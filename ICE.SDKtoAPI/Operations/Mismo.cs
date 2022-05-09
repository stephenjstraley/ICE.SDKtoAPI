using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial class LenderAPI
    {
        public async Task<string> ConvertMismoLoanAsync(string xml)
        {
            SetResponse();
            var provider = new MismoProviderService(_accessToken);
            var resp = await provider.ConvertMismoToLoan(xml);
            _lastResponse = resp.Item2;
            return resp.Item1;
        }
        public async Task<bool> CreateLoanFromConvertedMismoAsync(string loan, string folder = "")
        {
            object newLoan = JsonConvert.DeserializeObject(loan);
            return await CreateLoanFromConvertedMismoAsync(newLoan, folder);
        }
        public async Task<bool> CreateLoanFromConvertedMismoAsync(object loan, string folder = "")
        {
            if(string.IsNullOrEmpty(folder))
                folder = "My+Pipeline";

            SetResponse();
            var provider = new MismoProviderService(_accessToken);
            _lastResponse = await provider.CreateLoanFromConvertedMemoAsync(loan, folder);
            return _lastResponse.IsSuccess;
        }
        public async Task<bool> UpdateLoanFromMismoAsync(string guid, string xml)
        {
            SetResponse();
            var provider = new MismoProviderService(_accessToken);
            _lastResponse = await provider.UpdateLoanFromMismoAsync(guid, xml);
            return _lastResponse.IsSuccess;
        }
    }
}
