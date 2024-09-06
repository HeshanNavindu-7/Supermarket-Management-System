using AllinOne.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//mail library
using System.Net;
using System.Net.Mail;
using System.Text;
//validation
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllinOne.UI
{
    public partial class Forgot_password : Form
    {
        String randomCode;
        public static String to;

        public Forgot_password()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            int i=0;
            if (txtEmail.Text.Length == 0)
            {
                error_msg.Text = "Please Enter Email Address";
                txtEmail.Focus();

            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                error_msg.Text = "Enter a valid email. Ex:name@gmail.com";
                txtEmail.Focus();

            }
            else if (i == 0)
            {
                String from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (txtEmail.Text).ToString();
                from = "amazingone090@gmail.com";
                pass = "bogspexfcyqpvhgy";
                messageBody = "Your reset code is " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Password Reseting Code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code Send Successfully");
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_verify_Click(object sender, EventArgs e)
        {//for int valida
            int i = 0;
            string compare = txtVerify.Text;
            Regex regex = new Regex(@"[\d]");
            if (!regex.IsMatch(compare))
            {
                //true
                error.Text = "please enter verify code";

            }
            else if (i == 0)
            {
                try
                {
                    if (randomCode == (txtVerify.Text).ToString())
                    {
                        to = txtEmail.Text;
                        //resetPass rp = new resetPass();
                        this.Hide();
                        //rp.Show();
                        MessageBox.Show("Successfully verified admin will send you to new user name and password", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Wrong Code");
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
