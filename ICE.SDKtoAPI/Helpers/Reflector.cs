using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace ICE.SDKtoAPI.Helpers
{
    public struct ConversionResult
    {
        public Boolean Success;
        public object ConvertedValue;
    }
    public static class Reflector
    {
        private static readonly BindingFlags DefaultBindings = BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic;

        public static object GetValue(object source, string codeToExec)
        {
            var reflectRes = GetReflectorResult(source, codeToExec, true, false);
            if (reflectRes != null) return reflectRes.Value;

            return null;
        }
        public static bool SetVaue(object source, string codeToExec, object value) => SetValue(source, codeToExec, value, false);
        public static bool SetValue(object source, string codeToEx, object value, bool createIfNoExists)
        {
            var executed = false;

            var reflectorResults = GetReflectorResult(source, codeToEx, false, createIfNoExists);
            if (reflectorResults != null)
            {
                TypeConverter typeConverter = null;
                var propertInfo = reflectorResults.MemberInfo as PropertyInfo;
                if (propertInfo != null)
                {
                    if (propertInfo.CanWrite)
                    {
                        typeConverter = GetTypeConverter(propertInfo);
                        var conversionResult = ConvertValue(value, propertInfo.PropertyType, typeConverter);
                        if (conversionResult.Success)
                            propertInfo.SetValue(reflectorResults.PreviousValue, conversionResult.ConvertedValue, reflectorResults.MemberInfoParameters);
                        else
                            executed = false;
                    }
                }
                else
                {
                    var fieldInfo = reflectorResults.MemberInfo as FieldInfo;
                    if (fieldInfo != null)
                    {
                        typeConverter = GetTypeConverter(fieldInfo);
                        var conversionResult = ConvertValue(value, fieldInfo.FieldType, typeConverter);
                        if (conversionResult.Success)
                            fieldInfo.SetValue(reflectorResults.PreviousValue, conversionResult.ConvertedValue);
                        else
                            executed = false;
                    }
                    else
                        executed = false;
                }
            }
            else
                executed = false;

            return executed;
        }
        public static void RunDynamicCode(object source, string codeToExecute) => GetReflectorResult(source, codeToExecute, true, false);
        public static object ExecuteMethod(object source, string methodName, object[] parameters)
        {
            if (parameters == null)
                parameters = new object[0];

            var methodInfs = GetMethods(source, methodName);

            foreach (var methodInfo in methodInfs)
            {
                object[] convertedParameters = GetParameters(methodInfo, parameters);
                if (convertedParameters != null)
                    return methodInfo.Invoke(source, convertedParameters);
            }
            return null;
        }
        public static object ExecuteMethod(object source, string methodName, object parameter) => ExecuteMethod(source, methodName, new object[] { parameter });
        public static object ExecuteMethod(object source, string methodName) => ExecuteMethod(source, methodName, null);
        public static void CopyObject(object source, object target)
        {
            if (source != null && target != null)
            {
                var targetType = target.GetType();
                var sourceType = source.GetType();

                PropertyInfo[] properties = sourceType.GetProperties(DefaultBindings);
                foreach (var sourceProperty in properties)
                {
                    var targetProperty = targetType.GetProperty(sourceProperty.Name, sourceProperty.PropertyType);
                    if (targetProperty != null && targetProperty.CanRead && targetProperty.CanWrite)
                    {
                        object value = sourceProperty.GetValue(source, null);
                        targetProperty.SetValue(target, value, null);
                    }
                }

                FieldInfo[] fields = sourceType.GetFields(DefaultBindings);
                foreach (var sourceField in fields)
                {
                    var targetField = targetType.GetField(sourceField.Name);
                    if (targetField != null && targetField.IsPublic)
                    {
                        object value = sourceField.GetValue(source);
                        targetField.SetValue(target, value);
                    }
                }
            }
        }
        public static ConversionResult ConvertValue(object value, Type type, TypeConverter typeConverter)
        {
            var conversionResult = new ConversionResult
            {
                Success = false
            };

            if (value != null && type != null)
            {
                var objectType = value.GetType();
                if (objectType == type)
                {
                    conversionResult.Success = true;
                    conversionResult.ConvertedValue = value;
                }
                else
                {
                    if (typeConverter != null && typeConverter.CanConvertFrom(objectType))
                    {
                        try
                        {
                            conversionResult.ConvertedValue = typeConverter.ConvertFrom(value);
                            conversionResult.Success = true;
                        }
                        catch (FormatException) { }
                        catch (Exception e)
                        {
                            if (!(e.InnerException is FormatException))
                                throw;
                        }
                    }
                    else
                    {
                        try
                        {
                            conversionResult.ConvertedValue = Convert.ChangeType(value, type, CultureInfo.CurrentCulture);
                            conversionResult.Success = true;
                        }
                        catch (InvalidCastException) { }
                    }
                }
            }
            return conversionResult;
        }
        public static bool CanCreateObject(string classPath, Assembly assembly, params object[] parameters)
        {
            var canCreate = false;
            var type = Type.GetType(classPath);
            if (type == null)
            {
                var pathWithAssembly = classPath + ", " + assembly.FullName;
                type = Type.GetType(pathWithAssembly);
            }

            if (type != null)
            {
                foreach (var ci in type.GetConstructors())
                {
                    if (ci.IsPublic)
                    {
                        ParameterInfo[] constructorParameters = ci.GetParameters();
                        if (constructorParameters.Length == parameters.Length)
                        {
                            for (var i = 0; i < constructorParameters.Length; i++)
                            {
                                object parameter = parameters[i];
                                if (parameter == null) continue;

                                var pi = constructorParameters[i];
                                if (!pi.ParameterType.IsAssignableFrom(parameter.GetType())) break;
                            }
                            canCreate = true;
                            break;
                        }
                    }
                }
            }
            return canCreate;
        }
        public static object CreateObject(string classPath, Assembly assembly, params object[] parameters)
        {
            var type = Type.GetType(classPath);
            if (type == null)
            {
                var pathWithAssembly = classPath + ", " + assembly.FullName;
                type = Type.GetType(pathWithAssembly);
            }
            if (type == null) return null;

            return Activator.CreateInstance(type, parameters);
        }
        private static ReflectorResult GetReflectorResult(object source, string codeToExecute, bool getLastValue, bool createIdNotExists)
        {
            var result = new ReflectorResult(source);

            try
            {
                string[] codeFragments = SplitCodeArray(codeToExecute);
                for (var i = 0; i < codeFragments.Length; i++)
                {
                    if (result.Value == null) return result;

                    var codeFragment = codeFragments[i];
                    result.PreviousValue = result.Value;

                    if (codeFragment.Contains("]"))
                    {
                        ProcessArray(result, codeFragment, createIdNotExists);
                    }
                    else if (codeFragment.Contains(")"))
                    {
                        ProcessMethod(result, codeFragment);
                    }
                    else
                    {
                        bool retrieveValue = getLastValue;
                        if (!retrieveValue)
                            retrieveValue = i + 1 != codeFragments.Length;

                        ProcessProperty(result, codeFragment, retrieveValue);
                    }
                }
            }
            catch { }

            return result;
        }
        private static string[] SplitCodeArray(string codeToExecute)
        {
            var items = new List<string>();

            var parenAndBracketCount = 0;
            var buffer = "";

            foreach (var c in codeToExecute.ToCharArray())
            {
                if (c == '.')
                {
                    if (buffer.Length > 0)
                    {
                        items.Add(buffer);
                        buffer = "";
                    }
                    continue;
                }
                else if (c == '[')
                {
                    parenAndBracketCount += 1;
                    if (buffer.Length > 0)
                        items.Add(buffer);

                    buffer = c.ToString();
                }
                else if (c == ']' || c == ')')
                {
                    parenAndBracketCount -= 1;
                    buffer += c;
                    if (buffer.Length > 0)
                    {
                        items.Add(buffer);
                        buffer = "";
                    }
                }
                else if (char.IsWhiteSpace(c) || char.IsControl(c))
                {
                    if (parenAndBracketCount == 0)
                        continue;
                    else
                        buffer += c;
                }
                else if (c == '(')
                {
                    parenAndBracketCount += 1;
                    buffer += c;
                }
                else
                    buffer += c;
            }

            if (buffer.Length > 0)
                items.Add(buffer);

            return items.ToArray();
        }
        private static object[] GetParameters(string codeFragment, MemberInfo memberInfo)
        {
            var parameters = SplitParametersForMethod(codeFragment);
            if (string.IsNullOrEmpty(parameters))
                return new object[0];

            object[] parameterArray = parameters.Split(',');
            return GetParameters(memberInfo, parameterArray);
        }
        private static object[] GetParameters(MemberInfo memberInfo, object[] parameterArray)
        {
            ParameterInfo[] parameterInfo = null;
            TypeConverter typeConverter = null;

            var propertyInfo = memberInfo as PropertyInfo;
            if (propertyInfo != null)
            {
                parameterInfo = propertyInfo.GetIndexParameters();
                typeConverter = GetTypeConverter(parameterInfo[0]);
            }
            else
            {
                var methodInfo = memberInfo as MethodInfo;
                if (methodInfo != null)
                    parameterInfo = methodInfo.GetParameters();
            }

            if (parameterInfo == null) return null;

            object[] returnParameters = new object[parameterInfo.Length];
            for (var i = 0; i < parameterArray.Length; i++)
            {
                var converstionResult = ConvertValue(parameterArray[i], parameterInfo[i].ParameterType, typeConverter);
                if (converstionResult.Success)
                    returnParameters[i] = converstionResult.ConvertedValue;
                else
                    return null;
            }
            return returnParameters;
        }
        private static TypeConverter GetTypeConverter(MemberInfo memberInfo, Type targetType)
        {
            object[] typeConverters = memberInfo.GetCustomAttributes(typeof(TypeConverterAttribute), true);
            if (typeConverters.Length > 0)
            {
                var typeConverterAttribute = (TypeConverterAttribute)typeConverters[0];
                var typeFromName = Type.GetType(typeConverterAttribute.ConverterTypeName);
                if ((typeFromName != null) && typeof(TypeConverter).IsAssignableFrom(typeFromName))
                    return (TypeConverter)Activator.CreateInstance(typeFromName);
            }
            return TypeDescriptor.GetConverter(targetType);
        }
        private static TypeConverter GetTypeConverter(PropertyInfo propertyInfo) => GetTypeConverter(propertyInfo, propertyInfo.PropertyType);
        private static TypeConverter GetTypeConverter(FieldInfo fieldInfo) => GetTypeConverter(fieldInfo, fieldInfo.FieldType);
        private static TypeConverter GetTypeConverter(ParameterInfo parameterInfo) => GetTypeConverter(parameterInfo.Member, parameterInfo.ParameterType);
        private static ArrayDefinition GetArrayDefinition(object value, string codeToExec)
        {
            var retrieveMemberInfos = new List<MemberInfo>();
            foreach (var propertyInfo in value.GetType().GetProperties(DefaultBindings))
            {
                if (propertyInfo.Name == "Item")
                {
                    retrieveMemberInfos.Add(propertyInfo);
                }
            }

            if (retrieveMemberInfos.Count == 0)
            {
                foreach (var methodInfo in value.GetType().GetMethods(DefaultBindings))
                {
                    if (methodInfo.Name == "GetValue")
                    {
                        retrieveMemberInfos.Add(methodInfo);
                    }
                }
            }

            foreach(var memberInfo in retrieveMemberInfos)
            {
                object[] parameters = GetParameters(codeToExec, memberInfo);
                if (parameters != null)
                {
                    return new ArrayDefinition
                    {
                        Parameters = parameters,
                        RetrieveMemberInfo = memberInfo
                    };
                }
            }
            return null;
        }
        private static void ProcessArray(ReflectorResult result, string frag, bool createIfNotExists)
        {
            var failCount = 0;
            var arrayDefinition = GetArrayDefinition(result.Value, frag);
            if (arrayDefinition != null)
            {
                var propertyInfo = arrayDefinition.RetrieveMemberInfo as PropertyInfo;
                if (propertyInfo != null)
                {
                    SetPropertyInfoValue:
                    try
                    {

                    }
                    catch(TargetInvocationException ex)
                    {
                        failCount++;
                        if (ex.InnerException is ArgumentOutOfRangeException && failCount == 1 && createIfNotExists)
                        {
                            if (CreateArrayItem(result, arrayDefinition))
                            {
                                goto SetPropertyInfoValue;
                            }
                        }

                        result.Clear();
                        throw new InvalidCodeFragmentException(frag);
                    }
                }
                else
                {
                    var methodInfo = arrayDefinition.RetrieveMemberInfo as MethodInfo;
                    if (methodInfo != null)
                    {
                        try
                        {
                            object value = methodInfo.Invoke(result.Value, arrayDefinition.Parameters);
                            result.SetResult(value, methodInfo, arrayDefinition.Parameters);
                        }
                        catch (TargetInvocationException)
                        {
                            result.Clear();
                            throw new InvalidCodeFragmentException(frag);
                        }
                    }
                }
            }
            else
            {
                result.Clear();
                throw new InvalidCodeFragmentException(frag);
            }
        }
        private static bool CreateArrayItem(ReflectorResult result, ArrayDefinition arrayDef)
        {
            var resultType = result.Value.GetType();
            Type containedType = null;
            if (resultType.IsArray)
                containedType = resultType.GetElementType();
            else
                containedType = resultType.GetGenericArguments()[0];

            object newInstance = Activator.CreateInstance(containedType);
            if (!resultType.IsArray)
            {
                MethodInfo[] methods = GetMethods(result.Value, "Insert");
                foreach (var info in methods)
                {
                    object[] temp = new object[arrayDef.Parameters.Length + 1];
                    arrayDef.Parameters.CopyTo(temp, 0);
                    temp[arrayDef.Parameters.Length] = newInstance;

                    object[] parameters = GetParameters(info, temp);
                    if (parameters != null)
                    {
                        info.Invoke(result.Value, parameters);
                        return true;
                    }
                }
            }
            return false;
        }
        private static void ProcessProperty(ReflectorResult result, string frag, bool retrieveVal)
        {
            var propInfo = result.Value.GetType().GetProperty(frag, DefaultBindings);
            if (propInfo != null)
            {
                object value = result.Value;
                if (retrieveVal)
                {
                    value = propInfo.GetValue(result.Value, null);
                    result.SetResult(value, propInfo, null);
                }
                result.SetResult(value, propInfo, null);
            }
            else
            {
                var fieldInfo = result.Value.GetType().GetField(frag, DefaultBindings);
                if (fieldInfo != null)
                {
                    object value = result.Value;
                    if (retrieveVal)
                        value = fieldInfo.GetValue(result.Value);

                    result.SetResult(value, fieldInfo, null);
                }
                else
                {
                    result.Clear();
                    throw new InvalidCodeFragmentException(frag);
                }
            }
        }
        private static void ProcessMethod(ReflectorResult result, string frag)
        {
            var name = frag.Substring(0, frag.IndexOf('('));
            MethodInfo[] methodInfos = GetMethods(result.Value, name);

            foreach(var info in methodInfos)
            {
                object[] parameters = GetParameters(frag, info);
                if (parameters != null)
                {
                    object value = info.Invoke(result.Value, parameters);
                    result.SetResult(value, null, null);
                    break;
                }
            }
        }
        private static string SplitParametersForMethod(String fragment)
        {
            char startChar = '[';
            char endChar = ']';

            if (fragment.EndsWith(")", StringComparison.CurrentCulture))
            {
                startChar = '(';
                endChar = ')';
            }

            var startParm = fragment.IndexOf(startChar) + 1;
            if (startParm < 1) return null;

            var endParm = fragment.IndexOf(endChar);
            return endParm < 0 ? null : fragment.Substring(startParm, endParm = startParm).Trim();
        }
        private static MethodInfo[] GetMethods(object value, string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("methodName");

            if (value == null) return new MethodInfo[0];

            var infos = new List<MethodInfo>();
            foreach(var info in value.GetType().GetMethods(DefaultBindings))
            {
                if (info.Name == name)
                    infos.Add(info);
            }
            return infos.ToArray();
        }

        private class ArrayDefinition
        {
            public MemberInfo RetrieveMemberInfo { get; set; }
            public object[] Parameters { get; set; }
        }

        private class ReflectorResult
        {
            public ReflectorResult(object startValue)
            {
                SetResult(startValue, null, null);
            }
            public MemberInfo MemberInfo { get; private set; }
            public object[] MemberInfoParameters { get; private set; }
            public object PreviousValue { get; set; }
            public object Value { get; private set; }

            public void SetResult(object value, MemberInfo info, object[] infoParms)
            {
                Value = value;
                MemberInfo = info;
                MemberInfoParameters = infoParms;
            }

            public void Clear() 
            {
                Value = null;
                MemberInfo = null;
                PreviousValue = null;
            }
        }

        [Serializable]
        [SuppressMessage("Microsoft.Design", "CA1064:ExcentionsShouldBePublic")]
        [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors")]
        private class InvalidCodeFragmentException : Exception
        {
            public InvalidCodeFragmentException(String invalidFragment) : base(invalidFragment)
            { }
            
        }
    }
}
