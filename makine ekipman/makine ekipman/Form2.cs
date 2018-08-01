using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        fonksiyonlar fonk = new fonksiyonlar();

       



        public void Form2_Load(object sender, EventArgs e)
        {

           
        }

        public void btnGoster_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "Biçme Makinesi")
            {
                //  Bicme goster1 = new Bicme();
                // goster1.Show();
                Teklif_Bicme_Makinesi goster1 = new Teklif_Bicme_Makinesi();
                goster1.Show();
            }

            if (comboBox1.Text == "Çapa Makinesi")
            {
                Teklif_Capa_Makinesi goster1 = new Teklif_Capa_Makinesi();
                goster1.Show();



            }
            if (comboBox1.Text == "Dip Kazan")
            {
                Form4 goster1 = new Form4();
                goster1.Show();
            }

            if (comboBox1.Text == "Ekim Makinesi")
            {
                Teklif_Ekim_Makinesi goster1 = new Teklif_Ekim_Makinesi();
                goster1.Show();

            }

            if (comboBox1.Text == "Goble")
            {
                Teklif_Goble goster1 = new Teklif_Goble();
                goster1.Show();
            }

            if (comboBox1.Text == "Gübre Serpme Makinesi")
            {
                /*
                 itemizle();
                 MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                 baglan.Open();
                 MySqlCommand cmd = new MySqlCommand("select distinct tip from gubreserpmemakinesi", baglan);
                 MySqlDataReader oku = cmd.ExecuteReader();
                 while (oku.Read())
                 {
                     cmbTip.Items.Add(oku["tip"]);
                 }
                 baglan.Close();

                 baglan.Open();
                 cmd = new MySqlCommand("select distinct kapasite from gubreserpmemakinesi ", baglan);
                 oku = cmd.ExecuteReader();
                 while (oku.Read())
                 {
                     cmbKapasite.Items.Add(oku["kapasite"]);
                 }
                 baglan.Close();

                 baglan.Open();
                 cmd = new MySqlCommand("select distinct agirlik from gubreserpmemakinesi", baglan);
                 oku = cmd.ExecuteReader();
                 while (oku.Read())
                 {
                     cmbAgirlik.Items.Add(oku["agirlik"]);
                 }
                 baglan.Close();

                 baglan.Open();
                 cmd = new MySqlCommand("select distinct guc from gubreserpmemakinesi", baglan);
                 oku = cmd.ExecuteReader();
                 while (oku.Read())
                 {
                     cmbGuc.Items.Add(oku["guc"]);
                 }
                 baglan.Close();

                 baglan.Open();
                 cmd = new MySqlCommand("select distinct isgenisligi from gubreserpmemakinesi", baglan);
                 oku = cmd.ExecuteReader();
                 while (oku.Read())
                 {
                     cmbisgenislik.Items.Add(oku["isgenisligi"]);
                 }
                 baglan.Close();

                 baglan.Open();
                 cmd = new MySqlCommand("select distinct uzunluk from gubreserpmemakinesi", baglan);
                 oku = cmd.ExecuteReader();
                 while (oku.Read())
                 {
                     cmbUzunluk.Items.Add(oku["uzunluk"]);
                 }
                 baglan.Close();

                 baglan.Open();
                 cmd = new MySqlCommand("select distinct genislik from gubreserpmemakinesi", baglan);
                 oku = cmd.ExecuteReader();
                 while (oku.Read())
                 {
                     cmbGenislik.Items.Add(oku["genislik"]);
                 }
                 baglan.Close();

                 baglan.Open();
                 cmd = new MySqlCommand("select distinct yukseklik from gubreserpmemakinesi", baglan);
                 oku = cmd.ExecuteReader();
                 while (oku.Read())
                 {
                     cmbYukseklik.Items.Add(oku["yukseklik"]);
                 }
                 baglan.Close();

                 baglan.Open();
                 cmd = new MySqlCommand("select distinct markamodel from gubreserpmemakinesi", baglan);
                 oku = cmd.ExecuteReader();
                 while (oku.Read())
                 {
                     cmbMarka.Items.Add(oku["markamodel"]);
                 }
                 baglan.Close();

                 baglan.Open();
                 cmd = new MySqlCommand("select distinct mensei from gubreserpmemakinesi", baglan);
                 oku = cmd.ExecuteReader();
                 while (oku.Read())
                 {
                     cmbMensei.Items.Add(oku["mensei"]);
                 }
                 baglan.Close();

                 baglan.Open();
                 cmd = new MySqlCommand("select distinct fiyat from gubreserpmemakinesi", baglan);
                 oku = cmd.ExecuteReader();
                 while (oku.Read())
                 {
                     cmbFiyat.Items.Add(oku["fiyat"]);
                 }
                 baglan.Close();*/
                Teklif_Gubre_Serpme_Makinesi goster1 = new Teklif_Gubre_Serpme_Makinesi();
                goster1.Show();

            }

            if (comboBox1.Text == "İlaçlama Makinesi")
            {
                Teklif_İlaclama_Makinesi goster1 = new Teklif_İlaclama_Makinesi();
                goster1.Show();
            }

            if (comboBox1.Text == "Kultuvatör")
            {
                Teklif_Kultuvator_Makinesi goster1 = new Teklif_Kultuvator_Makinesi();
                goster1.Show();

            }

            if (comboBox1.Text == "Merdane")
            {
                Teklif_Merdane goster1 = new Teklif_Merdane();
                goster1.Show();
            }

            if (comboBox1.Text == "Pulluk")
            {
                Teklif_Pulluk goster1 = new Teklif_Pulluk();
                goster1.Show();
            }

            if (comboBox1.Text == "Römork")
            {
                Teklif_Romork goster1 = new Teklif_Romork();
                goster1.Show();
            }

            if (comboBox1.Text == "Rotovatör")
            {
                Teklif_Rotovator goster1 = new Teklif_Rotovator();
                goster1.Show();
            }

            if (comboBox1.Text == "Tesviye Küreği")
            {
                Teklif_Tesfiye_Kuregi goster1 = new Teklif_Tesfiye_Kuregi();
                goster1.Show();
            }

            if (comboBox1.Text == "Tırmık")
            {
                Teklif_Tırmık goster1 = new Teklif_Tırmık();
                goster1.Show();
            }

            if (comboBox1.Text == "Yükleme Kepçesi")
            {
                Teklif_Yukleme_Kepcesi goster1 = new Teklif_Yukleme_Kepcesi();
                goster1.Show();
            }
        }

       
    }
}
 