using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV1;
using ICE.SDKtoAPI.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<RateLockSummaryContract>> GetRateLockSummaryRequestsAsync();
        Task<List<RateLockSummaryContract>> GetRateLockSummaryRequestsAsync(string guid);
        Task<List<ResourceLockContract>> GetResourceLockListAsync();
        Task<List<ResourceLockContract>> GetResourceLockListAsync(string guid);
        Task<ResourceLockContract> GetCurrentLockAsync(bool exclusiveOnly = false);
        Task<string> GetCurrentLockByAsync(bool exclusiveOnly = false);
        Task<bool> ForceUnlockAsync();
        bool Unlock();
        Task<bool> UnlockLoanAsync();
        Task<bool> UnlockLoanAsync(bool force = false);
        Task<bool> UnlockLoanAsync(string guid, bool force = false);
        bool Lock();
        Task<bool> LockLoanAsync();
        Task<bool> LockLoanAsync(bool force);
        Task<bool> LockLoanAsync(string guid, bool exclusive);
        Task<RateLockSummaryContract> GetRateLockRequestAsync(string resourceGuid);
        Task<RateLockSummaryContract> GetRateLockRequestAsync(string guid, string resourceGuid);
        Task<RateLockSummaryContract> ExtendRateLockAsync(string guid, string resourceGuid, ExtendRateLock detail);
        Task<RateLockSummaryContract> RelockRateLockAsync(string guid, string resourceGuid, ExtendRateLock detail);
        Task<RateLockSummaryContract> ConfirmRateLockAsync(string guid, string resourceGuid, ConfirmRateLock detail);
        Task<RateLockSummaryContract> ReviseRateLockAsync(string guid, string resourceGuid, RateLockSummaryContract detail);
        Task<RateLockSummaryContract> CancelRateLockAsync(string guid, string resourceGuid, RateLockSummaryContract detail);
        Task<List<LoanContractSnapshotFields>> GetRateLockShapshotAsync(string resourceGuid);
        Task<List<LoanContractSnapshotFields>> GetRateLockSnapshotAsync(string guid, string resourceGuid);
        Task<bool> ForceUnlockIfMoveToCancelDeclineFolderAsync(LoanFolder loanFolderToMoveTo);
    }
    public partial class LenderAPI : ILenderAPI
    {
        #region Summary
        public async Task<List<RateLockSummaryContract>> GetRateLockSummaryRequestsAsync() => await GetRateLockSummaryRequestsAsync(LoanGuid);
        public async Task<List<RateLockSummaryContract>> GetRateLockSummaryRequestsAsync(string guid)
        {
            SetResponse();
            var provider = new LockProviderService(_accessToken);
            var answer = await provider.GetLockRequestAsync(guid);
            _lastResponse = answer.Item2;
            return answer.Item1;
        }
        #endregion

        #region General Requests
        public async Task<List<ResourceLockContract>> GetResourceLockListAsync() => await GetResourceLockListAsync(LoanGuid);
        public async Task<List<ResourceLockContract>> GetResourceLockListAsync(string guid)
        {
            SetResponse();
            var provider = new LockProviderService(_accessToken);
            var results = await provider.ResourceLockListAsync(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<ResourceLockContract> GetCurrentLockAsync(bool exclusiveOnly = false)
        {
            var list = await GetResourceLockListAsync();
            if (list != null && list.Count > 0)
            {
                if (exclusiveOnly)
                {
                    var isExclusive = list.Where(t => t.LockType.ToUpper() == "EXCLUSIVE").First();
                    if (isExclusive != null)
                        return isExclusive;
                }
                else
                    return list[0];
            }
            return null;
        }
        public async Task<string> GetCurrentLockByAsync(bool exclusiveOnly = false)
        {
            ResourceLockContract userId = await GetCurrentLockAsync(exclusiveOnly);

            return (userId != null) ? userId.Userid : string.Empty;
        }
        #endregion

        #region Lock/Unlock Loan
        public async Task<bool> ForceUnlockAsync() => await UnlockLoanAsync(LoanGuid, true);
        public bool Unlock() => UnlockLoanAsync().Result;
        public async Task<bool> UnlockLoanAsync() => await UnlockLoanAsync(LoanGuid, true);
        public async Task<bool> UnlockLoanAsync(bool force = false) => await UnlockLoanAsync(LoanGuid, force);
        public async Task<bool> UnlockLoanAsync(string guid, bool force = false)
        {
            var resourceId = string.Empty;
            var resourceList = GetResourceLockListAsync(guid).Result;
            if (resourceList.Count > 0)
            {
                foreach (var item in resourceList)
                {
                    if (item.Resource.EntityType.ToUpper() == "LOAN")
                    {
                        resourceId = item.Id;
                        break;
                    }
                }
            }
            if (!string.IsNullOrEmpty(resourceId))
            {
                SetResponse();
                var provider = new LockProviderService(_accessToken);
                var result = await provider.UnlockAsync(guid, resourceId, force);
                _lastResponse = result;

                if (result.IsSuccess)
                    _loanLockId = "";

                return result.IsSuccess;
            }
            else
                return true;
        }
        public bool Lock() => LockLoanAsync().Result;
        public async Task<bool> LockLoanAsync() => await LockLoanAsync(LoanGuid, true);
        public async Task<bool> LockLoanAsync(bool force) => await LockLoanAsync(LoanGuid, force);
        public async Task<bool> LockLoanAsync(string guid, bool exclusive)
        {
            var exists = false;
            // Get the resource list
            var resourceList = GetResourceLockListAsync(guid).Result;

            if (IsOkStatus)
            {
                if (resourceList.Count > 0)
                {
                    var found = resourceList.First(t => t.Resource.EntityType.ToUpper() == "LOAN");
                    if (found != null)
                        exists = true;
                }
            }

            if (exists)
            {
                _lastResponse.ErrorMessage = "Lock Id Present...";
                return false;
            }
            else
            {
                try
                {
                    SetResponse();
                    var provider = new LockProviderService(_accessToken);
                    var response = await provider.LockLoanAsync(guid, exclusive);
                    if (response.Item2.IsSuccess)
                        _loanLockId = response.Item1;
                    else
                        _loanLockId = string.Empty;

                    _lastResponse = response.Item2;
                    return response.Item2.IsSuccess;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        #endregion

        #region Rate Lock Operations
        public async Task<RateLockSummaryContract> GetRateLockRequestAsync(string resourceGuid) => await GetRateLockRequestAsync(LoanGuid, resourceGuid);
        public async Task<RateLockSummaryContract> GetRateLockRequestAsync(string guid, string resourceGuid)
        {
            SetResponse();
            var provider = new LockProviderService(_accessToken);
            var result = await provider.GetRateLockRequestAsync(guid, resourceGuid); // .GetRateLockRequestAsync(guid, resourceGuid);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<RateLockSummaryContract> ExtendRateLockAsync(string guid, string resourceGuid, ExtendRateLock detail)
        {
            SetResponse();
            var provider = new LockProviderService(_accessToken);
            var result = await provider.ExtendRateLockRequestAsync(guid, resourceGuid, detail);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<RateLockSummaryContract> RelockRateLockAsync(string guid, string resourceGuid, ExtendRateLock detail)
        {
            SetResponse();
            var provider = new LockProviderService(_accessToken);
            var result = await provider.RelockRateLockRequestAsync(guid, resourceGuid, detail);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<RateLockSummaryContract> ConfirmRateLockAsync(string guid, string resourceGuid, ConfirmRateLock detail)
        {
            SetResponse();
            var provider = new LockProviderService(_accessToken);
            var result = await provider.ConfirmRateLockRequestAsync(guid, resourceGuid, detail);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<RateLockSummaryContract> ReviseRateLockAsync(string guid, string resourceGuid, RateLockSummaryContract detail)
        {
            SetResponse();
            var provider = new LockProviderService(_accessToken);
            var result = await provider.ReviseRateLockRequestAsync(guid, resourceGuid, detail);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<RateLockSummaryContract> CancelRateLockAsync(string guid, string resourceGuid, RateLockSummaryContract detail)
        {
            SetResponse();
            var provider = new LockProviderService(_accessToken);
            var result = await provider.CancelRateLockRequestAsync(guid, resourceGuid, detail);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<List<LoanContractSnapshotFields>> GetRateLockShapshotAsync(string resourceGuid) => await GetRateLockSnapshotAsync(LoanGuid, resourceGuid);
        public async Task<List<LoanContractSnapshotFields>> GetRateLockSnapshotAsync(string guid, string resourceGuid)
        {
            SetResponse();
            var provider = new LockProviderService(_accessToken);
            var result = await provider.GetRateLockSnapshotAsync(guid, resourceGuid);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<bool> ForceUnlockIfMoveToCancelDeclineFolderAsync(LoanFolder loanFolderToMoveTo)
        {
            bool result = false;
            if (_loanV1 != null)
            {
                if (loanFolderToMoveTo != null && loanFolderToMoveTo.Name == "Cancel-Declines")
                {
                    try
                    {
                        await LockLoanAsync();
                    }
                    catch
                    {
                        await UnlockLoanAsync();
                    }
                    finally
                    {
                        await UnlockLoanAsync();
                        result = true;
                    }
                }
            }
            return result;
        }
        #endregion
    }
}
