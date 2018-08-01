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
    public partial class Teklif_Yukleme_Kepcesi : Form
    {
        public Teklif_Yukleme_Kepcesi()
        {
            InitializeComponent();
        }
        public static string TYTip;
        public static string TYisg;
        public static string TYagirlik;
        public static string TYuzunluk;
        public static string TYYuksek;
        public static string TYMarka;
        public static string TYMensei;
        public static string TYFiyat;

        private void button1_Click(object sender, EventArgs e)
        {
            TYTip = TTYTip.SelectedItem.ToString();
            TYisg=TTYIsG.SelectedItem.ToString(); 
            TYagirlik = TTYAgirlik.SelectedItem.ToString();
            TYuzunluk = TTYUzunluk.SelectedItem.ToString();
            TYYuksek = TTYYukseklik.SelectedItem.ToString();
            TYMarka=TTYMarkaM.SelectedItem.ToString(); 
            TYMensei= TTYMensei.SelectedItem.ToString();
            TYFiyat = TTYFiyat.SelectedItem.ToString();
            this.Close();
        }

        private void Teklif_Yukleme_Kepcesi_Load(object sender, EventArgs e)
        {

            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from yuklemekepcesi", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTYTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct isgenisligi from yuklemekepcesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTYIsG.Items.Add(oku["isgenisligi"]);
            }
            baglan.Close();

           

           
            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from yuklemekepcesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTYAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from yuklemekepcesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTYUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

           

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from yuklemekepcesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTYYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from yuklemekepcesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTYMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from yuklemekepcesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTYMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from yuklemekepcesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTYFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
