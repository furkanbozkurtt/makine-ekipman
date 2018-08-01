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
    public partial class merdane : Form
    {
        public static string merdanetip;
        public static string merdaneagirlik;
        public static string merdaneagirlik1;
        public static string merdaneguc;
        public static string merdaneguc1;
        public static string merdaneuzunluk;
        public static string merdaneuzunluk1;
        public static string merdanegenislik;
        public static string merdanegenislik1;
        public static string merdaneyukseklik;
        public static string merdaneyukseklik1;
        public static string merdaneisgenislik;
        public static string merdaneisgenislik1;
        public static string merdanesira;
        public static string merdanecap;
        public static string merdaneek;
        public static string merdanebirim;
        public static string merdanemiktar;
        public merdane()
        {
            InitializeComponent();

        }

        private void merdane_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            merdanebirim = txtMBirim.Text;
            merdanemiktar = txtMMiktar.Text;
            merdanetip = txtMTip.Text;
            merdaneagirlik = txtMAgırlık.Text;
            merdaneagirlik1 = txtMAgırlık1.Text;
            merdaneguc = txtMGuc.Text;
            merdaneguc1 = txtMGuc1.Text;
            merdaneuzunluk = txtMUzunluk.Text;
            merdaneuzunluk1 = txtMUzunluk1.Text;
            merdanegenislik = txtMGenislik.Text;
            merdanegenislik1 = txtMGenislik1.Text;
            merdaneyukseklik = txtMYukseklik.Text;
            merdaneyukseklik1 = txtMYukseklik.Text;
            merdaneyukseklik1 = txtMYukseklik1.Text;
            merdaneisgenislik = txtMIsG.Text;
            merdaneisgenislik1 = txtMIsG1.Text;
            merdanesira = txtMSıra.Text;
            merdanecap = txtMCap.Text;
            merdaneek = txtMEk.Text;
            this.Close();
        }
    }
}
