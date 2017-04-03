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

    
    public DataSet SelectHighScores()
    {
        DataAccess myAccess = new DataAccess();

        string query = "spSelectScores";
        DataSet rows = myAccess.getQuery(query);
        return rows;
    }
    

    public DataSet SelectOrders()
    {
        DataAccess myAccess = new DataAccess();

        string query = "spSelectScores";
        DataSet rows = myAccess.getQuery(query);
        return rows;
    }

    public DataSet SelectQuestions(int number, string category)
    {
        DataAccess myAccess = new DataAccess();

        SqlParameter[] parameters = new SqlParameter[2];
        parameters[0] = new SqlParameter("number", number);
        parameters[1] = new SqlParameter("category", category);

        string query = "spSelectQuestions";
        DataSet rows = myAccess.getQuery(query, parameters);
        return rows;
    }
}