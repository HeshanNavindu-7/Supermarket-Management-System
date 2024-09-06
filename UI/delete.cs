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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
      

        private void guna_de_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // int rowIndex = adduser_dgv.CurrentCell.RowIndex;
                //adduser_dgv.Rows.RemoveAt(rowIndex);
                cmd = new SqlCommand("Delete from tblsignin where User_Id = '" + guna_de_userid.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {

                    MessageBox.Show(this, "Data delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tblsigninTableAdapter.Fill(this.adduserDataset.tblsignin);

                    /*da = new SqlDataAdapter("Select * from  tblsignin", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    adduser_dgv.DataSource = dt;*/

                }
                else
                    MessageBox.Show(this, "Data Cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adduserDataset.tblsignin' table. You can move, or remove it, as needed.
            this.tblsigninTableAdapter.Fill(this.adduserDataset.tblsignin);
            con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");

        }
    }
}

