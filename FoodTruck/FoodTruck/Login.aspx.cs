using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodTruck
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = ConnectionClass.LoginUser(txtUser.Text, txtPass.Text);
            if(user != null){
                Session["name"] = user.name;
                Session["type"] = user.type;
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblOutput.Text = "Fail";
            }
        }
    }
}