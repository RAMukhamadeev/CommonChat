using System.Data.SqlClient;
using System.Windows.Forms;

namespace CommonChat
{
    public static class SqlLibrary
    {
        public static SqlDataReader ExecuteQuery(string queryString)
        {
            SqlConnectionStringBuilder connPar = new SqlConnectionStringBuilder
            {
                DataSource = "lt294ggsgu.database.windows.net",
                InitialCatalog = "chat_db",
                Encrypt = true,
                TrustServerCertificate = false,
                UserID = "chat_db_user",
                Password = "VeryGoodPassword123"
            };
            SqlDataReader data;
            using (SqlConnection connection = new SqlConnection(connPar.ToString()))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                data = command.ExecuteReader();
            }
            return data;
        }
    }
}
