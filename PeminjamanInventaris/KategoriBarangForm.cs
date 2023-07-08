using System;
using System.Collections;
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
    public partial class KategoriBarangForm : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User=sa;Password=Chluni2350719";
        private SqlConnection connection;
        public KategoriBarangForm()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            refreshForm();
        }

        private void refreshForm()
        {
            txtNamaKatBarang.Enabled = true;
            btnClear.Enabled = true;
            btnSearch.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void dataGridView()
        {
            connection.Open();
            string str = "SELECT * FROM dbo.Kategori_Barang;";
            SqlDataAdapter da = new SqlDataAdapter(str, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewKatBarang.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataMasterForm dm = new DataMasterForm();
            dm.Show();
            this.Hide();
        }

        private void KategoriBarangForm_Load(object sender, EventArgs e)
        {
            txtNamaKatBarang.Enabled = true;
            btnClear.Enabled = true;
            btnSearch.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User ID=sa;Password=Chluni2350719";
            string namaKatBarang = txtNamaKatBarang.Text;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Membangkitkan ID kategori barang otomatis
                string idKatBarang = GenerateUniqueID(connection);

                // Menyimpan data barang ke dalam tabel
                string insertQuery = "INSERT INTO Kategori_Barang (id_kat_barang, nama_kategori) VALUES (@id_kat_barang, @nama_kategori)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.Add(new SqlParameter("@id_kat_barang", idKatBarang));
                    insertCmd.Parameters.Add(new SqlParameter("@nama_kategori", namaKatBarang));
                    insertCmd.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshForm();
            dataGridView();
            txtNamaKatBarang.Text = "";

        }

        private string GenerateUniqueID(SqlConnection connection)
        {
            string idKatBarang = "";
            string countQuery = "SELECT COUNT(*) FROM Kategori_Barang";
            using (SqlCommand countCmd = new SqlCommand(countQuery, connection))
            {
                int count = (int)countCmd.ExecuteScalar();
                idKatBarang = "IK" + (count + 1).ToString().PadLeft(4, '0');
            }

            return idKatBarang;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNamaKatBarang.Text = "";
            dataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User ID=sa;Password=Chluni2350719";
            string query = "UPDATE Kategori_Barang SET nama_kategori = @nama_kategori WHERE id_kat_barang = @id_kat_barang";
            string namaKatBarang = txtNamaKatBarang.Text;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Membangkitkan ID kategori barang otomatis
                string idKatBarang = GenerateUniqueID(connection);

               using (SqlCommand insertCmd = new SqlCommand(query, connection))
                {
                    insertCmd.Parameters.Add(new SqlParameter("@id_kat_barang", idKatBarang));
                    insertCmd.Parameters.Add(new SqlParameter("@nama_kategori", namaKatBarang));
                    insertCmd.ExecuteNonQuery();
                }

                connection.Close();
            }
            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User ID=sa;Password=Chluni2350719";
            string query = "SELECT * FROM Kategori_Barang WHERE id_kat_barang = @id_kat_barang";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_kat_barang", txtIDKat.Text);

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewKatBarang.DataSource = dataTable;
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
            string query = "DELETE FROM Kategori_Barang WHERE id_kat_barang = @id_kat_barang";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_kat_barang", txtIDKat.Text);

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
            txtIDKat.Text = "";
            dataGridView();
        }
    }
}
