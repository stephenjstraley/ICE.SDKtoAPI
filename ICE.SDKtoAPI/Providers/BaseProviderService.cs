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

            orgs = await Get<List<LenderApiContractsV1.OrganizationContract>>(usePath);

            return new Tuple<List<LenderApiContractsV1.OrganizationContract>, LenderApiResponse>(orgs, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV1.OrganizationHierarchyContract>, LenderApiResponse>> GetOrganizationsHierarchyAsync()
        {
            List<LenderApiContractsV1.OrganizationHierarchyContract> orgs = new List<LenderApiContractsV1.OrganizationHierarchyContract>();
            ClearResponse();

            var usePath = paths.OrganizationsPath + "?view=hierarchy";

            orgs = await Get<List<LenderApiContractsV1.OrganizationHierarchyContract>>(usePath);

            return new Tuple<List<LenderApiContractsV1.OrganizationHierarchyContract>, LenderApiResponse>(orgs, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.FieldSchemaContract>, LenderApiResponse>> GetV3FieldSchemaAsync(int start = 0, int limit = 500)
        {
            List<LenderApiContractsV3.FieldSchemaContract> fields = new List<LenderApiContractsV3.FieldSchemaContract>();
            ClearResponse();

            var usePath = paths.FieldSchemaV3Path + $"?start={start}&limit={limit}";

            fields = await Get<List<LenderApiContractsV3.FieldSchemaContract>>(usePath);

            return new Tuple<List<LenderApiContractsV3.FieldSchemaContract>, LenderApiResponse>(fields, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.FieldSchemaContract>, LenderApiResponse>> GetV3FieldSchemaAsync(string id)
        {
            List<LenderApiContractsV3.FieldSchemaContract> fields = new List<LenderApiContractsV3.FieldSchemaContract>();
            ClearResponse();

            var usePath = paths.FieldSchemaV3Path + $"?ids={id}";

            fields = await Get<List<LenderApiContractsV3.FieldSchemaContract>>(usePath);

            return new Tuple<List<LenderApiContractsV3.FieldSchemaContract>, LenderApiResponse>(fields, _response);
        }
        public async Task<Tuple<LenderApiContractsV1.FieldSchemaContract, LenderApiResponse>> GetV1FieldSchemaAsync(string id)
        {
            LenderApiContractsV1.FieldSchemaContract field = null;
            ClearResponse();

            var usePath = paths.FieldSchemaV1Path.AppendPathSegment($"{id}");

            field = await Get<LenderApiContractsV1.FieldSchemaContract>(usePath);

            return new Tuple<LenderApiContractsV1.FieldSchemaContract, LenderApiResponse>(field, _response);
        }
        public async Task<Tuple<LenderApiContractsV1.OrganizationContract, LenderApiResponse>> GetOrganizationAsync(string id)
        {
            LenderApiContractsV1.OrganizationContract org = null;
            ClearResponse();

            var usePath = paths.OrganizationPath(id);

            org = await Get<LenderApiContractsV1.OrganizationContract>(usePath);

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

            string result = await GetString(path);

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

            sets = await Get<List<LenderApiContractsV1.EntityRefContract>>(usePath);

            return new Tuple<List<LenderApiContractsV1.EntityRefContract>, LenderApiResponse>(sets, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV1.EntityRefContract>, LenderApiResponse>> GetLoanTemplatesAsyc(string param)
        {
            List<LenderApiContractsV1.EntityRefContract> sets = null;
            ClearResponse();

            var usePath = paths.EncompassPathFull + $"/settings/templates/items?path={param}";

            sets = await Get<List<LenderApiContractsV1.EntityRefContract>>(usePath);

            return new Tuple<List<LenderApiContractsV1.EntityRefContract>, LenderApiResponse>(sets, _response);
        }
        public async Task<Tuple<LoanTemplateSet, LenderApiResponse>> GetLoanProgramTemplatesAsyc(string param)
        {
            LoanTemplateSet sets = null;

            paths.SetV3();

            var usePath = TemplatePath("loanProgram", param);

            sets = await Get<LoanTemplateSet>(usePath);

            return new Tuple<LoanTemplateSet, LenderApiResponse>(sets, _response);
        }
        public async Task<Tuple<LoanTemplateSet, LenderApiResponse>> GetLoanClosingCostTemplatesAsyc(string param)
        {
            LoanTemplateSet sets = null;
            ClearResponse();

            paths.SetV3();
            var usePath = TemplatePath("closingCost", param);

            sets = await Get<LoanTemplateSet>(usePath);

            return new Tuple<LoanTemplateSet, LenderApiResponse>(sets, _response);
        }
        public async Task<Tuple<LoanTemplateSet, LenderApiResponse>> GetLoanSSPTemplatesAsyc(string param)
        {
            LoanTemplateSet sets = null;
            ClearResponse();

            paths.SetV3();
            var usePath = TemplatePath("settlementServiceProvider", param);

            sets = await Get<LoanTemplateSet>(usePath);

            return new Tuple<LoanTemplateSet, LenderApiResponse>(sets, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.RecipientContract>, LenderApiResponse>> GetLoanRecipients(string guid)
        {
            List<LenderApiContractsV3.RecipientContract> recips = null;

            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/loans/{guid}/recipients";

            recips = await Get<List<LenderApiContractsV3.RecipientContract>>(usePath);

            return new Tuple<List<LenderApiContractsV3.RecipientContract>, LenderApiResponse>(recips, _response);
        }
        public async Task<Tuple<List<LenderApiContractsV3.RegistrationLogContract>, LenderApiResponse>> GetRegistrationLogs(string guid)
        {
            List<LenderApiContractsV3.RegistrationLogContract> logs = null;

            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/loans/{guid}/registrationLogs";

            logs = await Get<List<LenderApiContractsV3.RegistrationLogContract>>(usePath);

            return new Tuple<List<LenderApiContractsV3.RegistrationLogContract>, LenderApiResponse>(logs, _response);
        }
        public async Task<Tuple<LenderApiContractsV3.RegistrationLogContract, LenderApiResponse>> GetRegistrationLog(string guid, string logId)
        {
            LenderApiContractsV3.RegistrationLogContract log = null;

            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/loans/{guid}/registrationLogs/{logId}";

            log = await Get<LenderApiContractsV3.RegistrationLogContract>(usePath);

            return new Tuple<LenderApiContractsV3.RegistrationLogContract, LenderApiResponse>(log, _response);
        }

        // Create Reg Log
        // Update Reg Log
    }
}
