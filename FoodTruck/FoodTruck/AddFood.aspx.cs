using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodTruck
{
    public partial class AddFood : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string selectedValue = DropDownList1.SelectedValue;
            ShowPics();
            DropDownList1.SelectedValue = selectedValue;
        }
        private void ShowPics()
        {
            string[] images = Directory.GetFiles(Server.MapPath("Images/"));
            ArrayList imageList = new ArrayList();

            foreach (string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\") + 1);
                imageList.Add(imageName);
            }

            DropDownList1.DataSource = imageList;
            DropDownList1.DataBind();

        }

        private void ClearAll()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtType.Text = "";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/Images/") + filename);
                lblResult.Text = "Success!";
                Page_Load(sender, e);
            }
            catch (Exception)
            {
                lblResult.Text = "Fail!!!";

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string description = txtDescription.Text;
                int price = Convert.ToInt32(txtPrice.Text);
                
                string type = txtType.Text;
                string image = "Images/" + DropDownList1.SelectedValue;

                FoodClass food = new FoodClass(name, description, price, image, type);
                ConnectionClass.AddFoodItem(food);
                lblResult.Text = "Uploaded Item";
                ClearAll();
                
            }
            catch (Exception)
            {
                lblResult.Text = "Failed to add Item.";
            }
        }
    }
}