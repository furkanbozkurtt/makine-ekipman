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
    public partial class rotovator : Form
    {
        public static string rotovatortip;
        public static string rotovatoragirlik;
        public static string rotovatoragirlik1;
        public static string rotovatorguc;
        public static string rotovatorguc1;
        public static string rotovatoruzunluk;
        public static string rotovatoruzunluk1;
        public static string rotovatorgenislik;
        public static string rotovatorgenislik1;
        public static string rotovatoryukseklik;
        public static string rotovatoryukseklik1;
        public static string rotovatorbicak;
        public static string rotovatorisgenislik;
        public static string rotovatorisgenislik1;
        public static string rotovatorisderinlik;
        public static string rotovatorek;
        public static string rotovatorbirim;
        public static string rotovatormiktar;

        public rotovator()
        {
            InitializeComponent();
        }

        private void lblRTBicakS_Click(object sender, EventArgs e)
        {

        }

        private void rotovator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rotovatorbirim = txtRTBirim.Text;
            rotovatormiktar = txtRTMiktar.Text;
            rotovatortip = txtRTTip.Text;
            rotovatoragirlik = txtRTAgirlik.Text;
            rotovatoragirlik1 = txtRTAgirlik1.Text;
            rotovatorguc = txtRTGuc.Text;
            rotovatorguc1 = txtRTGuc1.Text;
            rotovatoruzunluk = txtRTUzunluk.Text;
            rotovatoruzunluk1 = txtRTUzunluk1.Text;
            rotovatorgenislik = txtRTGenislik.Text;
            rotovatorgenislik1 = txtRTGenislik1.Text;
            rotovatoryukseklik = txtRTYukseklik.Text;
            rotovatoryukseklik1 = txtRTYukseklik1.Text;
            rotovatorbicak = txtRTBicakS.Text;
            rotovatorisgenislik = txtRTIsG.Text;
            rotovatorisgenislik1 = txtRTIsG1.Text;
            rotovatorisderinlik = txtRTIsD.Text;
            rotovatorek = txtRTEk.Text;
            this.Close();
        }
    }
}
