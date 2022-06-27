using ICE.SDKtoAPI.LenderApiContractsV1;
using ICE.SDKtoAPI.Providers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<PersonaContract>> GetPersonasAsync();
        Task<PersonaContract> GetPersonaAsync(string id);
        Task<PersonaContract> GetPersonaGategoriesAsync(string id, string cats);
        Task<PersonaContract> GetPersonaByNameAsync(string name);
        Task<List<UserContract>> GetUsersWithPersonaAsync(PersonaContract persona);

    }
    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<PersonaContract>> GetPersonasAsync()
        {
            SetResponse();
            var service = new SettingProviderService(_accessToken);
            var values = await service.GetPersonasAsync();
            _lastResponse = values.Item2;
            _personas = values.Item1;
            return _personas;
        }
        public async Task<PersonaContract> GetPersonaAsync(string id)
        {
            SetResponse();
            var service = new SettingProviderService(_accessToken);
            var values = await service.GetPersonaAsync(id);
            _lastResponse = values.Item2;
            return values.Item1;
        }
        public async Task<PersonaContract> GetPersonaGategoriesAsync(string id, string cats)
        {
            SetResponse();
            var service = new SettingProviderService(_accessToken);
            var values = await service.GetPersonaCategoriesAsync(id, cats);
            _lastResponse = values.Item2;
            return values.Item1;
        }
        public async Task<PersonaContract> GetPersonaByNameAsync(string name)
        {
            PersonaContract persona = null;
            await GetPersonasAsync();
            List<PersonaContract> temp = _personas; // did this to get around intellesense error
            if (temp != null && temp.Count > 0)
                persona = temp.Where(t => t.Name.ToUpper() == name.ToUpper()).FirstOrDefault();

            return persona;
        }
        public async Task<List<UserContract>> GetUsersWithPersonaAsync(PersonaContract persona)
        {
            List<UserContract> users = new List<UserContract>();
            await GetUsersAsync();
            List<UserContract> temp = _users;
            foreach (UserContract user in temp)
            {
                if (user.Personas != null)
                {
                    foreach (var p in user.Personas)
                    {
                        if (p.EntityId == persona.Id)
                            users.Add(user);
                    }
                }
            }

            return users;
        }

    }
}
