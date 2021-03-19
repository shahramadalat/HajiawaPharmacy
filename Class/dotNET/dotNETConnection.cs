using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace PharmacyHajiawa.Class.dotNET
{
   public  class dotNETConnection
    {

        public static SqlConnection con;
        public dotNETConnection()
        {
            string machine = Environment.MachineName;

            con = new SqlConnection(@$"Server={machine};Database=PharmasyDB;Trusted_Connection=True;");
        }
        public static List<T> ConvertSqlToList<T>(string sql)
        {
            dotNETConnection c = new dotNETConnection();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    List<T> data = new List<T>();
                    foreach (DataRow row in dt.Rows)
                    {
                        T item = GetItems<T>(row);
                        data.Add(item);
                    }
                    return data;
                }
            }
        }
        private static T GetItems<T>(DataRow dr)
        {

            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        pro.SetValue(obj, Convert.ChangeType(dr[column.ColumnName], pro.PropertyType));
                    }
                    else { 
                        continue;
                    }
                }
            }
            return obj;
        }


        public static List<T> ConvertToProcedure<T>(string sql,string[,] para)
        {
            dotNETConnection c = new dotNETConnection();
            using (SqlCommand command= con.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = sql;
                for (int i = 0; i <= para.GetUpperBound(0); i++)
                {
                    command.Parameters.AddWithValue(para[0,i],para[1,i]);
                }
                using (SqlDataAdapter da = new SqlDataAdapter(command)) 
                {
                
                    using (DataTable dt = new DataTable())
                    {
                        // da.Fill(dt);
                        List<T> data = new List<T>();
                        foreach (DataRow row in dt.Rows)
                        {
                            T item = GetItems<T>(row);
                            data.Add(item);
                        }
                        return data;
                    }

                }
            }
        }




    }
}
