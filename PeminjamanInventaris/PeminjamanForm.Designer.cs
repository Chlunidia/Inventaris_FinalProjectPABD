namespace PeminjamanInventaris
{
    partial class PeminjamanForm
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
            this.labelPeminjaman = new System.Windows.Forms.Label();
            this.cbxPetugas = new System.Windows.Forms.ComboBox();
            this.labelPetugas = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewPeminjaman = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelIDPeminjaman = new System.Windows.Forms.Label();
            this.txtIDPeminjaman = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelTglPeminjaman = new System.Windows.Forms.Label();
            this.datePeminjaman = new System.Windows.Forms.DateTimePicker();
            this.datePengembalian = new System.Windows.Forms.DateTimePicker();
            this.labelTglPengembalian = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNamaPeminjam = new System.Windows.Forms.Label();
            this.labelBarang = new System.Windows.Forms.Label();
            this.cbxBarang = new System.Windows.Forms.ComboBox();
            this.cbxNamaPeminjam = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePHarus = new System.Windows.Forms.DateTimePicker();
            this.labelTglP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjaman)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPeminjaman
            // 
            this.labelPeminjaman.AutoSize = true;
            this.labelPeminjaman.Font = new System.Drawing.Font("Girlie", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeminjaman.Location = new System.Drawing.Point(485, 14);
            this.labelPeminjaman.Name = "labelPeminjaman";
            this.labelPeminjaman.Size = new System.Drawing.Size(362, 114);
            this.labelPeminjaman.TabIndex = 46;
            this.labelPeminjaman.Text = "Peminjaman";
            // 
            // cbxPetugas
            // 
            this.cbxPetugas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPetugas.FormattingEnabled = true;
            this.cbxPetugas.Location = new System.Drawing.Point(265, 85);
            this.cbxPetugas.Name = "cbxPetugas";
            this.cbxPetugas.Size = new System.Drawing.Size(318, 30);
            this.cbxPetugas.TabIndex = 73;
            // 
            // labelPetugas
            // 
            this.labelPetugas.AutoSize = true;
            this.labelPetugas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetugas.Location = new System.Drawing.Point(3, 82);
            this.labelPetugas.Name = "labelPetugas";
            this.labelPetugas.Size = new System.Drawing.Size(70, 22);
            this.labelPetugas.TabIndex = 65;
            this.labelPetugas.Text = "Petugas";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(3, 123);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(158, 22);
            this.labelStatus.TabIndex = 79;
            this.labelStatus.Text = "Status Peminjaman";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(576, 762);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 52);
            this.btnBack.TabIndex = 85;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewPeminjaman
            // 
            this.dataGridViewPeminjaman.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeminjaman.Location = new System.Drawing.Point(667, 148);
            this.dataGridViewPeminjaman.Name = "dataGridViewPeminjaman";
            this.dataGridViewPeminjaman.RowHeadersWidth = 62;
            this.dataGridViewPeminjaman.RowTemplate.Height = 28;
            this.dataGridViewPeminjaman.Size = new System.Drawing.Size(591, 469);
            this.dataGridViewPeminjaman.TabIndex = 86;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(821, 688);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 52);
            this.btnSearch.TabIndex = 90;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelIDPeminjaman
            // 
            this.labelIDPeminjaman.AutoSize = true;
            this.labelIDPeminjaman.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDPeminjaman.Location = new System.Drawing.Point(641, 640);
            this.labelIDPeminjaman.Name = "labelIDPeminjaman";
            this.labelIDPeminjaman.Size = new System.Drawing.Size(215, 22);
            this.labelIDPeminjaman.TabIndex = 89;
            this.labelIDPeminjaman.Text = "Masukkan ID Peminjaman";
            // 
            // txtIDPeminjaman
            // 
            this.txtIDPeminjaman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPeminjaman.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPeminjaman.Location = new System.Drawing.Point(898, 637);
            this.txtIDPeminjaman.Multiline = true;
            this.txtIDPeminjaman.Name = "txtIDPeminjaman";
            this.txtIDPeminjaman.Size = new System.Drawing.Size(318, 38);
            this.txtIDPeminjaman.TabIndex = 88;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(947, 688);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 52);
            this.btnDelete.TabIndex = 87;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(349, 688);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 52);
            this.btnUpdate.TabIndex = 93;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(222, 688);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 52);
            this.btnClear.TabIndex = 92;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(95, 688);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 52);
            this.btnAdd.TabIndex = 91;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelTglPeminjaman
            // 
            this.labelTglPeminjaman.AutoSize = true;
            this.labelTglPeminjaman.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglPeminjaman.Location = new System.Drawing.Point(3, 164);
            this.labelTglPeminjaman.Name = "labelTglPeminjaman";
            this.labelTglPeminjaman.Size = new System.Drawing.Size(173, 22);
            this.labelTglPeminjaman.TabIndex = 94;
            this.labelTglPeminjaman.Text = "Tanggal Peminjaman";
            // 
            // datePeminjaman
            // 
            this.datePeminjaman.Location = new System.Drawing.Point(265, 167);
            this.datePeminjaman.Name = "datePeminjaman";
            this.datePeminjaman.Size = new System.Drawing.Size(318, 26);
            this.datePeminjaman.TabIndex = 95;
            // 
            // datePengembalian
            // 
            this.datePengembalian.Location = new System.Drawing.Point(265, 249);
            this.datePengembalian.Name = "datePengembalian";
            this.datePengembalian.Size = new System.Drawing.Size(318, 26);
            this.datePengembalian.TabIndex = 97;
            // 
            // labelTglPengembalian
            // 
            this.labelTglPengembalian.AutoSize = true;
            this.labelTglPengembalian.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglPengembalian.Location = new System.Drawing.Point(3, 246);
            this.labelTglPengembalian.Name = "labelTglPengembalian";
            this.labelTglPengembalian.Size = new System.Drawing.Size(187, 22);
            this.labelTglPengembalian.TabIndex = 96;
            this.labelTglPengembalian.Text = "Tanggal Pengembalian";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.48217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.51783F));
            this.tableLayoutPanel1.Controls.Add(this.labelTglP, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.datePHarus, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelNamaPeminjam, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBarang, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPetugas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxPetugas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTglPeminjaman, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.datePeminjaman, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxNamaPeminjam, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxStatus, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxBarang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTglPengembalian, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.datePengembalian, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 163);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 291);
            this.tableLayoutPanel1.TabIndex = 98;
            // 
            // labelNamaPeminjam
            // 
            this.labelNamaPeminjam.AutoSize = true;
            this.labelNamaPeminjam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaPeminjam.Location = new System.Drawing.Point(3, 0);
            this.labelNamaPeminjam.Name = "labelNamaPeminjam";
            this.labelNamaPeminjam.Size = new System.Drawing.Size(139, 22);
            this.labelNamaPeminjam.TabIndex = 48;
            this.labelNamaPeminjam.Text = "Nama Peminjam";
            // 
            // labelBarang
            // 
            this.labelBarang.AutoSize = true;
            this.labelBarang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarang.Location = new System.Drawing.Point(3, 41);
            this.labelBarang.Name = "labelBarang";
            this.labelBarang.Size = new System.Drawing.Size(117, 22);
            this.labelBarang.TabIndex = 64;
            this.labelBarang.Text = "Nama Barang";
            // 
            // cbxBarang
            // 
            this.cbxBarang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBarang.FormattingEnabled = true;
            this.cbxBarang.Items.AddRange(new object[] {
            "Nanggroe Aceh Darussalam",
            "Sumatera Utara",
            "Sumatera Selatan",
            "Sumatera Barat",
            "Bengkulu",
            "Riau",
            "Kepulauan Riau",
            "Jambi",
            "Lampung",
            "Bangka Belitung",
            "Kalimantan Barat",
            "Kalimantan Timur",
            "Kalimantan Selatan",
            "Kalimantan Tengah",
            "Kalimantan Utara",
            "Banten",
            "DKI Jakarta",
            "Jawa Barat",
            "Jawa Tengah",
            "Daerah Istimewa Yogyakarta",
            "Jawa Timur",
            "Bali",
            "Nusa Tenggara Timur",
            "Nusa Tenggara Barat",
            "Gorontalo",
            "Sulawesi Barat",
            "Sulawesi Tengah",
            "Sulawesi Utara",
            "Sulawesi Tenggara",
            "Sulawesi Selatan",
            "Maluku Utara",
            "Maluku",
            "Papua Barat",
            "Papua",
            "Papua Tengah",
            "Papua Pegunungan",
            "Papua Selatan",
            "Papua Barat Daya"});
            this.cbxBarang.Location = new System.Drawing.Point(265, 44);
            this.cbxBarang.Name = "cbxBarang";
            this.cbxBarang.Size = new System.Drawing.Size(318, 30);
            this.cbxBarang.TabIndex = 98;
            // 
            // cbxNamaPeminjam
            // 
            this.cbxNamaPeminjam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNamaPeminjam.FormattingEnabled = true;
            this.cbxNamaPeminjam.Items.AddRange(new object[] {
            "Nanggroe Aceh Darussalam",
            "Sumatera Utara",
            "Sumatera Selatan",
            "Sumatera Barat",
            "Bengkulu",
            "Riau",
            "Kepulauan Riau",
            "Jambi",
            "Lampung",
            "Bangka Belitung",
            "Kalimantan Barat",
            "Kalimantan Timur",
            "Kalimantan Selatan",
            "Kalimantan Tengah",
            "Kalimantan Utara",
            "Banten",
            "DKI Jakarta",
            "Jawa Barat",
            "Jawa Tengah",
            "Daerah Istimewa Yogyakarta",
            "Jawa Timur",
            "Bali",
            "Nusa Tenggara Timur",
            "Nusa Tenggara Barat",
            "Gorontalo",
            "Sulawesi Barat",
            "Sulawesi Tengah",
            "Sulawesi Utara",
            "Sulawesi Tenggara",
            "Sulawesi Selatan",
            "Maluku Utara",
            "Maluku",
            "Papua Barat",
            "Papua",
            "Papua Tengah",
            "Papua Pegunungan",
            "Papua Selatan",
            "Papua Barat Daya"});
            this.cbxNamaPeminjam.Location = new System.Drawing.Point(265, 3);
            this.cbxNamaPeminjam.Name = "cbxNamaPeminjam";
            this.cbxNamaPeminjam.Size = new System.Drawing.Size(318, 30);
            this.cbxNamaPeminjam.TabIndex = 100;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Dipinjam",
            "Dikembalikan"});
            this.cbxStatus.Location = new System.Drawing.Point(265, 126);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(318, 30);
            this.cbxStatus.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.labelIDPeminjaman);
            this.panel1.Controls.Add(this.txtIDPeminjaman);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.dataGridViewPeminjaman);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labelPeminjaman);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 880);
            this.panel1.TabIndex = 99;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // datePHarus
            // 
            this.datePHarus.Location = new System.Drawing.Point(265, 208);
            this.datePHarus.Name = "datePHarus";
            this.datePHarus.Size = new System.Drawing.Size(318, 26);
            this.datePHarus.TabIndex = 99;
            // 
            // labelTglP
            // 
            this.labelTglP.AutoSize = true;
            this.labelTglP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglP.Location = new System.Drawing.Point(3, 205);
            this.labelTglP.Name = "labelTglP";
            this.labelTglP.Size = new System.Drawing.Size(239, 22);
            this.labelTglP.TabIndex = 101;
            this.labelTglP.Text = "Tanggal Pengembalian Harus";
            // 
            // PeminjamanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1278, 894);
            this.Controls.Add(this.panel1);
            this.Name = "PeminjamanForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peminjaman";
            this.Load += new System.EventHandler(this.PeminjamanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjaman)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelPeminjaman;
        private System.Windows.Forms.ComboBox cbxPetugas;
        private System.Windows.Forms.Label labelPetugas;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewPeminjaman;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelIDPeminjaman;
        private System.Windows.Forms.TextBox txtIDPeminjaman;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelTglPeminjaman;
        private System.Windows.Forms.DateTimePicker datePeminjaman;
        private System.Windows.Forms.DateTimePicker datePengembalian;
        private System.Windows.Forms.Label labelTglPengembalian;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbxBarang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNamaPeminjam;
        private System.Windows.Forms.Label labelBarang;
        private System.Windows.Forms.ComboBox cbxNamaPeminjam;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label labelTglP;
        private System.Windows.Forms.DateTimePicker datePHarus;
    }
}