using System;
using System.Collections.Generic;
using static ICE.SDKtoAPI.Helpers.PipelineHelper;


namespace LenderApi_Tests
{
    public partial class Program
    {
        public static void CancelDeclinedLoans()
        {
            var request = GetContract(
                             GetFilterContractAnd(
                                 GetPipelineTerm("Loan.LoanFolder", _fromFolder, StringFieldMatchType.Exact),
                                 GetPipelineTerm("Fields.DENIAL.X11", new DateTime(1970, 1, 1), OrdinalFieldMatchType.GreaterThanOrEquals))
                                 );

            var loans = _api.PipelineRequestAsync(request).Result;
            if (_api.IsOkStatus)
            {
                Console.Clear();
                Console.WriteLine("---- CancelDeclined Loan Guids ----");
                foreach (var loan in loans)
                    Console.WriteLine(loan.LoanGuid);

            }

            Console.WriteLine();
            Console.WriteLine("Any key to continue");
            Console.ReadKey();
        }

        public static void EmployeeAdverseLoans()
        {
            var request = GetContract(
                                GetFilterContractAnd(
                                    GetPipelineTerm("Fields.4181", "Y", StringFieldMatchType.Exact),
                                    GetPipelineTerm("Fields.3142", string.Empty, StringFieldMatchType.Exact, include: false),
                                    GetPipelineTerm("Fields.CX.BST", "6", StringFieldMatchType.Exact),
                                    GetFilterContractOr(
                                            GetPipelineTerm("Fields.CX.STATUS", "009", StringFieldMatchType.Exact),
                                            GetPipelineTerm("Fields.CX.STATUS", "010", StringFieldMatchType.Exact)
                                    )
                                )
                            );

            var loans = _api.PipelineRequestAsync(request).Result;
            if (_api.IsOkStatus)
            {
                Console.Clear();
                Console.WriteLine("---- Employee Adverse Loan Guids ----");
                foreach (var loan in loans)
                    Console.WriteLine(loan.LoanGuid);

            }

            Console.WriteLine();
            Console.WriteLine("Any key to continue");
            Console.ReadKey();
        }
        public static void FundedLoans()
        {
            PipelineQueryWithFields request = null;

            if (_dtc)
            {
                var myPipeline = GetPipelineTerm("Loan.LoanFolder", "My Pipeline", StringFieldMatchType.Exact);
                var loanStatus = GetPipelineTerm("Fields.CX.STATUS", "006", StringFieldMatchType.Exact, true);
                var empProg = GetPipelineTerm("Fields.CX.EMPLOYEE.PROGRAM", string.Empty, StringFieldMatchType.Exact, true);

                var emp4181N = GetPipelineTerm("Fields.4181", "N", StringFieldMatchType.Exact, true);
                var emp4181n = GetPipelineTerm("Fields.4181", "n", StringFieldMatchType.Exact, true);

                var orEmp = GetFilterContractOr(emp4181N, emp4181n);

                request = GetContract(GetFilterContractAnd(myPipeline, loanStatus, empProg, orEmp));
            }
            else
            {
                var myPipeline = GetPipelineTerm("Fields.2626", "Correspondent", StringFieldMatchType.Exact);
                var loanStatus = GetPipelineTerm("Fields.CX.STATUS", "006", StringFieldMatchType.Exact, true);
                var pipeLine = GetPipelineTerm("Loan.LoanFolder", "Pipeline Correspondent", StringFieldMatchType.Exact);

                request = GetContract(GetFilterContractAnd(myPipeline, loanStatus, pipeLine));

            }

            var loans = _api.PipelineRequestAsync(request, 1000).Result;
            if (_api.IsOkStatus)
            {
                Console.Clear();
                Console.WriteLine("---- Funded Loan Guids ----");
                foreach (var loan in loans)
                    Console.WriteLine(loan.LoanGuid);

            }

            Console.WriteLine();
            Console.WriteLine("Any key to continue");
            Console.ReadKey();
        }
        public static void RefiLoans()
        {
            if (_dtc)
            {
                var monthRange = -30 * (12); //_appConfig.SweepRangeInMonths;
                var dayCheck = 30; // _appConfig.CreditCheckAgeDays;
                var after = DateTime.Today.AddDays(monthRange);
                var epoch = DateTime.Today - TimeSpan.FromDays(dayCheck);

                List<string> fields = new List<string>();
                fields.Add("GUID");
                fields.Add("Loan.LoanNumber");
                fields.Add("Loan.LoanPurpose");  // 299
                fields.Add("Fields.CX.STATUS");
                fields.Add("Fields.CX.SUBSTATUS");
                fields.Add("Fields.CX.CREDITFIRSTRUN.DATE");
                fields.Add("Fields.Document.DateReceived.Credit Report");
                fields.Add("Fields.Document.DateReceived.Pre-Qual Letter");

                var sort = SortCriterionList();
                sort.Add(SortCriterionList("Fields.CX.CREDITFIRSTRUN.DATE"));

                var loanCreatedAfter = GetPipelineTerm("Fields.2025", after, OrdinalFieldMatchType.GreaterThanOrEquals, DateFieldMatchPrecision.Day);
                var matchStatus = GetPipelineTerm("Fields.CX.STATUS", "001", StringFieldMatchType.Exact, true);
                var matchSubstatus = GetPipelineTerm("Fields.CX.SUBSTATUS", "C", StringFieldMatchType.Exact, true);
                var creditCheckDateBefore = GetPipelineTerm("Fields.CX.CREDITFIRSTRUN.DATE", epoch, OrdinalFieldMatchType.LessThan, DateFieldMatchPrecision.Day);
                var matchCashRefi = GetPipelineTerm("Fields.19", "Cash-Out Refinance", StringFieldMatchType.Exact, true);
                var matchNoCashRefi = GetPipelineTerm("Fields.19", "NoCash-Out Refinance", StringFieldMatchType.Exact, true);
                var atLeast620FicoScore = GetPipelineTerm("Loan.CreditScore", 620, OrdinalFieldMatchType.GreaterThanOrEquals);

                var request = GetContract(
                                    sort,
                                    GetFilterContractAnd(loanCreatedAfter,
                                    matchStatus,
                                    matchSubstatus,
                                    atLeast620FicoScore,
                                    creditCheckDateBefore,
                                    GetFilterContractOr(matchCashRefi, matchNoCashRefi)
                                    ),
                                    fields.ToArray()
                    );

                var loans = _api.PipelineRequestAsync(request).Result;
                if (_api.IsOkStatus)
                {
                    Console.Clear();
                    Console.WriteLine("---- Refi Loan Guids and Fields ----");
                    foreach (var loan in loans)
                        Console.WriteLine($"{loan.LoanGuid} - {loan.Fields["Loan.LoanNumber"]} - {loan.Fields["Fields.CX.STATUS"]}");

                }

                Console.WriteLine();
                Console.WriteLine("Any key to continue");
                Console.ReadKey();

            }
        }
        public static void PurchaseLoans()
        {
            if (_dtc)
            {
                var monthRange = -1 * (12); //_appConfig.SweepRangeInMonths;
                var dayCheck = 30; // _appConfig.CreditCheckAgeDays;
                var after = DateTime.Today.AddDays(monthRange);
                var epoch = DateTime.Today - TimeSpan.FromDays(dayCheck);

                var sort = SortCriterionList();
                sort.Add(SortCriterionList("Fields.CX.CREDITFIRSTRUN.DATE"));

                List<string> fields = new List<string>();
                fields.Add("Fields.CX.STATUS");
                fields.Add("Fields.CX.SUBSTATUS");
                fields.Add("Fields.19");
                fields.Add("Fields.11");
                fields.Add("Loan.CreditScore");
                fields.Add("Fields.Document.DateReceived.Purchase Prequalification Order");
                fields.Add("Fields.Document.DateReceived.Pre-Qual Letter");
                fields.Add("Fields.CX.CREDITFIRSTRUN.DATE");
                fields.Add("Fields.2025");
                fields.Add("Loan.LoanNumber");
                fields.Add("Fields.CX.CXLD.AGENT.DISPOSITION");

                var request = GetContract(
                    sort,
                    GetFilterContractAnd(
                        GetPipelineTerm("Fields.CX.STATUS", "001", StringFieldMatchType.Exact, true),
                        GetPipelineTerm("Fields.CX.SUBSTATUS", "C", StringFieldMatchType.Exact, true),
                        GetPipelineTerm("Fields.19", "Purchase", StringFieldMatchType.Exact, true),

                        GetPipelineTerm("Fields.11", "TBD", StringFieldMatchType.Exact, true),
                        GetPipelineTerm("Loan.CreditScore", 620, OrdinalFieldMatchType.GreaterThanOrEquals),

                        GetPipelineTerm("Fields.Document.DateReceived.Pre-Qual Letter", DateFieldCriterion.IsEmpty),

                        GetPipelineTerm("Fields.Document.DateReceived.Purchase Prequalification Order", DateFieldCriterion.IsEmpty),

                         GetPipelineTerm("Fields.CX.CREDITFIRSTRUN.DATE", epoch, OrdinalFieldMatchType.LessThanOrEquals, DateFieldMatchPrecision.Day),
                         GetPipelineTerm("Fields.2025", after, OrdinalFieldMatchType.GreaterThanOrEquals, DateFieldMatchPrecision.Day),

                         GetPipelineTerm("LoanFolder", "Employee Loans zAdverse PreQuals", StringFieldMatchType.Exact, false),
                         GetPipelineTerm("LoanFolder", "Employee Loans zAdverse Loans", StringFieldMatchType.Exact, false),
                         GetPipelineTerm("LoanFolder", "Employee Loans", StringFieldMatchType.Exact, false)

                        ),
                    fields.ToArray()
                    );

                var loans = _api.PipelineRequestAsync(request).Result;
                if (_api.IsOkStatus)
                {
                    Console.Clear();
                    Console.WriteLine("---- Purchase Loan Guids and Fields ----");
                    foreach (var loan in loans)
                        Console.WriteLine($"{loan.LoanGuid} - {loan.Fields["Loan.LoanNumber"]} - {loan.Fields["Fields.CX.STATUS"]}");

                }

                Console.WriteLine();
                Console.WriteLine("Any key to continue");
                Console.ReadKey();
            }
        }

