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
    public partial class tirmik : Form
    {
        public static string tirmiktip;
        public static string tirmikagirlik;
        public static string tirmikagirlik1;
        public static string tirmikuzunluk;
        public static string tirmikuzunluk1;
        public static string tirmikyukseklik;
        public static string tirmikyukseklik1;
        public static string tirmikguc;
        public static string tirmikguc1;
        public static string tirmikgenislik;
        public static string tirmikgenislik1;
        public static string tirmikisgenislik;
        public static string tirmikisgenislik1;
        public static string tirmikdis;
        public static string tirmikek;
        public static string tirmikbirim;
        public static string tirmikmiktar;

        public tirmik()
        {
            InitializeComponent();

        }

        private void tirmik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tirmikbirim = txtTIBirim.Text;
            tirmikmiktar = txtTMiktar.Text;
            tirmiktip = txtTITip.Text;
            tirmikagirlik = txtTIAgirlik.Text;
            tirmikagirlik1 = txtTIAgirlik1.Text;
            tirmikuzunluk = txtTIUzunluk.Text;
            tirmikuzunluk1 = txtTIUzunluk1.Text;
            tirmikyukseklik = txtTIYukseklik.Text;
            tirmikyukseklik1 = txtTIYukseklik1.Text;
            tirmikguc = txtTIGuc.Text;
            tirmikguc1 = txtTIGuc1.Text;
            tirmikgenislik = txtTIGenislik.Text;
            tirmikgenislik1 = txtTIGenislik1.Text;
            tirmikisgenislik = txtTIIsG.Text;
            tirmikisgenislik1 = txtTIIsG1.Text;
            tirmikdis = txtTIDisS.Text;
            tirmikek = txtTIEk.Text;
            this.Close();
        }
    }
}
