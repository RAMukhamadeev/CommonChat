using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CommonChat
{
    public static class SqlLibrary
    {
        public static DataTable GetAllMessages()
        {
            string query = String.Format("SELECT * FROM Messages ORDER BY Number;");
            DataTable dt = null;
            try
            {
                dt = ExecuteQuery(query);
            }
            catch
            {
                // ignored
            }
            return dt;
        }

        public static long CountOfMessages()
        {
            string query = "SELECT COUNT(*) FROM Messages;";
            long res;

            try
            {
                DataTable dt = ExecuteQuery(query);
                res = Int64.Parse(dt.Rows[0].ItemArray[0].ToString());
            }
            catch
            {
                res = -1;
            }

            return res;
        }

        public static string SendMessage(string email, string firstName, string lastName, string message)
        {
            string query =
                String.Format(
                    "INSERT INTO Messages (AuthorEmail, FirstName, LastName, Message, DateOfMessage) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', '{4}');",
                    email,
                    firstName,
                    lastName,
                    message,
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    );

            string res = "";
            try
            {
                ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                res += "Сообщение отправить не удалось :( \n" + ex.Message;
            }

            return res;
        }

        public static DataTable Login(string email, string password)
        {
            string query =
                String.Format(
                    "SELECT * FROM Users WHERE Email = '{0}' AND PasswordHash = '{1}';", 
                    email,
                    CalcHash(password)
                    );
            DataTable dt = null;
            try
            {
                dt = ExecuteQuery(query);
            }
            catch
            {
                // ignored
            }

            return dt;
        }

        private static string CalcHash(string password)
        {
            long res = password.Aggregate<char, long>(1, (current, t) => ((current + t) * 3557) % 68718952447);
            return res.ToString();
        }

        public static string RegistrationOfNewUser(string email, string password, string firstName, string lastName)
        {
            string query =
                String.Format(
                    "INSERT INTO Users (Email, PasswordHash, FirstName, LastName, DateOfRegistration) VALUES ( N'{0}', '{1}', N'{2}', N'{3}', '{4}');",
                    email,
                    CalcHash(password),
                    firstName,
                    lastName,
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    );

            string res = "";
            try
            {
                ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                res += "Регистрация не удалась :( \n" + ex.Message;
                return res;
            }

            res += "Регистрация прошла успешно!";
            return res;
        }

        public static DataTable ExecuteQuery(string queryString)
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
            
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connPar.ToString()))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader sdr = command.ExecuteReader();
                dt.Load(sdr);
                sdr.Close();
            }

            return dt;
        }
    }
}
