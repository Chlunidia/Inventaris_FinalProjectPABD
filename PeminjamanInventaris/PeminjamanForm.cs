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
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public PeminjamanForm()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            dataGridView();
            LoadBarangData();
            LoadPeminjamData();
            LoadPetugasData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }

        private void PeminjamanForm_Load(object sender, EventArgs e)
        {
            cbxStatus.Items.Add("Dipinjam");
            cbxStatus.Items.Add("Dikembalikan");
            cbxStatus.Items.Add("Terlambat");
            cbxStatus.SelectedIndex = 0;
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

        private void LoadPeminjamData()
        {
            try
            {
                connection.Open();

                string query = "SELECT id_peminjam, nama_peminjam FROM Peminjam";
                command = new SqlCommand(query, connection);
                DataTable peminjam = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(peminjam);

                cbxNamaPeminjam.DisplayMember = "nama_peminjam";
                cbxNamaPeminjam.ValueMember = "id_peminjam";

                cbxNamaPeminjam.DataSource = peminjam;
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

                cbxBarang.DisplayMember = "nama_barang";
                cbxBarang.ValueMember = "id_barang";

                cbxBarang.DataSource = barang;
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
            finally
            {
                connection.Close();
            }
        }

        private void ClearFields()
        {
            cbxNamaPeminjam.SelectedIndex = -1;
            cbxBarang.SelectedIndex = -1;
            cbxPetugas.SelectedIndex = -1;
            cbxStatus.SelectedIndex = -1;
            datePeminjaman.Value = DateTime.Now;
            datePHarus.Value = DateTime.Now;
            datePengembalian.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string idPeminjam = cbxNamaPeminjam.SelectedValue.ToString();
            string idBarang = cbxBarang.SelectedValue.ToString();
            string idPetugas = cbxPetugas.SelectedValue.ToString();
            DateTime tanggalPeminjaman = datePeminjaman.Value;
            DateTime tanggalPHarus = datePHarus.Value;
            DateTime tanggalPengembalian = datePengembalian.Value;

            try
            {
                connection.Open();

                // Generate unique ID for peminjaman
                string idPeminjaman = GenerateUniqueID(connection, idPeminjam);

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

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data peminjaman berhasil ditambahkan.");

                    // Refresh data grid view
                    dataGridView();

                    // Clear input fields
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data peminjaman.");
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

        private string GenerateUniqueID(SqlConnection connection, string nama)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idPeminjaman = txtIDPeminjaman.Text.Trim();

            try
            {
                connection.Open();

                // Cek apakah ID Peminjaman yang akan diupdate ada dalam database
                string checkQuery = "SELECT COUNT(*) FROM Peminjaman WHERE id_peminjaman = @idPeminjaman";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount == 0)
                    {
                        MessageBox.Show("ID Peminjaman tidak ditemukan.");
                        return;
                    }
                }

                // Tampung nilai-nilai baru dari kontrol input
                string idPeminjam = cbxNamaPeminjam.SelectedValue.ToString();
                string idBarang = cbxBarang.SelectedValue.ToString();
                string idPetugas = cbxPetugas.SelectedValue.ToString();
                DateTime tanggalPeminjaman = datePeminjaman.Value;
                DateTime tanggalPHarus = datePHarus.Value;
                DateTime tanggalPengembalian = datePengembalian.Value;

                // Update data peminjaman
                string query = @"UPDATE Peminjaman 
                         SET id_peminjam = @idPeminjam, id_barang = @idBarang, id_petugas = @idPetugas, 
                             status_peminjaman = @statusPeminjaman, tanggal_peminjaman = @tanggalPeminjaman, 
                             tanggal_pengembalian_harus = @tanggalPHarus, tanggal_pengembalian = @tanggalPengembalian
                         WHERE id_peminjaman = @idPeminjaman";

                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);
                command.Parameters.AddWithValue("@idPeminjam", idPeminjam);
                command.Parameters.AddWithValue("@idBarang", idBarang);
                command.Parameters.AddWithValue("@idPetugas", idPetugas);
                command.Parameters.AddWithValue("@statusPeminjaman", cbxStatus.SelectedItem.ToString());
                command.Parameters.AddWithValue("@tanggalPeminjaman", tanggalPeminjaman);
                command.Parameters.AddWithValue("@tanggalPHarus", tanggalPHarus);
                command.Parameters.AddWithValue("@tanggalPengembalian", tanggalPengembalian);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data peminjaman berhasil diupdate.");

                    // Refresh data grid view
                    dataGridView();
                }
                else
                {
                    MessageBox.Show("Gagal mengupdate data peminjaman.");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string idPeminjaman = txtIDPeminjaman.Text.Trim();

            try
            {
                connection.Open();

                // Cek apakah ID Peminjaman yang akan dihapus ada dalam database
                string checkQuery = "SELECT COUNT(*) FROM Peminjaman WHERE id_peminjaman = @idPeminjaman";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount == 0)
                    {
                        MessageBox.Show("ID Peminjaman tidak ditemukan.");
                        return;
                    }
                }

                // Konfirmasi penghapusan data
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data peminjaman?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Hapus data peminjaman
                    string query = "DELETE FROM Peminjaman WHERE id_peminjaman = @idPeminjaman";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data peminjaman berhasil dihapus.");

                        // Refresh data grid view
                        dataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data peminjaman.");
                    }
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

        private void btnSurat_Click(object sender, EventArgs e)
        {
            SuratPeminjamanForm suratPeminjaman = new SuratPeminjamanForm();
            suratPeminjaman.Show();
        }
    }
}
