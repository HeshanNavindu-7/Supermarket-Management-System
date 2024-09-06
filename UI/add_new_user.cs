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
using System.Text.RegularExpressions;
using AllinOne.UI;

namespace AllinOne
{
    public partial class add_new_user : Form
    {
        public add_new_user()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        SqlDataAdapter da;

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

            // cmd = new SqlCommand("insert into tblsignin values User_Id='" + guna_adduser_id + "',User_Name='" + guna_dash_username + "',password='" + guna_dash_password + "',Role='" + gunacmb_userrole + "'", con);
        }

        private void add_new_user_Load(object sender, EventArgs e)
        {//data bindings
            // TODO: This line of code loads data into the 'adduserDataset.tblsignin' table. You can move, or remove it, as needed.
            this.tblsigninTableAdapter1.Fill(this.adduserDataset.tblsignin);
            // TODO: This line of code loads data into the 'allInOneDataSet.tblsignin' table. You can move, or remove it, as needed.
            //  this.tblsigninTableAdapter.Fill(this.allInOneDataSet.tblsignin);
            // TODO: This line of code loads data into the 'allInOneDataSet.tblsignin' table. You can move, or remove it, as needed.
            // this.tblsigninTableAdapter1.Fill(this.allInOneDataSet.tblsignin);
            //con path
            con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");
            /* da = new SqlDataAdapter("Select * from  tblsignin", con);
             DataTable dt = new DataTable();
             da.Fill(dt);
             adduser_dgv.DataSource = dt;*/
            guna_addnew_userid.Enabled = true;
        }


        private void edit(bool value)
        {
            guna_addnew_userid.Enabled = false;
            guna_dash_password.Enabled = true;
        }









