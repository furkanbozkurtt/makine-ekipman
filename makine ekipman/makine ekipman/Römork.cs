using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class Teklif_Romork : Form
    {
        public Teklif_Romork()
        {
            InitializeComponent();
        }

        private void Teklif_Romork_Load(object sender, EventArgs e)
        {

            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from romork", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRTip.Items.Add(oku["tip"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct dingilsayisi from romork ", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRDingil.Items.Add(oku["dingilsayisi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct kapasite from romork", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRKapasite.Items.Add(oku["kapasite"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct tekersayisi from romork", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRTeker.Items.Add(oku["tekersayisi"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct lastikebatlari from romork", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRLastik.Items.Add(oku["lastikebatlari"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct uzunluk from romork", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRUzunluk.Items.Add(oku["uzunluk"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct genislik from romork", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRGenislik.Items.Add(oku["genislik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct yukseklik from romork", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRYukseklik.Items.Add(oku["yukseklik"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from romork", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from romork", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from romork", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTRFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
