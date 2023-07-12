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
    public partial class PeminjamForm : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User=sa;Password=Chluni2350719";
        public PeminjamForm()
        {
            InitializeComponent();
            dataGridView();
        }

        private void PeminjamForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT id_peminjam, nama_peminjam, no_tlp_peminjam, organisasi_asal, alamat_peminjam FROM Peminjam;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewPeminjam.DataSource = ds.Tables[0];

                // Mengganti header kolom
                dataGridViewPeminjam.Columns["id_peminjam"].HeaderText = "ID Peminjam";
                dataGridViewPeminjam.Columns["nama_peminjam"].HeaderText = "Nama Peminjam";
                dataGridViewPeminjam.Columns["no_tlp_peminjam"].HeaderText = "Nomor Telepon";
                dataGridViewPeminjam.Columns["organisasi_asal"].HeaderText = "Organisasi Asal";
                dataGridViewPeminjam.Columns["alamat_peminjam"].HeaderText = "Alamat";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string keyword = txtNama.Text.Trim();
                    string query = @"SELECT id_peminjam, nama_peminjam, no_tlp_peminjam, organisasi_asal, alamat_peminjam
                             FROM Peminjam
                             WHERE nama_peminjam LIKE '%' + @keyword + '%';";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@keyword", keyword);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewPeminjam.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
