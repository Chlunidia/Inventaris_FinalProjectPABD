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
        public PeminjamanForm()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            dataGridView();
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
