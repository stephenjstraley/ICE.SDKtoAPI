using ICE.SDKtoAPI.Providers;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<bool> GetLoanBorrowerCoBorrowerAsync();
        Task<bool> GetLoanBorrowerCoBorrowerAsync(string guid);
    }
    public partial class LenderAPI : ILenderAPI
    {
        public async Task<bool> GetLoanBorrowerCoBorrowerAsync() => await GetLoanBorrowerCoBorrowerAsync(LoanGuid);
        public async Task<bool> GetLoanBorrowerCoBorrowerAsync(string guid)
        {
            try
            {
                SetResponse();
                var service = new LoanProviderService(_accessToken);
                var values = await service.GetBorrowerCoborrowerAsync(guid);
                _lastResponse = values.Item2;
                _loanV1 = values.Item1;
                if (values.Item2.IsSuccess)
                {
                    Fields.SetLoan(_loanV1);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                SetBadResponse(HttpStatusCode.ExpectationFailed, ex.Message);
                return false;
            }
        }

    }
}
