using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    public class AttachmentUrlDownloadContract
    {
        public List<DownloadUrlContract> Attachments { get; set; }
    }

    public class DownloadUrlContract
    {
        public string Id { get; set; }
        public string Url { get; set; }
    }
}
