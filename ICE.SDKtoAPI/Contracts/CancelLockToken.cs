using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class CancelLockToken
    {
        public DateTime? CancellationDate { get; set; }
        public string Comments { get; set; }
    }
}
