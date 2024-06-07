using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string conectionStr = "Data Source=HG;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dataTable = new DataTable();
            using(SqlConnection sqlConnection = new SqlConnection(conectionStr))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                if (parameter != null) 
                {
                    string[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (string param in listParameter) 
                    {
                        if (param.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(param, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            
            return dataTable;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int dataCount = 0;
            using (SqlConnection sqlConnection = new SqlConnection(conectionStr))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (string param in listParameter)
                    {
                        if (param.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(param, parameter[i]);
                            i++;
                        }
                    }
                }
                dataCount = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return dataCount;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object dataObject = 0;
            using (SqlConnection sqlConnection = new SqlConnection(conectionStr))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (string param in listParameter)
                    {
                        if (param.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(param, parameter[i]);
                            i++;
                        }
                    }
                }
                dataObject = sqlCommand.ExecuteScalar();
                sqlConnection.Close();
            }
            return dataObject;
        }
    }
}
