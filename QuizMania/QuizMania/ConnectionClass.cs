using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuizMania
{
    public class ConnectionClass
    {

        private static SqlConnection conn;
        private static SqlCommand command;

        static ConnectionClass()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuizConnection"].ToString();
            conn = new SqlConnection(connectionString);
            command = new SqlCommand("", conn);
        }
        public static string AddUser(User user)
        {
            string query = string.Format("SELECT COUNT(*) FROM Users WHERE name = '{0}'", user.name);
            command.CommandText = query;

            try
            {
                conn.Open();
                int numUsers = (int)command.ExecuteScalar();
                if (numUsers < 1)
                {
                    query = string.Format("INSERT INTO Users VALUES('{0}', '{1}', '{2}','{3}','{4}')", user.name, user.password, user.email, 0, "0");
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    return "Registered!";
                }
                else
                {
                    return "Already registered";
                }
            }
            finally
            {
                conn.Close();
            }
        }

    }
}