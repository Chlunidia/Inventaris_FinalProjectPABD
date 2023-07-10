namespace PeminjamanInventaris
{
    partial class PeminjamForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelIDB = new System.Windows.Forms.Label();
            this.txtIDPeminjam = new System.Windows.Forms.TextBox();
            this.labelPeminjam = new System.Windows.Forms.Label();
            this.dataGridViewPeminjam = new System.Windows.Forms.DataGridView();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjam)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(580, 797);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 52);
            this.btnBack.TabIndex = 77;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(874, 738);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 52);
            this.btnSearch.TabIndex = 76;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelIDB
            // 
            this.labelIDB.AutoSize = true;
            this.labelIDB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDB.Location = new System.Drawing.Point(276, 746);
            this.labelIDB.Name = "labelIDB";
            this.labelIDB.Size = new System.Drawing.Size(223, 22);
            this.labelIDB.TabIndex = 75;
            this.labelIDB.Text = "Masukkan Nama Peminjam";
            // 
            // txtIDPeminjam
            // 
            this.txtIDPeminjam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPeminjam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPeminjam.Location = new System.Drawing.Point(531, 744);
            this.txtIDPeminjam.Multiline = true;
            this.txtIDPeminjam.Name = "txtIDPeminjam";
            this.txtIDPeminjam.Size = new System.Drawing.Size(318, 38);
            this.txtIDPeminjam.TabIndex = 74;
            // 
            // labelPeminjam
            // 
            this.labelPeminjam.AutoSize = true;
            this.labelPeminjam.Font = new System.Drawing.Font("Girlie", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeminjam.Location = new System.Drawing.Point(417, 15);
            this.labelPeminjam.Name = "labelPeminjam";
            this.labelPeminjam.Size = new System.Drawing.Size(442, 114);
            this.labelPeminjam.TabIndex = 73;
            this.labelPeminjam.Text = "Data Peminjam\r\n";
            // 
            // dataGridViewPeminjam
            // 
            this.dataGridViewPeminjam.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewPeminjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeminjam.Location = new System.Drawing.Point(656, 143);
            this.dataGridViewPeminjam.Name = "dataGridViewPeminjam";
            this.dataGridViewPeminjam.RowHeadersWidth = 62;
            this.dataGridViewPeminjam.Size = new System.Drawing.Size(581, 567);
            this.dataGridViewPeminjam.TabIndex = 72;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.49287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.50713F));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(69, 197);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 379);
            this.tableLayoutPanel1.TabIndex = 79;
            // 
            // txtOrganisasi
            // 
            this.txtOrganisasi.Location = new System.Drawing.Point(212, 327);
            this.txtOrganisasi.Multiline = true;
            this.txtOrganisasi.Name = "txtOrganisasi";
            this.txtOrganisasi.Size = new System.Drawing.Size(318, 38);
            this.txtOrganisasi.TabIndex = 91;
            this.txtOrganisasi.TextChanged += new System.EventHandler(this.txtOrganisasi_TextChanged);
            // 
            // txtNoTlp
            // 
            this.txtNoTlp.Location = new System.Drawing.Point(212, 273);
            this.txtNoTlp.Multiline = true;
            this.txtNoTlp.Name = "txtNoTlp";
            this.txtNoTlp.Size = new System.Drawing.Size(318, 38);
            this.txtNoTlp.TabIndex = 90;
            // 
            // txtKodePos
            // 
            this.txtKodePos.Location = new System.Drawing.Point(212, 219);
            this.txtKodePos.Multiline = true;
            this.txtKodePos.Name = "txtKodePos";
            this.txtKodePos.Size = new System.Drawing.Size(318, 38);
            this.txtKodePos.TabIndex = 89;
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(212, 111);
            this.txtKota.Multiline = true;
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(318, 38);
            this.txtKota.TabIndex = 87;
            this.txtKota.TextChanged += new System.EventHandler(this.txtKota_TextChanged);
            // 
            // txtJalan
            // 
            this.txtJalan.Location = new System.Drawing.Point(212, 57);
            this.txtJalan.Multiline = true;
            this.txtJalan.Name = "txtJalan";
            this.txtJalan.Size = new System.Drawing.Size(318, 38);
            this.txtJalan.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Alamat Jalan";
            // 
            // txtPeminjam
            // 
            this.txtPeminjam.Location = new System.Drawing.Point(212, 3);
            this.txtPeminjam.Multiline = true;
            this.txtPeminjam.Name = "txtPeminjam";
            this.txtPeminjam.Size = new System.Drawing.Size(318, 38);
            this.txtPeminjam.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Alamat Kota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "Alamat Provinsi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 82;
            this.label5.Text = "Kode Pos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "Nomor Telepon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 324);
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
            this.cbxProvinsi.Location = new System.Drawing.Point(212, 165);
            this.cbxProvinsi.Name = "cbxProvinsi";
            this.cbxProvinsi.Size = new System.Drawing.Size(318, 28);
            this.cbxProvinsi.TabIndex = 92;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(406, 631);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 52);
            this.btnUpdate.TabIndex = 82;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(280, 631);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 52);
            this.btnClear.TabIndex = 81;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(154, 631);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 52);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1015, 738);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 52);
            this.btnDelete.TabIndex = 83;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 880);
            this.panel1.TabIndex = 101;
            // 
            // PeminjamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1278, 894);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelIDB);
            this.Controls.Add(this.txtIDPeminjam);
            this.Controls.Add(this.labelPeminjam);
            this.Controls.Add(this.dataGridViewPeminjam);
            this.Controls.Add(this.panel1);
            this.Name = "PeminjamForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Peminjam";
            this.Load += new System.EventHandler(this.PeminjamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjam)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelIDB;
        private System.Windows.Forms.TextBox txtIDPeminjam;
        private System.Windows.Forms.Label labelPeminjam;
        private System.Windows.Forms.DataGridView dataGridViewPeminjam;
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
    }
}