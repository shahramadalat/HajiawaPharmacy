using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows;

namespace PharmacyHajiawa.Class
{
    public class Query
    {
        #region excution
        public Task<int> ExcuteAsyncTrans(List<string> queries)
        {
            classConnection con = new classConnection();
            classConnection.con.Open();
            SqlTransaction trans = classConnection.con.BeginTransaction();
            try
            {
                SqlCommand command;
                foreach (var item in queries)
                {
                    command = new SqlCommand(item, classConnection.con, trans);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("سەرکەوتو بوو");
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message+"\n سەرکەوتوو نەبوو");
            }
            return Task.FromResult(0);
        }
        public Task<int> ExcuteAsync(string query)
        {
            classConnection c = new classConnection();
            using (SqlCommand command = new SqlCommand(query, classConnection.con))
            {
                classConnection.con.Open();
                command.ExecuteNonQuery();
                classConnection.con.Close();
            }
            return Task.FromResult(0);
            // return await con.QueryFirstOrDefaultAsync<PersonTable>("Select * from PersonTable where Id=@id",new {id});
        }
        public Task<int> ExcuteProcedureAsyncWithParameter(string query,string[,] parameter)
        {
            classConnection c = new classConnection();
            using (SqlCommand command = new SqlCommand(query, classConnection.con))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                for (int i = 0; i <= parameter.GetUpperBound(0); i++)
                {
                    command.Parameters.AddWithValue(parameter[i,0],parameter[i,1]);
                }
                classConnection.con.Open();
                command.ExecuteNonQuery();
                classConnection.con.Close();
            }
            return Task.FromResult(0);
        }
        public Task<int> Excute(string query)
        {
            classConnection c = new classConnection();
            using (SqlCommand command = new SqlCommand(query, classConnection.con))
            {
                classConnection.con.Open();
                command.ExecuteNonQuery();
                classConnection.con.Close();
            }
            return Task.FromResult(0); ;

        }

        #endregion


        public bool isExist(string query, string[,] parameter)
        {
            classConnection c = new classConnection();
            classConnection.con.OpenAsync();
            SqlCommand command = new SqlCommand(query, classConnection.con);
            for (int i = 0; i <= parameter.GetUpperBound(0); i++)
            {
                command.Parameters.AddWithValue(parameter[i, 0], parameter[i, 1]);
            }
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int result = int.Parse(reader[0].ToString());
                if (result is 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }

        public Task<string> GetOneNoParameter(string query)
        {
            classConnection c = new classConnection();
            SqlCommand command = new SqlCommand(query, classConnection.con);
            classConnection.con.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return Task.FromResult(reader[0].ToString());
            }
            classConnection.con.Close();

            return Task.FromResult("0");
        }
        public Task<string> GetOneProcedure(string query, string[,] para)
        {
            classConnection c = new classConnection();
            classConnection.con.Open();
            SqlCommand command = new SqlCommand(query, classConnection.con);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            for (int i = 0; i <= para.GetUpperBound(0); i++)
            {
                command.Parameters.AddWithValue(para[i, 0], para[i, 1]);
            }
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return Task.FromResult(reader[0].ToString());
            }
            classConnection.con.Close();

