using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Bootstrap_Test
{
    public class Question
    {

        public int id { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public string difficulty { get; set; }
        public string qString { get; set; }
        public string cAnswer { get; set; }
        public string wAnswer1 { get; set; }
        public string wAnswer2 { get; set; }
        public string wAnswer3 { get; set; }

        public Question(int id, string category, string type, string difficulty, string qString, string cAnswer, string wAnswer1, string wAnswer2, string wAnswer3)
        {
            this.id = id;
            this.category = category;
            this.type = type;
            this.difficulty = difficulty;
            this.qString = qString;
            this.cAnswer = cAnswer;
            this.wAnswer1 = wAnswer1;
            this.wAnswer2 = wAnswer2;
            this.wAnswer3 = wAnswer3;
        }
        public Question(string category, string type, string difficulty, string qString, string cAnswer, string wAnswer1, string wAnswer2, string wAnswer3)
        {
            this.category = category;
            this.type = type;
            this.difficulty = difficulty;
            this.qString = qString;
            this.cAnswer = cAnswer;
            this.wAnswer1 = wAnswer1;
            this.wAnswer2 = wAnswer2;
            this.wAnswer3 = wAnswer3;
        }

        public int getID()
        {
            int id = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["JordanString"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("", conn);
            try
            {
                string query = string.Format("SELECT * FROM Question WHERE Question.QuestionID = (SELECT MAX(Question.QuestionID) FROM Question);");
                conn.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            finally
            {
                conn.Close();
            }
            id = id + 1;
            return id;
        }
        public void AddQuestion(string category, string type, string difficulty, string qString, string cAnswer, string wAnswer1, string wAnswer2, string wAnswer3)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["JordanString"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("", conn);
            int temp_id = getID();
            string query = "INSERT INTO Question VALUES (@id, @category, @type, @difficulty, @qString, @cAnswer, @wAnswer1, @wAnswer2, @wAnswer3)";

            command.CommandText = query;
            command.Parameters.Add(new SqlParameter("@id", temp_id));
            command.Parameters.Add( new SqlParameter("@category", category.ToString()));
            command.Parameters.Add(new SqlParameter("@type", type.ToString()));
            command.Parameters.Add(new SqlParameter("@difficulty", difficulty.ToString()));
            command.Parameters.Add(new SqlParameter("@qString", qString.ToString()));
            command.Parameters.Add(new SqlParameter("@cAnswer", cAnswer.ToString()));
            command.Parameters.Add(new SqlParameter("@wAnswer1", wAnswer1.ToString()));
            command.Parameters.Add(new SqlParameter("@wAnswer2", wAnswer2.ToString()));
            command.Parameters.Add(new SqlParameter("@wAnswer3", wAnswer3.ToString()));
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
                command.Parameters.Clear();
            }

        }

    }
}