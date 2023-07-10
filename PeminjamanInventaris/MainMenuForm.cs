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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Show();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            KategoriBarangForm kategoriBarangForm = new KategoriBarangForm();
            kategoriBarangForm.Show();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            BarangForm barangForm = new BarangForm();
            barangForm.Show();
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            PetugasForm petugasForm = new PetugasForm();
            petugasForm.Show();
        }

        private void btnPengelolaan_Click(object sender, EventArgs e)
        {
            PengelolaanForm pengelolaanForm = new PengelolaanForm();
            pengelolaanForm.Show();
        }

        private void btnPeminjam_Click(object sender, EventArgs e)
        {
            PeminjamForm peminjamForm = new PeminjamForm();
            peminjamForm.Show();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            PeminjamanForm peminjaman = new PeminjamanForm();
            peminjaman.Show();
        }

        private void btnSurat_Click(object sender, EventArgs e)
        {
            SuratPeminjamanForm suratPeminjaman = new SuratPeminjamanForm();
            suratPeminjaman.Show();
        }
    }
}
