using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Providers;
using System.Collections.Generic;
using System.Threading.Tasks;
using static ICE.SDKtoAPI.Helpers.PipelineHelper;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<PipelineCanonicalFieldList> GetPipelineCanonicalNamesAsync();
        Task<List<GuidCursor>> PipelineRequestAsync(PipelineQueryWithFields contract);
        Task<List<GuidCursor>> PipelineRequestAsync(PipelineQueryWithFields contract, int limit);

    }
    public partial class LenderAPI : ILenderAPI
    {        
        public async Task<PipelineCanonicalFieldList> GetPipelineCanonicalNamesAsync()
        {
            SetResponse();
            var provider = new PipelineProviderService(_accessToken);
            var result = await provider.GetPipelineCanoicalNamesAsync();
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<List<GuidCursor>> PipelineRequestAsync(PipelineQueryWithFields contract)
        {
            SetResponse();
            var provider = new PipelineProviderService(_accessToken);
            var result = await provider.PipelineRequestAsync(contract);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<List<GuidCursor>> PipelineRequestAsync(PipelineQueryWithFields contract, int limit)
        {
            SetResponse();
            var provider = new PipelineProviderService(_accessToken);
            var result = await provider.PipelineRequestAsync(contract, limit);
            _lastResponse = result.Item2;
            return result.Item1;
        }
    }
}
