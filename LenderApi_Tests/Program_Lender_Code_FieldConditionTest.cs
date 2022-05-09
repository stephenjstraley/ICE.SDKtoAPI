using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void FieldConditionTest()
        {
            Console.Clear();
            _api.GetLoanGuidAsync(UseThisLoan).Wait();
            if (_api.HasAccessToken)
            {
                if (_api.GetFullLoanAsync().Result)
                {
                    Console.WriteLine("---- Check if Field is Defined ----");
                    if (_api.FieldDefined("3001"))
                    {
                        Console.WriteLine(_api.Fields["3001"]);
                        Console.WriteLine($"Description: {_api.FieldDescription("3001")}");
                        Console.WriteLine($"Read Only: {_api.FieldIsReadOnly("3001")}");
                        Console.WriteLine($"Field Locked: {_api.FieldIsLocked("3001")}");
                        Console.WriteLine($"Nullable: {_api.FieldIsNullable("3001")}");

                        //                        loan.FieldReadOnly["1863"];
                        //                        loan.FieldDataType["1863"];

                        //                        Output("1863");
                        //                        loan.Fields["1863"] = "No Name";

                        //                                                Output("3001");
                        //                        loan.Fields["3001"] = "MrCooper";

                        //                                                Output("CD3.X139");
                        //                        loan.Fields["CD3.X139"] = "Fee Description";  // READ ONLY

                        //                                                Output("DISCLOSURE.X560");
                        //                        loan.Fields["DISCLOSURE.X560"] = 100.00; // 73.18

                        // THERE IS A MAPPING ERROR!!!
                        //                        Output("DISCLOSURE.X1029");
                        //                        loan.Fields["DISCLOSURE.X1029"] = 1232;

                        //                                                Output("FV.X60");
                        //                        loan.Fields["FV.X60"] = "This is a new value"; // CLOSING PROTECTION LETTER

                        //                        Output("HUD1P1.X4");
                        //                        loan.Fields["HUD1P1.X4"] = 25.00;

                        //                        Output("NEWHUD2.X2546");
                        //                        loan.Fields["NEWHUD2.X2546"] = 800; // 700.00

                        //                        Output("101");
                        //                        loan.Fields["101"] = 10000; // 6500

                        //                        Output("183");
                        //                        loan.Fields["183"] = 34000;

                        //                        Output("271");
                        //                        loan.Fields["271"] = "New Description";
                        //                        Output("1417");
                        //                        loan.Fields["1417"] = "New City";  // Eugene

                        //                        Output("FE0102");
                        //                        loan.Fields["FE0102"] = "Mr. Cooper";  // amco

                        //                        Output("FM1084.X22");
                        //                        loan.Fields["FM1084.X22"] = 400.00; 

                        //                        Output("IRS4506.X4");
                        //                        loan.Fields["IRS4506.X4"] = "443-22-1123";

                        //                        Output("DISCLOSURE.X1029");
                        //                        loan.Fields["DISCLOSURE.X1029"] = "New Name";

                        //                        Output("BE0102");
                        //                        Output("HC0102");
                        //                        Output("BE0102");
                        //                        Output("HC0102");
                        //                        for (int i = 0; i < 9; i++)
                        //                          Output($"HUD0{i}01");

                        //                        loan.Fields["HUD0101"] = "01/01";  // 11/16
                        //                        Output("BE0003");
                        //                        Output("BE0102");
                        //                        Output("BE0302");

                        //                        Output("AR0036");

                        //                        loan.Fields["BE0003"] = "Attn: To Me"; // "Not Mr. Cooper";  // Mr. Cooper

                        //Output("AEA0001");
                        //Output("AEA0002");
                        //                        Output("AEA0003");
                        //                        Output("AEA0101");
                        //                        Output("AEA0201");

                        //loan.Fields["AEA0001"] = "11/20"; // 11/16
                        //                        loan.Fields["AEA0101"] = "12/20"; // 12/16

                        //loan.Fields["AEA0002"] = 100.00; // 465.21

                        //                        Output("BR0006");
                        //                        Output("BR0106");

                        //                        Output("DD0012");
                        //                        Output("DD0112");
                        //                        Output("DD0212");
                        //                        Output("DD0312");

                        //Output("DD1812");
                        //Output("DD1820");
                        //Output("DD1801");
                        //Output("DD1836");

                        //                        Output("DD1802");
                        //                        if (!loan.FieldIsReadOnly("DD1802"))
                        //                        {
                        //                            Console.WriteLine("Description: " + loan.FieldDescription("DD1802"));
                        //                            Console.WriteLine("Read Only: " + loan.FieldIsReadOnly("DD1802"));
                        //                            Console.WriteLine("Field Locked: " + loan.FieldIsLocked("DD1802"));

                        //                            loan.Fields["DD1802"] = "CooperSter"; // Bankster
                        //                        }

                        //                        Output("FL0002"); // WELLS FARGO HOME MORTG
                        //                        Output("FL0102"); // U.S. BANK
                        //                        loan.Fields["FL0102"] = "CHASE";

                        //                        Output("FM0004"); // 456 Test Address
                        //                        loan.Fields["FM0004"] = "678 Test Addres";

                        // None of the HUD dynamic fields are working
                        //Output("HUD0011"); // 2400
                        //loan.Fields["HUD0011"] = 2600.00;
                        //Output("HUD0001"); // 11/16
                        //loan.Fields["HUD0001"] = "11/21";

                        //                        Output("IR0025"); // 2015-12-31T00:00:00Z
                        //                        loan.Fields["IR0025"] = DateTime.Now;


                        //                        Output("NBOC0001"); // can't test this because we don't use it
                        //                        loan.Fields["NBOC0001"] = "Test";

                        //                        Output("NYFEES0001");  // can't test this because we don't use it
                        //                        loan.Fields["NYFEES0001"] = "My Last Name";

                        //                        Output("SP0002");
                        //                        loan.Fields["SP0002"] = "Service Provider Contract";

                        //                        Output("TA00DS");  // can't test this because we don't use it
                        //                        loan.Fields["TA00DS"] = "New Description";

                        //                        Output("TQL4506T0001");  // can't test this because we don't use it
                        //                        loan.Fields["TQL4506T0001"] = "123456";

                        //                        Output("TR0001"); // can't test this becaseu we don't have a closing document/closing entity of type = TRUSTEE
                        //                        loan.Fields["TR0001"] = "Unparsed Name";

                        //                        Output("UNFL0002");  // Can't test this because we don't use this
                        //                        loan.Fields["UNFL0002"] = "Adjustment Description";

                        //                        Output("XCOC0005");  // Can't test this because we don't use this
                        //                        loan.Fields["XCOC0005"] = "Changed Circumstance Description";

                        //                        Output("4000");
                        //                        loan.Fields["4000"] = "TestPerson";
                        //                        Output("CX.TEST");
                        //                        loan.Fields["CX.TEST"] = "For Stevieo";

                        //                        loan.UpdateLoan();

                        //                        loan.UpdateLoan();


                    }
                }
                else
                    Console.WriteLine($"Unable to load loan {UseThisLoan} on instance {_instanceId}");
            }
            else
                Console.WriteLine($"Unable to get guid for loan {UseThisLoan} on instance {_instanceId}");

        }

    }
}
