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
            this.Close();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            KategoriBarangForm kategoriBarang = new KategoriBarangForm();
            kategoriBarang.TopLevel = false;
            kategoriBarang.FormBorderStyle = FormBorderStyle.None;
            kategoriBarang.Dock = DockStyle.Fill;
            panel2.Controls.Add(kategoriBarang);
            panel2.Tag = kategoriBarang;
            kategoriBarang.BringToFront();
            kategoriBarang.Show();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            BarangForm barang = new BarangForm();
            barang.TopLevel = false;
            barang.FormBorderStyle = FormBorderStyle.None;
            barang.Dock = DockStyle.Fill;
            panel2.Controls.Add(barang);
            panel2.Tag = barang;
            barang.BringToFront();
            barang.Show();
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            PetugasForm petugas = new PetugasForm();
            petugas.TopLevel = false;
            petugas.FormBorderStyle = FormBorderStyle.None;
            petugas.Dock = DockStyle.Fill;
            panel2.Controls.Add(petugas);
            panel2.Tag = petugas;
            petugas.BringToFront();
            petugas.Show();
        }

        private void btnPengelolaan_Click(object sender, EventArgs e)
        {
            PengelolaanForm pen = new PengelolaanForm();
            pen.TopLevel = false;
            pen.FormBorderStyle = FormBorderStyle.None;
            pen.Dock = DockStyle.Fill;
            panel2.Controls.Add(pen);
            panel2.Tag = pen;
            pen.BringToFront();
            pen.Show();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            RiwayatForm riwayat = new RiwayatForm();
            riwayat.TopLevel = false;
            riwayat.FormBorderStyle = FormBorderStyle.None;
            riwayat.Dock = DockStyle.Fill;
            panel2.Controls.Add(riwayat);
            panel2.Tag = riwayat;
            riwayat.BringToFront();
            riwayat.Show();

        }

        private void btnPeminjam_Click(object sender, EventArgs e)
        {
            PeminjamForm peminjam = new PeminjamForm();
            peminjam.TopLevel = false;
            peminjam.FormBorderStyle = FormBorderStyle.None;
            peminjam.Dock = DockStyle.Fill;
            panel2.Controls.Add(peminjam);
            panel2.Tag = peminjam;
            peminjam.BringToFront();
            peminjam.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeminjamanForm pe = new PeminjamanForm();
            pe.TopLevel = false;
            pe.FormBorderStyle = FormBorderStyle.None;
            pe.Size = panel2.Size;  // Set the form's size to match the panel's size
            panel2.Controls.Add(pe);
            panel2.AutoScroll = true;  // Enable auto-scrolling
            panel2.Tag = pe;
            pe.BringToFront();
            pe.Show();
        }
    }
}
