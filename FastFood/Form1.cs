using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Form1 : Form
    {
        // INISIALISASI VARIABLE
        private String nama = "";
        private int total = 0, bayar = 0;

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        // TOMBOL KELUAR
        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // TOMBOL PESAN BURGER
        private void pesanBurger_Click(object sender, EventArgs e)
        {

        }

        // TOMBOL PESAN AYAM
        private void pesanAyam_Click(object sender, EventArgs e)
        {

        }

        // TOMBOL PESAN NASI
        private void pesanNasi_Click(object sender, EventArgs e)
        {

        }

        // TOMBOL SET JUMLAH PESAN BURGER, AYAM, DAN NASI
        private void minBurger_Click(object sender, EventArgs e)
        {

        }

        private void plusBurger_Click(object sender, EventArgs e)
        {

        }

        private void minAyam_Click(object sender, EventArgs e)
        {

        }

        private void plusAyam_Click(object sender, EventArgs e)
        {

        }

        private void minNasi_Click(object sender, EventArgs e)
        {

        }

        private void plusNasi_Click(object sender, EventArgs e)
        {

        }

        // TOMBOL PROSES UNTUK MENGHITUNG TOTAL BIAYA DAN KEMBALIAN
        private void tombolProses_Click(object sender, EventArgs e)
        {
            
        }
    }
}
