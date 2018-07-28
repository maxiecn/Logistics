namespace LogisticsClient.Receive
{
    partial class FrmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImport));
            this.dgImport = new System.Windows.Forms.DataGridView();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImport
            // 
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgImport.Location = new System.Drawing.Point(0, 0);
            this.dgImport.Name = "dgImport";
            this.dgImport.RowTemplate.Height = 23;
            this.dgImport.Size = new System.Drawing.Size(907, 429);
            this.dgImport.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(784, 445);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(643, 445);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 38);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确认导入";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 495);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgImport);
            this.Name = "FrmImport";
            this.Text = "导入运单";
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgImport;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}