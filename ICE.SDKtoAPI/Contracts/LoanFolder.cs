using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class LoanFolder
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsArchive { get; set; }
        public bool IsTrash { get; set; }
        public int Size { get; set; }
    }
}
