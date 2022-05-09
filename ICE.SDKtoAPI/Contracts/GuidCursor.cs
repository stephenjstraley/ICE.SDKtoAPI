using System.Collections.Generic;

namespace ICE.SDKtoAPI.Contracts
{
    public class GuidCursor
    {
        public string LoanGuid { get; set; }
        public Dictionary<string, string> Fields { get; set; }
    }
}
