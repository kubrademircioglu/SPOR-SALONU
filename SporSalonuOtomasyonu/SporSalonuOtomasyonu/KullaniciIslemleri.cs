using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
namespace SporSalonuOtomasyonu
{
    class KullaniciIslemleri
    {

        public string PKayitEkle(string ad, string soyad, string yas, string cinsiyet, string eposta, string maas, string adres, string yetki, string tc, string telefon, String gorev, string girisTarihi,string username,string sifre)
        {
            
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_PERSONEL_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_AD", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_SOYAD", OracleDbType.Varchar2, 20).Value = soyad;
                command.Parameters.Add("@P_YAS", OracleDbType.Varchar2, 20).Value = yas;
                command.Parameters.Add("@P_CINSIYET", OracleDbType.Varchar2, 20).Value = cinsiyet;
               
                command.Parameters.Add("@P_EPOSTA", OracleDbType.Varchar2, 20).Value = eposta;
                command.Parameters.Add("@P_MAAS", OracleDbType.Varchar2, 20).Value = maas;
                command.Parameters.Add("@P_ADRES", OracleDbType.Varchar2, 20).Value = adres;

                command.Parameters.Add("@P_YETKI", OracleDbType.Varchar2, 20).Value = yetki;
                command.Parameters.Add("@P_TC", OracleDbType.Varchar2, 20).Value = tc;
                command.Parameters.Add("@P_TELEFON", OracleDbType.Varchar2, 20).Value = telefon;
                command.Parameters.Add("@P_GOREV", OracleDbType.Varchar2, 20).Value = gorev;
                command.Parameters.Add("@P_GIRISTARIHI", OracleDbType.Varchar2, 20).Value = girisTarihi;
                command.Parameters.Add("@P_USERNAME", OracleDbType.Varchar2, 20).Value = username;
                command.Parameters.Add("@P_SIFRE", OracleDbType.Varchar2, 20).Value = sifre;
                
                
                









                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Kayıt Başarılı";

            }


            catch (Exception)
            {
                sonuc = "Kayıt Hatalı";

            }


            return sonuc;
        }
        public string PKayitSil(int userid)
        {
            string sonuc;

            OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

            OracleCommand command = new OracleCommand("PROC_PERSONEL_SIL", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@P_USER_ID", OracleDbType.Varchar2, 20).Value = userid;

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
            sonuc = "Silme İşlemi Başarılı";



            return sonuc;
        }
        
        public string PKayitGuncelle(int userid,string ad, string soyad, string yas, string cinsiyet, string eposta, string maas, string adres, string yetki, string tc, string telefon, String gorev, string girisTarihi,string username,string sifre)
        {
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_PERSONEL_GUNCELLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_USER_ID", OracleDbType.Varchar2, 20).Value = userid;
                command.Parameters.Add("@P_AD", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_SOYAD", OracleDbType.Varchar2, 20).Value = soyad;
                command.Parameters.Add("@P_YAS", OracleDbType.Varchar2, 20).Value = yas;
                command.Parameters.Add("@P_CINSIYET", OracleDbType.Varchar2, 20).Value = cinsiyet;

                command.Parameters.Add("@P_EPOSTA", OracleDbType.Varchar2, 20).Value = eposta;
                command.Parameters.Add("@P_MAAS", OracleDbType.Varchar2, 20).Value = maas;
                command.Parameters.Add("@P_ADRES", OracleDbType.Varchar2, 20).Value = adres;

                command.Parameters.Add("@P_YETKI", OracleDbType.Varchar2, 20).Value = yetki;
                command.Parameters.Add("@P_TC", OracleDbType.Varchar2, 20).Value = tc;
                command.Parameters.Add("@P_TELEFON", OracleDbType.Varchar2, 20).Value = telefon;
                command.Parameters.Add("@P_GOREV", OracleDbType.Varchar2, 20).Value = gorev;
                command.Parameters.Add("@P_GIRISTARIHI", OracleDbType.Varchar2, 20).Value = girisTarihi;
                command.Parameters.Add("@P_USERNAME", OracleDbType.Varchar2, 20).Value = username;
                command.Parameters.Add("@P_SIFRE", OracleDbType.Varchar2, 20).Value = sifre;

                

                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Güncelleme Başarılı";
            }
            catch (Exception e)
            {
                sonuc = "Güncelleme Hatalı";
            }
            return sonuc;

        }

       

    }
    
}
