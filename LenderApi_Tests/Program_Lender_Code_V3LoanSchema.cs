using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void V3LoanSchema()
        {
            Console.Clear();

            var schema = _api.GetV3LoanSchemaAsync().Result;

            if (_api.IsOkStatus)
            {
                Console.WriteLine(JsonConvert.SerializeObject(schema));
            }
        }

    }
}
