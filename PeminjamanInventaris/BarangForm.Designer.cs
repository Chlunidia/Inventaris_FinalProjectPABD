namespace PeminjamanInventaris
{
    partial class BarangForm
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
            this.components = new System.ComponentModel.Container();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.labelKategori = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelBarang = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNmB = new System.Windows.Forms.TextBox();
            this.labelIDB = new System.Windows.Forms.Label();
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.inventarisDataSet = new PeminjamanInventaris.inventarisDataSet();
            this.peminjamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peminjamTableAdapter = new PeminjamanInventaris.inventarisDataSetTableAdapters.PeminjamTableAdapter();
            this.txtIDKat = new System.Windows.Forms.TextBox();
            this.labelKat = new System.Windows.Forms.Label();
            this.inventarisDataSet1 = new PeminjamanInventaris.inventarisDataSet1();
            this.kategoriBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategori_BarangTableAdapter = new PeminjamanInventaris.inventarisDataSet1TableAdapters.Kategori_BarangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJumlah
            // 
            this.txtJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJumlah.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.Location = new System.Drawing.Point(279, 322);
            this.txtJumlah.Multiline = true;
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(318, 38);
            this.txtJumlah.TabIndex = 46;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaBarang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaBarang.Location = new System.Drawing.Point(279, 278);
            this.txtNamaBarang.Multiline = true;
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(318, 38);
            this.txtNamaBarang.TabIndex = 45;
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategori.Location = new System.Drawing.Point(31, 368);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(140, 22);
            this.labelKategori.TabIndex = 43;
            this.labelKategori.Text = "Kategori Barang";
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(31, 324);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(65, 22);
            this.labelJumlah.TabIndex = 42;
            this.labelJumlah.Text = "Jumlah";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.Location = new System.Drawing.Point(31, 280);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(117, 22);
            this.labelNamaBarang.TabIndex = 41;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // labelBarang
            // 
            this.labelBarang.AutoSize = true;
            this.labelBarang.Font = new System.Drawing.Font("Girlie", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarang.Location = new System.Drawing.Point(508, 19);
            this.labelBarang.Name = "labelBarang";
            this.labelBarang.Size = new System.Drawing.Size(239, 114);
            this.labelBarang.TabIndex = 48;
            this.labelBarang.Text = "Barang";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(946, 720);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 52);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(373, 472);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 51);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(111, 472);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 51);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNmB
            // 
            this.txtNmB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmB.Location = new System.Drawing.Point(902, 668);
            this.txtNmB.Multiline = true;
            this.txtNmB.Name = "txtNmB";
            this.txtNmB.Size = new System.Drawing.Size(318, 38);
            this.txtNmB.TabIndex = 53;
            // 
            // labelIDB
            // 
            this.labelIDB.AutoSize = true;
            this.labelIDB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDB.Location = new System.Drawing.Point(654, 670);
            this.labelIDB.Name = "labelIDB";
            this.labelIDB.Size = new System.Drawing.Size(201, 22);
            this.labelIDB.TabIndex = 54;
            this.labelIDB.Text = "Masukkan Nama Barang";
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(635, 148);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.RowHeadersWidth = 62;
            this.dataGridViewBarang.RowTemplate.Height = 28;
            this.dataGridViewBarang.Size = new System.Drawing.Size(605, 500);
            this.dataGridViewBarang.TabIndex = 55;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(820, 720);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 52);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(237, 472);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 51);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxKategori
            // 
            this.cbxKategori.DataSource = this.kategoriBarangBindingSource;
            this.cbxKategori.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(279, 368);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(318, 30);
            this.cbxKategori.TabIndex = 60;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(582, 802);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 52);
            this.btnBack.TabIndex = 61;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // inventarisDataSet
            // 
            this.inventarisDataSet.DataSetName = "inventarisDataSet";
            this.inventarisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peminjamBindingSource
            // 
            this.peminjamBindingSource.DataMember = "Peminjam";
            this.peminjamBindingSource.DataSource = this.inventarisDataSet;
            // 
            // peminjamTableAdapter
            // 
            this.peminjamTableAdapter.ClearBeforeFill = true;
            // 
            // txtIDKat
            // 
            this.txtIDKat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDKat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDKat.Location = new System.Drawing.Point(279, 411);
            this.txtIDKat.Multiline = true;
            this.txtIDKat.Name = "txtIDKat";
            this.txtIDKat.Size = new System.Drawing.Size(318, 38);
            this.txtIDKat.TabIndex = 63;
            // 
            // labelKat
            // 
            this.labelKat.AutoSize = true;
            this.labelKat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKat.Location = new System.Drawing.Point(31, 413);
            this.labelKat.Name = "labelKat";
            this.labelKat.Size = new System.Drawing.Size(165, 22);
            this.labelKat.TabIndex = 62;
            this.labelKat.Text = "ID Kategori Barang";
            // 
            // inventarisDataSet1
            // 
            this.inventarisDataSet1.DataSetName = "inventarisDataSet1";
            this.inventarisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoriBarangBindingSource
            // 
            this.kategoriBarangBindingSource.DataMember = "Kategori_Barang";
            this.kategoriBarangBindingSource.DataSource = this.inventarisDataSet1;
            // 
            // kategori_BarangTableAdapter
            // 
            this.kategori_BarangTableAdapter.ClearBeforeFill = true;
            // 
            // BarangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1278, 894);
            this.ControlBox = false;
            this.Controls.Add(this.txtIDKat);
            this.Controls.Add(this.labelKat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewBarang);
            this.Controls.Add(this.labelIDB);
            this.Controls.Add(this.txtNmB);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelBarang);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelNamaBarang);
            this.MaximizeBox = false;
            this.Name = "BarangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barang";
            this.Load += new System.EventHandler(this.BarangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBarangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label labelBarang;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNmB;
        private System.Windows.Forms.Label labelIDB;
        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.Button btnBack;
        private inventarisDataSet inventarisDataSet;
        private System.Windows.Forms.BindingSource peminjamBindingSource;
        private inventarisDataSetTableAdapters.PeminjamTableAdapter peminjamTableAdapter;
        private System.Windows.Forms.TextBox txtIDKat;
        private System.Windows.Forms.Label labelKat;
        private inventarisDataSet1 inventarisDataSet1;
        private System.Windows.Forms.BindingSource kategoriBarangBindingSource;
        private inventarisDataSet1TableAdapters.Kategori_BarangTableAdapter kategori_BarangTableAdapter;
    }
}