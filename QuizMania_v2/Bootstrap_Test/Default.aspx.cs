using System;
using System.Collections.Generic;

using System.Web;
using System.Web.Providers.Entities;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap_Test
{
    public partial class _Default : Page
    {

         
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["current"] = 0;
            Label1.Text = "Welcome to the Quiz Mania Experience. Gowieuroweiuroweiruwoei. ruwoeiruwoeriuwoeiruwoe. iruwoeiruoweiru";  
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("Board.aspx");    
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("Board.aspx");

        }
    }
}