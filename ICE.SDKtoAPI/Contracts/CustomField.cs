using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class CustomField
    {
        public string Id { get; set; }
        public string FieldName { get; set; }
        public float? NumericValue { get; set; }
        public string StringValue { get; set; }
    }
}
