using System;
using System.Collections.Generic;
using System.Text;

namespace Stacc.Core.DigitalSignature.Client
{
    public class DigitalSignatureClient : IDisposable
    {
        private string _signingCertThumbprint;

        public DigitalSignatureClient(
            string signingCertThumbprint
        )
        {
            _signingCertThumbprint = signingCertThumbprint;
        }

        public void Dispose()
        {
            // TODO: Dispose
        }
    }
}
