using ICE.SDKtoAPI.Providers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.RegistrationLogContract>> GetRegistrationLogs();
        Task<List<LenderApiContractsV3.RegistrationLogContract>> GetRegistrationLogs(string guid);
        Task<LenderApiContractsV3.RegistrationLogContract> GetRegistrationLog(string logId);
        Task<LenderApiContractsV3.RegistrationLogContract> GetRegistrationLog(string guid, string logId);
    }

    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV3.RegistrationLogContract>> GetRegistrationLogs() => await GetRegistrationLogs(LoanGuid);
        public async Task<List<LenderApiContractsV3.RegistrationLogContract>> GetRegistrationLogs(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.GetRegistrationLogs(guid);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }

        public async Task<LenderApiContractsV3.RegistrationLogContract> GetRegistrationLog(string logId) => await GetRegistrationLog(LoanGuid, logId);
        public async Task<LenderApiContractsV3.RegistrationLogContract> GetRegistrationLog(string guid, string logId)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.GetRegistrationLog(guid, logId);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
    }
}
