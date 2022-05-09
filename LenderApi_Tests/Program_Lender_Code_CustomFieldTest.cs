using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void CustomFieldTest()
        {
            Console.Clear();
            _api.GetLoanGuidAsync(UseThisLoan).Wait();

            if (_api.HasLoanGuid)
            {
                if (_api.GetFullLoanAsync().Result)
                {
                    Console.WriteLine("---- Custom Fields ---- ");
                    var customs = _api.GetCustomFieldsAsync().Result;
                    foreach (var customField in customs)
                        Output(customField.Id);

                    Console.WriteLine();
                    Console.WriteLine("--- Display Specific Fields ---");
                    Console.WriteLine($"Filed UWID: {_api.Fields["UWID"]}");
                    Console.WriteLine($"Field 984: {_api.Fields["984"]}");
                    Console.WriteLine($"Field 137: {_api.Fields["137"]}");
                    Console.WriteLine($"Field 4000#1: {_api.Fields["4000#1"]}");
                    Console.WriteLine($"Field 762: {_api.Fields["762"]}");

                    Console.WriteLine();
                    Console.WriteLine("--- Update Specific Field ---");
                    _api.Fields["CX.RECORDED.FOLDERS"] = "FOO";

                    Console.WriteLine();
                    Console.WriteLine("--- Update Regular Field ---");
                    Output("FICO");
                    Output("UWC.NOTCLEARED");
                    Output("LOCKRATE.FULFILLEDDATETIME");

                    Output("137");
                    _api.Fields["137"] = 34;   // 2703.73

                    Output("4000");
                    _api.Fields["4000#1"] = "NewStuff";   // 2703.73

                    ///TODO
                    //                        loan.Fields["26"] = 4000;
                    //                        loan.UpdateLoan();

                    //                        loan.Fields["CX.FIELD_IS_BAD"] = "Yep";
                    //                        loan.Fields["CX.CL.FNMA.BORR.FUNDS.1"] = false;

                    //                        Output("479");                       
                    //                        loan.Fields["479"] = e479.Empty;
                    //                        Output("662");                       
                    //                        loan.Fields["662"] = e622.Initial;
                    //                        Output("411");
                    //                        loan.Fields["411"] = "My Test Company";


                    _api.UpdateLoanAsync().Wait();

                }
                else
                    Console.WriteLine($"Unable to load loan {UseThisLoan} on instance {_instanceId}");
            }
            else
                Console.WriteLine($"Unable to get guid for loan {UseThisLoan} on instance {_instanceId}");

        }

    }
}
