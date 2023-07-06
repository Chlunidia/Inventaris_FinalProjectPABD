namespace PeminjamanInventaris
{
    partial class DataMasterForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.btnPetugas = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnPeminjam = new System.Windows.Forms.Button();
            this.btnSurat = new System.Windows.Forms.Button();
            this.labelDataMaster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(340, 456);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 52);
            this.btnBack.TabIndex = 64;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBarang
            // 
            this.btnBarang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarang.Location = new System.Drawing.Point(234, 141);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(308, 43);
            this.btnBarang.TabIndex = 66;
            this.btnBarang.Text = "Data Barang";
            this.btnBarang.UseVisualStyleBackColor = true;
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayat.Location = new System.Drawing.Point(234, 337);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(308, 43);
            this.btnRiwayat.TabIndex = 67;
            this.btnRiwayat.Text = "Riwayat Penyimpanan";
            this.btnRiwayat.UseVisualStyleBackColor = true;
            // 
            // btnPetugas
            // 
            this.btnPetugas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetugas.Location = new System.Drawing.Point(234, 239);
            this.btnPetugas.Name = "btnPetugas";
            this.btnPetugas.Size = new System.Drawing.Size(308, 43);
            this.btnPetugas.TabIndex = 68;
            this.btnPetugas.Text = "Data Petugas";
            this.btnPetugas.UseVisualStyleBackColor = true;
            // 
            // btnKategori
            // 
            this.btnKategori.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategori.Location = new System.Drawing.Point(234, 190);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(308, 43);
            this.btnKategori.TabIndex = 69;
            this.btnKategori.Text = "Data Kategori Barang";
            this.btnKategori.UseVisualStyleBackColor = true;
            // 
            // btnPeminjam
            // 
            this.btnPeminjam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjam.Location = new System.Drawing.Point(234, 288);
            this.btnPeminjam.Name = "btnPeminjam";
            this.btnPeminjam.Size = new System.Drawing.Size(308, 43);
            this.btnPeminjam.TabIndex = 70;
            this.btnPeminjam.Text = "Data Peminjam";
            this.btnPeminjam.UseVisualStyleBackColor = true;
            // 
            // btnSurat
            // 
            this.btnSurat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurat.Location = new System.Drawing.Point(234, 386);
            this.btnSurat.Name = "btnSurat";
            this.btnSurat.Size = new System.Drawing.Size(308, 43);
            this.btnSurat.TabIndex = 71;
            this.btnSurat.Text = "Surat Peminjaman";
            this.btnSurat.UseVisualStyleBackColor = true;
            // 
            // labelDataMaster
            // 
            this.labelDataMaster.AutoSize = true;
            this.labelDataMaster.Font = new System.Drawing.Font("Girlie", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataMaster.Location = new System.Drawing.Point(207, 18);
            this.labelDataMaster.Name = "labelDataMaster";
            this.labelDataMaster.Size = new System.Drawing.Size(371, 114);
            this.labelDataMaster.TabIndex = 72;
            this.labelDataMaster.Text = "Data Master";
            // 
            // DataMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.labelDataMaster);
            this.Controls.Add(this.btnSurat);
            this.Controls.Add(this.btnPeminjam);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnPetugas);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnBarang);
            this.Controls.Add(this.btnBack);
            this.Name = "DataMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataMasterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Button btnPetugas;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnPeminjam;
        private System.Windows.Forms.Button btnSurat;
        private System.Windows.Forms.Label labelDataMaster;
    }
}