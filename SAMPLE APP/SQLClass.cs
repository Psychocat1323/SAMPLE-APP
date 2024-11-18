using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Drawing.Text; 

namespace SAMPLE_APP
{
    abstract class SQL_Abstract
    {

        // Change the database connection in Properties > UserSetting
        // Don't need to specificy what database this class create a database
        // if error when testing connection enable Trust Server Certificate
        protected string _connectionString
        {
            get => Properties.UserSettings.Default.ConnString;
        }

    

        protected SqlConnection OpenConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening connection: {ex.Message}");
                return null;
            }
        }

        protected void CreateDB()
        {
            string query = "IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = @dbName) " +
                           "BEGIN SELECT 1 END";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@dbName", "SampleAppDB");

                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string createDbQuery = "CREATE DATABASE SampleAppDB";
                        using (SqlCommand createDbCmd = new SqlCommand(createDbQuery, connection))
                        {
                            createDbCmd.ExecuteNonQuery();
                        }

                        CreateTable();

                    }
                    else
                    {
                        return;
                    }
                }
            }
        }


        private void CreateTable()
        {
            string query = "IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'SampleAppDB') " +
                          "BEGIN " +
                          "USE SampleAppDB; " +
                          "IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'SampleTable') " +
                          "BEGIN " +
                          "CREATE TABLE SampleTable(" +
                          "ProdID INT PRIMARY KEY," +
                          "Quantity INT," +
                          "ProdName NVARCHAR(MAX)," +
                          "DateCreated Date); " +
                          "END " +
                          "END";

            ExecuteQuery(query);
        }

        protected  void ExecuteQuery(string query)
        {
            using (SqlConnection conn = OpenConnection())
            {
                if (conn == null)
                {
                    MessageBox.Show("Failed to establish a connection.");

                }
                using (SqlCommand cmd = new SqlCommand("USE SampleAppDB " + query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        protected  SqlCommand PrepareQuery(string query)
        {
            SqlConnection conn = OpenConnection();
            if (conn == null)
            {
                MessageBox.Show("Failed to establish a connection.");
                return null;
            }
            return new SqlCommand("USE SampleAppDB " + query, conn);
        }




    }


    class SQLClass:SQL_Abstract
    {

        // Invoke Protected Function

        public async Task InvokeCreateDB()
        {
            CreateDB();
            await Task.Delay(2000);
        }
        public SqlCommand InvokePrepareQuery(string query) => PrepareQuery(query);

        public void InvokeExecuteQuery(string query) => ExecuteQuery(query);

    }
}
