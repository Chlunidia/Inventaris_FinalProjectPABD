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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelIDB = new System.Windows.Forms.Label();
            this.txtIDPeminjaman = new System.Windows.Forms.TextBox();
            this.labelPeminjam = new System.Windows.Forms.Label();
            this.dataGridViewPeminjaman = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOrganisasi = new System.Windows.Forms.TextBox();
            this.txtNoTlp = new System.Windows.Forms.TextBox();
            this.txtKodePos = new System.Windows.Forms.TextBox();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.txtJalan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeminjam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxProvinsi = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelBarang = new System.Windows.Forms.Label();
            this.cbxBarang = new System.Windows.Forms.ComboBox();
            this.labelPetugas = new System.Windows.Forms.Label();
            this.cbxPetugas = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.labelTglPeminjaman = new System.Windows.Forms.Label();
            this.datePeminjaman = new System.Windows.Forms.DateTimePicker();
            this.labelTglP = new System.Windows.Forms.Label();
            this.datePHarus = new System.Windows.Forms.DateTimePicker();
            this.labelTglPengembalian = new System.Windows.Forms.Label();
            this.datePengembalian = new System.Windows.Forms.DateTimePicker();
            this.btnSurat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjaman)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(597, 65);
            this.btnClose.TabIndex = 77;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(295, 65);
            this.btnSearch.TabIndex = 76;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelIDB
            // 
            this.labelIDB.AutoSize = true;
            this.labelIDB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDB.Location = new System.Drawing.Point(3, 0);
            this.labelIDB.Name = "labelIDB";
            this.labelIDB.Size = new System.Drawing.Size(215, 22);
            this.labelIDB.TabIndex = 75;
            this.labelIDB.Text = "Masukkan ID Peminjaman";
            // 
            // txtIDPeminjaman
            // 
            this.txtIDPeminjaman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPeminjaman.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPeminjaman.Location = new System.Drawing.Point(248, 3);
            this.txtIDPeminjaman.Multiline = true;
            this.txtIDPeminjaman.Name = "txtIDPeminjaman";
            this.txtIDPeminjaman.Size = new System.Drawing.Size(310, 41);
            this.txtIDPeminjaman.TabIndex = 74;
            // 
            // labelPeminjam
            // 
            this.labelPeminjam.AutoSize = true;
            this.labelPeminjam.Font = new System.Drawing.Font("Girlie", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeminjam.Location = new System.Drawing.Point(417, 34);
            this.labelPeminjam.Name = "labelPeminjam";
            this.labelPeminjam.Size = new System.Drawing.Size(442, 114);
            this.labelPeminjam.TabIndex = 73;
            this.labelPeminjam.Text = "Data Peminjam\r\n";
            // 
            // dataGridViewPeminjaman
            // 
            this.dataGridViewPeminjaman.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeminjaman.Location = new System.Drawing.Point(636, 164);
            this.dataGridViewPeminjaman.Name = "dataGridViewPeminjaman";
            this.dataGridViewPeminjaman.RowHeadersWidth = 4;
            this.dataGridViewPeminjaman.Size = new System.Drawing.Size(600, 566);
            this.dataGridViewPeminjaman.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Nama Peminjam";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.71773F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.28227F));
            this.tableLayoutPanel1.Controls.Add(this.txtOrganisasi, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtNoTlp, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtKodePos, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtKota, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtJalan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPeminjam, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbxProvinsi, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 338);
            this.tableLayoutPanel1.TabIndex = 79;
            // 
            // txtOrganisasi
            // 
            this.txtOrganisasi.Location = new System.Drawing.Point(247, 291);
            this.txtOrganisasi.Multiline = true;
            this.txtOrganisasi.Name = "txtOrganisasi";
            this.txtOrganisasi.Size = new System.Drawing.Size(310, 38);
            this.txtOrganisasi.TabIndex = 91;
            this.txtOrganisasi.TextChanged += new System.EventHandler(this.txtOrganisasi_TextChanged);
            // 
            // txtNoTlp
            // 
            this.txtNoTlp.Location = new System.Drawing.Point(247, 243);
            this.txtNoTlp.Multiline = true;
            this.txtNoTlp.Name = "txtNoTlp";
            this.txtNoTlp.Size = new System.Drawing.Size(310, 38);
            this.txtNoTlp.TabIndex = 90;
            // 
            // txtKodePos
            // 
            this.txtKodePos.Location = new System.Drawing.Point(247, 195);
            this.txtKodePos.Multiline = true;
            this.txtKodePos.Name = "txtKodePos";
            this.txtKodePos.Size = new System.Drawing.Size(310, 38);
            this.txtKodePos.TabIndex = 89;
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(247, 99);
            this.txtKota.Multiline = true;
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(310, 38);
            this.txtKota.TabIndex = 87;
            this.txtKota.TextChanged += new System.EventHandler(this.txtKota_TextChanged);
            // 
            // txtJalan
            // 
            this.txtJalan.Location = new System.Drawing.Point(247, 51);
            this.txtJalan.Multiline = true;
            this.txtJalan.Name = "txtJalan";
            this.txtJalan.Size = new System.Drawing.Size(310, 38);
            this.txtJalan.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Alamat Jalan";
            // 
            // txtPeminjam
            // 
            this.txtPeminjam.Location = new System.Drawing.Point(247, 3);
            this.txtPeminjam.Multiline = true;
            this.txtPeminjam.Name = "txtPeminjam";
            this.txtPeminjam.Size = new System.Drawing.Size(310, 38);
            this.txtPeminjam.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Alamat Kota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "Alamat Provinsi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 82;
            this.label5.Text = "Kode Pos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "Nomor Telepon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 84;
            this.label7.Text = "Organisasi Asal";
            // 
            // cbxProvinsi
            // 
            this.cbxProvinsi.FormattingEnabled = true;
            this.cbxProvinsi.Items.AddRange(new object[] {
            "Aceh",
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
            "Jakarta",
            "Jawa Barat",
            "Jawa Tengah",
            "Yogyakarta",
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
            this.cbxProvinsi.Location = new System.Drawing.Point(247, 147);
            this.cbxProvinsi.Name = "cbxProvinsi";
            this.cbxProvinsi.Size = new System.Drawing.Size(310, 28);
            this.cbxProvinsi.TabIndex = 92;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(300, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(291, 65);
            this.btnClear.TabIndex = 81;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(291, 65);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.71773F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.28227F));
            this.tableLayoutPanel2.Controls.Add(this.labelBarang, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbxBarang, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPetugas, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxPetugas, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelStatus, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbxStatus, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelTglPeminjaman, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.datePeminjaman, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelTglP, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.datePHarus, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelTglPengembalian, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.datePengembalian, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(561, 298);
            this.tableLayoutPanel2.TabIndex = 99;
            // 
            // labelBarang
            // 
            this.labelBarang.AutoSize = true;
            this.labelBarang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarang.Location = new System.Drawing.Point(3, 0);
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
            this.cbxBarang.Location = new System.Drawing.Point(248, 3);
            this.cbxBarang.Name = "cbxBarang";
            this.cbxBarang.Size = new System.Drawing.Size(310, 30);
            this.cbxBarang.TabIndex = 98;
            // 
            // labelPetugas
            // 
            this.labelPetugas.AutoSize = true;
            this.labelPetugas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetugas.Location = new System.Drawing.Point(3, 49);
            this.labelPetugas.Name = "labelPetugas";
            this.labelPetugas.Size = new System.Drawing.Size(70, 22);
            this.labelPetugas.TabIndex = 65;
            this.labelPetugas.Text = "Petugas";
            // 
            // cbxPetugas
            // 
            this.cbxPetugas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPetugas.FormattingEnabled = true;
            this.cbxPetugas.Location = new System.Drawing.Point(248, 52);
            this.cbxPetugas.Name = "cbxPetugas";
            this.cbxPetugas.Size = new System.Drawing.Size(310, 30);
            this.cbxPetugas.TabIndex = 73;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(3, 98);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(158, 22);
            this.labelStatus.TabIndex = 79;
            this.labelStatus.Text = "Status Peminjaman";
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Dipinjam",
            "Dikembalikan"});
            this.cbxStatus.Location = new System.Drawing.Point(248, 101);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(310, 30);
            this.cbxStatus.TabIndex = 99;
            // 
            // labelTglPeminjaman
            // 
            this.labelTglPeminjaman.AutoSize = true;
            this.labelTglPeminjaman.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglPeminjaman.Location = new System.Drawing.Point(3, 147);
            this.labelTglPeminjaman.Name = "labelTglPeminjaman";
            this.labelTglPeminjaman.Size = new System.Drawing.Size(173, 22);
            this.labelTglPeminjaman.TabIndex = 94;
            this.labelTglPeminjaman.Text = "Tanggal Peminjaman";
            // 
            // datePeminjaman
            // 
            this.datePeminjaman.Location = new System.Drawing.Point(248, 150);
            this.datePeminjaman.Name = "datePeminjaman";
            this.datePeminjaman.Size = new System.Drawing.Size(310, 26);
            this.datePeminjaman.TabIndex = 95;
            // 
            // labelTglP
            // 
            this.labelTglP.AutoSize = true;
            this.labelTglP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglP.Location = new System.Drawing.Point(3, 196);
            this.labelTglP.Name = "labelTglP";
            this.labelTglP.Size = new System.Drawing.Size(239, 22);
            this.labelTglP.TabIndex = 101;
            this.labelTglP.Text = "Tanggal Pengembalian Harus";
            // 
            // datePHarus
            // 
            this.datePHarus.Location = new System.Drawing.Point(248, 199);
            this.datePHarus.Name = "datePHarus";
            this.datePHarus.Size = new System.Drawing.Size(310, 26);
            this.datePHarus.TabIndex = 99;
            // 
            // labelTglPengembalian
            // 
            this.labelTglPengembalian.AutoSize = true;
            this.labelTglPengembalian.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglPengembalian.Location = new System.Drawing.Point(3, 245);
            this.labelTglPengembalian.Name = "labelTglPengembalian";
            this.labelTglPengembalian.Size = new System.Drawing.Size(187, 22);
            this.labelTglPengembalian.TabIndex = 96;
            this.labelTglPengembalian.Text = "Tanggal Pengembalian";
            // 
            // datePengembalian
            // 
            this.datePengembalian.Location = new System.Drawing.Point(248, 248);
            this.datePengembalian.Name = "datePengembalian";
            this.datePengembalian.Size = new System.Drawing.Size(310, 26);
            this.datePengembalian.TabIndex = 97;
            // 
            // btnSurat
            // 
            this.btnSurat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSurat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurat.Location = new System.Drawing.Point(304, 3);
            this.btnSurat.Name = "btnSurat";
            this.btnSurat.Size = new System.Drawing.Size(296, 65);
            this.btnSurat.TabIndex = 101;
            this.btnSurat.Text = "Surat Peminjaman";
            this.btnSurat.UseVisualStyleBackColor = false;
            this.btnSurat.Click += new System.EventHandler(this.btnSurat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(24, 563);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 351);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masukkan Data Peminjaman";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(25, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 393);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Masukkan Data Peminjam";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(624, 722);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 100);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cari Data Peminjaman";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.8061F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.1939F));
            this.tableLayoutPanel3.Controls.Add(this.labelIDB, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtIDPeminjaman, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(561, 47);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnSearch, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSurat, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(624, 828);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(603, 71);
            this.tableLayoutPanel4.TabIndex = 105;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 905);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(594, 71);
            this.tableLayoutPanel5.TabIndex = 106;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(624, 905);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(603, 71);
            this.tableLayoutPanel6.TabIndex = 107;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel6);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 1017);
            this.panel1.TabIndex = 108;
            // 
            // PeminjamanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1278, 1044);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelPeminjam);
            this.Controls.Add(this.dataGridViewPeminjaman);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "PeminjamanForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Peminjam";
            this.Load += new System.EventHandler(this.PeminjamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjaman)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelIDB;
        private System.Windows.Forms.TextBox txtIDPeminjaman;
        private System.Windows.Forms.Label labelPeminjam;
        private System.Windows.Forms.DataGridView dataGridViewPeminjaman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPeminjam;
        private System.Windows.Forms.TextBox txtOrganisasi;
        private System.Windows.Forms.TextBox txtNoTlp;
        private System.Windows.Forms.TextBox txtKodePos;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.TextBox txtJalan;
        private System.Windows.Forms.ComboBox cbxProvinsi;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelBarang;
        private System.Windows.Forms.ComboBox cbxBarang;
        private System.Windows.Forms.Label labelPetugas;
        private System.Windows.Forms.ComboBox cbxPetugas;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label labelTglPeminjaman;
        private System.Windows.Forms.DateTimePicker datePeminjaman;
        private System.Windows.Forms.Label labelTglP;
        private System.Windows.Forms.DateTimePicker datePHarus;
        private System.Windows.Forms.Label labelTglPengembalian;
        private System.Windows.Forms.DateTimePicker datePengembalian;
        private System.Windows.Forms.Button btnSurat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel1;
    }
}