using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Extensions;
using ICE.SDKtoAPI.LenderApiContractsV1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static ICE.SDKtoAPI.Helpers.PipelineHelper;

namespace ICE.SDKtoAPI.Providers
{
    public class PipelineProviderService : BaseProviderService
    {
        
        public PipelineProviderService(AccessToken token) : base(token)
        {
            paths.SetV1();
        }
        public async Task<Tuple<string, LenderApiResponse>> GetLoanGuidAsync(string loanNumber)
        {
            string guid = string.Empty;
            LenderApiResponse apiResponse;

            var request = new LoanPipelineViewContract
            {
                Filter = new LoanPipelineFilterContract
                {
                    Terms = new List<LoanPipelineFilterContractTerms>()
                    {
                        new LoanPipelineFilterContractTerms
                        {
                            CanonicalName = "Loan.LoanNumber",
                            Value = loanNumber,
                            MatchType = "exact",
                            Include = true
                        }
                        },
                    Operator = "and"
                },
                Fields = new List<string> { "Loan.GUID" }
            };

            var usePath = paths.LoanPipelinePathFull;

            try
            {
                var client = Authenticate(usePath);

                var resp = await client.PostJsonAsync(request);

                var cursor = resp.ReceiveJson<List<Contracts.Guid>>(); 

                if (cursor.Count > 0)
                    guid = cursor[0].LoanGuid;

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

            return new Tuple<string, LenderApiResponse>(guid, apiResponse);
        }
        public async Task<Tuple<PipelineCanonicalFieldList, LenderApiResponse>> GetPipelineCanoicalNamesAsync()
        {
            PipelineCanonicalFieldList list = null;
            LenderApiResponse apiResponse;

            var usePath = paths.PipelineFieldDefsFull;

            try
            {
                var client = Authenticate(usePath);

                var resp = await client.GetAsync();

                list = resp.ReceiveJson<PipelineCanonicalFieldList>();

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

            return new Tuple<PipelineCanonicalFieldList, LenderApiResponse>(list, apiResponse);
        }
        public async Task<Tuple<List<GuidCursor>, LenderApiResponse>> PipelineRequestAsync(PipelineQueryWithFields contract)
        {
            LenderApiResponse apiResponse;
            List<GuidCursor> cursors = null;

            var usePath = paths.LoanPipelinePathFull;

            try
            {
                var client = Authenticate(usePath);

                var resp = await client.PostJsonAsync(contract);

                cursors = resp.ReceiveJson<List<GuidCursor>>();

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

            return new Tuple<List<GuidCursor>, LenderApiResponse>(cursors, apiResponse);
        }

        public async Task<Tuple<List<GuidCursor>, LenderApiResponse>> PipelineRequestAsync(PipelineQueryWithFields contract, int limit)
        {
            LenderApiResponse apiResponse;
            List<GuidCursor> cursors = null;

            var usePath = paths.LoanPipelinePathFullWithLimit(limit.ToString());

            try
            {
                var client = Authenticate(usePath);

                var resp = await client.PostJsonAsync(contract);

                cursors = resp.ReceiveJson<List<GuidCursor>>();

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

            return new Tuple<List<GuidCursor>, LenderApiResponse>(cursors, apiResponse);
        }

        public static T PipelineField<T>(LoanPipelineItemContract data, string field)
        {
            if (data == null)
            {
                return default(T);
            }
            else
            {
                var things = JsonConvert.SerializeObject(data.Fields);
                var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(things);
                if (dictionary != null)
                {
                    if (dictionary.ContainsKey(field))
                    {
                        var value = dictionary[field];
                        try
                        {
                            return (T)Convert.ChangeType(value, typeof(T));
                        }
                        catch
                        {
                            try
                            {
                                return (T)Convert.ChangeType(value, Nullable.GetUnderlyingType(typeof(T)));
                            }
                            catch //(Exception ex)  // Probably the empty string is not of DateTime format
                            {
                                return default(T);
                            }
                        }
                    }
                    else
                        return default(T);
                }
                else
                    return default(T);
            }
        }
    }

}
