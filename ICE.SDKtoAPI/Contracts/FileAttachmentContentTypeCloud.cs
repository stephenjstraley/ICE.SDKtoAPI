using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public static class FileAttachmentContentTypeCloud
    {
        public static readonly string ApplicationEmf = "application/emf";
        public static readonly string ApplicationMsword = "application/msword";
        public static readonly string ApplicationPdf = "application/pdf";
        public static readonly string ApplicationXposDocument = "application/vnd.ms-xpsdocument";
        public static readonly string ApplicationOpenXml = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
        public static readonly string ImageJpeg = "image/jpeg";
        public static readonly string ImagePng = "image/png";
        public static readonly string ImageTiff = "image/tiff";
        public static readonly string TextHtml = "text/html";
        public static readonly string TextPlain = "text/plain";
    }

    public static class FileAttachmentContentTypeMedia
    {
        public static readonly string ApplicationMsword = "application/msword";
        public static readonly string ApplicationPdf = "application/pdf";
        public static readonly string ApplicationOpenXml = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
        public static readonly string ImageJpeg = "image/jpeg";
        public static readonly string ImagePng = "image/png";
        public static readonly string ImageTiff = "image/tiff";
        public static readonly string TextHtml = "text/html";
        public static readonly string TextPlain = "text/plain";
    }

    public static class FileAttachmentDownloadType
    {
        public static readonly string Native = "Native";
        public static readonly string Image = "Image";
        public static readonly string Background = "Background";
        public static readonly string Cloud = "Cloud";
    }
}
