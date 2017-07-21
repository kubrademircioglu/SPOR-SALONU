using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
namespace SporSalonuOtomasyonu
{
    class UyeIslemleri
    {
        public string UKayitEkle(string ad, string soyad, string dogumTarihi, string cinsiyet, string uyetarihi, string kayitzamani, string uyebitis, string telefon, string tc, string boy, string kilo, string meslek, string aylikucret, string adres, string acildurumtel, string yakinlik, string eposta, string aktiflik_durumu)
        {
            
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_UYE_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_AD", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_SOYAD", OracleDbType.Varchar2, 20).Value = soyad;
                command.Parameters.Add("@P_DOGUMTARIHI", OracleDbType.Varchar2, 20).Value = dogumTarihi;
                command.Parameters.Add("@P_CINSIYET", OracleDbType.Varchar2, 20).Value = cinsiyet;
                command.Parameters.Add("@P_UYETARIHI", OracleDbType.Varchar2, 20).Value = uyetarihi;
                command.Parameters.Add("@P_KAYITZAMANI", OracleDbType.Varchar2, 20).Value = kayitzamani;
                command.Parameters.Add("@P_UYEBITIS", OracleDbType.Varchar2, 20).Value = uyebitis;
                command.Parameters.Add("@P_TELEFON", OracleDbType.Varchar2, 20).Value = telefon;
                command.Parameters.Add("@P_TC", OracleDbType.Varchar2, 20).Value = tc;
                command.Parameters.Add("@P_BOY", OracleDbType.Varchar2, 20).Value = boy;
                command.Parameters.Add("@P_KILO", OracleDbType.Varchar2, 20).Value = kilo;
                command.Parameters.Add("@P_MESLEK", OracleDbType.Varchar2, 20).Value = meslek;
                command.Parameters.Add("@P_AYLIKUCRET", OracleDbType.Varchar2, 20).Value = aylikucret;
                command.Parameters.Add("@P_ADRES", OracleDbType.Varchar2, 20).Value = adres;
                command.Parameters.Add("@P_ACILDURUMTEL", OracleDbType.Varchar2, 20).Value = acildurumtel;
                command.Parameters.Add("@P_YAKINLIK", OracleDbType.Varchar2, 20).Value = yakinlik;
                command.Parameters.Add("@P_EPOSTA", OracleDbType.Varchar2, 20).Value = eposta;
                command.Parameters.Add("@P_AKTIFLIK_DURUMU", OracleDbType.Varchar2, 20).Value = aktiflik_durumu;
              
               
               
                
                
                
                









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


