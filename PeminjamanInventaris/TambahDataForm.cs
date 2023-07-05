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
    public partial class TambahDataForm : Form
    {
        public TambahDataForm()
        {
            InitializeComponent();
        }

        private void petugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetugasForm petugas = new PetugasForm();
            petugas.Show();
            this.Hide();
        }

        private void kategoriBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriBarangForm kategoriBarang = new KategoriBarangForm();
            kategoriBarang.Show();
            this.Hide();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarangForm barang = new BarangForm();
            barang.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }
    }
}
