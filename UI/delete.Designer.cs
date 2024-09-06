
namespace AllinOne
{
    partial class delete
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna_de_userid = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna_de_delete = new Guna.UI2.WinForms.Guna2Button();
            this.adduserDataset = new AllinOne.adduserDataset();
            this.tblsigninBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblsigninTableAdapter = new AllinOne.adduserDatasetTableAdapters.tblsigninTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adduserDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsigninBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(41, 70);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(36, 15);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "User id";
            // 
            // guna_de_userid
            // 
            this.guna_de_userid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna_de_userid.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tblsigninBindingSource, "User_Id", true));
            this.guna_de_userid.DefaultText = "";
            this.guna_de_userid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna_de_userid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna_de_userid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna_de_userid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna_de_userid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna_de_userid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna_de_userid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna_de_userid.Location = new System.Drawing.Point(159, 60);
            this.guna_de_userid.Name = "guna_de_userid";
            this.guna_de_userid.PasswordChar = '\0';
            this.guna_de_userid.PlaceholderText = "";
            this.guna_de_userid.SelectedText = "";
            this.guna_de_userid.Size = new System.Drawing.Size(200, 36);
            this.guna_de_userid.TabIndex = 1;
            // 
            // guna_de_delete
            // 
            this.guna_de_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna_de_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna_de_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna_de_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna_de_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna_de_delete.ForeColor = System.Drawing.Color.White;
            this.guna_de_delete.Location = new System.Drawing.Point(424, 60);
            this.guna_de_delete.Name = "guna_de_delete";
            this.guna_de_delete.Size = new System.Drawing.Size(180, 45);
            this.guna_de_delete.TabIndex = 2;
            this.guna_de_delete.Text = "Delete";
            this.guna_de_delete.Click += new System.EventHandler(this.guna_de_delete_Click);
            // 
            // adduserDataset
            // 
            this.adduserDataset.DataSetName = "adduserDataset";
            this.adduserDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 148);
            this.Controls.Add(this.guna_de_delete);
            this.Controls.Add(this.guna_de_userid);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "delete";
            this.Text = "delete";
            this.Load += new System.EventHandler(this.delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adduserDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsigninBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna_de_userid;
        private Guna.UI2.WinForms.Guna2Button guna_de_delete;
        private adduserDataset adduserDataset;
        private System.Windows.Forms.BindingSource tblsigninBindingSource;
        private adduserDatasetTableAdapters.tblsigninTableAdapter tblsigninTableAdapter;
    }
}