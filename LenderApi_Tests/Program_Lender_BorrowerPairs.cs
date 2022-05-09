using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void BorrowerPairs()
        {
            Console.Clear();
            _api.GetLoanGuidAsync(UseThisLoan).Wait();

            if (_api.HasLoanGuid)
            {
                if (_api.GetFullLoanAsync().Result)
                {
                    Console.WriteLine("---- Borrower Pairs ----");
                    var pairs = _api.GetAllBorrowerPairs();
                    foreach (var pair in pairs)
                    {
                        Console.WriteLine($"Borrower:  {pair.Borrower.LastName}, {pair.Borrower.FirstName} - {pair.Borrower.Id} ");
                        Console.WriteLine($"   CoBorrower:  {pair.Coborrower.LastName}, {pair.Coborrower.FirstName} - {pair.Coborrower.Id}");
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
