namespace PeminjamanInventaris
{
    partial class RiwayatForm
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
            this.dataGridViewRiwayat = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRiwayat
            // 
            this.dataGridViewRiwayat.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiwayat.Location = new System.Drawing.Point(28, 110);
            this.dataGridViewRiwayat.Name = "dataGridViewRiwayat";
            this.dataGridViewRiwayat.RowHeadersWidth = 62;
            this.dataGridViewRiwayat.RowTemplate.Height = 28;
            this.dataGridViewRiwayat.Size = new System.Drawing.Size(1208, 534);
            this.dataGridViewRiwayat.TabIndex = 0;
            this.dataGridViewRiwayat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 817);
            this.panel1.TabIndex = 100;
            // 
            // RiwayatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1278, 844);
            this.Controls.Add(this.dataGridViewRiwayat);
            this.Controls.Add(this.panel1);
            this.Name = "RiwayatForm";
            this.Text = "RiwayatForm";
            this.Load += new System.EventHandler(this.RiwayatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRiwayat;
        private System.Windows.Forms.Panel panel1;
    }
}