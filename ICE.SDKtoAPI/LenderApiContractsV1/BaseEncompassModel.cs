using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    public class BaseEncompassModel : IValidatableObject
    {
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContract) => null;
        public string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
