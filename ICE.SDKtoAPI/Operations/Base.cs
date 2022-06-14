using ICE.SDKtoAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Net;
using ICE.SDKtoAPI.Extensions;
using Flurl.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using ICE.SDKtoAPI.Providers;
using ICE.SDKtoAPI.SupportingClasses;

namespace ICE.SDKtoAPI
{
    public partial class LenderAPI : IDisposable
    {
        protected AccessToken _accessToken;
        protected LenderApiContractsV1.LoanContract _loanV1;
        protected LenderApiContractsV3.LoanContract _loanV3;
        protected string _rawLoan;
        protected string _loanLockId = null;
        protected string _guid = null;
        protected string _instanceId = string.Empty;
        protected string _clientId = string.Empty;
        protected string _userName = string.Empty;
        protected string _password = string.Empty;
        protected string _secret = string.Empty;
        protected bool _loadV3 = false;

        protected List<LenderApiContractsV1.UserContract> _users;
        protected List<LenderApiContractsV1.PersonaContract> _personas;
        protected List<LenderApiContractsV1.LoanContractLoanAssociate> _associates;
        protected LenderApiContractsV1.LoanMetaData _meta;
        protected LenderApiContractsV1.LoanBatchUpdateRequestContract _batchRequest = null;
        protected UserCredentials _credentials;
        protected string _thisWasLastCalled;
        protected LenderApiResponse _lastResponse { get; set; }
        public LenderApiResponse LastResponse => _lastResponse;
        public string LastErrorMessage => _lastResponse == null ? string.Empty : _lastResponse.ErrorMessage;
        public HttpStatusCode LastStatus => _lastResponse == null ? HttpStatusCode.OK : _lastResponse.StatusCode;
        public bool IsOkStatus => ((int)LastStatus < 300);
        public string LastUrl => _lastResponse == null ? string.Empty : _lastResponse.Url;
        public string LastQuery => _lastResponse == null ? string.Empty : _lastResponse.Query;
        public string LastExtraMessage => _lastResponse == null ? string.Empty : _lastResponse.ErrorMessage;
        public string LastMessage => _lastResponse == null ? string.Empty : _lastResponse.Message;
        public string LastLoanLockId => _loanLockId;
        public object Loan
        {
            get
            {
                if (_loadV3) return _loanV3;
                else return _loanV1;
            }
        }
        public string ClientId => _clientId;
        public string InstanceId => _instanceId;
        public string RawLoan => _rawLoan;
        public SDKAPIField Fields = new SDKAPIField();
        public string CurrentFolder => _meta?.LoanFolder ?? string.Empty;
        public string LoanGuid => _guid;
        public bool SaveResponseContect = false;
        public AccessToken Token => _accessToken;
        public bool HasAccessToken
        {
            get
            {
                if (_accessToken == null) return false;
                else
                {
                    var validate = ValidateTokenAsync().Result;
                    if (validate.Item2.IsSuccess) return true;
                    else return GetToken();
                }
            }
        }
        public string BearerToken => _accessToken?.Access_Token ?? "";
        public string LoanNumber => (_loadV3 ? _loanV3?.LoanNumber : _loanV1 != null ? _loanV1?.LoanNumber : string.Empty);
        public string LoanOfficerId => Fields["LOID"].ToStringNullSafe();
        public string LoanProcessorId => Fields["LPID"].ToStringNullSafe();
        public string LoanCloserId => Fields["CLID"].ToStringNullSafe();
        public bool LoanWasUpdated => Fields.LoanWasUpdated;
        public bool FieldDefsLoaded => Fields?._successfullyLoaded ?? false;
        public List<APISchema> FieldSchema => Fields?.FieldSchema ?? null;
        public List<APISchema> DynamicSchema => Fields?.DynamicSchema ?? null;
        public List<string> CustomFields => Fields?.GetCustomFields().Result.Select(testc => testc.Id).ToList() ?? null;
        public List<string> VirtualFields => Fields?.VirtualSchema ?? null;
        protected DocumentLogs _documentLog = null;
        public DocumentLogs Log => _documentLog;

