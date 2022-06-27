using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stacc.Core.DigitalSignature.Client.Model
{
    public class XadesSignatureResponse
    {
        public bool Success { get; set; }
        public Stream SignedFileContentStream { get; set; }
        public String SignedFileContentType { get; set; } // always application/xml TODO: Remove?
        public string ErrorType { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string WarningMessage { get; set; }
    }
}
