using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class Teklif_Bicme_Makinesi : Form
    {
        public Teklif_Bicme_Makinesi()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static string TBTip;
        public static string TBBicakS;
        public static string TBAgirlik;
        public static string TBGuc;
        public static string TBUzunluk;
        public static string TBYuksek;
        public static string TBGenis;
        public static string TBMarka;
        public static string TBMensei;
        public static string TBFiyat;



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TBTip = TTBTip.SelectedItem.ToString();
            TBAgirlik = TTBAgirlik.SelectedItem.ToString();
            TBBicakS = TTBBıcakS.SelectedItem.ToString();
            TBGuc = TTBGuc.SelectedItem.ToString();
            TBUzunluk = TTBUzunluk.SelectedItem.ToString();
            TBYuksek = TTBYukseklik.SelectedItem.ToString();
            TBGenis=TTBGenislik.SelectedItem.ToString();
            TBMarka=TTBMarkaM.SelectedItem.ToString();
            TBMensei=TTBMensei.SelectedItem.ToString();
            TBFiyat=TTBFiyat.SelectedItem.ToString();


        }

        private void Teklif_Bicme_Makinesi_Load(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from bicmemakinesi", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTBTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct bicaksayisi from bicmemakinesi ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTBBıcakS.Items.Add(oku["bicaksayisi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from bicmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTBAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from bicmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTBGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();
            

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from bicmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTBUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from bicmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTBGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from bicmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTBYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from bicmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTBMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from bicmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTBMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from bicmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTBFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
