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
    public partial class Teklif_Goble : Form
    {
        public Teklif_Goble()
        {
            InitializeComponent();
        }

        public static string TGTip;
        public static string TGisg;
        public static string TGguc;
        public static string TGDS;
        public static string TGAgir;
        public static string TGUzun;
        public static string TGGenis;
        public static string TGYuksek;
        public static string TGMarka;
        public static string TGMensei;
        public static string TGFiyat;



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TGTip = TTGTip.SelectedItem.ToString();
            TGisg= TTGisg.SelectedItem.ToString();
            TGguc= TTGGuc.SelectedItem.ToString();
            TGDS = TTGDiskS.SelectedItem.ToString();
            TGAgir= TTGAgirlik.SelectedItem.ToString();
            TGUzun= TTGUzunluk.SelectedItem.ToString();
            TGGenis= TTGGenislik.SelectedItem.ToString();
            TGYuksek = TTGYukseklik.SelectedItem.ToString();
            TGMarka = TTGMarkaM.SelectedItem.ToString();
            TGMensei = TTGMensei.SelectedItem.ToString();
            TGFiyat = TTGFiyat.SelectedItem.ToString();
        }

        private void Teklif_Goble_Load(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from goble", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct isgenisligi from goble", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGisg.Items.Add(oku["isgenisligi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from goble", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct disksayisi from goble", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGDiskS.Items.Add(oku["disksayisi"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from goble", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from goble", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from goble", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from goble", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from goble", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from goble", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from goble", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