        public static void PurchasePrequalLoans()
        {
            if (_dtc)
            {
                var monthRange = -1 * (12); //_appConfig.SweepRangeInMonths;
                var dayCheck = 120; // _appConfig.CreditCheckAgeDays;
                var after = DateTime.Today.AddDays(monthRange);
                var epoch = DateTime.Today - TimeSpan.FromDays(dayCheck);

                List<string> fields = new List<string>();
                fields.Add("GUID");
                fields.Add("Loan.LoanNumber");
                fields.Add("Loan.LoanPurpose");  // 299
                fields.Add("Fields.CX.STATUS");
                fields.Add("Fields.CX.SUBSTATUS");
                fields.Add("Fields.CX.CREDITFIRSTRUN.DATE");
                fields.Add("Fields.Document.DateReceived.Credit Report");
                fields.Add("Fields.Document.DateReceived.Pre-Qual Letter");

                var sort = SortCriterionList();
                sort.Add(SortCriterionList("Fields.CX.CREDITFIRSTRUN.DATE"));

                var loanCreatedAfter = GetPipelineTerm("Fields.2025", after, OrdinalFieldMatchType.GreaterThanOrEquals, DateFieldMatchPrecision.Day);
                var matchStatus = GetPipelineTerm("Fields.CX.STATUS", "001", StringFieldMatchType.Exact, true);
                var matchSubstatus = GetPipelineTerm("Fields.CX.SUBSTATUS", "C", StringFieldMatchType.Exact, true);
                var matchPurpose = GetPipelineTerm("Fields.19", "Purchase", StringFieldMatchType.Exact, true);
                var creditCheckDateBefore = GetPipelineTerm("Fields.Document.DateReceived.Credit Report", epoch, OrdinalFieldMatchType.LessThanOrEquals, DateFieldMatchPrecision.Day);
                var preQualLetterRecvd = GetPipelineTerm("Fields.Document.DateReceived.Pre-Qual Letter", DateFieldCriterion.IsNotEmpty);
                var preQualOrderRecvd = GetPipelineTerm("Fields.Document.DateReceived.Purchase Prequalification Order", DateFieldCriterion.IsNotEmpty);
                var matchPropertyAddress = GetPipelineTerm("Fields.11", "TBD", StringFieldMatchType.Exact, true);
                var matchVA = GetPipelineTerm("Fields.1172", "VA", StringFieldMatchType.CaseInsensitive, true);
                var matchFHA = GetPipelineTerm("Fields.1172", "FHA", StringFieldMatchType.CaseInsensitive, true);
                var matchConventional = GetPipelineTerm("Fields.1172", "Conventional", StringFieldMatchType.CaseInsensitive, true);
                var atLeast600FicoScore = GetPipelineTerm("Loan.CreditScore", 600, OrdinalFieldMatchType.GreaterThanOrEquals);
                var atLeast620FicoScore = GetPipelineTerm("Loan.CreditScore", 620, OrdinalFieldMatchType.GreaterThanOrEquals);
                var atLeast580FicoScore = GetPipelineTerm("Loan.CreditScore", 580, OrdinalFieldMatchType.GreaterThanOrEquals);
                var qLFEmployeeLoanszAdversePreQuals = GetPipelineTerm("LoanFolder", "Employee Loans zAdverse PreQuals", StringFieldMatchType.Exact, false);
                var qLFEmployeeLoanszAdverseLoans = GetPipelineTerm("LoanFolder", "Employee Loans zAdverse Loans", StringFieldMatchType.Exact, false);

                var matchCreditVA = GetFilterContractAnd(matchVA, atLeast600FicoScore);
                var matchCreditFHA = GetFilterContractAnd(matchFHA, atLeast580FicoScore);
                var matchCreditConv = GetFilterContractAnd(matchConventional, atLeast620FicoScore);

                var matchTypeAndCredit = GetFilterContractOr(matchCreditVA, matchCreditFHA, matchCreditConv);


                var request = GetContract(
                                   sort,
                                   GetFilterContractAnd(
                                        loanCreatedAfter,
                                        creditCheckDateBefore,
                                        GetFilterContractOr(preQualLetterRecvd, preQualOrderRecvd),
                                        matchPurpose,
                                        matchStatus,
                                        matchSubstatus,
                                        matchPropertyAddress,
                                        qLFEmployeeLoanszAdversePreQuals,
                                        qLFEmployeeLoanszAdverseLoans,
                                        matchTypeAndCredit
                                        ),
                                       fields.ToArray()
                                  );

                var loans = _api.PipelineRequestAsync(request).Result;
                if (_api.IsOkStatus)
                {
                    Console.Clear();
                    Console.WriteLine("---- Purchase Prequal Loan Guids and Fields ----");
                    foreach (var loan in loans)
                        Console.WriteLine($"{loan.LoanGuid} - {loan.Fields["Loan.LoanNumber"]} - {loan.Fields["Fields.CX.STATUS"]}");

                }

                Console.WriteLine();
                Console.WriteLine("Any key to continue");
                Console.ReadKey();

            }
        }
    }
}
