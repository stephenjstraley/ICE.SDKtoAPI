using ICE.SDKtoAPI.LenderApiContractsV3;
using ICE.SDKtoAPI.Providers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial class LenderAPI
    {
        public async Task<List<LoanFolderContract>> GetLoanFoldersAsync()
        {
            SetResponse();
            var provider = new FolderProviderService(_accessToken);
            var results = await provider.GetLoanFoldersAsync();
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<LoanFolderContract> GetLoanFolderAsync(string name)
        {
            SetResponse();
            var provider = new FolderProviderService(_accessToken);
            var results = await provider.GetLoanFolderAsync(name);
            _lastResponse = results.Item2;
            return results.Item1;
        }
    }
}
