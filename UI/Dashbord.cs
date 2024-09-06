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
using System.Runtime.InteropServices;
using AllinOne.UI;

namespace AllinOne
{
    public partial class Dashbord : Form
    {
        public Dashbord(string value)
        {
            InitializeComponent();
            this.value = value;
        }
        public string value { get; set; }
        SqlConnection con;
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            guna_log_user.Text = value;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        internal object LoadData(DateTime value1, DateTime value2)
        {
            throw new NotImplementedException();
        }

        private void guna_mainpanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public void loadform(object Form)
        {
            if (this.guna_mainpanel.Controls.Count > 0)
                this.guna_mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.guna_mainpanel.Controls.Add(f);
            this.guna_mainpanel.Tag = f;
            f.Show();
        }

        private void guna_btndashbord_Click(object sender, EventArgs e)
        {//form load
            loadform(new dashboard());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
            loadform(new details());
        }

        private void guna_btnabout_Click(object sender, EventArgs e)
        {
            loadform(new About());
        }
       
        private void guna_btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna_mainpanel_Paint(object sender, PaintEventArgs e)
        {
            loadform(new dashboard());  
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loadform(new Inventory());
        }

        private void guna_btnadduser_Click(object sender, EventArgs e)
        {
            loadform(new add_new_user());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {//logout --> sign in
            SignIn signobj = new SignIn();
            signobj.Show();
            this.Hide();
        }

        private void guna_sidepanel_Paint(object sender, PaintEventArgs e)
        {
            con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");

            if (ulog.type=="A")
            {
                guna_btndashbord.Visible = true;
                guna_btnadduser.Visible = true;
                guna_btnproduct.Visible = true;
                guna_btndetails.Visible = true;
                guna2Button1.Visible = true;
                guna2Button2.Visible = false;
               
            }

            else if(ulog.type == "C")
            {
                guna_btndashbord.Visible = true;
                guna_btnadduser.Visible = false;
                guna_btnproduct.Visible =false;
                guna_btndetails.Visible = true;
                guna2Button1.Visible = true;
                guna2Button2.Visible = true;
              
            }
        }

        public void guna_log_user_Click(object sender, EventArgs e)
        {
            
        }

        private void guna_btnproduct_Click(object sender, EventArgs e)
        {
            loadform(new product());
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            loadform(new Cashior_dashbord ());
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
          
        }
    }
}
