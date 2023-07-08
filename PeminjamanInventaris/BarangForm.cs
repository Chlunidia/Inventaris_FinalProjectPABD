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
        public BarangForm()
        {
            InitializeComponent();
        }

        private void txtIDBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataMasterForm dataMasterForm = new DataMasterForm();
            dataMasterForm.Show();
            this.Hide();
        }

        private void BarangForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventarisDataSet1.Kategori_Barang' table. You can move, or remove it, as needed.
            this.kategori_BarangTableAdapter.Fill(this.inventarisDataSet1.Kategori_Barang);
            // TODO: This line of code loads data into the 'inventarisDataSet.Peminjam' table. You can move, or remove it, as needed.
            this.peminjamTableAdapter.Fill(this.inventarisDataSet.Peminjam);

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
    }
}
