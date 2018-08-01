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
    public partial class capa : Form
    {
        public static string capatip;
        public static string capaagirlik;
        public static string capaagirlik1;
        public static string capaguc;
        public static string capaguc1;
        public static string capauzunluk;
        public static string capauzunluk1;
        public static string capagenislik;
        public static string capagenislik1;
        public static string capayukseklik;
        public static string capayukseklik1;
        public static string capaayaks;
        public static string capaayaks1;
        public static string capaek;
        public static string capabirim;
        public static string capamiktar;


        public capa()
        {
            InitializeComponent();
            

        }

        private void capa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            capabirim = txtCBirim.Text;
            capamiktar = txtCMiktar.Text;
            capatip = txtCTip.Text;
            capaagirlik = txtCAgirlik.Text;
            capaagirlik1 = txtCAgirlik1.Text;
            capaguc = txtCGuc.Text;
            capaguc1 = txtCGuc1.Text;
            capauzunluk = txtCUzunluk.Text;
            capauzunluk1 = txtCUzunluk1.Text;
            capagenislik = txtCGenislik.Text;
            capagenislik1 = txtCGenislik1.Text;
            capayukseklik = txtCYuksek.Text;
            capayukseklik1 = txtCYuksek1.Text;
            capaayaks = txtCAyaksayisi.Text;
            capaayaks1 = txtCAyaksayisi1.Text;
            capaek = txtCEk.Text;
            this.Close();
        }
    }
}
