using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class APISchema
    {
        public string Key { get; set; } = string.Empty;  // 0
        public string Meta { get; set; } = string.Empty; // 1
        public bool ReadOnly { get; set; } = false; // 2
        public string Type { get; set; } = string.Empty; // 3
        public bool Nullable { get; set; } = false;// 4
        public string Description { get; set; } = string.Empty; // 5
        public bool LockedField { get; set; } = false; // 6
        public string ENum { get; set; } = string.Empty; // 7
        public string Format { get; set; } = string.Empty; // 8
    }
}
