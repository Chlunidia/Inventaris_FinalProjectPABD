using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeminjamanInventaris
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;User ID=sa;Password=Chluni2350719";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string serverName = "CHLUNIDIA";
            string username = txtUserID.Text;
            string password = txtPassword.Text;

            string connectionString = $"Data Source={serverName};User ID={username};Password={password}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Database connection successful!");
                    MainMenuForm mainMenu = new MainMenuForm();
                    mainMenu.Show(); 
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    string errorMessage = "Error connecting to the database:\n";
                    foreach (SqlError error in ex.Errors)
                    {
                        errorMessage += "Message: " + error.Message + "\n";
                        if
                        (error.Number == 18456)
                        {
                            errorMessage += "Invalid username or password" ;
                        }
                    }
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
