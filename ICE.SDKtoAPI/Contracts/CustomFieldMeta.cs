using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class CustomFieldMeta
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public int MaxLength { get; set; }
        public string ModelPath { get; set; }
        public bool IsCalcualted { get; set; }
    }
}
