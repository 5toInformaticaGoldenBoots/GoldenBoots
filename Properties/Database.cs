using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GoldenBoots
{
    public class Database : IDisposable
    {
        private string _connectionString;
        private SqlConnection _sqlConnection;

        public Database(string server = "localhost,1433", string database = "GoldenBoots", bool trustedConnection = true)
        {
            this._connectionString = $"Server={server};Database={database};Trusted_Connection={trustedConnection};TrustServerCertificate=True;";
            this._sqlConnection = new SqlConnection(this._connectionString);
            this._sqlConnection.Open();
        }

        public void Dispose()
        {
            if (_sqlConnection != null)
            {
                _sqlConnection.Close();
                _sqlConnection.Dispose();
            }
        }

        public void Execute(string query, Dictionary<string, object> parameters = null)
        {
            using (var cmd = new SqlCommand(query, _sqlConnection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue($"@{param.Key}", param.Value);
                    }
                }
                cmd.ExecuteNonQuery();
            }
        }

        public List<object[]> Query(string query, Dictionary<string, object> parameters = null)
        {
            List<object[]> result = new List<object[]>();
            using (SqlCommand command = new SqlCommand(query, _sqlConnection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue($"@{param.Key}", param.Value);
                    }
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);
                        result.Add(data);
                    }
                }
            }
            return result;
        }

        public object[] QueryOne(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlCommand command = new SqlCommand(query, _sqlConnection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue($"@{param.Key}", param.Value);
                    }
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);
                        return data;
                    }
                }
            }
            return null;
        }
    }
}