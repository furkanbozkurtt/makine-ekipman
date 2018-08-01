using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makine_ekipman
{
    public partial class Goble : Form
    {
        public static string gobletip;
        public static string gobleagirlik;
        public static string gobleagirlik1;
        public static string gobleguc;
        public static string gobleguc1;
        public static string gobleuzunluk;
        public static string gobleuzunluk1;
        public static string gobleyukseklik;
        public static string gobleyukseklik1;
        public static string goblegenislik;
        public static string goblegenislik1;
        public static string gobledisksayisi;
        public static string gobledisksayisi1;
        public static string gobleisgenislik;
        public static string gobleisgenislik1;
        public static string gobleek;
        public static string goblebirim;
        public static string goblemiktar;

        public Goble()
        {
            InitializeComponent();
           

        }

        private void Goble_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            goblebirim = txtGBirim.Text;
            goblemiktar = txtGMiktar.Text;
            gobletip = txtGtip.Text;
            gobleagirlik = txtGAgirlik.Text;
            gobleagirlik1 = txtGAgirlik1.Text;
            gobleguc = txtGGuc.Text;
            gobleguc1 = txtGGuc1.Text;
            gobleuzunluk = txtGUzunluk.Text;
            gobleuzunluk1 = txtGUzunluk1.Text;
            gobleyukseklik = txtGYuksek.Text;
            gobleyukseklik1 = txtGYuksek1.Text;
            goblegenislik = txtGGenislik.Text;
            goblegenislik1 = txtGGenislik1.Text;
            gobledisksayisi = txtGDiskS.Text;
            gobledisksayisi1 = txtGDiskS1.Text;
            gobleisgenislik = txtGIsG.Text;
            gobleisgenislik1 = txtGIsG1.Text;
            gobleek = txtGEk.Text;
            this.Close();
        }
    }
}
