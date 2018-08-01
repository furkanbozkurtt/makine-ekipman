using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wordeaktar = Microsoft.Office.Interop.Word;
using System.Reflection;
using MySql.Data.MySqlClient;
using MySQL.Data;
using table = Microsoft.Office.Interop.Word.Table;

namespace makine_ekipman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        fonksiyonlar fonk = new fonksiyonlar();

        public void itemizle()
        {
            txtAgirlik.Clear();
            txtAyak.Clear();
            txtBicak.Clear();
            txtCalisma.Clear();
            txtCap.Clear();
            txtDebi.Clear();
            txtDingil.Clear();
            txtDis.Clear();
            txtDisk.Clear();
            txtFiyat.Clear();
            txtGenislik.Clear();
            txtGovde.Clear();
            txtGuc.Clear();
            txtişderinligi.Clear();
            txtişGenislik.Clear();
            txtKapasite.Clear();
            txtLastik.Clear();
            txtMarka.Clear();
            txtMensei.Clear();
            txtSac.Clear();
            txtSasi.Clear();
            txtSira.Clear();
            txtTeker.Clear();
            txtTip.Clear();
            txtUzunluk.Clear();
            txtYukseklik.Clear();
            txtYon.Clear();
            cmbFirmag.Items.Clear();

        }

        public void temizle()
        {
            lblTip.Visible = false;
            txtTip.Visible = false;
            lblUzunluk.Visible = false;
            txtUzunluk.Visible = false;
            lblYukseklik.Visible = false;
            txtYukseklik.Visible = false;
            lblYon.Visible = false;
            txtYon.Visible = false;
            lblÇderinlik.Visible = false;
            txtişderinligi.Visible = false;
            lblÇgenislik.Visible = false;
            txtişGenislik.Visible = false;
            lblTeker.Visible = false;
            txtTeker.Visible = false;
            lblSasi.Visible = false;
            txtSasi.Visible = false;
            lblSac.Visible = false;
            txtSac.Visible = false;
            lblMensei.Visible = false;
            txtMensei.Visible = false;
            lblMarka.Visible = false;
            txtMarka.Visible = false;
            lblLastik.Visible = false;
            txtLastik.Visible = false;
            lblKapasite.Visible = false;
            txtKapasite.Visible = false;
            lblGuc.Visible = false;
            txtGuc.Visible = false;
            lblGovde.Visible = false;
            txtGovde.Visible = false;
            lblFiyat.Visible = false;
            txtFiyat.Visible = false;
            lblDisk.Visible = false;
            txtDisk.Visible = false;
            lblDis.Visible = false;
            txtDis.Visible = false;
            lblDingil.Visible = false;
            txtDingil.Visible = false;
            lblDebi.Visible = false;
            txtDebi.Visible = false;
            lblCap.Visible = false;
            txtCap.Visible = false;
            lblCalisma.Visible = false;
            txtCalisma.Visible = false;
            lblBicakS.Visible = false;
            txtBicak.Visible = false;
            lblAgirlik.Visible = false;
            txtAgirlik.Visible = false;
            lblGenislik.Visible = false;
            txtGenislik.Visible = false;
            lblSira.Visible = false;
            txtSira.Visible = false;
            lblAyak.Visible = false;
            txtAyak.Visible = false;
            lblFirmaG.Visible = false;
            cmbFirmag.Visible = false;

        }


                public static string TadSoyad;
                public static string TAdres;
                public static string Tetarih;
                public static string Datarih;
                public static string fadi;
                public static long sonuc;
        public void btnTeklif_Click(object sender, EventArgs e)
        {
            
             //TadSoyad = txtTAdSoyad.Text;
           //  TAdres = txtTAdres.Text;
             Tetarih = TTarih.Text;
           // string Firmaismi = txtTFirma.Text;
           //  Datarih = DavetTarih.Text;

             fadi = cmbFsec.SelectedItem.ToString();
             sonuc=0;
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select vergino from firma where"+fadi, baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                    sonuc = Convert.ToInt64(oku["vergino"]);
            }
            baglan.Close();
            string fadrres="";
            baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            cmd = new MySqlCommand("select adres from firma where" + fadi, baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                fadrres = oku["adres"].ToString();
            }
            baglan.Close();
            long ftell = 0;
            baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            cmd = new MySqlCommand("select telefon from firma where" + fadi, baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ftell = Convert.ToInt64(oku["telefon"]);
            }
            baglan.Close();
            string fverggi = "";
            baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            cmd = new MySqlCommand("select vergidairesi from firma where" + fadi, baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                fverggi = oku["vergidairesi"].ToString();
            }
            baglan.Close();
            int ffaxx = 0;
            baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            cmd = new MySqlCommand("select faks from firma where" + fadi, baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ffaxx = Convert.ToInt32(oku["faks"]);
            }
            int fticariss = 0;
            baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            cmd = new MySqlCommand("select ticarisicilno from firma where" + fadi, baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                fticariss = Convert.ToInt32(oku["ticarisicilno"]);
            }
            string fpost = "";
            baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            cmd = new MySqlCommand("select eposta from firma where" + fadi, baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                fpost = oku["eposta"].ToString();
            }




            DateTime elligun = Convert.ToDateTime(Datarih);
            elligun = elligun.AddDays(50);
            DateTime Tetarih2 = Convert.ToDateTime(Tetarih);
            DateTime Datarih2 = Convert.ToDateTime(Datarih);
            wordeaktar.Application wordapp = new wordeaktar.Application();
            wordapp.Visible = true;
            wordeaktar.Document worddoc;
            object objmissing = System.Reflection.Missing.Value;
            worddoc = wordapp.Documents.Add(ref objmissing);
            wordapp.Selection.Font.Size = 10;
            wordapp.Selection.Font.Name = "arial";
            //Form2 goster = new Form2();
            //goster.Show();



            object objMiss = System.Reflection.Missing.Value;
            object objEndOfDocFlag = "\\endofdoc"; 
            wordeaktar.Table objtab2;
            wordeaktar.Range objWordRng1 = worddoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            objtab2 = worddoc.Tables.Add(objWordRng1, 4, 4, ref objMiss, ref objMiss);
            objtab2.Borders.Enable = 1;
            objtab2.Range.ParagraphFormat.SpaceAfter = 6;
            objtab2.Cell(1, 1).Range.Text = "Firma Adı";
            objtab2.Cell(1, 2).Range.Text = fadi;
            objtab2.Cell(1, 3).Range.Text = "Adresi";
            objtab2.Cell(1, 4).Range.Text = fadrres;
            objtab2.Cell(2, 1).Range.Text = "Vergi No";
            objtab2.Cell(2, 2).Range.Text = ""+sonuc;
            objtab2.Cell(2, 3).Range.Text = "Telefon";
            objtab2.Cell(2, 4).Range.Text = ""+ftell;
            objtab2.Cell(3, 1).Range.Text = "Vergi Dairesi";
            objtab2.Cell(3, 2).Range.Text = ""+fverggi;
            objtab2.Cell(3, 3).Range.Text = "Faks";
            objtab2.Cell(3, 4).Range.Text = ""+ffaxx;
            objtab2.Cell(4, 1).Range.Text = "Ticari Sicil No";
            objtab2.Cell(4, 2).Range.Text = ""+fticariss;
            objtab2.Cell(4, 3).Range.Text = "E-posta";// +fonk.secimlerCoklu("Biçme Makinesi");
            objtab2.Cell(4, 4).Range.Text = ""+fpost;
            objtab2.Rows[1].Range.Font.Bold = 1;
            objtab2.Rows[1].Range.Font.Italic = 1;


            wordeaktar.Paragraph paragraf1;
            paragraf1 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf1.Range.Text = ("\n\n\n\n                                     MAKİNE/EKİPMAN İÇİN TEKLİF SUNUM FORMU");
            paragraf1.Range.Font.Bold = 1;
            paragraf1.Range.InsertParagraphAfter();
            worddoc.Paragraphs[1].Alignment = //burda sağa dayalı merkezde felan olacagı belirtiliyor 2 satır.
                 wordeaktar.WdParagraphAlignment.wdAlignParagraphCenter;

            wordeaktar.Paragraph paragraf2;
            paragraf2 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf2.Range.Text = (TadSoyad);
            paragraf2.Range.Font.Bold = 1;
            paragraf2.Range.InsertParagraphAfter();
            worddoc.Paragraphs[2].Alignment =
                wordeaktar.WdParagraphAlignment.wdAlignParagraphLeft;

            wordeaktar.Paragraph paragraf3;
            paragraf3 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf3.Range.Text = (TAdres);
            paragraf3.Range.Font.Bold = 1;
            paragraf3.Range.InsertParagraphAfter();
            worddoc.Paragraphs[3].Alignment =
                wordeaktar.WdParagraphAlignment.wdAlignParagraphLeft;

            wordeaktar.Paragraph paragraf4;
            paragraf4 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf4.Range.Text = ("         " + yatirim + " yatırımı kapsamında " + Datarih2.ToShortDateString() + " tarihli davet mektubunuz ile istemiş  olduğunuz\n Makine/Ekipman alımına ilişkin fiyat teklifimiz,teklif davet mektubunu ve eklerinde \n belirtilen şartların tamamına uygun ve " + elligun.ToShortDateString() + " tarihine kadar geçerli olmak üzere bilgilerinize sunulmuştur \n\n\n\n\n\n");
            paragraf4.Range.Font.Bold = 1;
            paragraf4.Range.InsertParagraphAfter();
            worddoc.Paragraphs[4].Alignment =
                wordeaktar.WdParagraphAlignment.wdAlignParagraphLeft;

            wordeaktar.Paragraph paragraf5;
            paragraf5 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf5.Range.Text = ("1. Teklif Fiyatları \n2. Teklife İlişkin Beyanlar ve Taahhütler \n3. Teklif Davet Mektubunun İmzalanmış Fotokopisi \n4. Teknik Şartnamenin İmzalanmış Fotokopisi \n5. Nüfus Cüzdan Fotokopisi \n6.Faaliyet Belgesi \n\n\n\n\n\n\n\n\n\n\n\n  ");
            paragraf5.Range.Font.Bold = 1;
            paragraf5.Range.InsertParagraphAfter();
            worddoc.Paragraphs[5].Alignment =
                wordeaktar.WdParagraphAlignment.wdAlignParagraphLeft;

            wordeaktar.Paragraph paragraf6;
            paragraf6 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf6.Range.Text = ("                                         TEKLİFE İLİŞKİN BEYANLAR VE TAAHHÜTLER");
            paragraf6.Range.Font.Bold = 1;
            paragraf6.Range.InsertParagraphAfter();
            worddoc.Paragraphs[6].Alignment =
                wordeaktar.WdParagraphAlignment.wdAlignParagraphCenter;
            
            wordeaktar.Paragraph paragraf7;
            paragraf7 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf7.Range.Text = ("\n1- Tarafınızca " + Datarih2.ToShortDateString() + " Tarihinde gönderilen teklif davet mektubu ve ekleri incelenmiş, okunmuş ve bütün koşullarıyla kabul edilmiştir. \n2- Teklif fiyatlarımız KDV ve tüm vergiler hariç olarak verilmiştir. Teklif fiyatlarımızda; malların varış \nyerine teslim giderleri, paketleme, sigorta, nakliye, ambalajdan çıkarma, kurma vb. giderler hariçtir. \n3- Teklifimiz" + elligun.ToShortDateString() + " tarihine kadar geçerlidir. \n4- Verdiğimiz teklif ve eklerinin mülkiyetinin başvuru sahibine ait olduğunu ve teklifimiz kabul edilmese bile bu belgeleri tekrar talep etmeyeceğimizi taahhüt ediyoruz. \n6- AB projeleri kapsamında yapılacak alımlara teklif vermeye engel durumlardan birine dahil olmadığımızı beyan ediyoruz. \n7- Teklif tarihi itibariyle başvuru sahibi ailevi, manevi, politik, milli, ekonomik veya menfaat \nsağlayan herhangi bir ortaklık veya ilişki içerisinde olmadığımızı beyan ediyoruz. \n8- Teklif geçerlilik süresi içerisinde yukarıda belirtilen koşullarda herhangi bir değişiklik olması durumunda başvuru sahibini derhal bilgilendireceğimizi beyan ediyoruz. \n");
            paragraf7.Range.Font.Bold = 1;
            paragraf7.Range.InsertParagraphAfter();
            worddoc.Paragraphs[7].Alignment =
                wordeaktar.WdParagraphAlignment.wdAlignParagraphLeft;

            wordeaktar.Paragraph paragraf8;
            paragraf8 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf8.Range.Text = ("                                         TEKLİF KAPSAMINDA SUNULAN TAAHHÜTLER VE BELGELER:");
            paragraf8.Range.Font.Bold = 1;
            paragraf8.Range.InsertParagraphAfter();
            worddoc.Paragraphs[8].Alignment =
                wordeaktar.WdParagraphAlignment.wdAlignParagraphCenter;

            wordeaktar.Paragraph paragraf9;
            paragraf9 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf9.Range.Text = ("Garanti ve Bakım Şartları :  \nHer ürün için gerekli Bakım Şartları, Kullanım Kılavuzunda veya ayrıca verilen Bakım Kılavuzunda belirtilecektir.\nGerekli bakımın periyodu, kimin tarafından nasıl yapılacağı kılavuzlarda belirtilecektir.\nServisin yapması gereken bakımlar ve arıza onarımı firmamızın teknik servisi tarafından verilecektir.\nKullanım Kılavuzu ve Eğitim \nÜrünlere ait Türkçe kullanım kılavuzları firmamız tarafından verilecektir.\nGerekli Yedek Parçalar \nFirmamız 10 yıl boyunca yedek parça ve servis garantisi erecektir. Garanti kapsamında değişecek parçalar en geç 5 gün içerisinde, garanti süresinden sonra en geç 10 gün içerisinde tarafımızdan temin edilecektir.");
            paragraf9.Range.Font.Bold = 1;
            paragraf9.Range.InsertParagraphAfter();
            worddoc.Paragraphs[9].Alignment =
                wordeaktar.WdParagraphAlignment.wdAlignParagraphLeft;

           // object objMiss = System.Reflection.Missing.Value;
           // object objEndOfDocFlag = "\\endofdoc"; 
            wordeaktar.Table objtab1;
            wordeaktar.Range objWordRng = worddoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            objtab1 = worddoc.Tables.Add(objWordRng, 5, 9, ref objMiss, ref objMiss);
            objtab1.Borders.Enable = 1;
            objtab1.Range.ParagraphFormat.SpaceAfter = 6;
           // int iRow, iCols;
            string strText;
            strText = "abc";
            objtab1.Cell(1, 1).Range.Text = strText;

            objtab1.Rows[1].Range.Font.Bold = 1;
            objtab1.Rows[1].Range.Font.Italic = 1;



            
            
        }   //teklif mektubu için word 

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Biçme Makinesi")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into bicmemakinesi (tip,agirlik,guc,uzunluk,genislik,yukseklik,bicaksayisi,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtAgirlik.Text + "','" + txtGuc.Text + "','" + txtUzunluk.Text + "','" + txtGenislik.Text + "','" + txtYukseklik.Text + "','" + txtBicak.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();

            }
            if (comboBox1.Text == "Çapa Makinesi")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into capamakinesi (tip,agirlik,guc,uzunluk,genislik,yukseklik,ayaksayisi,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtAgirlik.Text + "','" + txtGuc.Text + "','" + txtUzunluk.Text + "','" + txtGenislik.Text + "','" + txtYukseklik.Text + "','" + txtAyak.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();

            }

            if (comboBox1.Text == "Dip Kazan")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into dipkazan (tip,ayaksayisi,sasiyuksekligi,calismaderinligi,guc,uzunluk,genislik,yukseklik,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtAyak.Text + "','" + txtSasi.Text + "','" + txtCalisma.Text + "','" + txtGuc.Text + "','" + txtUzunluk.Text + "','" + txtGenislik.Text + "','" + txtYukseklik.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();

            }
            if (comboBox1.Text == "Ekim Makinesi")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into ekimmakinesi (tip,agirlik,guc,ayaksayisi,isgenisligi,genislik,yukseklik,uzunluk,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtAgirlik.Text + "','" + txtGuc.Text + "','" + txtAyak.Text + "','" + txtişGenislik.Text + "','" + txtGenislik.Text + "','" + txtYukseklik.Text + "','" + txtUzunluk.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();

            }
            if (comboBox1.Text == "Goble")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into goble (tip,agirlik,disksayisi,guc,uzunluk,genislik,yukseklik,isgenisligi,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtAgirlik.Text + "','" + txtDisk.Text + "','" + txtGuc.Text + "','" + txtUzunluk.Text + "','" + txtGenislik.Text + "','" + txtYukseklik.Text + "','" + txtişGenislik.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();
            }
            if (comboBox1.Text == "Gübre Serpme Makinesi")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into gubreserpmemakinesi (tip,agirlik,guc,isgenisligi,genislik,uzunluk,yukseklik,kapasite,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtAgirlik.Text + "','" + txtGuc.Text + "','" + txtişGenislik.Text + "','" + txtGenislik.Text + "','" + txtUzunluk.Text + "','" + txtYukseklik.Text + "','" + txtKapasite.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();
            }

            if (comboBox1.Text == "İlaçlama Makinesi")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into ilaclamamakinesi (tip,guc,kapasite,debi,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtGuc.Text + "','" + txtKapasite.Text + "','" + txtDebi.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();
            }

            if (comboBox1.Text == "Kultuvatör")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into kultuvator (tip,agirlik,guc,isgenisligi,ayaksayisi,genislik,yukseklik,uzunluk,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtAgirlik.Text + "','" + txtGuc.Text + "','" + txtişGenislik.Text + "','" + txtAyak.Text + "','" + txtGenislik.Text + "','" + txtYukseklik.Text + "','" + txtUzunluk.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();
            }


            if (comboBox1.Text == "Merdane")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into merdane (tip,agirlik,guc,isgenisligi,genislik,yukseklik,uzunluk,sira,cap,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtAgirlik.Text + "','" + txtGuc.Text + "','" + txtişGenislik.Text + "','" + txtGenislik.Text + "','" + txtYukseklik.Text + "','" + txtUzunluk.Text + "','" + txtSira.Text + "','" + txtCap.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();
            }

            if (comboBox1.Text == "Pulluk")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into pulluk (tip,agirlik,guc,isgenisligi,ayaksayisi,govdearasi,uzunluk,genislik,yukseklik,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtAgirlik.Text + "','" + txtGuc.Text + "','" + txtişGenislik.Text + "','" + txtAyak.Text + "','" + txtGovde.Text + "','" + txtUzunluk.Text + "','" + txtGenislik.Text + "','" + txtYukseklik.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();
            }

            if (comboBox1.Text == "Römork")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into romork (tip,kapasite,dingilsayisi,tekersayisi,uzunluk,genislik,yukseklik,lastikebatları,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtKapasite.Text + "','" + txtDingil.Text + "','" + txtTeker.Text + "','" + txtUzunluk.Text + "','" + txtGenislik.Text + "','" + txtYukseklik.Text + "','" + txtLastik.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();
            }

            if (comboBox1.Text == "Rotovatör")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into rotovator (tip,agirlik,guc,isgenisligi,bicaksayisi,isderinligi,genislik,yukseklik,uzunluk,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtAgirlik.Text + "','" + txtGuc.Text + "','" + txtişGenislik.Text + "','" + txtBicak.Text + "','" + txtişderinligi.Text + "','" + txtGenislik.Text + "','" + txtYukseklik.Text + "','" + txtUzunluk.Text + "','" + txtMarka.Text + "','" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();
            }

            if (comboBox1.Text == "Tesviye Küreği")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into tesviyekuregi (tip,isgenisligi,sackalinligi,yonlendirme,uzunluk,genislik,yukseklik,agirlik,guc,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtişGenislik.Text + "','" + txtSac.Text + "','" + txtYon.Text + "','" + txtUzunluk.Text + "','" + txtGenislik.Text + "','" + txtYukseklik.Text + "','" + txtAgirlik.Text + "','" + txtGuc.Text + "','" + txtMarka.Text + "', '" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();
            }


            if (comboBox1.Text == "Tırmık")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into tirmik (tip,agirlik,guc,genislik,uzunluk,yukseklik,isgenisligi,dissayisi,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtAgirlik.Text + "','" + txtGuc.Text + "','" + txtGenislik.Text + "','" + txtUzunluk.Text + "','" + txtYukseklik.Text + "','" + txtişGenislik.Text + "','" + txtDis.Text + "','" + txtMarka.Text + "', '" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();
            }


            if (comboBox1.Text == "Yükleme Kepçesi")
            {
                MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand("insert into yuklemekepcesi (tip,isgenisligi,uzunluk,yukseklik,agirlik,markamodel,mensei,fiyat,firmaadi) values ('" + txtTip.Text + "','" + txtişGenislik.Text + "','" + txtUzunluk.Text + "','" + txtYukseklik.Text + "','" + txtAgirlik.Text + "','" + txtMarka.Text + "', '" + txtMensei.Text + "','" + txtFiyat.Text + "','" + cmbFirmag.Text + "')  ", baglan);
                MySqlDataReader oku = cmd.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Urun başarıyla eklenmiştir");
                itemizle();
            }


        }       // ürün eklemek için sql sorgular

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)  
        {
            cmbFirmag.Items.Clear();
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct firmaadi from firma", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbFirmag.Items.Add(oku["firmaadi"]);
            }
            baglan.Close();


            if (comboBox1.Text == "Biçme Makinesi")
            {
                temizle();

                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(500, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(500, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblBicakS.Visible = true;
                lblBicakS.Location = new Point(500, 135);
                txtBicak.Visible = true;
                txtBicak.Location = new Point(575, 130);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 165);
                cmbFirmag.Location = new Point(575, 160);


            }

            if (comboBox1.Text == "Çapa Makinesi")
            {
                temizle();
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(500, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(500, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblAyak.Visible = true;
                lblAyak.Location = new Point(500, 135);
                txtAyak.Visible = true;
                txtAyak.Location = new Point(575, 130);
                lblBicakS.Visible = false;
                txtBicak.Visible = false;
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 165);
                cmbFirmag.Location = new Point(575, 160);

            }
            if (comboBox1.Text == "Dip Kazan")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblSasi.Visible = true;
                txtSasi.Visible = true;
                txtSasi.Location = new Point(180, 100);
                lblSasi.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(480, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(480, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblAyak.Visible = true;
                lblAyak.Location = new Point(480, 135);
                txtAyak.Visible = true;
                txtAyak.Location = new Point(575, 130);
                lblCalisma.Visible = true;
                lblCalisma.Location = new Point(480, 165);
                txtCalisma.Visible = true;
                txtCalisma.Location = new Point(575, 160);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(480, 195);
                cmbFirmag.Location = new Point(575, 190);

            }

            if (comboBox1.Text == "Ekim Makinesi")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(500, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(500, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblAyak.Visible = true;
                lblAyak.Location = new Point(500, 135);
                txtAyak.Visible = true;
                txtAyak.Location = new Point(575, 130);
                lblÇgenislik.Visible = true;
                txtişGenislik.Visible = true;
                lblÇgenislik.Location = new Point(500, 165);
                txtişGenislik.Location = new Point(575, 160);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 195);
                cmbFirmag.Location = new Point(575, 190);

            }

            if (comboBox1.Text == "Goble")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(500, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(500, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblDisk.Visible = true;
                lblDisk.Location = new Point(500, 135);
                txtDisk.Visible = true;
                txtDisk.Location = new Point(575, 130);
                lblÇgenislik.Visible = true;
                txtişGenislik.Visible = true;
                lblÇgenislik.Location = new Point(500, 165);
                txtişGenislik.Location = new Point(575, 160);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 195);
                cmbFirmag.Location = new Point(575, 190);

            }

            if (comboBox1.Text == "Gübre Serpme Makinesi")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(500, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(500, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblKapasite.Visible = true;
                lblKapasite.Location = new Point(500, 135);
                txtKapasite.Visible = true;
                txtKapasite.Location = new Point(575, 130);
                lblÇgenislik.Visible = true;
                txtişGenislik.Visible = true;
                lblÇgenislik.Location = new Point(500, 165);
                txtişGenislik.Location = new Point(575, 160);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 195);
                cmbFirmag.Location = new Point(575, 190);

            }

            if (comboBox1.Text == "İlaçlama Makinesi")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 100);
                lblGuc.Location = new Point(55, 105);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 130);
                lblMarka.Location = new Point(55, 135);
                lblMensei.Visible = true;
                txtMensei.Visible = true;
                txtMensei.Location = new Point(180, 160);
                lblMensei.Location = new Point(55, 165);
                lblFiyat.Visible = true;
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(180, 190);
                lblFiyat.Location = new Point(55, 195);
                lblKapasite.Visible = true;
                txtKapasite.Visible = true;
                txtKapasite.Location = new Point(180, 220);
                lblKapasite.Location = new Point(55, 225);
                lblDebi.Visible = true;
                txtDebi.Visible = true;
                txtDebi.Location = new Point(180, 250);
                lblDebi.Location = new Point(55, 255);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(55, 285);
                cmbFirmag.Location = new Point(180, 280);

            }

            if (comboBox1.Text == "Kultuvatör")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(500, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(500, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblAyak.Visible = true;
                lblAyak.Location = new Point(500, 135);
                txtAyak.Visible = true;
                txtAyak.Location = new Point(575, 130);
                lblÇgenislik.Visible = true;
                lblÇgenislik.Location = new Point(500, 165);
                txtişGenislik.Visible = true;
                txtişGenislik.Location = new Point(575, 160);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 195);
                cmbFirmag.Location = new Point(575, 190);

            }

            if (comboBox1.Text == "Merdane")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(500, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(500, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblÇgenislik.Visible = true;
                lblÇgenislik.Location = new Point(500, 135);
                txtişGenislik.Visible = true;
                txtişGenislik.Location = new Point(575, 130);
                lblSira.Visible = true;
                txtSira.Visible = true;
                lblSira.Location = new Point(500, 165);
                txtSira.Location = new Point(575, 160);
                lblCap.Visible = true;
                lblCap.Location = new Point(500, 195);
                txtCap.Visible = true;
                txtCap.Location = new Point(575, 190);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 225);
                cmbFirmag.Location = new Point(575, 220);

            }

            if (comboBox1.Text == "Pulluk")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(500, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(500, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblAyak.Visible = true;
                lblAyak.Location = new Point(500, 135);
                txtAyak.Visible = true;
                txtAyak.Location = new Point(575, 130);
                lblÇgenislik.Visible = true;
                txtişGenislik.Visible = true;
                lblÇgenislik.Location = new Point(500, 165);
                txtişGenislik.Location = new Point(575, 160);
                lblGovde.Visible = true;
                lblGovde.Location = new Point(500, 195);
                txtGovde.Visible = true;
                txtGovde.Location = new Point(575, 190);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 225);
                cmbFirmag.Location = new Point(575, 220);

            }

            if (comboBox1.Text == "Römork")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblUzunluk.Visible = true;
                lblUzunluk.Location = new Point(55, 105);
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 100);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 130);
                lblGenislik.Location = new Point(55, 135);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 160);
                lblYukseklik.Location = new Point(55, 165);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 190);
                lblMarka.Location = new Point(55, 195);
                lblMensei.Visible = true;
                txtMensei.Visible = true;
                txtMensei.Location = new Point(180, 220);
                lblMensei.Location = new Point(55, 225);
                lblFiyat.Visible = true;
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(180, 250);
                lblFiyat.Location = new Point(55, 255);
                txtKapasite.Visible = true;
                txtKapasite.Location = new Point(575, 70);
                lblKapasite.Visible = true;
                lblKapasite.Location = new Point(500, 75);
                lblDingil.Visible = true;
                lblDingil.Location = new Point(500, 105);
                txtDingil.Visible = true;
                txtDingil.Location = new Point(575, 100);
                lblTeker.Visible = true;
                lblTeker.Location = new Point(500, 135);
                txtTeker.Visible = true;
                txtTeker.Location = new Point(575, 130);
                lblLastik.Visible = true;
                txtLastik.Visible = true;
                lblLastik.Location = new Point(500, 165);
                txtLastik.Location = new Point(575, 160);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 195);
                cmbFirmag.Location = new Point(575, 190);

            }

            if (comboBox1.Text == "Rotovatör")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(500, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(500, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblBicakS.Visible = true;
                lblBicakS.Location = new Point(500, 135);
                txtBicak.Visible = true;
                txtBicak.Location = new Point(575, 130);
                lblÇgenislik.Visible = true;
                lblÇgenislik.Location = new Point(500, 165);
                txtişGenislik.Visible = true;
                txtişGenislik.Location = new Point(575, 160);
                lblÇderinlik.Visible = true;
                lblÇderinlik.Location = new Point(500, 195);
                txtişderinligi.Visible = true;
                txtişderinligi.Location = new Point(575, 190);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 225);
                cmbFirmag.Location = new Point(575, 220);

            }

            if (comboBox1.Text == "Tesviye Küreği")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(500, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(500, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblÇgenislik.Visible = true;
                lblÇgenislik.Location = new Point(500, 135);
                txtişGenislik.Visible = true;
                txtişGenislik.Location = new Point(575, 130);
                lblSac.Visible = true;
                lblSac.Location = new Point(500, 165);
                txtSac.Visible = true;
                txtSac.Location = new Point(575, 160);
                lblYon.Visible = true;
                lblYon.Location = new Point(500, 195);
                txtYon.Visible = true;
                txtYon.Location = new Point(575, 190);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 225);
                cmbFirmag.Location = new Point(575, 220);

            }

            if (comboBox1.Text == "Tırmık")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblGuc.Visible = true;
                txtGuc.Visible = true;
                txtGuc.Location = new Point(180, 130);
                lblGuc.Location = new Point(55, 135);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 160);
                lblUzunluk.Location = new Point(55, 165);
                lblGenislik.Visible = true;
                txtGenislik.Visible = true;
                txtGenislik.Location = new Point(180, 190);
                lblGenislik.Location = new Point(55, 195);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 220);
                lblYukseklik.Location = new Point(55, 225);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 250);
                lblMarka.Location = new Point(55, 255);
                txtMensei.Visible = true;
                txtMensei.Location = new Point(575, 70);
                lblMensei.Visible = true;
                lblMensei.Location = new Point(500, 75);
                lblFiyat.Visible = true;
                lblFiyat.Location = new Point(500, 105);
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(575, 100);
                lblÇgenislik.Visible = true;
                lblÇgenislik.Location = new Point(500, 135);
                txtişGenislik.Visible = true;
                txtişGenislik.Location = new Point(575, 130);
                lblDis.Visible = true;
                lblDis.Location = new Point(500, 165);
                txtDis.Visible = true;
                txtDis.Location = new Point(575, 160);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 195);
                cmbFirmag.Location = new Point(575, 190);

            }

            if (comboBox1.Text == "Yükleme Kepçesi")
            {
                temizle();
                lblTip.Visible = true;
                txtTip.Visible = true;
                lblTip.Location = new Point(55, 75);
                txtTip.Location = new Point(180, 70);
                lblAgirlik.Visible = true;
                txtAgirlik.Visible = true;
                txtAgirlik.Location = new Point(180, 100);
                lblAgirlik.Location = new Point(55, 105);
                lblUzunluk.Visible = true;
                txtUzunluk.Visible = true;
                txtUzunluk.Location = new Point(180, 130);
                lblUzunluk.Location = new Point(55, 135);
                lblYukseklik.Visible = true;
                txtYukseklik.Visible = true;
                txtYukseklik.Location = new Point(180, 160);
                lblYukseklik.Location = new Point(55, 165);
                lblMarka.Visible = true;
                txtMarka.Visible = true;
                txtMarka.Location = new Point(180, 190);
                lblMarka.Location = new Point(55, 195);
                lblMensei.Visible = true;
                txtMensei.Visible = true;
                txtMensei.Location = new Point(180, 220);
                lblMensei.Location = new Point(55, 225);
                lblFiyat.Visible = true;
                txtFiyat.Visible = true;
                txtFiyat.Location = new Point(180, 250);
                lblFiyat.Location = new Point(55, 255);
                txtişGenislik.Visible = true;
                txtişGenislik.Location = new Point(575, 70);
                lblÇgenislik.Visible = true;
                lblÇgenislik.Location = new Point(500, 75);
                lblFirmaG.Visible = true;
                cmbFirmag.Visible = true;
                lblFirmaG.Location = new Point(500, 105);
                cmbFirmag.Location = new Point(575, 100);

            }




        }   //ürün ekle kısmında seçilen ürünün özelliklerini gösterir

        private void tabMalEkle_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
          MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
           baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select firmaadi from firma", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
         /*  while (oku.Read())
            {
                cmbFsec.Items.Add(oku["firmaadi"]);
                
            }*/
            baglan.Close();


            temizle();
            baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            cmd = new MySqlCommand("select distinct firmaadi from firma", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbFirma.Items.Add(oku["firmaadi"]);
            }
            baglan.Close();

            baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            cmd = new MySqlCommand("select distinct firmaadi from firma", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbFirma2.Items.Add(oku["firmaadi"]);
            }
            baglan.Close();


            baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            cmd = new MySqlCommand("select distinct firmaadi from firma", baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbFirma3.Items.Add(oku["firmaadi"]);
            }
            baglan.Close();


            baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            cmd = new MySqlCommand("select distinct firmaadi from firma", baglan);
            oku = cmd.ExecuteReader();
           /* while (oku.Read())
            {
                //cmbGfsec.Items.Add(oku["firmaadi"]);
                //cmbFirma.Items.Add(oku["firmaadi"]);
            }*/
            baglan.Close();
            


        }       //form1 yüklenir yüklenmez olacaklar comboxlar felan dolacak gibi



        private void btnFirma_Click(object sender, EventArgs e)
        {
            string FirmaAdi = txtFAdi.Text;
            string FirmaAdres = txtFAdres.Text;
            string FirmaEposta = txtFEposta.Text;
            string Ftel = txtFTelefon.Text;
            string FFax = txtFFaks.Text;
            string VergiNo = txtVNo.Text;
            string sicilNo = txtTSNo.Text;
            string vergiD = txtVDairesi.Text;

            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("insert into firma (firmaadi,vergino,vergidairesi,ticarisicilno,telefon,adres,faks,eposta) values ('" + txtFAdi.Text + "','" + txtVNo.Text + "','" + txtVDairesi.Text + "','" + txtTSNo.Text + "','" + txtFTelefon.Text + "','" + txtFAdres.Text + "','" + txtFFaks.Text + "','" + txtFEposta.Text + "')  ", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
            baglan.Close();
            MessageBox.Show("Firma başarıyla eklenmiştir");
        }       //firma bilgilerini alıp  veritabanına ekleyen kısım
        public static DateTime alinan;
        public static DateTime ongun;
        public static DateTime elligun;
        public static string tarih;
        public static string adres;
        public static string tel;
        public static string faks;
        public static string adsoyad;
        public static string eposta;
        public static string yatirim;
        public static string ffirmaa;
        public void button2_Click(object sender, EventArgs e)
        {

            ffirmaa = cmbFirma.Text;
            yatirim = txtYatirim.Text;
            adsoyad = txtAdSoyad.Text;
            tarih = dTTarih.Text;
            alinan = Convert.ToDateTime(tarih);
            elligun = Convert.ToDateTime(tarih);
            elligun = elligun.AddDays(50);
            ongun = Convert.ToDateTime(tarih);
            ongun = ongun.AddDays(10);
            adres = txtAdres.Text;
            tel = txtTelefon.Text;
            faks = txtFaks.Text;
            eposta = txtEposta.Text;
            Form3 goster = new Form3();
            goster.firma = cmbFirma.Text;
            goster.firma1 = cmbFirma2.Text;
            goster.firma2 = cmbFirma3.Text;
            STtarih.Value = ongun;
            goster.Show();
                        
    }
       
            
        
        private void tabGuncelleme_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct firmaadi from firma", baglan);
            MySqlDataReader oku = cmd.ExecuteReader();
           /* while (oku.Read())
            {
                cmbGfsec.Items.Add(oku["firmaadi"]);
            }*/
            baglan.Close();
        }   //güncelleme kısmı

        

      

        

        
        private void tabTeklif_Load(object sender, EventArgs e)
        {
           // TTarih.Value = dTTarih.Value;
        }
        private void tabTeklif_Click(object sender, EventArgs e)
        {
            //  TTarih.Value = alinan;       
        }
        static string firma1;
        private void cmbFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            firma1 = cmbFirma.SelectedItem.ToString();
            cmbFsec.Items.Add(firma1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TTarih_ValueChanged(object sender, EventArgs e)
        {
                 }
        private void tabDavet_Click(object sender, EventArgs e)
        {

        }


        private void txtYatirim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngstrr_Click(object sender, EventArgs e)
        {
            Form2 goster = new Form2();
            goster.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            STtarih.Value = ongun;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //Tektarih.MaxDate = ongun;
            if (Tektarih.Value > ongun)
            {
                MessageBox.Show("teklif son tarihini geçemezsiniz");
                Tektarih.Value = ongun;
            }
        }

        private void dTTarih_ValueChanged(object sender, EventArgs e)
        {
            TTarih.Value = dTTarih.Value;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbFsec_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        static string firma2;
        private void cmbFirma2_SelectedIndexChanged(object sender, EventArgs e)
        {
            firma2 = cmbFirma2.SelectedItem.ToString();
            cmbFsec.Items.Add(firma2);
        }
        static string firma3;
        private void cmbFirma3_SelectedIndexChanged(object sender, EventArgs e)
        {
            firma3 = cmbFirma3.SelectedItem.ToString();
            cmbFsec.Items.Add(firma3);
        }
        
    }
}
