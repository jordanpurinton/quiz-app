using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap_Test
{
    public partial class TestQuestions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int number = 10;
            DataSelect mySelect = new DataSelect();
            DataSet questions = mySelect.SelectQuestions(number, "Sports");

            for (int i = 0; i < number; i++)
            {
                Response.Write(questions.Tables[0].Rows[i][4].ToString() + "</br>");
            }
        }
    }
}