        public string UKayitGuncelle(int userid,string ad, string soyad, string dogumTarihi, string cinsiyet, string uyetarihi, string kayitzamani, string uyebitis, string telefon, string tc, string boy, string kilo, string meslek, string aylikucret, string adres, string acildurumtel, string yakinlik, string eposta, string  aktiflik_durumu)
        {
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_UYE_GUNCELLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_USER_ID", OracleDbType.Varchar2, 20).Value = userid;
                command.Parameters.Add("@P_AD", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_SOYAD", OracleDbType.Varchar2, 20).Value = soyad;
                command.Parameters.Add("@P_DOGUMTARIHI", OracleDbType.Varchar2, 20).Value = dogumTarihi;
                command.Parameters.Add("@P_CINSIYET", OracleDbType.Varchar2, 20).Value = cinsiyet;
                command.Parameters.Add("@P_UYETARIHI", OracleDbType.Varchar2, 20).Value = uyetarihi;
                command.Parameters.Add("@P_KAYITZAMANI", OracleDbType.Varchar2, 20).Value = kayitzamani;
                command.Parameters.Add("@P_UYEBITIS", OracleDbType.Varchar2, 20).Value = uyebitis;
                command.Parameters.Add("@P_TELEFON", OracleDbType.Varchar2, 20).Value = telefon;
                command.Parameters.Add("@P_TC", OracleDbType.Varchar2, 20).Value = tc;
                command.Parameters.Add("@P_BOY", OracleDbType.Varchar2, 20).Value = boy;
                command.Parameters.Add("@P_KILO", OracleDbType.Varchar2, 20).Value = kilo;
                command.Parameters.Add("@P_MESLEK", OracleDbType.Varchar2, 20).Value = meslek;
                command.Parameters.Add("@P_AYLIKUCRET", OracleDbType.Varchar2, 20).Value = aylikucret;
                command.Parameters.Add("@P_ADRES", OracleDbType.Varchar2, 20).Value = adres;
                command.Parameters.Add("@P_ACILDURUMTEL", OracleDbType.Varchar2, 20).Value = acildurumtel;
                command.Parameters.Add("@P_YAKINLIK", OracleDbType.Varchar2, 20).Value = yakinlik;
                command.Parameters.Add("@P_EPOSTA", OracleDbType.Varchar2, 20).Value = eposta;
                command.Parameters.Add("@P_AKTIFLIK_DURUMU", OracleDbType.Varchar2, 20).Value = aktiflik_durumu;
              



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
        public string UDONDURMMA(int userid, string ad, string soyad, string dogumTarihi, string cinsiyet, string uyetarihi, string kayitzamani, string uyebitis, string telefon, string tc, string boy, string kilo, string meslek, string aylikucret, string adres, string acildurumtel, string yakinlik, string eposta, string aktiflik_durumu)
        {
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_UYE_DONDURMA", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_USER_ID", OracleDbType.Varchar2, 20).Value = userid;
                command.Parameters.Add("@P_AD", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_SOYAD", OracleDbType.Varchar2, 20).Value = soyad;
                command.Parameters.Add("@P_DOGUMTARIHI", OracleDbType.Varchar2, 20).Value = dogumTarihi;
                command.Parameters.Add("@P_CINSIYET", OracleDbType.Varchar2, 20).Value = cinsiyet;
                command.Parameters.Add("@P_UYETARIHI", OracleDbType.Varchar2, 20).Value = uyetarihi;
                command.Parameters.Add("@P_KAYITZAMANI", OracleDbType.Varchar2, 20).Value = kayitzamani;
                command.Parameters.Add("@P_UYEBITIS", OracleDbType.Varchar2, 20).Value = uyebitis;
                command.Parameters.Add("@P_TELEFON", OracleDbType.Varchar2, 20).Value = telefon;
                command.Parameters.Add("@P_TC", OracleDbType.Varchar2, 20).Value = tc;
                command.Parameters.Add("@P_BOY", OracleDbType.Varchar2, 20).Value = boy;
                command.Parameters.Add("@P_KILO", OracleDbType.Varchar2, 20).Value = kilo;
                command.Parameters.Add("@P_MESLEK", OracleDbType.Varchar2, 20).Value = meslek;
                command.Parameters.Add("@P_AYLIKUCRET", OracleDbType.Varchar2, 20).Value = aylikucret;
                command.Parameters.Add("@P_ADRES", OracleDbType.Varchar2, 20).Value = adres;
                command.Parameters.Add("@P_ACILDURUMTEL", OracleDbType.Varchar2, 20).Value = acildurumtel;
                command.Parameters.Add("@P_YAKINLIK", OracleDbType.Varchar2, 20).Value = yakinlik;
                command.Parameters.Add("@P_EPOSTA", OracleDbType.Varchar2, 20).Value = eposta;
                command.Parameters.Add("@P_AKTIFLIK_DURUMU", OracleDbType.Varchar2, 20).Value = aktiflik_durumu;




                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "DONDURMA Başarılı";
            }
            catch (Exception e)
            {
                sonuc = "DONDURMA Hatalı";
            }
            return sonuc;

        }
        public string UKayitSil(int userid)
        {
            string sonuc;

            OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

            OracleCommand command = new OracleCommand("PROC_UYE_SIL", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@P_USER_ID", OracleDbType.Varchar2, 20).Value = userid;

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
            sonuc = "Silme İşlemi Başarılı";



            return sonuc;
        }





        internal static string UKayitGuncelle(int userid, string p, string p_2, string p_3, string p_4, string donustur3, string p_5, string donustur4, string p_6, string p_7, string p_8, string p_9, string p_10, string p_11, string p_12)
        {
            throw new NotImplementedException();
        }
    }
}
