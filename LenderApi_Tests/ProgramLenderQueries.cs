using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        public static void LenderApiQueryMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lender API Pipeline Query Tests");
                Console.WriteLine("----------------");
                Console.WriteLine("1. Cancel/Declined Loans");
                Console.WriteLine("2. Employee Loans - Adverse");
                Console.WriteLine("3. Funded Loans");
                Console.WriteLine("4. ReFi Loans");
                Console.WriteLine("5. Purchase Loans");
                Console.WriteLine("6. Prequal Purcahse Loans");


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
                                CancelDeclinedLoans();
                                break;
                            case 2:
                                EmployeeAdverseLoans();
                                break;
                            case 3:
                                FundedLoans();
                                break;
                            case 4:
                                RefiLoans();
                                break;
                            case 5:
                                PurchaseLoans();
                                break;
                            case 6:
                                PurchasePrequalLoans();
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
    }
}
