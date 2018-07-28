namespace LogisticsClient.Manage
{
    partial class FrmAddTransCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddTransCompany));
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.txtCompCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(102, 28);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(377, 21);
            this.txtCompName.TabIndex = 0;
            // 
            // txtCompCode
            // 
            this.txtCompCode.Location = new System.Drawing.Point(102, 75);
            this.txtCompCode.Name = "txtCompCode";
            this.txtCompCode.Size = new System.Drawing.Size(377, 21);
            this.txtCompCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "快递公司名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "快递公司代码";
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(143, 173);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(296, 173);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "单号位数";
            // 
            // txtBillLength
            // 
            this.txtBillLength.Location = new System.Drawing.Point(102, 122);
            this.txtBillLength.MaxLength = 4;
            this.txtBillLength.Name = "txtBillLength";
            this.txtBillLength.Size = new System.Drawing.Size(377, 21);
            this.txtBillLength.TabIndex = 2;
            this.txtBillLength.TextChanged += new System.EventHandler(this.txtBillLength_TextChanged);
            this.txtBillLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillLength_KeyPress);
            // 
            // FrmAddTransCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBillLength);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompCode);
            this.Controls.Add(this.txtCompName);
            this.Name = "FrmAddTransCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加转运公司";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.TextBox txtCompCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillLength;
    }
}