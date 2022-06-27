using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Extensions;
using ICE.SDKtoAPI.SupportingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        void SetLoanGuid(string guid);
        LenderAPI SetV3Loan();
        LenderAPI SetV1Loan();
    }
    public partial class LenderAPI : ILenderAPI, IDisposable
    {
        #region properties
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
        public bool IsLoanLocked
        {
            get
            {
                var locklist = GetCurrentLockAsync().Result;
                return !(locklist == null);
            }
        }
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
        #endregion

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

        protected void SetResponse()
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
        protected void SetBadResponse(HttpStatusCode code, string message)
        {
            _lastResponse = new LenderApiResponse()
            {
                ErrorMessage = message,
                Message = message,
                IsSuccess = false,
                StatusCode = code
            };
        }

        public void SetLoanGuid(string guid) => _guid = guid;
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
