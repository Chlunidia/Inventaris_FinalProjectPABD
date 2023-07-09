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
    public partial class PeminjamForm : Form
    {
        public PeminjamForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataMasterForm dataMasterForm = new DataMasterForm();
            dataMasterForm.Show();
            this.Hide();
        }

        private void txtOrganisasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
