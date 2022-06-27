using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV3;
using ICE.SDKtoAPI.Providers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        bool MoveToFolder(string newName);
        bool MoveToFolder(string guid, string newName);
        Task<LenderApiResponse> MoveToFolderAsync(string guid, string newName);
        Task<List<LoanFolderContract>> GetLoanFoldersAsync();
        Task<LoanFolderContract> GetLoanFolderAsync(string name);
    }
    public partial class LenderAPI : ILenderAPI
    {
        public bool MoveToFolder(string newName) => MoveToFolder(LoanGuid, newName);
        public bool MoveToFolder(string guid, string newName)
        {
            SetResponse();
            LenderApiResponse results = MoveToFolderAsync(guid, newName).Result;
            if (!results.IsSuccess)
            {
                _lastResponse = results;
            }
            return results.IsSuccess;
        }
        public async Task<LenderApiResponse> MoveToFolderAsync(string guid, string newName)
        {
            SetResponse();
            var provider = new FolderProviderService(_accessToken);
            var resp = await provider.MoveToFolderAsync(guid, newName);
            _lastResponse = resp;
            return resp;
        }
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
