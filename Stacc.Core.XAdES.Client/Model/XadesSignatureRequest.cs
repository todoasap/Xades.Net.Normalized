using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stacc.Core.DigitalSignature.Client.Model
{
    public class XadesSignatureRequest
    {
        public Stream FileContentStream { get; set; }
        public String FileContentType { get; set; } // In v1 only application/xml is allowed
    }
}
