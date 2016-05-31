namespace OV_Tool
{
    partial class Map
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
            this.WBKarte = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WBKarte
            // 
            this.WBKarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBKarte.Location = new System.Drawing.Point(0, 0);
            this.WBKarte.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBKarte.Name = "WBKarte";
            this.WBKarte.Size = new System.Drawing.Size(939, 631);
            this.WBKarte.TabIndex = 0;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(939, 631);
            this.Controls.Add(this.WBKarte);
            this.Name = "Map";
            this.Text = "Map";
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.WebBrowser WBKarte;
    }
}