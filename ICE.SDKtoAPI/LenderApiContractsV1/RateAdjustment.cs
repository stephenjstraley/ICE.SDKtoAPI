using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    public class RateAdjustment
    {
        public string AdjustmentType { get; set; }
        public string Description { get; set; }
        public string PriceAdjustmentType { get; set; }
        public double? Adjustment { get; set; }
    }
}
