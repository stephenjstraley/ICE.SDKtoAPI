﻿using ICE.SDKtoAPI.Contracts;
using System;
using System.Collections.Generic;
using Flurl;
using System.Threading.Tasks;
using Flurl.Http;
using ICE.SDKtoAPI.Extensions;
using System.Net.Http;
using System.Net;

namespace ICE.SDKtoAPI.Providers
{
    public class LoanProviderService : BaseProviderService
    {
        public LoanProviderService(AccessToken token = null) : base(token) { paths.SetV1(); }

        public async Task<Tuple<V3LoanSchema, LenderApiResponse>> GetV3LoanSchemaAsync()
        {
            paths.SetV3();
            V3LoanSchema schema = null;

            var usePath = paths.EncompassPathFull.AppendPathSegment("/schema/loan");

            try
            {
                schema = await Get<V3LoanSchema>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<V3LoanSchema, LenderApiResponse>(schema, _response);
        }
        public async Task<Tuple<LenderApiContractsV1.LoanContract, string, LenderApiResponse>> GetLoanAsync(string guid)
        {
            paths.SetV1();
            LenderApiContractsV1.LoanContract theFullLoan = null;
            string rawLoan = null;

            var usePath = paths.LoanPathFull.AppendPathSegment($"/{guid}");

            try
            {
                rawLoan = await GetString(usePath);

                theFullLoan = await Get<LenderApiContractsV1.LoanContract>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<LenderApiContractsV1.LoanContract, string, LenderApiResponse>(theFullLoan, rawLoan, _response);
        }
        public async Task<Tuple<LenderApiContractsV3.LoanContract, string, LenderApiResponse>> GetV3LoanAsync(string guid, bool withNulls = false)
        {
            LenderApiContractsV3.LoanContract theFullLoan = null;
            var result = string.Empty;

            paths.SetV3();

            var additional = string.Empty;
            if (withNulls)
                additional += "?includeEmpty=true";

            var usePath = paths.LoanPathFull.AppendPathSegment($"/{guid}{additional}");

            try
            {
                theFullLoan = await Get<LenderApiContractsV3.LoanContract>(usePath);
                result = await GetString(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<LenderApiContractsV3.LoanContract, string, LenderApiResponse>(theFullLoan, result, _response);
        }
        public async Task<Tuple<LenderApiContractsV1.LoanContract, LenderApiResponse>> CreateLoanAsync(LenderApiContractsV1.LoanContractBase loan, string folderName)
        {
            LenderApiContractsV1.LoanContract value = null;
            LenderApiResponse apiResponse;

            paths.SetV3();

            var usePath = paths.CreateLoan(folderName);

            try
            {
                value = await Post<LenderApiContractsV1.LoanContract>(loan, usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            paths.SetV1();

            return new Tuple<LenderApiContractsV1.LoanContract, LenderApiResponse>(value, _response);
        }
        public async Task<Tuple<LenderApiContractsV1.LoanMetaData, LenderApiResponse>> GetLoanMetaDataAsync(string guid)
        {
            LenderApiContractsV1.LoanMetaData data = null;

            var usePath = paths.GetMetaData(guid);

            try
            {
                data = await Get<LenderApiContractsV1.LoanMetaData>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<LenderApiContractsV1.LoanMetaData, LenderApiResponse>(data, _response);
        }
        public async Task<Tuple<List<VirtualFieldMeta>, LenderApiResponse>> GetVirutalFieldsAsync()
        {
            List<VirtualFieldMeta> fields = null;
            paths.SetV3(); // this only works for V3

            var usePath = paths.VirtualFieldPathFull;

            try
            {
                fields = await Get<List<VirtualFieldMeta>>(usePath);

            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<VirtualFieldMeta>, LenderApiResponse>(fields, _response);
        }
        public async Task<Tuple<object, LenderApiResponse>> GetFieldValuesAsync(string guid, List<string> fields)
        {
            LenderApiResponse apiResponse = null;
            object pairs = null;

            paths.SetV3(); // this only works for V3

            var usePath = paths.ReadFieldValues(guid);

            try
            {
                var client = Authenticate(usePath);

                var resp = await client.WithHeader("Content-Type", "application/json")
                                       .PostJsonAsync(fields);

                pairs = resp.ReceiveJson<object>();

                apiResponse = OkResponse(resp.Headers, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath);
            }

            return new Tuple<object, LenderApiResponse>(pairs, apiResponse);
        }
        public async Task<Tuple<List<CustomFieldMeta>, LenderApiResponse>> GetCustomFieldsAsync(bool withV3 = false)
        {
            List<CustomFieldMeta> fields = null;

            if (withV3) paths.SetV3();
            else paths.SetV1();

            var usePath = paths.CustomFieldPathFull;

            try
            {
                fields = await Get<List<CustomFieldMeta>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<CustomFieldMeta>, LenderApiResponse>(fields, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV1.LoanContractLoanAssociate>, LenderApiResponse>> GetLoanAssociatesAsync(string guid)
        {
            List<LenderApiContractsV1.LoanContractLoanAssociate> associates = null;

            paths.SetV1();

            var usePath = paths.AssociatesPath(guid);

            try
            {
                associates = await Get<List<LenderApiContractsV1.LoanContractLoanAssociate>>(usePath); 
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV1.LoanContractLoanAssociate>, LenderApiResponse>(associates, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV1.LoanUnderwritingConditionsContract>, LenderApiResponse>> GetUnderwitingConditionsAsync(string guid)
        {
            List<LenderApiContractsV1.LoanUnderwritingConditionsContract> conditions = null;

            var usePath = paths.UnderwritingConditionsPath(guid);

            paths.SetV1();

            try
            {
                conditions = await Get<List<LenderApiContractsV1.LoanUnderwritingConditionsContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV1.LoanUnderwritingConditionsContract>, LenderApiResponse>(conditions, _response);
        }
        public async Task<Tuple<LenderApiContractsV1.LoanContract, LenderApiResponse>> GetBorrowerCoborrowerAsync(string guid)
        {
            LenderApiContractsV1.LoanContract theFullLoan = null;

            paths.SetV1();

            var usePath = paths.BorrowCorBorrowEntityPath(guid);

            try
            {
                theFullLoan = await Get<LenderApiContractsV1.LoanContract>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<LenderApiContractsV1.LoanContract, LenderApiResponse>(theFullLoan, _response);
        }
        public async Task<LenderApiResponse> UpdateLoanAsync(string guid, LenderApiContractsV1.LoanContract loan)
        {
            paths.SetV1();

            var usePath = $"{paths.LoanPathFull}/{guid}";

            try
            {
                var temp = await Patch<string>(loan, usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return _response;
        }
        public async Task<LenderApiResponse> UpdateLoanAsync(string guid, LenderApiContractsV3.LoanContract loan, string lockId = null)
        {
            paths.SetV3();

            var usePath = $"{paths.LoanPathFull}/{guid}?view=entity";

            if (!string.IsNullOrEmpty(lockId))
                usePath += $"&lockId={lockId}";

            try
            {
                if (!string.IsNullOrEmpty(guid) && loan != null)
                {
                    await Patch(loan, usePath);
                }
                else
                {
                    _response = BadResponse(System.Net.HttpStatusCode.BadRequest, "LOAN is null or GUID was empty", "LOAN is null or GUID was empty");
                }
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return _response;
        }
        public async Task<LenderApiResponse> DeleteLoanAsync(string guid, bool loanV3 = false)
        {
            if (loanV3)
                paths.SetV3();
            else
                paths.SetV1();

            var usePath = $"{paths.LoanPathFull}/{guid}";

            if (loanV3)
                usePath += "?elli_idt=enterprise";

            try
            {
                await Delete(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return _response;
        }
        public async Task<LenderApiResponse> EncompassBatchUpdateAsync(object data)
        {
            paths.SetV1();

            var usePath = paths.BatchPath;

            try
            {
                if (data != null)
                {
                    await Post(data, usePath);
                }
                else
                {
                    _response = BadResponse(System.Net.HttpStatusCode.BadRequest, "Parameter was null", "Parameter was null");
                }
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return _response;
        }
        public async Task<Tuple<List<LenderApiContractsV1.LoanContractConversationLogs>, LenderApiResponse>> GetConversationLogsAsync(string guid)
        {
            List<LenderApiContractsV1.LoanContractConversationLogs> conversations = null;

            paths.SetV1();

            var usePath = paths.ConversationsPath(guid);

            try
            {
                conversations = await Get<List<LenderApiContractsV1.LoanContractConversationLogs>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV1.LoanContractConversationLogs>, LenderApiResponse>(conversations, _response);
        }
        public async Task<Tuple<LenderApiContractsV1.LoanContractConversationLogs, LenderApiResponse>> GetConversationLogAsync(string guid, string id)
        {
            LenderApiContractsV1.LoanContractConversationLogs conversation = null;

            paths.SetV1();

            var usePath = paths.ConversationsPath(guid) + $"/{id}";

            try
            {
                conversation = await Get<LenderApiContractsV1.LoanContractConversationLogs>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<LenderApiContractsV1.LoanContractConversationLogs, LenderApiResponse>(conversation, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV1.LoanContractDisclosureTracking2015Logs>, LenderApiResponse>> GetDisclosureTrackingLogsAsync(string guid)
        {
            List<LenderApiContractsV1.LoanContractDisclosureTracking2015Logs> logs = null;

            paths.SetV1();

            var usePath = paths.DisclosureTrackingPath(guid);

            try
            {
                logs = await Get<List<LenderApiContractsV1.LoanContractDisclosureTracking2015Logs>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV1.LoanContractDisclosureTracking2015Logs>, LenderApiResponse>(logs, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.ResidenceContract>, LenderApiResponse>> GetResidences(string guid, string appGuid, bool borrower = true)
        {
            paths.SetV3();

            List<LenderApiContractsV3.ResidenceContract> residences = null;

            string appType = borrower ? "borrower" : "coborrower";

            var usePath = paths.Residences(guid, appGuid, appType);

            try
            {
                residences = await Get<List<LenderApiContractsV3.ResidenceContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.ResidenceContract>, LenderApiResponse>(residences, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.GiftGrantContract>, LenderApiResponse>> GetGiftsGrants(string guid, string appGuid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.GiftGrantContract> giftsGrants = null;

            var usePath = paths.GiftsGrants(guid, appGuid);

            try
            {
                giftsGrants = await Get<List<LenderApiContractsV3.GiftGrantContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.GiftGrantContract>, LenderApiResponse>(giftsGrants, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.AdditionalLoanContract>, LenderApiResponse>> GetAdditionalLoans(string guid, string appGuid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.AdditionalLoanContract> additionalLoans = null;

            var usePath = paths.AdditionaLoans(guid, appGuid);

            try
            {
                additionalLoans = await Get<List<LenderApiContractsV3.AdditionalLoanContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.AdditionalLoanContract>, LenderApiResponse>(additionalLoans, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.OtherAssetContract>, LenderApiResponse>> GetOtherAssets(string guid, string appGuid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.OtherAssetContract> otherAssets = null;

            var usePath = paths.OtherAssets(guid, appGuid);

            try
            {
                otherAssets = await Get<List<LenderApiContractsV3.OtherAssetContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.OtherAssetContract>, LenderApiResponse>(otherAssets, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.OtherIncomeSourceContract>, LenderApiResponse>> GetOtherIncomeSources(string guid, string appGuid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.OtherIncomeSourceContract> otherSources = null;

            var usePath = paths.OtherIncomeSources(guid, appGuid);

            try
            {
                otherSources = await Get<List<LenderApiContractsV3.OtherIncomeSourceContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.OtherIncomeSourceContract>, LenderApiResponse>(otherSources, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.OtherLiabilityContract>, LenderApiResponse>> GetOtherLiabilities(string guid, string appGuid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.OtherLiabilityContract> otherLiabilities = null;

            var usePath = paths.OtherLiabilities(guid, appGuid);

            try
            {
                otherLiabilities = await Get<List<LenderApiContractsV3.OtherLiabilityContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.OtherLiabilityContract>, LenderApiResponse>(otherLiabilities, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.NonVolContract>, LenderApiResponse>> GetNonVols(string guid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.NonVolContract> nonVols = null;

            var usePath = paths.NonVols(guid);

            try
            {
                nonVols = await Get<List<LenderApiContractsV3.NonVolContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.NonVolContract>, LenderApiResponse>(nonVols, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>, LenderApiResponse>> GetAffliatedBusinessArrangements(string guid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> affs = null;

            var usePath = paths.AffiliatedBusinessArrangements(guid);

            try
            {
                affs = await Get<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>, LenderApiResponse>(affs, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.ServiceProviderContract>, LenderApiResponse>> GetServiceProviders(string guid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.ServiceProviderContract> sps = null;

            var usePath = paths.ServiceProviders(guid);

            try
            {
                sps = await Get<List<LenderApiContractsV3.ServiceProviderContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.ServiceProviderContract>, LenderApiResponse>(sps, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.HomeCounselingProviderContract>, LenderApiResponse>> GetHomeCounselingProviders(string guid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.HomeCounselingProviderContract> hcps = null;

            var usePath = paths.ServiceProviders(guid);

            try
            {
                hcps = await Get<List<LenderApiContractsV3.HomeCounselingProviderContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.HomeCounselingProviderContract>, LenderApiResponse>(hcps, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.EmploymentContract>, LenderApiResponse>> GetEmployments(string guid, string appGuid, bool borrower = true)
        {
            paths.SetV3();

            List<LenderApiContractsV3.EmploymentContract> employments = null;

            string appType = borrower ? "borrower" : "coborrower";

            var usePath = paths.Employments(guid, appGuid, appType);

            try
            {
                employments = await Get<List<LenderApiContractsV3.EmploymentContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.EmploymentContract>, LenderApiResponse>(employments, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.ReoPropertyContract>, LenderApiResponse>> GetReoProperties(string guid, string appGuid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.ReoPropertyContract> reos = null;

            var usePath = paths.ReoProperties(guid, appGuid);

            try
            {
                reos = await Get<List<LenderApiContractsV3.ReoPropertyContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.ReoPropertyContract>, LenderApiResponse>(reos, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.VolContract>, LenderApiResponse>> GetVols(string guid, string appGuid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.VolContract> vols = null;

            var usePath = paths.Vols(guid, appGuid);

            try
            {
                vols = await Get<List<LenderApiContractsV3.VolContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.VolContract>, LenderApiResponse>(vols, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.VodContract>, LenderApiResponse>> GetVods(string guid, string appGuid)
        {
            paths.SetV3();

            List<LenderApiContractsV3.VodContract> vods = null;

            var usePath = paths.Vods(guid, appGuid);

            try
            {
                vods = await Get<List<LenderApiContractsV3.VodContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.VodContract>, LenderApiResponse>(vods, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.UrlaAlternateNameContract>, LenderApiResponse>> GetURLAAlternateNames(string guid, string appGuid, bool borrower = true)
        {
            paths.SetV3();

            List<LenderApiContractsV3.UrlaAlternateNameContract> alterNames = null;

            string appType = borrower ? "borrower" : "coborrower";

            var usePath = paths.URLAAlternateNames(guid, appGuid, appType);

            try
            {
                alterNames = await Get<List<LenderApiContractsV3.UrlaAlternateNameContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.UrlaAlternateNameContract>, LenderApiResponse>(alterNames, _response);
        }
        private async Task<Tuple<HttpResponseMessage, LenderApiResponse>> ManageOperations(string path, object contract)
        {
            try
            {
                var client = Authenticate(path);

                var response = await client.PatchJsonAsync(contract);

                if ((int)response.StatusCode >= 300)
                    return new Tuple<HttpResponseMessage, LenderApiResponse>(null, BadResponse(response.StatusCode, response.ReasonPhrase, ""));
                else
                    return new Tuple<HttpResponseMessage, LenderApiResponse>(response, OkResponse(response, path));
            }
            catch (FlurlHttpException e)
            {
                return new Tuple<HttpResponseMessage, LenderApiResponse>(null, BadResponse(e, path));
            }
            catch (Exception exp)
            {
                return new Tuple<HttpResponseMessage, LenderApiResponse>(null, BadResponse(exp, path));
            }
        }
        public async Task<Tuple<List<LenderApiContractsV3.ResidenceContract>, LenderApiResponse>> ManageResidence(string action, string guid, string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            string appType = forBorrower ? "borrower" : "coborrower";

            var usePath = paths.Residences(guid, appGuid, appType);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.ResidenceContract>>();

                return new Tuple<List<LenderApiContractsV3.ResidenceContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.ResidenceContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.GiftGrantContract>, LenderApiResponse>> ManageGiftsGrants(string action, string guid, string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.GiftsGrants(guid, appGuid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.GiftGrantContract>>();

                return new Tuple<List<LenderApiContractsV3.GiftGrantContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.GiftGrantContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.AdditionalLoanContract>, LenderApiResponse>> ManageAdditionalLoans(string action, string guid, string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.AdditionaLoans(guid, appGuid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";
            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.AdditionalLoanContract>>();

                return new Tuple<List<LenderApiContractsV3.AdditionalLoanContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.AdditionalLoanContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.OtherAssetContract>, LenderApiResponse>> ManageOtherAssets(string action, string guid, string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.OtherAssets(guid, appGuid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.OtherAssetContract>>();

                return new Tuple<List<LenderApiContractsV3.OtherAssetContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.OtherAssetContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.OtherIncomeSourceContract>, LenderApiResponse>> ManageOtherIncomeSources(string action, string guid, string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.OtherIncomeSources(guid, appGuid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.OtherIncomeSourceContract>>();

                return new Tuple<List<LenderApiContractsV3.OtherIncomeSourceContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.OtherIncomeSourceContract>, LenderApiResponse>(null, apiResponse);
        }

        public async Task<Tuple<List<LenderApiContractsV3.OtherLiabilityContract>, LenderApiResponse>> ManageOtherLiabilities(string action, string guid, string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.OtherLiabilities(guid, appGuid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.OtherLiabilityContract>>();

                return new Tuple<List<LenderApiContractsV3.OtherLiabilityContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.OtherLiabilityContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.NonVolContract>, LenderApiResponse>> ManageNonVols(string action, string guid, List<LenderApiContractsV3.NonVolContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.NonVols(guid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.NonVolContract>>();

                return new Tuple<List<LenderApiContractsV3.NonVolContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.NonVolContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>, LenderApiResponse>> ManageAffiliatedBusinessArrangements(string action, string guid, List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.AffiliatedBusinessArrangements(guid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>>();

                return new Tuple<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.ServiceProviderContract>, LenderApiResponse>> ManageServiceProviders(string action, string guid, List<LenderApiContractsV3.ServiceProviderContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.ServiceProviders(guid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.ServiceProviderContract>>();

                return new Tuple<List<LenderApiContractsV3.ServiceProviderContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.ServiceProviderContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.HomeCounselingProviderContract>, LenderApiResponse>> ManageHomeCouncilingProviders(string action, string guid, List<LenderApiContractsV3.HomeCounselingProviderContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.HomeCouncelingProviders(guid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.HomeCounselingProviderContract>>();

                return new Tuple<List<LenderApiContractsV3.HomeCounselingProviderContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.HomeCounselingProviderContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.EmploymentContract>, LenderApiResponse>> ManageEmployment(string action, string guid, string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            string appType = forBorrower ? "borrower" : "coborrower";

            var usePath = paths.Employments(guid, appGuid, appType);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.EmploymentContract>>();

                return new Tuple<List<LenderApiContractsV3.EmploymentContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.EmploymentContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.ReoPropertyContract>, LenderApiResponse>> ManageReoProperties(string action, string guid, string appGuid, List<LenderApiContractsV3.ReoPropertyContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.ReoProperties(guid, appGuid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.ReoPropertyContract>>();

                return new Tuple<List<LenderApiContractsV3.ReoPropertyContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.ReoPropertyContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.VolContract>, LenderApiResponse>> ManageVols(string action, string guid, string appGuid, List<LenderApiContractsV3.VolContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.Vols(guid, appGuid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.VolContract>>();

                return new Tuple<List<LenderApiContractsV3.VolContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.VolContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.VodContract>, LenderApiResponse>> ManageVods(string action, string guid, string appGuid, List<LenderApiContractsV3.VodContract> contract)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            var usePath = paths.Vods(guid, appGuid);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.VodContract>>();

                return new Tuple<List<LenderApiContractsV3.VodContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.VodContract>, LenderApiResponse>(null, apiResponse);
        }
        public async Task<Tuple<List<LenderApiContractsV3.UrlaAlternateNameContract>, LenderApiResponse>> ManageUrlaAlternaNames(string action, string guid, string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true)
        {
            paths.SetV3();

            LenderApiResponse apiResponse = null;

            string appType = forBorrower ? "borrower" : "coborrower";

            var usePath = paths.URLAAlternateNames(guid, appGuid, appType);

            if (action != "add" && action != "update" && action != "delete")
                apiResponse = BadResponse(HttpStatusCode.BadRequest, "Invalid Action String", "");

            usePath += $"?action={action}&view=entity";

            if (apiResponse == null)
            {
                var ret = await ManageOperations(usePath, contract);
                var resp = ret.Item1;
                var val = resp.ReceiveJson<List<LenderApiContractsV3.UrlaAlternateNameContract>>();

                return new Tuple<List<LenderApiContractsV3.UrlaAlternateNameContract>, LenderApiResponse>(val, ret.Item2);
            }
            else
                return new Tuple<List<LenderApiContractsV3.UrlaAlternateNameContract>, LenderApiResponse>(null, apiResponse);
        }
    }
}