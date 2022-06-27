using ICE.SDKtoAPI.Providers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV1.LoanContractConversationLogs>> GetConversationLogsAsync();
        Task<List<LenderApiContractsV1.LoanContractConversationLogs>> GetConversationLogsAsync(string guid);
        Task<LenderApiContractsV1.LoanContractConversationLogs> GetConversationLogAsync(string id);
        Task<LenderApiContractsV1.LoanContractConversationLogs> GetConversationLogAsync(string guid, string id);
    }

    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV1.LoanContractConversationLogs>> GetConversationLogsAsync() => await GetConversationLogsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV1.LoanContractConversationLogs>> GetConversationLogsAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetConversationLogsAsync(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<LenderApiContractsV1.LoanContractConversationLogs> GetConversationLogAsync(string id) => await GetConversationLogAsync(LoanGuid, id);
        public async Task<LenderApiContractsV1.LoanContractConversationLogs> GetConversationLogAsync(string guid, string id)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetConversationLogAsync(guid, id);
            _lastResponse = results.Item2;
            return results.Item1;
        }

    }
}
