using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data.Odbc;
//using System.Data.OracleClient;

namespace anaekran

{
    class servis
    {


        public OracleDataReader Login_insert_DataReader(string adsoyad, string tc, string kullaniciadi, string sifre, string telno, string sehir)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader("insert into Login(AdSoyad, Tc, KullaniciAdi, Sifre, TelNo, Sehir) values('" + adsoyad + "', '" + tc + "','" + kullaniciadi + "', '" + sifre + "', '" + telno + "','" + sehir + "')");

            return dr;
        }

        public OracleDataReader Kayit_insert_DataReader(string turadi, int durum, string adsoyad, string tc, string telno, string odatipi)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader("insert into Kayitlar(TurID, Durum, AdSoyad, Tc, TelNo, OdaTipi) values(" + "(select TurID FROM Tur where Adi='" + turadi + "')" + "," + durum + ",'" + adsoyad + "','" + tc + "','" + telno + "','" + odatipi + "')");

            return dr;
        }
        public OracleDataReader MüsKayit_insert_DataReader(string turadi, int durum, string adsoyad, string tc, string telno, string odatipi, string kullaniciad, string sifre)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader("insert into Kayitlar(TurID, Durum, AdSoyad, Tc, TelNo, OdaTipi,MusID) values(" + "(select TurID FROM Tur where Adi='" + turadi + "')" + "," + durum + ",'" + adsoyad + "','" + tc + "','" + telno + "','" + odatipi + "', (select ID from Login where KullaniciAdi='" + kullaniciad + "' and Sifre='" + sifre + "'))");

            return dr;
        }

        //public OracleDataReader Login_insert_DataReader(string adsoyad, string tc, string kullaniciadi, string sifre, string telno, string sehir)
        //{
        //    OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(string.Format("BEGIN " + " SP_LOGIN_INSERT ( '{0}','{1}','{2}','{3}','{4}','{5}');", adsoyad, tc, kullaniciadi, sifre, telno, sehir) + " END");
        //    return dr;
        //}


        public OracleDataReader Tur_insert(string adi, string bilgi, string tarih, int durum, int tek, int cift, int dort, int kontenjan, string tip)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader("insert into Tur(Adi, Bilgi, Tarih, Durum, Tekfiyat, Ciftfiyat, Dortfiyat, Kontenjan, Tip) values('"+adi+"', '"+bilgi+"', '"+tarih+"'," +durum+", "+tek+", "+cift+"," +dort+"," +kontenjan+", '"+tip+"')");
            return dr;
        }
       
        public OracleDataReader Tur_updata(string adi, string bilgi, string tarih, int durum, int tek, int cift, int dort, int kontenjan, string tip, int id)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" UPDATE Tur SET Adi = '"+adi+"', Bilgi = '"+bilgi+"', Tarih = '"+tarih+"', Durum = "+durum+", Tekfiyat = "+tek+", Ciftfiyat = "+cift+", Dortfiyat = "+dort+", Kontenjan = "+kontenjan+", Tip = '"+tip+"' WHERE TurID = "+id+"");
            return dr;
        }

        public OracleDataReader Tur_delete(string adi, string tip)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader("delete Tur where Adi = '"+adi+"'   and Tip = '"+tip+"'");
            return dr;
        }
        public OracleDataReader Login_delete(string adi, string sifre)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader("delete Login where KullaniciAdi = '" + adi + "'   and Sifre = '" + sifre + "'");
            return dr;
        }

        public OracleDataReader kayit_delete(int kayitid)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader("delete Kayitlar where KayitID = "+kayitid+"");
            return dr;
        }





        public DataTable Kayitlar_select()
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select Kayitlar.*, Tur.Adi, Tur.Bilgi, Tur.Tarih, Tur.Tip from Kayitlar LEFT JOIN Tur on Kayitlar.TurID = Tur.TurID");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable MusKayitlar_select(int müsid)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select Kayitlar.*, Tur.Adi, Tur.Bilgi, Tur.Tarih, Tur.Tip from Kayitlar LEFT JOIN Tur on Kayitlar.TurID = Tur.TurID WHERE MusID="+müsid+"");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable ara_select(int müsid, string tip, string a)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select Kayitlar.*, Tur.Adi, Tur.Bilgi, Tur.Tarih, Tur.Tip from Kayitlar LEFT JOIN Tur on Kayitlar.TurID = Tur.TurID WHERE MusID=" + müsid + " and "+tip+"='"+a+"'");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable ara2_select(int müsid, string tip, string a)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select Kayitlar.*, Tur.Adi, Tur.Bilgi, Tur.Tarih, Tur.Tip from Kayitlar LEFT JOIN Tur on Kayitlar.TurID = Tur.TurID WHERE MusID=" + müsid + " and " + tip + "=" + a + "");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable adminara_select( string tip, string a)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select Kayitlar.*, Tur.Adi, Tur.Bilgi, Tur.Tarih, Tur.Tip from Kayitlar LEFT JOIN Tur on Kayitlar.TurID = Tur.TurID WHERE " + tip + "='" + a + "'");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable adminara2_select(string tip, string a)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select Kayitlar.*, Tur.Adi, Tur.Bilgi, Tur.Tarih, Tur.Tip from Kayitlar LEFT JOIN Tur on Kayitlar.TurID = Tur.TurID WHERE " + tip + "=" + a + "");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable tur_select(String tip)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select* from Tur where Tip='"+tip+ "' ");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable turbilgi_select(String turadi)
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select* from Tur where Adi='" + turadi + "' ");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable aktif_select()
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select * from Tur where Durum=1 ");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable pasif_select()
        {
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select * from Tur where Durum=0 ");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable login_select(string kullaniciadi, string sifre)
        {
            
            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select * from Login where KullaniciAdi='" + kullaniciadi + "' and Sifre='" + sifre + "' ");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable kullaniciadi_select(string kullaniciadi)
        {

            OracleDataReader dr = anaekran.baglanti.Db_Connect.Oracle_DataReader(" select * from Login where KullaniciAdi='" + kullaniciadi + "'");
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }




    }
}
