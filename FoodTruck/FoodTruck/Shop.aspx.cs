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
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GenerateControls();
        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            SaveOrder();
            lblOutput.Text = "Success!  Thanks for shopping with us!";
            btnConfirm.Visible = false;
            btnCancel.Visible = false;

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Authenticate();
            Confirm();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session["orders"] = null;
            btnConfirm.Visible = false;
            btnCancel.Visible = false;
            lblOutput.Text = "Order cancelled";

        }

        private void GenerateControls()
        {
            ArrayList foodList = ConnectionClass.GetFoodByType("%");
            foreach(FoodClass food in foodList)
            {
                Panel foodPanel = new Panel();
                Image image = new Image { ImageUrl = food.image, CssClass = "ProductsImage" };
                Literal literal = new Literal() { Text = "<br />" };
                Literal literal2 = new Literal() { Text = "<br />" };
                Label lblName = new Label { Text = food.name, CssClass = "ProductsName" };
                Label lblPrice = new Label { Text = String.Format("${0}" + "<br />", food.price), CssClass = "ProductsPrice" };
                TextBox txtBox = new TextBox { ID = food.id.ToString(), CssClass = "ProductsTextBox", Text = "0", Width=60 };
                RegularExpressionValidator regex = new RegularExpressionValidator { ValidationExpression = "^[0-9]*", ControlToValidate = txtBox.ID, ErrorMessage = "Only numbers" };
                foodPanel.Controls.Add(image);
                foodPanel.Controls.Add(literal);
                foodPanel.Controls.Add(lblName);
                foodPanel.Controls.Add(literal2);
                foodPanel.Controls.Add(lblPrice);
                foodPanel.Controls.Add(txtBox);
                foodPanel.Controls.Add(regex);
                pnl_Out.Controls.Add(foodPanel);

            }
        }
        private ArrayList GetOrders()
        {
            ContentPlaceHolder cph = (ContentPlaceHolder) Master.FindControl("ContentPlaceHolder2");
            ControlFinder<TextBox> cf = new ControlFinder<TextBox>();
            cf.FindChildControls(cph);
            var textBoxList = cf.FoundControls;
            ArrayList orderList = new ArrayList();

            foreach(TextBox textBox in textBoxList)
            {
                if(textBox.Text != "")
                {
                    int orderTotal = Convert.ToInt32(textBox.Text);
                    if (orderTotal > 0)
                    {
                        FoodClass food = ConnectionClass.GetFoodByID(Convert.ToInt32(textBox.ID));
                        Order order = new Order(Session["name"].ToString(), food.name, orderTotal, food.price, DateTime.Now);
                        orderList.Add(order);

                    }
                }
            }
            return orderList;
        }
        private void Confirm()
        {
            int totalOrder = 0;
            ArrayList newOrders = GetOrders();
            Session["orders"] = newOrders;
            StringBuilder sb = new StringBuilder();
            sb.Append("<table><h3>Are you sure you want all that food?</h3>");
            foreach(Order order in newOrders)
            {
                int total = order.price * order.amount;
                sb.Append(String.Format(@"
                <tr>
                    <td width='auto'>{0}</td>
                    <td width='auto'>{1} x{2}</td>
                    <td>$</td><td>{3}</td>
                </tr>                
                ",order.amount,order.product,order.price,total));
                totalOrder = totalOrder + total;
            }
            sb.Append(String.Format(@"
            <tr>
                <td>Total:</td>
                <td>${0}</td>    
            </tr>
            ",totalOrder));
            sb.Append("</table>");
            lblOutput.Text = sb.ToString();
            lblOutput.Visible = true;
            btnConfirm.Visible = true;
            btnCancel.Visible = true;

        }
        private void SaveOrder()
        {
            ArrayList orderList = (ArrayList)Session["orders"];
            ConnectionClass.AddOrder(orderList);
            Session["orders"] = null;

        }
        private void Authenticate()
        {
            if(Session["name"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
        
    }
}