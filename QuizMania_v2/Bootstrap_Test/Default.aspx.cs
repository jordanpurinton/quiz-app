﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections;
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
                Label1.Text = "Welcome to the Quiz Mania Experience.";
            }
            // Uncomment the next two lines to run without authentication
            //Session["current"] = 0;
            //Label1.Text = "Welcome to the Quiz Mania Experience.";  
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            Session["score"] = 0;

            int questionNum = int.Parse(QuestionNumberList.SelectedValue);
            DataSelect mySelect = new DataSelect();
            DataSet questions = mySelect.SelectQuestions(questionNum, CategoryList.SelectedValue);
            ArrayList questionList = new ArrayList(questionNum);
            Session["QuestionNum"] = questionNum;

            for (int i = 0; i < questionNum; i++)
            {
                string category = questions.Tables[0].Rows[i][1].ToString().Trim();
                string questionString = questions.Tables[0].Rows[i][4].ToString().Trim();
                string correctAnswer = questions.Tables[0].Rows[i][5].ToString().Trim();
                string incorrectAnswer1 = questions.Tables[0].Rows[i][6].ToString().Trim();
                string incorrectAnswer2 = questions.Tables[0].Rows[i][7].ToString().Trim();
                string incorrectAnswer3 = questions.Tables[0].Rows[i][8].ToString().Trim();

                /* debug
                Response.Write("question: " + questionString + " | correct: " + correctAnswer +
                                " | incorrect 1: " + incorrectAnswer1 + " | incorrect 2: " + incorrectAnswer2 +
                                " | incorrect 3: " + incorrectAnswer3 + "<br />");
                */

                questionList.Add(category + "|" + questionString + "|" + correctAnswer + "|" + incorrectAnswer1 + "|" + incorrectAnswer2 + "|" + incorrectAnswer3);
            }
            Session["QuestionList"] = questionList;
            Session["Score"] = 0;

            Response.Redirect("Board.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["score"] = 0;

            Random random = new Random();
            int questionNum = random.Next(1, 30);
            DataSelect mySelect = new DataSelect();
            DataSet questions = mySelect.SelectQuestions(questionNum, "Random");
            ArrayList questionList = new ArrayList(questionNum);
            Session["QuestionNum"] = questionNum;

            for (int i = 0; i < questionNum; i++)
            {
                string category = questions.Tables[0].Rows[i][1].ToString().Trim();
                string questionString = questions.Tables[0].Rows[i][4].ToString().Trim();
                string correctAnswer = questions.Tables[0].Rows[i][5].ToString().Trim();
                string incorrectAnswer1 = questions.Tables[0].Rows[i][6].ToString().Trim();
                string incorrectAnswer2 = questions.Tables[0].Rows[i][7].ToString().Trim();
                string incorrectAnswer3 = questions.Tables[0].Rows[i][8].ToString().Trim();

                /* debug
                Response.Write("question: " + questionString + " | correct: " + correctAnswer +
                                " | incorrect 1: " + incorrectAnswer1 + " | incorrect 2: " + incorrectAnswer2 +
                                " | incorrect 3: " + incorrectAnswer3 + "<br />");
                */

                questionList.Add(category + "|" + questionString + "|" + correctAnswer + "|" + incorrectAnswer1 + "|" + incorrectAnswer2 + "|" + incorrectAnswer3);
            }
            Session["QuestionList"] = questionList;
            Session["Score"] = 0;
            Response.Redirect("Board.aspx");

        }
    }
}