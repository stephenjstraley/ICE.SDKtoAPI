using ICE.SDKtoAPI;
using ICE.SDKtoAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using static ICE.SDKtoAPI.Helpers.PipelineHelper;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void FolderPermission()
        {
            Console.Clear();
            using (_api = new LenderAPI(_instanceId, _apiClientId, _userName, _password, _secret))
            {
                _api.GetTokenAsync().Wait();

                if (!_api.HasAccessToken)
                {
                    return;
                }

                var keys = LoadKeys();

                if (keys.Count > 0)
                {
                    foreach (var key in keys)
                    {
                        var tempCount = 1;

                        var pipeline = GetDelimitedValue(key.Pipeline);

                        foreach (var category in pipeline)
                        {
                            var dictLoan = GetRecordedMortgageLoans(category, key.StatusField, key.StatusFieldValue);

                            foreach (var kvp in dictLoan)
                            {
                                Console.WriteLine($"{key.Title} => Loan Counter: {tempCount++} of {dictLoan.Count}");

                                if (_api.GetFullLoanAsync(kvp.Key).Result)
                                {
                                    bool canContinue = _api.UnlockLoanAsync(true).Result;
                                    if (canContinue)
                                    {
                                        canContinue = _api.LockLoanAsync().Result;  // exclusive is default
                                        if (canContinue)
                                        {
                                            canContinue = ApplyRestrictions(key);
                                            if (canContinue)
                                            {
                                                canContinue = _api.CommitAsync().Result;
                                                if (!canContinue)
                                                {
                                                    //                                                    Console.WriteLine($"Unable to commit data change to loan [{kvp.Key}] - Skipping");
                                                }
                                            }
                                            else
                                                Console.WriteLine($"Unable to apply restrictions to loan [{kvp.Key}] - Skipping");
                                        }
                                        else
                                            Console.WriteLine($"Unable to LOCK loan [{kvp.Key}] - Skipping");
                                    }
                                    else
                                        Console.WriteLine($"Unable to unlock loan [{kvp.Key}] - Skipping");
                                }
                                else
                                    Console.WriteLine($"Unable to get loan [{kvp.Key}] - {_api.LastErrorMessage}");
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }

        static List<string> GetDelimitedValue(string documentTitle) => documentTitle.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList();

        static Dictionary<string, string> GetRecordedMortgageLoans(string pipeline, string statusfield, string statusfieldvalue)
        {
            Dictionary<string, string> loanData = new Dictionary<string, string>();

            try
            {
                //_logger.LogInformation($"starting populating loans from '{pipeline}'");

                var query = GetQuery(pipeline, statusfield, statusfieldvalue);

                foreach (var q in query)
                {
                    loanData.Add(q.LoanGuid, q.Fields["Loan.LoanNumber"].ToString());
                }

            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, $"Error retrieving Loans '{pipeline}' {ex.Message}");

            }
            //            _logger.LogInformation($"Completed query for loans, Loans found [{loanData.Count}] for pileline [{pipeline}]/[{statusfield}]/[{statusfieldvalue}]");
            return loanData;
        }

        static List<GuidCursor> GetQuery(string pipeline, string statusfield, string statusfieldvalue)
        {
            var loans = new List<GuidCursor>();
            List<string> fields = new List<string>
            {
                "GUID",
                "Loan.LoanNumber"
            };

            // the below is the original code which is not coded correctly.   Once ReeaseDateRun is defined as config
            // variable, it will always be used causing this sweep to pick up loan > 2 years old.
            //var releaseDateRun = string.IsNullOrEmpty(_config.ReleaseDateRun) ? DateTime.Today.AddDays(-1).ToString() : _config.ReleaseDateRun;

            // only going back 1 year per Guy's suggestion
            var releaseDateRun = DateTime.Today.AddDays(-365).ToString();
            //            _logger.LogInformation($"Starting date for sweep in [{releaseDateRun}]");

            try
            {
                var qLoanFolder = GetPipelineTerm("LoanFolder", pipeline, StringFieldMatchType.CaseInsensitive, true);
                var qLoanStatusLow = GetPipelineTerm("Fields.CX.STATUS", 002, OrdinalFieldMatchType.GreaterThanOrEquals);
                var qLoanStatusHigh = GetPipelineTerm("Fields.CX.STATUS", 005, OrdinalFieldMatchType.LessThanOrEquals);
                var qLoanStatus009 = GetPipelineTerm("Fields.CX.STATUS", "009", StringFieldMatchType.Exact, false);
                var qLoanStatus010 = GetPipelineTerm("Fields.CX.STATUS", "010", StringFieldMatchType.Exact, false);
                var qLoanFolderStatus = GetPipelineTerm($"Fields.{statusfield}", statusfieldvalue, StringFieldMatchType.Contains, false);
                var qLoanFolderStatusempty = GetPipelineTerm($"Fields.{statusfield}", string.Empty, StringFieldMatchType.Exact, true);
                var qStartDay = GetPipelineTerm("Fields.MS.START", Convert.ToDateTime(releaseDateRun), OrdinalFieldMatchType.GreaterThanOrEquals, DateFieldMatchPrecision.Day);
                var request = GetContract(
                                  GetFilterContractAnd(
                                      qLoanFolder,
                                      GetFilterContractOr(qLoanFolderStatus, qLoanFolderStatusempty),
                                      qStartDay,
                                      qLoanStatusLow,
                                      qLoanStatusHigh,
                                      qLoanStatus009,
                                      qLoanStatus010
                                      ),
                                fields.ToArray()
                              );

                loans = _api.PipelineRequestAsync(request, 20000).Result;
            }
            catch (Exception e)
            {
                //                _logger.LogInformation(_api.LastQuery);
                //                _logger.LogError(e, e.Message);
            }
            return loans;
        }

        static List<AccessRestrictionKey> LoadKeys()
        {
            List<AccessRestrictionKey> keys = new List<AccessRestrictionKey>();

            var temp1 = "My Pipeline|Recorded Mortgage|Accounting|||CX.RECORDED.FOLDERS|MTG";
            var temp2 = "My Pipeline|Final Title Insurance|Accounting|||CX.RECORDED.FOLDERS|FTI";

            keys.Add(new AccessRestrictionKey(temp1, "|"));
            keys.Add(new AccessRestrictionKey(temp2, "|"));

            return keys;
        }

        static bool ApplyRestrictions(AccessRestrictionKey key)
        {
            bool success = true;

            try
            {
                var lsttitle = GetDelimitedValue(key.Title);
                var lstKeepRoles = GetDelimitedValue(key.KeepRoles);
                var lstRemoveRoles = GetDelimitedValue(key.RemoveRoles);
                var lstAddRoles = GetDelimitedValue(key.Addroles);
                var statusField = key.StatusField;
                var statusValue = key.StatusFieldValue;

                //_logger.LogInformation($"TrackedDocuments ({lsttitle.Count}) found for loan {_api.LoanNumber}");

                foreach (var title in lsttitle)
                {
                    //_logger.LogInformation($"retrieving TrackedDocuments for ('{title}') on loan {_api.LoanNumber}");

                    var docs = _api.GetDocumentsByTitleAsync(title).Result;
                    var createdFolder = false;

                    if (docs.Count <= 0)  // Can't find so create
                    {
                        Console.WriteLine($"Creating Folder ('{title}') on loan {_api.LoanNumber}");
                        createdFolder = CreateFolder(title);
                    }

                    if (createdFolder) // reload if folder was created
                        docs = _api.GetDocumentsByTitleAsync(title).Result;  // get the docs again with new doc if created

                    foreach (var doc in docs)
                    {
                        Console.WriteLine($"Processing roles restriction for TrackedDocument ('{title}') on loan {_api.LoanNumber}");
                        if (lstRemoveRoles.Count > 0)
                        {
                            //RemoveRolesRestriction(doc, lstRemoveRoles);
                        }
                        if (lstKeepRoles.Count > 0)
                        {
                            //KeepRolesRestriction(doc, lstKeepRoles, statusField, statusValue);
                        }
                        if (lstAddRoles.Count > 0)
                        {
                            //AddRolesRestriction(doc, lstAddRoles, statusField, statusValue);
                        }
                        else
                        {
                            //UpdateFieldStatus(statusField, statusValue);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                success = false;
                Console.WriteLine($"Error on loan {_api.LoanNumber} - unable to apply restrictions");
            }

            return success;
        }

        static void UpdateFieldStatus(string statusField, string statusFieldValue, string role = null)
        {
            //update field
            var value = _api.Fields[statusField];
            string newValue = Convert.ToString(value);

            if (!newValue.Contains(statusFieldValue))
            {
                newValue += $",{statusFieldValue}";
                newValue = newValue.Trim().Trim(',');
                _api.Fields[statusField] = newValue;
            }
        }

        static bool CreateFolder(string title)
        {
            Console.WriteLine("Creating Folder Called");
            // get next milestone event name
            //            var description = "";
            //            _api.CreateDocumentAsync(title, description).Wait();
            //            if (_api.IsOkStatus)
            //                return true;
            //            else
            //            {
            //                Console.WriteLine($"Unable to create folder {title} - {description} - for loan {_api.LoanNumber}");
            return false;
            //            }
        }
    }

    public class AccessRestrictionKey
    {
        public AccessRestrictionKey(string config, string seperator)
        {
            var content = config.Split(seperator);

            Pipeline = content[0];
            Title = content[1];
            KeepRoles = content[2];
            RemoveRoles = content[3];
            Addroles = content[4];
            StatusField = content[5];
            StatusFieldValue = content[6];
        }
        public string Title { get; set; }
        public string KeepRoles { get; set; }
        public string RemoveRoles { get; set; }
        public string Pipeline { get; set; }
        public string Addroles { get; set; }
        public string StatusField { get; set; }
        public string StatusFieldValue { get; set; }
    }
}
