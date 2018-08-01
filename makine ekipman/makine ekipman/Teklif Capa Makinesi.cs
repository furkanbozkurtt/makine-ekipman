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
    public partial class Teklif_Capa_Makinesi : Form
    {
        public Teklif_Capa_Makinesi()
        {
            InitializeComponent();
        }
        public static string TCTip;
        public static string TCAgir;
        public static string TCGuc;
        public static string TCBS;
        public static string TCUzun;
        public static string TCGenis;
        public static string TCYuksek;
        public static string TCMarka;
        public static string TCMensei;
        public static string TCFiyat;

            private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            TCAgir = TTCAgirlik.SelectedItem.ToString();
            TCTip = TTCTip.SelectedItem.ToString(); 
            TCGuc = TTCGuc.SelectedItem.ToString();
            TCBS = TTCBıcakS.SelectedItem.ToString();
            TCUzun = TTCUzunluk.SelectedItem.ToString();
            TCGenis = TTCGenislik.SelectedItem.ToString();
            TCYuksek = TTCYukseklik.SelectedItem.ToString();
            TCMarka = TTCMarkaM.SelectedItem.ToString();
            TCMensei = TTCMensei.SelectedItem.ToString();
            TCFiyat = TTCFiyat.SelectedItem.ToString();


        }

        private void Teklif_Capa_Makinesi_Load(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from capamakinesi", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTCTip.Items.Add(oku["tip"]);
            }
            baglan.Close();
            
            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from capamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTCAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from capamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTCGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct ayaksayisi from capamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTCBıcakS.Items.Add(oku["ayaksayisi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from capamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTCUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from capamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTCGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from capamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTCYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from capamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTCMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from capamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTCMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from capamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTCFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close(); 
        }
    }
}
