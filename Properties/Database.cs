using Microsoft.Data.SqlClient;

namespace GoldenBoots
{
    internal class RowArray
    {
        private object[] _row;

        public RowArray(int length)
        {
            this._row = new object[length];
        }
    }

    internal class RowList
    {
        private List<object> _row = new();

        public RowList()
        {
            
        }
    }

    internal class Database
    {
        private string _connectionString;
        private SqlConnection _sqlConnection;

        public Database(string server = "localhost", string database = "GoldenBoots", bool trustedConnection = true)
        {
            this._connectionString = $"Server={server};Database={database};Trusted_Connection={trustedConnection};Encrypt=False;";
            this._sqlConnection = new SqlConnection(this._connectionString);
            this._sqlConnection.Open();
        }

        public void Execute(string query)
        {

            using (SqlCommand command = new SqlCommand(query, this._sqlConnection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void _InsertDataArray(SqlDataReader reader, object[] array)
        {
            reader.GetValues(array);
        }

        private object[] _ReadReaderArray(SqlDataReader reader)
        {
            int maxColumns = reader.FieldCount;
            object[] data = new object[maxColumns];

            this._InsertDataArray(reader, data);

            return data;
        }

        private Dictionary<string, object> _ReadReaderDict(SqlDataReader reader)
        {
            Dictionary<string, object> answer = new();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                answer.Add(reader.GetName(i), reader.GetValue(i));
            }

            return answer;
        }

        public List<object[]> Select(string query)
        {
            SqlCommand command = new SqlCommand(query, this._sqlConnection);
            
            List<object[]> result = [];

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(this._ReadReaderArray(reader));
                }
            }

            return result;
        }

        public object[] SelectOne(string query)
        {
            SqlCommand command = new SqlCommand(query, this._sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                int maxColumns = reader.FieldCount;

                object[] data = new object[maxColumns];

                reader.Read();
                return this._ReadReaderArray(reader);
            }
        }

        public List<Dictionary<string, object>> SelectDict(string query)
        {
            List<Dictionary<string, object>> answer = [];

            SqlCommand command = new(query, this._sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    answer.Add(this._ReadReaderDict(reader));
                }
            }

            return answer;
        }

        public void Close()
        {
            this._sqlConnection.Close();
        }

        public void Open()
        {
            this._sqlConnection.Open();
        }
    }
}