using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;

namespace SporSalonuOtomasyonu
{
    class RandevuIslemleri
    {
        public string RandevuEkle(string spor_adi, string giristarihi, string saat,int uye_id )
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_RANDEVU_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_SPOR_ADI", OracleDbType.Varchar2, 20).Value = spor_adi;
                command.Parameters.Add("@P_GIRISTARIHI", OracleDbType.Varchar2, 20).Value = giristarihi;
                command.Parameters.Add("@P_SAAT", OracleDbType.Varchar2, 20).Value = saat;
              command.Parameters.Add("@P_UYE_ID", OracleDbType.Int32).Value = uye_id;
                
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "RANDEVU KAYDI Başarılı";

            }


            catch (Exception)
            {
                sonuc = "RANDEVU Kayıdı Hatalı";

            }


            return sonuc;
        }
        public string RandevuGuncelle(int userid, string spor_adi, string giristarihi, string saat)
        {
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

                OracleCommand command = new OracleCommand("PROC_RANDEVU_GUNCELLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_USER_ID", OracleDbType.Varchar2, 20).Value = userid;
                command.Parameters.Add("@P_SPOR_ADI", OracleDbType.Varchar2, 20).Value = spor_adi;
                command.Parameters.Add("@P_GIRISTARIHI", OracleDbType.Varchar2, 20).Value = giristarihi;
                command.Parameters.Add("@P_SAAT", OracleDbType.Varchar2, 20).Value = saat;
                
                



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
         public string RANDEVUSil(int userid)
        {
            string sonuc;

            OracleConnection connect = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");

            OracleCommand command = new OracleCommand("PROC_RANDEVU_SIL", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@P_USER_ID", OracleDbType.Varchar2, 20).Value = userid;

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
            sonuc = "Silme İşlemi Başarılı";



            return sonuc;
        }
    }
}
