using ICE.SDKtoAPI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        const string GETSET = "{ get; set; }";

        public static void GenerateContracts()
        {
            using (_api = new LenderAPI(_instanceId, _apiClientId, _userName, _password, _secret))
            {
                _api.GetTokenAsync().Wait();

                if (_api.HasAccessToken)
                {
                    Console.Clear();
                    Console.Write("Enter Output Folder Name (leave blank for previous menu): ");
                    var folderName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(folderName))
                    {
                        if (folderName.EndsWith(@"\"))
                        {
                            folderName = folderName.Substring(0, folderName.Length - 1);
                        }
                        Console.WriteLine();
                        Console.Write("Enter Namespace for Contract Classes (leave blnak for previous menu): ");
                        var nameSpace = Console.ReadLine();
                        if (!string.IsNullOrEmpty(nameSpace))
                        {
                            // Make the Folder
                            bool canContinue = true;
                            if (!Directory.Exists(folderName))
                            {
                                Directory.CreateDirectory(folderName);
                                canContinue = Directory.Exists(folderName);
                            }
                            else
                                canContinue = true;

                            if (canContinue)
                            {
                                var schema = _api.GetLoanSchemaAsync("v3").Result;
                                if (_api.IsOkStatus)
                                {
                                    ProcessSchema(schema, folderName, nameSpace);
                                    Console.ReadKey();
                                }
                                else
                                    Console.WriteLine($"Unable to get schema : {_api.LastErrorMessage}");
                            }
                        }
                    }
                }
            }
        }

        public static void ProcessSchema(string schema, string folder, string ns)
        {
            dynamic rss = JObject.Parse(schema);
            dynamic items = rss.definitions;
            dynamic properties = rss.properties;

            Console.WriteLine();
            Console.Write("Creating Classes: ");

            #region Itterate through classes
            foreach (dynamic item in items)
            {
                var className = item.Name;
                //                    Console.Clear();
                using (StreamWriter wr = new StreamWriter($"{folder}\\{className}.cs"))
                {
                    ClassHeader(wr, className, ns);

                    //if (className == "AlertChangeCircumstanceContract")
                    //{
                    //    var asd = 1;
                    //}
                    #region properties
                    var world = JsonConvert.SerializeObject(item.Value);
                    world = world.Replace("$ref", "reference");
                    JToken props = (JToken)JsonConvert.DeserializeObject(world);

                    var i = props.Children();

                    foreach (JProperty classAttribute in i)
                    {
                        if (classAttribute.Name == "properties")
                        {
                            try
                            {
                                foreach (var property in classAttribute.Value)
                                {
                                    var newprop = property as JProperty;
                                    PropStruc tt = newprop.Value.ToObject<PropStruc>();

                                    wr.WriteLine($"        [DataMember(Name = \"{newprop.Name}\")]");

                                    if (tt.Type != null)
                                    {
                                        if (tt.Type.GetType().Name == "String")
                                        {
                                            var theType = tt.Type.ToString().ToUpper();
                                            switch (theType)
                                            {
                                                case "STRING":
                                                    wr.WriteLine($"        public string {ToUL(newprop.Name)} {GETSET}");
                                                    break;
                                                case "NUMBER":
                                                    wr.WriteLine($"        public decimal {ToUL(newprop.Name)} {GETSET}");
                                                    break;
                                                case "BOOLEAN":
                                                    wr.WriteLine($"        public bool {ToUL(newprop.Name)} {GETSET}");
                                                    break;
                                                case "INTEGER":
                                                    wr.WriteLine($"        public int {ToUL(newprop.Name)} {GETSET}");
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            JArray toCast = tt.Type as JArray;
                                            var theType = toCast[0].ToString().ToUpper();
                                            var nullable = (toCast[1].ToString().Contains("null") ? "?" : "");
                                            switch (theType)
                                            {
                                                case "STRING":
                                                    wr.WriteLine($"        public string {ToUL(newprop.Name)} {GETSET}");
                                                    break;
                                                case "NUMBER":
                                                    wr.WriteLine($"        public decimal{nullable} {ToUL(newprop.Name)} {GETSET}");
                                                    break;
                                                case "BOOLEAN":
                                                    wr.WriteLine($"        public bool{nullable} {ToUL(newprop.Name)} {GETSET}");
                                                    break;
                                                case "INTEGER":
                                                    wr.WriteLine($"        public int{nullable} {ToUL(newprop.Name)} {GETSET}");
                                                    break;
                                                case "OBJECT":
                                                    wr.WriteLine($"        public object {ToUL(newprop.Name)} {GETSET}");
                                                    break;
                                                case "ARRAY":
                                                    if (!string.IsNullOrEmpty(tt.ClassRefs.Reference))
                                                    {
                                                        var getClass = GetClassNameFromRef(tt.ClassRefs.Reference);
                                                        wr.WriteLine($"        public List<{ToUL(getClass)}> {ToUL(newprop.Name)} {GETSET}");
                                                    }
                                                    else
                                                    {
                                                        wr.WriteLine($"        public List<object> {ToUL(newprop.Name)} {GETSET}");
                                                    }
                                                    break;

                                            }
                                            //Console.WriteLine($"    {newprop.Name} => {toCast[0]} - {toCast[1]}");
                                        }
                                    }
                                    else  // there is a reference
                                    {
                                        wr.WriteLine($"        public string {ToUL(newprop.Name)} {GETSET}");
                                    }
                                    wr.WriteLine();

                                }
                            }
                            catch (Exception e)
                            {
                                var xxx = e; //                            // do by hand
                            }
                        }
                    }
                    #endregion

                    ClassFooter(wr);
                }
            }
            #endregion

            #region Loan Class
            using (StreamWriter wr = new StreamWriter($"{folder}\\LoanContract.cs"))
            {
                ClassHeader(wr, "LoanContract", ns);
                var loanStr = JsonConvert.SerializeObject(properties);
                loanStr = loanStr.Replace("$ref", "reference");
                JToken loanProps = (JToken)JsonConvert.DeserializeObject(loanStr);
                foreach (JProperty loanAttribute in loanProps.Children())
                {
                    var newprop = loanAttribute as JProperty;
                    PropStruc tt = newprop.Value.ToObject<PropStruc>();
                    wr.WriteLine($"        [DataMember(Name = \"{newprop.Name}\")]");

                    if (tt.Type != null)
                    {
                        JArray toCast = tt.Type as JArray;
                        var theType = toCast[0].ToString().ToUpper();
                        var nullable = (toCast[1].ToString().Contains("null") ? "?" : "");

                        switch (theType)
                        {
                            case "STRING":
                                wr.WriteLine($"        public string {ToUL(newprop.Name)} {GETSET}");
                                break;
                            case "NUMBER":
                                wr.WriteLine($"        public decimal{nullable} {ToUL(newprop.Name)}  {GETSET}");
                                break;
                            case "ARRAY":
                                if (!string.IsNullOrEmpty(tt.ClassRefs.Reference))
                                {
                                    var getClass = GetClassNameFromRef(tt.ClassRefs.Reference);
                                    wr.WriteLine($"        public List<{ToUL(getClass)}> {ToUL(newprop.Name)} {GETSET}");
                                }
                                else
                                {
                                    wr.WriteLine($"        public List<object> {ToUL(newprop.Name)} {GETSET}");
                                }
                                break;

                            case "BOOLEAN":
                                wr.WriteLine($"        public bool{nullable} {ToUL(newprop.Name)} {GETSET}");
                                break;
                            case "INTEGER":
                                wr.WriteLine($"        public int{nullable} {ToUL(newprop.Name)}  {GETSET}");
                                break;
                            case "OBJECT":
                                wr.WriteLine($"        public object {ToUL(newprop.Name)} {GETSET}");
                                break;
                        }
                    }
                    else
                    {
                        if (tt.Type == null && tt.ClassRefs == null)
                        {
                            var getRef = GetClassName(newprop.Value);
                            var getClass = GetClassNameFromRef(getRef.Item2);

                            wr.WriteLine($"        public {ToUL(getClass)} {ToUL(newprop.Name)} {GETSET}");
                        }
                    }
                    wr.WriteLine("");

                }
                ClassFooter(wr);
            }
            #endregion

        }

        static void ClassHeader(StreamWriter wr, string name, string ns)
        {
            Console.Write("*");

            wr.WriteLine("using System.Collections.Generic;");
            wr.WriteLine("using System.Runtime.Serialization;");
            wr.WriteLine("");
            wr.WriteLine($"namespace {ns}");
            wr.WriteLine("{");
            wr.WriteLine("    [DataContract]");
            wr.WriteLine($"    public class {name}");
            wr.WriteLine("    {");
        }
        static void ClassFooter(StreamWriter wr)
        {
            wr.WriteLine("    }");
            wr.WriteLine("}");
        }

        static string ToUL(string item) => item.Substring(0, 1).ToUpper() + item.Substring(1);

        static string GetClassNameFromRef(string theRef)
        {
            var items = theRef.Split("/");
            var theOne = items[items.Length - 1];
            theOne = theOne.Replace("}", "").Replace("\"", "");
            return theOne;
        }

        private static Tuple<string, string> GetClassName(JToken item)
        {
            var s = JsonConvert.SerializeObject(item);
            // Get name of class
            var ndx = s.IndexOf(":");
            var className = s.Substring(0, ndx).Replace("{", "").Trim().Replace("\"", "");
            var rest = s.Substring(ndx + 1).Trim();

            return new Tuple<string, string>(className, rest);
        }
    }

    [DataContract]
    public class PropStruc
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "type")]
        public object Type { get; set; }

        [DataMember(Name = "enum")]
        public object Enum { get; set; }

        [DataMember(Name = "additionalProperties")]
        public object AdditionalProperties { get; set; }

        [DataMember(Name = "maxLength")]
        public int MaxLength { get; set; } = 0;

        [DataMember(Name = "format")]
        public string Format { get; set; } = "";

        [DataMember(Name = "items")]
        public PropAdditional ClassRefs { get; set; }

    }
    public class PropAdditional
    {
        [DataMember(Name = "reference")]
        public string Reference { get; set; } = "";

        [DataMember(Name = "type")]
        public object Type { get; set; }
    }
}
