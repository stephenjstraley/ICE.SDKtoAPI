using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        void MetaData(string guid);
        string Serialize();
        Task<LenderApiContractsV1.FieldSchemaContract> GetV1FieldSchemaAsync(string id);
        Task<List<LenderApiContractsV3.FieldSchemaContract>> GetV3FieldSchemaAsync(string id);
        Task<List<LenderApiContractsV3.FieldSchemaContract>> GetV3FieldSchemaAsync(List<string> ids);
        Task<List<LenderApiContractsV3.FieldSchemaContract>> GetV3FieldSchemaAsync(int start = 0, int limit = 5000);
        Task<string> GetLoanSchemaAsync(string version);
        Task<List<string>> GetAllFieldIdsAsync();
        Task<List<CustomFieldMeta>> GetCustomFieldsAsync(bool v3Schema = false);
        Task<List<VirtualFieldMeta>> GetVirtualFieldsAsync();
        Task<List<FieldsFromEncompass>> GetFieldValuesAsync(string guid, List<string> fields, bool v3version = false);
    }

    public partial class LenderAPI : ILenderAPI
    {
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
        public async Task<List<LenderApiContractsV3.FieldSchemaContract>> GetV3FieldSchemaAsync(List<string> ids)
        {
            SetResponse();
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetV3FieldSchemaAsync(ids);
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
        public async Task<List<CustomFieldMeta>> GetCustomFieldsAsync(bool v3Schema = false)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var result = await provider.GetCustomFieldsAsync(v3Schema);
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

        public async Task<List<FieldsFromEncompass>> GetFieldValuesAsync(string guid, List<string> fields, bool v3version = false)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var result = await provider.GetFieldValuesAsync(guid, fields, v3version);
            _lastResponse = result.Item2;
            return result.Item1;
        }

    }
}
