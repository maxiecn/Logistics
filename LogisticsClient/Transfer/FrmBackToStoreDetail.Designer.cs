namespace LogisticsClient.Transfer
{
    partial class FrmBackToStoreDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackToStoreDetail));
            this.dgDetails = new System.Windows.Forms.DataGridView();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetails
            // 
            this.dgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgDetails.Location = new System.Drawing.Point(0, 0);
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.RowTemplate.Height = 23;
            this.dgDetails.Size = new System.Drawing.Size(795, 348);
            this.dgDetails.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(531, 374);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 38);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确认导入";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(672, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmBackToStoreDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 430);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgDetails);
            this.Name = "FrmBackToStoreDetail";
            this.Text = "退回仓库";
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetails;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}