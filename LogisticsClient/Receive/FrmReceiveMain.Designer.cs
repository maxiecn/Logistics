namespace LogisticsClient.Receive
{
    partial class FrmReceiveMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceiveMain));
            this.popMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退货ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNotSend = new DevExpress.XtraEditors.SimpleButton();
            this.btnHasSent = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.btnSearchAdv = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtBillID = new DevExpress.XtraEditors.TextEdit();
            this.pageCount = new System.Windows.Forms.NumericUpDown();
            this.btnNotReceiveMoney = new System.Windows.Forms.Button();
            this.btnEditPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dgBills = new System.Windows.Forms.DataGridView();
            this.ColRecordTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPackingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChinaPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsurancePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTransComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHasReceiveMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyReceiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPayType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasReceiveMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBills)).BeginInit();
            this.SuspendLayout();
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
            // btnNotSend
            // 
            this.btnNotSend.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnNotSend.Location = new System.Drawing.Point(13, 13);
            this.btnNotSend.Name = "btnNotSend";
            this.btnNotSend.Size = new System.Drawing.Size(75, 23);
            this.btnNotSend.TabIndex = 0;
            this.btnNotSend.Text = "未发货";
            this.btnNotSend.Click += new System.EventHandler(this.btnNotSend_Click);
            // 
            // btnHasSent
            // 
            this.btnHasSent.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnHasSent.Location = new System.Drawing.Point(116, 13);
            this.btnHasSent.Name = "btnHasSent";
            this.btnHasSent.Size = new System.Drawing.Size(75, 23);
            this.btnHasSent.TabIndex = 1;
            this.btnHasSent.Text = "已发货";
            this.btnHasSent.Click += new System.EventHandler(this.btnHasSent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.cbxStore);
            this.panel1.Controls.Add(this.btnSearchAdv);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtBillID);
            this.panel1.Controls.Add(this.pageCount);
            this.panel1.Controls.Add(this.btnNotReceiveMoney);
            this.panel1.Controls.Add(this.btnEditPrint);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnHasSent);
            this.panel1.Controls.Add(this.btnNotSend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 87);
            this.panel1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(478, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxStore
            // 
            this.cbxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Location = new System.Drawing.Point(577, 51);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(120, 20);
            this.cbxStore.TabIndex = 11;
            this.cbxStore.SelectedIndexChanged += new System.EventHandler(this.cbxStore_SelectedIndexChanged);
            // 
            // btnSearchAdv
            // 
            this.btnSearchAdv.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchAdv.Image")));
            this.btnSearchAdv.Location = new System.Drawing.Point(323, 50);
            this.btnSearchAdv.Name = "btnSearchAdv";
            this.btnSearchAdv.Size = new System.Drawing.Size(125, 23);
            this.btnSearchAdv.TabIndex = 10;
            this.btnSearchAdv.Text = "高级搜索";
            this.btnSearchAdv.Click += new System.EventHandler(this.btnSearchAdv_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(219, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(13, 51);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(179, 20);
            this.txtBillID.TabIndex = 8;
            // 
            // pageCount
            // 
            this.pageCount.Location = new System.Drawing.Point(577, 15);
            this.pageCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageCount.Name = "pageCount";
            this.pageCount.Size = new System.Drawing.Size(120, 21);
            this.pageCount.TabIndex = 7;
            this.pageCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageCount.ValueChanged += new System.EventHandler(this.pageCount_ValueChanged);
            // 
            // btnNotReceiveMoney
            // 
            this.btnNotReceiveMoney.Location = new System.Drawing.Point(478, 14);
            this.btnNotReceiveMoney.Name = "btnNotReceiveMoney";
            this.btnNotReceiveMoney.Size = new System.Drawing.Size(75, 23);
            this.btnNotReceiveMoney.TabIndex = 4;
            this.btnNotReceiveMoney.Text = "未收款";
            this.btnNotReceiveMoney.UseVisualStyleBackColor = true;
            this.btnNotReceiveMoney.Click += new System.EventHandler(this.btnNotReceiveMoney_Click);
            // 
            // btnEditPrint
            // 
            this.btnEditPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPrint.Image")));
            this.btnEditPrint.Location = new System.Drawing.Point(323, 13);
            this.btnEditPrint.Name = "btnEditPrint";
            this.btnEditPrint.Size = new System.Drawing.Size(125, 23);
            this.btnEditPrint.TabIndex = 3;
            this.btnEditPrint.Text = "编辑打印模板";
            this.btnEditPrint.Click += new System.EventHandler(this.btnEditPrint_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(712, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 56);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgBills
            // 
            this.dgBills.AllowUserToAddRows = false;
            this.dgBills.AllowUserToOrderColumns = true;
            this.dgBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRecordTime,
            this.BillID,
            this.ColPassword,
            this.SenderName,
            this.SenderTel,
            this.GoodsTypeName,
            this.Measure,
            this.Amount,
            this.ColPackingName,
            this.ColUnitPrice,
            this.Price,
            this.ChinaPrice,
            this.InsurancePrice,
            this.PackingPrice,
            this.ColTransComp,
            this.SumPrice,
            this.ReceiverName,
            this.ReceiverTel,
            this.ReceiverAddress,
            this.PriceTypeName,
            this.MoneyReceiver,
            this.colHasReceiveMoney,
            this.MoneyReceiverName,
            this.ColPayType,
            this.Column23,
            this.Column12,
            this.Column13,
            this.Column26,
            this.Column27,
            this.Column28,
            this.Column29,
            this.Column15,
            this.GoodsTypeID,
            this.hasReceiveMoney,
            this.PackingTypeID,
            this.Column18,
            this.ColTransID,
            this.Column20,
            this.PriceTypeID,
            this.Column22,
            this.Column30,
            this.PayTypeID});
            this.dgBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBills.Location = new System.Drawing.Point(0, 87);
            this.dgBills.Name = "dgBills";
            this.dgBills.ReadOnly = true;
            this.dgBills.RowTemplate.Height = 23;
            this.dgBills.Size = new System.Drawing.Size(1060, 614);
            this.dgBills.TabIndex = 4;
            this.dgBills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBills_CellDoubleClick);
            this.dgBills.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBills_ColumnHeaderMouseClick);
            this.dgBills.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgBills_RowPostPaint);
            this.dgBills.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgBills_RowStateChanged);
            // 
            // ColRecordTime
            // 
            this.ColRecordTime.DataPropertyName = "RecordTime";
            this.ColRecordTime.HeaderText = "收货时间";
            this.ColRecordTime.Name = "ColRecordTime";
            this.ColRecordTime.ReadOnly = true;
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            this.BillID.HeaderText = "单号";
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // ColPassword
            // 
            this.ColPassword.DataPropertyName = "Password";
            this.ColPassword.HeaderText = "密码";
            this.ColPassword.Name = "ColPassword";
            this.ColPassword.ReadOnly = true;
            // 
            // SenderName
            // 
            this.SenderName.DataPropertyName = "SenderName";
            this.SenderName.HeaderText = "发货人";
            this.SenderName.Name = "SenderName";
            this.SenderName.ReadOnly = true;
            // 
            // SenderTel
            // 
            this.SenderTel.DataPropertyName = "SenderTel";
            this.SenderTel.HeaderText = "发货人电话";
            this.SenderTel.Name = "SenderTel";
            this.SenderTel.ReadOnly = true;
            // 
            // GoodsTypeName
            // 
            this.GoodsTypeName.DataPropertyName = "GoodsTypeName";
            this.GoodsTypeName.HeaderText = "货物类型";
            this.GoodsTypeName.Name = "GoodsTypeName";
            this.GoodsTypeName.ReadOnly = true;
            // 
            // Measure
            // 
            this.Measure.DataPropertyName = "Measure";
            this.Measure.HeaderText = "重量/体积";
            this.Measure.Name = "Measure";
            this.Measure.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "件数";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // ColPackingName
            // 
            this.ColPackingName.DataPropertyName = "PackingTypeName";
            this.ColPackingName.HeaderText = "包装方式";
            this.ColPackingName.Name = "ColPackingName";
            this.ColPackingName.ReadOnly = true;
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.DataPropertyName = "UnitPrice";
            this.ColUnitPrice.HeaderText = "单价";
            this.ColUnitPrice.Name = "ColUnitPrice";
            this.ColUnitPrice.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "国际运费";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // ChinaPrice
            // 
            this.ChinaPrice.DataPropertyName = "ChinaPrice";
            this.ChinaPrice.HeaderText = "国内运费";
            this.ChinaPrice.Name = "ChinaPrice";
            this.ChinaPrice.ReadOnly = true;
            // 
            // InsurancePrice
            // 
            this.InsurancePrice.DataPropertyName = "InsurancePrice";
            this.InsurancePrice.HeaderText = "保险费";
            this.InsurancePrice.Name = "InsurancePrice";
            this.InsurancePrice.ReadOnly = true;
            // 
            // PackingPrice
            // 
            this.PackingPrice.DataPropertyName = "PackingPrice";
            this.PackingPrice.HeaderText = "包装费";
            this.PackingPrice.Name = "PackingPrice";
            this.PackingPrice.ReadOnly = true;
            // 
            // ColTransComp
            // 
            this.ColTransComp.DataPropertyName = "TransCompName";
            this.ColTransComp.HeaderText = "转运公司";
            this.ColTransComp.Name = "ColTransComp";
            this.ColTransComp.ReadOnly = true;
            this.ColTransComp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SumPrice
            // 
            this.SumPrice.DataPropertyName = "SumPrice";
            this.SumPrice.HeaderText = "总价";
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.ReadOnly = true;
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
            // PriceTypeName
            // 
            this.PriceTypeName.DataPropertyName = "PriceTypeName";
            this.PriceTypeName.HeaderText = "收款方式";
            this.PriceTypeName.Name = "PriceTypeName";
            this.PriceTypeName.ReadOnly = true;
            // 
            // MoneyReceiver
            // 
            this.MoneyReceiver.DataPropertyName = "MoneyReceiver";
            this.MoneyReceiver.HeaderText = "收款人编号";
            this.MoneyReceiver.Name = "MoneyReceiver";
            this.MoneyReceiver.ReadOnly = true;
            this.MoneyReceiver.Visible = false;
            // 
            // colHasReceiveMoney
            // 
            this.colHasReceiveMoney.DataPropertyName = "hasReceiveMoneyDisplay";
            this.colHasReceiveMoney.HeaderText = "已收款";
            this.colHasReceiveMoney.Name = "colHasReceiveMoney";
            this.colHasReceiveMoney.ReadOnly = true;
            // 
            // MoneyReceiverName
            // 
            this.MoneyReceiverName.DataPropertyName = "MoneyReceiverName";
            this.MoneyReceiverName.HeaderText = "收款人姓名";
            this.MoneyReceiverName.Name = "MoneyReceiverName";
            this.MoneyReceiverName.ReadOnly = true;
            // 
            // ColPayType
            // 
            this.ColPayType.DataPropertyName = "PayTypeName";
            this.ColPayType.HeaderText = "付款方式";
            this.ColPayType.Name = "ColPayType";
            this.ColPayType.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.DataPropertyName = "RecorderName";
            this.Column23.HeaderText = "收货记录人";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "StatusName";
            this.Column12.HeaderText = "当前状态";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "StoreName";
            this.Column13.HeaderText = "收货门店";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column26
            // 
            this.Column26.DataPropertyName = "TransBill";
            this.Column26.HeaderText = "转运单号";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
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
            this.Column28.ReadOnly = true;
            this.Column28.Visible = false;
            // 
            // Column29
            // 
            this.Column29.DataPropertyName = "TransRecorderName";
            this.Column29.HeaderText = "转运记录人";
            this.Column29.Name = "Column29";
            this.Column29.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "CustomerID";
            this.Column15.HeaderText = "CustomerID";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // GoodsTypeID
            // 
            this.GoodsTypeID.DataPropertyName = "GoodsType";
            this.GoodsTypeID.HeaderText = "GoodsType";
            this.GoodsTypeID.Name = "GoodsTypeID";
            this.GoodsTypeID.ReadOnly = true;
            this.GoodsTypeID.Visible = false;
            // 
            // hasReceiveMoney
            // 
            this.hasReceiveMoney.DataPropertyName = "hasReceiveMoney";
            this.hasReceiveMoney.HeaderText = "hasReceiveMoney";
            this.hasReceiveMoney.Name = "hasReceiveMoney";
            this.hasReceiveMoney.ReadOnly = true;
            this.hasReceiveMoney.Visible = false;
            // 
            // PackingTypeID
            // 
            this.PackingTypeID.DataPropertyName = "PackingType";
            this.PackingTypeID.HeaderText = "PackingType";
            this.PackingTypeID.Name = "PackingTypeID";
            this.PackingTypeID.ReadOnly = true;
            this.PackingTypeID.Visible = false;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "RecorderID";
            this.Column18.HeaderText = "RecorderID";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Visible = false;
            // 
            // ColTransID
            // 
            this.ColTransID.DataPropertyName = "TransCompID";
            this.ColTransID.HeaderText = "TransCompID";
            this.ColTransID.Name = "ColTransID";
            this.ColTransID.ReadOnly = true;
            this.ColTransID.Visible = false;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "StoreID";
            this.Column20.HeaderText = "StoreID";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Visible = false;
            // 
            // PriceTypeID
            // 
            this.PriceTypeID.DataPropertyName = "PriceType";
            this.PriceTypeID.HeaderText = "PriceType";
            this.PriceTypeID.Name = "PriceTypeID";
            this.PriceTypeID.ReadOnly = true;
            this.PriceTypeID.Visible = false;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "Status";
            this.Column22.HeaderText = "Status";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Visible = false;
            // 
            // Column30
            // 
            this.Column30.DataPropertyName = "ModifyTime";
            this.Column30.HeaderText = "ModifyTime";
            this.Column30.Name = "Column30";
            this.Column30.ReadOnly = true;
            this.Column30.Visible = false;
            // 
            // PayTypeID
            // 
            this.PayTypeID.DataPropertyName = "PayType";
            this.PayTypeID.HeaderText = "PayTypeID";
            this.PayTypeID.Name = "PayTypeID";
            this.PayTypeID.ReadOnly = true;
            this.PayTypeID.Visible = false;
            // 
            // FrmReceiveMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 701);
            this.Controls.Add(this.dgBills);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReceiveMain";
            this.Text = "FrmReceiveMain";
            this.popMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBillID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip popMenu;
        private System.Windows.Forms.ToolStripMenuItem 退货ToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btnNotSend;
        private DevExpress.XtraEditors.SimpleButton btnHasSent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgBills;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnEditPrint;
        private System.Windows.Forms.Button btnNotReceiveMoney;
        private System.Windows.Forms.NumericUpDown pageCount;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtBillID;
        private DevExpress.XtraEditors.SimpleButton btnSearchAdv;
        private System.Windows.Forms.ComboBox cbxStore;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRecordTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPackingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChinaPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsurancePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTransComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHasReceiveMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyReceiverName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColPayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasReceiveMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTransID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayTypeID;

    }
}