        private void guna_dash_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna_btn_add_Click(object sender, EventArgs e)
        { int i = 0;
            string compare = guna_addnew_userid.Text;
            Regex regex = new Regex(@"[\d]");
            if (!regex.IsMatch(compare))
            {
                //true
                error_msg.Text = "user id cannot have letters";

            }
            else if (string.IsNullOrEmpty(guna_dash_username.Text))
            {
                error_msg.Text = "First Name cannot be blank";
                guna_dash_username.Focus();
                i++;
            }
            else if (guna_dash_username.Text.Any(char.IsDigit))
            {
                error_msg.Text = "First Name cannot have numbers";
                guna_dash_username.Focus();
                i++;
            }
            else if (string.IsNullOrEmpty(guna_dash_password.Text))
            {
                error_msg.Text = "Please Enter your Password";
                guna_dash_password.Focus();
                i++;
            }
            else if (gunacmb_userrole.SelectedIndex == -1)
            {
                error_msg.Text = "please  select the user Role";
                gunacmb_userrole.Focus();
                i++;

            }
            else if (i == 0) {
                try
                {

                    guna_dash_username.Focus();
                    con.Open();
                    cmd = new SqlCommand("Insert into tblsignin values ('" + guna_addnew_userid.Text + "','" + guna_dash_username.Text + "', '" + guna_dash_password.Text + "', '" + gunacmb_userrole.Text + "') ", con);

                    // cmd = new SqlCommand("insert into tblsignin values User_Name='" + guna_dash_username + "',password='" + guna_dash_password + "',Role='" + gunacmb_userrole + "'", con);
                    //dgv ekata



                    //add data
                    int r = cmd.ExecuteNonQuery();
                    if (r == 1)
                    {



                        MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       //display the data row
                        this.tblsigninTableAdapter1.Fill(this.adduserDataset.tblsignin);

                        /*adduser_dgv.Refresh();
                        da = new SqlDataAdapter("Select * from  tblsignin", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        adduser_dgv.DataSource = dt;
                        guna_dash_username.Clear();
                        guna_dash_password.Clear();*/
                    }


                    else
                        MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
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
                    MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                guna_dash_username.Clear();
                guna_addnew_userid.Clear();
                guna_dash_password.Clear();
            }
        }

        /*
        guna_DataGridView_adduser.Rows.Add(gunacmb_userrole.Text, guna_dash_username.Text, guna_dash_password.Text);
        con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");
        con.Open();
         cmd.ExecuteNonQuery();
        guna_DataGridView_adduser.Refresh();
       con.Close();
       MessageBox.Show("your data save succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        // guna_DataGridView_adduser.Rows.(guna_adduser_id.Text, gunacmb_userrole.Text, guna_dash_username.Text, guna_dash_password.Text);
        //new




        SqlDataAdapter da = new SqlDataAdapter(cmd);
        SigninDataSet ds = new SigninDataSet();

        da.Fill(ds);

        guna_DataGridView_adduser.DataSource = ds;
        */

        private void display_data()
        {

        }


        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna_DataGridView_adduser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adduser_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btn_updateadduser_Click(object sender, EventArgs e)
        {
            guna_addnew_userid.Enabled = true;
            guna_dash_password.Enabled = true;
            int i = 0;
            string compare = guna_addnew_userid.Text;
            Regex regex = new Regex(@"[\d]");
            if (!regex.IsMatch(compare))
            {
                //true
                error_msg.Text = "user id cannot have letters";
               
            }
            else if (string.IsNullOrEmpty(guna_dash_username.Text))
            {
                error_msg.Text = "user Name cannot be blank";
                guna_dash_username.Focus();
                i++;
            }
            else if (guna_dash_username.Text.Any(char.IsDigit))
            {
                error_msg.Text = "First Name cannot have numbers";
                guna_dash_username.Focus();
                i++;
            }
            else if (string.IsNullOrEmpty(guna_dash_password.Text))
            {
                error_msg.Text = "Please Enter your Password";
                guna_dash_password.Focus();
                i++;
            }
            else if (gunacmb_userrole.SelectedIndex == -1)
            {
                error_msg.Text = "please  select the user Role";
                gunacmb_userrole.Focus();
                i++;

            }
            else if (i == 0)
            {
                try
                {
                    con.Open();

                    cmd = new SqlCommand("Update tblsignin set User_Name='" + guna_dash_username.Text + "',password= '" + guna_dash_password.Text + "',Role= '" + gunacmb_userrole.Text + "'where User_Id='" + guna_addnew_userid.Text + "' ", con);

                    //  adduserDataset.tblsignin.AddtblsigninRow(adduserDataset.tblsignin.)
                    //dgv ekata



                    //add data
                    int r = cmd.ExecuteNonQuery();
                    if (r == 1)
                    {


                        MessageBox.Show(this, "Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //display row
                        this.tblsigninTableAdapter1.Fill(this.adduserDataset.tblsignin);
                        /* adduser_dgv.Refresh();
                        da = new SqlDataAdapter("Select * from  tblsignin", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        adduser_dgv.DataSource = dt;*/

                    }

                    else
                        MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
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
                    MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                guna_dash_username.Clear();
                guna_addnew_userid.Clear();
                guna_dash_password.Clear();
            }


        }

        private void btn_deleteadduser_Click(object sender, EventArgs e)
        {
            int i = 0;
            string compare = guna_addnew_userid.Text;
            Regex regex = new Regex(@"[\d]");
            if (!regex.IsMatch(compare))
            {
                //true
                error_msg.Text = "User id  cannot have letters or null";

            }
            //else if (string.IsNullOrEmpty(guna_dash_username.Text))
            //{
            //    error_msg.Text = "First Name cannot be blank";
            //    guna_dash_username.Focus();
            //    i++;
            //}
            //else if (guna_dash_username.Text.Any(char.IsDigit))
            //{
            //    error_msg.Text = "First Name cannot have numbers";
            //    guna_dash_username.Focus();
            //    i++;
            //}
            //else if (string.IsNullOrEmpty(guna_dash_password.Text))
            //{
            //    error_msg.Text = "Please Enter your Password";
            //    guna_dash_password.Focus();
            //    i++;
            //}
            //else if (gunacmb_userrole.SelectedIndex == -1)
            //{
            //    error_msg.Text = "please  select the user Role";
            //    gunacmb_userrole.Focus();
            //    i++;

            //}
            else if (i == 0)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from tblsignin where User_Id = '" + guna_addnew_userid.Text + "'", con);
                    int r = cmd.ExecuteNonQuery();
                    if (r == 1)
                    {

                        MessageBox.Show(this, "Data delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.tblsigninTableAdapter1.Fill(this.adduserDataset.tblsignin);

                        /*da = new SqlDataAdapter("Select * from  tblsignin", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        adduser_dgv.DataSource = dt;*/

                    }
                    else
                        MessageBox.Show(this, "Data Cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //delete de = new delete();
                    //de.ShowDialog();
                    //this.tblsigninTableAdapter1.Fill(this.adduserDataset.tblsignin);
                    //guna_dash_username.Clear();
                    //guna_addnew_userid.Clear();
                    //guna_dash_password.Clear();
                   
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
                finally
                {
                    con.Close();
                }
            }
        
        }
        adduserDAL xDAL = new adduserDAL();
        private void guna_addnew_userid_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //Get the keyword fro the text box
            //    string keyword = guna_addnew_userid.Text;

            //    if (keyword == "")
            //    {
            //        //Clear all the textboxes
            //        guna_dash_username.Text = "";
            //        guna_dash_password.Text = "";
            //        gunacmb_userrole.Text = "";


            //        return;
            //    }

            //    //Search the product and display on respective textboxes
            //    adduserBLL p = xDAL.GetProductsForTransaction(keyword);

            //    //Set the values on textboxes based on p object
            //    guna_dash_username.Text = p.User_Name;
            //    guna_dash_password.Text = p.password;
            //    gunacmb_userrole.Text = p.Role;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SendEmail ss = new SendEmail();
            ss.ShowDialog();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            error_msg.Text = "";
            guna_dash_username.Clear();
            guna_addnew_userid.Clear();
            guna_dash_password.Clear();
        }
    }
}