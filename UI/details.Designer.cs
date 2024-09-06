
namespace AllinOne
{
    partial class details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna_signupdtail = new Guna.UI2.WinForms.Guna2Button();
            this.guna_dgv_detail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunabtn_signindetails = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.allInOneDataSet = new AllinOne.AllInOneDataSet();
            this.allInOneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna_dgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allInOneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allInOneDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna_signupdtail
            // 
            this.guna_signupdtail.BorderRadius = 5;
            this.guna_signupdtail.BorderThickness = 1;
            this.guna_signupdtail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna_signupdtail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna_signupdtail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna_signupdtail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna_signupdtail.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna_signupdtail.ForeColor = System.Drawing.Color.White;
            this.guna_signupdtail.Location = new System.Drawing.Point(841, 78);
            this.guna_signupdtail.Name = "guna_signupdtail";
            this.guna_signupdtail.Size = new System.Drawing.Size(234, 45);
            this.guna_signupdtail.TabIndex = 0;
            this.guna_signupdtail.Text = "Signup";
            this.guna_signupdtail.Click += new System.EventHandler(this.guna_signupdtail_Click);
            // 
            // guna_dgv_detail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna_dgv_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna_dgv_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna_dgv_detail.BackgroundColor = System.Drawing.Color.White;
            this.guna_dgv_detail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna_dgv_detail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna_dgv_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna_dgv_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna_dgv_detail.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna_dgv_detail.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna_dgv_detail.EnableHeadersVisualStyles = false;
            this.guna_dgv_detail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna_dgv_detail.Location = new System.Drawing.Point(33, 149);
            this.guna_dgv_detail.Name = "guna_dgv_detail";
            this.guna_dgv_detail.RowHeadersVisible = false;
            this.guna_dgv_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna_dgv_detail.Size = new System.Drawing.Size(1042, 586);
            this.guna_dgv_detail.TabIndex = 1;
            this.guna_dgv_detail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna_dgv_detail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna_dgv_detail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna_dgv_detail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna_dgv_detail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna_dgv_detail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna_dgv_detail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna_dgv_detail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna_dgv_detail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna_dgv_detail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna_dgv_detail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna_dgv_detail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna_dgv_detail.ThemeStyle.HeaderStyle.Height = 4;
            this.guna_dgv_detail.ThemeStyle.ReadOnly = false;
            this.guna_dgv_detail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna_dgv_detail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna_dgv_detail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna_dgv_detail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna_dgv_detail.ThemeStyle.RowsStyle.Height = 22;
            this.guna_dgv_detail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna_dgv_detail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna_dgv_detail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna_dgv_detail_CellContentClick);
            // 
            // gunabtn_signindetails
            // 
            this.gunabtn_signindetails.BorderRadius = 5;
            this.gunabtn_signindetails.BorderThickness = 1;
            this.gunabtn_signindetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtn_signindetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtn_signindetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtn_signindetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtn_signindetails.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.gunabtn_signindetails.ForeColor = System.Drawing.Color.White;
            this.gunabtn_signindetails.Location = new System.Drawing.Point(574, 78);
            this.gunabtn_signindetails.Name = "gunabtn_signindetails";
            this.gunabtn_signindetails.Size = new System.Drawing.Size(224, 45);
            this.gunabtn_signindetails.TabIndex = 2;
            this.gunabtn_signindetails.Text = "Sign in";
            this.gunabtn_signindetails.Click += new System.EventHandler(this.gunabtn_signindetails_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(485, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(148, 46);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "DETAILS";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(306, 78);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(234, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Bill";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(33, 78);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(234, 45);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Item";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // allInOneDataSet
            // 
            this.allInOneDataSet.DataSetName = "AllInOneDataSet";
            this.allInOneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allInOneDataSetBindingSource
            // 
            this.allInOneDataSetBindingSource.DataSource = this.allInOneDataSet;
            this.allInOneDataSetBindingSource.Position = 0;
            // 
            // details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 788);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.gunabtn_signindetails);
            this.Controls.Add(this.guna_dgv_detail);
            this.Controls.Add(this.guna_signupdtail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "details";
            this.Text = "details";
            this.Load += new System.EventHandler(this.details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna_dgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allInOneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allInOneDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna_signupdtail;
        private Guna.UI2.WinForms.Guna2DataGridView guna_dgv_detail;
        private Guna.UI2.WinForms.Guna2Button gunabtn_signindetails;
        private System.Windows.Forms.BindingSource allInOneDataSetBindingSource;
        private AllInOneDataSet allInOneDataSet;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}