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
    public partial class BarangForm : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User=sa;Password=Chluni2350719";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public BarangForm()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            LoadKategoriData();
            dataGridView();
        }

        private void refreshForm()
        {
            txtNamaBarang.Enabled = true;
            txtIB.Enabled = true;
            txtJumlah.Enabled = true;
            btnClear.Enabled = true;
            btnSearch.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void BarangForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT * FROM dbo.Barang;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewBarang.DataSource = ds.Tables[0];
            }
        }

        private void ClearInputFields()
        {
            txtNamaBarang.Text = "";
            txtIB.Text = "";
            txtJumlah.Text = "";
            cbxKategori.SelectedIndex = -1;
        }

        private void LoadKategoriData()
        {
            try
            {
                connection.Open();

                string query = "SELECT id_kat_barang, nama_kategori FROM Kategori_Barang";
                command = new SqlCommand(query, connection);
                DataTable kat = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(kat);

                cbxKategori.DisplayMember = "nama_kategori";
                cbxKategori.ValueMember = "id_kat_barang";

                cbxKategori.DataSource = kat;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string namaBarang = txtNamaBarang.Text;
            string jumlah = txtJumlah.Text;
            
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                // Mengecek apakah kategori barang dengan nama yang sama sudah ada
                string checkQuery = "SELECT COUNT(*) FROM Barang WHERE nama_barang = @nama_barang";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@nama_barang", namaBarang);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Barang dengan nama tersebut sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Membangkitkan ID kategori barang otomatis hanya jika tidak ada kategori dengan nama yang sama
                string idBarang = GenerateUniqueID(connection, namaBarang);

                // Menyimpan data barang ke dalam tabel
                string insertQuery = "INSERT INTO Barang (id_barang, nama_barang, jumlah, id_kat_barang) VALUES (@id_barang, @nama_barang, @jumlah, @id_kat_barang)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@id_barang", idBarang);
                    insertCmd.Parameters.AddWithValue("@nama_barang", namaBarang);
                    insertCmd.Parameters.AddWithValue("@jumlah", jumlah);
                    insertCmd.Parameters.AddWithValue("@id_kat_barang", cbxKategori.SelectedValue);
                    insertCmd.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshForm();
            dataGridView();
            ClearInputFields();
        }

        private string GenerateUniqueID(SqlConnection connection, string namaBarang)
        {
            string idBarang = "";
            int count = 1;

            while (true)
            {
                idBarang = "IB" + count.ToString().PadLeft(4, '0');

                // Mengecek apakah ID kategori barang sudah digunakan sebelumnya
                string checkQuery = "SELECT COUNT(*) FROM Barang WHERE id_barang = @id_barang";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@id_barang", idBarang);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount == 0)
                    {
                        // ID unik ditemukan
                        break;
                    }
                }

                count++;
            }

            return idBarang;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBarang.SelectedCells.Count > 0)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        // Get the values from the input controls
                        string idBarang = dataGridViewBarang.SelectedCells[0].Value.ToString();
                        string namaBarang = txtNamaBarang.Text;
                        string jumlah = txtJumlah.Text;
                        string idKatBarang = cbxKategori.SelectedValue.ToString();

                        // Update the record in the table
                        string updateQuery = "UPDATE Barang SET nama_barang = @namaBarang, jumlah = @jumlah, id_kat_barang = @idKatBarang WHERE id_barang = @idBarang";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@idBarang", idBarang);
                            updateCmd.Parameters.AddWithValue("@namaBarang", namaBarang);
                            updateCmd.Parameters.AddWithValue("@jumlah", jumlah);
                            updateCmd.Parameters.AddWithValue("@idKatBarang", idKatBarang);
                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil diperbarui.");
                                refreshForm();
                            }
                            else
                            {
                                MessageBox.Show("Gagal memperbarui data.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pilih baris data yang ingin diperbarui.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    // Get the value of the ID from the input control
                    string idBarang = txtIB.Text;

                    // Create the SQL query to search for data based on the ID
                    string query = "SELECT id_barang, nama_barang, jumlah, id_kat_barang FROM Barang WHERE id_barang = @idBarang";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameter for the SQL query
                        command.Parameters.AddWithValue("@idBarang", idBarang);

                        // Execute the query and retrieve the result in a DataSet
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        // Bind the result to the DataGridView
                        dataGridViewBarang.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBarang.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(stringConnection))
                        {
                            connection.Open();

                            // Get the value of the ID from the selected cell
                            string idBarang = dataGridViewBarang.SelectedCells[0].Value.ToString();

                            // Create the SQL query to delete the record based on the ID
                            string deleteQuery = "DELETE FROM Barang WHERE id_barang = @idBarang";

                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                // Set the parameter for the SQL query
                                command.Parameters.AddWithValue("@idBarang", idBarang);

                                // Execute the query to delete the record
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Data berhasil dihapus.");
                                    refreshForm();
                                }
                                else
                                {
                                    MessageBox.Show("Gagal menghapus data.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pilih baris data yang ingin dihapus.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
