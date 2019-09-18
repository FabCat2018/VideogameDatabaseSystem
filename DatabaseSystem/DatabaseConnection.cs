using System.Data.SqlClient;

namespace VideogameDatabaseSystem.DatabaseSystem
{
    class DatabaseConnection
    {
        private string connectionString = "Server=DESKTOP-U3ATH6F;Database=Videogames;Trusted_Connection=true";

        public void OpenConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }

        public void GetFromDatabase()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TableName WHERE FirstColumn = @0", connection);
            command.Parameters.Add(new SqlParameter("0", 1));
        }

        public void CloseConnection()
        {
            _conn.Close();
        }
    }
}