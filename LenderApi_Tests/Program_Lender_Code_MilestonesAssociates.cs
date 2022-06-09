using ICE.SDKtoAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void MilestonesAssociates()
        {
            Console.Clear();

            _api.GetLoanGuidAsync(UseThisLoan).Wait();

            if (_api.HasLoanGuid)
            {
                Console.WriteLine("---------- Milestones ------------");
                var ms = _api.GetMilestonesAsync(_api.LoanGuid).Result;
                if (ms != null)
                {
                    if (ms.Count == 0)
                        Console.WriteLine("No Milestones");
                    else
                    {
                        foreach (var i in ms)
                            Console.WriteLine($"{i.MilestoneName} - {i.StartDate} - {i.LoanAssociate.Id}");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("---------- Milestone By Name------------");
                var msQ = _api.GetMilestoneByNameAsync("Escrow").Result;
                if (msQ != null && _api.LastResponse.IsSuccess)
                    Console.WriteLine($"Detail: {msQ.MilestoneName} - {msQ.StartDate} - {msQ.LoanAssociate.Name}");
                else
                    if (!_api.LastResponse.IsSuccess)
                    Console.WriteLine($"Error: {_api.LastResponse.Message}");
                else
                    Console.WriteLine("No milestone found");

                Console.WriteLine();
                Console.WriteLine("---------- Last Completed Milestone ------------");
                var last = _api.LastCompletedMilestoneAsync().Result;
                if (last != null && _api.IsOkStatus)
                    Console.WriteLine(last.MilestoneName);
                else
                    Console.WriteLine($"Error: {_api.LastMessage}");


                Console.WriteLine();
                Console.WriteLine("---------- Next Milestone ------------");
                var next = _api.NextMilestoneAsync().Result;
                if (next != null && _api.IsOkStatus)
                    Console.WriteLine(next.MilestoneName);
                else
                    Console.WriteLine($"Error: {_api.LastMessage}");

                Console.WriteLine();
                Console.WriteLine("---------- Milestone Free Roles --------------");
                var freeRoles = _api.GetMilestoneFreeRolesAsync().Result;
                if (freeRoles == null)
                    Console.WriteLine("No Free Roles Found");
                else
                    foreach (var role in freeRoles)
                        Console.WriteLine($"{role.Id} - {role.LoanAssociate.Name}");


                Console.WriteLine();
                Console.WriteLine("------------------ Associates --------------");
                var assoc = _api.GetLoanAssociatesAsync(_api.LoanGuid).Result;
                if (assoc != null && _api.IsOkStatus)
                {
                    if (assoc.Count == 0)
                        Console.WriteLine("No Associates");
                    else
                    {
                        foreach (var i in assoc)
                            Console.WriteLine($"{i.Id} - {i.RoleName} = {i.Name}");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("------- Associate By Role name --------");
                var assocs = _api.GetLoanAssociatesByRoleNameAsync("Loan Processor").Result;
                foreach (var a in assocs)
                    Console.WriteLine($"{a.LoanAssociateType} - {a.Name} - {a.RoleName}");

                Console.WriteLine();
                Console.WriteLine("------- Associate By Role Enumeration --------");
                assocs = _api.GetLoanAssociatesAsync(FixedRole.LoanProcessor).Result;
                foreach (var a in assocs)
                    Console.WriteLine($"{a.LoanAssociateType} - {a.Name} - {a.RoleName}");


            }
            else
                Console.WriteLine($"Unable to get guid for loan {UseThisLoan} on instance {_instanceId}");

        }
    }
}
