namespace LogisticsClient.Transfer
{
    partial class FrmTransfer
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
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.dgBills = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTransComp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TransBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBills)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnFilter);
            this.splitContainer1.Panel1.Controls.Add(this.txtBillID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgBills);
            this.splitContainer1.Size = new System.Drawing.Size(973, 509);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(218, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "筛选";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(12, 12);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(185, 21);
            this.txtBillID.TabIndex = 0;
            // 
            // dgBills
            // 
            this.dgBills.AllowUserToAddRows = false;
            this.dgBills.AllowUserToOrderColumns = true;
            this.dgBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.ReceiverName,
            this.ReceiverTel,
            this.ReceiverAddress,
            this.GoodsTypeName,
            this.Column12,
            this.ColTransComp,
            this.TransBill,
            this.Column27,
            this.Column28,
            this.Column29,
            this.GoodsTypeID,
            this.PackingTypeID,
            this.Column18,
            this.Column19,
            this.Column20,
            this.PriceTypeID,
            this.Column22,
            this.Column30});
            this.dgBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBills.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgBills.Location = new System.Drawing.Point(0, 0);
            this.dgBills.Name = "dgBills";
            this.dgBills.RowTemplate.Height = 23;
            this.dgBills.Size = new System.Drawing.Size(973, 452);
            this.dgBills.TabIndex = 4;
            this.dgBills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBills_CellDoubleClick);
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            this.BillID.HeaderText = "单号";
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // ReceiverName
            // 
            this.ReceiverName.DataPropertyName = "ReceiverName";
            this.ReceiverName.HeaderText = "收货人";
            this.ReceiverName.Name = "ReceiverName";
            this.ReceiverName.ReadOnly = true;
            // 
            // ReceiverTel
            // 
            this.ReceiverTel.DataPropertyName = "ReceiverTel";
            this.ReceiverTel.HeaderText = "收货人电话";
            this.ReceiverTel.Name = "ReceiverTel";
            this.ReceiverTel.ReadOnly = true;
            // 
            // ReceiverAddress
            // 
            this.ReceiverAddress.DataPropertyName = "ReceiverAddress";
            this.ReceiverAddress.HeaderText = "收货人地址";
            this.ReceiverAddress.Name = "ReceiverAddress";
            this.ReceiverAddress.ReadOnly = true;
            // 
            // GoodsTypeName
            // 
            this.GoodsTypeName.DataPropertyName = "GoodsTypeName";
            this.GoodsTypeName.HeaderText = "货物类型";
            this.GoodsTypeName.Name = "GoodsTypeName";
            this.GoodsTypeName.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "StatusName";
            this.Column12.HeaderText = "当前状态";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // ColTransComp
            // 
            this.ColTransComp.DataPropertyName = "TransCompName";
            this.ColTransComp.HeaderText = "转运公司";
            this.ColTransComp.Name = "ColTransComp";
            this.ColTransComp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTransComp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColTransComp.Visible = false;
            // 
            // TransBill
            // 
            this.TransBill.DataPropertyName = "TransBill";
            this.TransBill.HeaderText = "转运单号";
            this.TransBill.Name = "TransBill";
            // 
            // Column27
            // 
            this.Column27.DataPropertyName = "TransTime";
            this.Column27.HeaderText = "转运时间";
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            // 
            // Column28
            // 
            this.Column28.DataPropertyName = "TransRecorderID";
            this.Column28.HeaderText = "TransRecorderID";
            this.Column28.Name = "Column28";
            this.Column28.Visible = false;
            // 
            // Column29
            // 
            this.Column29.DataPropertyName = "TransRecorderName";
            this.Column29.HeaderText = "转运记录人";
            this.Column29.Name = "Column29";
            this.Column29.ReadOnly = true;
            // 
            // GoodsTypeID
            // 
            this.GoodsTypeID.DataPropertyName = "GoodsType";
            this.GoodsTypeID.HeaderText = "GoodsType";
            this.GoodsTypeID.Name = "GoodsTypeID";
            this.GoodsTypeID.Visible = false;
            // 
            // PackingTypeID
            // 
            this.PackingTypeID.DataPropertyName = "PackingType";
            this.PackingTypeID.HeaderText = "PackingType";
            this.PackingTypeID.Name = "PackingTypeID";
            this.PackingTypeID.Visible = false;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "RecorderID";
            this.Column18.HeaderText = "RecorderID";
            this.Column18.Name = "Column18";
            this.Column18.Visible = false;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "TransCompID";
            this.Column19.HeaderText = "TransCompID";
            this.Column19.Name = "Column19";
            this.Column19.Visible = false;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "StoreID";
            this.Column20.HeaderText = "StoreID";
            this.Column20.Name = "Column20";
            this.Column20.Visible = false;
            // 
            // PriceTypeID
            // 
            this.PriceTypeID.DataPropertyName = "PriceType";
            this.PriceTypeID.HeaderText = "PriceType";
            this.PriceTypeID.Name = "PriceTypeID";
            this.PriceTypeID.Visible = false;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "Status";
            this.Column22.HeaderText = "Status";
            this.Column22.Name = "Column22";
            this.Column22.Visible = false;
            // 
            // Column30
            // 
            this.Column30.DataPropertyName = "ModifyTime";
            this.Column30.HeaderText = "ModifyTime";
            this.Column30.Name = "Column30";
            this.Column30.Visible = false;
            // 
            // FrmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 509);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTransfer";
            this.Text = "FrmTransfer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColTransComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtBillID;


    }
}