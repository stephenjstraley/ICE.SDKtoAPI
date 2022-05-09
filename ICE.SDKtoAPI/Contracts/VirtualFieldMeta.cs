using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class VirtualFieldMeta
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public bool MultiInstance { get; set; }
        public string InstanceSpecifierType { get; set; }
        public bool ReadOnly { get; set; }
    }
}
