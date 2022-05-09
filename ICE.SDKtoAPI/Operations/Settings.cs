using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Providers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial class LenderAPI
    {
        public async Task<List<LenderApiContractsV1.OrganizationContract>> GetOrganizationsAsync()
        {
            SetResponse();
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetOrganizationsAsync();
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<List<LenderApiContractsV1.OrganizationHierarchyContract>> GetOrganizationsHierarchyAsync()
        {
            SetResponse();
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetOrganizationsHierarchyAsync();
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<LenderApiContractsV1.OrganizationContract> GetOrganizationAsync(string id)
        {
            SetResponse();
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetOrganizationAsync(id);
            _lastResponse = result.Item2;
            return result.Item1;
        }

        // Policies
        // External Orgs
        // External Users
        // Disclosure Tracking
        // Secondary

        #region Loan Templates
        public async Task<List<LenderApiContractsV1.EntityRefContract>> GetLoanTemplateFoldersAsync(string path = null)
        {
            SetResponse();
            path = string.IsNullOrEmpty(path) ? "public" : path;
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetLoanTemplateFoldersAsyc(path);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<List<LenderApiContractsV1.EntityRefContract>> GetLoanTemplatesAsync(string path = null)
        {
            SetResponse();
            path = string.IsNullOrEmpty(path) ? "public%5cCompanywide" : path;
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetLoanTemplatesAsyc(path);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<LoanTemplateSet> GetLoanProgramTemplatesAsync(string path = null)
        {
            SetResponse();
            path = string.IsNullOrEmpty(path) ? "Public:\\Companywide" : path;
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetLoanProgramTemplatesAsyc(path);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<LoanTemplateSet> GetLoanClosingCostTemplatesAsync(string path = null)
        {
            SetResponse();
            path = string.IsNullOrEmpty(path) ? "Public:\\Companywide" : path;
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetLoanClosingCostTemplatesAsyc(path);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<LoanTemplateSet> GetLoanSSPTemplatesAsync(string path = null)
        {
            SetResponse();
            path = string.IsNullOrEmpty(path) ? "Public:\\Companywide" : path;
            var provider = new BaseProviderService(_accessToken);
            var result = await provider.GetLoanSSPTemplatesAsyc(path);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        #endregion



    }
}
