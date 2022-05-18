using ICE.SDKtoAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        public static void LenderApiMenu()
        {
            using (_api = new LenderAPI(_instanceId, _apiClientId, _userName, _password, _secret))
            {
                _api.GetTokenAsync().Wait();

                if (_api.HasAccessToken)
                {
                    while(true)
                    {
                        Console.Clear();
                        Console.WriteLine($"Lender API Tests - {_env}");
                        Console.WriteLine("----------------");
                        Console.WriteLine("1. User Personas and Roles                  2. All Field Values");
                        Console.WriteLine("3. Custom Field Canonical Names             4. Milestones and Associates");
                        Console.WriteLine("5. Underwriters and Conditions              6. Create, Set and Delete Loan");
                        Console.WriteLine("7. Loan Lock Tests                          8. Custom Field Test");
                        Console.WriteLine("9. Borrower Pairs                           10. Field Lock Test");
                        Console.WriteLine("11. Rate Lock Test                          12. Field Condition Tests");
                        Console.WriteLine("13. Documents and Attachments               14. Folders");
                        Console.WriteLine("15. Settings                                16. Field Schema");
                        Console.WriteLine("17. Token Test                              18. Enhanced Conditions");
                        Console.WriteLine("19. WebHooks                                20. Raw Get Loan");
                        Console.WriteLine("21. Residences and More                     22. V3 Loan Schema");

                        // Test Mismo
                        // Test Enhaced Conditions
                        // Test Loan Templaes / External Users/ External Orgs
                        // Enhanced Coniditoins Settings
                        // Enhanced Conditions

                        // Show Loan Sub Collections = VoS, VOLs REOS et cetera

                        Console.WriteLine();
                        Console.WriteLine("50. Queries");
                        Console.WriteLine();
                        Console.WriteLine("60. Scratch Pad");
                        Console.WriteLine();

                        Console.WriteLine("99. Return to Main Menu");

                        try
                        {
                            var opt = Convert.ToInt32(Console.ReadLine());
                            if (opt == 99)
                                break;
                            else
                            {
                                switch (opt)
                                {
                                    case 1:
                                        UsersAndRoles();
                                        break;
                                    case 2:
                                        AllLoanFieldValues();
                                        break;
                                    case 3:
                                        CustomFieldsConicalNames();
                                        break;
                                    case 4:
                                        MilestonesAssociates();
                                        break;
                                    case 5:
                                        UnderWritersAndConditions();
                                        break;
                                    case 6:
                                        CreateAndDeleteLoan();
                                        break;
                                    case 7:
                                        LockTest();
                                        break;
                                    case 8:
                                        CustomFieldTest();
                                        break;
                                    case 9:
                                        BorrowerPairs();
                                        break;
                                    case 10:
                                        FieldLockTest();
                                        break;
                                    case 11:
                                        RateLockTest();
                                        break;
                                    case 12:
                                        FieldConditionTest();
                                        break;
                                    case 13:
                                        DocumentAndAttachmentsTest();
                                        break;
                                    case 14:
                                        Folders();
                                        break;
                                    case 15:
                                        Settings();
                                        break;
                                    case 16:
                                        FieldSchema();
                                        break;
                                    case 17:
                                        TokenTest();
                                        break;
                                    case 18:
                                        EnhancedConditions();
                                        break;
                                    case 19:
                                        WebHooks();
                                        break;
                                    case 20:
                                        LoanTest();
                                        break;
                                    case 21:
                                        ResidencesAndMore();
                                        break;
                                    case 22:
                                        V3LoanSchema();
                                        break;

                                    case 50:
                                        LenderApiQueryMenu();
                                        break;
                                    case 60:
                                        ScratchPad();
                                        break;
                                }

                                Console.WriteLine();
                                Console.WriteLine("Any key to continue");
                                Console.ReadKey();
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
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Unable to obtain ACCESS TOKEN for instance {_instanceId}");
                    Console.WriteLine($"Error: {_api.LastMessage}");
                    Console.WriteLine();
                    Console.WriteLine("ENTER to continue");
                    Console.ReadLine();
                }
            }
        }
    }
}
