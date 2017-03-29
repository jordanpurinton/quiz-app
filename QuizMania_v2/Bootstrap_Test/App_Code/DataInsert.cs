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

    /*
    public int InsertNewOrder(string ItemList)
    {
        DataAccess myAccess = new DataAccess();
        SqlParameter[] parameters = new SqlParameter[1];
        //parameters[0] = new SqlParameter("OrderId", OrderId);
        parameters[0] = new SqlParameter("ItemList", ItemList);

        string query = "spInsertNewOrder";
        int rows = myAccess.nonQuery(query, parameters);
        return rows;
    }

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
