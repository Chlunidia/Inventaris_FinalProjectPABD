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

            // Membuat adapter dan dataset
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            // Mengisi DataTable dengan data dari adapter
            adapter.Fill(dataTable);

            // Menambahkan kolom ke DataGridView
            dataGridView1.Columns.Add("id_peminjaman", "ID Peminjaman");
            dataGridView1.Columns.Add("tanggal_peminjaman", "Tanggal Peminjaman");
            dataGridView1.Columns.Add("tanggal_pengembalian_harus", "Tanggal Pengembalian Harus");
            dataGridView1.Columns.Add("tanggal_pengembalian", "Tanggal Pengembalian");
            dataGridView1.Columns.Add("id_surat", "ID Surat");
            dataGridView1.Columns.Add("nama_peminjam", "Nama Peminjam");
            dataGridView1.Columns.Add("alamat_peminjam", "Alamat Peminjam");

            // Menampilkan data dalam DataGridView
            foreach (DataRow row in dataTable.Rows)
            {
                dataGridView1.Rows.Add(row["id_peminjaman"], row["tanggal_peminjaman"], row["tanggal_pengembalian_harus"], row["tanggal_pengembalian"], row["id_surat"], row["nama_peminjam"], row["alamat_peminjam"]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
