using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

public class DataInsert
{
    public DataInsert()
    {
        
    }

    
    public void InsertHighScore(int Score, string UserId)
    {
        DateTime DateScored = DateTime.Now;

        DataAccess myAccess = new DataAccess();
        SqlParameter[] parameters = new SqlParameter[3];
        parameters[0] = new SqlParameter("Score", Score);
        parameters[1] = new SqlParameter("UserId", UserId);
        parameters[2] = new SqlParameter("DateScored", DateScored);

        string query = "spInsertHighScore";
        int rows = myAccess.nonQuery(query, parameters);
    }

    /*
    public int CreateNewOrder()
    {
        DataAccess myAccess = new DataAccess();

        string query = "spCreateOrder";
        DataSet rows = myAccess.getQuery(query);
        int newId = Int32.Parse(rows.Tables[0].Rows[0][0].ToString());

        return newId;
    }
    */
}
