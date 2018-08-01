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
    public partial class Romork : Form
    {
        public static string romorktip;
        public static string romorkuzunluk;
        public static string romorkuzunluk1;
        public static string romorkgenislik;
        public static string romorkgenislik1;
        public static string romorkyukseklik;
        public static string romorkyukseklik1;
        public static string romorkkapasite;
        public static string romorkkapasite1;
        public static string romorkdingil;
        public static string romorktekersayisi;
        public static string romorklastik;
        public static string romorklastik1;
        public static string romorkek;
        public static string romorkbirim;
        public static string romorkmiktar;

        public Romork()
        {
            InitializeComponent();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Romork_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            romorkbirim = txtRBirim.Text;
            romorkmiktar = txtRMiktar.Text;
            romorktip = txtRTip.Text;
            romorkuzunluk = txtRUzunluk.Text;
            romorkuzunluk1 = txtRUzunluk1.Text;
            romorkgenislik = txtRGenislik.Text;
            romorkgenislik1 = txtRGenislik1.Text;
            romorkyukseklik = txtRYukseklik.Text;
            romorkyukseklik1 = txtRYukseklik1.Text;
            romorkkapasite = txtRKapasite.Text;
            romorkkapasite1 = txtRKapasite1.Text;
            romorkdingil = txtRDingil.Text;
            romorktekersayisi = txtRTekerS.Text;
            romorklastik = txtRLastikE.Text;
            romorklastik1 = txtRLastikE1.Text;
            romorkek = txtREk.Text;
            this.Close();
        }
    }
}
