using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizMania
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int score { get; set; }
        public string achievements { get; set; }
        public User(int id, string name, string password, string email, int score, string achievements)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.email = email;
            this.score = score;
            this.achievements = achievements;
        }
        public User(string name, string password, string email, int score, string achievements)
        {
            this.name = name;
            this.password = password;
            this.email = email;
            this.score = score;
            this.achievements = achievements;
        }
    }


}