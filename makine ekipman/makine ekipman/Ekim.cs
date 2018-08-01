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
    public partial class Ekim : Form
    {
        public static string ekimtip;
        public static string ekimagirlik;
        public static string ekimagirlik1;
        public static string ekimguc;
        public static string ekimguc1;
        public static string ekimuzunluk;
        public static string ekimuzunluk1;
        public static string ekimgenislik;
        public static string ekimgenislik1;
        public static string ekimyukseklik;
        public static string ekimyukseklik1;
        public static string ekimayaksayisi;
        public static string ekimayaksayisi1;
        public static string ekimisg;
        public static string ekimisg1;
        public static string ekimek;
        public static string ekimbirim;
        public static string ekimmiktar;


        public Ekim()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ekim_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekimbirim = txtEBirim.Text;
            ekimmiktar = txtEMiktar.Text;
            ekimtip = txtETip.Text;
            ekimagirlik = txtEAgirlik.Text;
            ekimagirlik1 = txtEAgirlik1.Text;
            ekimguc = txtEGuc.Text;
            ekimguc1 = txtEGuc1.Text;
            ekimuzunluk = txtEUzunluk.Text;
            ekimuzunluk1 = txtEUzunluk1.Text;
            ekimgenislik = txtEGenislik.Text;
            ekimgenislik1 = txtEGenislik1.Text;
            ekimyukseklik = txtEYukseklik.Text;
            ekimyukseklik1 = txtEYukseklik1.Text;
            ekimayaksayisi = txtEAyakS.Text;
            ekimayaksayisi1 = txtEAyakS1.Text;
            ekimisg = txtEIsG.Text;
            ekimisg1 = txtEIsG1.Text;
            ekimek = txtEEk.Text;
            this.Close();
        }
    }
}
