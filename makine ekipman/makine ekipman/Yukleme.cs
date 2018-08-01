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
    public partial class Yukleme : Form
    {
        public static string YTip;
        public static string YAgirlik;
        public static string YAgirlik1;
        public static string YUzunluk;
        public static string YUzunluk1;
        public static string YYuksek;
        public static string YYuksek1;
        public static string Yisg;
        public static string Yisg1;
        public static string YEk;
        public static string YBirim;
        public static string YMiktar;

        public Yukleme()
        {
            InitializeComponent();
            

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Yukleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YBirim = txtYBirim.Text;
            YMiktar = txtYMiktar.Text;
            YTip = txtYTip.Text;
            YAgirlik = txtYAgirlik.Text;
            YAgirlik1 = txtYAgirlik1.Text;
            YUzunluk = txtYUzunluk.Text;
            YUzunluk1 = txtYUzunluk1.Text;
            YYuksek = txtYYukseklik.Text;
            YYuksek1 = txtYYukseklik1.Text;
            Yisg = txtYIsG.Text;
            Yisg1 = txtYIsG1.Text;
            YEk = txtYEk.Text;
            this.Close();
        }
    }
}
