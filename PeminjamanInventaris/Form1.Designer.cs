namespace PeminjamanInventaris
{
    partial class Form1
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelKet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Girlie", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(563, 107);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(174, 114);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // labelUserID
            // 
            this.labelUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(401, 557);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(88, 22);
            this.labelUserID.TabIndex = 1;
            this.labelUserID.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(393, 639);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(88, 22);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(397, 738);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(476, 59);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(397, 582);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(476, 39);
            this.txtUserID.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(397, 664);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(476, 39);
            this.txtPassword.TabIndex = 5;
            // 
            // labelKet
            // 
            this.labelKet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKet.AutoSize = true;
            this.labelKet.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKet.Location = new System.Drawing.Point(458, 237);
            this.labelKet.Name = "labelKet";
            this.labelKet.Size = new System.Drawing.Size(346, 22);
            this.labelKet.TabIndex = 6;
            this.labelKet.Text = "Please enter your username and password!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1278, 894);
            this.Controls.Add(this.labelKet);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelLogin);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelKet;
    }
}

