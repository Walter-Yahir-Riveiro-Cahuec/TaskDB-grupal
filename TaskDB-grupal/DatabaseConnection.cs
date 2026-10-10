using System.Configuration;
using Microsoft.Data.SqlClient;

namespace TaskDB
{
    public static class DatabaseConnection
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["TaskDB"].ConnectionString;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
