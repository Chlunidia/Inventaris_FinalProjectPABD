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
    public partial class PeminjamForm : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User=sa;Password=Chluni2350719";
        private SqlConnection connection;
        public PeminjamForm()
        {
            InitializeComponent();
            dataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataMasterForm dataMasterForm = new DataMasterForm();
            dataMasterForm.Show();
            this.Hide();
        }

        private void dataGridView()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT id_peminjam, nama_peminjam, no_tlp_peminjam, organisasi_asal, alamat_peminjam FROM dbo.Peminjam;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewPeminjam.DataSource = ds.Tables[0];
            }
        }

        private void txtOrganisasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
