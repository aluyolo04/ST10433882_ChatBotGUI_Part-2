using MySql.Data.MySqlClient;

namespace CyberlinkGUI
{
    public class Database
    {
        private string connectionString =
            "server=localhost;database=CyberSecurityChatbot;uid=root;pwd=aviweaphinda13_;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}