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
            this.btnDataMaster = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelMainMenu = new System.Windows.Forms.Label();
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
            // btnDataMaster
            // 
            this.btnDataMaster.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDataMaster.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataMaster.Location = new System.Drawing.Point(384, 592);
            this.btnDataMaster.Name = "btnDataMaster";
            this.btnDataMaster.Size = new System.Drawing.Size(238, 82);
            this.btnDataMaster.TabIndex = 4;
            this.btnDataMaster.Text = "Data Master";
            this.btnDataMaster.UseVisualStyleBackColor = false;
            this.btnDataMaster.Click += new System.EventHandler(this.btnDataMaster_Click);
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
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1278, 894);
            this.ControlBox = false;
            this.Controls.Add(this.labelMainMenu);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btnDataMaster);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPeminjaman);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDataMaster;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelMainMenu;
    }
}