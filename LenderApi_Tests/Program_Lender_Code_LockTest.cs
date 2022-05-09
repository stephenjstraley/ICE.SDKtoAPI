using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void LockTest()
        {
            Console.Clear();

            _api.GetLoanGuidAsync(UseThisLoan).Wait();
            Console.WriteLine(_api.LoanGuid);
            Console.WriteLine(_api.GetApplicationId(_api.LoanGuid, 1).Result);
            var qLock = _api.UnlockLoanAsync(_api.LoanGuid, true).Result;
            Console.WriteLine(qLock);

            if (_api.HasLoanGuid)
            {
                Console.WriteLine("--- Rate Lock Summary Requests ---");
                var req = _api.GetRateLockSummaryRequestsAsync().Result;
                foreach (var r in req)
                    Console.WriteLine(r.LockStatus);


                Console.WriteLine("--- Locking and Unlocking Loan ---");
                var worked = _api.LockLoanAsync(_api.LoanGuid, true).Result;
                Console.WriteLine(worked);
                if (worked)
                    Console.WriteLine(_api.LastLoanLockId);

                worked = _api.UnlockLoanAsync(_api.LoanGuid, true).Result;
                Console.WriteLine(worked);
                Console.WriteLine(_api.IsLoanLocked);


                Console.WriteLine("--- Resource Lock List ---");
                var list = _api.GetResourceLockListAsync().Result;
                foreach (var item in list)
                    Console.WriteLine($"{item.Id} - {item.Resource.EntityType} - {item.LockType} ");

                _api.Unlock();

                Console.WriteLine();
                Console.WriteLine("--- Resource Lock List ---");
                list = _api.GetResourceLockListAsync().Result;
                foreach (var item in list)
                    Console.WriteLine($"{item.Id} - {item.Resource.EntityType} - {item.LockType} ");

                _api.Lock();

                Console.WriteLine();
                Console.WriteLine("--- Resource Lock List ---");
                list = _api.GetResourceLockListAsync().Result;
                foreach (var item in list)
                    Console.WriteLine($"{item.Id} - {item.Resource.EntityType} - {item.LockType} ");

                #region Rate Lock Requests
                Console.WriteLine();
                Console.WriteLine("---------- Rate Lock Requests ------------");
                var locks = _api.GetResourceLockListAsync(_api.LoanGuid).Result;
                if (locks != null)
                {
                    if (locks.Count == 0)
                        Console.WriteLine("No Resource Locks");
                    else
                    {
                        foreach (var i in locks)
                            Console.WriteLine(i.LockType + " - " + i.Resource + " - " + i.Userid);
                    }
                }
                #endregion

                #region Resource Lock List
                Console.WriteLine();
                Console.WriteLine("--- Resource Lock List ---");
                list = _api.GetResourceLockListAsync().Result;
                foreach (var item in list)
                    Console.WriteLine($"{item.Id} - {item.Resource.EntityType} - {item.LockType} ");
                #endregion

            }
            else
                Console.WriteLine($"Unable to get guid for loan {UseThisLoan} on instance {_instanceId}");

        }
    }
}
