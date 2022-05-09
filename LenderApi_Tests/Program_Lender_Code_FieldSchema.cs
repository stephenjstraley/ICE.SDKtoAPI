using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void FieldSchema()
        {
            Console.Clear();
            Console.WriteLine("---- Field Schema ----");
            var theList = new List<ICE.SDKtoAPI.LenderApiContractsV3.FieldSchemaContract>();
            var start = 0;
            var limit = 6000;
            bool firstTime = true;
            while (true)
            {
                Console.WriteLine($"Getting {start} - field count at {theList.Count}");
                var items = _api.GetV3FieldSchemaAsync(start, limit).Result;
                if (items.Count != 0)
                {
                    start += limit + (firstTime ? 1 : 0);
                    firstTime = false;
                    theList.AddRange(items);
                }
                else
                    break;
            }

            using (var writer = new StreamWriter(@"C:\temp\fieldlist.txt"))
            {
                foreach (var item in theList)
                {
                    Console.WriteLine($"{item.Id} - {item.Format}");
                    writer.WriteLine($"{item.Id} - {item.Format} - {item.DataType} - {item.ContractPath}");
                }
            }

            //            System.IO.File.WriteAllText(@"C:\temp\export.xml", contents);

        }

    }
}
