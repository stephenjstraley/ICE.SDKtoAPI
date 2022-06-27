using ICE.SDKtoAPI.LenderApiContractsV3;
using ICE.SDKtoAPI.Providers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<EnhancedConditionType>> GetEnhancedConditionTypesAsync();
        Task<EnhancedConditionType> GetEnhancedConditionTypeAsync(string id);
        Task<List<EnhancedConditionType>> AddEnhancedConditionTypeAsync(EnhancedConditionType cond);
        Task<List<EnhancedConditionType>> AddEnhancedConditionTypesAsync(List<EnhancedConditionType> conds);
        Task<List<EnhancedConditionType>> UpdateEnhancedConditionTypeAsync(EnhancedConditionType cond);
        Task<List<EnhancedConditionType>> UpdateEnhancedConditionTypesAsync(List<EnhancedConditionType> cond);
        Task<List<EnhancedConditionType>> DeleteEnhancedConditionTypeAsync(EnhancedConditionType cond);
        Task<List<EnhancedConditionType>> DeleteEnhancedConditionTypesAsync(List<EnhancedConditionType> cond);
        Task<List<EnhancedConditionTemplate>> GetEnhancedConditionTemplatesAsync();
        Task<EnhancedConditionTemplate> GetEnhancedConditionTemplateAsync(string id);
        Task<List<EnhancedConditionTemplate>> AddEnhancedConditionTemplateAsync(EnhancedConditionTemplate temp);
        Task<List<EnhancedConditionTemplate>> AddEnhancedConditionTemplatesAsync(List<EnhancedConditionTemplate> temps);
        Task<List<EnhancedConditionTemplate>> UpdateEnhancedConditionTemplateAsync(EnhancedConditionTemplate temp);
        Task<List<EnhancedConditionTemplate>> UpdateEnhancedConditionTemplatesAsync(List<EnhancedConditionTemplate> temps);
        Task<List<EnhancedConditionTemplate>> DeleteEnhancedConditionTemplateAsync(EnhancedConditionTemplate temp);
        Task<List<EnhancedConditionTemplate>> DeleteEnhancedConditionTemplatesAsync(List<EnhancedConditionTemplate> temps);
        Task<List<EnhancedConditionSet>> GetEnhancedConditionSetsAsync();
        Task<EnhancedConditionSet> GetEnhancedConditionSetAsync(string id);
        Task<List<EnhancedConditionTracking>> GetEnhancedConditionTrackingAsync(string loanGuid, string condId);
        Task<List<EnhancedConditionTracking>> AddEnhancedConditionTrackingAsync(string loanGuid, string condId, EnhancedConditionTracking track);
        Task<List<EnhancedConditionTracking>> AddEnhancedConditionTrackingsAsync(string loanGuid, string condId, List<EnhancedConditionTracking> tracks);
        Task<List<EnhancedConditionTracking>> UpdateEnhancedConditionTrackingAsync(string loanGuid, string condId, EnhancedConditionTracking track);
        Task<List<EnhancedConditionTracking>> UpdateEnhancedConditionTrackingsAsync(string loanGuid, string condId, List<EnhancedConditionTracking> tracks);
        Task<List<EnhancedConditionTracking>> DeleteEnhancedConditionTrackingAsync(string loanGuid, string condId, EnhancedConditionTracking track);
        Task<List<EnhancedConditionTracking>> DeleteEnhancedConditionTrackingsAsync(string loanGuid, string condId, List<EnhancedConditionTracking> tracks);
        Task<List<EnhancedConditionContract>> GetEnhancedConditionsAsync(string loanGuid);
        Task<EnhancedConditionContract> GetEnhancedConditionAsync(string loanGuid, string condId);
        Task<List<EnhancedConditionContract>> AddEnhancedConditionAsync(string loanGuid, EnhancedConditionContract condition);
        Task<List<EnhancedConditionContract>> AddEnhancedConditionsAsync(string loanGuid, List<EnhancedConditionContract> conditions);
        Task<List<EnhancedConditionContract>> UpdateEnhancedConditionAsync(string loanGuid, EnhancedConditionContract condition);
        Task<List<EnhancedConditionContract>> UpdateEnhancedConditionsAsync(string loanGuid, List<EnhancedConditionContract> conditions);
        Task<List<EnhancedConditionContract>> DuplicateEnhancedConditionAsync(string loanGuid, EnhancedConditionContract condition);
        Task<List<EnhancedConditionContract>> DuplicateEnhancedConditionsAsync(string loanGuid, List<EnhancedConditionContract> conditions);
        Task<List<EnhancedConditionContract>> DeleteEnhancedConditionAsync(string loanGuid, EnhancedConditionContract condition);
        Task<List<EnhancedConditionContract>> DeleteEnhancedConditionsAsync(string loanGuid, List<EnhancedConditionContract> conditions);
        Task<List<EnhancedConditionCommentContract>> GetEnhancedConditionCommentsAsync(string loanGuid, string conditionGuid);
        Task<List<EnhancedConditionCommentContract>> AddEnhancedConditionCommentAsync(string loanGuid, string condId, EnhancedConditionCommentContract comm);
        Task<List<EnhancedConditionCommentContract>> AddEnhancedConditionCommentsAsync(string loanGuid, string condId, List<EnhancedConditionCommentContract> comms);
        Task<List<EnhancedConditionCommentContract>> UpdateEnhancedConditionCommentAsync(string loanGuid, string condId, EnhancedConditionCommentContract comm);
        Task<List<EnhancedConditionCommentContract>> UpdateEnhancedConditionCommentsAsync(string loanGuid, string condId, List<EnhancedConditionCommentContract> comms);
        Task<List<EnhancedConditionCommentContract>> DeleteEnhancedConditionCommentAsync(string loanGuid, string condId, EnhancedConditionCommentContract comm);
        Task<List<EnhancedConditionCommentContract>> DeleteEnhancedConditionCommentsAsync(string loanGuid, string condId, List<EnhancedConditionCommentContract> comms);
        Task<List<EntityReferenceContract>> GetEnhancedConditionDocumentsAsync(string loanGuid, string conditionGuid);
    }
    public partial class LenderAPI : ILenderAPI
    {
        #region Enhanced Condition Types
        public async Task<List<EnhancedConditionType>> GetEnhancedConditionTypesAsync()
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.GetConditionTypesAsync();
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<EnhancedConditionType> GetEnhancedConditionTypeAsync(string id)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.GetConditionTypeAsync(id);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionType>> AddEnhancedConditionTypeAsync(EnhancedConditionType cond)
        {
            List<EnhancedConditionType> types = new List<EnhancedConditionType>();
            types.Add(cond);
            return await AddEnhancedConditionTypesAsync(types);
        }
        public async Task<List<EnhancedConditionType>> AddEnhancedConditionTypesAsync(List<EnhancedConditionType> conds)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetConditionTypeAsync(conds, "add");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionType>> UpdateEnhancedConditionTypeAsync(EnhancedConditionType cond)
        {
            List<EnhancedConditionType> types = new List<EnhancedConditionType>();
            types.Add(cond);
            return await UpdateEnhancedConditionTypesAsync(types);
        }
        public async Task<List<EnhancedConditionType>> UpdateEnhancedConditionTypesAsync(List<EnhancedConditionType> cond)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetConditionTypeAsync(cond, "update");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionType>> DeleteEnhancedConditionTypeAsync(EnhancedConditionType cond)
        {
            List<EnhancedConditionType> types = new List<EnhancedConditionType>();
            types.Add(cond);
            return await DeleteEnhancedConditionTypesAsync(types);
        }
        public async Task<List<EnhancedConditionType>> DeleteEnhancedConditionTypesAsync(List<EnhancedConditionType> cond)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetConditionTypeAsync(cond, "delete");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        #endregion

        #region Enhanced Condition Templates
        public async Task<List<EnhancedConditionTemplate>> GetEnhancedConditionTemplatesAsync()
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.GetConditionTemplatesAsync();
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<EnhancedConditionTemplate> GetEnhancedConditionTemplateAsync(string id)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.GetConditionTemplateAsync(id);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionTemplate>> AddEnhancedConditionTemplateAsync(EnhancedConditionTemplate temp)
        {
            List<EnhancedConditionTemplate> temps = new List<EnhancedConditionTemplate>();
            temps.Add(temp);
            return await AddEnhancedConditionTemplatesAsync(temps);
        }
        public async Task<List<EnhancedConditionTemplate>> AddEnhancedConditionTemplatesAsync(List<EnhancedConditionTemplate> temps)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetConditionTemplateAsync(temps, "add");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionTemplate>> UpdateEnhancedConditionTemplateAsync(EnhancedConditionTemplate temp)
        {
            List<EnhancedConditionTemplate> temps = new List<EnhancedConditionTemplate>();
            temps.Add(temp);
            return await UpdateEnhancedConditionTemplatesAsync(temps);
        }
        public async Task<List<EnhancedConditionTemplate>> UpdateEnhancedConditionTemplatesAsync(List<EnhancedConditionTemplate> temps)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetConditionTemplateAsync(temps, "update");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionTemplate>> DeleteEnhancedConditionTemplateAsync(EnhancedConditionTemplate temp)
        {
            List<EnhancedConditionTemplate> temps = new List<EnhancedConditionTemplate>();
            temps.Add(temp);
            return await DeleteEnhancedConditionTemplatesAsync(temps);
        }
        public async Task<List<EnhancedConditionTemplate>> DeleteEnhancedConditionTemplatesAsync(List<EnhancedConditionTemplate> temps)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetConditionTemplateAsync(temps, "delete");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        #endregion

        #region Enhanced Condition Sets
        public async Task<List<EnhancedConditionSet>> GetEnhancedConditionSetsAsync()
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.GetConditionSetsAsync();
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<EnhancedConditionSet> GetEnhancedConditionSetAsync(string id)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.GetConditionSetAsync(id);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        #endregion

        #region Enhanced Condition Status Tracking
        public async Task<List<EnhancedConditionTracking>> GetEnhancedConditionTrackingAsync(string loanGuid, string condId)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.GetEnhancedConditionTrackingAsync(loanGuid, condId);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionTracking>> AddEnhancedConditionTrackingAsync(string loanGuid, string condId, EnhancedConditionTracking track)
        {
            List<EnhancedConditionTracking> tracks = new List<EnhancedConditionTracking>();
            tracks.Add(track);
            return await AddEnhancedConditionTrackingsAsync(loanGuid, condId, tracks);
        }
        public async Task<List<EnhancedConditionTracking>> AddEnhancedConditionTrackingsAsync(string loanGuid, string condId, List<EnhancedConditionTracking> tracks)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetEnhancedConditionTrackingAsync(loanGuid, condId, tracks, "add");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionTracking>> UpdateEnhancedConditionTrackingAsync(string loanGuid, string condId, EnhancedConditionTracking track)
        {
            List<EnhancedConditionTracking> tracks = new List<EnhancedConditionTracking>();
            tracks.Add(track);
            return await UpdateEnhancedConditionTrackingsAsync(loanGuid, condId, tracks);
        }
        public async Task<List<EnhancedConditionTracking>> UpdateEnhancedConditionTrackingsAsync(string loanGuid, string condId, List<EnhancedConditionTracking> tracks)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetEnhancedConditionTrackingAsync(loanGuid, condId, tracks, "update");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionTracking>> DeleteEnhancedConditionTrackingAsync(string loanGuid, string condId, EnhancedConditionTracking track)
        {
            List<EnhancedConditionTracking> tracks = new List<EnhancedConditionTracking>();
            tracks.Add(track);
            return await DeleteEnhancedConditionTrackingsAsync(loanGuid, condId, tracks);
        }
        public async Task<List<EnhancedConditionTracking>> DeleteEnhancedConditionTrackingsAsync(string loanGuid, string condId, List<EnhancedConditionTracking> tracks)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetEnhancedConditionTrackingAsync(loanGuid, condId, tracks, "delete");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        #endregion

        #region Enhanced Condition
        public async Task<List<EnhancedConditionContract>> GetEnhancedConditionsAsync(string loanGuid)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.GetEnhancedConditionsAsync(loanGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<EnhancedConditionContract> GetEnhancedConditionAsync(string loanGuid, string condId)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.GetEnhancedConditionAsync(loanGuid, condId);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionContract>> AddEnhancedConditionAsync(string loanGuid, EnhancedConditionContract condition)
        {
            List<EnhancedConditionContract> conds = new List<EnhancedConditionContract>();
            conds.Add(condition);
            return await AddEnhancedConditionsAsync(loanGuid, conds);
        }
        public async Task<List<EnhancedConditionContract>> AddEnhancedConditionsAsync(string loanGuid, List<EnhancedConditionContract> conditions)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetEnhancedConditionAsync(loanGuid, conditions, "add");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionContract>> UpdateEnhancedConditionAsync(string loanGuid, EnhancedConditionContract condition)
        {
            List<EnhancedConditionContract> conds = new List<EnhancedConditionContract>();
            conds.Add(condition);
            return await UpdateEnhancedConditionsAsync(loanGuid, conds);
        }
        public async Task<List<EnhancedConditionContract>> UpdateEnhancedConditionsAsync(string loanGuid, List<EnhancedConditionContract> conditions)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetEnhancedConditionAsync(loanGuid, conditions, "update");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionContract>> DuplicateEnhancedConditionAsync(string loanGuid, EnhancedConditionContract condition)
        {
            List<EnhancedConditionContract> conds = new List<EnhancedConditionContract>();
            conds.Add(condition);
            return await DuplicateEnhancedConditionsAsync(loanGuid, conds);
        }
        public async Task<List<EnhancedConditionContract>> DuplicateEnhancedConditionsAsync(string loanGuid, List<EnhancedConditionContract> conditions)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetEnhancedConditionAsync(loanGuid, conditions, "duplicate");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionContract>> DeleteEnhancedConditionAsync(string loanGuid, EnhancedConditionContract condition)
        {
            List<EnhancedConditionContract> conds = new List<EnhancedConditionContract>();
            conds.Add(condition);
            return await DeleteEnhancedConditionsAsync(loanGuid, conds);
        }
        public async Task<List<EnhancedConditionContract>> DeleteEnhancedConditionsAsync(string loanGuid, List<EnhancedConditionContract> conditions)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetEnhancedConditionAsync(loanGuid, conditions, "delete");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        #endregion

        #region Enhanced Condition Comments
        public async Task<List<EnhancedConditionCommentContract>> GetEnhancedConditionCommentsAsync(string loanGuid, string conditionGuid)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.GetEnhanceConditionCommentsAsync(loanGuid, conditionGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionCommentContract>> AddEnhancedConditionCommentAsync(string loanGuid, string condId, EnhancedConditionCommentContract comm)
        {
            List<EnhancedConditionCommentContract> comms = new List<EnhancedConditionCommentContract>();
            comms.Add(comm);
            return await AddEnhancedConditionCommentsAsync(loanGuid, condId, comms);
        }
        public async Task<List<EnhancedConditionCommentContract>> AddEnhancedConditionCommentsAsync(string loanGuid, string condId, List<EnhancedConditionCommentContract> comms)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetEnhancedConditionCommentsAsync(loanGuid, condId, comms, "add");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionCommentContract>> UpdateEnhancedConditionCommentAsync(string loanGuid, string condId, EnhancedConditionCommentContract comm)
        {
            List<EnhancedConditionCommentContract> comms = new List<EnhancedConditionCommentContract>();
            comms.Add(comm);
            return await UpdateEnhancedConditionCommentsAsync(loanGuid, condId, comms);
        }
        public async Task<List<EnhancedConditionCommentContract>> UpdateEnhancedConditionCommentsAsync(string loanGuid, string condId, List<EnhancedConditionCommentContract> comms)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetEnhancedConditionCommentsAsync(loanGuid, condId, comms, "update");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<EnhancedConditionCommentContract>> DeleteEnhancedConditionCommentAsync(string loanGuid, string condId, EnhancedConditionCommentContract comm)
        {
            List<EnhancedConditionCommentContract> comms = new List<EnhancedConditionCommentContract>();
            comms.Add(comm);
            return await DeleteEnhancedConditionCommentsAsync(loanGuid, condId, comms);
        }
        public async Task<List<EnhancedConditionCommentContract>> DeleteEnhancedConditionCommentsAsync(string loanGuid, string condId, List<EnhancedConditionCommentContract> comms)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.SetEnhancedConditionCommentsAsync(loanGuid, condId, comms, "delete");
            _lastResponse = results.Item2;
            return results.Item1;
        }
        #endregion

        #region Documents
        public async Task<List<EntityReferenceContract>> GetEnhancedConditionDocumentsAsync(string loanGuid, string conditionGuid)
        {
            SetResponse();
            var provider = new EnhancedConditionsProviderService(_accessToken);
            var results = await provider.GetEnhanceConditionDocumentsAsync(loanGuid, conditionGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        #endregion
    }
}
