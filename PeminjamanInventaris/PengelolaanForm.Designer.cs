namespace PeminjamanInventaris
{
    partial class PengelolaanForm
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
            this.labelPengelolaan = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNamaPetugas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDPetugas = new System.Windows.Forms.TextBox();
            this.cbxNamaPetugas = new System.Windows.Forms.ComboBox();
            this.labelNamaB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDBarang = new System.Windows.Forms.TextBox();
            this.cbxNamaBarang = new System.Windows.Forms.ComboBox();
            this.labelKet = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelIDP = new System.Windows.Forms.Label();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPengelolaan
            // 
            this.labelPengelolaan.AutoSize = true;
            this.labelPengelolaan.Font = new System.Drawing.Font("Girlie", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPengelolaan.Location = new System.Drawing.Point(428, 9);
            this.labelPengelolaan.Name = "labelPengelolaan";
            this.labelPengelolaan.Size = new System.Drawing.Size(360, 114);
            this.labelPengelolaan.TabIndex = 74;
            this.labelPengelolaan.Text = "Pengelolaan";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.18538F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.81462F));
            this.tableLayoutPanel1.Controls.Add(this.labelKet, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxNamaBarang, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelNamaB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelNamaPetugas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIDPetugas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxNamaPetugas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIDBarang, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 231);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 233);
            this.tableLayoutPanel1.TabIndex = 75;
            // 
            // labelNamaPetugas
            // 
            this.labelNamaPetugas.AutoSize = true;
            this.labelNamaPetugas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaPetugas.Location = new System.Drawing.Point(3, 0);
            this.labelNamaPetugas.Name = "labelNamaPetugas";
            this.labelNamaPetugas.Size = new System.Drawing.Size(121, 22);
            this.labelNamaPetugas.TabIndex = 49;
            this.labelNamaPetugas.Text = "Nama Petugas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID Petugas";
            // 
            // txtIDPetugas
            // 
            this.txtIDPetugas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPetugas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPetugas.Location = new System.Drawing.Point(191, 49);
            this.txtIDPetugas.Multiline = true;
            this.txtIDPetugas.Name = "txtIDPetugas";
            this.txtIDPetugas.Size = new System.Drawing.Size(318, 38);
            this.txtIDPetugas.TabIndex = 58;
            // 
            // cbxNamaPetugas
            // 
            this.cbxNamaPetugas.FormattingEnabled = true;
            this.cbxNamaPetugas.Location = new System.Drawing.Point(191, 3);
            this.cbxNamaPetugas.Name = "cbxNamaPetugas";
            this.cbxNamaPetugas.Size = new System.Drawing.Size(318, 28);
            this.cbxNamaPetugas.TabIndex = 60;
            // 
            // labelNamaB
            // 
            this.labelNamaB.AutoSize = true;
            this.labelNamaB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaB.Location = new System.Drawing.Point(3, 92);
            this.labelNamaB.Name = "labelNamaB";
            this.labelNamaB.Size = new System.Drawing.Size(117, 22);
            this.labelNamaB.TabIndex = 61;
            this.labelNamaB.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "ID Barang";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDBarang
            // 
            this.txtIDBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDBarang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBarang.Location = new System.Drawing.Point(191, 141);
            this.txtIDBarang.Multiline = true;
            this.txtIDBarang.Name = "txtIDBarang";
            this.txtIDBarang.Size = new System.Drawing.Size(318, 38);
            this.txtIDBarang.TabIndex = 63;
            // 
            // cbxNamaBarang
            // 
            this.cbxNamaBarang.FormattingEnabled = true;
            this.cbxNamaBarang.Location = new System.Drawing.Point(191, 95);
            this.cbxNamaBarang.Name = "cbxNamaBarang";
            this.cbxNamaBarang.Size = new System.Drawing.Size(318, 28);
            this.cbxNamaBarang.TabIndex = 64;
            // 
            // labelKet
            // 
            this.labelKet.AutoSize = true;
            this.labelKet.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKet.Location = new System.Drawing.Point(3, 184);
            this.labelKet.Name = "labelKet";
            this.labelKet.Size = new System.Drawing.Size(99, 22);
            this.labelKet.TabIndex = 65;
            this.labelKet.Text = "Keterangan";
            this.labelKet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(191, 187);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 38);
            this.textBox1.TabIndex = 66;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(330, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 52);
            this.btnUpdate.TabIndex = 99;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(203, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 52);
            this.btnClear.TabIndex = 98;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(76, 492);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 52);
            this.btnAdd.TabIndex = 97;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(824, 729);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 52);
            this.btnSearch.TabIndex = 96;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(950, 729);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 52);
            this.btnDelete.TabIndex = 95;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(579, 803);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 52);
            this.btnBack.TabIndex = 94;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // labelIDP
            // 
            this.labelIDP.AutoSize = true;
            this.labelIDP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDP.Location = new System.Drawing.Point(652, 674);
            this.labelIDP.Name = "labelIDP";
            this.labelIDP.Size = new System.Drawing.Size(223, 22);
            this.labelIDP.TabIndex = 101;
            this.labelIDP.Text = "Masukkan Nama Peminjam";
            // 
            // txtIDP
            // 
            this.txtIDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDP.Location = new System.Drawing.Point(909, 671);
            this.txtIDP.Multiline = true;
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(318, 38);
            this.txtIDP.TabIndex = 100;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(579, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(658, 494);
            this.dataGridView1.TabIndex = 102;
            // 
            // PengelolaanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1278, 894);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelIDP);
            this.Controls.Add(this.txtIDP);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelPengelolaan);
            this.Name = "PengelolaanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengelolaan";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPengelolaan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelNamaPetugas;
        private System.Windows.Forms.Label labelKet;
        private System.Windows.Forms.ComboBox cbxNamaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNamaB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDPetugas;
        private System.Windows.Forms.ComboBox cbxNamaPetugas;
        private System.Windows.Forms.TextBox txtIDBarang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelIDP;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}