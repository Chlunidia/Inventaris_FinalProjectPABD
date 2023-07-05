namespace PeminjamanInventaris
{
    partial class KategoriBarangForm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelBarang = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtIDBarang = new System.Windows.Forms.TextBox();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelIDKBarang = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelIDB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(230, 181);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 52);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 52);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // labelBarang
            // 
            this.labelBarang.AutoSize = true;
            this.labelBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarang.Location = new System.Drawing.Point(106, 9);
            this.labelBarang.Name = "labelBarang";
            this.labelBarang.Size = new System.Drawing.Size(372, 55);
            this.labelBarang.TabIndex = 56;
            this.labelBarang.Text = "Kategori Barang";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(219, 129);
            this.txtNamaBarang.Multiline = true;
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(318, 38);
            this.txtNamaBarang.TabIndex = 55;
            // 
            // txtIDBarang
            // 
            this.txtIDBarang.Location = new System.Drawing.Point(219, 85);
            this.txtIDBarang.Multiline = true;
            this.txtIDBarang.Name = "txtIDBarang";
            this.txtIDBarang.Size = new System.Drawing.Size(318, 38);
            this.txtIDBarang.TabIndex = 54;
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Location = new System.Drawing.Point(40, 129);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(114, 20);
            this.labelNamaBarang.TabIndex = 53;
            this.labelNamaBarang.Text = "Nama Kategori";
            // 
            // labelIDKBarang
            // 
            this.labelIDKBarang.AutoSize = true;
            this.labelIDKBarang.Location = new System.Drawing.Point(40, 85);
            this.labelIDKBarang.Name = "labelIDKBarang";
            this.labelIDKBarang.Size = new System.Drawing.Size(145, 20);
            this.labelIDKBarang.TabIndex = 52;
            this.labelIDKBarang.Text = "ID Kategori Barang";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(357, 181);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 52);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(172, 526);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 52);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(493, 206);
            this.dataGridView1.TabIndex = 64;
            // 
            // labelIDB
            // 
            this.labelIDB.AutoSize = true;
            this.labelIDB.Location = new System.Drawing.Point(40, 474);
            this.labelIDB.Name = "labelIDB";
            this.labelIDB.Size = new System.Drawing.Size(159, 20);
            this.labelIDB.TabIndex = 63;
            this.labelIDB.Text = "Masukkan ID Barang";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 471);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 38);
            this.textBox1.TabIndex = 62;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(298, 526);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 52);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(235, 584);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 52);
            this.btnBack.TabIndex = 66;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // KategoriBarangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 660);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelIDB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelBarang);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtIDBarang);
            this.Controls.Add(this.labelNamaBarang);
            this.Controls.Add(this.labelIDKBarang);
            this.Name = "KategoriBarangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KategoriBarangForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtIDBarang;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label labelIDKBarang;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelIDB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}