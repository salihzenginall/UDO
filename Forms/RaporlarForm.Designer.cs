namespace UDO.Forms
{
    partial class RaporlarForm
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
            this.panelUst = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelIcerik = new System.Windows.Forms.Panel();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.dataGridViewRapor = new System.Windows.Forms.DataGridView();
            this.cmbRaporTuru = new System.Windows.Forms.ComboBox();
            this.lblRaporTuru = new System.Windows.Forms.Label();
            this.btnRaporGetir = new System.Windows.Forms.Button();
            this.panelUst.SuspendLayout();
            this.panelIcerik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapor)).BeginInit();
            this.SuspendLayout();
            //
            // panelUst
            //
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.panelUst.Controls.Add(this.lblBaslik);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(950, 50);
            this.panelUst.TabIndex = 0;
            //
            // lblBaslik
            //
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(12, 11);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(99, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "RAPORLAR";
            //
            // panelIcerik
            //
            this.panelIcerik.Controls.Add(this.btnRaporGetir);
            this.panelIcerik.Controls.Add(this.lblRaporTuru);
            this.panelIcerik.Controls.Add(this.cmbRaporTuru);
            this.panelIcerik.Controls.Add(this.lblBilgi);
            this.panelIcerik.Controls.Add(this.dataGridViewRapor);
            this.panelIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIcerik.Location = new System.Drawing.Point(0, 50);
            this.panelIcerik.Name = "panelIcerik";
            this.panelIcerik.Padding = new System.Windows.Forms.Padding(10);
            this.panelIcerik.Size = new System.Drawing.Size(950, 555);
            this.panelIcerik.TabIndex = 1;
            //
            // lblBilgi
            //
            this.lblBilgi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBilgi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.Color.Gray;
            this.lblBilgi.Location = new System.Drawing.Point(10, 525);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(930, 20);
            this.lblBilgi.TabIndex = 2;
            this.lblBilgi.Text = "Toplam kayıt: 0";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // dataGridViewRapor
            //
            this.dataGridViewRapor.AllowUserToAddRows = false;
            this.dataGridViewRapor.AllowUserToDeleteRows = false;
            this.dataGridViewRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRapor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRapor.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewRapor.Name = "dataGridViewRapor";
            this.dataGridViewRapor.ReadOnly = true;
            this.dataGridViewRapor.Size = new System.Drawing.Size(930, 470);
            this.dataGridViewRapor.TabIndex = 1;
            //
            // cmbRaporTuru
            //
            this.cmbRaporTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaporTuru.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRaporTuru.FormattingEnabled = true;
            this.cmbRaporTuru.Items.AddRange(new object[] {
            "Tüm Seferler",
            "Aktif Seferler",
            "İptal Edilen Seferler",
            "Tamamlanan Seferler",
            "Tüm Müşteriler",
            "Aktif Müşteriler",
            "VIP Müşteriler",
            "Tüm Personel",
            "Aktif Personel",
            "Pasif Personel",
            "Tüm Deniz Otobüsleri",
            "Bakım Zamanı Gelen Deniz Otobüsleri"});
            this.cmbRaporTuru.Location = new System.Drawing.Point(100, 15);
            this.cmbRaporTuru.Name = "cmbRaporTuru";
            this.cmbRaporTuru.Size = new System.Drawing.Size(250, 23);
            this.cmbRaporTuru.TabIndex = 0;
            this.cmbRaporTuru.SelectedIndexChanged += new System.EventHandler(this.cmbRaporTuru_SelectedIndexChanged);
            //
            // lblRaporTuru
            //
            this.lblRaporTuru.AutoSize = true;
            this.lblRaporTuru.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRaporTuru.Location = new System.Drawing.Point(10, 18);
            this.lblRaporTuru.Name = "lblRaporTuru";
            this.lblRaporTuru.Size = new System.Drawing.Size(68, 15);
            this.lblRaporTuru.TabIndex = 3;
            this.lblRaporTuru.Text = "Rapor Türü:";
            //
            // btnRaporGetir
            //
            this.btnRaporGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnRaporGetir.FlatAppearance.BorderSize = 0;
            this.btnRaporGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporGetir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporGetir.ForeColor = System.Drawing.Color.White;
            this.btnRaporGetir.Location = new System.Drawing.Point(360, 14);
            this.btnRaporGetir.Name = "btnRaporGetir";
            this.btnRaporGetir.Size = new System.Drawing.Size(100, 25);
            this.btnRaporGetir.TabIndex = 4;
            this.btnRaporGetir.Text = "Rapor Getir";
            this.btnRaporGetir.UseVisualStyleBackColor = false;
            this.btnRaporGetir.Click += new System.EventHandler(this.btnRaporGetir_Click);
            //
            // RaporlarForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 605);
            this.Controls.Add(this.panelIcerik);
            this.Controls.Add(this.panelUst);
            this.Name = "RaporlarForm";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.RaporlarForm_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelIcerik.ResumeLayout(false);
            this.panelIcerik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelIcerik;
        private System.Windows.Forms.DataGridView dataGridViewRapor;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Button btnRaporGetir;
        private System.Windows.Forms.Label lblRaporTuru;
        private System.Windows.Forms.ComboBox cmbRaporTuru;
    }
}