﻿using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV3;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class FolderProviderService : BaseProviderService
    {
        public FolderProviderService(AccessToken token) : base(token) { paths.SetV3(); }

        public async Task<LenderApiResponse> MoveToFolderAsync(string guid, string newName)
        {
            paths.SetV1();

            LenderApiResponse apiResponse;

            var usePath = paths.MoveFolderPath(newName);

            try
            {
                var url = Authenticate(usePath);   // $"https://api.elliemae.com/encompass/v1/loanfolders/{newName}/loans?action=add";

                var response = await url.PatchJsonAsync(new { loanGuid = guid });

                apiResponse = OkResponse(response.Headers, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath);
            }

            paths.SetV3();

            return apiResponse;
        }
        public async Task<Tuple<List<LoanFolderContract>, LenderApiResponse>> GetLoanFoldersAsync()
        {
            List<LoanFolderContract> folders = null;

            var usePath = paths.FolderPathFull;

            try
            {
                folders = await Get<List<LoanFolderContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LoanFolderContract>, LenderApiResponse>(folders, _response);
        }
        public async Task<Tuple<LoanFolderContract, LenderApiResponse>> GetLoanFolderAsync(string name)
        {
            LoanFolderContract folder = null;

            var usePath = paths.FolderPathFull + "/" + name;

            try
            {
                folder = await Get<LoanFolderContract>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<LoanFolderContract, LenderApiResponse>(folder, _response);
        }

    }
}
