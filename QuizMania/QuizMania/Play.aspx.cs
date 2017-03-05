using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizMania
{
    public partial class Play : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Fill()
        {
            Label1.Text = "How much wood would a wood chuck chuck if a wood chuck could chuck wood?";
        }



        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Success.aspx");

        }
    }
}