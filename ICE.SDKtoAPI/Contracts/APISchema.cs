using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class APISchema
    {
        public string Key { get; set; } // 0
        public string Meta { get; set; } // 1
        public bool ReadOnly { get; set; } // 2
        public string Type { get; set; } // 3
        public bool Nullable { get; set; } // 4
        public string Description { get; set; } // 5
        public bool LockedField { get; set; } // 6
        public string ENum { get; set; } // 7
        public string Format { get; set; } = string.Empty; // 8
    }
}
