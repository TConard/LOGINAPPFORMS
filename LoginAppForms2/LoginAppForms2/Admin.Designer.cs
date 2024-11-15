namespace LoginAppForms2
{
    partial class Admin
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
            this.btnViewUserData = new System.Windows.Forms.Button();
            this.btnViewVendorData = new System.Windows.Forms.Button();
            this.btnViewVendorDelivery = new System.Windows.Forms.Button();
            this.btnBackLogIn = new System.Windows.Forms.Button();
            this.btnNewVendorLog = new System.Windows.Forms.Button();
            this.dgUserData = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorCredentialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorLoginDataSet = new LoginAppForms2.VendorLoginDataSet();
            this.vendorCredentialsTableAdapter = new LoginAppForms2.VendorLoginDataSetTableAdapters.VendorCredentialsTableAdapter();
            this.dgNewVendor = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCJobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCComAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newVendorsDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newVendorInfoData = new LoginAppForms2.NewVendorInfoData();
            this.vendorInfo2Data = new LoginAppForms2.VendorInfo2Data();
            this.vendorInfo2DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newVendorsDBTableAdapter = new LoginAppForms2.NewVendorInfoDataTableAdapters.NewVendorsDBTableAdapter();
            this.dgVendorDelivery = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorInfo2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInfo2TableAdapter = new LoginAppForms2.VendorInfo2DataTableAdapters.VendorInfo2TableAdapter();
            this.newVendorInfoDataSet = new LoginAppForms2.NewVendorInfoDataSet();
            this.newVendorsDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newVendorsDBTableAdapter1 = new LoginAppForms2.NewVendorInfoDataSetTableAdapters.NewVendorsDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorsDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfo2Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfo2DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendorDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfo2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorsDBBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewUserData
            // 
            this.btnViewUserData.Location = new System.Drawing.Point(135, 111);
            this.btnViewUserData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewUserData.Name = "btnViewUserData";
            this.btnViewUserData.Size = new System.Drawing.Size(232, 80);
            this.btnViewUserData.TabIndex = 0;
            this.btnViewUserData.Text = "View User Data";
            this.btnViewUserData.UseVisualStyleBackColor = true;
            this.btnViewUserData.Click += new System.EventHandler(this.btnViewUserData_Click);
            // 
            // btnViewVendorData
            // 
            this.btnViewVendorData.Location = new System.Drawing.Point(135, 340);
            this.btnViewVendorData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewVendorData.Name = "btnViewVendorData";
            this.btnViewVendorData.Size = new System.Drawing.Size(232, 80);
            this.btnViewVendorData.TabIndex = 0;
            this.btnViewVendorData.Text = "View Vendor Data";
            this.btnViewVendorData.UseVisualStyleBackColor = true;
            this.btnViewVendorData.Click += new System.EventHandler(this.btnViewVendorData_Click);
            // 
            // btnViewVendorDelivery
            // 
            this.btnViewVendorDelivery.Location = new System.Drawing.Point(135, 586);
            this.btnViewVendorDelivery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewVendorDelivery.Name = "btnViewVendorDelivery";
            this.btnViewVendorDelivery.Size = new System.Drawing.Size(232, 80);
            this.btnViewVendorDelivery.TabIndex = 0;
            this.btnViewVendorDelivery.Text = "View Vendor Delivery";
            this.btnViewVendorDelivery.UseVisualStyleBackColor = true;
            this.btnViewVendorDelivery.Click += new System.EventHandler(this.btnViewVendorDelivery_Click);
            // 
            // btnBackLogIn
            // 
            this.btnBackLogIn.Location = new System.Drawing.Point(135, 1138);
            this.btnBackLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackLogIn.Name = "btnBackLogIn";
            this.btnBackLogIn.Size = new System.Drawing.Size(232, 80);
            this.btnBackLogIn.TabIndex = 0;
            this.btnBackLogIn.Text = "Back";
            this.btnBackLogIn.UseVisualStyleBackColor = true;
            this.btnBackLogIn.Click += new System.EventHandler(this.btnBackLogIn_Click);
            // 
            // btnNewVendorLog
            // 
            this.btnNewVendorLog.Location = new System.Drawing.Point(1590, 1138);
            this.btnNewVendorLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewVendorLog.Name = "btnNewVendorLog";
            this.btnNewVendorLog.Size = new System.Drawing.Size(232, 80);
            this.btnNewVendorLog.TabIndex = 0;
            this.btnNewVendorLog.Text = "New Vendor Log";
            this.btnNewVendorLog.UseVisualStyleBackColor = true;
            this.btnNewVendorLog.Click += new System.EventHandler(this.btnNewVendorLog_Click);
            // 
            // dgUserData
            // 
            this.dgUserData.AllowUserToOrderColumns = true;
            this.dgUserData.AutoGenerateColumns = false;
            this.dgUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dgUserData.DataSource = this.vendorCredentialsBindingSource;
            this.dgUserData.Location = new System.Drawing.Point(494, 118);
            this.dgUserData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgUserData.Name = "dgUserData";
            this.dgUserData.RowHeadersWidth = 62;
            this.dgUserData.Size = new System.Drawing.Size(1328, 952);
            this.dgUserData.TabIndex = 1;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorCredentialsBindingSource
            // 
            this.vendorCredentialsBindingSource.DataMember = "VendorCredentials";
            this.vendorCredentialsBindingSource.DataSource = this.vendorLoginDataSet;
            // 
            // vendorLoginDataSet
            // 
            this.vendorLoginDataSet.DataSetName = "VendorLoginDataSet";
            this.vendorLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorCredentialsTableAdapter
            // 
            this.vendorCredentialsTableAdapter.ClearBeforeFill = true;
            // 
            // dgNewVendor
            // 
            this.dgNewVendor.AllowUserToOrderColumns = true;
            this.dgNewVendor.AutoGenerateColumns = false;
            this.dgNewVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNewVendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.pOCNameDataGridViewTextBoxColumn,
            this.pOCJobTitleDataGridViewTextBoxColumn,
            this.pOCEmailDataGridViewTextBoxColumn,
            this.pOCPhoneDataGridViewTextBoxColumn,
            this.pOCCompanyDataGridViewTextBoxColumn,
            this.pOCComAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.dgNewVendor.DataSource = this.newVendorsDBBindingSource;
            this.dgNewVendor.Location = new System.Drawing.Point(494, 118);
            this.dgNewVendor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgNewVendor.Name = "dgNewVendor";
            this.dgNewVendor.RowHeadersWidth = 62;
            this.dgNewVendor.Size = new System.Drawing.Size(1329, 952);
            this.dgNewVendor.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCNameDataGridViewTextBoxColumn
            // 
            this.pOCNameDataGridViewTextBoxColumn.DataPropertyName = "POC_Name";
            this.pOCNameDataGridViewTextBoxColumn.HeaderText = "POC_Name";
            this.pOCNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCNameDataGridViewTextBoxColumn.Name = "pOCNameDataGridViewTextBoxColumn";
            this.pOCNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCJobTitleDataGridViewTextBoxColumn
            // 
            this.pOCJobTitleDataGridViewTextBoxColumn.DataPropertyName = "POC_JobTitle";
            this.pOCJobTitleDataGridViewTextBoxColumn.HeaderText = "POC_JobTitle";
            this.pOCJobTitleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCJobTitleDataGridViewTextBoxColumn.Name = "pOCJobTitleDataGridViewTextBoxColumn";
            this.pOCJobTitleDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCEmailDataGridViewTextBoxColumn
            // 
            this.pOCEmailDataGridViewTextBoxColumn.DataPropertyName = "POC_Email";
            this.pOCEmailDataGridViewTextBoxColumn.HeaderText = "POC_Email";
            this.pOCEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCEmailDataGridViewTextBoxColumn.Name = "pOCEmailDataGridViewTextBoxColumn";
            this.pOCEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCPhoneDataGridViewTextBoxColumn
            // 
            this.pOCPhoneDataGridViewTextBoxColumn.DataPropertyName = "POC_Phone";
            this.pOCPhoneDataGridViewTextBoxColumn.HeaderText = "POC_Phone";
            this.pOCPhoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCPhoneDataGridViewTextBoxColumn.Name = "pOCPhoneDataGridViewTextBoxColumn";
            this.pOCPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCCompanyDataGridViewTextBoxColumn
            // 
            this.pOCCompanyDataGridViewTextBoxColumn.DataPropertyName = "POC_Company";
            this.pOCCompanyDataGridViewTextBoxColumn.HeaderText = "POC_Company";
            this.pOCCompanyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCCompanyDataGridViewTextBoxColumn.Name = "pOCCompanyDataGridViewTextBoxColumn";
            this.pOCCompanyDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCComAddressDataGridViewTextBoxColumn
            // 
            this.pOCComAddressDataGridViewTextBoxColumn.DataPropertyName = "POC_ComAddress";
            this.pOCComAddressDataGridViewTextBoxColumn.HeaderText = "POC_ComAddress";
            this.pOCComAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCComAddressDataGridViewTextBoxColumn.Name = "pOCComAddressDataGridViewTextBoxColumn";
            this.pOCComAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 150;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.Width = 150;
            // 
            // newVendorsDBBindingSource
            // 
            this.newVendorsDBBindingSource.DataMember = "NewVendorsDB";
            this.newVendorsDBBindingSource.DataSource = this.newVendorInfoData;
            // 
            // newVendorInfoData
            // 
            this.newVendorInfoData.DataSetName = "NewVendorInfoData";
            this.newVendorInfoData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorInfo2Data
            // 
            this.vendorInfo2Data.DataSetName = "VendorInfo2Data";
            this.vendorInfo2Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorInfo2DataBindingSource
            // 
            this.vendorInfo2DataBindingSource.DataSource = this.vendorInfo2Data;
            this.vendorInfo2DataBindingSource.Position = 0;
            // 
            // newVendorsDBTableAdapter
            // 
            this.newVendorsDBTableAdapter.ClearBeforeFill = true;
            // 
            // dgVendorDelivery
            // 
            this.dgVendorDelivery.AllowUserToOrderColumns = true;
            this.dgVendorDelivery.AutoGenerateColumns = false;
            this.dgVendorDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendorDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn1});
            this.dgVendorDelivery.DataSource = this.newVendorsDBBindingSource1;
            this.dgVendorDelivery.Location = new System.Drawing.Point(494, 118);
            this.dgVendorDelivery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgVendorDelivery.Name = "dgVendorDelivery";
            this.dgVendorDelivery.RowHeadersWidth = 62;
            this.dgVendorDelivery.Size = new System.Drawing.Size(1329, 952);
            this.dgVendorDelivery.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            this.cityDataGridViewTextBoxColumn1.Width = 150;
            // 
            // vendorInfo2BindingSource
            // 
            this.vendorInfo2BindingSource.DataMember = "VendorInfo2";
            this.vendorInfo2BindingSource.DataSource = this.vendorInfo2DataBindingSource;
            // 
            // vendorInfo2TableAdapter
            // 
            this.vendorInfo2TableAdapter.ClearBeforeFill = true;
            // 
            // newVendorInfoDataSet
            // 
            this.newVendorInfoDataSet.DataSetName = "NewVendorInfoDataSet";
            this.newVendorInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newVendorsDBBindingSource1
            // 
            this.newVendorsDBBindingSource1.DataMember = "NewVendorsDB";
            this.newVendorsDBBindingSource1.DataSource = this.newVendorInfoDataSet;
            // 
            // newVendorsDBTableAdapter1
            // 
            this.newVendorsDBTableAdapter1.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2037, 1365);
            this.Controls.Add(this.dgVendorDelivery);
            this.Controls.Add(this.dgNewVendor);
            this.Controls.Add(this.dgUserData);
            this.Controls.Add(this.btnNewVendorLog);
            this.Controls.Add(this.btnBackLogIn);
            this.Controls.Add(this.btnViewVendorDelivery);
            this.Controls.Add(this.btnViewVendorData);
            this.Controls.Add(this.btnViewUserData);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorsDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfo2Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfo2DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendorDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfo2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorsDBBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewUserData;
        private System.Windows.Forms.Button btnViewVendorData;
        private System.Windows.Forms.Button btnViewVendorDelivery;
        private System.Windows.Forms.Button btnBackLogIn;
        private System.Windows.Forms.Button btnNewVendorLog;
        private System.Windows.Forms.DataGridView dgUserData;
        private VendorLoginDataSet vendorLoginDataSet;
        private System.Windows.Forms.BindingSource vendorCredentialsBindingSource;
        private VendorLoginDataSetTableAdapters.VendorCredentialsTableAdapter vendorCredentialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgNewVendor;
        private System.Windows.Forms.BindingSource vendorInfo2DataBindingSource;
        private VendorInfo2Data vendorInfo2Data;
        private NewVendorInfoData newVendorInfoData;
        private System.Windows.Forms.BindingSource newVendorsDBBindingSource;
        private NewVendorInfoDataTableAdapters.NewVendorsDBTableAdapter newVendorsDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCJobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCComAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgVendorDelivery;
        private System.Windows.Forms.BindingSource vendorInfo2BindingSource;
        private VendorInfo2DataTableAdapters.VendorInfo2TableAdapter vendorInfo2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private NewVendorInfoDataSet newVendorInfoDataSet;
        private System.Windows.Forms.BindingSource newVendorsDBBindingSource1;
        private NewVendorInfoDataSetTableAdapters.NewVendorsDBTableAdapter newVendorsDBTableAdapter1;
    }
}