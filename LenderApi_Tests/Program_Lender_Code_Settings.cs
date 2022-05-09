using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void Settings()
        {
            Console.Clear();
            _api.GetLoanGuidAsync(UseThisLoan).Wait();
            if (_api.HasLoanGuid)
            {
                Console.WriteLine("---- Get Organizations ----");
                var items = _api.GetOrganizationsAsync().Result;
                foreach (var item in items)
                    Console.WriteLine(item.Name);

                Console.WriteLine();
                Console.WriteLine("---- Field Schema ----");
                foreach (var item in _api.FieldSchema)
                    Console.WriteLine(item.Key + " - " + item.Meta + " - " + item.Description);

                Console.WriteLine();
                Console.WriteLine("---- Dynamic Field Schema ---- ");
                foreach (var item in _api.DynamicSchema)
                    Console.WriteLine(item.Key + " - " + item.Meta + " - " + item.Description);

                Console.WriteLine();
                Console.WriteLine("---- Conversation Logs ----");
                var convos = _api.GetConversationLogsAsync().Result;
                Console.Write(_api.LastStatus);
                foreach (var item in convos)
                    Console.WriteLine(item.Id + " - " + item.DateUtc.ToString() + " - " + item.Comments);
            }
            else
                Console.WriteLine($"Unable to get guid for loan {UseThisLoan} on instance {_instanceId}");

        }

    }
}
