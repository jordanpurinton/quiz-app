using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodTruck
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Fill();
        }

        public void Fill()
        {

            ArrayList foodList = new ArrayList();
            if (!IsPostBack)
            {
                foodList = ConnectionClass.GetFoodByType("%");
            }
            else
            {
                foodList = ConnectionClass.GetFoodByType(DropDownList1.SelectedValue);
            }
            StringBuilder sb = new StringBuilder();
            
            foreach (FoodClass food in foodList)
            {
                sb.Append(string.Format(@"<table class='foodTable'>
                <tr>
                    <td rowspan='4' width='150px'><img runat='server' src='{3}' /></td>
                    <th><h2>Name:</h2></th>
                    <th><h2>{0}</h2></th>
                </tr>
                <tr>
                    <th>Price:</th>
                    <td><h2>${1}</h2></td>
                </tr>
                <tr>
                    <td colspan='2'>{2}</td>
                </tr>
                </table> ", food.name, food.price, food.description, food.image));
                Label1.Text = sb.ToString();      

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill();
        }
    }
}