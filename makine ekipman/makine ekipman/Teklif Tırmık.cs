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
    public partial class Teklif_Tırmık : Form
    {
        public Teklif_Tırmık()
        {
            InitializeComponent();
        }
        public static string TTITip;
        public static string TTIisg;
        public static string TTIgenis;
        public static string TTIagir;
        public static string TTIguc;
        public static string TTIDs;
        public static string TTIuzun;
        public static string TTIyuk;
        public static string TTIMarka;
        public static string TTIMensei;
        public static string TTIFiyat;


        private void button1_Click(object sender, EventArgs e)
        {

            TTITip = TTTiTip.SelectedItem.ToString();
            TTIisg= TTTiIsG.SelectedItem.ToString();
            TTIgenis= TTTiGenislik.SelectedItem.ToString();
            TTIagir= TTTiAgirlik.SelectedItem.ToString();
            TTIguc = TTTiGuc.SelectedItem.ToString();
            TTIDs = TTTiDisS.SelectedItem.ToString();
            TTIuzun = TTTiUzunluk.SelectedItem.ToString();
            TTIyuk = TTTiYukseklik.SelectedItem.ToString();
            TTIMarka = TTTiMarkaM.SelectedItem.ToString();
            TTIMensei = TTTiMensei.SelectedItem.ToString(); 
            TTIFiyat=TTTiFiyat.SelectedItem.ToString();
            this.Close();
        }

        private void Teklif_Tırmık_Load(object sender, EventArgs e)
        {

            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from tirmik", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTiTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct isgenisligi from tirmik ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTiIsG.Items.Add(oku["isgenisligi"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from tirmik ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTiGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from tirmik", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTiAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from tirmik", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTiGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct dissayisi from tirmik", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTiDisS.Items.Add(oku["dissayisi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from tirmik", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTiUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();
            

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from tirmik", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTiYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from tirmik", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTiMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from tirmik", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTiMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from tirmik", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTTiFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
