namespace LogisticsClient.Manage
{
    partial class FrmUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetPassword = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEnableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.storeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.storeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResetPassword);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.Image")));
            this.btnResetPassword.Location = new System.Drawing.Point(435, 16);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(104, 23);
            this.btnResetPassword.TabIndex = 6;
            this.btnResetPassword.Text = "重置密码";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(283, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "停用/启用";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(153, 16);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "修改";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(31, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.AutoGenerateColumns = false;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.loginNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.isEnableDataGridViewCheckBoxColumn,
            this.storeNameDataGridViewTextBoxColumn,
            this.storeIDDataGridViewTextBoxColumn});
            this.dgUsers.DataSource = this.userDtoBindingSource;
            this.dgUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUsers.Location = new System.Drawing.Point(0, 54);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.RowTemplate.Height = 23;
            this.dgUsers.Size = new System.Drawing.Size(971, 568);
            this.dgUsers.TabIndex = 1;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "用户编号";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "用户姓名";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginNameDataGridViewTextBoxColumn
            // 
            this.loginNameDataGridViewTextBoxColumn.DataPropertyName = "LoginName";
            this.loginNameDataGridViewTextBoxColumn.HeaderText = "登录名";
            this.loginNameDataGridViewTextBoxColumn.Name = "loginNameDataGridViewTextBoxColumn";
            this.loginNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "密码";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // isEnableDataGridViewCheckBoxColumn
            // 
            this.isEnableDataGridViewCheckBoxColumn.DataPropertyName = "isEnable";
            this.isEnableDataGridViewCheckBoxColumn.HeaderText = "可用";
            this.isEnableDataGridViewCheckBoxColumn.Name = "isEnableDataGridViewCheckBoxColumn";
            this.isEnableDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // storeNameDataGridViewTextBoxColumn
            // 
            this.storeNameDataGridViewTextBoxColumn.DataPropertyName = "StoreName";
            this.storeNameDataGridViewTextBoxColumn.HeaderText = "所属店面";
            this.storeNameDataGridViewTextBoxColumn.Name = "storeNameDataGridViewTextBoxColumn";
            this.storeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.storeNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // storeIDDataGridViewTextBoxColumn
            // 
            this.storeIDDataGridViewTextBoxColumn.DataPropertyName = "StoreID";
            this.storeIDDataGridViewTextBoxColumn.HeaderText = "店面编号";
            this.storeIDDataGridViewTextBoxColumn.Name = "storeIDDataGridViewTextBoxColumn";
            this.storeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userDtoBindingSource
            // 
            this.userDtoBindingSource.DataSource = typeof(Model.Dto.UserDto);
            // 
            // FrmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 622);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUserManager";
            this.Text = "FrmUserManager";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.DataGridView dgUsers;
        private DevExpress.XtraEditors.SimpleButton btnResetPassword;
        private System.Windows.Forms.BindingSource userDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEnableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn storeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIDDataGridViewTextBoxColumn;






    }
}