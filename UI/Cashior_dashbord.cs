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
using AllinOne.DataAccessLayer;
using AllinOne.BLL;
//printer libary
using DGVPrinterHelper;
using System.Text.RegularExpressions;

namespace AllinOne
{
    public partial class Cashior_dashbord : Form
    {
        public Cashior_dashbord()
        {
            InitializeComponent();

            timer1.Start();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void Cashior_dashbord_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");

           timer1.Start();
            //Specify Columns for our TransactionDataTable

            transactionDT.Columns.Add("itemname");
            transactionDT.Columns.Add("unitprice");
            transactionDT.Columns.Add("Qty");
            transactionDT.Columns.Add("Total");


            SqlCommand cmd = new SqlCommand("select bill_Id from tbltransaction", con);
            autoidnumber();
              //  con.Open();

            //    using (SqlDataReader dr=cmd.ExecuteReader())
            //{
            //    if (dr.Read())
            //    {
            //        try { 

            //        int a;

            //        a=Convert.ToInt32(dr["bill_Id"].ToString());
            //        lbl_bill_id.Text = (a+1).ToString();


            //        }
            //        catch(Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }
       // }
            //con.Close();

            


        }
        double val = 0;
        public void autoidnumber()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(bill_Id)+1 from tbltransaction", con);

            int a;

            a = Convert.ToInt32(cmd.ExecuteScalar());
            a++;
            lbl_bill_id.Text = val+a .ToString();

            con.Close();

        }
        //  double Amount_paid, total_amount, Discount_Amount, Balance, sum;

        private void cashior_dashbordpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {

        }
    
        private void Item_code_txt_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Item_Name_txt_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void unit_price_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {

        }

        private void Quantity_txt_TextChanged(object sender, EventArgs e)
        {

        }
        itemDAL xDAL = new itemDAL();
        transactionDAL tDAL = new transactionDAL();
        DataTable transactionDT = new DataTable();
        
        private void Add_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
              string compare = Quantity_txt.Text;
            Regex regex = new Regex(@"[\d]");
            if (!regex.IsMatch(compare))
            {
                //true
                error_msg.Text = "quantity cannot have letters or null";

            }
            //else if (!regex.IsMatch(balance))
            //{
            //    //true
            //    error_msg.Text = "balance  cannot have letters or null";

            //}
            else if (i == 0)
            {
                try
                {

                    string itemname = "";
                    decimal unitprice = 0;
                    decimal Qty = 0;
                   //Get Product Name, Rate and Qty customer wants to buy
                   itemname = Item_Name_txt.Text;
                     decimal.TryParse(unit_price_txt.Text,out unitprice);
                    //decimal unitprice1 = Convert.ToDecimal(unit_price_txt.Text);
                   decimal.TryParse(Quantity_txt.Text,out Qty);

                    decimal Total = unitprice * Qty; //Total=RatexQty
                    Console.WriteLine(Total);
                    decimal subtotal = 0;
                    decimal.TryParse(txt_subtotal.Text,out subtotal);
                    subtotal = subtotal + Total;


                    //Display the Subtotal in textbox
                    //Get the subtotal value from textbox


                    // decimal subTotal = 0;


                    //// txt_subtotal.Text = subTotal.ToString();
                    //subTotal = subTotal + Total;
                    //Console.WriteLine(subTotal);
                    //todo

                    //subTotal = decimal.Parse(txt_subtotal.Text);
                    //subTotal = subTotal + Total;

                    //todo end

                    //Check whether the product is selected or not

                    if (itemname == "")
                    {
                        //Display error MEssage
                        MessageBox.Show("Select the product first. Try Again.");
                    }
                    else
                    {


                        //Add product to the dAta Grid View
                        transactionDT.Rows.Add(itemname, unitprice, Qty, Total);

                        //Show in DAta Grid View
                        dgv_addedproduct.DataSource = transactionDT;
                        //Display the Subtotal in textbox

                        txt_subtotal.Text = subtotal.ToString();

                        //subTotal = decimal.Parse(txt_subtotal.Text);



                        //Clear the Textboxes

                        txt_search.Text = "";
                        //Item_Name_txt.Text = "";
                        //unit_price_txt.Text = "0.00";
                        //Quantity_txt.Text = "0.00";
                        //txt_subtotal.Text = "0.00";
                        //Item_code_txt.Clear();
                        Item_Name_txt.Clear();
                        unit_price_txt.Clear();
                        Quantity_txt.Clear();
                        error_msg.Text = "";

                    }

                }
                //does not meet the parameter specification of the called method
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
            //check whether product selected or not
            /*  if(itemname=="")
              {
                  MessageBox.Show("select the product and try again");
              }
              else
              {
                  tratractiondt.Rows.Add(itemname, Quantity, Unit_price, sum);
              }*/



        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
        }
        
      

        private void Calculate_btn_Click(object sender, EventArgs e)
        {

        }

        private void dgv_addedproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Get the keyword fro the text box
                string keyword = txt_search.Text;

            if (keyword == "")
            {
                //Clear all the textboxes
                Item_Name_txt.Text = "";
                unit_price_txt.Text = "";

                return;
            }

            //Search the product and display on respective textboxes
            itemBLL p = xDAL.GetProductsForTransaction(keyword);

