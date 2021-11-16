
namespace CSHARP_DataManipulation_x02
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tweeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataManagementx01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataManagement_x01DataSet = new CSHARP_DataManipulation_x02.DataManagement_x01DataSet();
            this.kiratTableAdapter = new CSHARP_DataManipulation_x02.DataManagement_x01DataSetTableAdapters.KiratTableAdapter();
            this.regBtn = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.TextBox();
            this.mName = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.Barangay = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.facebook = new System.Windows.Forms.TextBox();
            this.gmail = new System.Windows.Forms.TextBox();
            this.MobileNo = new System.Windows.Forms.TextBox();
            this.Region = new System.Windows.Forms.TextBox();
            this.tweeter = new System.Windows.Forms.TextBox();
            this.Insta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagementx01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagement_x01DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.barangayDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.gmailDataGridViewTextBoxColumn,
            this.facebookDataGridViewTextBoxColumn,
            this.instaDataGridViewTextBoxColumn,
            this.tweeterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kiratBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(441, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // barangayDataGridViewTextBoxColumn
            // 
            this.barangayDataGridViewTextBoxColumn.DataPropertyName = "Barangay";
            this.barangayDataGridViewTextBoxColumn.HeaderText = "Barangay";
            this.barangayDataGridViewTextBoxColumn.Name = "barangayDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // gmailDataGridViewTextBoxColumn
            // 
            this.gmailDataGridViewTextBoxColumn.DataPropertyName = "Gmail";
            this.gmailDataGridViewTextBoxColumn.HeaderText = "Gmail";
            this.gmailDataGridViewTextBoxColumn.Name = "gmailDataGridViewTextBoxColumn";
            // 
            // facebookDataGridViewTextBoxColumn
            // 
            this.facebookDataGridViewTextBoxColumn.DataPropertyName = "facebook";
            this.facebookDataGridViewTextBoxColumn.HeaderText = "facebook";
            this.facebookDataGridViewTextBoxColumn.Name = "facebookDataGridViewTextBoxColumn";
            // 
            // instaDataGridViewTextBoxColumn
            // 
            this.instaDataGridViewTextBoxColumn.DataPropertyName = "insta";
            this.instaDataGridViewTextBoxColumn.HeaderText = "insta";
            this.instaDataGridViewTextBoxColumn.Name = "instaDataGridViewTextBoxColumn";
            // 
            // tweeterDataGridViewTextBoxColumn
            // 
            this.tweeterDataGridViewTextBoxColumn.DataPropertyName = "tweeter";
            this.tweeterDataGridViewTextBoxColumn.HeaderText = "tweeter";
            this.tweeterDataGridViewTextBoxColumn.Name = "tweeterDataGridViewTextBoxColumn";
            // 
            // kiratBindingSource
            // 
            this.kiratBindingSource.DataMember = "Kirat";
            this.kiratBindingSource.DataSource = this.dataManagementx01DataSetBindingSource;
            // 
            // dataManagementx01DataSetBindingSource
            // 
            this.dataManagementx01DataSetBindingSource.DataSource = this.dataManagement_x01DataSet;
            this.dataManagementx01DataSetBindingSource.Position = 0;
            // 
            // dataManagement_x01DataSet
            // 
            this.dataManagement_x01DataSet.DataSetName = "DataManagement_x01DataSet";
            this.dataManagement_x01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kiratTableAdapter
            // 
            this.kiratTableAdapter.ClearBeforeFill = true;
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(133, 181);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(141, 36);
            this.regBtn.TabIndex = 1;
            this.regBtn.Text = "register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(19, 46);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(96, 20);
            this.fname.TabIndex = 2;
            this.fname.Text = "first name";
            // 
            // mName
            // 
            this.mName.Location = new System.Drawing.Point(121, 46);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(96, 20);
            this.mName.TabIndex = 3;
            this.mName.Text = "middle name";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(325, 46);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(96, 20);
            this.Age.TabIndex = 5;
            this.Age.Text = "age";
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(223, 46);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(96, 20);
            this.lName.TabIndex = 4;
            this.lName.Text = "last name";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(121, 98);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(96, 20);
            this.city.TabIndex = 9;
            this.city.Text = "city";
            // 
            // Barangay
            // 
            this.Barangay.Location = new System.Drawing.Point(19, 98);
            this.Barangay.Name = "Barangay";
            this.Barangay.Size = new System.Drawing.Size(96, 20);
            this.Barangay.TabIndex = 8;
            this.Barangay.Text = "Barangay";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(88, 72);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(333, 20);
            this.address.TabIndex = 7;
            this.address.Text = "address";
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(19, 72);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(63, 20);
            this.sex.TabIndex = 6;
            this.sex.Text = "sex";
            // 
            // facebook
            // 
            this.facebook.Location = new System.Drawing.Point(121, 124);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(96, 20);
            this.facebook.TabIndex = 13;
            this.facebook.Text = "facebook";
            // 
            // gmail
            // 
            this.gmail.Location = new System.Drawing.Point(19, 124);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(96, 20);
            this.gmail.TabIndex = 12;
            this.gmail.Text = "Gmail";
            // 
            // MobileNo
            // 
            this.MobileNo.Location = new System.Drawing.Point(325, 98);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(96, 20);
            this.MobileNo.TabIndex = 11;
            this.MobileNo.Text = "MobileNo";
            // 
            // Region
            // 
            this.Region.Location = new System.Drawing.Point(223, 98);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(96, 20);
            this.Region.TabIndex = 10;
            this.Region.Text = "Region";
            // 
            // tweeter
            // 
            this.tweeter.Location = new System.Drawing.Point(223, 124);
            this.tweeter.Name = "tweeter";
            this.tweeter.Size = new System.Drawing.Size(96, 20);
            this.tweeter.TabIndex = 15;
            this.tweeter.Text = "tweeter";
            // 
            // Insta
            // 
            this.Insta.Location = new System.Drawing.Point(325, 124);
            this.Insta.Name = "Insta";
            this.Insta.Size = new System.Drawing.Size(96, 20);
            this.Insta.TabIndex = 14;
            this.Insta.Text = "Insta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 451);
            this.Controls.Add(this.tweeter);
            this.Controls.Add(this.Insta);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.gmail);
            this.Controls.Add(this.MobileNo);
            this.Controls.Add(this.Region);
            this.Controls.Add(this.city);
            this.Controls.Add(this.Barangay);
            this.Controls.Add(this.address);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.mName);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagementx01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagement_x01DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataManagementx01DataSetBindingSource;
        private DataManagement_x01DataSet dataManagement_x01DataSet;
        private System.Windows.Forms.BindingSource kiratBindingSource;
        private DataManagement_x01DataSetTableAdapters.KiratTableAdapter kiratTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tweeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox mName;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox Barangay;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox facebook;
        private System.Windows.Forms.TextBox gmail;
        private System.Windows.Forms.TextBox MobileNo;
        private System.Windows.Forms.TextBox Region;
        private System.Windows.Forms.TextBox tweeter;
        private System.Windows.Forms.TextBox Insta;
    }
}

