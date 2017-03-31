using System;
using System.Collections.Generic;
using System.Data;
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
            int questionNum = int.Parse(QuestionNumberList.SelectedValue);
            int[] questionArray = new int[questionNum];
            DataSelect mySelect = new DataSelect();
            DataSet questions = mySelect.SelectQuestions(questionNum, CategoryList.SelectedValue);

            for (int i = 0; i < questionNum; i++)
            {
                Response.Write(questions.Tables[0].Rows[i].ToString() + "</br>");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("Board.aspx");

        }
    }
}