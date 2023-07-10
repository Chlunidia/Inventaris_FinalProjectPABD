namespace PeminjamanInventaris
{
    partial class SuratPeminjamanForm
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
            this.labelSurat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdSurat = new System.Windows.Forms.Label();
            this.lblNamaPetugas = new System.Windows.Forms.Label();
            this.lblNamaPeminjam = new System.Windows.Forms.Label();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.lblStatusPeminjaman = new System.Windows.Forms.Label();
            this.lblTanggalPeminjaman = new System.Windows.Forms.Label();
            this.lblTanggalPengembalianHarus = new System.Windows.Forms.Label();
            this.lblTanggalPengembalian = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIdPeminjaman = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSurat
            // 
            this.labelSurat.AutoSize = true;
            this.labelSurat.Font = new System.Drawing.Font("Girlie", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurat.Location = new System.Drawing.Point(363, 25);
            this.labelSurat.Name = "labelSurat";
            this.labelSurat.Size = new System.Drawing.Size(526, 114);
            this.labelSurat.TabIndex = 73;
            this.labelSurat.Text = "Surat Peminjaman";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "ID Surat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nama Petugas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Nama Peminjam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Status Peminjaman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 79;
            this.label6.Text = "Tanggal Peminjaman";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Tanggal Pengembalian Harus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 81;
            this.label8.Text = "Tanggal Pengembalian";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTanggalPengembalian, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTanggalPengembalianHarus, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblTanggalPeminjaman, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblStatusPeminjaman, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblNamaBarang, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNamaPeminjam, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNamaPetugas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIdSurat, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIdPeminjaman, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 179);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 407);
            this.tableLayoutPanel1.TabIndex = 82;
            // 
            // lblIdSurat
            // 
            this.lblIdSurat.AutoSize = true;
            this.lblIdSurat.Location = new System.Drawing.Point(285, 0);
            this.lblIdSurat.Name = "lblIdSurat";
            this.lblIdSurat.Size = new System.Drawing.Size(51, 20);
            this.lblIdSurat.TabIndex = 82;
            this.lblIdSurat.Text = "label9";
            // 
            // lblNamaPetugas
            // 
            this.lblNamaPetugas.AutoSize = true;
            this.lblNamaPetugas.Location = new System.Drawing.Point(285, 45);
            this.lblNamaPetugas.Name = "lblNamaPetugas";
            this.lblNamaPetugas.Size = new System.Drawing.Size(60, 20);
            this.lblNamaPetugas.TabIndex = 83;
            this.lblNamaPetugas.Text = "label10";
            // 
            // lblNamaPeminjam
            // 
            this.lblNamaPeminjam.AutoSize = true;
            this.lblNamaPeminjam.Location = new System.Drawing.Point(285, 90);
            this.lblNamaPeminjam.Name = "lblNamaPeminjam";
            this.lblNamaPeminjam.Size = new System.Drawing.Size(60, 20);
            this.lblNamaPeminjam.TabIndex = 84;
            this.lblNamaPeminjam.Text = "label11";
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Location = new System.Drawing.Point(285, 135);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(60, 20);
            this.lblNamaBarang.TabIndex = 85;
            this.lblNamaBarang.Text = "label12";
            // 
            // lblStatusPeminjaman
            // 
            this.lblStatusPeminjaman.AutoSize = true;
            this.lblStatusPeminjaman.Location = new System.Drawing.Point(285, 180);
            this.lblStatusPeminjaman.Name = "lblStatusPeminjaman";
            this.lblStatusPeminjaman.Size = new System.Drawing.Size(60, 20);
            this.lblStatusPeminjaman.TabIndex = 86;
            this.lblStatusPeminjaman.Text = "label13";
            // 
            // lblTanggalPeminjaman
            // 
            this.lblTanggalPeminjaman.AutoSize = true;
            this.lblTanggalPeminjaman.Location = new System.Drawing.Point(285, 225);
            this.lblTanggalPeminjaman.Name = "lblTanggalPeminjaman";
            this.lblTanggalPeminjaman.Size = new System.Drawing.Size(60, 20);
            this.lblTanggalPeminjaman.TabIndex = 87;
            this.lblTanggalPeminjaman.Text = "label14";
            // 
            // lblTanggalPengembalianHarus
            // 
            this.lblTanggalPengembalianHarus.AutoSize = true;
            this.lblTanggalPengembalianHarus.Location = new System.Drawing.Point(285, 270);
            this.lblTanggalPengembalianHarus.Name = "lblTanggalPengembalianHarus";
            this.lblTanggalPengembalianHarus.Size = new System.Drawing.Size(60, 20);
            this.lblTanggalPengembalianHarus.TabIndex = 88;
            this.lblTanggalPengembalianHarus.Text = "label15";
            // 
            // lblTanggalPengembalian
            // 
            this.lblTanggalPengembalian.AutoSize = true;
            this.lblTanggalPengembalian.Location = new System.Drawing.Point(285, 315);
            this.lblTanggalPengembalian.Name = "lblTanggalPengembalian";
            this.lblTanggalPengembalian.Size = new System.Drawing.Size(42, 20);
            this.lblTanggalPengembalian.TabIndex = 89;
            this.lblTanggalPengembalian.Text = "label";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 90;
            this.label9.Text = "ID Peminjaman";
            // 
            // lblIdPeminjaman
            // 
            this.lblIdPeminjaman.AutoSize = true;
            this.lblIdPeminjaman.Location = new System.Drawing.Point(285, 360);
            this.lblIdPeminjaman.Name = "lblIdPeminjaman";
            this.lblIdPeminjaman.Size = new System.Drawing.Size(42, 20);
            this.lblIdPeminjaman.TabIndex = 91;
            this.lblIdPeminjaman.Text = "label";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(311, 641);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(145, 54);
            this.btnPrint.TabIndex = 83;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // SuratPeminjamanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1278, 894);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelSurat);
            this.Name = "SuratPeminjamanForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surat Peminjaman";
            this.Load += new System.EventHandler(this.SuratPeminjamanForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSurat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTanggalPengembalian;
        private System.Windows.Forms.Label lblTanggalPengembalianHarus;
        private System.Windows.Forms.Label lblTanggalPeminjaman;
        private System.Windows.Forms.Label lblStatusPeminjaman;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label lblNamaPeminjam;
        private System.Windows.Forms.Label lblNamaPetugas;
        private System.Windows.Forms.Label lblIdSurat;
        private System.Windows.Forms.Label lblIdPeminjaman;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPrint;
    }
}