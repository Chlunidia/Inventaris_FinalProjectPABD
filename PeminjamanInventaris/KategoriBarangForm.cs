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
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
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
            dataGridView();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string namaKatBarang = txtNamaKatBarang.Text;

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                // Mengecek apakah kategori barang dengan nama yang sama sudah ada
                string checkQuery = "SELECT COUNT(*) FROM Kategori_Barang WHERE nama_kategori = @nama_kategori";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@nama_kategori", namaKatBarang);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Kategori barang dengan nama tersebut sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Membangkitkan ID kategori barang otomatis hanya jika tidak ada kategori dengan nama yang sama
                string idKatBarang = GenerateUniqueID(connection, namaKatBarang);

                // Menyimpan data barang ke dalam tabel
                string insertQuery = "INSERT INTO Kategori_Barang (id_kat_barang, nama_kategori) VALUES (@id_kat_barang, @nama_kategori)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@id_kat_barang", idKatBarang);
                    insertCmd.Parameters.AddWithValue("@nama_kategori", namaKatBarang);
                    insertCmd.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshForm();
            dataGridView();
            txtNamaKatBarang.Text = "";
        }

        private string GenerateUniqueID(SqlConnection connection, string namaKatBarang)
        {
            string idKatBarang = "";
            int count = 1;

            while (true)
            {
                idKatBarang = "IK" + count.ToString().PadLeft(4, '0');

                // Mengecek apakah ID kategori barang sudah digunakan sebelumnya
                string checkQuery = "SELECT COUNT(*) FROM Kategori_Barang WHERE id_kat_barang = @id_kat_barang";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@id_kat_barang", idKatBarang);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount == 0)
                    {
                        // ID unik ditemukan
                        break;
                    }
                }

                count++;
            }

            return idKatBarang;
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIDKat.Text = "";
            txtNamaKatBarang.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idKatBarang = txtIDKat.Text;
            string namaKatBarang = txtNamaKatBarang.Text;

            if (string.IsNullOrEmpty(idKatBarang))
            {
                MessageBox.Show("Silakan masukkan ID kategori barang yang akan diperbarui.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(namaKatBarang))
            {
                MessageBox.Show("Silakan masukkan nama kategori barang yang baru.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                // Mengecek apakah kategori barang dengan ID yang dimasukkan ada
                string checkQuery = "SELECT COUNT(*) FROM Kategori_Barang WHERE id_kat_barang = @id_kat_barang";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@id_kat_barang", idKatBarang);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Kategori barang dengan ID tersebut tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Mengecek apakah kategori barang dengan nama yang sama sudah ada, kecuali untuk kategori dengan ID yang sama
                string duplicateCheckQuery = "SELECT COUNT(*) FROM Kategori_Barang WHERE nama_kategori = @nama_kategori AND id_kat_barang != @id_kat_barang";
                using (SqlCommand duplicateCheckCmd = new SqlCommand(duplicateCheckQuery, connection))
                {
                    duplicateCheckCmd.Parameters.AddWithValue("@nama_kategori", namaKatBarang);
                    duplicateCheckCmd.Parameters.AddWithValue("@id_kat_barang", idKatBarang);
                    int duplicateCount = (int)duplicateCheckCmd.ExecuteScalar();
                    if (duplicateCount > 0)
                    {
                        MessageBox.Show("Kategori barang dengan nama tersebut sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Memperbarui data kategori barang
                string updateQuery = "UPDATE Kategori_Barang SET nama_kategori = @nama_kategori WHERE id_kat_barang = @id_kat_barang";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                {
                    updateCmd.Parameters.AddWithValue("@nama_kategori", namaKatBarang);
                    updateCmd.Parameters.AddWithValue("@id_kat_barang", idKatBarang);
                    updateCmd.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshForm();
            dataGridView();
            txtIDKat.Text = "";
            txtNamaKatBarang.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Kategori_Barang WHERE id_kat_barang = @id_kat_barang";

            using (SqlConnection conn = new SqlConnection(stringConnection))
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
            try
            {
                string idKatBarang = txtIDKat.Text;

                if (string.IsNullOrEmpty(idKatBarang))
                {
                    MessageBox.Show("Silakan masukkan ID kategori barang yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        // Mengecek apakah kategori barang dengan ID yang dimasukkan ada
                        string checkQuery = "SELECT COUNT(*) FROM Kategori_Barang WHERE id_kat_barang = @id_kat_barang";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                        {
                            checkCmd.Parameters.AddWithValue("@id_kat_barang", idKatBarang);
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count == 0)
                            {
                                MessageBox.Show("Kategori barang dengan ID tersebut tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Menghapus data kategori barang berdasarkan ID
                        string deleteQuery = "DELETE FROM Kategori_Barang WHERE id_kat_barang = @id_kat_barang";
                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@id_kat_barang", idKatBarang);
                            int rowsAffected = deleteCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refreshForm();
                                dataGridView();
                                txtIDKat.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
