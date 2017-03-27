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

    /*
    public DataSet SelectScores(int selectId)
    {
        DataAccess myAccess = new DataAccess();
        SqlParameter[] parameters = new SqlParameter[1];
        parameters[0] = new SqlParameter("ItemId", ItemId);

        string query = "spReturnItems";
        DataSet rows = myAccess.getQuery(query, parameters);
        return rows;
    }
    */

    public DataSet SelectOrders()
    {
        DataAccess myAccess = new DataAccess();

        string query = "spSelectScores";
        DataSet rows = myAccess.getQuery(query);
        return rows;
    }
}