using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class TemplateEntityRef
    {
        public string EntityName { get; set; }
        public string EtntityType { get; set; }
        public string EntityPath { get; set; }
        public bool? HasSubFolders { get; set; }
        public string Description { get; set; }
    }
}
