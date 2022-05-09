using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void UsersAndRoles()
        {
            Console.Clear();
            #region Users
            Console.WriteLine("---------- All Users (10000 users specified) ------------");
            var users = _api.GetUsersAsync(10000).Result;
            if (users != null)
            {
                if (users.Count == 0)
                    Console.WriteLine("No Users");
                else
                {
                    foreach (var i in users)
                        Console.WriteLine($"{i.FullName} - {i.Title} - {i.Id}");
                }

                Console.WriteLine();
                Console.WriteLine("---- Find A Specific User by email and list User Groups ----");
                var userEmail = "Michael.Dowell@mrcooper.com";
                var foundUser = users.FirstOrDefault(user => user?.Email?.Equals(userEmail, StringComparison.InvariantCultureIgnoreCase) ?? false);

                var userGroups = _api.GetUserGroupsAsync(foundUser.Id).Result;
                Console.WriteLine(userEmail);
                foreach (var g in userGroups)
                    Console.WriteLine(g.EntityName);
            }

            if (users != null)
            {
                // now get the first users
                var user = users[0];
                var md = "0md1";

                #region User Personas
                Console.WriteLine();
                Console.WriteLine($"-------- User's Personas 0md1 - Michael Dowell --------");
                ICE.SDKtoAPI.LenderApiContractsV1.UserProfileContract profile = _api.GetUserProfileAsync(md).Result;
                if (profile != null && _api.IsOkStatus)
                {
                    foreach (var i in profile.Personas)
                        Console.WriteLine($"Persona: {i.EntityName}");
                }
                #endregion

                #region User Groups
                Console.WriteLine();
                Console.WriteLine($"-------- User's Groups {user.Id} --------");
                var groups = _api.GetUserGroupsAsync(user.Id).Result;
                if (groups != null)
                {
                    foreach (var i in groups)
                        Console.WriteLine($"{i.EntityId} - {i.EntityName} - {i.EntityType}");
                }
                #endregion

                #region User compensation plans
                Console.WriteLine();
                Console.WriteLine($"-------- User's Compensation Plans {user.Id} --------");
                var plans = _api.GetUserCompensationPlansAsync(user.Id).Result;
                if (plans != null && _api.LastResponse.IsSuccess)
                {
                    foreach (var i in plans)
                        Console.WriteLine($"{i.UserParentInformation}");
                }
                #endregion

                #region User licenses
                Console.WriteLine();
                Console.WriteLine($"-------- User's Licenses {user.Id} --------");
                var licenses = _api.GetUserLicensesAsync(user.Id).Result;
                if (licenses != null && _api.LastResponse.IsSuccess)
                {
                    foreach (var i in licenses)
                        Console.WriteLine($"{i.State} - {i.License}");
                }
                #endregion

                /// TODO
                /// List All Persons
                /// List Person Categories for a specific Persona

            }
            #endregion

            ///TODO... get user needs changed
            Console.WriteLine();
            Console.WriteLine("---- Assign User to Role ----");
            var tenth = _api.GetUserAsync("9zz8").Result;
            _api.SendToProcessingAsync(tenth).Wait();


            #region Personas
            Console.WriteLine();
            Console.WriteLine("---------- All Personas ------------");
            var p = _api.GetPersonasAsync().Result;
            if (p != null)
            {
                if (p.Count == 0)
                    Console.WriteLine("No Personas");
                else
                {
                    foreach (var i in p)
                        Console.WriteLine($"{i.Name} - {i.Id}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("---------- Persona by name (UnderWriter) ------------");
            var pp = _api.GetPersonaByNameAsync("Underwriter").Result;
            if (pp != null)
                Console.WriteLine(pp.Id);
            else
                Console.WriteLine("No Found Persona");

            Console.WriteLine();
            Console.WriteLine("---------- Users in Persona ------------");
            var up = _api.GetUsersWithPersonaAsync(pp).Result;
            foreach (ICE.SDKtoAPI.LenderApiContractsV1.UserContract uc in up)
                Console.WriteLine($"{uc.FullName} - {uc.Title} - {uc.Id}");

            #endregion

            #region All Roles
            Console.WriteLine();
            Console.WriteLine("---------- All Role Names (Conventional Roles only) ------------");
            var rn = _api.GetRolesAsync().Result;
            if (rn != null)
            {
                if (rn.Count == 0)
                    Console.WriteLine("No Roles");
                else
                {
                    foreach (var i in rn)
                        Console.WriteLine(i.RoleName);
                }
            }
            #endregion

        }
    }
}
