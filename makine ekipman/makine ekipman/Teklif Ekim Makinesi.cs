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
    public partial class Teklif_Ekim_Makinesi : Form
    {
        public Teklif_Ekim_Makinesi()
        {
            InitializeComponent();
        }

        public static string TETip;
        public static string TEis;
        public static string TEguc;
        public static string TEayak;
        public static string TEagirlik;
        public static string TEUzun;
        public static string TEgenis;
        public static string TEyuksek;
        public static string TEMarka;
        public static string TEMensei;
        public static string TEFiyat;




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TETip = TTETip.SelectedItem.ToString();
            TEis=TTEIsG.SelectedItem.ToString();
            TEguc=TTEGuc.SelectedItem.ToString();
            TEayak = TTEBıcakS.SelectedItem.ToString();
            TEagirlik=TTEAgirlik.SelectedItem.ToString();
            TEUzun=TTEUzunluk.SelectedItem.ToString();
            TEgenis = TTEGenislik.SelectedItem.ToString();
            TEyuksek = TTEYukseklik.SelectedItem.ToString();
            TEMarka = TTEMarkaM.SelectedItem.ToString();
            TEMensei = TTEMensei.SelectedItem.ToString();
            TEFiyat = TTEFiyat.SelectedItem.ToString();
        }

        private void Teklif_Ekim_Makinesi_Load(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from ekimmakinesi", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTETip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct isgenisligi from ekimmakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTEIsG.Items.Add(oku["isgenisligi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from ekimmakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTEGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct ayaksayisi from ekimmakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTEBıcakS.Items.Add(oku["ayaksayisi"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from ekimmakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTEAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from ekimmakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTEUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from ekimmakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTEGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from ekimmakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTEYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from ekimmakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTEMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from ekimmakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTEMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from ekimmakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTEFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
