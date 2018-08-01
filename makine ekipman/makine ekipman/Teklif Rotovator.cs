using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySQL.Data;
using wordeaktar = Microsoft.Office.Interop.Word;
using table = Microsoft.Office.Interop.Word.Table;

namespace makine_ekipman
{
    public partial class Teklif_Rotovator : Form
    {
        public Teklif_Rotovator()
        {
            InitializeComponent();
        }
        public static string TRTip;
        public static string TRisg;
        public static string TRgenis;
        public static string TRagir;
        public static string TRguc;
        public static string TRbicak;
        public static string TRuzun;
        public static string TRisd;
        public static string TRYuksek;
        public static string TRMarka;
        public static string TRMensei;
        public static string TRFiyat;

        private void button1_Click(object sender, EventArgs e)
        {
            TRTip = TTRTip.SelectedItem.ToString();
            TRisg= TTRIsG.SelectedItem.ToString();
            TRgenis= TTRGenislik.SelectedItem.ToString();
            TRagir= TTRAgirlik.SelectedItem.ToString();
            TRguc= TTRGuc.SelectedItem.ToString();
            TRbicak = TTRBicakS.SelectedItem.ToString();
            TRuzun = TTRUzunluk.SelectedItem.ToString();
            TRisd= TTRIsD.SelectedItem.ToString();
            TRYuksek= TTRYukseklik.SelectedItem.ToString();
            TRMarka = TTRMarkaM.SelectedItem.ToString();
            TRMensei= TTRMensei.SelectedItem.ToString();
            TRFiyat= TTRFiyat.SelectedItem.ToString();

            this.Close();
        }

        private void Teklif_Rotovator_Load(object sender, EventArgs e)
        {


            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from rotovator", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct isgenisligi from rotovator ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRIsG.Items.Add(oku["isgenisligi"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from rotovator ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from rotovator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from rotovator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct bicaksayisi from rotovator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRBicakS.Items.Add(oku["bicaksayisi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from rotovator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct isderinligi from rotovator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRIsD.Items.Add(oku["isderinligi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from rotovator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from rotovator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from rotovator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from rotovator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
