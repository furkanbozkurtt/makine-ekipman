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
    public partial class tesviye : Form
    {
        public static string tesviyetip;
        public static string tesviyeagirlik;
        public static string tesviyeagirlik1;
        public static string tesviyeguc;
        public static string tesviyeguc1;
        public static string tesviyeuzunluk;
        public static string tesviyeuzunluk1;
        public static string tesviyegenislik;
        public static string tesviyegenislik1;
        public static string tesviyeyukseklik;
        public static string tesviyeyukseklik1;
        public static string tesviyeisgenislik;
        public static string tesviyeisgenislik1;
        public static string tesviyesac;
        public static string tesviyeyon;
        public static string tesviyeek;
        public static string tesviyemiktar;
        public static string tesviyebirim;

        public tesviye()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tesviye_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tesviyebirim = txtTEBirim.Text;
            tesviyemiktar = txtTEMiktar.Text;
            tesviyetip = txtTETip.Text;
            tesviyeagirlik = txtTEAgirlik.Text;
            tesviyeagirlik1 = txtTEAgirlik1.Text;
            tesviyeguc = txtTEGuc.Text;
            tesviyeguc1 = txtTEGuc1.Text;
            tesviyeuzunluk = txtTEUzunluk.Text;
            tesviyeuzunluk1 = txtTEUzunluk1.Text;
            tesviyegenislik = txtTEGenislik.Text;
            tesviyegenislik1 = txtTEGenislik1.Text;
            tesviyeyukseklik = txtTEYukseklik.Text;
            tesviyeyukseklik1 = txtTEYukseklik1.Text;
            tesviyeisgenislik = txtTEIsG.Text;
            tesviyeisgenislik1 = txtTEIsG1.Text;
            tesviyesac = txtTESacK.Text;
            tesviyeyon = txtTEYonlendirme.Text;
            tesviyeek = txtTEEk.Text;
            this.Close();
        }
    }
}
