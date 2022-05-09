using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class AccessToken
    {
        public string Access_Token { get; set; }
        public string Token_Type { get; set; }
        public DateTime GeneratedAt { get; set; } = DateTime.Now;
        public DateTime LastUsage { get; set; } = DateTime.Now;
        public bool Success { get; set; } = true;
    }

    
}
