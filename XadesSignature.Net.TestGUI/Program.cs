using Microsoft.Xades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography; // MAREK TEST
using System.Windows.Forms;

namespace XadesSignatureNetTestGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // MAREK TEST CODE:
            CryptoConfig.AddAlgorithm(typeof(RSAPKCS1SHA256SignatureDescription), "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256");
            SignatureDescription description = CryptoConfig.CreateFromName("http://www.w3.org/2001/04/xmldsig-more#rsa-sha256") as SignatureDescription;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}
