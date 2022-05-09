using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    public class AttachmentUploadContract
    {
        public AttachmentUploadFileContract File { get; set; }
        public string Title { get; set; }

    }
    public class AttachmentUploadFileContract
    {
        public string ContentType { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
    }
}