        public class DocumentLogs
        {
            protected LenderAPI _ref = null;
            public DocumentLogs(LenderAPI parent) { _ref = parent; }
            public List<LenderApiContractsV1.LoanContractDocumentLogs> TrackedDocuments => _ref._loanV1.DocumentLogs;
            public LenderApiContractsV1.LoanContractDocumentLogs TrackedDocumentAdd(string title, string stage)
            {
                var count = TrackedDocuments.Count();
                return new LenderApiContractsV1.LoanContractDocumentLogs()
                {
                    Title = title,
                    Stage = stage,
                    DateAddedUtc = DateTime.UtcNow,
                    UpdatedDateUtc = DateTime.UtcNow,
                    Id = $"LogRecord/{count + 1}",
                    Guid = System.Guid.NewGuid().ToString()
                };
            }
        }

        public LenderAPI()
        {
            _documentLog = new DocumentLogs(this);
        }

        public LenderAPI(string instance, string apiClient, string userName, string password, string secret)
        {
            _documentLog = new DocumentLogs(this);
            _credentials = new UserCredentials()
            {
                ClientId = apiClient,
                ClientSecret = secret,
                InstanceId = instance,
                Password = password,
                UserName = userName
            };
            _instanceId = instance;
            _clientId = apiClient;
            _userName = userName;
            _password = password;
            _secret = secret;
        }

        public LenderAPI(UserCredentials creds)
        {
            _documentLog = new DocumentLogs(this);
            _credentials = creds;
            _instanceId = creds.InstanceId;
            _clientId = creds.ClientId;
            _userName = creds.UserName;
            _password = creds.Password;
            _secret = creds.ClientSecret;
        }

        public LenderAPI SetV3Loan()
        {
            _loadV3 = true;
            Fields.SetLoanVersion(_loadV3);
            return this;
        }
        public LenderAPI SetV1Loan()
        {
            _loadV3 = false;
            Fields.SetLoanVersion(_loadV3);
            return this;
        }
        public void SetResponse()
        {
            _lastResponse = new LenderApiResponse()
            {
                IsSuccess = true,
                ErrorMessage = "",
                ExtraInfo = "",
                Message = "",
                StatusCode = HttpStatusCode.OK
            };
        }
        public void SetLoanGuid(string guid) => _guid = guid;

