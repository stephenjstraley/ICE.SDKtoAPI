using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ICE.SDKtoAPI.Extensions
{
    public static class Extensions
    {
        public static string ToStringNullSafe(this object value) => (value ?? string.Empty).ToString();
        public static string ToStringNullSafe(this object value, int places)
        {
            if (string.IsNullOrEmpty((string)value)) return string.Empty;
            else
            {
                try
                {
                    var fmt = "{0:N" + places + "}";
                    decimal newValue = Convert.ToDecimal((string)value);
                    return string.Format(fmt, newValue);
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(value);
                    System.Diagnostics.Debug.WriteLine(e.Message);
                    return (string)value;
                }
            }
        }
        public static DateTime? ToDate(this object value)
        {
            if (value == null) return null;
            else return Convert.ToDateTime(value);
        }
        public static bool IsYes(this object value) => value.ToStringNullSafe().ToUpper() == "Y";
        public static bool IsNo(this object value) => value.ToStringNullSafe().ToUpper() == "N";
        public static bool IsEmpty(this object value) => string.IsNullOrEmpty(value.ToStringNullSafe());
        public static string UnformattedValue(this object value) => ToStringNullSafe(value);
        public static bool Is(this object value, string compare) => value.ToStringNullSafe().Equals(compare, StringComparison.OrdinalIgnoreCase);
        public static T ReceiveJson<T>(this HttpResponseMessage resp)
        {
            if (resp != null)
            {
                var content = resp.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrEmpty(content)) 
                    return JsonConvert.DeserializeObject<T>(content);

            }
            return default(T);
        }
        public static StringBuilder AppendEnd(this StringBuilder s, object item1, object item2) => s.AppendEnd($"{item1} {item2}");
        public static StringBuilder AppendEnd(this StringBuilder s, object item) => s.Append($"{item}\n");
        public static StringBuilder StartClass(this StringBuilder s, string className) => s.Append($"class {className} {{\n");
        public static StringBuilder EndClass(this StringBuilder s) => s.Append("}\n");
    }
}
