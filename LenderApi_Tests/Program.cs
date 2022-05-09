using ICE.SDKtoAPI;
using System;

namespace LenderApi_Tests
{
    public partial class Program
    {
        public static LenderAPI _api;

        public static string _instanceId = string.Empty;
        public static string _apiClientId = string.Empty;
        public static string _userName = string.Empty;
        public static string _password = string.Empty;
        public static string _secret = string.Empty;
        public static string _loanNumber = string.Empty;
        public static string _loanGuid = string.Empty;
        public static string _fromFolder = string.Empty;
        public static bool _dtc = true;
        public static string _env = string.Empty;

        public static string UseThisLoan => _loanNumber;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Sample Application to try various features in new LenderApi Library,");
                Console.WriteLine("          FrameworkAPI library, and new Email API Library");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("0. Set Program for Upgrade QA");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("1. Set Program for DEV");
                Console.WriteLine("2. Set Program for QA");
                Console.WriteLine("3. Set Program for UAT");
                Console.WriteLine("4. Set Program for DEV - TPO");
                Console.WriteLine("5. Set Program for QA - TPO");
                Console.WriteLine("6. Set Program for UAT - TPO");
                Console.WriteLine("7. Set Program for Prod");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("10. Lender API Tests");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("20 Test Bed");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("30 Generate V3 Loan Schema");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("99 Exit");
                try
                {
                    var opt = Convert.ToInt32(Console.ReadLine());
                    if (opt == 99)
                        break;
                    else
                    {
                        switch (opt)
                        {
                            case 0:
                                SetUpgradeQa();
                                break;
                            case 1:
                                SetDev();
                                break;
                            case 2:
                                SetQa();
                                break;
                            case 3:
                                SetUat();
                                break;
                            case 4:
                                SetDevTPO();
                                break;
                            case 5:
                                SetQaTPO();
                                break;
                            case 6:
                                SetUatTPO();
                                break;
                            case 7:
                                SetProd();
                                break;

                            case 10:
                                LenderApiMenu();
                                break;

                            case 20:
                                TestBedMenu();
                                break;

                            case 30:
                                GenerateContracts();
                                break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
        }

        static void Output(string id)
        {
            try
            {
                Console.WriteLine($"[{id}] -> " + _api.Fields[id]);
            }
            catch (Exception e)
            {
                Console.WriteLine(id + " --> " + e.Message);
            }
        }
        static void Output<T>(string id)
        {
            Console.WriteLine($"[{id}] -> " + _api.Field<T>(id));
        }
    }
}
