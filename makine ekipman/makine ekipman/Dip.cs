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
    public partial class Dip : Form
    {
        public static string diptip;
        public static string dipsasiyuk;
        public static string dipguc;
        public static string dipguc1;
        public static string dipuzunluk;
        public static string dipuzunluk1;
        public static string dipgenislik;
        public static string dipgenislik1;
        public static string dipyukseklik;
        public static string dipyukseklik1;
        public static string dipayaksayisi;
        public static string dipayaksayisi1;
        public static string dipcderinlik;
        public static string dipek;
        public static string dipBirim;
        public static string dipmiktar;

        public Dip()
        {
            InitializeComponent();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dip_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dipBirim = txtDBirim.Text;
            dipmiktar = txtDMiktar.Text;
            diptip = txtDTip.Text;
            dipsasiyuk = txtDSasiy.Text;
            dipguc = txtDGuc.Text;
            dipguc1 = txtDGuc1.Text;
            dipuzunluk = txtDUzunluk.Text;
            dipuzunluk1 = txtDUzunluk1.Text;
            dipgenislik = txtDGen.Text;
            dipgenislik1 = txtDGen1.Text;
            dipyukseklik = txtDYukseklik.Text;
            dipyukseklik1 = txtDYukseklik1.Text;
            dipayaksayisi = txtDAyakS.Text;
            dipayaksayisi1 = txtDAyakS1.Text;
            dipcderinlik = txtDCalismaD.Text;
            dipek = txtDEk.Text;
            this.Close();
        }
    }
}
