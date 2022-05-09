using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void LoanTest()
        {
            Console.Clear();

            var guid = _api.GetLoanGuidAsync(UseThisLoan).Result;
            if (!string.IsNullOrEmpty(guid) && _api.IsOkStatus)
            {
                var v1Loan = (ICE.SDKtoAPI.LenderApiContractsV1.LoanContract)_api.SetV1Loan().GetLoanAsync(guid).Result;
                var v3Loan = (ICE.SDKtoAPI.LenderApiContractsV3.LoanContract)_api.SetV3Loan().GetLoanAsync(guid).Result;
            }
        }
    }
}
