using MySql.Data.MySqlClient;
using System;

namespace StudentCrudOperations
{
    class DbConfig
    {
        private static string connectionString = "server=localhost;database=university;uid=root;pwd=root;";
        private MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

        public MySqlConnection connection()
        {
            return mySqlConnection;
        }
    }
}
