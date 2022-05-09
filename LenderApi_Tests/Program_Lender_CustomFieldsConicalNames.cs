using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void CustomFieldsConicalNames()
        {
            Console.Clear();
            Console.WriteLine("---- Canonical Names ----- ");
            var def = _api.GetPipelineCanonicalNamesAsync().Result;
            foreach (var field in def.Fields)
                Console.WriteLine(field.Name);
        }
    }
}
