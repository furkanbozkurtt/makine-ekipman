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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public static string TDTip;
        public static string TDCD;
        public static string TDGuc;
        public static string TDAyak;
        public static string TDSasi;
        public static string TDuzun;
        public static string TDGenis;
        public static string TDYuksek;
        public static string TDMarka;
        public static string TDMensei;
        public static string TDFiyat;




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TDTip = TTDTip.SelectedItem.ToString();
            TDCD = TTDCalismaD.SelectedItem.ToString();
            TDGuc=TTDGuc.SelectedItem.ToString();
            TDAyak= TTDAyakS.SelectedItem.ToString();
            TDSasi=TTDSasi.SelectedItem.ToString();
            TDuzun = TTDUzunluk.SelectedItem.ToString();
            TDGenis = TTDGenislik.SelectedItem.ToString();
            TDYuksek = TTDYukseklik.SelectedItem.ToString();
            TDMarka = TTDMarkaM.SelectedItem.ToString();
            TDMensei = TTDMensei.SelectedItem.ToString();
            TDFiyat = TTDFiyat.SelectedItem.ToString();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from dipkazan", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTDTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct calismaderinligi from dipkazan", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTDCalismaD.Items.Add(oku["calismaderinligi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from dipkazan", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTDGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct ayaksayisi from dipkazan", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTDAyakS.Items.Add(oku["ayaksayisi"]);
            }
            baglan.Close();
            baglan.Open();
            cmd = new MySqlCommand("select distinct sasiyuksekligi from dipkazan", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTDSasi.Items.Add(oku["sasiyuksekligi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from dipkazan", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTDUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from dipkazan", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTDGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from dipkazan", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTDYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from dipkazan", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTDMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from dipkazan", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTDMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from dipkazan", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTDFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();

            
        }
    }
}
