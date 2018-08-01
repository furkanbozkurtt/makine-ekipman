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
    public partial class Teklif_İlaclama_Makinesi : Form
    {
        public Teklif_İlaclama_Makinesi()
        {
            InitializeComponent();
        }
        public static string TITip;
        public static string TIGuc;
        public static string TIKapasite;
        public static string TIDebi;
        public static string TIMarka;
        public static string TIMensei;
        public static string TIFiyat;

        private void button1_Click(object sender, EventArgs e)
        {
            TITip = TTITip.SelectedItem.ToString();
            TIGuc = TTIGuc.SelectedItem.ToString();
            TIKapasite=TTIKapasite.SelectedItem.ToString();
            TIDebi= TTIDebi.SelectedItem.ToString();
            TIMarka= TTIMarkaM.SelectedItem.ToString();
            TIMensei= TTIMensei.SelectedItem.ToString();
            TIFiyat= TTIFiyat.SelectedItem.ToString();
            this.Close();
        }

        private void Teklif_İlaclama_Makinesi_Load(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct tip from ilaclamamakinesi", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTITip.Items.Add(oku["tip"]);
            }
            baglan.Close();

           

            baglan.Open();
            cmd = new MySqlCommand("select distinct guc from ilaclamamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTIGuc.Items.Add(oku["guc"]);
            }
            baglan.Close();

           
            baglan.Open();
            cmd = new MySqlCommand("select distinct kapasite from ilaclamamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTIKapasite.Items.Add(oku["kapasite"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct debi from ilaclamamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTIDebi.Items.Add(oku["debi"]);
            }
            baglan.Close();

            

            baglan.Open();
            cmd = new MySqlCommand("select distinct markamodel from ilaclamamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTIMarkaM.Items.Add(oku["markamodel"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct mensei from ilaclamamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTIMensei.Items.Add(oku["mensei"]);
            }
            baglan.Close();

            baglan.Open();
            cmd = new MySqlCommand("select distinct fiyat from ilaclamamakinesi", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                TTIFiyat.Items.Add(oku["fiyat"]);
            }
            baglan.Close();
        }
    }
}
