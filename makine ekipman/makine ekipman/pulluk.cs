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
    public partial class pulluk : Form
    {
        public static string pulluktip;
        public static string pullukagirlik;
        public static string pullukagirlik1;
        public static string pullukguc;
        public static string pullukguc1;
        public static string pullukuzunluk;
        public static string pullukuzunluk1;
        public static string pullukgenislik;
        public static string pullukgenislik1;
        public static string pullukyukseklik;
        public static string pullukyukseklik1;
        public static string pullukayaks;
        public static string pullukayaks1;
        public static string pullukisgenislik;
        public static string pullukisgenislik1;
        public static string pullukgovdearasi;
        public static string pullukek;
        public static string pullukbirim;
        public static string pullukmiktar;
        public pulluk()
        {
            InitializeComponent();

        }

        private void pulluk_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pullukbirim = txtPBirim.Text;
            pullukmiktar = txtPMiktar.Text;
            pulluktip = txtPTip.Text;
            pullukagirlik = txtPAgirlik.Text;
            pullukagirlik1 = txtPAgirlik1.Text;
            pullukguc = txtPGuc.Text;
            pullukguc1 = txtPGuc1.Text;
            pullukuzunluk = txtPUzunluk.Text;
            pullukuzunluk1 = txtPUzunluk1.Text;
            pullukgenislik = txtPGenislik.Text;
            pullukgenislik1 = txtPGenislik1.Text;
            pullukyukseklik = txtPYukseklik.Text;
            pullukyukseklik1 = txtPYukseklik1.Text;
            pullukayaks = txtPAyakS.Text;
            pullukayaks1 = txtPAyakS1.Text;
            pullukisgenislik = txtPIsG.Text;
            pullukisgenislik1 = txtPIsG1.Text;
            pullukgovdearasi = txtPGovdeA.Text;
            pullukek = txtPEk.Text;
            this.Close();
        }
    }
}
