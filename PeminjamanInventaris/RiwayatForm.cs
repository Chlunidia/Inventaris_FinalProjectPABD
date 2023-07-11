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
    public partial class RiwayatForm : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User=sa;Password=Chluni2350719";
        public RiwayatForm()
        {
            InitializeComponent();
        }

        private void RiwayatForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = @"SELECT Peminjaman.id_peminjaman, Peminjam.nama_peminjam, Barang.nama_barang, Petugas.nama_petugas, Peminjaman.tanggal_peminjaman, Peminjaman.tanggal_pengembalian, Peminjaman.status_peminjaman
                                 FROM Peminjaman
                                 JOIN Peminjam ON Peminjaman.id_peminjam = Peminjam.id_peminjam
                                 JOIN Barang ON Peminjaman.id_barang = Barang.id_barang
                                 JOIN Petugas ON Peminjaman.id_petugas = Petugas.id_petugas;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewRiwayat.DataSource = ds.Tables[0];
                // Ubah nama header kolom
                dataGridViewRiwayat.Columns["id_peminjaman"].HeaderText = "ID Peminjaman";
                dataGridViewRiwayat.Columns["nama_peminjam"].HeaderText = "Nama Peminjam";
                dataGridViewRiwayat.Columns["nama_barang"].HeaderText = "Nama Barang";
                dataGridViewRiwayat.Columns["nama_petugas"].HeaderText = "Nama Petugas";
                dataGridViewRiwayat.Columns["tanggal_peminjaman"].HeaderText = "Tanggal Peminjaman";
                dataGridViewRiwayat.Columns["tanggal_pengembalian"].HeaderText = "Tanggal Pengembalian";
                dataGridViewRiwayat.Columns["status_peminjaman"].HeaderText = "Status Peminjaman";

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
