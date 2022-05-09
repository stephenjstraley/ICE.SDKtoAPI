using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void EnhancedConditions()
        {
            Console.Clear();

            if (!string.IsNullOrEmpty(_loanGuid))
            {
                var types = _api.GetEnhancedConditionTypesAsync().Result;
                Console.WriteLine(" ----- Conditions Types ------ ");
                foreach (var t in types)
                    Console.WriteLine(t.Title);

                Console.WriteLine(" ----- Conditions Templates ------ ");
                var temps = _api.GetEnhancedConditionTemplatesAsync().Result;
                foreach (var t in temps)
                    Console.WriteLine(t.Title);

                var sets = _api.GetEnhancedConditionSetsAsync().Result;
                Console.WriteLine(" ----- Conditions Sets ------ ");
                foreach (var t in sets)
                    Console.WriteLine(t.Name);


                var conds = _api.GetEnhancedConditionsAsync(_loanGuid).Result;

                Console.WriteLine(" ----- Conditions ------ ");
                foreach (var c in conds)
                {
                    Console.WriteLine($"{c.Title} - {c.Category}");

                    var tracking = _api.GetEnhancedConditionTrackingAsync(_loanGuid, c.Id).Result;

                    if (tracking != null && tracking.Count > 0)
                    {
                        Console.WriteLine("     -- Status Tracking --");
                        foreach (var t in tracking)
                            Console.WriteLine($"     Tracking: {t.Status} - BY [{t.User.EntityName}]");
                    }

                    var comments = _api.GetEnhancedConditionCommentsAsync(_loanGuid, c.Id).Result;
                    if (comments != null && comments.Count > 0)
                    {
                        Console.WriteLine("     -- Comments --");
                        foreach (var com in comments)
                            Console.WriteLine($"     {com.Comments}");
                    }

                    var docs = _api.GetEnhancedConditionDocumentsAsync(_loanGuid, c.Id).Result;
                    if (docs != null && docs.Count > 0)
                    {
                        Console.WriteLine("     -- Documents --");
                        foreach (var d in docs)
                            Console.WriteLine($"     {d.EntityName}");
                    }
                }

                // now condition and header information
                if (conds != null && conds.Count > 0)
                {
                    var condId = conds[0].Id;
                    var cond = _api.GetEnhancedConditionAsync(_loanGuid, condId).Result;
                    if (_api.LastResponse.IsSuccess)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" ----- Condition Headers ------ ");
                        var permit = _api.LastResponse.GetHeaderValue("X-Elli-Permissions");
                        Console.WriteLine(permit);

                    }
                }

            }
        }

    }
}
