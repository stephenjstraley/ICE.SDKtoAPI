using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void AllLoanFieldValues()
        {
            Console.Clear();

            _api.GetLoanGuidAsync(UseThisLoan).Wait();
            if (_api.HasLoanGuid)
            {
                //                Console.WriteLine(_api.LoanGuid);

                if (_api.GetFullLoanAsync(false).Result)  // Load field dictionary up front (TRUE parameter)
                {
                    //Console.WriteLine();
                    //Console.WriteLine("---- stuff -----");

                    //                    Console.Write("Virtual Field Count: " + _api.VirtualFields.Count.ToString());
                    //                    foreach (var i in _api.VirtualFields)
                    //                        Console.WriteLine(i);

                    //Console.WriteLine("--- RAW Json ---");
                    //Console.WriteLine(_api.RawLoan);

                    var fieldIds = _api.GetAllFieldIdsAsync().Result;

                    //                    var temp = _api.GetAllFieldIdsAsync().Result;
                    //                    var cTot = _api.LastResponse.GetHeaderValue("X-Total-Count");

                    //                    Console.WriteLine($"Total number of regular fields is: {cTot}");
                    //                    Console.WriteLine();

                    //                    var x = _api.Fields["118"];

                    //Console.WriteLine($"[4000#1] -> " + _api.Fields["4000#1"]);

                    //CustomFields();

                    foreach (var id in fieldIds)
                    {
                        try
                        {
                            // N needs to be done
                            //if (!Char.IsLetter(id[0]))
                            //if (id.StartsWith("CX.TQLGSE0")) // || id.StartsWith("V") || id.StartsWith("W") || id.StartsWith("X"))
                            //{
                            var xx = _api.Fields[id];
                            //Output(id);
                            //}
                        }
                        catch (KeyNotFoundException e)
                        {
                            Console.WriteLine($"[{id}] -> Not found in dictionary = [{e.Message}]");
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine($"[{id}] -> {ex.Message}");
                        }
                    }

                    CustomFields();
                    //VirtualFields();

                    Console.WriteLine();
                    Console.WriteLine("---- Additional Tests ----- ");
                    Output("4000#1");
                    Output("FL0002");
                    Output("FL0102");
                    Output<int?>("1200");
                }
                else
                {
                    Console.WriteLine($"Unable to load loan {UseThisLoan} on instance {_instanceId}");
                    Console.WriteLine(_api.LastMessage);
                }
            }
            else
                Console.WriteLine($"Unable to get guid for loan {UseThisLoan} on instance {_instanceId}");

            void CustomFields()
            {
                Console.WriteLine();
                Console.WriteLine("---- Custom Fields ----- ");
                var customs = _api.GetCustomFieldsAsync().Result;
                foreach (var customField in customs)
                    Output(customField.Id);
            }
        }
    }
}
