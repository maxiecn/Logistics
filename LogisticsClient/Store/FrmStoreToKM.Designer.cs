namespace LogisticsClient.Store
{
    partial class FrmStoreToKM
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.chkGoods = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(309, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSend.Location = new System.Drawing.Point(12, 430);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // chkGoods
            // 
            this.chkGoods.FormattingEnabled = true;
            this.chkGoods.Location = new System.Drawing.Point(12, 12);
            this.chkGoods.Name = "chkGoods";
            this.chkGoods.Size = new System.Drawing.Size(372, 404);
            this.chkGoods.TabIndex = 3;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelectAll.Location = new System.Drawing.Point(120, 430);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 6;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // FrmStoreToKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 460);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.chkGoods);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmStoreToKM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发往昆明";
            this.Load += new System.EventHandler(this.FrmStoreToKM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckedListBox chkGoods;
        private System.Windows.Forms.Button btnSelectAll;


    }
}