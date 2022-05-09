using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class FieldsFromEncompass
    {
        List<EncompassField> fields { get; set; }
    }
    public class EncompassField
    {
        public string id { get; set; }
        public string value { get; set; }
    }
}
