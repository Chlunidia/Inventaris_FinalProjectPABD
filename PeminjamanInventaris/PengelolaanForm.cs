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
                string query = "SELECT * FROM dbo.Pengelolaan;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewPengelolaan.DataSource = ds.Tables[0];
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
    }
}
