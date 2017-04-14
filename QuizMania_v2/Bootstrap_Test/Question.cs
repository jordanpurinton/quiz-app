using System;
using System.Collections.Generic;
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

    }
}