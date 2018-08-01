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
    public partial class Form3 : Form
        
    {
        public Form3()
        {
            InitializeComponent();
    }
        fonksiyonlar fm = new fonksiyonlar();

        public string firma,firma1,firma2;
        public static string[] mallar = new string[300];


        private void Form3_Load(object sender, EventArgs e)
        {
            cmbFirma3.Items.Add(firma);
            cmbFirma3.Items.Add(firma1);
            cmbFirma3.Items.Add(firma2);


        }

        public static int sayi = 0;
        private void btnGoster3_Click(object sender, EventArgs e)
        {

            mallar[sayi] = cmbUrun.Text;
            sayi++;
            if (cmbUrun.Text == "Biçme Makinesi") {
                Bicme goster1 = new Bicme();
                goster1.Show();
            }
            if(cmbUrun.Text == "Çapa Makinesi")
            {
                capa goster2 = new capa();
                goster2.Show();
            }
            if (cmbUrun.Text == "Dip Kazan")
            {
                Dip goster3 = new Dip();
                goster3.Show();
            }
            if (cmbUrun.Text == "Ekim Makinesi")
            {
                Ekim goster4 = new Ekim();
                goster4.Show();
            }
            if (cmbUrun.Text == "Goble")
            {
                Goble goster5 = new Goble();
                goster5.Show();
            }
            if (cmbUrun.Text == "Gübre Serpme Makinesi")
            {
                Gubre goster6 = new Gubre();
                goster6.Show();
            }
            if (cmbUrun.Text == "İlaçlama Makinesi")
            {
                ilaclama goster7 = new ilaclama();
                goster7.Show();
            }
            if (cmbUrun.Text == "Merdane")
            {
                merdane goster8 = new merdane();
                goster8.Show();
            }
            if (cmbUrun.Text == "Pulluk")
            {
                pulluk goster9 = new pulluk();
                goster9.Show();
            }
            if (cmbUrun.Text == "Römork")
            {
                Romork goster10 = new Romork();
                goster10.Show();
            }
            if (cmbUrun.Text == "Rotovatör")
            {
                rotovator goster11 = new rotovator();
                goster11.Show();
            }
            if (cmbUrun.Text == "Tesviye Küreği")
            {
                tesviye goster12 = new tesviye();
                goster12.Show();
            }
            if (cmbUrun.Text == "Tırmık")
            {
                tirmik goster13 = new tirmik();
                goster13.Show();
            }
            if (cmbUrun.Text == "Yükleme Kepçesi")
            {
                Yukleme goster14 = new Yukleme();
                goster14.Show();
                    }

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {

            wordeaktar.Application wordapp = new wordeaktar.Application();
            wordapp.Visible = true;
            wordeaktar.Document worddoc;
            object objmissing = System.Reflection.Missing.Value;
            worddoc = wordapp.Documents.Add(ref objmissing);
            wordapp.Selection.Font.Size = 10;
            wordapp.Selection.Font.Name = "arial";

            wordeaktar.Paragraph paragraf1;
            paragraf1 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf1.Range.Text = (Form1.adsoyad);
            paragraf1.Range.Font.Bold = 1;
            paragraf1.Range.InsertParagraphAfter();
            worddoc.Paragraphs[1].Alignment =
                wordeaktar.WdParagraphAlignment.wdAlignParagraphCenter;

            wordeaktar.Paragraph paragraf2;
            paragraf2 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf2.Range.Text = ("MAKİNE-EKİPMAN ALIMI İÇİN TEKLİF DAVET MEKTUBU"+Teklif_Yukleme_Kepcesi.TYagirlik+"");
            paragraf2.Range.Font.Bold = 1;
            paragraf2.Range.InsertParagraphAfter(); worddoc.Paragraphs[2].Alignment = //burda sağa dayalı merkezde felan olacagı belirtiliyor 2 satır.
                 wordeaktar.WdParagraphAlignment.wdAlignParagraphCenter;         //burda sağa dayalı merkezde felan olacagı belirtiliyor 2 satır.

            wordeaktar.Paragraph paragraf3;
            paragraf3 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf3.Range.Text = (Form1.tarih);
            paragraf3.Range.Font.Bold = 1;
            paragraf3.Range.InsertParagraphAfter();
            worddoc.Paragraphs[3].Alignment =                           //burda sağa dayalı merkezde felan olacagı belirtiliyor 2 satır.
                wordeaktar.WdParagraphAlignment.wdAlignParagraphRight;   //burda sağa dayalı merkezde felan olacagı belirtiliyor 2 satır.


            wordeaktar.Paragraph paragraf4;
            paragraf4 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf4.Range.Text = (cmbFirma3.Text);
            paragraf4.Range.Font.Bold = 1;
            paragraf4.Range.InsertParagraphAfter();

            wordeaktar.Paragraph paragraf5;
            paragraf5 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf5.Range.Text = (fm.adrres(Form1.ffirmaa));
            paragraf5.Range.Font.Bold = 1;
            paragraf5.Range.InsertParagraphAfter();

            wordeaktar.Paragraph paragraf6;
            paragraf6 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf6.Range.Text = ("       IPARD programı kapsamında Avrupa Birliği ve Türkiye Cumhuriyeti Hükümeti tarafından sağlanan hibe desteğinden yararlanmak için," + Form1.adres + " adresinde uygulamayı planladığım "+Form1.yatirim+" yatırımım kapsamında, sizi makine-ekipman alımı için bu davet mektubu ve eklerinde belirtilen şartlara uygun teklif vermeye davet ediyorum.");
            paragraf6.Range.InsertParagraphAfter();



            wordeaktar.Paragraph paragraf7;
            paragraf7 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf7.Range.Text = (Form1.adsoyad);
            paragraf7.Range.Font.Bold = 1;
            paragraf7.Range.InsertParagraphAfter();
            worddoc.Paragraphs[7].Alignment =                           //burda sağa dayalı merkezde felan olacagı belirtiliyor 2 satır.
            wordeaktar.WdParagraphAlignment.wdAlignParagraphRight;   //burda sağa dayalı merkezde felan olacagı belirtiliyor 2 satır.

            wordeaktar.Paragraph paragraf8;
            paragraf8 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf8.Range.Text = ("Teklifin Sunulacağı Adres ve İletişim Bilgileri");
            paragraf8.Range.Font.Bold = 1;
            paragraf8.Range.Underline = wordeaktar.WdUnderline.wdUnderlineSingle;
            paragraf8.Range.InsertParagraphAfter();
            paragraf8.Range.Underline = wordeaktar.WdUnderline.wdUnderlineNone;


            wordeaktar.Paragraph paragraf9;
            paragraf9 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf9.Range.Text = ("Adres  :" + Form1.adres);
            paragraf9.Range.InsertParagraphAfter();

            wordeaktar.Paragraph paragraf10;
            paragraf10 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf10.Range.Text = ("Telefon:" + Form1.tel);
            paragraf10.Range.InsertParagraphAfter();

            wordeaktar.Paragraph paragraf11;
            paragraf11 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf11.Range.Text = ("Faks  :" + Form1.faks);
            paragraf11.Range.InsertParagraphAfter();

            wordeaktar.Paragraph paragraf12;
            paragraf12 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf12.Range.Text = ("e-posta:" + Form1.eposta);
            paragraf12.Range.InsertParagraphAfter();

         /*   wordeaktar.Paragraph paragraf13;
            paragraf13 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf13.Range.Text = ("EKLER :");
            paragraf13.Range.Font.Bold = 1;
            paragraf13.Range.InsertParagraphAfter();*/

            wordeaktar.Paragraph paragraf14;
            paragraf14 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf14.Range.Text = ("1-Teknik Şartname");
            paragraf14.Range.InsertParagraphAfter();

            wordeaktar.Paragraph paragraf15;
            paragraf15 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf15.Range.Text = ("TEKLİFE İLİŞKİN GENEL ŞARTLAR");
            paragraf15.Range.InsertParagraphAfter();
            worddoc.Paragraphs[15].Alignment = wordeaktar.WdParagraphAlignment.wdAlignParagraphCenter;

            wordeaktar.Paragraph paragraf16;
            paragraf16 = worddoc.Content.Paragraphs.Add(ref objmissing);
            paragraf16.Range.Text = ("1- Teklif sunacak potansiyel tedarikçi,bu alıma konu olan ve teklif davet mektubu ve eklerinde yer alan özel ve genel şartların tamamını kayıtsız şartsız kabul eder. Teklif verenin kendi satış koşullarını ve alternatif çözümleri bu alım çerçevesinde geçersizdir.\n2- Bu davet konusu makine-ekipman alımının tamamı için fiyat verilmesi, Teknik Şartnamede yer alan her bir kalem için birim ve toplam fiyatların teklifte belirtilmesi zorunludur.Aksi takdirde teklif geçersiz sayılacaktır.Bu alım kapsamındaki uygun teklifin seçiminde geneluygulama olarak, her bir kalem için yapılan teklifler değil, teklifin genel toplamı dikkate alınacaktır.Ancak fiyat dışındaki unsurlar da seçim aşamasında değerlendirilecektir.\n3 - Teklif, KDV ve tüm vergiler hariç olarak, ithal mallar için gümrük vergileri hariç olarak verilmelidir.Teklifin KDV ve tüm vergiler hariç olarak verildiği de hususi olarak belirtilmelidir.Ayrıca fiyatlar; malların varış yerine teslim giderleri, paketleme, sigorta, nakliye, ambalajdan çıkarma, kurma vb.giderleri hariç olarak hesaplanmalıdır. Tekliflerin fiyatlandırılmasında vergiler ile ilgili hususlarda Maliye Bakanlığının Türkiye – Avrupa Birliği Çerçeve Anlaşması Genel Tebliğlerindeki esaslar dikkate alınmalıdır. Tekliflerde belirtilen fiyatlar sabit olup sonradan hiçbir şekilde değiştirilemez.\n4 - Tekliflerin fiyatlandırılmasında piyasa koşulları dikkate alınmalı ve fiyatlar piyasa koşullarına  uygun olmalıdır.\n5 - Teklifteki hesaplama işlemleri doğru bir şekilde yapılmalıdır.\n6 - Teklifin, teknik şartnamede belirtilen özellikleri ve şartları karşılaması zorunludur.\n7 - Teklifte her bir kalemin marka ve modeli mutlaka belirtilmelidir.\n8 - Teklif kapsamında sunulacak makine ekipman ve her türlü malzeme mutlaka yeni olmalıdır.\n9 - Teklif," + Form1.elligun.ToShortDateString() + " tarihine kadar geçerli olacak şekilde hazırlanmalıdır. (Talep ettiğiniz teklif geçerlilik süresini mutlaka yazınız. Bu konuda Teklif Alma Kuralları Rehberindeki açıklamaları dikkate alınız.Başvuru dosyasına koyacağınız bütün tekliflerin geçerlilik sürelerinin en az başvurunuzun teslim tarihini kapsadığını ve yukarıda belirttiğiniz tarihe uygun olduğunu kontrol ediniz.)\n10 - Teklifte, teknik şartnamede yer alan her bir kalemin menşei yazılı olarak belirtilmelidir.\nMenşeler, TKDK web sayfasında(www.tkdk.gov.tr) yayınlanan “Teklif Alma Kuralları”nda belirtilen menşe kurallarına kesinlikle uygun olmalıdır.Eğer teklif kabul edilir ve proje TKDK tarafından destek almaya uygun görülürse menşe ile ilgili belgeler malın teslim aşamasında teslim edilmelidir.\n11- Makine - ekipmanlara ilişkin bakım, garanti koşulları ve süreleri, teknik şartnameye uygun olarak teklifte belirtilmelidir.\n12- Aşağıdaki belgeler Teklif ekinde mutlaka sunulmalıdır. \n* Teklif davet mektubunun potansiyel tedarikçi tarafından imzalanmış fotokopisi \n* Teknik şartnamenin potansiyel tedarikçi tarafından imzalanmış fotokopisi \n* Potansiyel tedarikçi;\n            -Tüzel kişi ise, Ticaret ve / veya Sanayi Odasından TKDK’nın Başvuru Çağrısına çıktığı tarihten sonra alınmış “Ortaklık Yapısını Gösteren Belge” (Bu belgede ortakların TC kimlik no, tüzel kişi ortaklarda vergi no ve ortakların hisse oranları belirtilmelidir),\n            -Gerçek kişi ise, TC Kimlik Numarasının yer aldığı “nüfus cüzdanı fotokopisi veya nüfus kayıt sureti”,\n            -Yabancı ise, yeminli tercüman tarafından Türkçeye çevrilmiş apostilli “ticari kayıt belgesi” \n* Potansiyel tedarikçi;\n            -Ticaret ve / veya Sanayi Odasına üye ise, Ticaret ve / veya Sanayi Odasından TKDK’nın Başvuru Çağrısına çıktığı tarihten sonra alınmış “Faaliyet belgesi veya Faaliyet alanını gösteren Belge”,\n            -Esnaf ve Sanatkârlar Odasına Üye ise, Esnaf ve sanatkârlar odasından TKDK’nın Başvuru Çağrısına çıktığı tarihten sonra alınmış “Mesleki faaliyet Belgesi”,\n            -Serbest mühendis veya müşavir statüsünde gerçek kişi ise, bağlı olduğu meslek odasından alınmış TKDK’nın başvuru çağrısına çıkıldığı yıla ait “Serbest Müşavirlik Mühendislik Büro Tescil Belgesi”nin fotokopisi\n            -Yabancı ise teklif sahibinin, yeminli tercüman tarafından Türkçeye çevrilmiş apostilli Faaliyet Belgesi \n13 - Teklifin ilgili yerleri imzalanmış / kaşelenmiş ve imzalanmamış her sayfası paraflanmış olmalıdır.\n14 - Bu teklif davet mektubu kapsamında gönderilen tüm tekliflerin mülkiyet hakkı tarafıma ait olup verilen teklifler geri iade edilmeyecektir.\n15 - Teslim / kurulum, ödeme ve diğer tüm koşullar teklifin seçilmesi durumunda yapılacak alım sözleşmesinde belirlenecektir. \n16 - Teklifler TKDK web adresinde(www.tkdk.gov.tr) adresinde yayımlanan “Teklif Alma Kuralları Rehberi”ne uygun olarak hazırlanmalıdır. Bu davet mektubunda belirtilmeyen hususlarda da aynı rehberdeki kurallar ve koşullar geçerli olup, bu çerçevede teklif hazırlanmalıdır.\n17 - Teklif, " + Form1.ongun.ToShortDateString() + " günü saat 17.00’ a kadar davet mektubunda belirtilen adreste olacak şekilde elden veya kargo aracılığı ile veya posta ile zarf içerisinde teslim edilecektir. Teklif faks veya e-posta yoluyla da gönderebilir ancak, imzalı kaşeli orijinallerini son teklif verme tarihinden önce tarafıma teslim edilmek zorundadırlar.Postadaki gecikmeler dikkate alınmayacaktır. (Tekliflerin son teslim tarihini mutlaka belirtiniz ve başvuru dosyasına koyacağınız bütün tekliflerin bu tarihten önceki bir tarihe sahip olduklarını kontrol ediniz.)");
            paragraf16.Range.InsertParagraphAfter();
            worddoc.Paragraphs[15].Alignment = wordeaktar.WdParagraphAlignment.wdAlignParagraphCenter;


            object objMiss = System.Reflection.Missing.Value;
            object objEndOfDocFlag = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
            wordeaktar.Table objtab1;
            wordeaktar.Range objWordRng = worddoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            objtab1 = worddoc.Tables.Add(objWordRng, sayi+1, 5, ref objMiss, ref objMiss);
            objtab1.Borders.Enable = 1;
            objtab1.Range.ParagraphFormat.SpaceAfter = sayi+1;

            objtab1.Cell(1, 1).Range.Text = "No";
            objtab1.Cell(1, 2).Range.Text = "Alınacak Malın Adı";
            objtab1.Cell(1, 3).Range.Text = "Teknik Özellikler";
            objtab1.Cell(1, 4).Range.Text = "Birim";
            objtab1.Cell(1, 5).Range.Text = "Miktar";
            for (int i = 2; i <= sayi+1; i++)
            {
                objtab1.Cell(i, 1).Range.Text = "" + (i - 1);
                objtab1.Cell(i, 2).Range.Text = "" + mallar[i-2];
                objtab1.Cell(i, 3).Range.Text = ""+fm.secimler(mallar[i-2]) ;
                objtab1.Cell(i, 4).Range.Text = "" + fm.Birimler(mallar[i - 2]);
                objtab1.Cell(i, 5).Range.Text = "" + fm.Miktarlar(mallar[i - 2]);
            }
            objtab1.Rows[1].Range.Font.Bold = 1;
            objtab1.Rows[1].Range.Font.Italic = 1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnGoster2_Click(object sender, EventArgs e)
        {

        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFirma3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}