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
    public partial class PetugasForm : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User=sa;Password=Chluni2350719";
        private SqlConnection connection;
        public PetugasForm()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            dataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void txtNamaPetugas_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT id_petugas, nama_petugas, no_tlp_petugas, jabatan, username, kata_sandi, alamat_petugas FROM dbo.Petugas;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewPetugas.DataSource = ds.Tables[0];

                dataGridViewPetugas.Columns["id_petugas"].HeaderText = "ID";
                dataGridViewPetugas.Columns["nama_petugas"].HeaderText = "Nama";
                dataGridViewPetugas.Columns["no_tlp_petugas"].HeaderText = "No. Telepon";
                dataGridViewPetugas.Columns["jabatan"].HeaderText = "Jabatan";
                dataGridViewPetugas.Columns["username"].HeaderText = "Username";
                dataGridViewPetugas.Columns["kata_sandi"].HeaderText = "Password";
                dataGridViewPetugas.Columns["alamat_petugas"].HeaderText = "Alamat";
            }
        }

        private void ClearInputFields()
        {
            txtNamaPetugas.Text = "";
            txtAJalan.Text = "";
            txtAKota.Text = "";
            cbxProvinsi.SelectedIndex = -1;
            txtKodePos.Text = "";
            txtNoTlp.Text = "";
            txtJabatan.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string namaPetugas = txtNamaPetugas.Text;
                string jalan = txtAJalan.Text;
                string kota = txtAKota.Text;
                string provinsi = cbxProvinsi.SelectedItem?.ToString();
                string kodePos = txtKodePos.Text;
                string noTlp = txtNoTlp.Text;
                string jabatan = txtJabatan.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    // Mengecek apakah petugas dengan nama yang sama sudah ada
                    string checkQuery = "SELECT COUNT(*) FROM Petugas WHERE nama_petugas = @nama_petugas";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@nama_petugas", namaPetugas);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Petugas dengan nama tersebut sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Membangkitkan ID petugas otomatis hanya jika tidak ada petugas dengan nama yang sama
                    string idPetugas = GenerateUniqueID(connection);

                    // Menyimpan data petugas ke dalam tabel
                    string insertQuery = "INSERT INTO Petugas (id_petugas, nama_petugas, jalan_p, kota_p, provinsi_p, kodepos, no_tlp_petugas, jabatan, username, kata_sandi) VALUES (@id_petugas, @nama_petugas, @jalan, @kota, @provinsi, @kodePos, @noTlp, @jabatan, @username, @password)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@id_petugas", idPetugas);
                        insertCmd.Parameters.AddWithValue("@nama_petugas", namaPetugas);
                        insertCmd.Parameters.AddWithValue("@jalan", jalan);
                        insertCmd.Parameters.AddWithValue("@kota", kota);
                        insertCmd.Parameters.AddWithValue("@provinsi", provinsi);
                        insertCmd.Parameters.AddWithValue("@kodePos", kodePos);
                        insertCmd.Parameters.AddWithValue("@noTlp", noTlp);
                        insertCmd.Parameters.AddWithValue("@jabatan", jabatan);
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", password);
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
            string idPetugas = "";
            int count = 1;

            while (true)
            {
                idPetugas = "PT" + count.ToString().PadLeft(4, '0');

                // Mengecek apakah ID kategori barang sudah digunakan sebelumnya
                string checkQuery = "SELECT COUNT(*) FROM Petugas WHERE id_petugas = @id_petugas";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@id_petugas", idPetugas);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount == 0)
                    {
                        // ID unik ditemukan
                        break;
                    }
                }

                count++;
            }

            return idPetugas;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPetugas.SelectedCells.Count > 0)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        // Mengambil nilai dari kontrol input pengguna
                        string idPetugas = dataGridViewPetugas.SelectedCells[0].Value.ToString();
                        string namaPetugas = txtNamaPetugas.Text;
                        string jalan = txtAJalan.Text;
                        string kota = txtAKota.Text;
                        string provinsi = cbxProvinsi.SelectedItem.ToString();
                        string kodePos = txtKodePos.Text;
                        string noTlp = txtNoTlp.Text;
                        string jabatan = txtJabatan.Text;
                        string username = txtUsername.Text;
                        string password = txtPassword.Text;

                        // Membuat perintah SQL untuk memperbarui data dalam tabel
                        string query = "UPDATE dbo.Petugas SET nama_petugas = @namaPetugas, jalan_p = @jalan, kota_p = @kota, provinsi_p = @provinsi, kodepos = @kodePos, no_tlp_petugas = @noTlp, jabatan = @jabatan, username = @username, kata_sandi = @password WHERE id_petugas = @idPetugas";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Mengatur parameter untuk perintah SQL
                            command.Parameters.AddWithValue("@idPetugas", idPetugas);
                            command.Parameters.AddWithValue("@namaPetugas", namaPetugas);
                            command.Parameters.AddWithValue("@jalan", jalan);
                            command.Parameters.AddWithValue("@kota", kota);
                            command.Parameters.AddWithValue("@provinsi", provinsi);
                            command.Parameters.AddWithValue("@kodePos", kodePos);
                            command.Parameters.AddWithValue("@noTlp", noTlp);
                            command.Parameters.AddWithValue("@jabatan", jabatan);
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            // Menjalankan perintah SQL untuk memperbarui data dalam tabel
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil diperbarui.");
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
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    // Mengambil nilai ID dari kontrol input pengguna
                    string idPetugas = txtIDP.Text;

                    // Membuat perintah SQL untuk mencari data berdasarkan ID
                    string query = "SELECT id_petugas, nama_petugas, no_tlp_petugas, jabatan, username, kata_sandi, alamat_petugas FROM dbo.Petugas WHERE id_petugas = @idPetugas";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Mengatur parameter untuk perintah SQL
                        command.Parameters.AddWithValue("@idPetugas", idPetugas);

                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridViewPetugas.DataSource = ds.Tables[0];
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
                if (dataGridViewPetugas.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(stringConnection))
                        {
                            connection.Open();

                            // Mengambil nilai ID dari sel yang terpilih
                            string idPetugas = dataGridViewPetugas.SelectedCells[0].Value.ToString();

                            // Membuat perintah SQL untuk menghapus data berdasarkan ID
                            string query = "DELETE FROM dbo.Petugas WHERE id_petugas = @idPetugas";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Mengatur parameter untuk perintah SQL
                                command.Parameters.AddWithValue("@idPetugas", idPetugas);

                                // Menjalankan perintah SQL untuk menghapus data
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Data berhasil dihapus.");
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

        private void PetugasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
