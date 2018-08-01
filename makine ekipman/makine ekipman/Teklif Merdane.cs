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
    public partial class Teklif_Merdane : Form
    {
        public Teklif_Merdane()
        {
            InitializeComponent();
        }

        public static string TMTip;
        public static string TMisg;
        public static string TMgenis;
        public static string TMagir;
        public static string TMguc;
        public static string TMcap;
        public static string TMuzun;
        public static string TMsira;
        public static string TMyuksek;
        public static string TMMarka;
        public static string TMMensei;
        public static string TMFiyat;

        private void button1_Click(object sender, EventArgs e)
        {

            TMTip = TTMTip.SelectedItem.ToString();
            TMisg= TTMIsG.SelectedItem.ToString();
            TMgenis= TTMGenislik.SelectedItem.ToString(); 
            TMagir= TTMAgirlik.SelectedItem.ToString();
            TMguc= TTMGuc.SelectedItem.ToString();
            TMcap= TTMCap.SelectedItem.ToString();
            TMuzun= TTMUzunluk.SelectedItem.ToString();
            TMsira= TTMSira.SelectedItem.ToString();
            TMyuksek= TTMYukseklik.SelectedItem.ToString();
            TMMarka= TTMMarkaM.SelectedItem.ToString();
            TMMensei = TTMMensei.SelectedItem.ToString();
            TMFiyat = TTMFiyat.SelectedItem.ToString();
            this.Close();
        }

        private void Teklif_Merdane_Load(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from merdane", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct isgenisligi from merdane ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMIsG.Items.Add(oku["isgenisligi"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from merdane ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from merdane", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from merdane", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct cap from merdane", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMCap.Items.Add(oku["cap"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from merdane", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct sira from merdane", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMSira.Items.Add(oku["sira"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from merdane", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from merdane", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from merdane", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from merdane", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTMFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
