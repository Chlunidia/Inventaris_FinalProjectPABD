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
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtIDBarang = new System.Windows.Forms.TextBox();
            this.labelAKota = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelIDBarang = new System.Windows.Forms.Label();
            this.labelBarang = new System.Windows.Forms.Label();
            this.btnKBarang = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelIDB = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJumlah
            // 
            this.txtJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJumlah.Location = new System.Drawing.Point(211, 184);
            this.txtJumlah.Multiline = true;
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(318, 38);
            this.txtJumlah.TabIndex = 46;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaBarang.Location = new System.Drawing.Point(211, 140);
            this.txtNamaBarang.Multiline = true;
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(318, 38);
            this.txtNamaBarang.TabIndex = 45;
            // 
            // txtIDBarang
            // 
            this.txtIDBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDBarang.Location = new System.Drawing.Point(211, 96);
            this.txtIDBarang.Multiline = true;
            this.txtIDBarang.Name = "txtIDBarang";
            this.txtIDBarang.Size = new System.Drawing.Size(318, 38);
            this.txtIDBarang.TabIndex = 44;
            this.txtIDBarang.TextChanged += new System.EventHandler(this.txtIDBarang_TextChanged);
            // 
            // labelAKota
            // 
            this.labelAKota.AutoSize = true;
            this.labelAKota.Location = new System.Drawing.Point(32, 228);
            this.labelAKota.Name = "labelAKota";
            this.labelAKota.Size = new System.Drawing.Size(145, 20);
            this.labelAKota.TabIndex = 43;
            this.labelAKota.Text = "ID Kategori Barang";
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Location = new System.Drawing.Point(32, 184);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(60, 20);
            this.labelJumlah.TabIndex = 42;
            this.labelJumlah.Text = "Jumlah";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Location = new System.Drawing.Point(32, 140);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(107, 20);
            this.labelNamaBarang.TabIndex = 41;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // labelIDBarang
            // 
            this.labelIDBarang.AutoSize = true;
            this.labelIDBarang.Location = new System.Drawing.Point(32, 96);
            this.labelIDBarang.Name = "labelIDBarang";
            this.labelIDBarang.Size = new System.Drawing.Size(82, 20);
            this.labelIDBarang.TabIndex = 40;
            this.labelIDBarang.Text = "ID Barang";
            // 
            // labelBarang
            // 
            this.labelBarang.AutoSize = true;
            this.labelBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarang.Location = new System.Drawing.Point(304, 20);
            this.labelBarang.Name = "labelBarang";
            this.labelBarang.Size = new System.Drawing.Size(180, 55);
            this.labelBarang.TabIndex = 48;
            this.labelBarang.Text = "Barang";
            // 
            // btnKBarang
            // 
            this.btnKBarang.Location = new System.Drawing.Point(552, 228);
            this.btnKBarang.Name = "btnKBarang";
            this.btnKBarang.Size = new System.Drawing.Size(202, 38);
            this.btnKBarang.TabIndex = 49;
            this.btnKBarang.Text = "Lihat ID Kategori Barang";
            this.btnKBarang.UseVisualStyleBackColor = true;
            this.btnKBarang.Click += new System.EventHandler(this.btnKBarang_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(401, 573);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 52);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(552, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(202, 38);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(552, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 38);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(306, 520);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 38);
            this.textBox1.TabIndex = 53;
            // 
            // labelIDB
            // 
            this.labelIDB.AutoSize = true;
            this.labelIDB.Location = new System.Drawing.Point(122, 523);
            this.labelIDB.Name = "labelIDB";
            this.labelIDB.Size = new System.Drawing.Size(159, 20);
            this.labelIDB.TabIndex = 54;
            this.labelIDB.Text = "Masukkan ID Barang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(718, 206);
            this.dataGridView1.TabIndex = 55;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(275, 573);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 52);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(552, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 38);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 28);
            this.comboBox1.TabIndex = 60;
            // 
            // btnBack
            // 
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(340, 631);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 52);
            this.btnBack.TabIndex = 61;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BarangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 713);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelIDB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnKBarang);
            this.Controls.Add(this.labelBarang);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtIDBarang);
            this.Controls.Add(this.labelAKota);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelNamaBarang);
            this.Controls.Add(this.labelIDBarang);
            this.Name = "BarangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarangForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtIDBarang;
        private System.Windows.Forms.Label labelAKota;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label labelIDBarang;
        private System.Windows.Forms.Label labelBarang;
        private System.Windows.Forms.Button btnKBarang;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelIDB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBack;
    }
}