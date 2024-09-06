using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using AllinOne.BLL;

namespace AllinOne.DataAccessLayer
{
    class itemDAL
    {
        static string myConnstring = ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString;
        #region Select method for Product Module
        public DataTable Select()
        {
            //Create Sql Connection to connect Databaes
            SqlConnection conn = new SqlConnection(myConnstring);

            //DAtaTable to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //Writing the Query to Select all the products from database
                String sql = "SELECT * FROM tblitem";

                //Creating SQL Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //SQL Data Adapter to hold the value from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open DAtabase Connection
                conn.Open();

                adapter.Fill(dt);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show( "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
        #region Method to Insert Product in database
        public bool Insert(itemBLL p)
        {
            //Creating Boolean Variable and set its default value to false
            bool isSuccess = false;

            //Sql Connection for DAtabase
            SqlConnection conn = new SqlConnection(myConnstring);

            try
            {
                //SQL Query to insert product into database
                String sql = "INSERT INTO tblitem (item_Id,item_name, catogery,quantity,unit_price) VALUES (@item_Id,@item_name, @catogery, @quantity, @unit_price)";

                //Creating SQL Command to pass the values
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passign the values through parameters
                cmd.Parameters.AddWithValue("@item_Id", p.item_Id);
                cmd.Parameters.AddWithValue("@item_name", p.item_name);
                cmd.Parameters.AddWithValue("@catogery", p.catogery);
                cmd.Parameters.AddWithValue("@quantity", p.quantity);
                cmd.Parameters.AddWithValue("@unit_price", p.unit_price);
                

                //Opening the Database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //If the query is executed successfully then the value of rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //FAiled to Execute Query
                    isSuccess = false;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Method to Update Product in Database
        public bool Update(itemBLL p)
        {
            //create a boolean variable and set its initial value to false
            bool isSuccess = false;

            //Create SQL Connection for DAtabase
            SqlConnection conn = new SqlConnection(myConnstring);

            try
            {
                //SQL Query to Update Data in dAtabase
                String sql = "UPDATE  tblitem SET item_Id=@item_Id,item_name=@item_name, catogery=@catogery, quantity=@quantity, unit_price=@unit_price where item_Id=@item_Id ";

                //Create SQL Cmmand to pass the value to query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the values using parameters and cmd
                cmd.Parameters.AddWithValue("@item_Id", p.item_Id);
                cmd.Parameters.AddWithValue("@item_name", p.item_name);
                cmd.Parameters.AddWithValue("@catogery", p.catogery);
                cmd.Parameters.AddWithValue("@quantity", p.quantity);
                cmd.Parameters.AddWithValue("@unit_price", p.unit_price);

                //Open the Database connection
                conn.Open();

                //Create Int Variable to check if the query is executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully then the value of rows will be greater than 0 else it will be less than zero
                if (rows > 0)
                {
                    //Query ExecutedSuccessfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show( "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;

        }

       

        #endregion
        #region Method to Delete Product from Database
        public bool Delete(itemBLL p)
        {
            //Create Boolean Variable and Set its default value to false
            bool isSuccess = false;

            //SQL Connection for DB connection
            SqlConnection conn = new SqlConnection(myConnstring);

            try
            {
                //Write Query Product from DAtabase
                String sql = "DELETE FROM tblitem WHERE item_Id=@item_Id";

                //Sql Command to Pass the Value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values using cmd
                cmd.Parameters.AddWithValue("@item_Id", p.item_Id);

                //Open Database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query is executed successfullly then the value of rows will be greated than 0 else it will be less than 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region SEARCH Method for Product Module
        public DataTable Search(string keywords)
        {
            //SQL Connection fro DB Connection
            SqlConnection conn = new SqlConnection(myConnstring);
            //Creating DAtaTable to hold value from dAtabase
            DataTable dt = new DataTable();

            try
            {
                //SQL query to search product
                string sql = "SELECT * FROM tblitem WHERE item_Id LIKE '%" + keywords + "%' OR  item_name LIKE '%" + keywords + "%' OR catogery LIKE '%" + keywords + "%'OR quantity LIKE '%" + keywords + "%'";
                //Sql Command to execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //SQL Data Adapter to hold the data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                conn.Open();

                adapter.Fill(dt);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show( "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
        #region METHOD TO SEARCH PRODUCT IN TRANSACTION MODULE
        public itemBLL GetProductsForTransaction(string keyword)
        {
            //Create an object of productsBLL and return it
            itemBLL p = new itemBLL();
            //SqlConnection
            SqlConnection conn = new SqlConnection(myConnstring);
            //Datatable to store data temporarily
            DataTable dt = new DataTable();

            try
            {
                //Write the Query to Get the detaisl
                string sql = "SELECT item_name, unit_price, quantity,catogery FROM tblitem WHERE item_Id LIKE '%" + keyword + "%' OR item_name LIKE '%" + keyword + "%'";
                //Create Sql Data Adapter to Execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                //Open DAtabase Connection
                conn.Open();

                //Pass the value from adapter to dt
                adapter.Fill(dt);

                //If we have any values on dt then set the values to productsBLL
                if (dt.Rows.Count > 0)
                {
                    p.item_name = dt.Rows[0]["item_name"].ToString();
                    p.catogery= dt.Rows[0]["catogery"].ToString();
                    p.unit_price = decimal.Parse(dt.Rows[0]["unit_price"].ToString());
                    p.quantity = decimal.Parse(dt.Rows[0]["quantity"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return p;
        }
        #endregion
        #region METOD TO GET CURRENT QUANTITY FROM THE DATABASE ON ITEM ID
        public int GetitemQty(int item_Id )
        {
            //SqlConnection
            SqlConnection conn = new SqlConnection(myConnstring);
            //create int variable to sav and set its defaul value 0
            int qty = 0;
            //create datatable store data temporaly\
            DataTable dt = new DataTable();
            try
            {
                //get qty fromdatabase
                string sql = "Select quantity FROM tblitem where id ='+item_Id+'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //data adapter to execute quary
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    qty = Int32.Parse(dt.Rows[0]["quantity"].ToString());
                }
                conn.Close();
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return qty;
        }

        #endregion
        #region  METOD TO  UPDATE QTY
        public bool Updateqty(int item_Id,int qty)
        {
            bool success = false;
            //SqlConnection
            SqlConnection conn = new SqlConnection(myConnstring);
            try
            {
                string sql = "Update tblitem set qty=@quantity where item_Id=@item_Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@item_Id", item_Id);
              
                cmd.Parameters.AddWithValue("@quantity", qty);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return success;
        }
        #endregion
        #region METHOD TO INCRESE PRODOUCT
        public bool increaseitem(int item_Id, int increaseqty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myConnstring);

            try
            {
                int currentqty = GetitemQty(item_Id);
                int newqty = currentqty + increaseqty;
                //updateqty
                success = Updateqty(item_Id, newqty);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }
            return success;
        }
        #endregion
        #region METOD TO DECREASE PRODUCT
        public bool Decreseitem(int item_Id, int qty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myConnstring);
            try
            {
                int currentqty = GetitemQty(item_Id);
                int newqty = currentqty - qty;
                //updateqty
                success = Updateqty(item_Id, newqty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }
            return success;
        }

        #endregion
    }
}
