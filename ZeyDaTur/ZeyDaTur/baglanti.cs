using System;
using WindowsFormsApp4;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
//using System.Data.OracleClient;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;

namespace anaekran

{
    class baglanti
    {

        public class Db_Connect
        {

            public static string GetConnectionString()
            {
                //OracleConnection baglanti = new OracleConnection();
                //baglanti.ConnectionString = "Data Source=XE;User ID=damla;Password=damla ;Unicode=True";
                return "Data Source=XE; User ID=tur;Password=tur "; 
            }


            public static OracleDataReader Oracle_DataReader(string queryString)
            {
                //OracleConnection.ClearAllPools();

                OracleDataReader dr = null;
                OracleConnection baglanti = new OracleConnection(GetConnectionString());



                OracleCommand komut  = new OracleCommand(queryString, baglanti);
                //komut.CommandType = CommandType.Text;
                baglanti.Open();
                //OracleDataAdapter da = new OracleDataAdapter(komut);
                //komut.ExecuteNonQuery();
                //baglanti.Close();
                dr = komut.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
        }
    }
}
