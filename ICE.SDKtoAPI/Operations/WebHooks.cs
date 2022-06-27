using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV1;
using ICE.SDKtoAPI.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<WebHookResource>> GetWebHookResourcesAsync();
        Task<List<WebHookResourceEvent>> GetWebHookResourceEventsAsync();
        Task<List<WebHookSubscription>> GetWebHookSubscriptionsAsync();
        Task<WebHookSubscription> GetWebHookSubscriptionAsync(string id);
        Task<WebHookSubscription> CreateWebHookSubscriptionAsync(WebHookSubscription data);
        Task<List<WebHookEvent>> GetWebHookEventsAsync(WebHookEventParameters parms = null);
        Task<List<WebHookEvent>> GetWebHookEventsAsync(int numberToGet, WebHookEventParameters parms);
        Task<List<WebHookEvent>> GetWebHookEventsAsync(DateTime date);
        Task<List<WebHookEvent>> GetWebHookEventsAsync(WebHookEventParameters parms, DateTime date);
    }
    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<WebHookResource>> GetWebHookResourcesAsync()
        {
            SetResponse();
            var provider = new WebHookProviderService(_accessToken);
            var results = await provider.GetResourcesAsync();
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<WebHookResourceEvent>> GetWebHookResourceEventsAsync()
        {
            SetResponse();
            var provider = new WebHookProviderService(_accessToken);
            var results = await provider.GetResourceEventsAsync();
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<WebHookSubscription>> GetWebHookSubscriptionsAsync()
        {
            SetResponse();
            var provider = new WebHookProviderService(_accessToken);
            var results = await provider.GetSubscriptionsAsync();
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<WebHookSubscription> GetWebHookSubscriptionAsync(string id)
        {
            SetResponse();
            var provider = new WebHookProviderService(_accessToken);
            var results = await provider.GetSubscriptionAsync(id);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<WebHookSubscription> CreateWebHookSubscriptionAsync(WebHookSubscription data)
        {
            SetResponse();
            var provider = new WebHookProviderService(_accessToken);
            var results = await provider.CreateSubscriptionAsync(data);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<WebHookEvent>> GetWebHookEventsAsync(WebHookEventParameters parms = null)
        {
            if (parms == null)
                parms = new WebHookEventParameters();

            return await GetWebHookEventsAsync(parms.Limit, parms);
        }
        public async Task<List<WebHookEvent>> GetWebHookEventsAsync(int numberToGet, WebHookEventParameters parms)
        {
            var items = new List<WebHookEvent>();

            if (parms.StartTime != null && parms.EndTime != null)
            {
                if (Convert.ToDateTime(parms.StartTime) > Convert.ToDateTime(parms.EndTime))
                {
                    _lastResponse = new LenderApiResponse();
                    _lastResponse.StatusCode = System.Net.HttpStatusCode.NotAcceptable;
                    _lastResponse.Message = "Starting Date/Time GREATER than Ending Date/Time";
                    return null;
                }
                else
                    parms.EndTime = Convert.ToDateTime(parms.EndTime).AddSeconds(59);  // Ensuring end of minute 
            }
            SetResponse();
            var provider = new WebHookProviderService(_accessToken);
            var results = await provider.GetEventsAsync(parms);   // make initial call
            _lastResponse = results.Item2;

            var events = results.Item1;

            if (LastResponse.IsSuccess)
            {
                while (events != null && LastResponse.IsSuccess)
                {
                    if (events.Count == 0)
                    {
                        break;
                    }

                    foreach (var e in events)
                    {
                        if (!items.Any(x => x.Id == e.Id))
                        {
                            if (string.IsNullOrEmpty(parms.FilterText))  // no filter
                                items.Add(e);
                            else
                            {
                                if (e.Event.ClientId.Contains(parms.FilterText) ||
                                    e.Event.EventType.Contains(parms.FilterText) ||
                                    e.Event.ResourceType.Contains(parms.FilterText) ||
                                    e.Event.StatusDetails.Contains(parms.FilterText) ||
                                    e.Event.Status.Contains(parms.FilterText)
                                    )
                                    items.Add(e);
                            }
                        }
                    }

                    parms.Start += parms.Limit;

                    if (items.Count >= numberToGet)
                        break;

                    results = await provider.GetEventsAsync(parms);
                    _lastResponse = results.Item2;
                    events = results.Item1;

                    if (!LastResponse.IsSuccess)  // Return what we have
                        break;
                }

                return items;
            }
            else
                return null;
        }
        public async Task<List<WebHookEvent>> GetWebHookEventsAsync(DateTime date) => await GetWebHookEventsAsync(new WebHookEventParameters(), date);
        public async Task<List<WebHookEvent>> GetWebHookEventsAsync(WebHookEventParameters parms, DateTime date)
        {
            var startDate = new DateTime(date.Year, date.Month, date.Day) + TimeSpan.Parse("00:00:00");
            var endDate = new DateTime(date.Year, date.Month, date.Day) + TimeSpan.Parse("00:14:59");

            var items = new List<WebHookEvent>();

            parms.StartTime = startDate;
            parms.EndTime = endDate;

            while (startDate.Day == date.Day)
            {
                var events = await GetWebHookEventsAsync(parms);

                if (LastResponse.IsSuccess)
                {
                    foreach (var e in events)
                    {
                        if (!items.Any(x => x.Id == e.Id))
                            items.Add(e);
                    }

                    startDate = startDate.AddMinutes(15);
                    endDate = endDate.AddMinutes(15);

                    parms.StartTime = startDate;
                    parms.EndTime = endDate;
                }
            }

            return items;
        }
    }
}
