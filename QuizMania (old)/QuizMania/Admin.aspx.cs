using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizMania
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = new QuizMania.User(txtName.Text, txtPass.Text, txtEmail.Text, 0, "0");
            ConnectionClass.AddUser(user);
        }
    }
}