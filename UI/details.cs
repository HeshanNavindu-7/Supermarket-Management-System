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

namespace AllinOne
{
    public partial class details : Form
    {
        public details()
        {
            InitializeComponent();
        }
       
        public void loadform(object Form)
        {
          
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection con;
        //bridge btween a DataSet and a data source
        SqlDataAdapter da;
        SqlCommand cmd;
        private void details_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");
        }

        private void guna_signupdtail_Click(object sender, EventArgs e)
        {
           
            da = new SqlDataAdapter("select * from tblsignup ", con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            guna_dgv_detail.DataSource = ds;
        
    }

        private void gunabtn_signindetails_Click(object sender, EventArgs e)
        {
            guna_dgv_detail.Refresh();
               da = new SqlDataAdapter("select * from tblsignin ", con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            guna_dgv_detail.DataSource = ds;
        }

        private void guna_dgv_detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna_dgv_detail.Refresh();
            da = new SqlDataAdapter("select * from tblitem ", con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            guna_dgv_detail.DataSource = ds;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna_dgv_detail.Refresh();
            da = new SqlDataAdapter("select * from tbltransaction ", con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            guna_dgv_detail.DataSource = ds;
        }
    }
}
