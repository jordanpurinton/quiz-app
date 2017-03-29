using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizMania
{
    public partial class Highscores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListScores();
        }

        private void ListScores()
        {
            // Need to update stored procedures
            /* 
            DataSelect mySelect = new DataSelect();
            DataSet scores = mySelect.SelectScores();
            

            int i = 0;
            StringBuilder html = new StringBuilder();
            foreach (var row in scores.Tables[0].Rows)
            {
                html.Append(String.Format(@"
                <div style='color: #000000; text-align: center;'>
                    <p style='margin: 10px; padding:10px; border-style: solid; border-width: 1px;'>
                    Place |{3}|&nbsp;&nbsp;&nbsp;UserId |{0}|&nbsp;&nbsp;&nbsp;Score |{1}|&nbsp;&nbsp;&nbsp;Date Scored |{2}|<p>
                </div>                
                ", scores.Tables[0].Rows[i][1].ToString(), scores.Tables[0].Rows[i][2].ToString(),
                    scores.Tables[0].Rows[i][3].ToString(), i+1));
                i += 1;
            }
            lblHighScores.Text = html.ToString();
            */
        }
    }
}