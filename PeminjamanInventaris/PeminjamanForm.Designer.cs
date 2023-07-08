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
            this.txtNamaPeminjam = new System.Windows.Forms.TextBox();
            this.labelNamaPeminjam = new System.Windows.Forms.Label();
            this.labelPeminjaman = new System.Windows.Forms.Label();
            this.cbxProvinsi = new System.Windows.Forms.ComboBox();
            this.txtNoTlp = new System.Windows.Forms.TextBox();
            this.txtKodePos = new System.Windows.Forms.TextBox();
            this.txtAKota = new System.Windows.Forms.TextBox();
            this.txtAJalan = new System.Windows.Forms.TextBox();
            this.labelNoTlp = new System.Windows.Forms.Label();
            this.labelKodePos = new System.Windows.Forms.Label();
            this.labelAProvinsi = new System.Windows.Forms.Label();
            this.labelAKota = new System.Windows.Forms.Label();
            this.labelAJalan = new System.Windows.Forms.Label();
            this.txtOrganisasi = new System.Windows.Forms.TextBox();
            this.labelOrganisasi = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtIDBarang = new System.Windows.Forms.TextBox();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelIDBarang = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewPeminjaman = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelIDP = new System.Windows.Forms.Label();
            this.txtNmP = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelTglPeminjaman = new System.Windows.Forms.Label();
            this.datePeminjaman = new System.Windows.Forms.DateTimePicker();
            this.datePengembalian = new System.Windows.Forms.DateTimePicker();
            this.labelTglPengembalian = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxBarang = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjaman)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNamaPeminjam
            // 
            this.txtNamaPeminjam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaPeminjam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPeminjam.Location = new System.Drawing.Point(227, 3);
            this.txtNamaPeminjam.Multiline = true;
            this.txtNamaPeminjam.Name = "txtNamaPeminjam";
            this.txtNamaPeminjam.Size = new System.Drawing.Size(318, 38);
            this.txtNamaPeminjam.TabIndex = 55;
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
            // cbxProvinsi
            // 
            this.cbxProvinsi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProvinsi.FormattingEnabled = true;
            this.cbxProvinsi.Items.AddRange(new object[] {
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
            this.cbxProvinsi.Location = new System.Drawing.Point(227, 135);
            this.cbxProvinsi.Name = "cbxProvinsi";
            this.cbxProvinsi.Size = new System.Drawing.Size(318, 30);
            this.cbxProvinsi.TabIndex = 73;
            // 
            // txtNoTlp
            // 
            this.txtNoTlp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoTlp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTlp.Location = new System.Drawing.Point(227, 223);
            this.txtNoTlp.Multiline = true;
            this.txtNoTlp.Name = "txtNoTlp";
            this.txtNoTlp.Size = new System.Drawing.Size(318, 38);
            this.txtNoTlp.TabIndex = 72;
            // 
            // txtKodePos
            // 
            this.txtKodePos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodePos.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodePos.Location = new System.Drawing.Point(227, 179);
            this.txtKodePos.Multiline = true;
            this.txtKodePos.Name = "txtKodePos";
            this.txtKodePos.Size = new System.Drawing.Size(318, 38);
            this.txtKodePos.TabIndex = 71;
            // 
            // txtAKota
            // 
            this.txtAKota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAKota.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAKota.Location = new System.Drawing.Point(227, 91);
            this.txtAKota.Multiline = true;
            this.txtAKota.Name = "txtAKota";
            this.txtAKota.Size = new System.Drawing.Size(318, 38);
            this.txtAKota.TabIndex = 70;
            // 
            // txtAJalan
            // 
            this.txtAJalan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAJalan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAJalan.Location = new System.Drawing.Point(227, 47);
            this.txtAJalan.Multiline = true;
            this.txtAJalan.Name = "txtAJalan";
            this.txtAJalan.Size = new System.Drawing.Size(318, 38);
            this.txtAJalan.TabIndex = 69;
            // 
            // labelNoTlp
            // 
            this.labelNoTlp.AutoSize = true;
            this.labelNoTlp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoTlp.Location = new System.Drawing.Point(3, 220);
            this.labelNoTlp.Name = "labelNoTlp";
            this.labelNoTlp.Size = new System.Drawing.Size(108, 22);
            this.labelNoTlp.TabIndex = 68;
            this.labelNoTlp.Text = "No. Telepon";
            // 
            // labelKodePos
            // 
            this.labelKodePos.AutoSize = true;
            this.labelKodePos.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodePos.Location = new System.Drawing.Point(3, 176);
            this.labelKodePos.Name = "labelKodePos";
            this.labelKodePos.Size = new System.Drawing.Size(87, 22);
            this.labelKodePos.TabIndex = 67;
            this.labelKodePos.Text = "Kode Pos";
            // 
            // labelAProvinsi
            // 
            this.labelAProvinsi.AutoSize = true;
            this.labelAProvinsi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAProvinsi.Location = new System.Drawing.Point(3, 132);
            this.labelAProvinsi.Name = "labelAProvinsi";
            this.labelAProvinsi.Size = new System.Drawing.Size(139, 22);
            this.labelAProvinsi.TabIndex = 66;
            this.labelAProvinsi.Text = "Alamat Provinsi";
            // 
            // labelAKota
            // 
            this.labelAKota.AutoSize = true;
            this.labelAKota.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAKota.Location = new System.Drawing.Point(3, 88);
            this.labelAKota.Name = "labelAKota";
            this.labelAKota.Size = new System.Drawing.Size(110, 22);
            this.labelAKota.TabIndex = 65;
            this.labelAKota.Text = "Alamat Kota";
            // 
            // labelAJalan
            // 
            this.labelAJalan.AutoSize = true;
            this.labelAJalan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAJalan.Location = new System.Drawing.Point(3, 44);
            this.labelAJalan.Name = "labelAJalan";
            this.labelAJalan.Size = new System.Drawing.Size(113, 22);
            this.labelAJalan.TabIndex = 64;
            this.labelAJalan.Text = "Alamat Jalan";
            // 
            // txtOrganisasi
            // 
            this.txtOrganisasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrganisasi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganisasi.Location = new System.Drawing.Point(227, 267);
            this.txtOrganisasi.Multiline = true;
            this.txtOrganisasi.Name = "txtOrganisasi";
            this.txtOrganisasi.Size = new System.Drawing.Size(318, 38);
            this.txtOrganisasi.TabIndex = 75;
            // 
            // labelOrganisasi
            // 
            this.labelOrganisasi.AutoSize = true;
            this.labelOrganisasi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrganisasi.Location = new System.Drawing.Point(3, 264);
            this.labelOrganisasi.Name = "labelOrganisasi";
            this.labelOrganisasi.Size = new System.Drawing.Size(136, 22);
            this.labelOrganisasi.TabIndex = 74;
            this.labelOrganisasi.Text = "Organisasi Asal";
            // 
            // txtJumlah
            // 
            this.txtJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJumlah.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.Location = new System.Drawing.Point(227, 355);
            this.txtJumlah.Multiline = true;
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(318, 38);
            this.txtJumlah.TabIndex = 84;
            // 
            // txtIDBarang
            // 
            this.txtIDBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDBarang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBarang.Location = new System.Drawing.Point(227, 399);
            this.txtIDBarang.Multiline = true;
            this.txtIDBarang.Name = "txtIDBarang";
            this.txtIDBarang.Size = new System.Drawing.Size(318, 38);
            this.txtIDBarang.TabIndex = 82;
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(3, 352);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(65, 22);
            this.labelJumlah.TabIndex = 81;
            this.labelJumlah.Text = "Jumlah";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.Location = new System.Drawing.Point(3, 308);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(117, 22);
            this.labelNamaBarang.TabIndex = 80;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // labelIDBarang
            // 
            this.labelIDBarang.AutoSize = true;
            this.labelIDBarang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDBarang.Location = new System.Drawing.Point(3, 396);
            this.labelIDBarang.Name = "labelIDBarang";
            this.labelIDBarang.Size = new System.Drawing.Size(91, 22);
            this.labelIDBarang.TabIndex = 79;
            this.labelIDBarang.Text = "ID Barang";
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
            this.dataGridViewPeminjaman.Location = new System.Drawing.Point(600, 148);
            this.dataGridViewPeminjaman.Name = "dataGridViewPeminjaman";
            this.dataGridViewPeminjaman.RowHeadersWidth = 62;
            this.dataGridViewPeminjaman.RowTemplate.Height = 28;
            this.dataGridViewPeminjaman.Size = new System.Drawing.Size(658, 469);
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
            // labelIDP
            // 
            this.labelIDP.AutoSize = true;
            this.labelIDP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDP.Location = new System.Drawing.Point(641, 640);
            this.labelIDP.Name = "labelIDP";
            this.labelIDP.Size = new System.Drawing.Size(223, 22);
            this.labelIDP.TabIndex = 89;
            this.labelIDP.Text = "Masukkan Nama Peminjam";
            // 
            // txtNmP
            // 
            this.txtNmP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmP.Location = new System.Drawing.Point(898, 637);
            this.txtNmP.Multiline = true;
            this.txtNmP.Name = "txtNmP";
            this.txtNmP.Size = new System.Drawing.Size(318, 38);
            this.txtNmP.TabIndex = 88;
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
            this.labelTglPeminjaman.Location = new System.Drawing.Point(3, 440);
            this.labelTglPeminjaman.Name = "labelTglPeminjaman";
            this.labelTglPeminjaman.Size = new System.Drawing.Size(173, 22);
            this.labelTglPeminjaman.TabIndex = 94;
            this.labelTglPeminjaman.Text = "Tanggal Peminjaman";
            // 
            // datePeminjaman
            // 
            this.datePeminjaman.Location = new System.Drawing.Point(227, 443);
            this.datePeminjaman.Name = "datePeminjaman";
            this.datePeminjaman.Size = new System.Drawing.Size(318, 26);
            this.datePeminjaman.TabIndex = 95;
            // 
            // datePengembalian
            // 
            this.datePengembalian.Location = new System.Drawing.Point(227, 487);
            this.datePengembalian.Name = "datePengembalian";
            this.datePengembalian.Size = new System.Drawing.Size(318, 26);
            this.datePengembalian.TabIndex = 97;
            // 
            // labelTglPengembalian
            // 
            this.labelTglPengembalian.AutoSize = true;
            this.labelTglPengembalian.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglPengembalian.Location = new System.Drawing.Point(3, 484);
            this.labelTglPengembalian.Name = "labelTglPengembalian";
            this.labelTglPengembalian.Size = new System.Drawing.Size(187, 22);
            this.labelTglPengembalian.TabIndex = 96;
            this.labelTglPengembalian.Text = "Tanggal Pengembalian";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.11407F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.88593F));
            this.tableLayoutPanel1.Controls.Add(this.cbxBarang, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelNamaPeminjam, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTglPeminjaman, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelTglPengembalian, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.datePengembalian, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.datePeminjaman, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtIDBarang, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelIDBarang, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelJumlah, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelNamaBarang, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtJumlah, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtOrganisasi, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtNoTlp, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelOrganisasi, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtKodePos, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelAJalan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxProvinsi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNamaPeminjam, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNoTlp, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtAJalan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelKodePos, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAKota, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAKota, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAProvinsi, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 534);
            this.tableLayoutPanel1.TabIndex = 98;
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
            this.cbxBarang.Location = new System.Drawing.Point(227, 311);
            this.cbxBarang.Name = "cbxBarang";
            this.cbxBarang.Size = new System.Drawing.Size(318, 30);
            this.cbxBarang.TabIndex = 98;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.labelIDP);
            this.panel1.Controls.Add(this.txtNmP);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.dataGridViewPeminjaman);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labelPeminjaman);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 880);
            this.panel1.TabIndex = 99;
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
        private System.Windows.Forms.TextBox txtNamaPeminjam;
        private System.Windows.Forms.Label labelNamaPeminjam;
        private System.Windows.Forms.Label labelPeminjaman;
        private System.Windows.Forms.ComboBox cbxProvinsi;
        private System.Windows.Forms.TextBox txtNoTlp;
        private System.Windows.Forms.TextBox txtKodePos;
        private System.Windows.Forms.TextBox txtAKota;
        private System.Windows.Forms.TextBox txtAJalan;
        private System.Windows.Forms.Label labelNoTlp;
        private System.Windows.Forms.Label labelKodePos;
        private System.Windows.Forms.Label labelAProvinsi;
        private System.Windows.Forms.Label labelAKota;
        private System.Windows.Forms.Label labelAJalan;
        private System.Windows.Forms.TextBox txtOrganisasi;
        private System.Windows.Forms.Label labelOrganisasi;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtIDBarang;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label labelIDBarang;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewPeminjaman;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelIDP;
        private System.Windows.Forms.TextBox txtNmP;
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
    }
}