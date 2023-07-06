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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TambahDataForm tambahData = new TambahDataForm();
            tambahData.Show();
            this.Hide();
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            PengembalianForm pengembalian = new PengembalianForm();
            pengembalian.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            RiwayatForm riwayat = new RiwayatForm();
            riwayat.Show();
            this.Hide();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            PeminjamanForm peminjaman = new PeminjamanForm();
            peminjaman.Show();
            this.Hide();
        }
    }
}
