namespace OV_Tool
{
    partial class eMailUndPasswort
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
            this.lblSender = new System.Windows.Forms.Label();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.tbEmpfänger = new System.Windows.Forms.TextBox();
            this.lblEmpfänger = new System.Windows.Forms.Label();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.btSenden = new System.Windows.Forms.Button();
            this.lblinhalt = new System.Windows.Forms.Label();
            this.rtbInhalt = new System.Windows.Forms.RichTextBox();
            this.tbBetreff = new System.Windows.Forms.TextBox();
            this.lblSubjekt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSender.Location = new System.Drawing.Point(10, 13);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(101, 13);
            this.lblSender.TabIndex = 0;
            this.lblSender.Text = "Ihre eMail-Adresse:*";
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(146, 13);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(251, 20);
            this.tbSender.TabIndex = 1;
            // 
            // tbEmpfänger
            // 
            this.tbEmpfänger.Location = new System.Drawing.Point(146, 101);
            this.tbEmpfänger.Name = "tbEmpfänger";
            this.tbEmpfänger.Size = new System.Drawing.Size(251, 20);
            this.tbEmpfänger.TabIndex = 7;
            // 
            // lblEmpfänger
            // 
            this.lblEmpfänger.AutoSize = true;
            this.lblEmpfänger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpfänger.Location = new System.Drawing.Point(10, 101);
            this.lblEmpfänger.Name = "lblEmpfänger";
            this.lblEmpfänger.Size = new System.Drawing.Size(134, 13);
            this.lblEmpfänger.TabIndex = 2;
            this.lblEmpfänger.Text = "eMail-Adresse Empfänger:*";
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(146, 39);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(251, 20);
            this.tbPW.TabIndex = 2;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPW.Location = new System.Drawing.Point(10, 39);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(72, 13);
            this.lblPW.TabIndex = 4;
            this.lblPW.Text = "Ihr Passwort:*";
            // 
            // btSenden
            // 
            this.btSenden.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSenden.Location = new System.Drawing.Point(322, 276);
            this.btSenden.Name = "btSenden";
            this.btSenden.Size = new System.Drawing.Size(75, 23);
            this.btSenden.TabIndex = 10;
            this.btSenden.Text = "Senden";
            this.btSenden.UseVisualStyleBackColor = false;
            this.btSenden.Click += new System.EventHandler(this.btSenden_Click);
            // 
            // lblinhalt
            // 
            this.lblinhalt.AutoSize = true;
            this.lblinhalt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinhalt.Location = new System.Drawing.Point(10, 153);
            this.lblinhalt.Name = "lblinhalt";
            this.lblinhalt.Size = new System.Drawing.Size(36, 13);
            this.lblinhalt.TabIndex = 7;
            this.lblinhalt.Text = "Inhalt:";
            // 
            // rtbInhalt
            // 
            this.rtbInhalt.Location = new System.Drawing.Point(146, 153);
            this.rtbInhalt.Name = "rtbInhalt";
            this.rtbInhalt.Size = new System.Drawing.Size(251, 117);
            this.rtbInhalt.TabIndex = 9;
            this.rtbInhalt.Text = "";
            // 
            // tbBetreff
            // 
            this.tbBetreff.Location = new System.Drawing.Point(146, 127);
            this.tbBetreff.Name = "tbBetreff";
            this.tbBetreff.Size = new System.Drawing.Size(251, 20);
            this.tbBetreff.TabIndex = 8;
            // 
            // lblSubjekt
            // 
            this.lblSubjekt.AutoSize = true;
            this.lblSubjekt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSubjekt.Location = new System.Drawing.Point(10, 127);
            this.lblSubjekt.Name = "lblSubjekt";
            this.lblSubjekt.Size = new System.Drawing.Size(45, 13);
            this.lblSubjekt.TabIndex = 9;
            this.lblSubjekt.Text = "Betreff:*";
            // 
            // eMailUndPasswort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(426, 309);
            this.Controls.Add(this.tbBetreff);
            this.Controls.Add(this.lblSubjekt);
            this.Controls.Add(this.rtbInhalt);
            this.Controls.Add(this.lblinhalt);
            this.Controls.Add(this.btSenden);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.tbEmpfänger);
            this.Controls.Add(this.lblEmpfänger);
            this.Controls.Add(this.tbSender);
            this.Controls.Add(this.lblSender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "eMailUndPasswort";
            this.Text = "eMail Senden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.TextBox tbSender;
        private System.Windows.Forms.TextBox tbEmpfänger;
        private System.Windows.Forms.Label lblEmpfänger;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Button btSenden;
        private System.Windows.Forms.Label lblinhalt;
        private System.Windows.Forms.RichTextBox rtbInhalt;
        private System.Windows.Forms.TextBox tbBetreff;
        private System.Windows.Forms.Label lblSubjekt;
    }
}