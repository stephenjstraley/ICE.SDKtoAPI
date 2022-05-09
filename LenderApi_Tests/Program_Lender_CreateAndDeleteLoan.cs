using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void CreateAndDeleteLoan()
        {
            Console.Clear();

            var newLoan = new ICE.SDKtoAPI.LenderApiContractsV1.LoanContractBase();

            var app = new ICE.SDKtoAPI.LenderApiContractsV1.LoanContractApplications();
            app.Borrower = new ICE.SDKtoAPI.LenderApiContractsV1.LoanContractBorrower();
            app.Borrower.FirstName = "andy";
            app.Borrower.LastName = "american";
            app.Borrower.TaxIdentificationIdentifier = "999.60-3333";
            app.Borrower.MaritalStatusType = "Married";
            app.Borrower.TotalMonthlyIncomeMinusNetRentalAmount = 10000.00;

            app.Coborrower = new ICE.SDKtoAPI.LenderApiContractsV1.LoanContractBorrower();
            app.Coborrower.FirstName = "amy";
            app.Coborrower.LastName = "america";
            app.Coborrower.EmailAddressText = "supriya.gopal@elliemae.com";
            app.Coborrower.TaxIdentificationIdentifier = "500-60-2222";
            app.Coborrower.TotalMonthlyIncomeMinusNetRentalAmount = 3500.00;

            newLoan.Applications.Add(app);

            var prop = new ICE.SDKtoAPI.LenderApiContractsV1.LoanContractProperty();
            prop.LoanPurposeType = "NoCash-Out Refinance";
            prop.RefinancePropertyExistingLienAmount = 400000.00;
            prop.RefinancePropertyAcquiredYear = "1999";
            prop.RefinancePropertyOriginalCostAmount = 450000.00;
            prop.StreetAddress = "4321 CulDeSac Street";
            prop.City = "Someplace";
            prop.State = "MA";
            prop.PostalCode = "02723";
            prop.FinancedNumberOfUnits = 1;

            newLoan.Property = prop;

            var rate = new ICE.SDKtoAPI.LenderApiContractsV1.LoanContractRateLock();
            rate.CurrentNumberOfDays = 110;

            newLoan.RateLock = rate;

            ICE.SDKtoAPI.LenderApiContractsV1.LoanContract addedLoan = _api.CreateLoanAsync(newLoan, "18 folders are selected").Result;
            Console.WriteLine("-------- Raw Added Loan --------");
            if (_api.IsOkStatus)
            {
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(addedLoan));

                Console.WriteLine();
                Console.WriteLine("-------- Set Loan to API --------");
                _api.SetLoanAsync(addedLoan).Wait();

                Console.WriteLine();
                Console.WriteLine("-------- Deleting Loan --------");
                var deleted = _api.DeleteLoanAsync(addedLoan.Id);
                Console.WriteLine($"Loan was deleted: {deleted}");
            }
            else
            {
                Console.WriteLine("Unable to add loan");
                Console.WriteLine();
                Console.WriteLine(_api.LastErrorMessage);
                Console.WriteLine(_api.LastStatus);
            }

        }
    }
}
