using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace makine_ekipman
{
    class fonksiyonlar
    {
        MySqlConnection baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
        MySqlCommand cmd;
        MySqlDataReader oku;
   //     Form2 frm2 = new Form2();


        

        public void insertmarka(string TeknikOzellikler, string MarkaModel, string Mensei, string Birim, int BirimFiyat)
        {
            baglan.Open();
            cmd = new MySqlCommand("insert into marka (markamodel,mensei,fiyat,teknikozellikler,birim) values ('" + MarkaModel + "','" + Mensei + "','" + BirimFiyat + "','" + TeknikOzellikler + "','" + Birim + "')", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();

        }

        public void inserturun(string MalAdi, string MarkaModel)
        {
            baglan.Open();
            cmd = new MySqlCommand("insert into urun (urunadi,markamodel) values ('" + MalAdi + "','" + MarkaModel + "')", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();

        }
        public string secimler(string a)
        {

            string[] c = new string[1];

            if (a == "Biçme Makinesi")
            {
                c[0] = "tip: " + Bicme.bicmetip + "\n" + "Ağırlık:" + Bicme.bicmeagirlik + " - " + Bicme.bicmeagirlik1 + "\n" + "Güç: " + Bicme.bicmeguc + " - " + Bicme.bicmeguc1 + "\n" + "Uzunluk: " + Bicme.bicmeuzunluk + " - " + Bicme.bicmeuzunluk1 + "\n" + "Genişlik: " + Bicme.bicmegenislik + " - " + Bicme.bicmegenislik1 + "\n" + "Yukseklik: " + Bicme.bicmeyukseklik + " - " + Bicme.bicmeyukseklik1 + "\n" + "Bıçak Sayısı:" + Bicme.bicmebicaksayisi + "\n" + Bicme.bicmeek;
                /*    c[5] = "Yukseklik: " + Bicme.bicmeyukseklik + " - " + Bicme.bicmeyukseklik1;
                    c[1] = "Ağırlık:" + Bicme.bicmeagirlik + " - " + Bicme.bicmeagirlik1;
                    c[2] = "Güç: " + Bicme.bicmeguc + " - " + Bicme.bicmeguc1;
                    c[3] = "Uzunluk: " + Bicme.bicmeuzunluk + " - " + Bicme.bicmeuzunluk1;
                    c[4] = "Genişlik: " + Bicme.bicmegenislik + " - " + Bicme.bicmegenislik1;
                    c[5] = "Yukseklik: " + Bicme.bicmeyukseklik + " - " + Bicme.bicmeyukseklik1;
                    c[6] = "Bıçak Sayısı:" + Bicme.bicmebicaksayisi;
                    c[7] = "" + Bicme.bicmeek;*/
            }
            if (a == "Çapa Makinesi")
            {
                c[0] = "tip: " + capa.capatip + "\n" + "Ağırlık:" + capa.capaagirlik + " - " + capa.capaagirlik1 + "\n" + "Güç: " + capa.capaguc + " - " + capa.capaguc1 + "\n" + "Uzunluk: " + capa.capauzunluk + " - " + capa.capauzunluk1 + "\n" + "Genişlik: " + capa.capagenislik + " - " + capa.capagenislik1 + "\n" + "Yukseklik: " + capa.capayukseklik + " - " + capa.capayukseklik1 + "\n" + "Ayak Sayısı:" + capa.capaayaks + " - " + capa.capaayaks1 + "\n" + capa.capaek;

            }
            if (a == "Dip Kazan")
            {
                c[0] = "tip: " + Dip.diptip + "\n" + "Şasi Yüksekliği: " + Dip.dipsasiyuk + "\n" + "Güç: " + Dip.dipguc + " - " + Dip.dipguc1 + "\n" + "Uzunluk: " + Dip.dipuzunluk + " - " + Dip.dipuzunluk1 + "\n" + "Genişlik: " + Dip.dipgenislik + " - " + Dip.dipgenislik1 + "\n" + "Yükseklik: " + Dip.dipyukseklik + " - " + Dip.dipyukseklik1 + "\n" + "Ayak Sayısı:" + Dip.dipayaksayisi + " - " + Dip.dipayaksayisi1 + "\nÇalışma Derinliği: " + Dip.dipcderinlik + "\n" + Dip.dipek;

            }
            if (a == "Ekim Makinesi")
            {
                c[0] = "tip: " + Ekim.ekimtip + "\n" + "Ağırlık:" + Ekim.ekimagirlik + " - " + Ekim.ekimagirlik1 + "\n" + "Güç: " + Ekim.ekimguc + " - " + Ekim.ekimguc1 + "\n" + "Uzunluk: " + Ekim.ekimuzunluk + " - " + Ekim.ekimuzunluk1 + "\n" + "Genişlik: " + Ekim.ekimgenislik + " - " + Ekim.ekimgenislik1 + "\n" + "Yukseklik: " + Ekim.ekimyukseklik + " - " + Ekim.ekimyukseklik1 + "\n" + "Ayak Sayısı:" + Ekim.ekimayaksayisi + " - " + Ekim.ekimayaksayisi1 + "\nİş Genişliği :" + Ekim.ekimisg + " - " + Ekim.ekimisg1 + "\n" + Ekim.ekimek;

            }
            if (a == "Goble")
            {
                c[0] = "tip: " + Goble.gobletip + "\n" + "Ağırlık:" + Goble.gobleagirlik + " - " + Goble.gobleagirlik1 + "\n" + "Güç: " + Goble.gobleguc + " - " + Goble.gobleguc1 + "\n" + "Uzunluk: " + Goble.gobleuzunluk + " - " + Goble.gobleuzunluk1 + "\n" + "Genişlik: " + Goble.gobleisgenislik + " - " + Goble.gobleisgenislik1 + "\n" + "Yukseklik: " + Goble.gobleyukseklik + " - " + Goble.gobleyukseklik1 + "\n" + "Disk Sayısı: " + Goble.gobledisksayisi + " - " + Goble.gobledisksayisi1 + "\nİş Genişliği" + Goble.gobleisgenislik + " - " + Goble.gobleisgenislik1 + " \n" + Goble.gobleek;
            }
            if (a == "Gübre Serpme Makinesi")
            {
                c[0] = "tip: " + Gubre.gubretip + "\n" + "Ağırlık:" + Gubre.gubreagirlik + " - " + Gubre.gubreagirlik1 + "\n" + "Güç: " + Gubre.gubreguc + " - " + Gubre.gubreguc1 + "\n" + "Uzunluk: " + Gubre.gubreuzunluk + " - " + Gubre.gubreuzunluk1 + "\n" + "Genişlik: " + Gubre.gubregenislik + " - " + Gubre.gubregenislik1 + "\n" + "Yukseklik: " + Gubre.gubreyukseklik + " - " + Gubre.gubreyukseklik1 + "\n" + "Kapasite :" + Gubre.gubrekapasite + " - " + Gubre.gubrekapasite1 + "\nİş Genişliği" + Gubre.gubreisgenislik + " - " + Gubre.gubreisgenislik1 + " \n" + Gubre.gubreek;
            }
            if (a == "İlaçlama Makinesi")
            {
                c[0] = "tip: " + ilaclama.ilaclamatip + "\n" + "Güç: " + ilaclama.ilaclamaguc + " - " + ilaclama.ilaclamaguc1 + "\n" + "Kapasite : " + ilaclama.ilaclamakapasite + " - " + ilaclama.ilaclamakapasite1 + "\n" + "Debi : " + ilaclama.ilaclamadebi + "\n" + ilaclama.ilaclamaek;
            }
            if (a == "Merdane")
            {
                c[0] = "tip: " + merdane.merdanetip + "\n" + "Ağırlık:" + merdane.merdaneagirlik + " - " + merdane.merdaneagirlik1 + "\n" + "Güç: " + merdane.merdaneguc + " - " + merdane.merdaneguc1 + "\n" + "Uzunluk: " + merdane.merdaneuzunluk + " - " + merdane.merdaneuzunluk1 + "\n" + "Genişlik: " + merdane.merdaneisgenislik + " - " + merdane.merdaneisgenislik1 + "\n" + "Yukseklik: " + merdane.merdaneyukseklik + " - " + merdane.merdaneyukseklik1 + "\n" + "İş Genişliği:" + merdane.merdaneisgenislik + " - " + merdane.merdaneisgenislik1 + "\nSıra :" + merdane.merdanesira + "\nÇap :" + merdane.merdanecap + "\n" + merdane.merdaneek;

            }
            if (a == "Pulluk")
            {
                c[0] = "tip: " + pulluk.pulluktip + "\n" + "Ağırlık:" + pulluk.pullukagirlik + " - " + pulluk.pullukagirlik1 + "\n" + "Güç: " + pulluk.pullukguc + " - " + pulluk.pullukguc1 + "\n" + "Uzunluk: " + pulluk.pullukuzunluk + " - " + pulluk.pullukuzunluk1 + "\n" + "Genişlik: " + pulluk.pullukisgenislik + " - " + pulluk.pullukisgenislik1 + "\n" + "Yukseklik: " + pulluk.pullukyukseklik + " - " + pulluk.pullukyukseklik1 + "\n" + "Ayak Sayısı:" + pulluk.pullukayaks + " - " + pulluk.pullukayaks1 + "\n" + "İş Genişliği:" + pulluk.pullukisgenislik + " - " + pulluk.pullukisgenislik1 + "\nGövde Arası Uzaklık :" + pulluk.pullukgovdearasi + "\n" + pulluk.pullukek;
            }
            if (a == "Römork")
            {
                c[0] = "tip: " + Romork.romorktip + "\n" + "Uzunluk:" + Romork.romorkuzunluk + " - " + Romork.romorkuzunluk1 + "\n" + "Genişlik : " + Romork.romorkgenislik + " - " + Romork.romorkgenislik1 + "\n" + "Yükseklik : " + Romork.romorkyukseklik + " - " + Romork.romorkyukseklik1 + "\n" + "Kapasite: " + Romork.romorkkapasite + " - " + Romork.romorkkapasite1 + "\n" + "Dingil Sayısı : " + Romork.romorkdingil + "\n" + "Teker Sayısı:" + Romork.romorktekersayisi + "\nLastik Ebat" + Romork.romorklastik + " - " + Romork.romorklastik1 + "\n" + Romork.romorkek;

            }
            if (a == "Rotovatör")
            {
                c[0] = "tip: " + rotovator.rotovatortip + "\n" + "Ağırlık:" + rotovator.rotovatoragirlik + " - " + rotovator.rotovatoragirlik1 + "\n" + "Güç: " + rotovator.rotovatorguc + " - " + rotovator.rotovatorguc1 + "\n" + "Uzunluk: " + rotovator.rotovatoruzunluk + " - " + rotovator.rotovatoruzunluk1 + "\n" + "Genişlik: " + rotovator.rotovatorgenislik + " - " + rotovator.rotovatorgenislik1 + "\n" + "Yukseklik: " + rotovator.rotovatoryukseklik + " - " + rotovator.rotovatoryukseklik1 + "\n" + "Bıçak Sayısı:" + rotovator.rotovatorbicak + "\nİş Genişliği :" + rotovator.rotovatorisgenislik + " - " + rotovator.rotovatorisgenislik1 + "\nİş Derinliği :" + rotovator.rotovatorisderinlik + "\n" + rotovator.rotovatorek;

            }
            if (a == "Tesviye Küreği")
            {
                c[0] = "tip: " + tesviye.tesviyetip + "\n" + "Ağırlık:" + tesviye.tesviyeagirlik + " - " + tesviye.tesviyeagirlik1 + "\n" + "Güç: " + tesviye.tesviyeguc + " - " + tesviye.tesviyeguc1 + "\n" + "Uzunluk: " + tesviye.tesviyeuzunluk + " - " + tesviye.tesviyeuzunluk1 + "\n" + "Genişlik: " + tesviye.tesviyeisgenislik + " - " + tesviye.tesviyeisgenislik1 + "\n" + "Yukseklik: " + tesviye.tesviyeyukseklik + " - " + tesviye.tesviyeyukseklik1 + "\n" + "İş Genişliği :" + tesviye.tesviyeisgenislik + " - " + tesviye.tesviyeisgenislik1 + "\nSac Kalınlığı :" + tesviye.tesviyesac + "\nYönlendirme : " + tesviye.tesviyeyon + "\n" + tesviye.tesviyeek;

            }
            if (a == "Tırmık")
            {
                c[0] = "tip: " + tirmik.tirmiktip + "\n" + "Ağırlık:" + tirmik.tirmikagirlik + " - " + tirmik.tirmikagirlik1 + "\n" + "Güç: " + tirmik.tirmikguc + " - " + tirmik.tirmikguc1 + "\n" + "Uzunluk: " + tirmik.tirmikuzunluk + " - " + tirmik.tirmikuzunluk1 + "\n" + "Yükseklik : " + tirmik.tirmikyukseklik + " - " + tirmik.tirmikyukseklik1 + "\n" + "Genişlik : " + tirmik.tirmikgenislik + " - " + tirmik.tirmikgenislik1 + "\n" + "İş Genişliği :" + tirmik.tirmikisgenislik + " - " + tirmik.tirmikisgenislik1 + "\nDiş Sayısı : " + tirmik.tirmikdis + "\n" + tirmik.tirmikek;
            }
            if (a == "Yükleme Kepçesi")
            {
                c[0] = "tip: " + Yukleme.YTip + "\n" + "Ağırlık:" + Yukleme.YAgirlik + " - " + Yukleme.YAgirlik1 + "\n" + "Uzunluk : " + Yukleme.YUzunluk + " - " + Yukleme.YUzunluk1 + "\n" + "Yükseklik : " + Yukleme.YYuksek + " - " + Yukleme.YYuksek1 + "\n" + "İş Genişlik: " + Yukleme.Yisg + " - " + Yukleme.Yisg1 + "\n" + Yukleme.YEk;
            }

            return c[0];
        }
        public string Birimler(string x)
        {
            string[] t = new string[1];
            if (x == "Biçme Makinesi")
            {
                t[0] = "" + Bicme.bicmebirim;
            }
            if (x == "Çapa Makinesi")
            {
                t[0] = "" + capa.capabirim;
            }
            if (x == "Dip Kazan")
            { t[0] = "" + Dip.dipBirim; }

            if (x == "Ekim Makinesi")
            { t[0] = "" + Ekim.ekimbirim; }
            if (x == "Goble")
            { t[0] = "" + Goble.goblebirim; }
            if (x == "Gübre Serpme Makinesi")
            { t[0] = "" + Gubre.gubrebirim; }
            if (x == "İlaçlama Makinesi")
            { t[0] = "" + ilaclama.ilaclamabirim; }
            if (x == "merdane")
            { t[0] = "" + merdane.merdanebirim; }
            if (x == "Pulluk")
            { t[0] = "" + pulluk.pullukbirim; }
            if (x == "Römork")
            { t[0] = "" + Romork.romorkbirim; }
            if (x == "Rotovatör")
            { t[0] = "" + rotovator.rotovatorbirim; }
            if (x == "Tesviye Küreği")
            { t[0] = "" + tesviye.tesviyebirim; }
            if (x == "Tırmık")
            { t[0] = "" + tirmik.tirmikbirim; }
            if (x == "Yükleme Kepçesi")
            { t[0] = "" + Yukleme.YBirim; }
            return t[0];
        }
        public string Miktarlar(string b)
        {
            string[] h = new string[1];
            if (b == "Biçme Makinesi")
            {
                h[0] = "" + Bicme.bicmemiktar;
            }
            if (b == "Çapa Makinesi")
            {
                h[0] = "" + capa.capamiktar;
            }
            if (b == "Dip Kazan")
            { h[0] = "" + Dip.dipmiktar; }

            if (b == "Ekim Makinesi")
            { h[0] = "" + Ekim.ekimmiktar; }
            if (b == "Goble")
            { h[0] = "" + Goble.goblemiktar; }
            if (b == "Gübre Serpme Makinesi")
            { h[0] = "" + Gubre.gubremiktar; }
            if (b == "İlaçlama Makinesi")
            { h[0] = "" + ilaclama.ilaclamamiktar; }
            if (b == "merdane")
            { h[0] = "" + merdane.merdanemiktar; }
            if (b == "Pulluk")
            { h[0] = "" + pulluk.pullukmiktar; }
            if (b == "Römork")
            { h[0] = "" + Romork.romorkmiktar; }
            if (b == "Rotovatör")
            { h[0] = "" + rotovator.rotovatormiktar; }
            if (b == "Tesviye Küreği")
            { h[0] = "" + tesviye.tesviyemiktar; }
            if (b == "Tırmık")
            { h[0] = "" + tirmik.tirmikmiktar; }
            if (b == "Yükleme Kepçesi")
            { h[0] = "" + Yukleme.YMiktar; }
            return h[0];
        }
        public string adrres(string c)
        {
            string fadrres = "";
            baglan = new MySqlConnection("Server = localhost; Database=makineekipman;Uid=root;Pwd=");
            baglan.Open();
            cmd = new MySqlCommand("select adres from firma where" + c, baglan);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                fadrres = oku["adres"].ToString();
            }
            baglan.Close();
            return fadrres;
        }
        public string secimlerCoklu(string h)
        {
            string[] ts = new string[6];
            if (h== "Biçme Makinesi")
            {
                baglan.Open();
                cmd = new MySqlCommand("select agirlik FROM bicmemakinesi where agirlik, bicmegenislik BETWEEN " + Bicme.bicmeagirlik+"AND"+Bicme.bicmeagirlik1+ "AND" + Bicme.bicmegenislik+"AND"+Bicme.bicmegenislik1, baglan);
                cmd.ExecuteNonQuery();
                while (oku.Read())
                {
                    ts[0] = oku["agirlik"].ToString();
                }
                baglan.Close();
                // SELECT isim, soyisim, yas FROM personel WHERE yas BETWEEN 20 AND 26

            }

            return ts[0];
        }
        
       /*public string secimT(string ismi) {
            
        }*/


            }

        }


