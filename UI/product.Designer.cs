
namespace AllinOne
{
    partial class product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.gunatxt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunadgv_product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catogeryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allInOneDataSet = new AllinOne.AllInOneDataSet();
            this.tblitemTableAdapter = new AllinOne.AllInOneDataSetTableAdapters.tblitemTableAdapter();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_item_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_unitprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_itemadd = new Guna.UI2.WinForms.Guna2Button();
            this.btn_itemupdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_itemid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_catogery = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.error_msg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunadgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allInOneDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gunatxt_search
            // 
            this.gunatxt_search.BorderRadius = 5;
            this.gunatxt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunatxt_search.DefaultText = "";
            this.gunatxt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunatxt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunatxt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunatxt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunatxt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunatxt_search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunatxt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunatxt_search.Location = new System.Drawing.Point(187, 190);
            this.gunatxt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunatxt_search.Name = "gunatxt_search";
            this.gunatxt_search.PasswordChar = '\0';
            this.gunatxt_search.PlaceholderText = "Search";
            this.gunatxt_search.SelectedText = "";
            this.gunatxt_search.Size = new System.Drawing.Size(283, 45);
            this.gunatxt_search.TabIndex = 0;
            this.gunatxt_search.TextChanged += new System.EventHandler(this.gunatxt_search_TextChanged);
            // 
            // gunadgv_product
            // 
            this.gunadgv_product.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunadgv_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunadgv_product.AutoGenerateColumns = false;
            this.gunadgv_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunadgv_product.BackgroundColor = System.Drawing.Color.White;
            this.gunadgv_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunadgv_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunadgv_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunadgv_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunadgv_product.ColumnHeadersHeight = 21;
            this.gunadgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.catogeryDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn});
            this.gunadgv_product.DataSource = this.tblitemBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunadgv_product.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunadgv_product.EnableHeadersVisualStyles = false;
            this.gunadgv_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunadgv_product.Location = new System.Drawing.Point(27, 280);
            this.gunadgv_product.Name = "gunadgv_product";
            this.gunadgv_product.RowHeadersVisible = false;
            this.gunadgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunadgv_product.Size = new System.Drawing.Size(1065, 396);
            this.gunadgv_product.TabIndex = 1;
            this.gunadgv_product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunadgv_product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunadgv_product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunadgv_product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunadgv_product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunadgv_product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunadgv_product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunadgv_product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunadgv_product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunadgv_product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunadgv_product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunadgv_product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunadgv_product.ThemeStyle.HeaderStyle.Height = 21;
            this.gunadgv_product.ThemeStyle.ReadOnly = false;
            this.gunadgv_product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunadgv_product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunadgv_product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunadgv_product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunadgv_product.ThemeStyle.RowsStyle.Height = 22;
            this.gunadgv_product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunadgv_product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunadgv_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunadgv_product_CellContentClick);
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "item_Id";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "item_Id";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "item_name";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            // 
            // catogeryDataGridViewTextBoxColumn
            // 
            this.catogeryDataGridViewTextBoxColumn.DataPropertyName = "catogery";
            this.catogeryDataGridViewTextBoxColumn.HeaderText = "catogery";
            this.catogeryDataGridViewTextBoxColumn.Name = "catogeryDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            // 
            // tblitemBindingSource
            // 
            this.tblitemBindingSource.DataMember = "tblitem";
            this.tblitemBindingSource.DataSource = this.allInOneDataSet;
            // 
            // allInOneDataSet
            // 
            this.allInOneDataSet.DataSetName = "AllInOneDataSet";
            this.allInOneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblitemTableAdapter
            // 
            this.tblitemTableAdapter.ClearBeforeFill = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(65, 193);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(87, 42);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Search";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(217, 41);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(146, 42);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Item Name";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(458, 41);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(119, 42);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Catogery";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(669, 44);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(105, 39);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Quantity";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(888, 44);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(117, 39);
            this.guna2HtmlLabel5.TabIndex = 2;
            this.guna2HtmlLabel5.Text = "Unit Price";
            // 
            // txt_item_name
            // 
            this.txt_item_name.BorderRadius = 5;
            this.txt_item_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_item_name.DefaultText = "";
            this.txt_item_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_item_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_item_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_item_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_item_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_item_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_item_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_item_name.Location = new System.Drawing.Point(217, 100);
            this.txt_item_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.PasswordChar = '\0';
            this.txt_item_name.PlaceholderText = "Item Name";
            this.txt_item_name.SelectedText = "";
            this.txt_item_name.Size = new System.Drawing.Size(179, 40);
            this.txt_item_name.TabIndex = 3;
            this.txt_item_name.TextChanged += new System.EventHandler(this.txt_item_name_TextChanged);
            // 
            // txt_quantity
            // 
            this.txt_quantity.BorderRadius = 5;
            this.txt_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_quantity.DefaultText = "";
            this.txt_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantity.Location = new System.Drawing.Point(637, 100);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PasswordChar = '\0';
            this.txt_quantity.PlaceholderText = "Quantity";
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.Size = new System.Drawing.Size(179, 39);
            this.txt_quantity.TabIndex = 3;
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.BorderRadius = 5;
            this.txt_unitprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_unitprice.DefaultText = "";
            this.txt_unitprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_unitprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_unitprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_unitprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_unitprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_unitprice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_unitprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_unitprice.Location = new System.Drawing.Point(863, 100);
            this.txt_unitprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.PasswordChar = '\0';
            this.txt_unitprice.PlaceholderText = "Unit Price";
            this.txt_unitprice.SelectedText = "";
            this.txt_unitprice.Size = new System.Drawing.Size(179, 40);
            this.txt_unitprice.TabIndex = 3;
            // 
            // btn_itemadd
            // 
            this.btn_itemadd.BorderRadius = 5;
            this.btn_itemadd.BorderThickness = 1;
            this.btn_itemadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_itemadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_itemadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_itemadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_itemadd.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btn_itemadd.ForeColor = System.Drawing.Color.White;
            this.btn_itemadd.Location = new System.Drawing.Point(570, 190);
            this.btn_itemadd.Name = "btn_itemadd";
            this.btn_itemadd.Size = new System.Drawing.Size(130, 45);
            this.btn_itemadd.TabIndex = 4;
            this.btn_itemadd.Text = "Add";
            this.btn_itemadd.Click += new System.EventHandler(this.btn_itemadd_Click);
            // 
            // btn_itemupdate
            // 
            this.btn_itemupdate.BorderRadius = 5;
            this.btn_itemupdate.BorderThickness = 1;
            this.btn_itemupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_itemupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_itemupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_itemupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_itemupdate.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btn_itemupdate.ForeColor = System.Drawing.Color.White;
            this.btn_itemupdate.Location = new System.Drawing.Point(752, 190);
            this.btn_itemupdate.Name = "btn_itemupdate";
            this.btn_itemupdate.Size = new System.Drawing.Size(130, 45);
            this.btn_itemupdate.TabIndex = 4;
            this.btn_itemupdate.Text = "Update";
            this.btn_itemupdate.Click += new System.EventHandler(this.btn_itemupdate_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(939, 190);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(130, 45);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Delete";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(58, 41);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(94, 42);
            this.guna2HtmlLabel6.TabIndex = 2;
            this.guna2HtmlLabel6.Text = "Item Id";
            // 
            // txt_itemid
            // 
            this.txt_itemid.BorderRadius = 5;
            this.txt_itemid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_itemid.DefaultText = "";
            this.txt_itemid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_itemid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_itemid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_itemid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemid.Location = new System.Drawing.Point(41, 100);
            this.txt_itemid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_itemid.Name = "txt_itemid";
            this.txt_itemid.PasswordChar = '\0';
            this.txt_itemid.PlaceholderText = "Item Id";
            this.txt_itemid.SelectedText = "";
            this.txt_itemid.Size = new System.Drawing.Size(131, 40);
            this.txt_itemid.TabIndex = 5;
            this.txt_itemid.TextChanged += new System.EventHandler(this.txt_itemid_TextChanged);
            // 
            // txt_catogery
            // 
            this.txt_catogery.BorderRadius = 5;
            this.txt_catogery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_catogery.DefaultText = "";
            this.txt_catogery.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_catogery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_catogery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_catogery.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_catogery.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_catogery.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_catogery.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_catogery.Location = new System.Drawing.Point(430, 103);
            this.txt_catogery.Name = "txt_catogery";
            this.txt_catogery.PasswordChar = '\0';
            this.txt_catogery.PlaceholderText = "Catogery";
            this.txt_catogery.SelectedText = "";
            this.txt_catogery.Size = new System.Drawing.Size(179, 36);
            this.txt_catogery.TabIndex = 7;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(12, 12);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(458, 145);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(44, 38);
            this.guna2ImageButton1.TabIndex = 19;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // error_msg
            // 
            this.error_msg.BackColor = System.Drawing.Color.Transparent;
            this.error_msg.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.error_msg.ForeColor = System.Drawing.Color.Red;
            this.error_msg.Location = new System.Drawing.Point(522, 145);
            this.error_msg.Name = "error_msg";
            this.error_msg.Size = new System.Drawing.Size(3, 2);
            this.error_msg.TabIndex = 18;
            this.error_msg.Text = null;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(488, 0);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(175, 46);
            this.guna2HtmlLabel7.TabIndex = 20;
            this.guna2HtmlLabel7.Text = "PRODUCT";
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 710);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.error_msg);
            this.Controls.Add(this.txt_catogery);
            this.Controls.Add(this.txt_itemid);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.btn_itemupdate);
            this.Controls.Add(this.btn_itemadd);
            this.Controls.Add(this.txt_unitprice);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_item_name);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.gunadgv_product);
            this.Controls.Add(this.gunatxt_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "product";
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunadgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allInOneDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2TextBox gunatxt_search;
        private Guna.UI2.WinForms.Guna2DataGridView gunadgv_product;
        private AllInOneDataSet allInOneDataSet;
        private System.Windows.Forms.BindingSource tblitemBindingSource;
        private AllInOneDataSetTableAdapters.tblitemTableAdapter tblitemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catogeryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txt_item_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_quantity;
        private Guna.UI2.WinForms.Guna2TextBox txt_unitprice;
        private Guna.UI2.WinForms.Guna2Button btn_itemadd;
        private Guna.UI2.WinForms.Guna2Button btn_itemupdate;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txt_itemid;
        private Guna.UI2.WinForms.Guna2TextBox txt_catogery;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel error_msg;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
    }
}