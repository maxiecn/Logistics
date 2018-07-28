namespace LogisticsClient.Receive
{
    partial class FrmCheckReceiveMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckReceiveMoney));
            this.dgReceiveMoney = new System.Windows.Forms.DataGridView();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceiveMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // dgReceiveMoney
            // 
            this.dgReceiveMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReceiveMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgReceiveMoney.Location = new System.Drawing.Point(0, 0);
            this.dgReceiveMoney.Name = "dgReceiveMoney";
            this.dgReceiveMoney.RowTemplate.Height = 23;
            this.dgReceiveMoney.Size = new System.Drawing.Size(639, 353);
            this.dgReceiveMoney.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(552, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "取消";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(422, 372);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确认收款";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "汇款总额";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(94, 372);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(11, 12);
            this.lblSum.TabIndex = 6;
            this.lblSum.Text = "0";
            // 
            // FrmCheckReceiveMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 416);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgReceiveMoney);
            this.Name = "FrmCheckReceiveMoney";
            this.Text = "汇款总览";
            ((System.ComponentModel.ISupportInitialize)(this.dgReceiveMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReceiveMoney;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSum;
    }
}