            return Task.FromResult("error");
        }
        public Task<string> GetOne(string query, string[,] para)
        {
                classConnection c = new classConnection();
            classConnection.con.Open();
            SqlCommand command = new SqlCommand(query, classConnection.con);
            for (int i = 0; i <= para.GetUpperBound(0); i++)
            {
                command.Parameters.AddWithValue(para[i, 0], para[i, 1]);
            }
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string result = reader[0].ToString();
                    return Task.FromResult(result);
            }
            classConnection.con.Close();

            return Task.FromResult("0");
        }
        public static string FirstValue;
        public static string SecondValue;
        public static string ThirdValue;
        public Task<string> GetTwo(string query,int valuecount)
        {
            classConnection c = new classConnection();
            SqlCommand command = new SqlCommand(query,classConnection.con);
            classConnection.con.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (valuecount==0)
                {
                    FirstValue = reader[0].ToString();
                    return Task.FromResult(reader[0].ToString());
                }
                else if (valuecount==1)
                {
                    FirstValue = reader[0].ToString();
                    SecondValue = reader[1].ToString();
                }
                else if (valuecount==2)
                {
                    FirstValue = reader[0].ToString();
                    SecondValue = reader[1].ToString();
                    ThirdValue = reader[2].ToString();
                }
               
            }
            classConnection.con.Close();
            return Task.FromResult(query);

        }
        public string GetLastId(string columnName, string tableName)
        {
            
            classConnection c = new classConnection();
            classConnection.con.Open();
            SqlCommand command = new SqlCommand($"SELECT TOP 1 {columnName} FROM {tableName} ORDER BY {columnName} DESC  ", classConnection.con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return reader[0].ToString();
            }
            classConnection.con.Close();
            return "0";

        }
        public Task<string> GetLastIdAsync(string columnName, string tableName)
        {
            classConnection c = new classConnection();
            classConnection.con.Open();
            SqlCommand command = new SqlCommand($"SELECT TOP 1 {columnName} FROM {tableName} ORDER BY {columnName} DESC  ", classConnection.con);
            SqlDataReader reader = command.ExecuteReader();

            //SqliteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return Task.FromResult(reader[0].ToString());
            }
            classConnection.con.Close();
            return Task.FromResult("0");

        }
        #region creation

        public Task<int> CreateIndexAsync(string IndexName, string TableName, string[] columns)
        {
            classConnection c = new classConnection();
            SqlCommand command1 = new SqlCommand($"SELECT count(*) FROM sys.indexes WHERE name='{IndexName}';", classConnection.con);
            classConnection.con.Open();
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                if (int.Parse(reader[0].ToString()) == 1)
                {
                    classConnection.con.Close();
                    return Task.FromResult(0);
                }
            }
            string SplitedColumns = string.Join(",", columns);
            string sql = $"CREATE INDEX {IndexName} ON {TableName}({SplitedColumns})";
            SqlCommand command = new SqlCommand(sql, classConnection.con);
            command.ExecuteNonQueryAsync();
            classConnection.con.Close();
            return Task.FromResult(0);
        }
        public Task<int> CreateTableAsync(string TableName, string[] ColumnWithProperty)
        {
            string splitedcolumns = string.Join(",", ColumnWithProperty);
            classConnection c = new classConnection();
            SqlCommand command = new SqlCommand($"CREATE TABLE IF NOT EXISTS {TableName} ({splitedcolumns});", classConnection.con);
            classConnection.con.OpenAsync();
            command.ExecuteNonQuery();
            classConnection.con.CloseAsync();
            return Task.FromResult(0);
        }

        #endregion
        #region insert update
        private string[] PropertiesName(object atype)
        {
          
            if (atype == null) return new string[] { };
            Type t = atype.GetType();
            PropertyInfo[] props = t.GetProperties();
            List<string> propNames = new List<string>();
            foreach (PropertyInfo prp in props)
            {
                if (GetPropValue(atype, prp.Name).ToString() is "0" || GetPropValue(atype, prp.Name).ToString() is null)
                {
                    continue;
                }
                propNames.Add(prp.Name.ToString());
            }
            return propNames.ToArray();
        }
        private string[] PropertiesValue(object atype)
        {
            if (atype == null) return new string[] { };
            Type t = atype.GetType();
            PropertyInfo[] props = t.GetProperties();
            List<string> propNames = new List<string>();
            foreach (PropertyInfo prp in props)
            {
                if (GetPropValue(atype, prp.Name).ToString() is "0")
                {
                    continue;
                }
                propNames.Add(GetPropValue(atype, prp.Name).ToString());
            }
            return propNames.ToArray();
        }
        private object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
        public Task<int> InsertAsync(object Model)
        {
            classConnection c = new classConnection();
            string joinedName = string.Join(",", PropertiesName(Model));
            var joinedValue = "\'" + string.Join("\', \'", PropertiesValue(Model)) + "\'";
            string sql = $"insert into {Model.GetType().Name}({joinedName}) values({joinedValue}) ;";
            SqlCommand command = new SqlCommand(sql,classConnection.con);
            classConnection.con.Open();
            command.ExecuteNonQuery();
            classConnection.con.Close();
            return Task.FromResult(0);
        }
        public Task<int> UpdateAsync(object Model,string? where)
        {
            classConnection c = new classConnection();
            string joinedName = string.Join(",", PropertiesName(Model));
            var joinedValue = "\'" + string.Join("\', \'", PropertiesValue(Model)) + "\'";
            List<string> ss = new List<string>();
           
             for (int i = 0; i < PropertiesName(Model).Length; i++)
             {
             
                    ss.Add(PropertiesName(Model)[i]+"='"+PropertiesValue(Model)[i]+"'");
             
             }
            string NameWithValues= string.Join(",", ss);
            string sql = $"update {Model.GetType().Name} set {NameWithValues} {where}  ;";
            SqlCommand command = new SqlCommand(sql, classConnection.con);
            classConnection.con.Open();
            command.ExecuteNonQuery();
            classConnection.con.Close();
            return Task.FromResult(0);
        }
        #endregion
        public Task<int> ExecProcedure()
        {
            return Task.FromResult(0);
        }




    }
}
