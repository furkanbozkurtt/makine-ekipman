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
    public partial class Teklif_Kultuvator_Makinesi : Form
    {
        public Teklif_Kultuvator_Makinesi()
        {
            InitializeComponent();
        }
        public static string TKTip;
        public static string TKisg;
        public static string TKAgir;
        public static string TKGuc;
        public static string TKUzun;
        public static string TKGenis;
        public static string TKYuksek;
        public static string TKMarka;
        public static string TKMensei;
        public static string TKFiyat;


        private void button1_Click(object sender, EventArgs e)
        {
            TKTip = TTKTip.SelectedItem.ToString();
            TKisg = TTKIsG.SelectedItem.ToString();
            TKAgir = TTKAgirlik.SelectedItem.ToString();
            TKGuc= TTKGuc.SelectedItem.ToString();
            TKUzun= TTKUzunluk.SelectedItem.ToString();
            TKGenis= TTKGenislik.SelectedItem.ToString();
            TKYuksek= TTKYukseklik.SelectedItem.ToString();
            TKMarka= TTKMarkaM.SelectedItem.ToString();
            TKMensei= TTKMensei.SelectedItem.ToString();
            TKFiyat= TTKFiyat.SelectedItem.ToString();
            this.Close();
        }

        private void Teklif_Kultuvator_Makinesi_Load(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from kultuvator", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTKTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct isgenisligi from kultuvator ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTKIsG.Items.Add(oku["isgenisligi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from kultuvator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTKAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from kultuvator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTKGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct ayaksayisi from kultuvator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTKAyakS.Items.Add(oku["ayaksayisi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from kultuvator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTKUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from kultuvator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTKGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from kultuvator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTKYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from kultuvator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTKMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from kultuvator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTKMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from kultuvator", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTKFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
