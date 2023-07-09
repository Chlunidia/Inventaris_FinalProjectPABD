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
        private SqlConnection connection;
        public PeminjamForm()
        {
            InitializeComponent();
            dataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataMasterForm dataMasterForm = new DataMasterForm();
            dataMasterForm.Show();
            this.Hide();
        }

        private void dataGridView()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT id_peminjam, nama_peminjam, no_tlp_peminjam, organisasi_asal, alamat_peminjam FROM dbo.Peminjam;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewPeminjam.DataSource = ds.Tables[0];
            }
        }

        private void ClearInputFields()
        {
            txtPeminjam.Text = "";
            txtJalan.Text = "";
            txtKota.Text = "";
            cbxProvinsi.SelectedIndex = -1;
            txtKodePos.Text = "";
            txtNoTlp.Text = "";
            txtOrganisasi.Text = "";
        }
        private void txtOrganisasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string namaPeminjam = txtPeminjam.Text;
                string jalan = txtJalan.Text;
                string kota = txtKota.Text;
                string provinsi = cbxProvinsi.SelectedItem?.ToString();
                string kodePos = txtKodePos.Text;
                string noTlp = txtNoTlp.Text;
                string organisasi = txtOrganisasi.Text;

                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    // Mengecek apakah petugas dengan nama yang sama sudah ada
                    string checkQuery = "SELECT COUNT(*) FROM Peminjam WHERE nama_peminjam = @nama_peminjam";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@nama_peminjam", namaPeminjam);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Petugas dengan nama tersebut sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Membangkitkan ID petugas otomatis hanya jika tidak ada petugas dengan nama yang sama
                    string idPeminjam = GenerateUniqueID(connection);

                    // Menyimpan data petugas ke dalam tabel
                    string insertQuery = "INSERT INTO Peminjam (id_peminjam, nama_peminjam, jalan, kota, provinsi, kode_pos, no_tlp_peminjam, organisasi_asal) VALUES (@id_peminjam, @nama_peminjam, @jalan, @kota, @provinsi, @kodePos, @noTlp, @organisasi)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@id_peminjam", idPeminjam);
                        insertCmd.Parameters.AddWithValue("@nama_peminjam", namaPeminjam);
                        insertCmd.Parameters.AddWithValue("@jalan", jalan);
                        insertCmd.Parameters.AddWithValue("@kota", kota);
                        insertCmd.Parameters.AddWithValue("@provinsi", provinsi);
                        insertCmd.Parameters.AddWithValue("@kodePos", kodePos);
                        insertCmd.Parameters.AddWithValue("@noTlp", noTlp);
                        insertCmd.Parameters.AddWithValue("@organisasi", organisasi);

                        insertCmd.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateUniqueID(SqlConnection connection)
        {
            string idPeminjam = "";
            int count = 1;

            while (true)
            {
                idPeminjam = "PJ" + count.ToString().PadLeft(4, '0');

                // Mengecek apakah ID kategori barang sudah digunakan sebelumnya
                string checkQuery = "SELECT COUNT(*) FROM Peminjam WHERE id_peminjam = @id_peminjam";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@id_peminjam", idPeminjam);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount == 0)
                    {
                        // ID unik ditemukan
                        break;
                    }
                }

                count++;
            }

            return idPeminjam;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    // Mengambil nilai ID dari kontrol input pengguna
                    string idPeminjam = txtIDPeminjam.Text;

                    // Membuat perintah SQL untuk mencari data berdasarkan ID
                    string query = "SELECT id_peminjam, nama_peminjam, no_tlp_peminjam, organisasi_asal, alamat_peminjam FROM dbo.Peminjam WHERE id_peminjam = @idPeminjam";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Mengatur parameter untuk perintah SQL
                        command.Parameters.AddWithValue("@idPeminjam", idPeminjam);

                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridViewPeminjam.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPeminjam.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(stringConnection))
                        {
                            connection.Open();

                            // Mengambil nilai ID dari sel yang terpilih
                            string idPeminjam = dataGridViewPeminjam.SelectedCells[0].Value.ToString();

                            // Membuat perintah SQL untuk menghapus data berdasarkan ID
                            string query = "DELETE FROM dbo.Peminjam WHERE id_peminjam = @idPeminjam";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Mengatur parameter untuk perintah SQL
                                command.Parameters.AddWithValue("@idPeminjam", idPeminjam);

                                // Menjalankan perintah SQL untuk menghapus data
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Data berhasil dihapus.");
                                    dataGridView();
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
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void PeminjamForm_Load(object sender, EventArgs e)
        {

        }
    }
}
