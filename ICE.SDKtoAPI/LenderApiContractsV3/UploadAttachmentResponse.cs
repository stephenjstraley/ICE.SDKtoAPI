using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    public class UploadAttachmentResponse
    {
        public string AttachmentId { get; set; }
        public string AuthorizationHeader { get; set; }
        public bool MultiChunkRequired { get; set; }
        public string UploadUrl { get; set; }
        public string ExpiresAt { get; set; }
        public bool V1Loan => string.IsNullOrEmpty(AuthorizationHeader);
        public UploadAttachmentChunkList MultiChunk { get; set; }
    }
    public class UploadAttachmentChunkList
    {
        public List<UploadAttachmentChunk> ChunkList { get; set; }
        public string CommitUrl { get; set; }
    }
    public class UploadAttachmentChunk
    {
        public string UploadUrl { get; set; }
        public long Size { get; set; }
    }
}
