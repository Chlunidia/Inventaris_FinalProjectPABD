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
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDataMaster = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjaman.Location = new System.Drawing.Point(111, 306);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(178, 68);
            this.btnPeminjaman.TabIndex = 1;
            this.btnPeminjaman.Text = "Peminjaman";
            this.btnPeminjaman.UseVisualStyleBackColor = true;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengembalian.Location = new System.Drawing.Point(306, 306);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(178, 68);
            this.btnPengembalian.TabIndex = 2;
            this.btnPengembalian.Text = "Pengembalian";
            this.btnPengembalian.UseVisualStyleBackColor = true;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(306, 391);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 66);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDataMaster
            // 
            this.btnDataMaster.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataMaster.Location = new System.Drawing.Point(111, 391);
            this.btnDataMaster.Name = "btnDataMaster";
            this.btnDataMaster.Size = new System.Drawing.Size(180, 66);
            this.btnDataMaster.TabIndex = 4;
            this.btnDataMaster.Text = "Data Master";
            this.btnDataMaster.UseVisualStyleBackColor = true;
            this.btnDataMaster.Click += new System.EventHandler(this.btnDataMaster_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Girlie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(123, 59);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(370, 147);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome!";
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.Location = new System.Drawing.Point(214, 230);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(159, 22);
            this.labelMainMenu.TabIndex = 6;
            this.labelMainMenu.Text = "This is main menu!";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(604, 516);
            this.ControlBox = false;
            this.Controls.Add(this.labelMainMenu);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btnDataMaster);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPengembalian);
            this.Controls.Add(this.btnPeminjaman);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDataMaster;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelMainMenu;
    }
}