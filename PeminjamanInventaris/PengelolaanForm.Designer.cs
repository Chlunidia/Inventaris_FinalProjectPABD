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
            this.labelTgl = new System.Windows.Forms.Label();
            this.labelNamaPetugas = new System.Windows.Forms.Label();
            this.cbxNamaPetugas = new System.Windows.Forms.ComboBox();
            this.labelNamaB = new System.Windows.Forms.Label();
            this.cbxNamaBarang = new System.Windows.Forms.ComboBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.labelKet = new System.Windows.Forms.Label();
            this.datePengelolaan = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelIDP = new System.Windows.Forms.Label();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.dataGridViewPengelolaan = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengelolaan)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.labelTgl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelNamaPetugas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxNamaPetugas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNamaB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxNamaBarang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtKeterangan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelKet, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.datePengelolaan, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 231);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 197);
            this.tableLayoutPanel1.TabIndex = 75;
            // 
            // labelTgl
            // 
            this.labelTgl.AutoSize = true;
            this.labelTgl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTgl.Location = new System.Drawing.Point(3, 147);
            this.labelTgl.Name = "labelTgl";
            this.labelTgl.Size = new System.Drawing.Size(72, 22);
            this.labelTgl.TabIndex = 67;
            this.labelTgl.Text = "Tanggal";
            this.labelTgl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // cbxNamaPetugas
            // 
            this.cbxNamaPetugas.FormattingEnabled = true;
            this.cbxNamaPetugas.Location = new System.Drawing.Point(183, 3);
            this.cbxNamaPetugas.Name = "cbxNamaPetugas";
            this.cbxNamaPetugas.Size = new System.Drawing.Size(314, 28);
            this.cbxNamaPetugas.TabIndex = 60;
            // 
            // labelNamaB
            // 
            this.labelNamaB.AutoSize = true;
            this.labelNamaB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaB.Location = new System.Drawing.Point(3, 49);
            this.labelNamaB.Name = "labelNamaB";
            this.labelNamaB.Size = new System.Drawing.Size(117, 22);
            this.labelNamaB.TabIndex = 61;
            this.labelNamaB.Text = "Nama Barang";
            this.labelNamaB.Click += new System.EventHandler(this.labelNamaB_Click);
            // 
            // cbxNamaBarang
            // 
            this.cbxNamaBarang.FormattingEnabled = true;
            this.cbxNamaBarang.Location = new System.Drawing.Point(183, 52);
            this.cbxNamaBarang.Name = "cbxNamaBarang";
            this.cbxNamaBarang.Size = new System.Drawing.Size(314, 28);
            this.cbxNamaBarang.TabIndex = 64;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeterangan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeterangan.Location = new System.Drawing.Point(183, 101);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(314, 38);
            this.txtKeterangan.TabIndex = 66;
            // 
            // labelKet
            // 
            this.labelKet.AutoSize = true;
            this.labelKet.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKet.Location = new System.Drawing.Point(3, 98);
            this.labelKet.Name = "labelKet";
            this.labelKet.Size = new System.Drawing.Size(99, 22);
            this.labelKet.TabIndex = 65;
            this.labelKet.Text = "Keterangan";
            this.labelKet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datePengelolaan
            // 
            this.datePengelolaan.Location = new System.Drawing.Point(183, 150);
            this.datePengelolaan.Name = "datePengelolaan";
            this.datePengelolaan.Size = new System.Drawing.Size(314, 26);
            this.datePengelolaan.TabIndex = 68;
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
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.labelIDP.Size = new System.Drawing.Size(207, 22);
            this.labelIDP.TabIndex = 101;
            this.labelIDP.Text = "Maukkan ID Pengelolaan";
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
            // dataGridViewPengelolaan
            // 
            this.dataGridViewPengelolaan.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewPengelolaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengelolaan.Location = new System.Drawing.Point(579, 150);
            this.dataGridViewPengelolaan.Name = "dataGridViewPengelolaan";
            this.dataGridViewPengelolaan.RowHeadersWidth = 62;
            this.dataGridViewPengelolaan.RowTemplate.Height = 28;
            this.dataGridViewPengelolaan.Size = new System.Drawing.Size(658, 494);
            this.dataGridViewPengelolaan.TabIndex = 102;
            // 
            // PengelolaanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1278, 894);
            this.Controls.Add(this.dataGridViewPengelolaan);
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
            this.Load += new System.EventHandler(this.PengelolaanForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengelolaan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPengelolaan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelNamaPetugas;
        private System.Windows.Forms.Label labelKet;
        private System.Windows.Forms.ComboBox cbxNamaBarang;
        private System.Windows.Forms.Label labelNamaB;
        private System.Windows.Forms.ComboBox cbxNamaPetugas;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelIDP;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.DataGridView dataGridViewPengelolaan;
        private System.Windows.Forms.Label labelTgl;
        private System.Windows.Forms.DateTimePicker datePengelolaan;
    }
}