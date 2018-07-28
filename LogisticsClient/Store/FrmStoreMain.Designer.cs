namespace LogisticsClient.Store
{
    partial class FrmStoreMain
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
            this.components = new System.ComponentModel.Container();
            this.dgStore = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecorderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退货ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgStore)).BeginInit();
            this.popMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgStore
            // 
            this.dgStore.AllowUserToAddRows = false;
            this.dgStore.AllowUserToOrderColumns = true;
            this.dgStore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.RecorderID,
            this.RecorderName,
            this.CreateTime});
            this.dgStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStore.Location = new System.Drawing.Point(0, 0);
            this.dgStore.Name = "dgStore";
            this.dgStore.ReadOnly = true;
            this.dgStore.RowTemplate.Height = 23;
            this.dgStore.Size = new System.Drawing.Size(1060, 701);
            this.dgStore.TabIndex = 2;
            this.dgStore.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStore_CellDoubleClick);
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            this.BillID.HeaderText = "单号";
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // RecorderID
            // 
            this.RecorderID.DataPropertyName = "RecorderID";
            this.RecorderID.HeaderText = "发货人编号";
            this.RecorderID.Name = "RecorderID";
            this.RecorderID.ReadOnly = true;
            this.RecorderID.Visible = false;
            // 
            // RecorderName
            // 
            this.RecorderName.DataPropertyName = "RecorderName";
            this.RecorderName.HeaderText = "发货人姓名";
            this.RecorderName.Name = "RecorderName";
            this.RecorderName.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "发货时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // popMenu
            // 
            this.popMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退货ToolStripMenuItem});
            this.popMenu.Name = "popMenu";
            this.popMenu.Size = new System.Drawing.Size(101, 26);
            // 
            // 退货ToolStripMenuItem
            // 
            this.退货ToolStripMenuItem.Name = "退货ToolStripMenuItem";
            this.退货ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退货ToolStripMenuItem.Text = "退货";
            // 
            // FrmStoreMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 701);
            this.Controls.Add(this.dgStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStoreMain";
            this.Text = "FrmReceiveMain";
            ((System.ComponentModel.ISupportInitialize)(this.dgStore)).EndInit();
            this.popMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStore;
        private System.Windows.Forms.ContextMenuStrip popMenu;
        private System.Windows.Forms.ToolStripMenuItem 退货ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecorderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;

    }
}