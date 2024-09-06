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
using AllinOne.UI;

namespace AllinOne
{
    public partial class SignIn : Form
    {
        // SqlConnection con = new SqlConnection(Properties.Settings.Default.uaDBConnectionString);
        SqlConnection con;
        //dataset data source connection
        SqlDataAdapter da;
        SqlCommand cmd;

        public SignIn()
        {
            InitializeComponent();

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");
        }

        private void gunasignup_Click(object sender, EventArgs e)
        {
            Signup sign = new Signup();
            sign.ShowDialog();
        }
        string log;
        private void gunasignin_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
            string username = guna_signin_username.Text.Trim();//Returns the result of removing all leading and trailing whitespace from text value text 
                string usernapwme = guna_signin_password.Text.Trim();
            cmd = new SqlCommand("SELECT * FROM tblsignin WHERE User_Name = '" + username + "' AND password = '" + usernapwme + "'  ", con);
                if (string.IsNullOrEmpty(guna_signin_username.Text))
                {
                    errormsg.Text = "UserName cannot be blank";
                    guna_signin_username.Focus();
                }
                else if (guna_signin_username.Text.Any(char.IsDigit))
                {
                    errormsg.Text = "UserName cannot have numbers";
                    guna_signin_username.Focus();
                }
                else if (string.IsNullOrEmpty(guna_signin_password.Text))
                {
                    errormsg.Text = "Please Enter your Password";
                    guna_signin_password.Focus();
                }
                else if (!guna2CheckBox1.Checked)
                {
                    errormsg.Text = " Agree terms and condition";
                    guna2CheckBox1.Focus();

                }
                else {
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {


                        //read data
                        while (dr.Read())
                        {//write who come to the admin or cahior
                            Console.WriteLine("Loaded view ('" + dr.GetValue(2).ToString() + "'):)");
                            if (dr.GetValue(3).ToString() == "admin")
                            {// ulog dashboard type
                                ulog.type = "A";
                                Dashbord dash = new Dashbord(guna_signin_username.Text);

                                dash.ShowDialog();
                                this.Hide();
                                //guna_log_user.Text = guna_signin_username.Text;
                            }
                            else if (dr.GetValue(3).ToString() == "Cashior")
                            {
                                ulog.type = "C";

                                Dashbord dash = new Dashbord(guna_signin_username.Text);
                                dash.ShowDialog();
                                this.Hide();

                            }
                        }
                    }
               
                else
                {
                    Console.WriteLine("invalid credential");
                }
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
            catch (Exception )
            {
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close Database Connection
                con.Close();
            }
            /* 
            
             da = new SqlDataAdapter(cmd);
             SigninDataSet ds = new SigninDataSet();
            
              da.Fill(ds);
               int i = ds.tblsignin.Rows.Count;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            try
            {
                if (dr["Role"].ToString() == "admin")
                {
                    ulog.type = "A";
                    Dashbord dash = new Dashbord();
                    dash.ShowDialog();
                    this.Hide();
                    //guna_log_user.Text = guna_signin_username.Text;
                }
                else if (dr["Role"].ToString() == "Cashior")
                {
                    ulog.type = "C";

                    Dashbord dash = new Dashbord();
                    dash.ShowDialog();
                    this.Hide();

                }


                else
                {
                    MessageBox.Show("", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           */

        }

        private void guna_signin_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgot_password_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_password ss = new Forgot_password();
            ss.ShowDialog();
        }

        private void Forgot_Password_Click(object sender, EventArgs e)
        {
       
        }
    }
}
