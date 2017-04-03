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
            
            // Comment out the "if" and "else" statements to run without authentication

            if (!Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect("Account/Login.aspx");
            }

            else
            {
                Session["current"] = 0;
                Label1.Text = "Welcome to the Quiz Mania Experience. Gowieuroweiuroweiruwoei. ruwoeiruwoeriuwoeiruwoe. iruwoeiruoweiru";
            }
            // Uncomment the next two lines to run without authentication
            //Session["current"] = 0;
            //Label1.Text = "Welcome to the Quiz Mania Experience. Gowieuroweiuroweiruwoei. ruwoeiruwoeriuwoeiruwoe. iruwoeiruoweiru";  
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int questionNum = int.Parse(QuestionNumberList.SelectedValue);
            string[] questionArray = new string[questionNum];
            DataSelect mySelect = new DataSelect();
            DataSet questions = mySelect.SelectQuestions(questionNum, CategoryList.SelectedValue);

            for (int i = 0; i < questionNum; i++)
            {
                string questionString = questions.Tables[0].Rows[i][4].ToString().Trim();
                string correctAnswer = questions.Tables[0].Rows[i][5].ToString().Trim(); ;
                string incorrectAnswer1 = questions.Tables[0].Rows[i][6].ToString().Trim(); ;
                string incorrectAnswer2 = questions.Tables[0].Rows[i][7].ToString().Trim(); ;
                string incorrectAnswer3 = questions.Tables[0].Rows[i][8].ToString().Trim(); ;

                questionArray[i] = questionString + "," + correctAnswer + "," + incorrectAnswer1 + "," + incorrectAnswer2 + "," + incorrectAnswer3;

                Response.Write(questionArray[i] + "<br>");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("Board.aspx");

        }
    }
}