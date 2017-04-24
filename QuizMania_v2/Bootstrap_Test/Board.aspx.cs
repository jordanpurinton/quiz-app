using Microsoft.AspNet.Identity;
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
            if (!Page.IsPostBack)
            {
                Session["score"] = 0;
                GameLoad();
            }
        }

        protected void Button1_Click(object sender, CommandEventArgs e)
        {
            string buttonPressed = e.CommandArgument.ToString();
            if (buttonPressed == (string)Session["correctAnswer"])
            {
                /* DEBUG Correct Answer
                Response.Write("Correct</br>");
                */
                Session["score"] = (int)Session["score"] + 1;
                ClientScript.RegisterStartupScript(GetType(), "hwa", "toastify('success', 'NICE', 'You answered correctly!', 'toast-top-left');", true);
            }

            if(buttonPressed != (string)Session["correctAnswer"])
            {
                ClientScript.RegisterStartupScript(GetType(), "hwa", "toastify('error', 'WRONG', 'You answered incorrectly!', 'toast-top-left');", true);
            }

            if (Session["current"].ToString().Equals("0"))
            {
                Session["current"] = 1;
            }
            else
            {
                // <br /> needs to be used for newlines in label text.  The label should automatically move 
                // any overflow to the next line but in other cases this will need to be the format
                Session["current"] = 0;
            }

            GameLoad();
        }

        protected void GameLoad()
        {
            if ((int)Session["QuestionNum"] != 0)
            {
                Random random = new Random();
                int ran = random.Next(0, 2);
                ArrayList questionList = (ArrayList)Session["QuestionList"];
                string questionIndex = (string)questionList[(int)Session["QuestionNum"] - 1];
                string[] answerArray = questionIndex.Split('|');

                // store and then remove question category from array
                Session["Category"] = answerArray.ElementAt(0);
                RemoveAt(ref answerArray, 0);

                // store and then remove question string from array
                string questionString = answerArray.ElementAt(0);
                RemoveAt(ref answerArray, 0);

                if ((string)Session["Category"] == "Sports")
                {
                    if (ran == 0)
                        boardImage.Style.Add("background-image", "url(Images/category_images/sports1.jpg)");
                    else
                        boardImage.Style.Add("background-image", "url(Images/category_images/sports2.png)");

                }
                else if ((string)Session["Category"] == "General Knowledge")
                {
                    if (ran == 0)
                        boardImage.Style.Add("background-image", "url(Images/category_images/general1.jpg)");
                    else
                        boardImage.Style.Add("background-image", "url(Images/category_images/general2.jpg)");
                }

                else if ((string)Session["Category"] == "Entertainment: Music")
                {
                    if (ran == 0)
                        boardImage.Style.Add("background-image", "url(Images/category_images/music1.jpg)");
                    else
                        boardImage.Style.Add("background-image", "url(Images/category_images/music2.jpg)");
                }

                else if ((string)Session["Category"] == "Entertainment: Video Games")
                {
                    if (ran == 0)
                        boardImage.Style.Add("background-image", "url(Images/category_images/videogames1.jpg)");
                    else
                        boardImage.Style.Add("background-image", "url(Images/category_images/videogames2.jpg)");
                }

                else if ((string)Session["Category"] == "Entertainment: Film")
                {
                    if (ran == 0)
                        boardImage.Style.Add("background-image", "url(Images/category_images/film1.png)");
                    else
                        boardImage.Style.Add("background-image", "url(Images/category_images/film2.jpg)");
                }

                else if ((string)Session["Category"] == "Entertainment: Television")
                {
                    if (ran == 0)
                        boardImage.Style.Add("background-image", "url(Images/category_images/television1.jpg)");
                    else
                        boardImage.Style.Add("background-image", "url(Images/category_images/television2.jpg)");
                }

                else if ((string)Session["Category"] == "History")
                {
                    if (ran == 0)
                        boardImage.Style.Add("background-image", "url(Images/category_images/history1.jpg)");
                    else
                        boardImage.Style.Add("background-image", "url(Images/category_images/history2.jpg)");
                }

                Session["correctString"] = answerArray[0];
                /* DEBUG Correct Answer
                Response.Write(Session["correctString"] + "</br>");
                */

                // check if the question is true/false
                if (answerArray[2] == "" && answerArray[3] == "")
                {
                    Button3.Visible = false;
                    Button4.Visible = false;
                    for (int i = 0; i < 2; i++)
                    {
                        // randomize the true false questions
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
                            /* DEBUG Correct Answer
                            Response.Write(i.ToString() + "</br>");
                            */
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
                CheckScore();
                Server.Transfer("FinalScore.aspx");
            }
        }

        protected void CheckScore()
        {
            DataSelect mySelect = new DataSelect();
            
            if (mySelect.CheckHighScore((int)Session["score"], User.Identity.GetUserName())) {
                DataInsert myInsert = new DataInsert();
                myInsert.InsertHighScore((int)Session["score"], User.Identity.GetUserName());
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