using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeminjamanInventaris
{
    public partial class SuratPeminjamanForm : Form
    {
        public string IdSurat { get; set; }
        public string IdPeminjaman { get; set; }
        public string NamaPetugas { get; set; }
        public string NamaPeminjam { get; set; }
        public string NamaBarang { get; set; }
        public string StatusPeminjaman { get; set; }
        public DateTime TanggalPeminjaman { get; set; }
        public DateTime TanggalPengembalianHarus { get; set; }
        public DateTime TanggalPengembalian { get; set; }
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=inventaris;Integrated Security=True;User=sa;Password=Chluni2350719";
        public SuratPeminjamanForm()
        {
            InitializeComponent();
        }

        private void SuratPeminjamanForm_Load(object sender, EventArgs e)
        {
            lblIdSurat.Text = IdSurat;
            lblIdPeminjaman.Text = IdPeminjaman;
            lblNamaPetugas.Text = NamaPetugas;
            lblNamaPeminjam.Text = NamaPeminjam;
            lblNamaBarang.Text = NamaBarang;
            lblStatusPeminjaman.Text = StatusPeminjaman;
            lblTanggalPeminjaman.Text = TanggalPeminjaman.ToShortDateString();
            lblTanggalPengembalianHarus.Text = TanggalPengembalianHarus.ToShortDateString();
            lblTanggalPengembalian.Text = TanggalPengembalian.ToShortDateString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
            Brush brush = Brushes.Black;

            float lineHeight = font.GetHeight();
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Prepare the content to be printed
            StringBuilder content = new StringBuilder();
            content.AppendLine("ID Surat: " + lblIdSurat.Text);
            content.AppendLine("ID Peminjaman: " + lblIdPeminjaman.Text);
            content.AppendLine("Nama Petugas: " + lblNamaPetugas.Text);
            content.AppendLine("Nama Peminjam: " + lblNamaPeminjam.Text);
            content.AppendLine("Nama Barang: " + lblNamaBarang.Text);
            content.AppendLine("Status Peminjaman: " + lblStatusPeminjaman.Text);
            content.AppendLine("Tanggal Peminjaman: " + lblTanggalPeminjaman.Text);
            content.AppendLine("Tanggal Pengembalian Harus: " + lblTanggalPengembalianHarus.Text);
            content.AppendLine("Tanggal Pengembalian: " + lblTanggalPengembalian.Text);

            // Print the content
            e.Graphics.DrawString(content.ToString(), font, brush, x, y);

            // Move the cursor to the next line
            y += lineHeight;

            // Check if there is more content to print
            if (y + lineHeight < e.MarginBounds.Bottom)
            {
                e.HasMorePages = false;  // All content has been printed
            }
            else
            {
                e.HasMorePages = true;  // There is more content to print
            }
        }
    }
}