            //Set the values on textboxes based on p object
            Item_Name_txt.Text = p.item_name;
            unit_price_txt.Text = p.unit_price.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("search");
            }
        }

        private void txt_discountamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = 0;
                 //Get the value fro discount textbox
                 decimal.TryParse(txt_discountamount.Text,out value);

                //if (value == "")
                //{
                //    //Display Error Message
                //    MessageBox.Show("Please Add Discount First");
                //}
                //else
                //{
                decimal subtotal = 0;
                decimal discount = 0;

                    //Get the discount in decimal value
                    decimal.TryParse(txt_subtotal.Text,out subtotal    );
                decimal.TryParse(txt_discountamount.Text,out discount);

                //Calculate the grandtotal based on discount
                decimal grandTotal = ((100 - discount) / 100) * subtotal;

                //Display the GrandTotla in TextBox
                txt_grandtotal.Text = grandTotal.ToString();
                //}
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

        private void txt_paidamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal grandTotal = 0;
            decimal paidAmount = 0;
            
                //Get the paid amount and grand total
                decimal.TryParse(txt_grandtotal.Text,out grandTotal);
                decimal.TryParse(txt_paidamount.Text,out paidAmount);
                //decimal paidAmount = Convert.ToDecimal(txt_paidamount.Text);
                // decimal grandTotal = Convert.ToDecimal(txt_grandtotal.Text);
                decimal returnAmount = paidAmount - grandTotal;

                //Display the return amount as well
                txt_return_amount.Text = returnAmount.ToString();
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            int i = 0;
          //  string compare = Quantity_txt.Text;
            string discount = txt_discountamount.Text;
          //  string gtotal = txt_grandtotal.Text;
            string amount = txt_paidamount.Text;
           // string balance = txt_return_amount.Text;
            Regex regex = new Regex(@"[\d]");
            //if (!regex.IsMatch(compare))
            //{
            //    //true
            //    error_msg.Text = "quantity cannot have letters or null";

            //}
           if (!regex.IsMatch(discount))
            {
                //true
                error_msg.Text = "discount  cannot have letters or null";

            }
            //else if (!regex.IsMatch(gtotal))
            //{
            //    //true
            //    error_msg.Text = "grand total  cannot have letters or null";

            //}
            else if (!regex.IsMatch(amount))
            {
                //true
                error_msg.Text = "Amount cannot have letters or null";

            }
            //else if (!regex.IsMatch(balance))
            //{
            //    //true
            //    error_msg.Text = "balance  cannot have letters or null";

            //}
            else if (i == 0) { 
            try
            {

                    if (con.State == ConnectionState.Closed)
                        con.Open();



                    cmd = new SqlCommand("Insert into tbltransaction values ('" + lbl_bill_id.Text + "', '" + txt_grandtotal.Text + "', '" + txt_discountamount.Text + "', '" + time_lbl.Text + "', '" + txt_paidamount.Text + "', '" + txt_return_amount.Text + "') ", con);

                    // cmd = new SqlCommand("insert into tblsignin values User_Name='" + guna_dash_username + "',password='" + guna_dash_password + "',Role='" + gunacmb_userrole + "'", con);
                    //dgv ekata

                   
                    //add data
                    int r = cmd.ExecuteNonQuery();
                if (r == 1)
                {
                    //    //Get the Values from PurchaseSales Form First
                    trnsactionBLL transaction = new trnsactionBLL();

                transaction.grandtotal = Math.Round(decimal.Parse(txt_grandtotal.Text), 2);
                // transaction.transaction_date = DateTime.Now;

                transaction.Discounnt_amount = decimal.Parse(txt_discountamount.Text);

                //Code to Print Bill
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "\r\n\r\n AllinOne SuperMarket";

                printer.Title = "\r\n\r\n\r\n AllinOne SuperMarket \r\n\r\n";
                printer.SubTitle = "Srilanka  \r\n Phone: +94 764509790 \r\n\r\n";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Discount: " + txt_discountamount.Text + "% \r\n" +  "Grand Total: " + txt_grandtotal.Text + "\r\n\r\n" + "Thank you for doing business with us.";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dgv_addedproduct);

                MessageBox.Show("Transaction Completed Sucessfully");
                //Celar the Data Grid View and Clear all the TExtboxes
                dgv_addedproduct.DataSource = null;
                dgv_addedproduct.Rows.Clear();
                        error_msg.Text = "";
                        txt_search.Clear();

                    Item_Name_txt.Clear();
                unit_price_txt.Clear();
                Quantity_txt.Clear();


                txt_subtotal.Clear();
                    txt_discountamount.Clear();

                    txt_grandtotal.Clear();
                    txt_paidamount.Clear();
                    txt_return_amount.Clear();
                   // autoidnumber();
                   

                    }

                else
                    MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    con.Close();

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
               
                catch (Exception ex )
            {
                    throw ex;
               // MessageBox.Show("hi");
            }
                finally
                {
                    //Close Database Connection
                    con.Close();
                    autoidnumber();
                }
            }

        }
       
        private void bill_date_ValueChanged(object sender, EventArgs e)
        {
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
        
            this.time_lbl.Text = time.ToString();
        }

        private void lbl_bill_id_Click(object sender, EventArgs e)
        {
        }
    }
}
