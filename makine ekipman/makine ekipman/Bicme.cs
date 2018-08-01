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
    public partial class Bicme : Form
    {
        public static string bicmetip;
        public static string bicmeagirlik;
        public static string bicmeagirlik1;
        public static string bicmeguc;
        public static string bicmeguc1;
        public static string bicmeuzunluk;
        public static string bicmeuzunluk1;
        public static string bicmegenislik;
        public static string bicmegenislik1;
        public static string bicmeyukseklik;
        public static string bicmeyukseklik1;
        public static string bicmebicaksayisi;
        public static string bicmeek;
        public static string bicmebirim;
        public static string bicmemiktar;

        public Bicme()
        {
            InitializeComponent();
        }

        private void txtBAgirlik_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bicme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bicmebirim = txtBBirim.Text;
            bicmemiktar = txtBMiktar.Text;
            bicmetip = txtBTip.Text;
            bicmeagirlik = txtBAgirlik.Text;
            bicmeagirlik1 = txtBAgirlik1.Text;
            bicmeguc = txtBGuc.Text;
            bicmeguc1 = txtBGuc1.Text;
            bicmeuzunluk = txtBUzunluk.Text;
            bicmeuzunluk1 = txtBUzunluk1.Text;
            bicmegenislik = txtBGenislik.Text;
            bicmegenislik1 = txtBGenislik1.Text;
            bicmeyukseklik = txtBYukseklik.Text;
            bicmeyukseklik1 = txtBYukseklik1.Text;
            bicmebicaksayisi = txtBBicakSayisi.Text;
            bicmeek = txtBEkO.Text;
            this.Close();
        }
    }
}
