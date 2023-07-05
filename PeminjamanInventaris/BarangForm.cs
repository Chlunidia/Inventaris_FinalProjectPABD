using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeminjamanInventaris
{
    public partial class BarangForm : Form
    {
        public BarangForm()
        {
            InitializeComponent();
        }

        private void txtIDBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TambahDataForm tambahData = new TambahDataForm();
            tambahData.Show();
            this.Hide();
        }

        private void btnKBarang_Click(object sender, EventArgs e)
        {
            KategoriForm kat = new KategoriForm();
            kat.Show();
            this.Hide();
        }
    }
}
