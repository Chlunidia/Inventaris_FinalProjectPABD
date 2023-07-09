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
    public partial class DataMasterForm : Form
    {
        public DataMasterForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            BarangForm barangForm = new BarangForm();
            barangForm.Show();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            KategoriBarangForm kategoriBarangForm = new KategoriBarangForm();
            kategoriBarangForm.Show();
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            PetugasForm petugasForm = new PetugasForm();
            petugasForm.Show();
        }

        private void btnPeminjam_Click(object sender, EventArgs e)
        {
            PeminjamForm peminjamForm = new PeminjamForm();
            peminjamForm.Show();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            RiwayatForm riwayatForm = new RiwayatForm();
            riwayatForm.Show();
        }

        private void btnSurat_Click(object sender, EventArgs e)
        {
            SuratPeminjamanForm suratPeminjaman = new SuratPeminjamanForm();
            suratPeminjaman.Show();
        }

        private void btnPengelolaan_Click(object sender, EventArgs e)
        {
            PengelolaanForm pengelolaanForm = new PengelolaanForm();
            pengelolaanForm.Show();
            this.Hide();
        }
    }
}
