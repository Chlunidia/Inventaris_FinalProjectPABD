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
            // PeminjamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 894);
            this.Controls.Add(this.dataGridViewPeminjam);
            this.Name = "PeminjamForm";
            this.Text = "PeminjamForm";
            this.Load += new System.EventHandler(this.PeminjamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPeminjam;
    }
}