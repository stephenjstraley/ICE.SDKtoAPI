using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Extensions;
using ICE.SDKtoAPI.LenderApiContractsV1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class LockProviderService : BaseProviderService
    {
        public LockProviderService(AccessToken token) : base(token) { paths.SetV1(); }
        public async Task<Tuple<List<RateLockSummaryContract>, LenderApiResponse>> GetLockRequestAsync(string guid)
        {
            var usePath = paths.RateLockRequests(guid);

            var list = await Get<List<RateLockSummaryContract>>(usePath);

            return new Tuple<List<RateLockSummaryContract>, LenderApiResponse>(list, _response);
        }
        public async Task<Tuple<List<ResourceLockContract>, LenderApiResponse>> ResourceLockListAsync(string guid)
        {
            var usePath = paths.ResourceLockList(guid);

            var theList = await Get<List<ResourceLockContract>>(usePath);

            return new Tuple<List<ResourceLockContract>, LenderApiResponse>(theList, _response);
        }
        public async Task<Tuple<RateLockDetail, LenderApiResponse>> GetLockRequestAsync(string guid, string resourceGuid)
        {
            var usePath = paths.LockRequestForResource(guid, resourceGuid);

            var item = await Get<RateLockDetail>(usePath);

            return new Tuple<RateLockDetail, LenderApiResponse>(item, _response);
        }
        public async Task<Tuple<RateLockSummaryContract, LenderApiResponse>> ExtendRateLockRequestAsync(string guid, string resourceId, ExtendRateLock rateLock)
        {
            var usePath = paths.ExtendLockRequestForResource(guid, resourceId);

            var item = await Get<RateLockSummaryContract>(usePath);

            return new Tuple<RateLockSummaryContract, LenderApiResponse>(item, _response);
        }
        public async Task<Tuple<RateLockSummaryContract, LenderApiResponse>> RelockRateLockRequestAsync(string guid, string resourceId, ExtendRateLock rateLock)
        {
            var usePath = paths.ReLockRequestForResource(guid, resourceId);

            var item = await Get<RateLockSummaryContract>(usePath);

            return new Tuple<RateLockSummaryContract, LenderApiResponse>(item, _response);
        }
        public async Task<Tuple<RateLockSummaryContract, LenderApiResponse>> ConfirmRateLockRequestAsync(string guid, string resourceId, ConfirmRateLock confirm)
        {
            var usePath = paths.ConfirmLockRequestForResource(guid, resourceId);

            var item = await Get<RateLockSummaryContract>(usePath);

            return new Tuple<RateLockSummaryContract, LenderApiResponse>(item, _response);
        }
        public async Task<Tuple<RateLockSummaryContract, LenderApiResponse>> ReviseRateLockRequestAsync(string guid, string resourceId, RateLockSummaryContract summary)
        {
            var usePath = paths.ReviseLockRequestForResource(guid, resourceId);

            var item = await Get<RateLockSummaryContract>(usePath);

            return new Tuple<RateLockSummaryContract, LenderApiResponse>(item, _response);
        }
        public async Task<Tuple<RateLockSummaryContract, LenderApiResponse>> CancelRateLockRequestAsync(string guid, string resourceId, RateLockSummaryContract summary)
        {
            var usePath = paths.CancelRateLockRequest(guid, resourceId);

            var item = await Get<RateLockSummaryContract>(usePath);

            return new Tuple<RateLockSummaryContract, LenderApiResponse>(item, _response);
        }
        public async Task<Tuple<RateLockSummaryContract, LenderApiResponse>> GetRateLockRequestAsync(string guid, string resourceId)
        {
            var usePath = paths.RateLockRequest(guid, resourceId);

            var item = await Get<RateLockSummaryContract>(usePath);

            return new Tuple<RateLockSummaryContract, LenderApiResponse>(item, _response);
        }
        public async Task<Tuple<List<LoanContractSnapshotFields>, LenderApiResponse>> GetRateLockSnapshotAsync(string guid, string resourceGuid)
        {
            LenderApiResponse apiResponse;

            List<LoanContractSnapshotFields> snaps = null;

            var usePath = paths.RateLockRequestsSnapshot(guid, resourceGuid);

            try 
            {
                var url = Authenticate(usePath);

                var response = await url.GetAsync();

                string result = await response.Content.ReadAsStringAsync();
                var items = JsonConvert.DeserializeObject(result);
                snaps = new List<LoanContractSnapshotFields>();

                var fields = (JObject)items;
                foreach (JProperty property in fields.Properties())
                {
                    snaps.Add(new LoanContractSnapshotFields()
                    {
                        FieldID = property.Name,
                        Value = property.Value.ToString()
                    });
                }
                apiResponse = OkResponse(response, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath, "");
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath, "");
            }

            return new Tuple<List<LoanContractSnapshotFields>, LenderApiResponse>(snaps, apiResponse);
        }
        public async Task<Tuple<string, LenderApiResponse>> LockLoanAsync(string guid, bool exclusive = true)
        {
            string lockId = null;
            LenderApiResponse apiResponse;

            var usePath = paths.ResourceLocksFull + "?view=id";

            try
            {
                var contract = new ResourceLockContract
                {
                    Resource = new ResourceLockContractResource
                    {
                        EntityType = "loan",
                        EntityId = guid
                    },
                    LockType = exclusive ? "exclusive" : "shared"
                };

                var url = Authenticate(usePath);

                var resp = await url.PostJsonAsync(contract);

                var response = resp.ReceiveJson<LockedLoanResponse>();

                if (response != null)
                    lockId = response?.Id;

                apiResponse = OkResponse(resp.Headers, usePath);
            }
            catch (FlurlHttpException ex)
            {
                apiResponse = BadResponse(ex, usePath, "");
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath, "");
            }

            return new Tuple<string, LenderApiResponse>(lockId, apiResponse);
        }
        public async Task<LenderApiResponse> UnlockAsync(string guid, string requestId, bool forced = false)
        {
            var value = forced ? "true" : "false";
            var usePath = paths.ResourceLock(guid, requestId, value);

            await Get<string>(usePath);

            return _response;
        }
    }
}
