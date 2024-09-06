using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//mail
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllinOne.UI
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void btnsend_Click(object sender, EventArgs e)
        {   int i= 0;

            if (!Regex.IsMatch(txtTo.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                gunaerror_msg.Text = "Enter a valid email. Ex:name@gmail.com";
                txtTo.Focus();
                i++;
            }
            else if (string.IsNullOrEmpty(txtsubject.Text))
            {
                gunaerror_msg.Text = "subject cannot be blank";
                txtsubject.Focus();
                i++;
            }
            else if (txtsubject.Text.Any(char.IsDigit))
            {
                gunaerror_msg.Text = "subject cannot have number";
                txtsubject.Focus();
                i++;
            }
            else if (string.IsNullOrEmpty(txtmessage.Text))
            {
                gunaerror_msg.Text = "subject cannot be blank";
                txtmessage.Focus();
                i++;
            }
            else if (txtmessage.Text.Any(char.IsDigit))
            {
                gunaerror_msg.Text = "subject cannot have number";
                txtmessage.Focus();
                i++;
            }
            if (i == 0)
            {
                String to, from, pass, messageBody;
                MailMessage message = new MailMessage();
                to = (txtTo.Text).ToString();
                from = "amazingone090@gmail.com";
                pass = "bogspexfcyqpvhgy";
                //messageBody = "Your reset code is " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                //message.Body = messageBody;
                message.Subject = txtsubject.Text;
                message.Body = txtmessage.Text;
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
                catch (Exception )
                {
                    MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //    //login to your mail server
                //    String to,from, pass, messageBody;


                //    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                //    smtp.EnableSsl = true;
                //    smtp.Port = 587;
                //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                //    MailMessage message = new MailMessage();
                //    to = (txtTo.Text).ToString();
                //    from = "amazingone090@gmail.com";
                //    pass = "bogspexfcyqpvhgy"; 
                //    if (!string.IsNullOrEmpty(txtEmailcc.Text))
                //        message.To.Add(new MailAddress(txtEmailcc.Text));
                //    message.Subject = txtsubject.Text;
                //    message.Body = txtmessage.Text;
                //    message.BodyEncoding = Encoding.UTF8;
                //    message.IsBodyHtml = true;
                //    message.Priority = MailPriority.Normal;
                //    message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                //    smtp.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                //    string userstate = "Sending...";
                //    //Send email async
                //    smtp.SendAsync(message, userstate);
                //    smtp.Credentials = new NetworkCredential(from, pass);
                //    try
                //    {
                //        smtp.Send(message);
                //        MessageBox.Show("Code Send Successfully");
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);
                //    }

                //}
                //private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
                //{
                //    if (e.Cancelled)
                //        MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    if (e.Error != null)
                //        MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    else
                //        MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
        }
    }
}
