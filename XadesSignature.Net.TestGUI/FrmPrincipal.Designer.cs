namespace XadesSignatureNetTestGUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEnveloping = new System.Windows.Forms.RadioButton();
            this.btnSeleccionarFichero = new System.Windows.Forms.Button();
            this.txtFichero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbEnveloped = new System.Windows.Forms.RadioButton();
            this.rbExternallyDetached = new System.Windows.Forms.RadioButton();
            this.rbInternnallyDetached = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtURLSellado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOCSP = new System.Windows.Forms.TextBox();
            this.btnXadesT = new System.Windows.Forms.Button();
            this.btnXadesXL = new System.Windows.Forms.Button();
            this.btnGuardarFirma = new System.Windows.Forms.Button();
            this.btnCargarFirma = new System.Windows.Forms.Button();
            this.btnCoFirmar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdentificadorPolitica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHashPolitica = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtURIPolitica = new System.Windows.Forms.TextBox();
            this.btnContraFirma = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAlgoritmo = new System.Windows.Forms.ComboBox();
            this.btnFirmarHuella = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFirmaMavisa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFirmar
            // 
            this.btnFirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFirmar.Location = new System.Drawing.Point(19, 482);
            this.btnFirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFirmar.Name = "btnFirmar";
            this.btnFirmar.Size = new System.Drawing.Size(88, 27);
            this.btnFirmar.TabIndex = 0;
            this.btnFirmar.Text = "Sign";
            this.btnFirmar.UseVisualStyleBackColor = true;
            this.btnFirmar.Click += new System.EventHandler(this.btnFirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEnveloping);
            this.groupBox1.Controls.Add(this.btnSeleccionarFichero);
            this.groupBox1.Controls.Add(this.txtFichero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbEnveloped);
            this.groupBox1.Controls.Add(this.rbExternallyDetached);
            this.groupBox1.Controls.Add(this.rbInternnallyDetached);
            this.groupBox1.Location = new System.Drawing.Point(14, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(707, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato de firma";
            // 
            // rbEnveloping
            // 
            this.rbEnveloping.AutoSize = true;
            this.rbEnveloping.Location = new System.Drawing.Point(15, 113);
            this.rbEnveloping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbEnveloping.Name = "rbEnveloping";
            this.rbEnveloping.Size = new System.Drawing.Size(84, 19);
            this.rbEnveloping.TabIndex = 6;
            this.rbEnveloping.Text = "Enveloping";
            this.rbEnveloping.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarFichero
            // 
            this.btnSeleccionarFichero.Location = new System.Drawing.Point(496, 163);
            this.btnSeleccionarFichero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeleccionarFichero.Name = "btnSeleccionarFichero";
            this.btnSeleccionarFichero.Size = new System.Drawing.Size(33, 27);
            this.btnSeleccionarFichero.TabIndex = 5;
            this.btnSeleccionarFichero.Text = "...";
            this.btnSeleccionarFichero.UseVisualStyleBackColor = true;
            this.btnSeleccionarFichero.Click += new System.EventHandler(this.btnSeleccionarFichero_Click);
            // 
            // txtFichero
            // 
            this.txtFichero.Location = new System.Drawing.Point(15, 164);
            this.txtFichero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFichero.Name = "txtFichero";
            this.txtFichero.Size = new System.Drawing.Size(480, 23);
            this.txtFichero.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original file:";
            // 
            // rbEnveloped
            // 
            this.rbEnveloped.AutoSize = true;
            this.rbEnveloped.Location = new System.Drawing.Point(15, 87);
            this.rbEnveloped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbEnveloped.Name = "rbEnveloped";
            this.rbEnveloped.Size = new System.Drawing.Size(80, 19);
            this.rbEnveloped.TabIndex = 2;
            this.rbEnveloped.Text = "Enveloped";
            this.rbEnveloped.UseVisualStyleBackColor = true;
            // 
            // rbExternallyDetached
            // 
            this.rbExternallyDetached.AutoSize = true;
            this.rbExternallyDetached.Location = new System.Drawing.Point(15, 59);
            this.rbExternallyDetached.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbExternallyDetached.Name = "rbExternallyDetached";
            this.rbExternallyDetached.Size = new System.Drawing.Size(128, 19);
            this.rbExternallyDetached.TabIndex = 1;
            this.rbExternallyDetached.Text = "Externally detached";
            this.rbExternallyDetached.UseVisualStyleBackColor = true;
            // 
            // rbInternnallyDetached
            // 
            this.rbInternnallyDetached.AutoSize = true;
            this.rbInternnallyDetached.Checked = true;
            this.rbInternnallyDetached.Location = new System.Drawing.Point(15, 31);
            this.rbInternnallyDetached.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbInternnallyDetached.Name = "rbInternnallyDetached";
            this.rbInternnallyDetached.Size = new System.Drawing.Size(126, 19);
            this.rbInternnallyDetached.TabIndex = 0;
            this.rbInternnallyDetached.TabStop = true;
            this.rbInternnallyDetached.Text = "Internally detached";
            this.rbInternnallyDetached.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML|*.xml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL timestamping server:";
            // 
            // txtURLSellado
            // 
            this.txtURLSellado.Location = new System.Drawing.Point(19, 245);
            this.txtURLSellado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtURLSellado.Name = "txtURLSellado";
            this.txtURLSellado.Size = new System.Drawing.Size(308, 23);
            this.txtURLSellado.TabIndex = 3;
            this.txtURLSellado.Text = "http://tss.accv.es:8318/tsa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "OCSP by default:";
            // 
            // txtOCSP
            // 
            this.txtOCSP.Location = new System.Drawing.Point(352, 243);
            this.txtOCSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOCSP.Name = "txtOCSP";
            this.txtOCSP.Size = new System.Drawing.Size(366, 23);
            this.txtOCSP.TabIndex = 5;
            this.txtOCSP.Text = "http://ocsp.dnie.es";
            // 
            // btnXadesT
            // 
            this.btnXadesT.Location = new System.Drawing.Point(380, 515);
            this.btnXadesT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXadesT.Name = "btnXadesT";
            this.btnXadesT.Size = new System.Drawing.Size(168, 27);
            this.btnXadesT.TabIndex = 6;
            this.btnXadesT.Text = "Expand to XADES-T";
            this.btnXadesT.UseVisualStyleBackColor = true;
            this.btnXadesT.Click += new System.EventHandler(this.btnXadesT_Click);
            // 
            // btnXadesXL
            // 
            this.btnXadesXL.Location = new System.Drawing.Point(562, 515);
            this.btnXadesXL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXadesXL.Name = "btnXadesXL";
            this.btnXadesXL.Size = new System.Drawing.Size(156, 27);
            this.btnXadesXL.TabIndex = 7;
            this.btnXadesXL.Text = "Upgrade to XADES-XL";
            this.btnXadesXL.UseVisualStyleBackColor = true;
            this.btnXadesXL.Click += new System.EventHandler(this.btnXadesXL_Click);
            // 
            // btnGuardarFirma
            // 
            this.btnGuardarFirma.Location = new System.Drawing.Point(606, 456);
            this.btnGuardarFirma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardarFirma.Name = "btnGuardarFirma";
            this.btnGuardarFirma.Size = new System.Drawing.Size(113, 27);
            this.btnGuardarFirma.TabIndex = 8;
            this.btnGuardarFirma.Text = "Save signature";
            this.btnGuardarFirma.UseVisualStyleBackColor = true;
            this.btnGuardarFirma.Click += new System.EventHandler(this.btnGuardarFirma_Click);
            // 
            // btnCargarFirma
            // 
            this.btnCargarFirma.Location = new System.Drawing.Point(606, 420);
            this.btnCargarFirma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCargarFirma.Name = "btnCargarFirma";
            this.btnCargarFirma.Size = new System.Drawing.Size(113, 27);
            this.btnCargarFirma.TabIndex = 9;
            this.btnCargarFirma.Text = "Upload signature";
            this.btnCargarFirma.UseVisualStyleBackColor = true;
            this.btnCargarFirma.Click += new System.EventHandler(this.btnCargarFirma_Click);
            // 
            // btnCoFirmar
            // 
            this.btnCoFirmar.Location = new System.Drawing.Point(113, 482);
            this.btnCoFirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCoFirmar.Name = "btnCoFirmar";
            this.btnCoFirmar.Size = new System.Drawing.Size(88, 27);
            this.btnCoFirmar.TabIndex = 10;
            this.btnCoFirmar.Text = "Co-Sign";
            this.btnCoFirmar.UseVisualStyleBackColor = true;
            this.btnCoFirmar.Click += new System.EventHandler(this.btnCoFirmar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Signature Policy Identifier:";
            // 
            // txtIdentificadorPolitica
            // 
            this.txtIdentificadorPolitica.Location = new System.Drawing.Point(19, 308);
            this.txtIdentificadorPolitica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIdentificadorPolitica.Name = "txtIdentificadorPolitica";
            this.txtIdentificadorPolitica.Size = new System.Drawing.Size(274, 23);
            this.txtIdentificadorPolitica.TabIndex = 12;
            this.txtIdentificadorPolitica.Text = "urn:oid:2.16.724.1.3.1.1.2.1.8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Policy hash value (base64):";
            // 
            // txtHashPolitica
            // 
            this.txtHashPolitica.Location = new System.Drawing.Point(323, 307);
            this.txtHashPolitica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHashPolitica.Name = "txtHashPolitica";
            this.txtHashPolitica.Size = new System.Drawing.Size(395, 23);
            this.txtHashPolitica.TabIndex = 14;
            this.txtHashPolitica.Text = "V8lVVNGDCPen6VELRD1Ja8HARFk=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Policy URI:";
            // 
            // txtURIPolitica
            // 
            this.txtURIPolitica.Location = new System.Drawing.Point(19, 370);
            this.txtURIPolitica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtURIPolitica.Name = "txtURIPolitica";
            this.txtURIPolitica.Size = new System.Drawing.Size(699, 23);
            this.txtURIPolitica.TabIndex = 16;
            this.txtURIPolitica.Text = "http://administracionelectronica.gob.es/es/ctt/politicafirma/politica_firma_AGE_v" +
    "1_8.pdf";
            // 
            // btnContraFirma
            // 
            this.btnContraFirma.Location = new System.Drawing.Point(113, 516);
            this.btnContraFirma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnContraFirma.Name = "btnContraFirma";
            this.btnContraFirma.Size = new System.Drawing.Size(126, 27);
            this.btnContraFirma.TabIndex = 17;
            this.btnContraFirma.Text = "Counter Signature";
            this.btnContraFirma.UseVisualStyleBackColor = true;
            this.btnContraFirma.Click += new System.EventHandler(this.btnContraFirma_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 413);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Signature algorithm:";
            // 
            // cmbAlgoritmo
            // 
            this.cmbAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgoritmo.FormattingEnabled = true;
            this.cmbAlgoritmo.Items.AddRange(new object[] {
            "RSAwithSHA1",
            "RSAwithSHA256",
            "RSAwithSHA512"});
            this.cmbAlgoritmo.Location = new System.Drawing.Point(19, 433);
            this.cmbAlgoritmo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbAlgoritmo.Name = "cmbAlgoritmo";
            this.cmbAlgoritmo.Size = new System.Drawing.Size(125, 23);
            this.cmbAlgoritmo.TabIndex = 19;
            // 
            // btnFirmarHuella
            // 
            this.btnFirmarHuella.Location = new System.Drawing.Point(19, 516);
            this.btnFirmarHuella.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFirmarHuella.Name = "btnFirmarHuella";
            this.btnFirmarHuella.Size = new System.Drawing.Size(88, 27);
            this.btnFirmarHuella.TabIndex = 20;
            this.btnFirmarHuella.Text = "Sign imprint";
            this.btnFirmarHuella.UseVisualStyleBackColor = true;
            this.btnFirmarHuella.Click += new System.EventHandler(this.btnFirmarHuella_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Seleccione la carpeta que contiene los documentos PDF";
            // 
            // btnFirmaMavisa
            // 
            this.btnFirmaMavisa.Location = new System.Drawing.Point(208, 482);
            this.btnFirmaMavisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFirmaMavisa.Name = "btnFirmaMavisa";
            this.btnFirmaMavisa.Size = new System.Drawing.Size(126, 27);
            this.btnFirmaMavisa.TabIndex = 21;
            this.btnFirmaMavisa.Text = "Massive signature";
            this.btnFirmaMavisa.UseVisualStyleBackColor = true;
            this.btnFirmaMavisa.Click += new System.EventHandler(this.btnFirmaMavisa_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 555);
            this.Controls.Add(this.btnFirmaMavisa);
            this.Controls.Add(this.btnFirmarHuella);
            this.Controls.Add(this.cmbAlgoritmo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnContraFirma);
            this.Controls.Add(this.txtURIPolitica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHashPolitica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdentificadorPolitica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCoFirmar);
            this.Controls.Add(this.btnCargarFirma);
            this.Controls.Add(this.btnGuardarFirma);
            this.Controls.Add(this.btnXadesXL);
            this.Controls.Add(this.btnXadesT);
            this.Controls.Add(this.txtOCSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtURLSellado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFirmar);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XAdES Signature Test";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbExternallyDetached;
        private System.Windows.Forms.RadioButton rbInternnallyDetached;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEnveloped;
        private System.Windows.Forms.Button btnSeleccionarFichero;
        private System.Windows.Forms.TextBox txtFichero;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtURLSellado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOCSP;
        private System.Windows.Forms.Button btnXadesT;
        private System.Windows.Forms.Button btnXadesXL;
        private System.Windows.Forms.Button btnGuardarFirma;
        private System.Windows.Forms.Button btnCargarFirma;
        private System.Windows.Forms.Button btnCoFirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdentificadorPolitica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHashPolitica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtURIPolitica;
        private System.Windows.Forms.Button btnContraFirma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAlgoritmo;
        private System.Windows.Forms.Button btnFirmarHuella;
        private System.Windows.Forms.RadioButton rbEnveloping;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFirmaMavisa;
    }
}

