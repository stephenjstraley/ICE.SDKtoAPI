using ICE.SDKtoAPI.LenderApiContractsV1;
using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void WebHooks()
        {
            Console.Clear();

            Console.WriteLine(" ---- Resources ---- ");
            var resources = _api.GetWebHookResourcesAsync().Result;
            if (resources != null)
            {
                foreach (var r in resources)
                {
                    Console.WriteLine($"Resource Name: {r.Name}   [{r.Description}]");

                    foreach (var e in r.Events)
                    {
                        Console.WriteLine($"   {e.Name}");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(" ---- Subscriptions ---- ");
            var subs = _api.GetWebHookSubscriptionsAsync().Result;
            if (subs != null)
            {
                foreach (var s in subs)
                {
                    Console.WriteLine($"Endpoint: {s.Endpoint}");
                    Console.WriteLine($"     Instance ID: {s.InstanceId}");
                    Console.WriteLine($"     Client ID: {s.ClientId}");
                    Console.WriteLine($"     Resource: {s.Resource}");
                    Console.WriteLine("     -- Events -- ");
                    foreach (var e in s.Events)
                        Console.WriteLine($"         {e}");
                }
            }

            Console.WriteLine();
            Console.WriteLine(" ---- Resource Events ---- ");
            var res = _api.GetWebHookResourceEventsAsync().Result;
            if (res != null)
            {
                foreach (var r in res)
                {
                    Console.WriteLine($"{r.Name} => [{r.ExtraPayload}]");
                }
            }

            Console.WriteLine();
            Console.WriteLine(" ---- Events ---- ");
            var events = _api.GetWebHookEventsAsync().Result;
            if (events != null)
            {
                foreach (var e in events)
                {
                    Console.WriteLine($"{e.Event.ResourceType} - {e.Event.EventType} - {e.Event.Status} - {e.Time}");
                }
            }

            Console.WriteLine();
            Console.WriteLine(" ---- Parameter Events ---- ");
            var parms = new WebHookEventParameters();
            parms.ResourceType = "Loan";
            //parms.EventType = "update";
            parms.Status = StatusWebHook.Received;
            //parms.ResourceId = "5ca15fe5-9d2e-4e0f-8c94-ae92bb3707d0";
            //parms.SubscriptionId = "a0067cce-6d1d-42bd-9a8f-26e1e3edccda";
            //parms.StartTime = new DateTime(2022, 3, 1);
            //parms.EndTime = new DateTime(2022, 3, 3);
            //Loan # 0431604404
            //Subscription ID - a0067cce-6d1d-42bd-9a8f-26e1e3edccda
            //Loan Guid - 5ca15fe5-9d2e-4e0f-8c94-ae92bb3707d0
            //Status - EventReceived
            parms.StartTime = new DateTime(2022, 02, 28, 00, 00, 00);
            parms.EndTime = new DateTime(2022, 02, 28, 00, 15, 00);

            parms.FilterText = "ID: c";


            events = _api.GetWebHookEventsAsync(1000, parms).Result;

            Console.WriteLine(_api.LastResponse.Query);
            if (events != null)
            {
                foreach (var e in events)
                {
                    //                    if (!string.IsNullOrEmpty(e.Event.SubscriptionId))
                    //                    {
                    //                        var sub = _api.GetWebHookSubscriptionAsync(e.Event.SubscriptionId).Result;
                    //                        if (sub != null)
                    //                        {
                    Console.WriteLine($"{e.Time} - {e.Event.Status} - [{e.Event.EventType} - {e.Event.ResourceType} - {e.Event.ResourceId} - {e.Event.SubscriptionId} = {e.Event.StatusDetails}]");
                    //                            Console.WriteLine($"                       {e.Event.StatusDetails}");
                    //                        }
                    //                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(" ---- Days Events - LOAN / UPDATE ---- ");
            //var events = _api.GetWebHookEventsAsync(parms,  DateTime.Now.AddDays(-1)).Result;
            events = _api.GetWebHookEventsAsync(parms, new DateTime(2022, 3, 1)).Result;
            if (events != null)
            {
                foreach (var e in events)
                {
                    if (!string.IsNullOrEmpty(e.Event.SubscriptionId))
                    {
                        var sub = _api.GetWebHookSubscriptionAsync(e.Event.SubscriptionId).Result;
                        if (sub != null)
                        {
                            if (e.Event.ResourceId == "5ca15fe5-9d2e-4e0f-8c94-ae92bb3707d0")
                            {
                                Console.WriteLine($"Event ID: {e.Id}");
                                Console.WriteLine($"Resource ID (Loan Guid): {e.Event.ResourceId}");
                                Console.WriteLine($"{e.Time} - {e.Event.Status} - [{sub.Endpoint}]");
                                Console.WriteLine($"                       {e.Event.StatusDetails}");
                            }
                        }
                    }
                }
            }

        }

    }
}
