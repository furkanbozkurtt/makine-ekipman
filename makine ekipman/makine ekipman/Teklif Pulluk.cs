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
    public partial class Teklif_Pulluk : Form
    {
        public Teklif_Pulluk()
        {
            InitializeComponent();
        }
        public static string TPTip;
        public static string TPisg;
        public static string TPGenis;
        public static string TPagir;
        public static string TPGuc;
        public static string TPAyak;
        public static string TPUzun;
        public static string TPGovde;
        public static string TPYuksek;
        public static string TPMarka;
        public static string TPMEnsei;
        public static string TPFiyat;

        private void button1_Click(object sender, EventArgs e)
        {


            TPTip = TTPTip.SelectedItem.ToString();
            TPisg= TTPIsG.SelectedItem.ToString();
            TPGenis= TTPGenislik.SelectedItem.ToString();
            TPagir= TTPAgirlik.SelectedItem.ToString();
            TPGuc= TTPGuc.SelectedItem.ToString();
            TPAyak = TTPAyakS.SelectedItem.ToString();
            TPUzun = TTPUzunluk.SelectedItem.ToString();
            TPGovde = TTPGovdeA.SelectedItem.ToString();
            TPYuksek= TTPYukseklik.SelectedItem.ToString();
            TPMarka= TTPMarkaM.SelectedItem.ToString();
            TPMEnsei=TTPMensei.SelectedItem.ToString();
            TPFiyat= TTPFiyat.SelectedItem.ToString();

            this.Close();
        }

        private void Teklif_Pulluk_Load(object sender, EventArgs e)
        {

            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from pulluk", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct isgenisligi from pulluk ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPIsG.Items.Add(oku["isgenisligi"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from pulluk ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from pulluk", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from pulluk", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct ayaksayisi from pulluk", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPAyakS.Items.Add(oku["ayaksayisi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from pulluk", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct govdearasi from pulluk", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPGovdeA.Items.Add(oku["govdearasi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from pulluk", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from pulluk", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from pulluk", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from pulluk", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTPFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
