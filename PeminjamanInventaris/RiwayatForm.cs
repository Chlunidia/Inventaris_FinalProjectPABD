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
            SqlConnection connection = new SqlConnection(stringConnection);

            // Membuat query SQL
            string query = @"
                SELECT
                    PJM.id_peminjaman,
                    PJM.tanggal_peminjaman,
                    PJM.tanggal_pengembalian_harus,
                    PJM.tanggal_pengembalian,
                    SP.id_surat,
                    PM.nama_peminjam,
                    PM.alamat_peminjam
                FROM
                    Peminjaman PJM
                    INNER JOIN Surat_Peminjaman SP ON PJM.id_peminjaman = SP.id_peminjaman
                    INNER JOIN Peminjam PM ON PJM.id_peminjam = PM.id_peminjam
            ";

            // Create an adapter and dataset
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();

            // Fill the dataset with data from the adapter
            adapter.Fill(dataSet);

            // Set the dataset as the data source for the DataGridView
            dataGridViewRiwayat.DataSource = dataSet.Tables[0];

            // Change the header column names
            dataGridViewRiwayat.Columns["id_peminjaman"].HeaderText = "ID Peminjaman";
            dataGridViewRiwayat.Columns["tanggal_peminjaman"].HeaderText = "Tanggal Peminjaman";
            dataGridViewRiwayat.Columns["tanggal_pengembalian_harus"].HeaderText = "Tanggal Pengembalian Harus";
            dataGridViewRiwayat.Columns["tanggal_pengembalian"].HeaderText = "Tanggal Pengembalian";
            dataGridViewRiwayat.Columns["id_surat"].HeaderText = "ID Surat";
            dataGridViewRiwayat.Columns["nama_peminjam"].HeaderText = "Nama Peminjam";
            dataGridViewRiwayat.Columns["alamat_peminjam"].HeaderText = "Alamat Peminjam";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
