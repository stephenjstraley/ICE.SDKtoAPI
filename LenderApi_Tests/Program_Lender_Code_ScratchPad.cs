using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    { 
        static async void ScratchPad()
        {
            var token = _api.GetTokenAsync().Result;

            if (_api.Token != null)  // (loan.HasAccessToken)
            {
                var guid = _api.GetLoanGuidAsync("0550469290").Result;

                if (_api.HasLoanGuid)
                {

                    var fields = _api.GetAllFieldIdsAsync().Result;

                    foreach (var field in fields)
                    {
                        var schema = _api.GetV3FieldSchemaAsync(field).Result;
                        if (schema.Count == 1 && (schema[0]?.Options != null && schema[0]?.Options.Count > 0))
                        {
                            Console.WriteLine($"public class e{schema[0].Id}");   // Enums
                            Console.WriteLine("{");
                            foreach (var opt in schema[0].Options)
                            {
                                if (string.IsNullOrEmpty(opt.Value))
                                {
                                    Console.WriteLine($"    public static readingonly string Empty = \"\"");
                                }
                                else
                                {
                                    var val = opt.Value.Contains("/") ? opt.Value.Replace("/", "") : opt.Value;
                                    Console.WriteLine($"    public static readingonly string {val} = \"{opt.Value}\"");
                                }
                            }
                            Console.WriteLine("}");
                        }
                    }
                }
            }
        }

    }
}
