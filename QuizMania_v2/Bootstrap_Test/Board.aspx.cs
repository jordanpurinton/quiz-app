using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap_Test
{
    public partial class Board : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["QuestionNum"] != 0)
            {
                ArrayList questionList = (ArrayList)Session["QuestionList"];
                string questionIndex = (string)questionList[(int)Session["QuestionNum"] - 1];
                string[] answerArray = questionIndex.Split(',');
                questionString.Text = answerArray[0];
                Button1.Text = answerArray[1];
                Button2.Text = answerArray[2];
                Button3.Text = answerArray[3];
                Button4.Text = answerArray[4];

                Session["QuestionNum"] = Convert.ToInt32(Session["QuestionNum"]) - 1;
            }
            else
            {
                Response.Redirect("About.aspx");
            }


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
                // <br /> needs to be used for newlines in label text.  The label should automatically move 
                // any overflow to the next line but in other cases this will need to be the format
                Label1.Text = "zxmncbzmxncbzmxn" + "<br />" + "cbzmxncbzmxncbzmx" + "<br />" + "ncbzmxncbz";
                Session["current"] = 0;
            }

        }


    }
}