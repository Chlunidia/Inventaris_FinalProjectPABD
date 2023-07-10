namespace PeminjamanInventaris
{
    partial class MainMenuForm
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
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnSurat = new System.Windows.Forms.Button();
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnPeminjam = new System.Windows.Forms.Button();
            this.btnPengelolaan = new System.Windows.Forms.Button();
            this.btnPetugas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPeminjaman.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjaman.Location = new System.Drawing.Point(384, 491);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(236, 84);
            this.btnPeminjaman.TabIndex = 1;
            this.btnPeminjaman.Text = "Peminjaman";
            this.btnPeminjaman.UseVisualStyleBackColor = false;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(655, 592);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(236, 82);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Girlie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(480, 160);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(370, 147);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome!";
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.Location = new System.Drawing.Point(571, 331);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(159, 22);
            this.labelMainMenu.TabIndex = 6;
            this.labelMainMenu.Text = "This is main menu!";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnKategori, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSurat, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnBarang, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPeminjam, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPengelolaan, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPetugas, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(896, 191);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 353);
            this.tableLayoutPanel1.TabIndex = 74;
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnKategori.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategori.Location = new System.Drawing.Point(3, 3);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(260, 48);
            this.btnKategori.TabIndex = 69;
            this.btnKategori.Text = "Data Kategori Barang";
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnSurat
            // 
            this.btnSurat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSurat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurat.Location = new System.Drawing.Point(3, 293);
            this.btnSurat.Name = "btnSurat";
            this.btnSurat.Size = new System.Drawing.Size(260, 49);
            this.btnSurat.TabIndex = 71;
            this.btnSurat.Text = "Surat Peminjaman";
            this.btnSurat.UseVisualStyleBackColor = false;
            this.btnSurat.Click += new System.EventHandler(this.btnSurat_Click);
            // 
            // btnBarang
            // 
            this.btnBarang.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBarang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarang.Location = new System.Drawing.Point(3, 61);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(260, 48);
            this.btnBarang.TabIndex = 66;
            this.btnBarang.Text = "Data Barang";
            this.btnBarang.UseVisualStyleBackColor = false;
            this.btnBarang.Click += new System.EventHandler(this.btnBarang_Click);
            // 
            // btnPeminjam
            // 
            this.btnPeminjam.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPeminjam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjam.Location = new System.Drawing.Point(3, 235);
            this.btnPeminjam.Name = "btnPeminjam";
            this.btnPeminjam.Size = new System.Drawing.Size(260, 48);
            this.btnPeminjam.TabIndex = 70;
            this.btnPeminjam.Text = "Data Peminjam";
            this.btnPeminjam.UseVisualStyleBackColor = false;
            this.btnPeminjam.Click += new System.EventHandler(this.btnPeminjam_Click);
            // 
            // btnPengelolaan
            // 
            this.btnPengelolaan.Location = new System.Drawing.Point(3, 177);
            this.btnPengelolaan.Name = "btnPengelolaan";
            this.btnPengelolaan.Size = new System.Drawing.Size(260, 48);
            this.btnPengelolaan.TabIndex = 74;
            this.btnPengelolaan.Text = "Pengelolaan Barang";
            this.btnPengelolaan.UseVisualStyleBackColor = true;
            this.btnPengelolaan.Click += new System.EventHandler(this.btnPengelolaan_Click);
            // 
            // btnPetugas
            // 
            this.btnPetugas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPetugas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetugas.Location = new System.Drawing.Point(3, 119);
            this.btnPetugas.Name = "btnPetugas";
            this.btnPetugas.Size = new System.Drawing.Size(260, 48);
            this.btnPetugas.TabIndex = 68;
            this.btnPetugas.Text = "Data Petugas";
            this.btnPetugas.UseVisualStyleBackColor = false;
            this.btnPetugas.Click += new System.EventHandler(this.btnPetugas_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1278, 894);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelMainMenu);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPeminjaman);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnPetugas;
        private System.Windows.Forms.Button btnSurat;
        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.Button btnPeminjam;
        private System.Windows.Forms.Button btnPengelolaan;
    }
}