        public void SetBadResponse(HttpStatusCode code, string message)
        {
            _lastResponse = new LenderApiResponse()
            {
                ErrorMessage = message,
                Message = message,
                IsSuccess = false,
                StatusCode = code
            };
        }
        public void MetaData(string guid)
        {
            _meta = new LenderApiContractsV1.LoanMetaData();

            try
            {
                var paths = new UrlPaths();
                var baseUrl = paths.GetMetaData(guid);

                _meta = baseUrl.WithHeader("Authorization", _accessToken.Access_Token)
                               .GetJsonAsync<LenderApiContractsV1.LoanMetaData>().Result;
            }
            catch
            {
                throw;
            }
        }
        public string Serialize()
        {
            if (_loadV3)
                return JsonConvert.SerializeObject(_loanV3, Formatting.Indented);
            else
                return JsonConvert.SerializeObject(_loanV1, Formatting.Indented);
        }
        public async Task<LenderApiContractsV1.FieldSchemaContract> GetV1FieldSchemaAsync(string id)
        {
            SetResponse();
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetV1FieldSchemaAsync(id);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<List<LenderApiContractsV3.FieldSchemaContract>> GetV3FieldSchemaAsync(string id)
        {
            SetResponse();
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetV3FieldSchemaAsync(id);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<List<LenderApiContractsV3.FieldSchemaContract>> GetV3FieldSchemaAsync(int start = 0, int limit = 5000)
        {
            SetResponse();
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetV3FieldSchemaAsync(start, limit);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<string> GetLoanSchemaAsync(string version)
        {
            SetResponse();
            bool v3 = (version.ToUpper() == "V3");
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetLoanSchemaAsync(v3);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<List<string>> GetAllFieldIdsAsync()
        {
            List<string> retValue = new List<string>();

            // get first 500 and the number of total fields
            SetResponse();
            var provider = new BaseProviderService(_accessToken);
            var range = 5000;
            var result = await provider.GetV3FieldSchemaAsync(0, range);
            var startingAt = range;
            _lastResponse = result.Item2;
            if (result.Item2.IsSuccess)
            {
                var fieldCount = _lastResponse.GetHeaderValue("X-Total-Count");
                if (!string.IsNullOrEmpty(fieldCount))
                {
                    // convert the results to IDS
                    if (result.Item2.IsSuccess && result.Item1.Count != 0)
                    {
                        foreach (var item in result.Item1)
                            retValue.Add(item.Id);

                        while (result.Item1.Count != 0)
                        {
                            Process();
                        }
                    }
                }
            }
            void Process()
            {
                result = provider.GetV3FieldSchemaAsync(startingAt, 5000).Result;
                _lastResponse = result.Item2;
                if (result.Item2.IsSuccess && result.Item1.Count != 0)
                {
                    foreach (var item in result.Item1)
                    {
                        if (!retValue.Contains(item.Id))
                            retValue.Add(item.Id);
                    }
                }
                startingAt += range;
            }

            return retValue;
        }

        public async Task<List<CustomFieldMeta>> GetCustomFieldsAsync()
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var result = await provider.GetCustomFieldsAsync();
            _lastResponse = result.Item2;
            if (result.Item2.IsSuccess)
            {
                Fields.SetCustomFields(result.Item1);
                return result.Item1;
            }
            else
            {
                Fields.ClearCustomFields();
                return result.Item1;
            }
        }

        public async Task<List<VirtualFieldMeta>> GetVirtualFieldsAsync()
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var result = await provider.GetVirutalFieldsAsync();
            _lastResponse = result.Item2;
            if (result.Item2.IsSuccess)
            {
                Fields.SetVirtualFields(result.Item1);
                return result.Item1;
            }
            else
            {
                Fields.ClearCustomFields();
                return result.Item1;
            }
        }

        public async Task<object> GetFieldValuesAsync(string guid, List<string> fields)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var result = await provider.GetFieldValuesAsync(guid, fields);
            _lastResponse = result.Item2;
            return result.Item1;
        }

        public async Task<bool> SendToProcessingAsync(LenderApiContractsV1.UserContract loanProcessor)
        {
            var pMs = GetMilestoneByNameAsync("Processing").Result;
            if (pMs != null)
                return await AssignLoanAssociateAsync(LoanGuid, pMs.Id, FixedRole.LoanProcessor, loanProcessor.Id);

            return false;
        }

        public async Task<bool> SubmitBatchUpdateAsync(LenderApiContractsV1.LoanBatchUpdateRequestContract contract)
        {
            try
            {
                SetResponse();
                var service = new BatchProviderService(_accessToken);
                var values = await service.BatchUpdateEncompass(contract);
                _lastResponse = values;
                return values.IsSuccess;
            }
            catch (Exception err)
            {
                SetBadResponse(HttpStatusCode.ExpectationFailed, err.Message);
            }
            return false;
        }

        public void BatchUpdateKeys(string key, string value)
        {
            if (_batchRequest != null)
            {
                //  && _fields.ContainsKey(key)
                var contract = _batchRequest.LoanData.Contacts[0];
                // map the field to the object
                //                var realName =  _fields[key];
                // add propert to object and assing VALUE
                //                contract.GetType().GetProperty(realName).SetValue(contract, value, null);
            }
        }
        #region Field Enhancement Ops
        public T Field<T>(string id) => Fields.MainField<T>(id);
        public bool FieldIsReadOnly(string id)
        {
            var item = Fields.GetDictionaryItem(id);
            if (item != null)
                return item.ReadOnly;
            else
                return true;
        }
        public bool FieldIsLocked(string id)
        {
            var item = Fields.GetDictionaryItem(id);
            if (item != null)
                return item.LockedField;
            else
                return true;
        }
        public bool FieldIsNullable(string id)
        {
            var item = Fields.GetDictionaryItem(id);
            if (item != null)
                return item.Nullable;
            else
                return true;
        }
        public string FieldType(string id)
        {
            var item = Fields.GetDictionaryItem(id);
            if (item != null)
                return item.Type;
            else
                return null;
        }
        public string FieldDescription(string id)
        {
            var item = Fields.GetDictionaryItem(id);
            if (item != null)
                return item.Description;
            else
                return null;
        }
        public bool FieldDefined(string id) => Fields.GetDictionaryItem(id) != null;
        #endregion

        public void Dispose()
        {
            //Fields = null;
            //_documentLog = null;
            //_accessToken = null;
            //_guid = null;
            //_meta = null;
            //_rawLoan = null;
            //_loanV1 = null;
            //_loanV3 = null;
            //_batchRequest = null;
            //_associates = null;
            //_personas = null;
            //_users = null;
            //_lastResponse = null;
        }

    }
}
