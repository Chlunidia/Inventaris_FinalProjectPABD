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
    public partial class PengelolaanForm : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User=sa;Password=Chluni2350719";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public PengelolaanForm()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            LoadPetugasData();
            LoadBarangData();
            dataGridView();
        }

        private void PengelolaanForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT * FROM dbo.Pengelolaan;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewPengelolaan.DataSource = ds.Tables[0];
            }
        }

        private void ClearFormFields()
        {
            cbxNamaPetugas.SelectedIndex = -1;
            cbxNamaBarang.SelectedIndex = -1;
            txtKeterangan.Text = string.Empty;
            datePengelolaan.Value = DateTime.Now;
        }


        private void LoadPetugasData()
        {
            try
            {
                connection.Open();

                string query = "SELECT id_petugas, nama_petugas FROM Petugas";
                command = new SqlCommand(query, connection);
                DataTable petugas = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(petugas);

                cbxNamaPetugas.DisplayMember = "nama_petugas";
                cbxNamaPetugas.ValueMember = "id_petugas";

                cbxNamaPetugas.DataSource = petugas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadBarangData()
        {
            try
            {
                connection.Open();

                string query = "SELECT id_barang, nama_barang FROM Barang";
                command = new SqlCommand(query, connection);
                DataTable barang = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(barang);

                cbxNamaBarang.DisplayMember = "nama_barang";
                cbxNamaBarang.ValueMember = "id_barang";

                cbxNamaBarang.DataSource = barang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void labelNamaB_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string keterangan = txtKeterangan.Text;

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                // Mengecek apakah kategori barang dengan nama yang sama sudah ada
                string checkQuery = "SELECT COUNT(*) FROM Pengelolaan WHERE keterangan = @keterangan";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@keterangan", keterangan);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Barang dengan nama tersebut sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Membangkitkan ID kategori barang otomatis hanya jika tidak ada kategori dengan nama yang sama
                string idPengelolaan = GenerateUniqueID(connection, keterangan);

                // Menyimpan data barang ke dalam tabel
                string insertQuery = "INSERT INTO Pengelolaan (id_pengelolaan, id_petugas, id_barang, keterangan, tanggal_pengelolaan) VALUES (@id_pengelolaan, @id_petugas, @id_barang, @keterangan, @tanggal_pengelolaan)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@id_pengelolaan", idPengelolaan);
                    insertCmd.Parameters.AddWithValue("@id_petugas", cbxNamaPetugas.SelectedValue);
                    insertCmd.Parameters.AddWithValue("@id_barang", cbxNamaBarang.SelectedValue);
                    insertCmd.Parameters.AddWithValue("@keterangan", keterangan);
                    insertCmd.Parameters.AddWithValue("@tanggal_pengelolaan", datePengelolaan.Value);
                    insertCmd.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
        }

        private string GenerateUniqueID(SqlConnection connection, string namaPengelolaan)
        {
            string idPengelolaan = "";
            int count = 1;

            while (true)
            {
                idPengelolaan = "IP" + count.ToString().PadLeft(4, '0');

                // Mengecek apakah ID kategori barang sudah digunakan sebelumnya
                string checkQuery = "SELECT COUNT(*) FROM Pengelolaan WHERE id_pengelolaan = @id_pengelolaan";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@id_pengelolaan", idPengelolaan);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount == 0)
                    {
                        // ID unik ditemukan
                        break;
                    }
                }

                count++;
            }

            return idPengelolaan;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Retrieve the search keyword from a TextBox or any other input control
                string idPengelolaan = txtIDP.Text;

                // Perform the search query
                string query = "SELECT * FROM Pengelolaan WHERE id_pengelolaan = @id_pengelolaan";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_pengelolaan", idPengelolaan);

                DataTable searchResults = new DataTable();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(searchResults);

                // Bind the search results to the DataGridView
                dataGridViewPengelolaan.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Retrieve the ID of the record to be deleted
                string idPengelolaan = txtIDP.Text;

                // Confirm with the user before deleting the record
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Perform the delete query
                    string query = "DELETE FROM Pengelolaan WHERE id_pengelolaan = @id_pengelolaan";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_pengelolaan", idPengelolaan);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Refresh the DataGridView after deletion
                    dataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
