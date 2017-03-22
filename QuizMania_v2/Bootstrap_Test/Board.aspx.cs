using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap_Test
{
    public partial class Board : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Session["current"].ToString().Equals("0"))
            {
                boardImage.Style.Add("background-image", "url(Images/George.jpg)");
                Label1.Text = "lkasdjflskajdflkasjdflaksjdlfkasjdlf";
                Session["current"] = 1;
            }
            else
            {
                boardImage.Style.Add("background-image", "url(Images/dock.jpg)");
                Label1.Text = "zxmncbzmxncbzmxncbzmxncbzmxncbzmxncbzmxncbz";
                Session["current"] = 0;
            }

        }
    }
}