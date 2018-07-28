namespace LogisticsClient
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPwd = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnTest = new System.Windows.Forms.Button();
            this.pnlReg = new System.Windows.Forms.Panel();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtRegInfo = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.pnlReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(169, 180);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(169, 75);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(240, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(169, 125);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Properties.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(240, 20);
            this.txtPwd.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(119, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(334, 180);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "退出";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(119, 63);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit1.TabIndex = 6;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "你看不见我";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pnlReg
            // 
            this.pnlReg.Controls.Add(this.btnReg);
            this.pnlReg.Controls.Add(this.txtRegInfo);
            this.pnlReg.Location = new System.Drawing.Point(44, 211);
            this.pnlReg.Name = "pnlReg";
            this.pnlReg.Size = new System.Drawing.Size(456, 43);
            this.pnlReg.TabIndex = 8;
            this.pnlReg.Visible = false;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(379, 10);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 11;
            this.btnReg.Text = "注册";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtRegInfo
            // 
            this.txtRegInfo.Location = new System.Drawing.Point(3, 10);
            this.txtRegInfo.Name = "txtRegInfo";
            this.txtRegInfo.Size = new System.Drawing.Size(358, 22);
            this.txtRegInfo.TabIndex = 10;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(169, 13);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(205, 22);
            this.txtIP.TabIndex = 9;
            this.txtIP.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(391, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 266);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.pnlReg);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogin);
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "泰宇达物流系统 - 登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.pnlReg.ResumeLayout(false);
            this.pnlReg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtPwd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Panel pnlReg;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtRegInfo;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnSave;
    }
}