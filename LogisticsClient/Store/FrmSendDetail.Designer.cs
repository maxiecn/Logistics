namespace LogisticsClient.Store
{
    partial class FrmSendDetail
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
            this.chkGoods = new System.Windows.Forms.CheckedListBox();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkGoods
            // 
            this.chkGoods.FormattingEnabled = true;
            this.chkGoods.Location = new System.Drawing.Point(12, 12);
            this.chkGoods.Name = "chkGoods";
            this.chkGoods.Size = new System.Drawing.Size(393, 436);
            this.chkGoods.TabIndex = 0;
            // 
            // btnStockIn
            // 
            this.btnStockIn.Location = new System.Drawing.Point(12, 454);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(75, 23);
            this.btnStockIn.TabIndex = 1;
            this.btnStockIn.Text = "收货入库";
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(330, 454);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // FrmSendDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 504);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnStockIn);
            this.Controls.Add(this.chkGoods);
            this.Name = "FrmSendDetail";
            this.Text = "发货明细";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkGoods;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnSelectAll;
    }
}