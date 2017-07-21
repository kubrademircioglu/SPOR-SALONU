using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
namespace SporSalonuOtomasyonu
{
    class HocaIslemleri
    {
       
        public string HKayitEkle(string ad, string soyad, string dogumTarihi, string cinsiyet, string girisTarihi, string adres, string boy, string kilo, string brans, string maas, string tc, string eposta, string telefon, string yetki)
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_HOCA_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_AD", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_SOYAD", OracleDbType.Varchar2, 20).Value = soyad;
                command.Parameters.Add("@P_DOGUMTARIHI", OracleDbType.Varchar2, 20).Value = dogumTarihi;
                command.Parameters.Add("@P_CINSIYET", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_BASLAMATARIH", OracleDbType.Varchar2, 20).Value =girisTarihi ;
                command.Parameters.Add("@P_ADRES", OracleDbType.Varchar2, 20).Value = adres;
                command.Parameters.Add("@P_BOY", OracleDbType.Varchar2, 20).Value = boy;
                command.Parameters.Add("@P_KILO", OracleDbType.Varchar2, 20).Value = kilo;
                command.Parameters.Add("@P_BRANS", OracleDbType.Varchar2, 20).Value = brans;
                command.Parameters.Add("@P_MAAS", OracleDbType.Varchar2, 20).Value = maas;
                command.Parameters.Add("@P_TC", OracleDbType.Varchar2, 20).Value = tc;
                command.Parameters.Add("@P_EPOSTA", OracleDbType.Varchar2, 20).Value = eposta;
                command.Parameters.Add("@P_TELEFON", OracleDbType.Varchar2, 20).Value = telefon;
                command.Parameters.Add("@P_YETKI", OracleDbType.Varchar2, 20).Value = yetki;
         

                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Kayıt Başarılı";

            }catch (Exception)
            {
                sonuc = "Kayıt Hatalı";

            }


            return sonuc;
        }
        public string HKayitSil(int userid)
        {
            string sonuc;

            OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

            OracleCommand command = new OracleCommand("PROC_HOCA_SIL", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@P_USER_ID", OracleDbType.Varchar2, 20).Value = userid;

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
            sonuc = "Silme İşlemi Başarılı";



            return sonuc;
        }
         public string HKayitGuncelle(int userid, string ad, string soyad, string dogumTarihi, string cinsiyet, string girisTarihi, string adres, string boy, string kilo, string brans, string maas, string tc, string eposta, string telefon, string yetki)
        {
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_HOCA_GUNCELLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@H_USER_ID", OracleDbType.Varchar2, 20).Value = userid;
                command.Parameters.Add("@P_AD", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_SOYAD", OracleDbType.Varchar2, 20).Value = soyad;
                command.Parameters.Add("@P_DOGUMTARIHI", OracleDbType.Varchar2, 20).Value = dogumTarihi;
                command.Parameters.Add("@P_CINSIYET", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_BASLAMATARIH", OracleDbType.Varchar2, 20).Value = girisTarihi;
                command.Parameters.Add("@P_ADRES", OracleDbType.Varchar2, 20).Value = adres;
                command.Parameters.Add("@P_BOY", OracleDbType.Varchar2, 20).Value = boy;
                command.Parameters.Add("@P_KILO", OracleDbType.Varchar2, 20).Value = kilo;
                command.Parameters.Add("@P_BRANS", OracleDbType.Varchar2, 20).Value = brans;
                command.Parameters.Add("@P_MAAS", OracleDbType.Varchar2, 20).Value = maas;
                command.Parameters.Add("@P_TC", OracleDbType.Varchar2, 20).Value = tc;
                command.Parameters.Add("@P_EPOSTA", OracleDbType.Varchar2, 20).Value = eposta;
                command.Parameters.Add("@P_TELEFON", OracleDbType.Varchar2, 20).Value = telefon;
                command.Parameters.Add("@P_YETKI", OracleDbType.Varchar2, 20).Value = yetki;


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
    
