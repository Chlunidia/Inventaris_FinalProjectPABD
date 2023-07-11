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
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;

        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User=sa;Password=Chluni2350719";
        public PeminjamanForm()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            dataGridView();
            LoadPetugasData();
            LoadBarangData();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void dataGridView()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = @"SELECT Peminjaman.id_peminjaman, Peminjam.nama_peminjam, Barang.nama_barang, Petugas.nama_petugas, Peminjaman.tanggal_peminjaman, Peminjaman.tanggal_pengembalian_harus, Peminjaman.tanggal_pengembalian, Peminjaman.status_peminjaman
                                 FROM Peminjaman
                                 JOIN Peminjam ON Peminjaman.id_peminjam = Peminjam.id_peminjam
                                 JOIN Barang ON Peminjaman.id_barang = Barang.id_barang
                                 JOIN Petugas ON Peminjaman.id_petugas = Petugas.id_petugas;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewPeminjaman.DataSource = ds.Tables[0];
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
            cbxBarang.SelectedIndex = -1;
            cbxPetugas.SelectedIndex = -1;
            cbxStatus.SelectedIndex = -1;
            datePeminjaman.Value = DateTime.Now;
            datePHarus.Value = DateTime.Now;
            datePengembalian.Value = DateTime.Now;
        }

        private void PeminjamanForm_Load(object sender, EventArgs e)
        {
            cbxStatus.Items.Add("Dipinjam");
            cbxStatus.Items.Add("Dikembalikan");
            cbxStatus.Items.Add("Terlambat");
            cbxStatus.SelectedIndex = 0;
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

                cbxBarang.DisplayMember = "nama_barang";
                cbxBarang.ValueMember = "id_barang";

                cbxBarang.DataSource = barang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { connection.Close(); }
            
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

                cbxPetugas.DisplayMember = "nama_petugas";
                cbxPetugas.ValueMember = "id_petugas";

                cbxPetugas.DataSource = petugas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { connection.Close(); }

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
                string idBarang = cbxBarang.SelectedValue.ToString();
                string idPetugas = cbxPetugas.SelectedValue.ToString();
                DateTime tanggalPeminjaman = datePeminjaman.Value;
                DateTime tanggalPHarus = datePHarus.Value;
                DateTime tanggalPengembalian = datePengembalian.Value;

                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    // Membangkitkan ID petugas otomatis hanya jika tidak ada petugas dengan nama yang sama
                    string idPeminjam = GenerateUniqueIDPeminjam(connection);

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
                    string idPeminjaman = GenerateUniqueIDPeminjaman(connection, idPeminjam);

                    string query = "INSERT INTO Peminjaman (id_peminjaman, id_peminjam, id_barang, id_petugas, status_peminjaman, tanggal_peminjaman, tanggal_pengembalian_harus, tanggal_pengembalian) " +
                                   "VALUES (@id_peminjaman, @idPeminjam, @idBarang, @idPetugas, @statusPeminjaman, @tanggalPeminjaman, @tanggalPHarus, @tanggalPengembalian)";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_peminjaman", idPeminjaman);
                    command.Parameters.AddWithValue("@idPeminjam", idPeminjam);
                    command.Parameters.AddWithValue("@idBarang", idBarang);
                    command.Parameters.AddWithValue("@idPetugas", idPetugas);
                    command.Parameters.AddWithValue("@statusPeminjaman", cbxStatus.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@tanggalPeminjaman", tanggalPeminjaman);
                    command.Parameters.AddWithValue("@tanggalPHarus", tanggalPHarus);
                    command.Parameters.AddWithValue("@tanggalPengembalian", tanggalPengembalian);
                    command.ExecuteNonQuery();
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
            ClearInputFields();
        }

        private string GenerateUniqueIDPeminjam(SqlConnection connection)
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

        private string GenerateUniqueIDPeminjaman(SqlConnection connection, string nama)
        {
            string idPeminjaman = "";
            int count = 1;

            while (true)
            {
                idPeminjaman = "PM" + count.ToString().PadLeft(4, '0');

                // Mengecek apakah ID kategori barang sudah digunakan sebelumnya
                string checkQuery = "SELECT COUNT(*) FROM Peminjaman WHERE id_peminjaman = @id_peminjaman";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@id_peminjaman", idPeminjaman);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount == 0)
                    {
                        // ID unik ditemukan
                        break;
                    }
                }

                count++;
            }

            return idPeminjaman;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idPeminjaman = txtIDPeminjaman.Text.Trim();

            try
            {
                connection.Open();

                string query = @"SELECT Peminjaman.id_peminjaman, Peminjam.nama_peminjam, Barang.nama_barang, Petugas.nama_petugas, Peminjaman.tanggal_peminjaman, Peminjaman.tanggal_pengembalian_harus, Peminjaman.tanggal_pengembalian, Peminjaman.status_peminjaman
                         FROM Peminjaman
                         JOIN Peminjam ON Peminjaman.id_peminjam = Peminjam.id_peminjam
                         JOIN Barang ON Peminjaman.id_barang = Barang.id_barang
                         JOIN Petugas ON Peminjaman.id_petugas = Petugas.id_petugas
                         WHERE Peminjaman.id_peminjaman = @idPeminjaman";

                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);

                adapter = new SqlDataAdapter(command);
                DataTable peminjamanData = new DataTable();
                adapter.Fill(peminjamanData);

                if (peminjamanData.Rows.Count > 0)
                {
                    dataGridViewPeminjaman.DataSource = peminjamanData;
                }
                else
                {
                    MessageBox.Show("Data peminjaman tidak ditemukan.");
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

        private void PeminjamForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {

        }

        private void btnSurat_Click(object sender, EventArgs e)
        {
            // Get the selected row from the data grid view
            if (dataGridViewPeminjaman.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPeminjaman.SelectedRows[0];

                // Get the values from the selected row
                string idPeminjaman = selectedRow.Cells["id_peminjaman"].Value.ToString();
                string namaPetugas = selectedRow.Cells["nama_petugas"].Value.ToString();
                string namaPeminjam = selectedRow.Cells["nama_peminjam"].Value.ToString();
                string namaBarang = selectedRow.Cells["nama_barang"].Value.ToString();
                string statusPeminjaman = selectedRow.Cells["status_peminjaman"].Value.ToString();
                DateTime tanggalPeminjaman = Convert.ToDateTime(selectedRow.Cells["tanggal_peminjaman"].Value);
                DateTime tanggalPengembalianHarus = Convert.ToDateTime(selectedRow.Cells["tanggal_pengembalian_harus"].Value);
                DateTime tanggalPengembalian = Convert.ToDateTime(selectedRow.Cells["tanggal_pengembalian"].Value);

                // Generate unique ID for id_surat
                string idSurat = GenerateUniqueIDSurat();

                // Create an instance of SuratPeminjamanForm
                SuratPeminjamanForm suratPeminjaman = new SuratPeminjamanForm();

                // Set the values of the properties in SuratPeminjamanForm
                suratPeminjaman.IdSurat = idSurat;
                suratPeminjaman.IdPeminjaman = idPeminjaman; // Pass id_peminjaman as well
                suratPeminjaman.NamaPetugas = namaPetugas;
                suratPeminjaman.NamaPeminjam = namaPeminjam;
                suratPeminjaman.NamaBarang = namaBarang;
                suratPeminjaman.StatusPeminjaman = statusPeminjaman;
                suratPeminjaman.TanggalPeminjaman = tanggalPeminjaman;
                suratPeminjaman.TanggalPengembalianHarus = tanggalPengembalianHarus;
                suratPeminjaman.TanggalPengembalian = tanggalPengembalian;

                // Show the SuratPeminjamanForm
                suratPeminjaman.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to generate the surat peminjaman.");
            }
        }
        private string GenerateUniqueIDSurat()
        {
            string idSurat = "";
            int count = 1;

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                while (true)
                {
                    idSurat = "SR" + count.ToString().PadLeft(4, '0');

                    // Check if the ID is already used in the Surat_Peminjaman table
                    string checkQuery = "SELECT COUNT(*) FROM Surat_Peminjaman WHERE id_surat = @idSurat";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@idSurat", idSurat);
                        int existingCount = (int)checkCmd.ExecuteScalar();
                        if (existingCount == 0)
                        {
                            // Unique ID found
                            break;
                        }
                    }

                    count++;
                }
            }

            return idSurat;
        }
    }
}
