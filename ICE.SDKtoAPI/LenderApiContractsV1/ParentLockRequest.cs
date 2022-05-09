using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    public class ParentLockRequest
    {
        public string RequestType { get; set; }
        public string LockStatus { get; set; }
        public string EntityId { get; set; }
        public string EntityType { get; set; }
        public string EntityName { get; set; }
        public string EntityUri { get; set; }
    }
}
