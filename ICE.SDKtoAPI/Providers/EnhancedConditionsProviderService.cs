using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV3;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class EnhancedConditionsProviderService : BaseProviderService
    {
        public EnhancedConditionsProviderService(AccessToken token) : base(token) { paths.SetV3(); }

        #region Types
        public async Task<Tuple<List<EnhancedConditionType>, LenderApiResponse>> GetConditionTypesAsync()
        {
            var usePath = paths.SettingConditions + "/types";

            List<EnhancedConditionType> types = await Get<List<EnhancedConditionType>>(usePath);

            return new Tuple<List<EnhancedConditionType>, LenderApiResponse>(types, _response);
        }
        public async Task<Tuple<EnhancedConditionType, LenderApiResponse>> GetConditionTypeAsync(string id)
        {
            var usePath = paths.SettingConditions + $"/types/{id}";

            EnhancedConditionType type = await Get<EnhancedConditionType>(usePath);

            return new Tuple<EnhancedConditionType, LenderApiResponse>(type, _response);
        }
        public async Task<Tuple<List<EnhancedConditionType>, LenderApiResponse>> SetConditionTypeAsync(List<EnhancedConditionType> eh, string action)
        {
            var usePath = paths.SettingConditions + $"/types?action={action}&view=entity";

            List<EnhancedConditionType> types = await Patch<List<EnhancedConditionType>>(eh, usePath);

            return new Tuple<List<EnhancedConditionType>, LenderApiResponse>(types, _response);
        }
        #endregion

        #region Template
        public async Task<Tuple<List<EnhancedConditionTemplate>, LenderApiResponse>> GetConditionTemplatesAsync()
        {
            var usePath = paths.SettingConditions + "/templates";

            List<EnhancedConditionTemplate> temps = await Get<List<EnhancedConditionTemplate>>(usePath);

            return new Tuple<List<EnhancedConditionTemplate>, LenderApiResponse>(temps, _response);
        }
        public async Task<Tuple<EnhancedConditionTemplate, LenderApiResponse>> GetConditionTemplateAsync(string id)
        {
            var usePath = paths.Settings + $"/templates/{id}";

            EnhancedConditionTemplate temp = await Get<EnhancedConditionTemplate>(usePath);

            return new Tuple<EnhancedConditionTemplate, LenderApiResponse>(temp, _response);
        }
        public async Task<Tuple<List<EnhancedConditionTemplate>, LenderApiResponse>> SetConditionTemplateAsync(List<EnhancedConditionTemplate> eh, string action)
        {
            var usePath = paths.SettingConditions + $"/templates?action={action}&view=entity";

            List<EnhancedConditionTemplate> temp = await Get<List<EnhancedConditionTemplate>>(usePath);

            return new Tuple<List<EnhancedConditionTemplate>, LenderApiResponse>(temp, _response);
        }
        #endregion

        #region Sets
        public async Task<Tuple<List<EnhancedConditionSet>, LenderApiResponse>> GetConditionSetsAsync()
        {
            var usePath = paths.SettingConditions + "/sets";

            List<EnhancedConditionSet> temps = await Get<List<EnhancedConditionSet>>(usePath);

            return new Tuple<List<EnhancedConditionSet>, LenderApiResponse>(temps, _response);
        }
        public async Task<Tuple<EnhancedConditionSet, LenderApiResponse>> GetConditionSetAsync(string id)
        {
            var usePath = paths.SettingConditions + $"/sets/{id}";

            EnhancedConditionSet temp = await Get<EnhancedConditionSet>(usePath);

            return new Tuple<EnhancedConditionSet, LenderApiResponse>(temp, _response);
        }
        #endregion

        #region Status Tracking
        public async Task<Tuple<List<EnhancedConditionTracking>, LenderApiResponse>> GetEnhancedConditionTrackingAsync(string loanGuid, string condId)
        {
            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{condId}/tracking";

            List<EnhancedConditionTracking> tracks = await Get<List<EnhancedConditionTracking>>(usePath);

            return new Tuple<List<EnhancedConditionTracking>, LenderApiResponse>(tracks, _response);
        }
        public async Task<Tuple<List<EnhancedConditionTracking>, LenderApiResponse>> SetEnhancedConditionTrackingAsync(string loanGuid, string condId, List<EnhancedConditionTracking> items, string action)
        {
            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{condId}/tracking/?action={action}&view=entity";

            List<EnhancedConditionTracking> tracks = await Get<List<EnhancedConditionTracking>>(usePath);

            return new Tuple<List<EnhancedConditionTracking>, LenderApiResponse>(tracks, _response);
        }
        #endregion

        #region Enhanced Conditions
        public async Task<Tuple<List<EnhancedConditionContract>, LenderApiResponse>> GetEnhancedConditionsAsync(string loanGuid)
        {
            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions";

            List<EnhancedConditionContract> conds = await Get<List<EnhancedConditionContract>>(usePath);

            return new Tuple<List<EnhancedConditionContract>, LenderApiResponse>(conds, _response);
        }
        public async Task<Tuple<EnhancedConditionContract, LenderApiResponse>> GetEnhancedConditionAsync(string loanGuid, string condId)
        {
            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{condId}?view=detail";

            EnhancedConditionContract cond = await Get<EnhancedConditionContract>(usePath);

            return new Tuple<EnhancedConditionContract, LenderApiResponse>(cond, _response);
        }
        public async Task<Tuple<List<EnhancedConditionContract>, LenderApiResponse>> SetEnhancedConditionAsync(string loanGuid, List<EnhancedConditionContract> conds, string operation)
        {
            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions?action={operation}";

            if (operation != "delete")
                usePath += "&view=entity";

            List<EnhancedConditionContract> condList = await Patch<List<EnhancedConditionContract>>(conds, usePath);

            return new Tuple<List<EnhancedConditionContract>, LenderApiResponse>(condList, _response);
        }
        #endregion
        /// Add condition
        /// Update condition
        /// Remove condition 
        /// Duplicate condition


        #region Comments
        public async Task<Tuple<List<EnhancedConditionCommentContract>, LenderApiResponse>> GetEnhanceConditionCommentsAsync(string loanGuid, string conditionGuid)
        {
            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{conditionGuid}/comments";

            List<EnhancedConditionCommentContract> comments = await Get<List<EnhancedConditionCommentContract>>(usePath);

            return new Tuple<List<EnhancedConditionCommentContract>, LenderApiResponse>(comments, _response);
        }
        public async Task<Tuple<List<EnhancedConditionCommentContract>, LenderApiResponse>> SetEnhancedConditionCommentsAsync(string loanGuid, string conditionGuid, List<EnhancedConditionCommentContract> comments, string action)
        {
            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{conditionGuid}/comments?action={action}&view=entity";

            comments = await Patch<List<EnhancedConditionCommentContract>>(comments, usePath);

            return new Tuple<List<EnhancedConditionCommentContract>, LenderApiResponse>(comments, _response);
        }
        #endregion

        public async Task<Tuple<List<EntityReferenceContract>, LenderApiResponse>> GetEnhanceConditionDocumentsAsync(string loanGuid, string conditionGuid)
        {
            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{conditionGuid}/documents";

            List<EntityReferenceContract> docs = await Get<List<EntityReferenceContract>>(usePath);

            return new Tuple<List<EntityReferenceContract>, LenderApiResponse>(docs, _response);
        }
    }
}
