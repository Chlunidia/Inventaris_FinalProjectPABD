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
    public partial class PetugasForm : Form
    {
        public PetugasForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataMasterForm dm = new DataMasterForm();
            dm.Show();
            this.Hide();
        }

        private void txtNamaPetugas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
