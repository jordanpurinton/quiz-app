using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap_Test
{
    public partial class ScoreTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFinalScore.Text = "You got a score of " + Session["score"] + "!";

            DataSelect mySelect = new DataSelect();
            Response.Write("Your highscore: " + 
                mySelect.SelectHighScore(Page.User.Identity.GetUserId()) + "<br>");
        }
    }
}