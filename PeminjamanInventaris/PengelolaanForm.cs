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
                string query = "SELECT P.id_pengelolaan, PT.nama_petugas, B.nama_barang, P.keterangan, P.tanggal_pengelolaan " +
                               "FROM dbo.Pengelolaan P " +
                               "JOIN Petugas PT ON P.id_petugas = PT.id_petugas " +
                               "JOIN Barang B ON P.id_barang = B.id_barang";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewPengelolaan.DataSource = ds.Tables[0];
                dataGridViewPengelolaan.Columns["id_pengelolaan"].HeaderText = "ID Pengelolaan";
                dataGridViewPengelolaan.Columns["nama_petugas"].HeaderText = "Nama Petugas";
                dataGridViewPengelolaan.Columns["nama_barang"].HeaderText = "Nama Barang";
                dataGridViewPengelolaan.Columns["keterangan"].HeaderText = "Keterangan";
                dataGridViewPengelolaan.Columns["tanggal_pengelolaan"].HeaderText = "Tanggal Pengelolaan";
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
            ClearFormFields();
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
                string idPengelolaan = txtIDP.Text;
                string query = "SELECT * FROM Pengelolaan WHERE id_pengelolaan = @id_pengelolaan";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_pengelolaan", idPengelolaan);

                DataTable searchResults = new DataTable();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(searchResults);
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
                string idPengelolaan = txtIDP.Text;
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Pengelolaan WHERE id_pengelolaan = @id_pengelolaan";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_pengelolaan", idPengelolaan);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
