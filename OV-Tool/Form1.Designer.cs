namespace OV_Tool
{
    partial class FRMTransportSwiss
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
            this.TCMain = new System.Windows.Forms.TabControl();
            this.tabVonBis = new System.Windows.Forms.TabPage();
            this.btKarteNach = new System.Windows.Forms.Button();
            this.btKarteVon = new System.Windows.Forms.Button();
            this.tbNach = new System.Windows.Forms.TextBox();
            this.tbVon = new System.Windows.Forms.TextBox();
            this.DTPDatumVonNach = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.DTPZeitVonNach = new System.Windows.Forms.DateTimePicker();
            this.btSuchen = new System.Windows.Forms.Button();
            this.lblZeit = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            this.tabAbfahrtstafel = new System.Windows.Forms.TabPage();
            this.btgenerateabfahrtsort = new System.Windows.Forms.Button();
            this.tbAbfahrtsort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LVResult = new System.Windows.Forms.ListView();
            this.CHFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHDeparture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHGleis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblVerbindungen = new System.Windows.Forms.Label();
            this.btMailSenden = new System.Windows.Forms.Button();
            this.btKarteVonAbfahrt = new System.Windows.Forms.Button();
            this.TCMain.SuspendLayout();
            this.tabVonBis.SuspendLayout();
            this.tabAbfahrtstafel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCMain
            // 
            this.TCMain.Controls.Add(this.tabVonBis);
            this.TCMain.Controls.Add(this.tabAbfahrtstafel);
            this.TCMain.Location = new System.Drawing.Point(12, 8);
            this.TCMain.Name = "TCMain";
            this.TCMain.SelectedIndex = 0;
            this.TCMain.Size = new System.Drawing.Size(341, 153);
            this.TCMain.TabIndex = 0;
            // 
            // tabVonBis
            // 
            this.tabVonBis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabVonBis.Controls.Add(this.btKarteNach);
            this.tabVonBis.Controls.Add(this.btKarteVon);
            this.tabVonBis.Controls.Add(this.tbNach);
            this.tabVonBis.Controls.Add(this.tbVon);
            this.tabVonBis.Controls.Add(this.DTPDatumVonNach);
            this.tabVonBis.Controls.Add(this.lblDatum);
            this.tabVonBis.Controls.Add(this.DTPZeitVonNach);
            this.tabVonBis.Controls.Add(this.btSuchen);
            this.tabVonBis.Controls.Add(this.lblZeit);
            this.tabVonBis.Controls.Add(this.lblNach);
            this.tabVonBis.Controls.Add(this.lblVon);
            this.tabVonBis.Location = new System.Drawing.Point(4, 22);
            this.tabVonBis.Name = "tabVonBis";
            this.tabVonBis.Padding = new System.Windows.Forms.Padding(3);
            this.tabVonBis.Size = new System.Drawing.Size(333, 127);
            this.tabVonBis.TabIndex = 0;
            this.tabVonBis.Text = "Von - Nach";
            // 
            // btKarteNach
            // 
            this.btKarteNach.Location = new System.Drawing.Point(263, 39);
            this.btKarteNach.Name = "btKarteNach";
            this.btKarteNach.Size = new System.Drawing.Size(63, 23);
            this.btKarteNach.TabIndex = 26;
            this.btKarteNach.Text = "Karte";
            this.btKarteNach.UseVisualStyleBackColor = true;
            this.btKarteNach.Click += new System.EventHandler(this.btKarte_Click);
            // 
            // btKarteVon
            // 
            this.btKarteVon.Location = new System.Drawing.Point(263, 14);
            this.btKarteVon.Name = "btKarteVon";
            this.btKarteVon.Size = new System.Drawing.Size(63, 23);
            this.btKarteVon.TabIndex = 25;
            this.btKarteVon.Text = "Karte";
            this.btKarteVon.UseVisualStyleBackColor = true;
            this.btKarteVon.Click += new System.EventHandler(this.btKarte_Click);
            // 
            // tbNach
            // 
            this.tbNach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbNach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNach.Location = new System.Drawing.Point(42, 42);
            this.tbNach.Name = "tbNach";
            this.tbNach.Size = new System.Drawing.Size(215, 20);
            this.tbNach.TabIndex = 24;
            this.tbNach.TextChanged += new System.EventHandler(this.tbNach_TextChanged);
            // 
            // tbVon
            // 
            this.tbVon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbVon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbVon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVon.Location = new System.Drawing.Point(42, 18);
            this.tbVon.Name = "tbVon";
            this.tbVon.Size = new System.Drawing.Size(215, 20);
            this.tbVon.TabIndex = 23;
            this.tbVon.TextChanged += new System.EventHandler(this.tbVon_TextChanged_1);
            // 
            // DTPDatumVonNach
            // 
            this.DTPDatumVonNach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDatumVonNach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTPDatumVonNach.Location = new System.Drawing.Point(176, 70);
            this.DTPDatumVonNach.Name = "DTPDatumVonNach";
            this.DTPDatumVonNach.Size = new System.Drawing.Size(81, 20);
            this.DTPDatumVonNach.TabIndex = 21;
            this.DTPDatumVonNach.Value = new System.DateTime(2016, 5, 24, 16, 10, 46, 0);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(130, 73);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 20;
            this.lblDatum.Text = "Datum:";
            // 
            // DTPZeitVonNach
            // 
            this.DTPZeitVonNach.CustomFormat = "HH:mm";
            this.DTPZeitVonNach.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTPZeitVonNach.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPZeitVonNach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTPZeitVonNach.Location = new System.Drawing.Point(42, 70);
            this.DTPZeitVonNach.Name = "DTPZeitVonNach";
            this.DTPZeitVonNach.ShowUpDown = true;
            this.DTPZeitVonNach.Size = new System.Drawing.Size(78, 20);
            this.DTPZeitVonNach.TabIndex = 19;
            this.DTPZeitVonNach.Value = new System.DateTime(2016, 5, 24, 16, 10, 46, 0);
            // 
            // btSuchen
            // 
            this.btSuchen.Location = new System.Drawing.Point(9, 98);
            this.btSuchen.Name = "btSuchen";
            this.btSuchen.Size = new System.Drawing.Size(75, 23);
            this.btSuchen.TabIndex = 8;
            this.btSuchen.Text = "Suchen";
            this.btSuchen.UseVisualStyleBackColor = true;
            this.btSuchen.Click += new System.EventHandler(this.btSuchen_Click);
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(7, 72);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(28, 13);
            this.lblZeit.TabIndex = 4;
            this.lblZeit.Text = "Zeit:";
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(6, 45);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(36, 13);
            this.lblNach.TabIndex = 2;
            this.lblNach.Text = "Nach:";
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(6, 18);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(29, 13);
            this.lblVon.TabIndex = 0;
            this.lblVon.Text = "Von:";
            // 
            // tabAbfahrtstafel
            // 
            this.tabAbfahrtstafel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabAbfahrtstafel.Controls.Add(this.btKarteVonAbfahrt);
            this.tabAbfahrtstafel.Controls.Add(this.btgenerateabfahrtsort);
            this.tabAbfahrtstafel.Controls.Add(this.tbAbfahrtsort);
            this.tabAbfahrtstafel.Controls.Add(this.label4);
            this.tabAbfahrtstafel.Location = new System.Drawing.Point(4, 22);
            this.tabAbfahrtstafel.Name = "tabAbfahrtstafel";
            this.tabAbfahrtstafel.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbfahrtstafel.Size = new System.Drawing.Size(333, 127);
            this.tabAbfahrtstafel.TabIndex = 1;
            this.tabAbfahrtstafel.Text = "Abfahrtstafel";
            // 
            // btgenerateabfahrtsort
            // 
            this.btgenerateabfahrtsort.Location = new System.Drawing.Point(9, 98);
            this.btgenerateabfahrtsort.Name = "btgenerateabfahrtsort";
            this.btgenerateabfahrtsort.Size = new System.Drawing.Size(75, 23);
            this.btgenerateabfahrtsort.TabIndex = 17;
            this.btgenerateabfahrtsort.Text = "Suchen";
            this.btgenerateabfahrtsort.UseVisualStyleBackColor = true;
            this.btgenerateabfahrtsort.Click += new System.EventHandler(this.btgenerateabfahrtsort_Click);
            // 
            // tbAbfahrtsort
            // 
            this.tbAbfahrtsort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbAbfahrtsort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbAbfahrtsort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAbfahrtsort.Location = new System.Drawing.Point(42, 18);
            this.tbAbfahrtsort.Name = "tbAbfahrtsort";
            this.tbAbfahrtsort.Size = new System.Drawing.Size(215, 20);
            this.tbAbfahrtsort.TabIndex = 10;
            this.tbAbfahrtsort.TextChanged += new System.EventHandler(this.tbAbfahrtsort_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Von:";
            // 
            // LVResult
            // 
            this.LVResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LVResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHFrom,
            this.CHto,
            this.CHDeparture,
            this.CHDauer,
            this.CHGleis});
            this.LVResult.Location = new System.Drawing.Point(12, 184);
            this.LVResult.Name = "LVResult";
            this.LVResult.Size = new System.Drawing.Size(341, 159);
            this.LVResult.TabIndex = 1;
            this.LVResult.UseCompatibleStateImageBehavior = false;
            this.LVResult.View = System.Windows.Forms.View.Details;
            // 
            // CHFrom
            // 
            this.CHFrom.Text = "Von";
            this.CHFrom.Width = 80;
            // 
            // CHto
            // 
            this.CHto.Text = "Nach";
            this.CHto.Width = 80;
            // 
            // CHDeparture
            // 
            this.CHDeparture.Text = "Abfahrt";
            this.CHDeparture.Width = 70;
            // 
            // CHDauer
            // 
            this.CHDauer.Text = "Dauer";
            // 
            // CHGleis
            // 
            this.CHGleis.Text = "Gleis";
            this.CHGleis.Width = 51;
            // 
            // lblVerbindungen
            // 
            this.lblVerbindungen.AutoSize = true;
            this.lblVerbindungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbindungen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVerbindungen.Location = new System.Drawing.Point(13, 165);
            this.lblVerbindungen.Name = "lblVerbindungen";
            this.lblVerbindungen.Size = new System.Drawing.Size(108, 16);
            this.lblVerbindungen.TabIndex = 2;
            this.lblVerbindungen.Text = "Verbindungen:";
            // 
            // btMailSenden
            // 
            this.btMailSenden.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btMailSenden.Location = new System.Drawing.Point(12, 351);
            this.btMailSenden.Name = "btMailSenden";
            this.btMailSenden.Size = new System.Drawing.Size(109, 23);
            this.btMailSenden.TabIndex = 3;
            this.btMailSenden.Text = "Als Mail senden";
            this.btMailSenden.UseVisualStyleBackColor = false;
            this.btMailSenden.Click += new System.EventHandler(this.btMailSenden_Click);
            // 
            // btKarteVonAbfahrt
            // 
            this.btKarteVonAbfahrt.Location = new System.Drawing.Point(263, 14);
            this.btKarteVonAbfahrt.Name = "btKarteVonAbfahrt";
            this.btKarteVonAbfahrt.Size = new System.Drawing.Size(63, 23);
            this.btKarteVonAbfahrt.TabIndex = 26;
            this.btKarteVonAbfahrt.Text = "Karte";
            this.btKarteVonAbfahrt.UseVisualStyleBackColor = true;
            this.btKarteVonAbfahrt.Click += new System.EventHandler(this.btKarte_Click);
            // 
            // FRMTransportSwiss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(365, 386);
            this.Controls.Add(this.btMailSenden);
            this.Controls.Add(this.lblVerbindungen);
            this.Controls.Add(this.LVResult);
            this.Controls.Add(this.TCMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FRMTransportSwiss";
            this.Text = "Transport Swiss";
            this.Load += new System.EventHandler(this.FRMTransportSwiss_Load);
            this.TCMain.ResumeLayout(false);
            this.tabVonBis.ResumeLayout(false);
            this.tabVonBis.PerformLayout();
            this.tabAbfahrtstafel.ResumeLayout(false);
            this.tabAbfahrtstafel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TCMain;
        private System.Windows.Forms.TabPage tabVonBis;
        private System.Windows.Forms.TabPage tabAbfahrtstafel;
        private System.Windows.Forms.ListView LVResult;
        private System.Windows.Forms.Button btSuchen;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.DateTimePicker DTPZeitVonNach;
        private System.Windows.Forms.Button btgenerateabfahrtsort;
        private System.Windows.Forms.TextBox tbAbfahrtsort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPDatumVonNach;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblVerbindungen;
        private System.Windows.Forms.ColumnHeader CHFrom;
        private System.Windows.Forms.ColumnHeader CHto;
        private System.Windows.Forms.ColumnHeader CHDeparture;
        private System.Windows.Forms.ColumnHeader CHDauer;
        private System.Windows.Forms.ColumnHeader CHGleis;
        private System.Windows.Forms.TextBox tbNach;
        private System.Windows.Forms.TextBox tbVon;
        private System.Windows.Forms.Button btKarteVon;
        private System.Windows.Forms.Button btKarteNach;
        private System.Windows.Forms.Button btMailSenden;
        private System.Windows.Forms.Button btKarteVonAbfahrt;
    }
}

