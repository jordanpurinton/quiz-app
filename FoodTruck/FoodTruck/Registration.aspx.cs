using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodTruck
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = new User(txtName.Text, txtPass.Text, txtEmail.Text, "User");
            lblResult.Text = ConnectionClass.RegisterUser(user);

        }
    }
}