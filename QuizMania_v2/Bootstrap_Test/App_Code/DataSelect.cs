using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

public class DataSelect
{
    public DataSelect()
    {

    }

    
    public DataSet SelectHighScores(int Number)
    {
        DataAccess myAccess = new DataAccess();
        SqlParameter parameter = new SqlParameter("Number", Number);
        string query = "spSelectScores";
        DataSet rows = myAccess.getQuery(query, parameter);
        return rows;
    }

    public DataSet SelectQuestions(int number, string category)
    {
        DataAccess myAccess = new DataAccess();

        if (category != "Random")
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("number", number);
            parameters[1] = new SqlParameter("category", category);
            string query = "spSelectQuestions";
            DataSet rows = myAccess.getQuery(query, parameters);
            return rows;
        }
        else
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("number", number);
            string query = "spRandomCategory";
            DataSet rows = myAccess.getQuery(query, parameters);
            return rows;
        }
    }

    public Boolean CheckHighScore(int score, string Username)
    {
        int old_score = SelectHighScore(Username);

        if (score > old_score)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int SelectHighScore(string Username)
    {
        DataAccess myAccess = new DataAccess();

        SqlParameter parameter = new SqlParameter("Username", Username);
        string query = "spSelectHighScore";
        int score = 0;
        try
        {
            score = (int)myAccess.getQuery(query, parameter).Tables[0].Rows[0][0];
        }
        catch(IndexOutOfRangeException e){}

        return score;
    }
}