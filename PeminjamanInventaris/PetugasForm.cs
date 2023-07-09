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
            txtIDPetugas.Enabled = true;
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
        }

        private void dataGridView()
        {
            connection.Open();
            string str = "SELECT id_peminjam, nama_petugas, no_tlp_peminjam, jabatan, username, kata_sandi, alamat_petugas FROM dbo.Petugas;";
            SqlDataAdapter da = new SqlDataAdapter(str, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewPeminjam.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private string GenerateUniqueID(SqlConnection connection)
        {
            string idKatBarang = "";
            string countQuery = "SELECT COUNT(*) FROM Kategori_Barang";
            using (SqlCommand countCmd = new SqlCommand(countQuery, connection))
            {
                int count = (int)countCmd.ExecuteScalar();
                idKatBarang = "IK" + (count + 1).ToString().PadLeft(4, '0');
            }

            return idKatBarang;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
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
