namespace LogisticsClient.Receive
{
    partial class FrmReceiveMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceiveMoney));
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lstBills = new System.Windows.Forms.CheckedListBox();
            this.dpMoneyReceive = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(12, 424);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确认收款";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(392, 424);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "取消";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstBills
            // 
            this.lstBills.FormattingEnabled = true;
            this.lstBills.Location = new System.Drawing.Point(12, 12);
            this.lstBills.Name = "lstBills";
            this.lstBills.Size = new System.Drawing.Size(455, 260);
            this.lstBills.TabIndex = 3;
            // 
            // dpMoneyReceive
            // 
            this.dpMoneyReceive.Location = new System.Drawing.Point(86, 284);
            this.dpMoneyReceive.Name = "dpMoneyReceive";
            this.dpMoneyReceive.Size = new System.Drawing.Size(200, 21);
            this.dpMoneyReceive.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "收款日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "收款备注";
            // 
            // txtRemark
            // 
            this.txtRemark.AcceptsReturn = true;
            this.txtRemark.Location = new System.Drawing.Point(86, 311);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(381, 107);
            this.txtRemark.TabIndex = 7;
            // 
            // FrmReceiveMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 459);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpMoneyReceive);
            this.Controls.Add(this.lstBills);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmReceiveMoney";
            this.Text = "收款记录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.CheckedListBox lstBills;
        private System.Windows.Forms.DateTimePicker dpMoneyReceive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemark;
    }
}