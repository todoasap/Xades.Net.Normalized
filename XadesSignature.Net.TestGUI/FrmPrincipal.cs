﻿// --------------------------------------------------------------------------------------------------------------------
// FrmPrincipal.cs
//
// FirmaXadesNet - Librería la para generación de firmas XADES
// Copyright (C) 2016 Dpto. de Nuevas Tecnologías de la Dirección General de Urbanismo del Ayto. de Cartagena
//
// This program is free software: you can redistribute it and/or modify
// it under the +terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
//
// E-Mail: informatica@gemuc.es
// 
// --------------------------------------------------------------------------------------------------------------------

using XadesSignatureNet;
using XadesSignatureNet.Clients;
using XadesSignatureNet.Crypto;
using XadesSignatureNet.Signature;
using XadesSignatureNet.Signature.Parameters;
using XadesSignatureNet.Upgraders;
using XadesSignatureNet.Upgraders.Parameters;
using XadesSignatureNet.Utils;
using XadesSignatureNet.Validation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace XadesSignatureNetTestGUI
{
    public partial class FrmPrincipal : Form
    {
        SignatureDocument _signatureDocument;

        public FrmPrincipal()
        {
            // Core.MZ.20220613: Injecting function because .NET Core misses X509Certificate2UI and X509SelectionFlag
            CertUtil.FunctionToSelectCertFromCollection = (X509Certificate2Collection fcollection, string title, string message) => {
                
                return X509Certificate2UI.SelectFromCollection(fcollection, title, message, X509SelectionFlag.SingleSelection);

            }; 

            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cmbAlgoritmo.SelectedIndex = 0;
        }


        private void btnSeleccionarFichero_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFichero.Text = openFileDialog1.FileName;
            }
        }

        private SignaturePolicyInfo ObtenerPolitica()
        {
            SignaturePolicyInfo spi = new SignaturePolicyInfo();

            spi.PolicyIdentifier = txtIdentificadorPolitica.Text;
            spi.PolicyHash = txtHashPolitica.Text;
            spi.PolicyUri = txtURIPolitica.Text;

            return spi;
        }

        private SignatureMethod ObtenerAlgoritmo()
        {
            if (cmbAlgoritmo.SelectedIndex == 0)
            {
                return SignatureMethod.RSAwithSHA1;
            }
            else if (cmbAlgoritmo.SelectedIndex == 1)
            {
                return SignatureMethod.RSAwithSHA256;
            }
            else
            {
                return SignatureMethod.RSAwithSHA512;
            }

        }

        private SignatureParameters ObtenerParametrosFirma()
        {
            SignatureParameters parametros = new SignatureParameters();           
            parametros.SignatureMethod = ObtenerAlgoritmo();
            parametros.SigningDate = DateTime.Now;

            // Test SignatureCommitment
            var sc = new SignatureCommitment(SignatureCommitmentType.ProofOfOrigin);            
            parametros.SignatureCommitments.Add(sc);

            return parametros;
        }

        private void btnFirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFichero.Text))
            {
                MessageBox.Show("You must select a file to sign.");
                return;
            }

            XadesService xadesService = new XadesService();
            SignatureParameters parametros = ObtenerParametrosFirma();

            if (rbInternnallyDetached.Checked)
            {
                parametros.SignaturePolicyInfo = ObtenerPolitica();
                parametros.SignaturePackaging = SignaturePackaging.INTERNALLY_DETACHED;
                parametros.DataFormat = new DataFormat();
                parametros.DataFormat.MimeType = MimeTypeInfo.GetMimeType(txtFichero.Text);
            }
            else if (rbExternallyDetached.Checked)
            {
                parametros.SignaturePackaging = SignaturePackaging.EXTERNALLY_DETACHED;
                parametros.ExternalContentUri = txtFichero.Text;
            }
            else if (rbEnveloped.Checked)
            {
                parametros.SignaturePackaging = SignaturePackaging.ENVELOPED;
            }
            else if (rbEnveloping.Checked)
            {
                parametros.SignaturePackaging = SignaturePackaging.ENVELOPING;
            }

            using (parametros.Signer = new Signer(CertUtil.SelectCertificate()))
            {
                if (parametros.SignaturePackaging != SignaturePackaging.EXTERNALLY_DETACHED)
                {
                    using (FileStream fs = new FileStream(txtFichero.Text, FileMode.Open))
                    {
                        _signatureDocument = xadesService.Sign(fs, parametros);
                    }
                }
                else
                {
                    _signatureDocument = xadesService.Sign(null, parametros);
                }
            }
            
            MessageBox.Show("Signature completed, you can now Save the signature or extend it to Xades-T.", "XAdES signature test",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnCoFirmar_Click(object sender, EventArgs e)
        {
            SignatureParameters parametros = ObtenerParametrosFirma();
            XadesService xadesService = new XadesService();

            using (parametros.Signer = new Signer(CertUtil.SelectCertificate()))
            {                
                _signatureDocument = xadesService.CoSign(_signatureDocument, parametros);
            }

            MessageBox.Show("Signature completed successfully.", "XAdES signature test",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AmpliarFirma(SignatureFormat formato)
        {
            try
            {
                UpgradeParameters parametros = new UpgradeParameters();

                parametros.TimeStampClient = new TimeStampClient(txtURLSellado.Text);
                parametros.OCSPServers.Add(new OcspServer(txtOCSP.Text));

                // test con @firma
                /* parametros.GetOcspUrlFromCertificate = false;
                OcspServer ocspServer = new OcspServer("https://afirma.redsara.es/servidorOcsp/servidorOCSP");                
                ocspServer.SetRequestorName(OcspServer.Rfc822Name, "idAplicacion");
                ocspServer.SignCertificate = CertUtil.SelectCertificate();

                parametros.OCSPServers.Add(ocspServer); */

                XadesUpgraderService upgrader = new XadesUpgraderService();
                upgrader.Upgrade(_signatureDocument, formato, parametros);
              
                MessageBox.Show("Signature enlarged successfully", "XADES signature test",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while extending the signature: " + ex.Message);
            }
        }

        private void btnXadesT_Click(object sender, EventArgs e)
        {
            AmpliarFirma(SignatureFormat.XAdES_T);
        }

        private void btnXadesXL_Click(object sender, EventArgs e)
        {
            AmpliarFirma(SignatureFormat.XAdES_XL);
        }

        private void GuardarFirma()
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _signatureDocument.Save(saveFileDialog1.FileName);

                MessageBox.Show("Signature saved successfully.");
            }
        }

        private void btnGuardarFirma_Click(object sender, EventArgs e)
        {
            GuardarFirma();
        }

        private void btnCargarFirma_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    XadesService xadesService = new XadesService();

                    var firmas = xadesService.Load(fs);

                    FrmSeleccionarFirma frm = new FrmSeleccionarFirma(firmas);

                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        _signatureDocument = frm.FirmaSeleccionada;

                        ValidationResult result = xadesService.Validate(_signatureDocument);

                        if (!result.IsValid)
                        {
                            MessageBox.Show(result.Message, "INVALID SIGNATURE");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must select a signature.");
                    }
                }
            }
        }


        private void btnContraFirma_Click(object sender, EventArgs e)
        {
            SignatureParameters parametros = ObtenerParametrosFirma();
            XadesService xadesService = new XadesService();

            using (parametros.Signer = new Signer(CertUtil.SelectCertificate()))
            {
                _signatureDocument = xadesService.CounterSign(_signatureDocument, parametros);
            }

            MessageBox.Show("Signature completed successfully.", "XAdES signature test",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFirmarHuella_Click(object sender, EventArgs e)
        {
            if (!rbInternnallyDetached.Checked)
            {
                MessageBox.Show("Please select the signature type internally detached.");
                return;
            }

            if (string.IsNullOrEmpty(txtFichero.Text))
            {
                MessageBox.Show("You must select a file to sign.");
                return;
            }

            XadesService xadesService = new XadesService();

            SignatureParameters parametros = ObtenerParametrosFirma();
            parametros.SignaturePackaging = SignaturePackaging.HASH_INTERNALLY_DETACHED;
            parametros.DataFormat = new DataFormat();
            parametros.DataFormat.MimeType = "hash/sha256";
            parametros.DataFormat.Description = "Hash value encoded in binary format";

            using(FileStream fs = new FileStream(txtFichero.Text, FileMode.Open))
            {
                using (parametros.Signer = new Signer(CertUtil.SelectCertificate()))
                {
                    _signatureDocument = xadesService.Sign(fs, parametros);
                }
            }            

            MessageBox.Show("Signature completed, you can now Save the signature or extend it to Xades-T.", "XAdES signature test",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnFirmaMavisa_Click(object sender, EventArgs e)
        {
            // Demostración de firma masiva

            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                List<FileInfo> files = new List<FileInfo>(dirInfo.EnumerateFiles("*.pdf"));

                if (files.Count == 0)
                {
                    MessageBox.Show("No documents found");
                    return;
                }

                using (Signer signer = new Signer(CertUtil.SelectCertificate()))
                {
                    SignatureParameters sp = new SignatureParameters();
                    sp.Signer = signer;
                    sp.SignaturePackaging = SignaturePackaging.INTERNALLY_DETACHED;
                    sp.DataFormat = new DataFormat();
                    sp.DataFormat.MimeType = "application/pdf";
                    sp.SignatureMethod = ObtenerAlgoritmo();
                    sp.SignaturePolicyInfo = ObtenerPolitica();

                    XadesService xadesService = new XadesService();

                    foreach (var file in files)
                    {
                        SignatureDocument sigDocument = xadesService.Sign(file.OpenRead(), sp);

                        sigDocument.Save(string.Format(@"{0}\{1}.{2}", folderBrowserDialog1.SelectedPath, Path.GetFileNameWithoutExtension(file.Name), "xsig"));
                    }
                }

                MessageBox.Show("Process completed");
            }
        }

    }
}
