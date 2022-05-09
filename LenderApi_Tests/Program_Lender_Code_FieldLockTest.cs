using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void FieldLockTest()
        {
            Console.Clear();
            _api.GetLoanGuidAsync(UseThisLoan).Wait();
            if (_api.HasLoanGuid)
            {
                if (_api.GetFullLoanAsync().Result)
                {
                    Console.WriteLine("----- Unlocking a locked field -----");
                    Output("137");
                    //if (_api.UnLockFields("137"))

                    //    _api.Fields["137"] = 34;
                    //    _api.UpdateLoan();
                    //    _api.LockFields("137");
                    //}

                    Console.WriteLine();
                    Console.WriteLine("----- Locking Batch Fields -----");
                    //var ids = new List<string>() { "61", "30" };
                    //if (loan.Unlock())
                    //{
                    //    if (loan.UnLockFields(ids))
                    //    {
                    //        loan.Fields["61"] = 34;   // 2265.88
                    //        loan.Fields["30"] = e30.Made;
                    //        loan.UpdateLoan();
                    //        loan.LockFields(ids);
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine(loan.LastErrorMsg);
                    //    }
                    //}


                    Console.WriteLine();
                    Console.WriteLine("----- Locking a Field -----");
                    //if (loan.LockFields("61"))
                    //{
                    //    loan.Fields["61"] = 34;   // 2265.88                            
                    //    loan.UpdateLoan();
                    //    loan.UnLockFields("61");
                    //}


                }
                else
                    Console.WriteLine($"Unable to load loan {UseThisLoan} on instance {_instanceId}");
            }
            else
                Console.WriteLine($"Unable to get guid for loan {UseThisLoan} on instance {_instanceId}");


        }

    }
}
