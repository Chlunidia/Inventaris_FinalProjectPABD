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
            this.dataGridViewPeminjam = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjam)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPeminjam
            // 
            this.dataGridViewPeminjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeminjam.Location = new System.Drawing.Point(59, 104);
            this.dataGridViewPeminjam.Name = "dataGridViewPeminjam";
            this.dataGridViewPeminjam.RowHeadersWidth = 62;
            this.dataGridViewPeminjam.RowTemplate.Height = 28;
            this.dataGridViewPeminjam.Size = new System.Drawing.Size(1164, 451);
            this.dataGridViewPeminjam.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 817);
            this.panel1.TabIndex = 100;
            // 
            // PeminjamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1278, 844);
            this.Controls.Add(this.dataGridViewPeminjam);
            this.Controls.Add(this.panel1);
            this.Name = "PeminjamForm";
            this.Text = "PeminjamForm";
            this.Load += new System.EventHandler(this.PeminjamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPeminjam;
        private System.Windows.Forms.Panel panel1;
    }
}