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
            int count = Convert.ToInt32(Request.QueryString["count"]);
            DataSelect mySelect = new DataSelect();
            DataSet scores = mySelect.SelectHighScores(count);
            
            int i = 0;
            StringBuilder html = new StringBuilder();
            html.Append(String.Format(@"
                <div id='highscoreList'>
                    <ol>"));
            foreach (var row in scores.Tables[0].Rows)
            {
            html.Append(String.Format(@"
                        <li>
                            <p><b>{0}</b></p>
                            <p><b>{1}</b></p>
                            <p>{2}</p>
                        </li>          
                ", scores.Tables[0].Rows[i][1].ToString(), scores.Tables[0].Rows[i][2].ToString(),
                    scores.Tables[0].Rows[i][3].ToString()));
                i++;
            }
            html.Append(String.Format(@"
                    </ol>
                </div>"));
            lblHighScores.Text = html.ToString();
        }

        protected void btnLoadMore_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Request.QueryString["count"]) + 100;
            Response.Redirect(String.Format(@"Highscores.aspx?count={0}", count));
        }
    }
}