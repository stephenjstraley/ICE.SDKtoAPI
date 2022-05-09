using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ICE.SDKtoAPI.Extensions;
using Flurl;

namespace ICE.SDKtoAPI.Providers
{
    public class BaseProviderService : CommonService
    {
        public BaseProviderService(AccessToken token = null) : base(token) {}
        public async Task<Tuple<List<LenderApiContractsV1.OrganizationContract>, LenderApiResponse>> GetOrganizationsAsync()
        {
            List<LenderApiContractsV1.OrganizationContract> orgs = new List<LenderApiContractsV1.OrganizationContract>();
            ClearResponse();

            var usePath = paths.OrganizationsPath + "?view=entity";
            try
            {
                orgs = await Get<List<LenderApiContractsV1.OrganizationContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }
            return new Tuple<List<LenderApiContractsV1.OrganizationContract>, LenderApiResponse>(orgs, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV1.OrganizationHierarchyContract>, LenderApiResponse>> GetOrganizationsHierarchyAsync()
        {
            List<LenderApiContractsV1.OrganizationHierarchyContract> orgs = new List<LenderApiContractsV1.OrganizationHierarchyContract>();
            ClearResponse();

            var usePath = paths.OrganizationsPath + "?view=hierarchy";
            try
            {
                orgs = await Get<List<LenderApiContractsV1.OrganizationHierarchyContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }
            return new Tuple<List<LenderApiContractsV1.OrganizationHierarchyContract>, LenderApiResponse>(orgs, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.FieldSchemaContract>, LenderApiResponse>> GetV3FieldSchemaAsync(int start = 0, int limit = 500)
        {
            List<LenderApiContractsV3.FieldSchemaContract> fields = new List<LenderApiContractsV3.FieldSchemaContract>();
            ClearResponse();

            var usePath = paths.FieldSchemaV3Path + $"?start={start}&limit={limit}";

            try
            {
                fields = await Get<List<LenderApiContractsV3.FieldSchemaContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }
            return new Tuple<List<LenderApiContractsV3.FieldSchemaContract>, LenderApiResponse>(fields, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.FieldSchemaContract>, LenderApiResponse>> GetV3FieldSchemaAsync(string id)
        {
            List<LenderApiContractsV3.FieldSchemaContract> fields = new List<LenderApiContractsV3.FieldSchemaContract>();
            ClearResponse();

            var usePath = paths.FieldSchemaV3Path + $"?ids={id}";

            try
            {
                fields = await Get<List<LenderApiContractsV3.FieldSchemaContract>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.FieldSchemaContract>, LenderApiResponse>(fields, _response);
        }
        public async Task<Tuple<LenderApiContractsV1.FieldSchemaContract, LenderApiResponse>> GetV1FieldSchemaAsync(string id)
        {
            LenderApiContractsV1.FieldSchemaContract field = null;
            ClearResponse();

            var usePath = paths.FieldSchemaV1Path.AppendPathSegment($"{id}");

            try
            {
                field = await Get<LenderApiContractsV1.FieldSchemaContract>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }
            return new Tuple<LenderApiContractsV1.FieldSchemaContract, LenderApiResponse>(field, _response);
        }
        public async Task<Tuple<LenderApiContractsV1.OrganizationContract, LenderApiResponse>> GetOrganizationAsync(string id)
        {
            LenderApiContractsV1.OrganizationContract org = null;
            ClearResponse();

            var usePath = paths.OrganizationPath(id);

            try
            {
                org = await Get<LenderApiContractsV1.OrganizationContract>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<LenderApiContractsV1.OrganizationContract, LenderApiResponse>(org, _response);
        }
        public async Task<Tuple<string, LenderApiResponse>> GetLoanSchemaAsync(bool useV3)
        {
            var path = string.Empty;
            if (useV3)
                path = paths.BasePath + "/encompass/v3/schemas/loan";
            else
                path = paths.BasePath + "/encompass/v1/schema/loan";

            ClearResponse();
            string result = null;

            try
            {
                result = await GetString(path);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, path);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, path);
            }
            return new Tuple<string, LenderApiResponse>(result, _response);
        }
        public string TemplatePath(string folder, string param)
        {
            paths.SetV3();
            var usePath = paths.EncompassPathFull + "/settings/templates";
            usePath += $"{folder}/folders?path={param}";
            return usePath;
        }
        public async Task<Tuple<List<LenderApiContractsV1.EntityRefContract>, LenderApiResponse>> GetLoanTemplateFoldersAsyc(string param)
        {
            List<LenderApiContractsV1.EntityRefContract> sets = null;
            ClearResponse();

            var usePath = paths.EncompassPathFull + $"/settings/folder/{param}";
            try
            {
                sets = await Get<List<LenderApiContractsV1.EntityRefContract>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV1.EntityRefContract>, LenderApiResponse>(sets, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV1.EntityRefContract>, LenderApiResponse>> GetLoanTemplatesAsyc(string param)
        {
            List<LenderApiContractsV1.EntityRefContract> sets = null;
            ClearResponse();

            var usePath = paths.EncompassPathFull + $"/settings/templates/items?path={param}";
            try
            {
                sets = await Get<List<LenderApiContractsV1.EntityRefContract>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }
            return new Tuple<List<LenderApiContractsV1.EntityRefContract>, LenderApiResponse>(sets, _response);
        }
        public async Task<Tuple<LoanTemplateSet, LenderApiResponse>> GetLoanProgramTemplatesAsyc(string param)
        {
            LoanTemplateSet sets = null;

            paths.SetV3();

            var usePath = TemplatePath("loanProgram", param);

            try
            {
                sets = await Get<LoanTemplateSet>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<LoanTemplateSet, LenderApiResponse>(sets, _response);
        }
        public async Task<Tuple<LoanTemplateSet, LenderApiResponse>> GetLoanClosingCostTemplatesAsyc(string param)
        {
            LoanTemplateSet sets = null;
            ClearResponse();

            paths.SetV3();
            var usePath = TemplatePath("closingCost", param);

            try
            {
                sets = await Get<LoanTemplateSet>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }
            return new Tuple<LoanTemplateSet, LenderApiResponse>(sets, _response);
        }
        public async Task<Tuple<LoanTemplateSet, LenderApiResponse>> GetLoanSSPTemplatesAsyc(string param)
        {
            LoanTemplateSet sets = null;
            ClearResponse();

            paths.SetV3();
            var usePath = TemplatePath("settlementServiceProvider", param);
            try
            {
                sets = await Get<LoanTemplateSet>(usePath);

            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }
            return new Tuple<LoanTemplateSet, LenderApiResponse>(sets, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.RecipientContract>, LenderApiResponse>> GetLoanRecipients(string guid)
        {
            List<LenderApiContractsV3.RecipientContract> recips = null;

            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/loans/{guid}/recipients";

            try
            {
                recips = await Get<List<LenderApiContractsV3.RecipientContract>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.RecipientContract>, LenderApiResponse>(recips, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.RegistrationLogContract>, LenderApiResponse>> GetRegistrationLogs(string guid)
        {
            List<LenderApiContractsV3.RegistrationLogContract> logs = null;

            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/loans/{guid}/registrationLogs";

            try
            {
                logs = await Get<List<LenderApiContractsV3.RegistrationLogContract>>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV3.RegistrationLogContract>, LenderApiResponse>(logs, _response);
        }
        public async Task<Tuple<LenderApiContractsV3.RegistrationLogContract, LenderApiResponse>> GetRegistrationLog(string guid, string logId)
        {
            LenderApiContractsV3.RegistrationLogContract log = null;

            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/loans/{guid}/registrationLogs/{logId}";

            try
            {
                log = await Get<LenderApiContractsV3.RegistrationLogContract>(usePath);
            }
            catch (FlurlHttpException e)
            {
                _response = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<LenderApiContractsV3.RegistrationLogContract, LenderApiResponse>(log, _response);
        }

        // Create Reg Log
        // Update Reg Log
    }
}
