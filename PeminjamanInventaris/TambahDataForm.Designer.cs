namespace PeminjamanInventaris
{
    partial class TambahDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahDataForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTambahData = new System.Windows.Forms.ToolStripDropDownButton();
            this.petugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTambahData});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTambahData
            // 
            this.toolStripTambahData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripTambahData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.petugasToolStripMenuItem,
            this.kategoriBarangToolStripMenuItem,
            this.barangToolStripMenuItem});
            this.toolStripTambahData.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTambahData.Image")));
            this.toolStripTambahData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTambahData.Name = "toolStripTambahData";
            this.toolStripTambahData.Size = new System.Drawing.Size(304, 29);
            this.toolStripTambahData.Text = "Pilih Data yang Ingin Ditambahkan";
            // 
            // petugasToolStripMenuItem
            // 
            this.petugasToolStripMenuItem.Name = "petugasToolStripMenuItem";
            this.petugasToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.petugasToolStripMenuItem.Text = "Petugas";
            this.petugasToolStripMenuItem.Click += new System.EventHandler(this.petugasToolStripMenuItem_Click);
            // 
            // kategoriBarangToolStripMenuItem
            // 
            this.kategoriBarangToolStripMenuItem.Name = "kategoriBarangToolStripMenuItem";
            this.kategoriBarangToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.kategoriBarangToolStripMenuItem.Text = "Kategori Barang";
            this.kategoriBarangToolStripMenuItem.Click += new System.EventHandler(this.kategoriBarangToolStripMenuItem_Click);
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.barangToolStripMenuItem.Text = "Barang";
            this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(338, 369);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 52);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TambahDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TambahDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TambahDataForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripTambahData;
        private System.Windows.Forms.ToolStripMenuItem petugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
    }
}