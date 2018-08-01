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
    public partial class Gubre : Form
    {
        public static string gubretip;
        public static string gubreagirlik;
        public static string gubreagirlik1;
        public static string gubreguc;
        public static string gubreguc1;
        public static string gubreuzunluk;
        public static string gubreuzunluk1;
        public static string gubregenislik;
        public static string gubregenislik1;
        public static string gubreyukseklik;
        public static string gubreyukseklik1;
        public static string gubrekapasite;
        public static string gubrekapasite1;
        public static string gubreisgenislik;
        public static string gubreisgenislik1;
        public static string gubreek;
        public static string gubrebirim;
        public static string gubremiktar;

        public Gubre()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Gubre_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gubrebirim = txtGBBirim.Text;
            gubremiktar = txtGBMiktar.Text;
            gubretip = txtGBTip.Text;
            gubreagirlik = txtGBAgirlik.Text;
            gubreagirlik1 = txtGBAgirlik1.Text;
            gubreguc = txtGBGuc.Text;
            gubreguc1 = txtGBGuc1.Text;
            gubreuzunluk = txtGBUzunluk.Text;
            gubreuzunluk1 = txtGBUzunluk1.Text;
            gubregenislik = txtGBGenislik.Text;
            gubregenislik1 = txtGBGenislik1.Text;
            gubreyukseklik = txtGBYukseklik.Text;
            gubreyukseklik1 = txtGBYukseklik1.Text;
            gubrekapasite = txtGBKapasite.Text;
            gubrekapasite1 = txtGBKapasite1.Text;
            gubreisgenislik = txtGBIsG.Text;
            gubreisgenislik1 = txtGBIsG1.Text;
            gubreek = txtGBEk.Text;
            this.Close();
        }
    }
}
