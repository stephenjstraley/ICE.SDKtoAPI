using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public partial class LoanFolderContract
    {
        [DataMember(Name = "folderName")]
        public string FolderName { get; set; }
        [DataMember(Name = "folderType")]
        public string FolderType { get; set; }

        [DataMember(Name = "actionsAllowed")]
        public List<string> ActionsAllowed { get; set; }

        [DataMember(Name = "isArchiveFolder")]
        public bool IsArchiveFolder { get; set; }

        [DataMember(Name = "includeDuplicateLoanCheck")]
        public bool IncludeDuplicateLoanCheck { get; set; }
        public bool CanLoansBeDuplicatedFrom => ActionsAllowed.Contains("DuplicateFrom");
        public bool CanLoansBeDumplicatedFrom => ActionsAllowed.Contains("DuplicateTo");
        public bool CanLoansBeImportedInto => ActionsAllowed.Contains("Import");
        public bool CanLoansByOriginatedInto => ActionsAllowed.Contains("Originate");
    }
}
