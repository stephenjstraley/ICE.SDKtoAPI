using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void UnderWritersAndConditions()
        {
            Console.Clear();

            _api.GetLoanGuidAsync(UseThisLoan).Wait();

            if (_api.HasLoanGuid)
            {
                Console.WriteLine("---------- Underwriting Conditions ------------");
                var uwc = _api.GetUnderwritingConditionsAsync().Result;
                if (uwc != null)
                {
                    if (uwc.Count == 0)
                        Console.WriteLine("No Underwriting Conditions");
                    else
                    {
                        foreach (var i in uwc)
                            Console.WriteLine(i.Title);
                    }
                }
                else
                    Console.WriteLine("Unable to get conditions");
            }
            else
                Console.WriteLine($"Unable to get guid for loan {UseThisLoan} on instance {_instanceId}");
        }

    }
}
