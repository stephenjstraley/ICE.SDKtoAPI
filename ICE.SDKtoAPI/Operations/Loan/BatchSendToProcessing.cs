using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Providers;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<bool> SendToProcessingAsync(LenderApiContractsV1.UserContract loanProcessor);
        Task<bool> SubmitBatchUpdateAsync(LenderApiContractsV1.LoanBatchUpdateRequestContract contract);
        void BatchUpdateKeys(string key, string value);

    }
    public partial class LenderAPI : ILenderAPI
    {
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
    }
}
