namespace LogisticsClient.Receive
{
    partial class FrmSendToStore
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
            System.Windows.Forms.Button btnSelectAll;
            this.chkGoods = new System.Windows.Forms.CheckedListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            btnSelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectAll
            // 
            btnSelectAll.Location = new System.Drawing.Point(105, 430);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new System.Drawing.Size(95, 23);
            btnSelectAll.TabIndex = 3;
            btnSelectAll.Text = "全选";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // chkGoods
            // 
            this.chkGoods.FormattingEnabled = true;
            this.chkGoods.Location = new System.Drawing.Point(12, 12);
            this.chkGoods.Name = "chkGoods";
            this.chkGoods.Size = new System.Drawing.Size(372, 404);
            this.chkGoods.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 430);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(309, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmSendToStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 482);
            this.Controls.Add(btnSelectAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.chkGoods);
            this.Name = "FrmSendToStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发往仓库";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkGoods;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
    }
}