﻿// --------------------------------------------------------------------------------------------------------------------
// FrmPrincipal.cs
//
// FirmaXadesNet - Demo de generación de fichero factura-e
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
using XadesSignatureNet.Crypto;
using XadesSignatureNet.Signature.Parameters;
using XadesSignatureNet.Utils;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace DemoInvoice
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {

            // Core.MZ.20220613: Injecting function because .NET Core misses X509Certificate2UI and X509SelectionFlag
            CertUtil.FunctionToSelectCertFromCollection = (X509Certificate2Collection fcollection, string title, string message) => {

                return X509Certificate2UI.SelectFromCollection(fcollection, title, message, X509SelectionFlag.SingleSelection);

            };

            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            XadesService xadesService = new XadesService();
            SignatureParameters parametros = new SignatureParameters();

            string ficheroFactura = Application.StartupPath + "\\Facturae.xml";

            // Política de firma de factura-e 3.1
            parametros.SignaturePolicyInfo = new SignaturePolicyInfo();
            parametros.SignaturePolicyInfo.PolicyIdentifier = "http://www.facturae.es/politica_de_firma_formato_facturae/politica_de_firma_formato_facturae_v3_1.pdf";
            parametros.SignaturePolicyInfo.PolicyHash = "Ohixl6upD6av8N7pEvDABhEL6hM=";
            parametros.SignaturePackaging = SignaturePackaging.ENVELOPED;
            parametros.DataFormat = new DataFormat();
            parametros.DataFormat.MimeType = "text/xml";
            parametros.SignerRole = new SignerRole();
            parametros.SignerRole.ClaimedRoles.Add("emisor");

            using (parametros.Signer = new Signer(XadesSignatureNet.Utils.CertUtil.SelectCertificate()))
            {
                using (FileStream fs = new FileStream(ficheroFactura, FileMode.Open))
                {
                    var docFirmado = xadesService.Sign(fs, parametros);

                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        docFirmado.Save(saveFileDialog1.FileName);
                        MessageBox.Show("Fichero guardado correctamente.");
                    }
                }
            }
        }
    }
}
