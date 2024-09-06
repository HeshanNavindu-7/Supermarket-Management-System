using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AllinOne.BLL;
using AllinOne.DataAccessLayer;
using System.Text.RegularExpressions;

namespace AllinOne
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
      
        private void product_Load(object sender, EventArgs e)
        {/*
            // TODO: This line of code loads data into the 'allInOneDataSet.tblitem' table. You can move, or remove it, as needed.
            this.tblitemTableAdapter.Fill(this.allInOneDataSet.tblitem);
            con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");
            cmd = new SqlCommand("select *from tblitem", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gunadgv_product.DataSource = dt;
            con.Close();*/
            DataTable dt = xdal.Select();
            gunadgv_product.DataSource = dt;
        }

        private void gunatxt_search_TextChanged(object sender, EventArgs e)
        {   //Get the Keywordss from Form
            string keywords = gunatxt_search.Text;
            /*
                       if (keywords != null)
                       {
                           //Search the products
                           DataTable dt = xdal.Search(keywords);
                           gunadgv_product.DataSource = dt;
                       }
                       else
                       {
                           //Display All the products
                           DataTable dt = xdal.Select();
                           gunadgv_product.DataSource = dt;
                       }

                       con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");
                       cmd = new SqlCommand("select *from tblitem where catogery like'"+gunatxt_search.Text+"%'", con);
                      con.Open();
                       SqlDataAdapter da = new SqlDataAdapter(cmd);
                       DataTable dt = new DataTable();
                       da.Fill(dt);
                       gunadgv_product.DataSource = dt;
                       con.Close();*/
            DataTable dt = xdal.Search(gunatxt_search.Text); 
            gunadgv_product.DataSource = dt;
        }
        itemBLL x = new itemBLL();
        itemDAL xdal = new itemDAL();
        private void btn_itemadd_Click(object sender, EventArgs e)
        {
            int i = 0;
            string compare = txt_itemid.Text;
            string comp = txt_quantity.Text;
            string compa = txt_unitprice.Text;
            Regex regex = new Regex(@"[\d]");
            if (!regex.IsMatch(compare))
            {
                //true
                error_msg.Text = "item id cannot have letters";

            }
            else if(string.IsNullOrEmpty(txt_item_name.Text))
            {
                error_msg.Text = "Item Name cannot be blank";
                txt_item_name.Focus();
            }
            else if (txt_item_name.Text.Any(char.IsDigit))
            {
                error_msg.Text = "Item Name cannot have numbers";
                txt_item_name.Focus();
            }
            else if (string.IsNullOrEmpty(txt_catogery.Text))
            {
                error_msg.Text = "catogery cannot be blank";
                txt_catogery.Focus();
            }
            else if (txt_catogery.Text.Any(char.IsDigit))
            {
                error_msg.Text = "catogery cannot have numbers";
                txt_catogery.Focus();
            }
            else if (!regex.IsMatch(comp))
            {
                //true
                error_msg.Text = "quantity cannot have letters or null";

            }
           else if (!regex.IsMatch(compa))
            {
                //true
                error_msg.Text = "unitprice cannot have letters or null";

            }
            else if (i == 0)
            {
                try
                {
                    //Get All the Values from Product Form
                    x.item_Id = int.Parse(txt_itemid.Text);
                    x.item_name = txt_item_name.Text;
                    x.catogery = txt_catogery.Text;
                    x.quantity = decimal.Parse(txt_quantity.Text);
                    x.unit_price = decimal.Parse(txt_unitprice.Text);


                   

                    //Create Boolean variable to check if the product is added successfully or not
                    bool success = xdal.Insert(x);
                    //if the product is added successfully then the value of success will be true else it will be false
                    if (success == true)
                    {
                        //Product Inserted Successfully
                        MessageBox.Show("item Added Successfully");
                        //Calling the Clear Method
                        Clear();
                        //Refreshing DAta Grid View
                        DataTable dt = xdal.Select();
                        gunadgv_product.DataSource = dt;
                    }
                    else
                    {
                        //Failed to Add New product
                        MessageBox.Show("Failed to Add New Product");
                    }
                
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Clear()
        {
            txt_itemid.Text = "";
            txt_item_name.Text = "";
            txt_catogery.Text = "";
            txt_unitprice.Text = "";
            txt_quantity.Text = "";
        }

        private void btn_itemupdate_Click(object sender, EventArgs e)
        {
            int i = 0;
            string compare = txt_itemid.Text;
            string comp = txt_quantity.Text;
            string compa = txt_unitprice.Text;
            Regex regex = new Regex(@"[\d]");
            if (!regex.IsMatch(compare))
            {
                //true
                error_msg.Text = "quantity cannot have letters";

            }
            else if (string.IsNullOrEmpty(txt_item_name.Text))
            {
                error_msg.Text = "Item Name cannot be blank";
                txt_item_name.Focus();
            }
            else if (txt_item_name.Text.Any(char.IsDigit))
            {
                error_msg.Text = "Item Name cannot have numbers";
                txt_item_name.Focus();
            }
            else if (string.IsNullOrEmpty(txt_catogery.Text))
            {
                error_msg.Text = "catogery cannot be blank";
                txt_catogery.Focus();
            }
            else if (txt_catogery.Text.Any(char.IsDigit))
            {
                error_msg.Text = "catogery cannot have numbers";
                txt_catogery.Focus();
            }
            else if (!regex.IsMatch(comp))
            {
                //true
                error_msg.Text = "quantity cannot have letters or null";

            }
            else if (!regex.IsMatch(compa))
            {
                //true
                error_msg.Text = "unitprice cannot have letters or null";

            }
            else if (i == 0)
            {

                try { 
                //Get the Values from UI or Product Form
                x.item_Id = int.Parse(txt_itemid.Text);
                x.item_name = txt_item_name.Text;
                x.catogery = txt_catogery.Text;
                x.quantity = int.Parse(txt_quantity.Text);
                x.unit_price = decimal.Parse(txt_unitprice.Text);




                //Create a boolean variable to check if the product is updated or not
                bool success = xdal.Update(x);
                //If the prouct is updated successfully then the value of success will be true else it will be false
                if (success == true)
                {
                    //Product updated Successfully
                    MessageBox.Show("Product Successfully Updated");
                    Clear();
                    //REfresh the Data Grid View
                    DataTable dt = xdal.Select();
                    gunadgv_product.DataSource = dt;
                }
                else
                {
                    //Failed to Update Product
                    MessageBox.Show("Failed to Update Product");
                }
                
            }
                catch (ArgumentException)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
        }

        private void txt_item_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            string compare = txt_itemid.Text;
            Regex regex = new Regex(@"[\d]");
            if (!regex.IsMatch(compare))
            {
                //true
                error_msg.Text = "item id cannot have letters or null";

            }
            else if (i == 0)
            {

                try
                {
                    //GEt the ID of the product to be deleted
                    x.item_Id = int.Parse(txt_itemid.Text);

                    //Create Bool VAriable to Check if the product is deleted or not
                    bool success = xdal.Delete(x);

                    //If prouct is deleted successfully then the value of success will true else it will be false
                    if (success == true)
                    {
                        //Product Successfuly Deleted
                        MessageBox.Show("Product successfully deleted.");
                        Clear();
                        //Refresh DAta Grid View
                        DataTable dt = xdal.Select();
                        gunadgv_product.DataSource = dt;
                    }
                    else
                    {
                        //Failed to Delete Product
                        MessageBox.Show("Failed to Delete Product.");
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gunadgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Create integer variable to know which product was clicked
            int rowIndex = e.RowIndex;
            //Display the Value on Respective TextBoxes
            txt_itemid.Text = gunadgv_product.Rows[rowIndex].Cells[0].Value.ToString();
            txt_item_name.Text = gunadgv_product.Rows[rowIndex].Cells[1].Value.ToString();
            txt_catogery.Text = gunadgv_product.Rows[rowIndex].Cells[2].Value.ToString();
            txt_quantity.Text = gunadgv_product.Rows[rowIndex].Cells[3].Value.ToString();
            txt_unitprice.Text = gunadgv_product.Rows[rowIndex].Cells[4].Value.ToString();

        }
        itemDAL xDAL = new itemDAL();

        private void txt_itemid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Get the keyword fro the text box
                string keyword = txt_itemid.Text;

                if (keyword == "")
                {
                    //Clear all the textboxes
                    txt_item_name.Text = "";
                    txt_unitprice.Clear();
                    txt_catogery.Text = "";
                    txt_quantity.Clear();
                  
                    return;
                }

                //Search the product and display on respective textboxes
                itemBLL p = xDAL.GetProductsForTransaction(keyword);

                //Set the values on textboxes based on p object
                txt_item_name.Text = p.item_name;
              //  txt_unitprice.Text = p.unit_price.ToString();
                txt_catogery.Text = p.catogery;
                //txt_quantity.Text = p.quantity.ToString();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
          
            this.Refresh();
            error_msg.Text = "";
            this.Clear();
        }
    }
}
