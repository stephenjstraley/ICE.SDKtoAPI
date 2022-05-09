using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class GiftGrantContractFull : GiftGrantContract
    {
        [DataMember(Name = "altId")]
        public string AltId { get; set; }
    }
}
