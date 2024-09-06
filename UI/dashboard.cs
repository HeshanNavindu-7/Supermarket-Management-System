using AllinOne.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;


namespace AllinOne
{
    public partial class dashboard : Form
    {

        //    private Dashbo model;


        //constroctor
        public dashboard()
        {
            InitializeComponent();
            //default last 7 days
            /* dtpStartDate.Value = DateTime.Today.AddDays(-7);
             dtpEndDate.Value = DateTime.Now;
             btnLast7Days.Select();

             model = new Dashbo();
           LoadData();*/
        }

        private void LoadData()
        { /*
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData = true)
            {
                lblNumOrders.Text = model.NumOrders.ToString();
                lblTotalRevenue.Text = "$" + model.TotalRevenue.ToString();
                lblTotalProfit.Text = "$" + model.TotalProfit.ToString();

                lblNumCustomers.Text = model.NumCustomers.ToString();
                lblNumSuppliers.Text = model.NumSuppliers.ToString();
                lblNumProduct.Text = model.NumProducts.ToString();

                chartGrossRevenue.DataSource = model.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Data";
                chartGrossRevenue.Series[0].YValueMembers = "Total Amount";
                chartGrossRevenue.DataBind();

                chartTop5Product.DataSource = model.TopProductsList;
                chartTop5Product.Series[0].XValueMember = "Key";
                chartTop5Product.Series[0].YValueMembers = "Value";
                chartTop5Product.DataBind();

                dgvunderstock.DataSource = model.UnderstockList;

                Console.WriteLine("Loaded view :)");
            

            }
            else
            {
                Console.WriteLine("view not loaded");
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {/*
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();*/

        }

        private void DisableCustomDates()
        { /*
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;*/
        }
        private void btnToday_Click(object sender, EventArgs e)
        { /*
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();*/
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {/*
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;*/
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {/*
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();*/

        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {/*
            dtpStartDate.Value = new DateTime(DateTime.Today.Year,DateTime.Today.Month,1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();*/
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chartGrossRevenue_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        private void dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //data bidings
            // TODO: This line of code loads data into the 'itemdataset.tblitem' table. You can move, or remove it, as needed.
            try {
            tblitemTableAdapter.Fill(itemdataset.tblitem);
            }
            catch(Exception )
            {
                MessageBox.Show("check again");
            }
            // TODO: This line of code loads data into the 'allI.Product' table. You can move, or remove it, as needed.
            // this.productTableAdapter.Fill(this.allI.Product);
            /*  con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");

              cmd = new SqlCommand("select item_name,unit_price  from tblitem  ", con);
              SqlDataReader dr;
              try
              {
                  con.Open();
                  dr = cmd.ExecuteReader();
                  while(dr.Read())
                  {
                      // this.chartTop5Product.Series["Item"].Points.AddXY(dr.GetString( "item_name"),dr.Get("unit_price"));
                     // chartGrossRevenue.DataSource = model.GrossRevenueList;
                      chartGrossRevenue.Series[0].XValueMember = "item_name";
                      chartGrossRevenue.Series[0].YValueMembers = "item_name";
                      chartGrossRevenue.DataSource = itemdataset.DataSetName;
                      chartGrossRevenue.DataBind();
                  }
              }
              catch(Exception)
              {

              }


            autototal()






                         this. chartGrossRevenue.Series["Sales"].Points.AddXY("peter", 10);
                         this. chartGrossRevenue.Series["Sales"].Points.AddXY("mer", 25);
                          this.chartGrossRevenue.Series["Sales"].Points.AddXY("ter", 17);
                          this.chartGrossRevenue.Series["Sales"].Points.AddXY("per", 30);


                          this.chartTop5Product.Series["Product"].Points.AddXY("rice", 10);
                          this.chartTop5Product.Series["Product"].Points.AddXY("biscuts", 25);
                          this.chartTop5Product.Series["Product"].Points.AddXY("bread", 17);
                          this.chartTop5Product.Series["Product"].Points.AddXY("egg", 30);
                          this.chartTop5Product.Series["Product"].Points.AddXY("soap", 30);

              var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
              if (refreshData = true)
              {
                  lblNumOrders.Text = model.NumOrders.ToString();
                  lblTotalRevenue.Text = "$" + model.TotalRevenue.ToString();
                  lblTotalProfit.Text = "$" + model.TotalProfit.ToString();

                  lblNumCustomers.Text = model.NumCustomers.ToString();
                  lblNumSuppliers.Text = model.NumSuppliers.ToString();
                  lblNumProduct.Text = model.NumProducts.ToString();

                  chartGrossRevenue.DataSource = model.GrossRevenueList;
                  chartGrossRevenue.Series[0].XValueMember = "Data";
                  chartGrossRevenue.Series[0].YValueMembers = "Total Amount";
                  chartGrossRevenue.DataBind();

                  chartTop5Product.DataSource = model.TopProductsList;
                  chartTop5Product.Series[0].XValueMember = "Key";
                  chartTop5Product.Series[0].YValueMembers = "Value";
                  chartTop5Product.DataBind();

                  dgvunderstock.DataSource = model.UnderstockList;

                  Console.WriteLine("Loaded view :)");


              }
              else
              {
                  Console.WriteLine("view not loaded");
              }*/
            //SqlCommand cmd = new SqlCommand("select count(item_Id) from tbltransaction", con);

            //con.Open();

            //using (SqlDataReader dr = cmd.ExecuteReader())
            //{
            //    if (dr.Read())
            //    {
            //        try
            //        {




            //            lblnoproduct.Text = dr["bill_Id"].ToString().ToString();


            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }

            //}
            fillChart();

        }




        private void dgvunderstock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void time_lbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.time_lbl.Text = time.ToString();
        }
        private void fillChart()
        {//bar chart
            try { 
            SqlConnection con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=AllInOne;Integrated Security=True");
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select grandtotal,Date from tbltransaction", con);
            adapt.Fill(ds);
            chartGrossRevenue.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series
            chartGrossRevenue.Series["Sales"].XValueMember = "Date";
            //set the member columns of the chart data source used to data bind to the X-values of the series
            chartGrossRevenue.Series["Sales"].YValueMembers = "grandtotal";
            chartGrossRevenue.Titles.Add("");
            con.Close();
            }//exception
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
                MessageBox.Show("Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}