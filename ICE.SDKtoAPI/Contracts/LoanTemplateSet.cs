using System.Collections.Generic;

namespace ICE.SDKtoAPI.Contracts
{
    public class LoanTemplateSet
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public TemplateEntityRef Parent { get; set;}
        public List<TemplateEntityRef> Contents { get; set; }
    }
}
