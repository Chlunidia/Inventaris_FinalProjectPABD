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
    public partial class PeminjamanForm : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User=sa;Password=Chluni2350719";
        private SqlConnection connection;
        public PeminjamanForm()
        {
            InitializeComponent();
        }
        private void refreshForm()
        {
            txtNamaPeminjam.Enabled = false;
            txtAJalan.Enabled = false;
            txtAKota.Enabled = false;
            cbxProvinsi.Enabled = false;
            txtKodePos.Enabled = false;
            txtNoTlp.Enabled = false;
            txtOrganisasi.Enabled = true;
            cbxBarang.Enabled = false;
            txtJumlah.Enabled = false;
            txtIDBarang.Enabled = false;
            datePeminjaman.Enabled = false;
            datePengembalian.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }

        private void PeminjamanForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            connection.Open();
            string str = "SELECT Peminjaman.id_peminjaman, Peminjaman.tanggal_peminjaman, Peminjam.nama_peminjam, Barang.nama_barang, Petugas.nama_petugas\r\nFROM Peminjaman\r\nJOIN Peminjam ON Peminjaman.id_peminjam = Peminjam.id_peminjam\r\nJOIN Barang ON Peminjaman.id_barang = Barang.id_barang\r\nJOIN Petugas ON Peminjaman.id_petugas = Petugas.id_petugas;\r\n";
            SqlDataAdapter da = new SqlDataAdapter(str, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewPeminjaman.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void cbx_Barang()
        {
            connection.Open();
            string query = "SELECT nama_barang FROM inventaris";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbxBarang.Items.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User ID=sa;Password=Chluni2350719";
            string query = "SELECT * FROM Peminjaman WHERE nama_peminjam = @nama_peminjam";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_peminjam", txtNmP.Text);

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewPeminjaman.DataSource = dataTable;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User ID=sa;Password=Chluni2350719";
            string query = "DELETE FROM Peminjaman WHERE nama_peminjam = @nama_peminjam";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_peminjam", txtNmP.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully deleted.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
