namespace LogisticsClient.Receive
{
    partial class FrmQueryDetail
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgBase = new System.Windows.Forms.DataGridView();
            this.dgDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgBase);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgDetail);
            this.splitContainer1.Size = new System.Drawing.Size(815, 554);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgBase
            // 
            this.dgBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBase.Location = new System.Drawing.Point(0, 0);
            this.dgBase.Name = "dgBase";
            this.dgBase.RowTemplate.Height = 23;
            this.dgBase.Size = new System.Drawing.Size(815, 271);
            this.dgBase.TabIndex = 0;
            this.dgBase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBase_CellClick);
            // 
            // dgDetail
            // 
            this.dgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetail.Location = new System.Drawing.Point(0, 0);
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.RowTemplate.Height = 23;
            this.dgDetail.Size = new System.Drawing.Size(815, 279);
            this.dgDetail.TabIndex = 0;
            // 
            // FrmQueryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 554);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmQueryDetail";
            this.Text = "运单详情";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgBase;
        private System.Windows.Forms.DataGridView dgDetail;
    }
}