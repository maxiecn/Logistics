namespace LogisticsClient.Transfer
{
    partial class FrmImportTrans
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
            this.lstImport = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.chkClear = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstImport
            // 
            this.lstImport.FormattingEnabled = true;
            this.lstImport.ItemHeight = 12;
            this.lstImport.Location = new System.Drawing.Point(12, 12);
            this.lstImport.Name = "lstImport";
            this.lstImport.Size = new System.Drawing.Size(690, 568);
            this.lstImport.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(627, 592);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 592);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // chkClear
            // 
            this.chkClear.AutoSize = true;
            this.chkClear.Location = new System.Drawing.Point(308, 596);
            this.chkClear.Name = "chkClear";
            this.chkClear.Size = new System.Drawing.Size(96, 16);
            this.chkClear.TabIndex = 3;
            this.chkClear.Text = "清空转运信息";
            this.chkClear.UseVisualStyleBackColor = true;
            this.chkClear.Visible = false;
            // 
            // FrmImportTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 627);
            this.Controls.Add(this.chkClear);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstImport);
            this.Name = "FrmImportTrans";
            this.Text = "导入转运单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstImport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.CheckBox chkClear;
    }
}