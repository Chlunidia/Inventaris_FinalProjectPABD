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
    public partial class BarangForm : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User=sa;Password=Chluni2350719";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public BarangForm()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            LoadKategoriData();
            dataGridView();
        }

        private void BarangForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT * FROM dbo.Barang;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewBarang.DataSource = ds.Tables[0];
            }
        }

        private void LoadKategoriData()
        {
            try
            {
                connection.Open();

                string query = "SELECT id_kat_barang, nama_kategori FROM Kategori_Barang";
                command = new SqlCommand(query, connection);
                DataTable kat = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(kat);

                cbxKategori.DisplayMember = "nama_kategori";
                cbxKategori.ValueMember = "id_kat_barang";

                cbxKategori.DataSource = kat;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
