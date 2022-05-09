using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void RateLockTest()
        {
            Console.Clear();

            _api.GetLoanGuidAsync(UseThisLoan).Wait();
            if (_api.HasLoanGuid)
            {
                if (_api.GetFullLoanAsync().Result)
                {
                    //Console.WriteLine("--- Rate Lock Requests --- ")
                    //        var locks = loan.GetRateLockRequest();

                    //var mmm = loan.GetRateLockRequest("b33473bc-5017-4dd7-b624-099864fb622d");
                    //var lll = loan.GetRateLockShapshot("b33473bc-5017-4dd7-b624-099864fb622d");

                    //var dd = loan.GetResourceLockList();

                    //Console.WriteLine(loan.GetCurrentLockBy());

                }
                else
                    Console.WriteLine($"Unable to load loan {UseThisLoan} on instance {_instanceId}");
            }
            else
                Console.WriteLine($"Unable to get guid for loan {UseThisLoan} on instance {_instanceId}");


        }

    }
}
