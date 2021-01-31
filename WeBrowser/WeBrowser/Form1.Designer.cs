
namespace WeBrowser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btNatrag = new System.Windows.Forms.Button();
            this.btNaprijed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnIdi = new System.Windows.Forms.Button();
            this.btnWebmail = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnGmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNatrag
            // 
            this.btNatrag.Location = new System.Drawing.Point(12, 12);
            this.btNatrag.Name = "btNatrag";
            this.btNatrag.Size = new System.Drawing.Size(75, 23);
            this.btNatrag.TabIndex = 0;
            this.btNatrag.Text = "Natrag";
            this.btNatrag.UseVisualStyleBackColor = true;
            this.btNatrag.Click += new System.EventHandler(this.btNatrag_Click);
            // 
            // btNaprijed
            // 
            this.btNaprijed.Location = new System.Drawing.Point(109, 12);
            this.btNaprijed.Name = "btNaprijed";
            this.btNaprijed.Size = new System.Drawing.Size(75, 23);
            this.btNaprijed.TabIndex = 1;
            this.btNaprijed.Text = "Naprijed";
            this.btNaprijed.UseVisualStyleBackColor = true;
            this.btNaprijed.Click += new System.EventHandler(this.btNaprijed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(258, 17);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(222, 20);
            this.txtAdresa.TabIndex = 3;
            this.txtAdresa.TextChanged += new System.EventHandler(this.txtAdresa_TextChanged);
            // 
            // btnIdi
            // 
            this.btnIdi.Location = new System.Drawing.Point(499, 15);
            this.btnIdi.Name = "btnIdi";
            this.btnIdi.Size = new System.Drawing.Size(44, 23);
            this.btnIdi.TabIndex = 4;
            this.btnIdi.Text = "Idi";
            this.btnIdi.UseVisualStyleBackColor = true;
            this.btnIdi.Click += new System.EventHandler(this.btnIdi_Click);
            // 
            // btnWebmail
            // 
            this.btnWebmail.Location = new System.Drawing.Point(726, 12);
            this.btnWebmail.Name = "btnWebmail";
            this.btnWebmail.Size = new System.Drawing.Size(76, 23);
            this.btnWebmail.TabIndex = 5;
            this.btnWebmail.Text = "Webmail";
            this.btnWebmail.UseVisualStyleBackColor = true;
            this.btnWebmail.Click += new System.EventHandler(this.btnWebmail_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(825, 12);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(44, 23);
            this.btnIspis.TabIndex = 6;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(13, 42);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1027, 581);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Url = new System.Uri("http://web2.ss-zcrnje-rovinj.skole.hr/", System.UriKind.Absolute);
            // 
            // btnGmail
            // 
            this.btnGmail.Location = new System.Drawing.Point(628, 12);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(75, 23);
            this.btnGmail.TabIndex = 8;
            this.btnGmail.Text = "Gmail";
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1038, 625);
            this.Controls.Add(this.btnGmail);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnWebmail);
            this.Controls.Add(this.btnIdi);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNaprijed);
            this.Controls.Add(this.btNatrag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shcum Browser™";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNatrag;
        private System.Windows.Forms.Button btNaprijed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnIdi;
        private System.Windows.Forms.Button btnWebmail;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnGmail;
    }
}

