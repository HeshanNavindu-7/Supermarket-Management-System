using AllinOne.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllinOne.DataAccessLayer
{
    class adduserDAL
    {
        static string myConnstring = ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString;

        #region METHOD TO SEARCH adduser IN TRANSACTION MODULE
        public adduserBLL GetProductsForTransaction(string keyword)
        {
            //Create an object of productsBLL and return it
            adduserBLL p = new adduserBLL();
            //SqlConnection
            SqlConnection conn = new SqlConnection(myConnstring);
            //Datatable to store data temporarily
            DataTable dt = new DataTable();

            try
            {
                //Write the Query to Get the detaisl
                string sql = "SELECT User_Id, User_Name, password,Role FROM tblsignin WHERE User_Id LIKE '%" + keyword + "%' ";
                //Create Sql Data Adapter to Execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                //Open DAtabase Connection
                conn.Open();

                //Pass the value from adapter to dt
                adapter.Fill(dt);

                //If we have any values on dt then set the values to productsBLL
                if (dt.Rows.Count > 0)
                {
                    p.User_Id = Int32.Parse(dt.Rows[0]["User_Id"].ToString());
                    p.User_Name = dt.Rows[0][" User_Name"].ToString();
                    p.password = dt.Rows[0]["unit_price"].ToString();
                    p.Role = dt.Rows[0]["quantity"].ToString();
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
    }
}
