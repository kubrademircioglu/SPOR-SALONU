using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;

namespace SporSalonuOtomasyonu
{
    class KullaniciGirisi
    {
        string username;


        private string kullaniciAdi
        {
            get { return this.kullaniciAdi; }
            set { this.kullaniciAdi = value; }
        }

        private string parola
        {
            get
            { return this.parola; }
            set { this.parola = value; }
        }
        public string girisYap(string kullaniciAdi, string parola)
        {
            string sorgu = "SELECT * FROM TB_PERSONEL WHERE USERNAME='" + kullaniciAdi + "' AND SIFRE='" + parola + "'";

            OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            OracleCommand command = new OracleCommand(sorgu, connection);
            connection.Open();
            OracleDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {

                    username = reader.GetValue(8).ToString();
                }
            }
            finally
            {
                reader.Close();
            }
            return username;

        }
    }
}