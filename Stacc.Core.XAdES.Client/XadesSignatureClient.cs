using System;
using System.Collections.Generic;
using System.Text;

namespace Stacc.Core.XAdES.Client
{
    public class XadesSignatureClient : IDisposable
    {
        private string _signingCertThumbprint;

        public XadesSignatureClient(string signingCertThumbprint)
        {
            _signingCertThumbprint = signingCertThumbprint;
        }

        public void Dispose()
        {
            // TODO: Dispose
        }
    }
}
