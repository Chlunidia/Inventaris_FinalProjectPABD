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
            refreshForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataMasterForm dm = new DataMasterForm();
            dm.Show();
            this.Hide();
        }

        private void txtNamaPetugas_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshForm()
        {
            txtAJalan.Enabled = true;
            txtAKota.Enabled = true;
            cbxProvinsi.Enabled = true;
            txtKodePos.Enabled = true;
            txtNoTlp.Enabled = true;
            txtJabatan.Enabled = true;
            btnClear.Enabled = true;
            btnSearch.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;
            dataGridView();
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
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    // Mengambil nilai dari kontrol input pengguna
                    string idPeminjam = GenerateUniqueID(connection);
                    string namaPetugas = txtNamaPetugas.Text;
                    string jalan = txtAJalan.Text;
                    string kota = txtAKota.Text;
                    string provinsi = cbxProvinsi.SelectedItem.ToString();
                    string kodePos = txtKodePos.Text;
                    string noTlp = txtNoTlp.Text;
                    string jabatan = txtJabatan.Text;
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    // Membuat perintah SQL untuk memasukkan data ke tabel
                    string query = "INSERT INTO dbo.Petugas (id_petugas, nama_petugas, jalan_p, kota_p, provinsi_p, kodepos, no_tlp_petugas, jabatan, username, kata_sandi) " +
                        "VALUES (@idPeminjam, @namaPetugas, @jalan, @kota, @provinsi, @kodePos, @noTlp, @jabatan, @username, @password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Mengatur parameter untuk perintah SQL
                        command.Parameters.AddWithValue("@idPeminjam", idPeminjam);
                        command.Parameters.AddWithValue("@namaPetugas", namaPetugas);
                        command.Parameters.AddWithValue("@jalan", jalan);
                        command.Parameters.AddWithValue("@kota", kota);
                        command.Parameters.AddWithValue("@provinsi", provinsi);
                        command.Parameters.AddWithValue("@kodePos", kodePos);
                        command.Parameters.AddWithValue("@noTlp", noTlp);
                        command.Parameters.AddWithValue("@jabatan", jabatan);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        // Menjalankan perintah SQL untuk memasukkan data ke tabel
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil ditambahkan ke tabel.");
                            refreshForm();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan data ke tabel.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private string GenerateUniqueID(SqlConnection connection)
        {
            string idKatBarang = "";
            string countQuery = "SELECT COUNT(*) FROM Petugas";
            using (SqlCommand countCmd = new SqlCommand(countQuery, connection))
            {
                int count = (int)countCmd.ExecuteScalar();
                idKatBarang = "PT" + (count + 1).ToString().PadLeft(4, '0');
            }

            return idKatBarang;
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
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void PetugasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
