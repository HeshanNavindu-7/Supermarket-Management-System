
namespace AllinOne
{
    partial class add_new_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_new_user));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna_dash_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.tblsigninBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.adduserDataset = new AllinOne.adduserDataset();
            this.guna_dash_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.tblsigninBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gunacmb_userrole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna_btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.error_msg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna_addnew_userid = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_deleteadduser = new Guna.UI2.WinForms.Guna2Button();
            this.guna_btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.adduser_dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tblsigninBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblsigninTableAdapter = new AllinOne.AllInOneDataSetTableAdapters.tblsigninTableAdapter();
            this.tblsigninTableAdapter1 = new AllinOne.adduserDatasetTableAdapters.tblsigninTableAdapter();
            this.guna2HtmlLabel20 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tblsigninBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adduserDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsigninBindingSource1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adduser_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsigninBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna_dash_username
            // 
            this.guna_dash_username.BorderRadius = 5;
            this.guna_dash_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna_dash_username.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tblsigninBindingSource2, "User_Name", true));
            this.guna_dash_username.DefaultText = "";
            this.guna_dash_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna_dash_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna_dash_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna_dash_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna_dash_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna_dash_username.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.guna_dash_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna_dash_username.Location = new System.Drawing.Point(422, 56);
            this.guna_dash_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna_dash_username.Name = "guna_dash_username";
            this.guna_dash_username.PasswordChar = '\0';
            this.guna_dash_username.PlaceholderText = "User Name";
            this.guna_dash_username.SelectedText = "";
            this.guna_dash_username.Size = new System.Drawing.Size(178, 39);
            this.guna_dash_username.TabIndex = 1;
            this.guna_dash_username.TextChanged += new System.EventHandler(this.guna_dash_username_TextChanged);
            // 
            // tblsigninBindingSource2
            // 
            this.tblsigninBindingSource2.DataMember = "tblsignin";
            this.tblsigninBindingSource2.DataSource = this.adduserDataset;
            // 
            // adduserDataset
            // 
            this.adduserDataset.DataSetName = "adduserDataset";
            this.adduserDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna_dash_password
            // 
            this.guna_dash_password.BorderRadius = 5;
            this.guna_dash_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna_dash_password.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tblsigninBindingSource2, "password", true));
            this.guna_dash_password.DefaultText = "";
            this.guna_dash_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna_dash_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna_dash_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna_dash_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna_dash_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna_dash_password.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.guna_dash_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna_dash_password.Location = new System.Drawing.Point(720, 56);
            this.guna_dash_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna_dash_password.Name = "guna_dash_password";
            this.guna_dash_password.PasswordChar = '\0';
            this.guna_dash_password.PlaceholderText = "Password";
            this.guna_dash_password.SelectedText = "";
            this.guna_dash_password.Size = new System.Drawing.Size(180, 39);
            this.guna_dash_password.TabIndex = 1;
            // 
            // tblsigninBindingSource1
            // 
            this.tblsigninBindingSource1.DataMember = "tblsignin";
            this.tblsigninBindingSource1.DataSource = this.adduserDataset;
            // 
            // gunacmb_userrole
            // 
            this.gunacmb_userrole.BackColor = System.Drawing.Color.Transparent;
            this.gunacmb_userrole.BorderRadius = 5;
            this.gunacmb_userrole.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tblsigninBindingSource2, "Role", true));
            this.gunacmb_userrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunacmb_userrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunacmb_userrole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunacmb_userrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunacmb_userrole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunacmb_userrole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gunacmb_userrole.ItemHeight = 30;
            this.gunacmb_userrole.Items.AddRange(new object[] {
            "admin",
            "Cashior"});
            this.gunacmb_userrole.Location = new System.Drawing.Point(982, 59);
            this.gunacmb_userrole.Name = "gunacmb_userrole";
            this.gunacmb_userrole.Size = new System.Drawing.Size(148, 36);
            this.gunacmb_userrole.TabIndex = 2;
            // 
            // guna_btn_add
            // 
            this.guna_btn_add.BorderRadius = 5;
            this.guna_btn_add.BorderThickness = 1;
            this.guna_btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna_btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna_btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna_btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna_btn_add.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna_btn_add.ForeColor = System.Drawing.Color.White;
            this.guna_btn_add.Location = new System.Drawing.Point(83, 147);
            this.guna_btn_add.Name = "guna_btn_add";
            this.guna_btn_add.Size = new System.Drawing.Size(156, 45);
            this.guna_btn_add.TabIndex = 5;
            this.guna_btn_add.Text = "Add";
            this.guna_btn_add.Click += new System.EventHandler(this.guna_btn_add_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel20);
            this.guna2Panel1.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.error_msg);
            this.guna2Panel1.Controls.Add(this.guna_addnew_userid);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel1.Controls.Add(this.btn_deleteadduser);
            this.guna2Panel1.Controls.Add(this.guna_btn_update);
            this.guna2Panel1.Controls.Add(this.adduser_dgv);
            this.guna2Panel1.Controls.Add(this.guna_btn_add);
            this.guna2Panel1.Controls.Add(this.gunacmb_userrole);
            this.guna2Panel1.Controls.Add(this.guna_dash_password);
            this.guna2Panel1.Controls.Add(this.guna_dash_username);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1189, 788);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Location = new System.Drawing.Point(400, 103);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(47, 33);
            this.guna2ImageButton1.TabIndex = 17;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(938, 147);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(156, 45);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Send Email";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // error_msg
            // 
            this.error_msg.BackColor = System.Drawing.Color.Transparent;
            this.error_msg.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.error_msg.ForeColor = System.Drawing.Color.Red;
            this.error_msg.Location = new System.Drawing.Point(464, 103);
            this.error_msg.Name = "error_msg";
            this.error_msg.Size = new System.Drawing.Size(3, 2);
            this.error_msg.TabIndex = 15;
            this.error_msg.Text = null;
            // 
            // guna_addnew_userid
            // 
            this.guna_addnew_userid.BorderRadius = 5;
            this.guna_addnew_userid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna_addnew_userid.DefaultText = "";
            this.guna_addnew_userid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna_addnew_userid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna_addnew_userid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna_addnew_userid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna_addnew_userid.Enabled = false;
            this.guna_addnew_userid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna_addnew_userid.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.guna_addnew_userid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna_addnew_userid.Location = new System.Drawing.Point(118, 56);
            this.guna_addnew_userid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna_addnew_userid.Name = "guna_addnew_userid";
            this.guna_addnew_userid.PasswordChar = '\0';
            this.guna_addnew_userid.PlaceholderText = "User Id";
            this.guna_addnew_userid.SelectedText = "";
            this.guna_addnew_userid.Size = new System.Drawing.Size(167, 39);
            this.guna_addnew_userid.TabIndex = 14;
            this.guna_addnew_userid.TextChanged += new System.EventHandler(this.guna_addnew_userid_TextChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Enabled = false;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(48, 59);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(64, 30);
            this.guna2HtmlLabel6.TabIndex = 13;
            this.guna2HtmlLabel6.Text = "User Id";
            // 
            // btn_deleteadduser
            // 
            this.btn_deleteadduser.BorderRadius = 5;
            this.btn_deleteadduser.BorderThickness = 1;
            this.btn_deleteadduser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteadduser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteadduser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deleteadduser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deleteadduser.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btn_deleteadduser.ForeColor = System.Drawing.Color.White;
            this.btn_deleteadduser.Location = new System.Drawing.Point(628, 147);
            this.btn_deleteadduser.Name = "btn_deleteadduser";
            this.btn_deleteadduser.Size = new System.Drawing.Size(180, 45);
            this.btn_deleteadduser.TabIndex = 8;
            this.btn_deleteadduser.Text = "Delete";
            this.btn_deleteadduser.Click += new System.EventHandler(this.btn_deleteadduser_Click);
            // 
            // guna_btn_update
            // 
            this.guna_btn_update.BorderRadius = 5;
            this.guna_btn_update.BorderThickness = 1;
            this.guna_btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna_btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna_btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna_btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna_btn_update.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna_btn_update.ForeColor = System.Drawing.Color.White;
            this.guna_btn_update.Location = new System.Drawing.Point(352, 147);
            this.guna_btn_update.Name = "guna_btn_update";
            this.guna_btn_update.Size = new System.Drawing.Size(156, 45);
            this.guna_btn_update.TabIndex = 7;
            this.guna_btn_update.Text = "Update";
            this.guna_btn_update.Click += new System.EventHandler(this.btn_updateadduser_Click);
            // 
            // adduser_dgv
            // 
            this.adduser_dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.adduser_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adduser_dgv.AutoGenerateColumns = false;
            this.adduser_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adduser_dgv.BackgroundColor = System.Drawing.Color.White;
            this.adduser_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adduser_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.adduser_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adduser_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adduser_dgv.ColumnHeadersHeight = 4;
            this.adduser_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.adduser_dgv.DataSource = this.tblsigninBindingSource2;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adduser_dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.adduser_dgv.EnableHeadersVisualStyles = false;
            this.adduser_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.adduser_dgv.Location = new System.Drawing.Point(48, 231);
            this.adduser_dgv.Name = "adduser_dgv";
            this.adduser_dgv.RowHeadersVisible = false;
            this.adduser_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adduser_dgv.Size = new System.Drawing.Size(1082, 499);
            this.adduser_dgv.TabIndex = 6;
            this.adduser_dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.adduser_dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.adduser_dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.adduser_dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.adduser_dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.adduser_dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.adduser_dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.adduser_dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.adduser_dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.adduser_dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.adduser_dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.adduser_dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.adduser_dgv.ThemeStyle.HeaderStyle.Height = 4;
            this.adduser_dgv.ThemeStyle.ReadOnly = false;
            this.adduser_dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.adduser_dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.adduser_dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.adduser_dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.adduser_dgv.ThemeStyle.RowsStyle.Height = 22;
            this.adduser_dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.adduser_dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.adduser_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adduser_dgv_CellContentClick);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "User_Id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.userIdDataGridViewTextBoxColumn.DividerWidth = 5;
            this.userIdDataGridViewTextBoxColumn.HeaderText = "User_Id";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 25;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User_Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(617, 59);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(85, 30);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Password";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(316, 59);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(99, 30);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "User Name";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(925, 59);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(42, 30);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Role";
            // 
            // tblsigninBindingSource
            // 
            this.tblsigninBindingSource.DataMember = "tblsignin";
            this.tblsigninBindingSource.DataSource = this.adduserDataset;
            // 
            // tblsigninTableAdapter
            // 
            this.tblsigninTableAdapter.ClearBeforeFill = true;
            // 
            // tblsigninTableAdapter1
            // 
            this.tblsigninTableAdapter1.ClearBeforeFill = true;
            // 
            // guna2HtmlLabel20
            // 
            this.guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel20.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel20.ForeColor = System.Drawing.SystemColors.Highlight;
            this.guna2HtmlLabel20.Location = new System.Drawing.Point(489, 3);
            this.guna2HtmlLabel20.Name = "guna2HtmlLabel20";
            this.guna2HtmlLabel20.Size = new System.Drawing.Size(149, 38);
            this.guna2HtmlLabel20.TabIndex = 181;
            this.guna2HtmlLabel20.Text = "Add user";
            // 
            // add_new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 788);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_new_user";
            this.Text = "add_new_user";
            this.Load += new System.EventHandler(this.add_new_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblsigninBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adduserDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsigninBindingSource1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adduser_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsigninBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox guna_dash_username;
        private Guna.UI2.WinForms.Guna2TextBox guna_dash_password;
        private Guna.UI2.WinForms.Guna2ComboBox gunacmb_userrole;
        private Guna.UI2.WinForms.Guna2Button guna_btn_add;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView adduser_dgv;
        private AllInOneDataSetTableAdapters.tblsigninTableAdapter tblsigninTableAdapter;
        private adduserDataset adduserDataset;
        private System.Windows.Forms.BindingSource tblsigninBindingSource;
        private adduserDatasetTableAdapters.tblsigninTableAdapter tblsigninTableAdapter1;
        private System.Windows.Forms.BindingSource tblsigninBindingSource1;
        private System.Windows.Forms.BindingSource tblsigninBindingSource2;
        private Guna.UI2.WinForms.Guna2Button guna_btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_deleteadduser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox guna_addnew_userid;
        private Guna.UI2.WinForms.Guna2HtmlLabel error_msg;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel20;
    }
}