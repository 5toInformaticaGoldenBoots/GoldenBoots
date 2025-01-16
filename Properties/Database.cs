using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GoldenBoots
{
    internal class Database
    {
        private string _connectionString;
        private SqlConnection _sqlConnection;

        public Database(string server = "localhost,1433", string database = "GoldenBoots", bool trustedConnection = true)
        {
            this._connectionString = $"Server={server};Database={database};Trusted_Connection={trustedConnection};TrustServerCertificate=True;";
            this._sqlConnection = new SqlConnection(this._connectionString);
        }

        public void Execute(string query)
        {
            using (SqlConnection conn = this._sqlConnection)
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<object[]> Query(string query)
        {
            using (SqlConnection conn = this._sqlConnection)
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                List<object[]> result = new();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int maxColumns = reader.FieldCount;
                    object[] data = new object[maxColumns];

                    while (reader.Read())
                    {
                        for (int i = 0; i < maxColumns; i++)
                        {
                            data[i] = reader.GetValue(i);
                        }

                        result.Add(data);
                    }
                }

                return result;
            }
        }
    }
}
