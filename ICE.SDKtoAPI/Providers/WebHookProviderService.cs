using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Extensions;
using ICE.SDKtoAPI.LenderApiContractsV1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class WebHookProviderService : BaseProviderService
    {
        public WebHookProviderService(AccessToken token) : base(token) { paths.SetV1(); }

        public async Task<Tuple<List<WebHookResource>, LenderApiResponse>> GetResourcesAsync()
        {
            List<WebHookResource> res = null;

            var usePath = paths.WebHookFull + "/resources";

            res = await Get<List<WebHookResource>>(usePath);

            return new Tuple<List<WebHookResource>, LenderApiResponse>(res, _response);
        }
        public async Task<Tuple<List<WebHookResourceEvent>, LenderApiResponse>> GetResourceEventsAsync()
        {
            List<WebHookResourceEvent> res = null;

            var usePath = paths.WebHookFull + "/resources/Loan/Events";

            res = await Get<List<WebHookResourceEvent>>(usePath);

            return new Tuple<List<WebHookResourceEvent>, LenderApiResponse>(res, _response);
        }
        public async Task<Tuple<List<WebHookSubscription>, LenderApiResponse>> GetSubscriptsionsAsync()
        {
            List<WebHookSubscription> subs = null;

            var usePath = paths.WebHookFull + "/subscriptions";

            subs = await Get<List<WebHookSubscription>>(usePath);

            return new Tuple<List<WebHookSubscription>, LenderApiResponse>(subs, _response);
        }
        public async Task<Tuple<WebHookSubscription, LenderApiResponse>> GetSubscriptsionAsync(string id)
        {
            WebHookSubscription sub = null;

            var usePath = paths.WebHookFull + $"/subscriptions/{id}";

            sub = await Get<WebHookSubscription>(usePath);

            return new Tuple<WebHookSubscription, LenderApiResponse>(sub, _response);
        }
        public async Task<Tuple<List<WebHookEvent>, LenderApiResponse>> GetEventsAsync(WebHookEventParameters details = null)
        {
            LenderApiResponse apiResponse;
            List<WebHookEvent> events = new List<WebHookEvent>();

            var usePath = paths.WebHookFull + "/events";

            if (details == null)
            {
                usePath += "?limit=100&start=0";
            }
            else
            {
                usePath += "?";
                // Now go through each parameter
                if (!string.IsNullOrEmpty(details.ResourceType))
                {
                    usePath += $"&resourceType={details.ResourceType}";
                }
                if (!string.IsNullOrEmpty(details.Status))
                {
                    usePath += $"&status={details.Status}";
                }
                if (!string.IsNullOrEmpty(details.EventType))
                {
                    usePath += $"&eventType={details.EventType}";
                }
                if (!string.IsNullOrEmpty(details.ResourceId))
                {
                    usePath += $"&resourceId={details.ResourceId}";
                }
                if (!string.IsNullOrEmpty(details.SubscriptionId))
                {
                    usePath += $"&subscriptionId={details.SubscriptionId}";
                }
                if (details.StartTime != null && details.EndTime != null)
                {
                    usePath += $"&startTime={Convert.ToDateTime(details.StartTime).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")}";
                    usePath += $"&endTime={Convert.ToDateTime(details.EndTime).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")}";
                }
                if (details.Limit <= 100 && details.Start >= 0)
                {
                    usePath += $"&limit={details.Limit}&start={details.Start}";
                }

                // Now remove the bad concat
                usePath = usePath.Replace("?&", "?");
            }

            try
            {
                var url = Authenticate(usePath);

                var resp = await url.GetAsync();

                if (resp.StatusCode != System.Net.HttpStatusCode.NotFound) // no events found
                    events = resp.ReceiveJson<List<WebHookEvent>>();

                apiResponse = OkResponse(resp.Headers, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath, "");
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath, "");
            }

            apiResponse.Query = usePath;

            return new Tuple<List<WebHookEvent>, LenderApiResponse>(events, apiResponse);
        }
    }
}
