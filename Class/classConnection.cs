using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace PharmacyHajiawa.Class
{
   public class  classConnection
    {
        public static SqlConnection con;
        public classConnection()
        {
            //DESKTOP-C02I16A
            //mine:
            //DESKTOP-O9O4VUB
            string machine = Environment.MachineName;
            con = new SqlConnection(@$"Server={machine};Database=PharmasyDB;Trusted_Connection=True;");
        }
    }
}
