using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using AllinOne.DataLayer;
using System.Net.Mail;
using System.Net;

namespace AllinOne
{
    public partial class Signup : Form
    {
      // to con open
        SqlConnection con;
        //data incert delete...
        SqlCommand cmd;

        public Signup()
        {
            InitializeComponent();
            
        }
       


        

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {
           // con path
                con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");
         
        }

        private void gunabtn_signup_Click(object sender, EventArgs e)
        {
            int r = 0;
           
            
            string discount = gunatxt_firstname.Text;
            
           
            
            Regex regex = new Regex(@"[\d]");
            if (gunacmb_gender.SelectedItem == null)
            {
                gunaerror_msg.Text = "Please select gender";
                gunacmb_gender.Focus();
                r++;

            }
            else if(string.IsNullOrEmpty(gunatxt_firstname.Text))
            {
                gunaerror_msg.Text = "First Name cannot be blank";
                gunatxt_firstname.Focus();
                r++;
            }
            else if (gunatxt_firstname.Text.Any(char.IsDigit))
            {
                gunaerror_msg.Text = "First Name cannot have number";
                gunatxt_firstname.Focus();
                r++;
            }
            else if (gunatxt_firstname.Text.Length <= 20)
            {
                gunaerror_msg.Text = "First Name cannot have greater than 20 letters";
                gunatxt_firstname.Focus();
                r++;
            }

            else if (!Regex.IsMatch(gunatxt_firstname.Text, @"[^A - Za - z0 - 9]"))
            {
                gunaerror_msg.Text = "can not enter simbol";
                gunatxt_firstname.Focus();
                r++;
            }
            else if (string.IsNullOrEmpty(gunatxt_lastname.Text))
            {
                gunaerror_msg.Text = "Last Name cannot be blank";
                gunatxt_lastname.Focus();
                r++;
            }
            else if (gunatxt_lastname.Text.Any(char.IsDigit))
            {
                gunaerror_msg.Text = "last Name cannot have numbers";
                gunatxt_firstname.Focus();
                r++;
            }
            else if (gunatxt_lastname.Text.Any(char.IsDigit))
            {
                gunaerror_msg.Text = "Last Name cannot have numbers";
                gunatxt_lastname.Focus();
                r++;
            }
          
            else if (!Regex.IsMatch(gunatxt_lastname.Text, @"[^A - Za - z0 - 9]"))
            {
                gunaerror_msg.Text = "can not enter simbol";
                gunatxt_lastname.Focus();
                r++;
            }
            else if (gunatxt_lastname.Text.Length <= 20)
            {
                gunaerror_msg.Text = "First Name cannot have greater than 20 letters";
                gunatxt_lastname.Focus();
                r++;
            }

            else if (gunacmb_role.SelectedItem == null)
            {
                gunaerror_msg.Text = "Please select role";
                gunacmb_role.Focus();
                r++;

            }
            else if (gunatxt_email.Text.Length == 0)
            {
                gunaerror_msg.Text = "Please Enter Email Address";
                gunatxt_email.Focus();
                r++;
            }
            else if (!Regex.IsMatch(gunatxt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                gunaerror_msg.Text = "Enter a valid email. Ex:name@gmail.com";
                gunatxt_email.Focus();
                r++;
            }
            else if (!Regex.IsMatch(gunatxt_cnumber.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                gunaerror_msg.Text = "TP must have 10 numbers";
                gunatxt_cnumber.Focus();
                r++;
            }
           
            else if (gunatxt_password.Text.Length == 0 && gunatxt_password.Text.Length <= 12)
            {
                gunaerror_msg.Text = "password can not be null or greater than 12 ";
                gunatxt_password.Focus();
                r++;
            }
            else if (gunatxt_cpassword.Text.Length == 0 && gunatxt_cpassword.Text.Length <= 12)
            {
                gunaerror_msg.Text = "password can not be null or greater than 12 ";
                gunatxt_cpassword.Focus();
                r++;
            }
            else if (gunatxt_password.Text != gunatxt_cpassword.Text)
            {
                gunaerror_msg.Text = "password and confirm password not eqal please check";
                gunatxt_cpassword.Focus();
                r++;
            }

            else if (!gunacheckbox.Checked && !gunacheckbox.Checked)
            {
                gunaerror_msg.Text = "Please agree terms condition";
                gunacheckbox.Focus();
                r++;

            }

            else if (r == 0)
            {

                try
                {

                    // con = DataAccessLayer.ConnectionManger.GetConnection();
                    con.Open();

                    cmd = new SqlCommand("insert into tblsignup values ('" + gunacmb_role.Text + "','" + gunatxt_firstname.Text + "', '" + gunatxt_lastname.Text + "', '" + gunatxt_email.Text + "','" + gunatxt_cnumber.Text + "',   '" + gunacmb_gender.Text + "', '" + gunaDOB.Value + "',  '" + gunatxt_password.Text + "', '" + gunatxt_cpassword.Text + "') ", con);
                    int i = cmd.ExecuteNonQuery();



                    //else
                    //    {
                    //        gunaerror_msg.Text = "";
                    //        //MessageBox.Show("Successfully Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (i == 1)
                    {
                        gunaerror_msg.Text = "";
                        MessageBox.Show(this, "Data save Successfully"+"  "+"Admin will send your user name and password ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //SignIn signobj = new SignIn();
                        //signobj.Show();

                        //authantycation prolem

                        //String to, from, pass, messageBody;
                        //MailMessage message = new MailMessage();
                        //to = "amazingone090@gmail.com";
                        //from = (gunatxt_email.Text).ToString();
                        //***pass = "bogspexfcyqpvhgy";
                        ////messageBody = "Your reset code is " + randomCode;
                        //message.To.Add(to);
                        //message.From = new MailAddress(from);
                        ////message.Body = messageBody;
                        //message.Subject = "new user sign up";
                        //message.Body = "send new user name & password";
                        //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        //smtp.EnableSsl = true;
                        //smtp.Port = 587;
                        //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        //smtp.Credentials = new NetworkCredential(from, pass);
                        //try
                        //{
                        //    smtp.Send(message);
                        //    MessageBox.Show("Code Send Successfully");
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.Message);
                        //}

                    }
                    else
                        MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                    con.Close();
                    cmd.Dispose();

                }
                //pass does not meet the parameter specification of the called method
                catch (ArgumentException)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException )
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

            }


        }

        private void gunaDOB_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - gunaDOB.Value.Year; 
            
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
