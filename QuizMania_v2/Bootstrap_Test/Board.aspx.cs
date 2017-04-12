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

                // get question index (contains question string and answers)
                ArrayList questionList = (ArrayList)Session["QuestionList"]; 
                string questionIndex = (string)questionList[(int)Session["QuestionNum"] - 1];
                string[] answerArray = questionIndex.Split('|');

                // store and then remove question string from array
                string questionString = answerArray.ElementAt(0);
                RemoveAt(ref answerArray, 0);

                Session["correctString"] = answerArray[0];
                Response.Write(Session["correctString"] + "</br>");

                // check if the question is true/false
                if (answerArray[2] == "" && answerArray[3] == "")
                {
                    Button3.Visible = false;
                    Button4.Visible = false;
                    for (int i = 0; i < 2; i++)
                    {
                        // randomize the true false questions
                        Random random = new Random();
                        int ran = (int)random.NextDouble();
                        if (ran == 0)
                        {
                            Button1.Text = System.Net.WebUtility.HtmlDecode(answerArray[0]);
                            Button2.Text = System.Net.WebUtility.HtmlDecode(answerArray[1]);
                            Session["correctAnswer"] = "0";
                        }
                        else
                        {
                            Button1.Text = System.Net.WebUtility.HtmlDecode(answerArray[1]);
                            Button2.Text = System.Net.WebUtility.HtmlDecode(answerArray[0]);
                            Session["correctAnswer"] = "1";
                        }
                    }

                }
                else
                {
                    answerArray = Shuffle(answerArray);

                    // check and store correct index
                    for (int i = 0; i < 4; i++)
                    {
                        if (answerArray[i] == (string)Session["correctString"])
                        {
                            Session["correctAnswer"] = i.ToString();
                            Response.Write(i.ToString() + "</br>");
                        }
                    }
                    Button1.Text = System.Net.WebUtility.HtmlDecode(answerArray[0]);
                    Button2.Text = System.Net.WebUtility.HtmlDecode(answerArray[1]);
                    Button3.Text = System.Net.WebUtility.HtmlDecode(answerArray[2]);
                    Button4.Text = System.Net.WebUtility.HtmlDecode(answerArray[3]);
                    Button3.Visible = true;
                    Button4.Visible = true;
                }
                questionLabel.Text = questionString;

                Session["QuestionNum"] = (int)Session["QuestionNum"] - 1;
            }
            else
            {
                Response.Redirect("About.aspx");
            }


        }
        protected void Button1_Click(object sender, CommandEventArgs e)
        {
            string buttonPressed = e.CommandArgument.ToString();
            if (buttonPressed == (string)Session["correctAnswer"])
            {
                Response.Write("Correct</br>");
            }


            if (Session["current"].ToString().Equals("0"))
            {
                boardImage.Style.Add("background-image", "url(Images/George.jpg)");
                Session["current"] = 1;
            }
            else
            {
                boardImage.Style.Add("background-image", "url(Images/dock.jpg)");
                // <br /> needs to be used for newlines in label text.  The label should automatically move 
                // any overflow to the next line but in other cases this will need to be the format
                Session["current"] = 0;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (Session["current"].ToString().Equals("0"))
            {
                boardImage.Style.Add("background-image", "url(Images/George.jpg)");
                Session["current"] = 1;
            }
            else
            {
                boardImage.Style.Add("background-image", "url(Images/dock.jpg)");
                // <br /> needs to be used for newlines in label text.  The label should automatically move 
                // any overflow to the next line but in other cases this will need to be the format
                Session["current"] = 0;
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            if (Session["current"].ToString().Equals("0"))
            {
                boardImage.Style.Add("background-image", "url(Images/George.jpg)");
                Session["current"] = 1;
            }
            else
            {
                boardImage.Style.Add("background-image", "url(Images/dock.jpg)");
                // <br /> needs to be used for newlines in label text.  The label should automatically move 
                // any overflow to the next line but in other cases this will need to be the format
                Session["current"] = 0;
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            if (Session["current"].ToString().Equals("0"))
            {
                boardImage.Style.Add("background-image", "url(Images/George.jpg)");
                Session["current"] = 1;
            }
            else
            {
                boardImage.Style.Add("background-image", "url(Images/dock.jpg)");
                // <br /> needs to be used for newlines in label text.  The label should automatically move 
                // any overflow to the next line but in other cases this will need to be the format
                Session["current"] = 0;
            }

        }
        private string[] Shuffle(string[] array)
        {
            Random _random = new Random();
            int n = array.Length;
            
            for (int i = 0; i < n; i++)
            {
                // NextDouble returns a random number between 0 and 1.
                // ... It is equivalent to Math.random() in Java.
                int r = i + (int)(_random.NextDouble() * (n - i));

                string t = array[r];
                array[r] = array[i];
                array[i] = t;
            }

            return array;

        }

        static void RemoveAt<T>(ref T[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++)
            {
                // moving elements downwards, to fill the gap at [index]
                arr[a] = arr[a + 1];
            }
            // finally, let's decrement Array's size by one
            Array.Resize(ref arr, arr.Length - 1);
        }


    }
}