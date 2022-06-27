using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Providers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV1.OrganizationContract>> GetOrganizationsAsync();
        Task<List<LenderApiContractsV1.OrganizationHierarchyContract>> GetOrganizationsHierarchyAsync();
        Task<LenderApiContractsV1.OrganizationContract> GetOrganizationAsync(string id);
        Task<List<LenderApiContractsV1.EntityRefContract>> GetLoanTemplateFoldersAsync(string path = null);
        Task<List<LenderApiContractsV1.EntityRefContract>> GetLoanTemplatesAsync(string path = null);
        Task<LoanTemplateSet> GetLoanProgramTemplatesAsync(string path = null);
        Task<LoanTemplateSet> GetLoanClosingCostTemplatesAsync(string path = null);
        Task<LoanTemplateSet> GetLoanSSPTemplatesAsync(string path = null);
        Task<UrlaConfiguration> GetUralConfigurationAsync();
        Task<LenderApiContractsV3.DisclosureTrackingSettings> GetDisclosureTrackingSettingsAsync();
        Task<List<LenderApiContractsV3.FundingTemplateContract>> GetFundingTemplatesAsync();
        Task<List<LenderApiContractsV3.InvestorTemplateContract>> GetInvestorTemplatesAsync();
        Task<LenderApiContractsV3.InvestorTemplateContract> GetInvestorTemplateAsync(string guid);
    }
    public partial class LenderAPI : ILenderAPI
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
        public async Task<UrlaConfiguration> GetUralConfigurationAsync()
        {
            SetResponse();
            var provider = new SettingProviderService(_accessToken);
            var result = await provider.GetUrlaConfiguration();
            _lastResponse = result.Item2;
            return result.Item1;
        }

        public async Task<LenderApiContractsV3.DisclosureTrackingSettings> GetDisclosureTrackingSettingsAsync()
        {
            SetResponse();
            var provider = new SettingProviderService(_accessToken);
            var result = await provider.GetDisclosureTrackingSettingsAsync();
            _lastResponse = result.Item2;
            return result.Item1;
        }

        // Policies

        public async Task<List<LenderApiContractsV3.FundingTemplateContract>> GetFundingTemplatesAsync()
        {
            SetResponse();
            var provider = new SettingProviderService(_accessToken);
            var result = await provider.GetFundingTemplatesAsync();
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<List<LenderApiContractsV3.InvestorTemplateContract>> GetInvestorTemplatesAsync()
        {
            SetResponse();
            var provider = new SettingProviderService(_accessToken);
            var result = await provider.GetInvestorTemplatesAsync();
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<LenderApiContractsV3.InvestorTemplateContract> GetInvestorTemplateAsync(string guid)
        {
            SetResponse();
            var provider = new SettingProviderService(_accessToken);
            var result = await provider.GetInvestorTemplateAsync(guid);
            _lastResponse = result.Item2;
            return result.Item1;
        }

        public async Task<List<LenderApiContractsV3.ExternalOrganizationContract>> GetExternalOrganizationsAsync()
        {
            SetResponse();
            var provider = new SettingProviderService(_accessToken);
            var result = await provider.GetExternalOrganizationsAsync();
            _lastResponse = result.Item2;
            return result.Item1;
        }

        public async Task<LenderApiContractsV3.ExternalOrganizationContract> GetExternalOrganizationAsync(string guid)
        {
            SetResponse();
            var provider = new SettingProviderService(_accessToken);
            var result = await provider.GetExternalOrganizationAsync(guid);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<List<LenderApiContractsV3.ExternalUserContract>> GetExternalUsersAsync()
        {
            SetResponse();
            var provider = new SettingProviderService(_accessToken);
            var result = await provider.GetExternalUsersAsync();
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<LenderApiContractsV3.ExternalUserContract> GetExternalUserAsync(string guid)
        {
            SetResponse();
            var provider = new SettingProviderService(_accessToken);
            var result = await provider.GetExternalUserAsync(guid);
            _lastResponse = result.Item2;
            return result.Item1;
        }


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
