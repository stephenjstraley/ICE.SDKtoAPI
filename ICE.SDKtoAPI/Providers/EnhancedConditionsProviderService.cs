﻿using Flurl.Http;
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
            List<EnhancedConditionType> types = null;

            var usePath = paths.SettingConditions + "/types";

            try
            {
                types = await Get<List<EnhancedConditionType>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<EnhancedConditionType>, LenderApiResponse>(types, _response);
        }
        public async Task<Tuple<EnhancedConditionType, LenderApiResponse>> GetConditionTypeAsync(string id)
        {
            EnhancedConditionType type = null;

            var usePath = paths.SettingConditions + $"/types/{id}";

            try
            {
                type = await Get<EnhancedConditionType>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<EnhancedConditionType, LenderApiResponse>(type, _response);
        }
        public async Task<Tuple<List<EnhancedConditionType>, LenderApiResponse>> SetConditionTypeAsync(List<EnhancedConditionType> eh, string action)
        {
            List<EnhancedConditionType> types = null;

            var usePath = paths.SettingConditions + $"/types?action={action}&view=entity";

            try
            {
                types = await Patch<List<EnhancedConditionType>>(eh, usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<EnhancedConditionType>, LenderApiResponse>(types, _response);
        }
        #endregion

        #region Template
        public async Task<Tuple<List<EnhancedConditionTemplate>, LenderApiResponse>> GetConditionTemplatesAsync()
        {
            List<EnhancedConditionTemplate> temps = null;

            var usePath = paths.SettingConditions + "/templates";

            try
            {
                temps = await Get<List<EnhancedConditionTemplate>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<EnhancedConditionTemplate>, LenderApiResponse>(temps, _response);
        }
        public async Task<Tuple<EnhancedConditionTemplate, LenderApiResponse>> GetConditionTemplateAsync(string id)
        {
            EnhancedConditionTemplate temp = null;

            var usePath = paths.Settings + $"/templates/{id}";

            try
            {
                temp = await Get<EnhancedConditionTemplate>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<EnhancedConditionTemplate, LenderApiResponse>(temp, _response);
        }
        public async Task<Tuple<List<EnhancedConditionTemplate>, LenderApiResponse>> SetConditionTemplateAsync(List<EnhancedConditionTemplate> eh, string action)
        {
            List<EnhancedConditionTemplate> temp = null;

            var usePath = paths.SettingConditions + $"/templates?action={action}&view=entity";

            try
            {
                temp = await Get<List<EnhancedConditionTemplate>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<EnhancedConditionTemplate>, LenderApiResponse>(temp, _response);
        }
        #endregion

        #region Sets
        public async Task<Tuple<List<EnhancedConditionSet>, LenderApiResponse>> GetConditionSetsAsync()
        {
            List<EnhancedConditionSet> temps = null;

            var usePath = paths.SettingConditions + "/sets";

            try
            {
                temps = await Get<List<EnhancedConditionSet>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<EnhancedConditionSet>, LenderApiResponse>(temps, _response);
        }
        public async Task<Tuple<EnhancedConditionSet, LenderApiResponse>> GetConditionSetAsync(string id)
        {
            EnhancedConditionSet temp = null;

            var usePath = paths.SettingConditions + $"/sets/{id}";

            try
            {
                temp = await Get<EnhancedConditionSet>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<EnhancedConditionSet, LenderApiResponse>(temp, _response);
        }
        #endregion

        #region Status Tracking
        public async Task<Tuple<List<EnhancedConditionTracking>, LenderApiResponse>> GetEnhancedConditionTrackingAsync(string loanGuid, string condId)
        {
            List<EnhancedConditionTracking> tracks = null;

            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{condId}/tracking";

            try
            {
                tracks = await Get<List<EnhancedConditionTracking>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<EnhancedConditionTracking>, LenderApiResponse>(tracks, _response);
        }
        public async Task<Tuple<List<EnhancedConditionTracking>, LenderApiResponse>> SetEnhancedConditionTrackingAsync(string loanGuid, string condId, List<EnhancedConditionTracking> items, string action)
        {
            List<EnhancedConditionTracking> tracks = null;

            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{condId}/tracking/?action={action}&view=entity";

            try
            {
                tracks = await Get<List<EnhancedConditionTracking>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<EnhancedConditionTracking>, LenderApiResponse>(tracks, _response);
        }
        #endregion

        #region Enhanced Conditions
        public async Task<Tuple<List<EnhancedConditionContract>, LenderApiResponse>> GetEnhancedConditionsAsync(string loanGuid)
        {
            List<EnhancedConditionContract> conds = null;

            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions";

            try
            {
                conds = await Get<List<EnhancedConditionContract>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<EnhancedConditionContract>, LenderApiResponse>(conds, _response);
        }
        public async Task<Tuple<EnhancedConditionContract, LenderApiResponse>> GetEnhancedConditionAsync(string loanGuid, string condId)
        {
            EnhancedConditionContract cond = null;

            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{condId}?view=detail";

            try
            {
                cond = await Get<EnhancedConditionContract>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<EnhancedConditionContract, LenderApiResponse>(cond, _response);
        }
        public async Task<Tuple<List<EnhancedConditionContract>, LenderApiResponse>> SetEnhancedConditionAsync(string loanGuid, List<EnhancedConditionContract> conds, string operation)
        {
            List<EnhancedConditionContract> condList = null;

            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions?action={operation}";

            if (operation != "delete")
                usePath += "&view=entity";

            try
            {
                condList = await Patch<List<EnhancedConditionContract>>(conds, usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

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
            List<EnhancedConditionCommentContract> comments = null;

            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{conditionGuid}/comments";

            try
            {
                comments = await Get<List<EnhancedConditionCommentContract>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<EnhancedConditionCommentContract>, LenderApiResponse>(comments, _response);
        }
        public async Task<Tuple<List<EnhancedConditionCommentContract>, LenderApiResponse>> SetEnhancedConditionCommentsAsync(string loanGuid, string conditionGuid, List<EnhancedConditionCommentContract> comments, string action)
        {
            List<EnhancedConditionCommentContract> cs = null;

            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{conditionGuid}/comments?action={action}&view=entity";

            try
            {
                comments = await Patch<List<EnhancedConditionCommentContract>>(comments, usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<EnhancedConditionCommentContract>, LenderApiResponse>(comments, _response);
        }
        #endregion

        public async Task<Tuple<List<EntityReferenceContract>, LenderApiResponse>> GetEnhanceConditionDocumentsAsync(string loanGuid, string conditionGuid)
        {
            List<EntityReferenceContract> docs = null;

            var usePath = paths.LoanPathFull + $"/{loanGuid}/conditions/{conditionGuid}/documents";

            try
            {
                docs = await Get<List<EntityReferenceContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<EntityReferenceContract>, LenderApiResponse>(docs, _response);
        }
    }
}
