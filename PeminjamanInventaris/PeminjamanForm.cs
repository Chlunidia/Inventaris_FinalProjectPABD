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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
