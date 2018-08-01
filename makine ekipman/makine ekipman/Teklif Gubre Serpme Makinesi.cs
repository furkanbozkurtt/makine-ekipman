using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
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
    public partial class Teklif_Gubre_Serpme_Makinesi : Form
    {
        public Teklif_Gubre_Serpme_Makinesi()
        {
            InitializeComponent();
        }

        public static string TGGTip;
        public static string TGGKApasite;
        public static string TGGAgirlik;
        public static string TGGGuc;
        public static string TGGisg;
        public static string TGGUzunluk;
        public static string TGGGenislik;
        public static string TGGYuksek;
        public static string TGGMarka;
        public static string TGGMensei;
        public static string TGGFiyat;



        private void button1_Click(object sender, EventArgs e)
        {

            TGGTip = TTGSTip.SelectedItem.ToString();
            TGGKApasite= TTGSKapasite.SelectedItem.ToString();
            TGGAgirlik=TTGSAgirlik.SelectedItem.ToString();
            TGGGuc=TTGSGuc.SelectedItem.ToString();
            TGGisg=TTGSIsgenisligi.SelectedItem.ToString();
            TGGUzunluk=TTGSUzunluk.SelectedItem.ToString();
            TGGGenislik=TTGSGenislik.SelectedItem.ToString();
            TGGYuksek=TTGSYukseklik.SelectedItem.ToString();
            TGGMarka=TTGSMarkaM.SelectedItem.ToString();
            TGGMensei=TTGSMensei.SelectedItem.ToString();
            TGGFiyat=TTGSFiyat.SelectedItem.ToString();



            this.Close();
            
        }

        private void Teklif_Gubre_Serpme_Makinesi_Load(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from gubreserpmemakinesi", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGSTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct kapasite from gubreserpmemakinesi ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGSKapasite.Items.Add(oku["kapasite"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct agirlik from gubreserpmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGSAgirlik.Items.Add(oku["agirlik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from gubreserpmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGSGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct isgenisligi from gubreserpmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGSIsgenisligi.Items.Add(oku["isgenisligi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from gubreserpmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGSUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from gubreserpmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGSGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from gubreserpmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGSYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from gubreserpmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGSMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from gubreserpmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGSMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from gubreserpmemakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTGSFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
