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
    public partial class Teklif_Tesfiye_Kuregi : Form
    {
        public Teklif_Tesfiye_Kuregi()
        {
            InitializeComponent();
        }
        public static string TTsTip;
        public static string TTsisg;
        public static string TTsgenis;
        public static string TTsagir;
        public static string TTsguc;
        public static string TTssk;
        public static string TTsuzunluk;
        public static string TTsYonlendirme;
        public static string TTsYuksek;
        public static string TTsMarka;
        public static string TTsMensei;
        public static string TTsFiyat;


        private void button1_Click(object sender, EventArgs e)
        {
            TTsTip = TTTTip.SelectedItem.ToString();
            TTsisg = TTTIsG.SelectedItem.ToString();
            TTsgenis= TTTGenislik.SelectedItem.ToString();
            TTsagir = TTTAgirlik.SelectedItem.ToString();
            TTsguc = TTTGuc.SelectedItem.ToString();
            TTssk = TTTSacK.SelectedItem.ToString();
            TTsuzunluk = TTTUzunluk.SelectedItem.ToString();
            TTsYonlendirme = TTTyon.SelectedItem.ToString();
            TTsYuksek = TTTYukseklik.SelectedItem.ToString();
            TTsMarka = TTTMarkaM.SelectedItem.ToString();
            TTsMensei = TTTMensei.SelectedItem.ToString();
            TTsFiyat = TTTFiyat.SelectedItem.ToString();
            this.Close();
        }

        private void Teklif_Tesfiye_Kuregi_Load(object sender, EventArgs e)
        {

            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from tesviyekuregi", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct isgenisligi from tesviyekuregi ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTIsG.Items.Add(oku["isgenisligi"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from tesviyekuregi ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from tesviyekuregi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from tesviyekuregi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct sackalinligi from tesviyekuregi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTSacK.Items.Add(oku["sackalinligi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from tesviyekuregi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yonlendirme from tesviyekuregi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTyon.Items.Add(oku["yonlendirme"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from tesviyekuregi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from tesviyekuregi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from tesviyekuregi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from tesviyekuregi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
