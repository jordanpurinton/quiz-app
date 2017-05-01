using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap_Test
{
	public partial class CustomQuestion : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect("Account/Login.aspx");
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {

            string temp_cat = dListCat.Text;
            string temp_type = dListType.Text;
            string temp_diff = dListDiff.Text;
            string temp_question = txtQuestion.Text;
            string temp_cAnswer = txtCAnswer.Text;
            string temp_wAnswer1 = txtW1.Text;
            string temp_wAnswer2 = txtW2.Text;
            string temp_wAnswer3 = txtW3.Text;
            if (txtCAnswer.Text == "" || txtQuestion.Text == "" || txtW1.Text == "")
            {
                txtError.Text = "Please complete the form, dog";

            }
            else
            {
                Question question = new Question(temp_cat, temp_type, temp_diff, temp_question, temp_cAnswer, temp_wAnswer1, temp_wAnswer2, temp_wAnswer3);
                question.AddQuestion(question.category, question.type, question.difficulty, question.qString, question.cAnswer, question.wAnswer1, question.wAnswer2, question.wAnswer3);
                ClientScript.RegisterStartupScript(GetType(), "hwa", "toastify('success', 'NICE', 'Question submitted successfully!', 'toast-top-left');", true);

                txtCAnswer.Text = "";
                txtQuestion.Text = "";
                txtW1.Text = "";
                txtW2.Text = "";
                txtW3.Text = "";
            }
        }
    }
}