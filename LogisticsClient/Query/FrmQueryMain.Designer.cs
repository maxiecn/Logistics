namespace LogisticsClient.Query
{
    partial class FrmQueryMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQueryMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAdv = new System.Windows.Forms.Panel();
            this.txtPriceEnd = new System.Windows.Forms.TextBox();
            this.txtPriceStart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMeasureEnd = new System.Windows.Forms.TextBox();
            this.txtMeasureStart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxGoodsType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.dgBills = new System.Windows.Forms.DataGridView();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCardFront = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCardBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasReceiveMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPayType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChinaPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsurancePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveOper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTransComp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TransBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransOper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlAdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBills)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pnlAdv);
            this.panel1.Controls.Add(this.btnAdvance);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBillID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 134);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlAdv
            // 
            this.pnlAdv.Controls.Add(this.txtPriceEnd);
            this.pnlAdv.Controls.Add(this.txtPriceStart);
            this.pnlAdv.Controls.Add(this.label8);
            this.pnlAdv.Controls.Add(this.txtMeasureEnd);
            this.pnlAdv.Controls.Add(this.txtMeasureStart);
            this.pnlAdv.Controls.Add(this.label9);
            this.pnlAdv.Controls.Add(this.label7);
            this.pnlAdv.Controls.Add(this.label6);
            this.pnlAdv.Controls.Add(this.dtEnd);
            this.pnlAdv.Controls.Add(this.label5);
            this.pnlAdv.Controls.Add(this.label4);
            this.pnlAdv.Controls.Add(this.dtStart);
            this.pnlAdv.Controls.Add(this.txtCustomerName);
            this.pnlAdv.Controls.Add(this.label3);
            this.pnlAdv.Controls.Add(this.cbxGoodsType);
            this.pnlAdv.Controls.Add(this.label2);
            this.pnlAdv.Location = new System.Drawing.Point(3, 37);
            this.pnlAdv.Name = "pnlAdv";
            this.pnlAdv.Size = new System.Drawing.Size(1041, 94);
            this.pnlAdv.TabIndex = 4;
            this.pnlAdv.Visible = false;
            // 
            // txtPriceEnd
            // 
            this.txtPriceEnd.Location = new System.Drawing.Point(219, 46);
            this.txtPriceEnd.Name = "txtPriceEnd";
            this.txtPriceEnd.Size = new System.Drawing.Size(121, 21);
            this.txtPriceEnd.TabIndex = 16;
            this.txtPriceEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNum);
            // 
            // txtPriceStart
            // 
            this.txtPriceStart.Location = new System.Drawing.Point(69, 46);
            this.txtPriceStart.Name = "txtPriceStart";
            this.txtPriceStart.Size = new System.Drawing.Size(121, 21);
            this.txtPriceStart.TabIndex = 15;
            this.txtPriceStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNum);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "至";
            // 
            // txtMeasureEnd
            // 
            this.txtMeasureEnd.Location = new System.Drawing.Point(606, 46);
            this.txtMeasureEnd.Name = "txtMeasureEnd";
            this.txtMeasureEnd.Size = new System.Drawing.Size(121, 21);
            this.txtMeasureEnd.TabIndex = 13;
            this.txtMeasureEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNum);
            // 
            // txtMeasureStart
            // 
            this.txtMeasureStart.Location = new System.Drawing.Point(456, 46);
            this.txtMeasureStart.Name = "txtMeasureStart";
            this.txtMeasureStart.Size = new System.Drawing.Size(121, 21);
            this.txtMeasureStart.TabIndex = 12;
            this.txtMeasureStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNum);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "运费";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "至";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "重量/体积";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(460, 9);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(121, 21);
            this.dtEnd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "至";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "发货日期";
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(310, 9);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(121, 21);
            this.dtStart.TabIndex = 4;
            this.dtStart.Value = new System.DateTime(2015, 6, 30, 0, 0, 0, 0);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(663, 9);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(137, 21);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "客户名称";
            // 
            // cbxGoodsType
            // 
            this.cbxGoodsType.FormattingEnabled = true;
            this.cbxGoodsType.Location = new System.Drawing.Point(69, 9);
            this.cbxGoodsType.Name = "cbxGoodsType";
            this.cbxGoodsType.Size = new System.Drawing.Size(137, 20);
            this.cbxGoodsType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "货物种类";
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(379, 8);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(75, 23);
            this.btnAdvance.TabIndex = 3;
            this.btnAdvance.Text = "高级搜索";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(279, 8);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "货物单号";
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(72, 10);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(201, 21);
            this.txtBillID.TabIndex = 0;
            // 
            // dgBills
            // 
            this.dgBills.AllowUserToAddRows = false;
            this.dgBills.AllowUserToOrderColumns = true;
            this.dgBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column24,
            this.IdCardFront,
            this.IdCardBack,
            this.hasReceiveMoney,
            this.BillID,
            this.ColPassword,
            this.SenderName,
            this.SenderTel,
            this.ReceiverName,
            this.ReceiverTel,
            this.ReceiverAddress,
            this.GoodsTypeName,
            this.Amount,
            this.Measure,
            this.PriceTypeName,
            this.ColPayType,
            this.Price,
            this.ChinaPrice,
            this.PackingPrice,
            this.InsurancePrice,
            this.SumPrice,
            this.ReceiveOper,
            this.PackingType,
            this.Column12,
            this.Column13,
            this.ColTransComp,
            this.TransBillID,
            this.TransTime,
            this.Column28,
            this.TransOper,
            this.Column15,
            this.GoodsTypeID,
            this.PackingTypeID,
            this.Column18,
            this.ColTransID,
            this.Column20,
            this.PriceTypeID,
            this.Column22,
            this.Column30,
            this.PayTypeID});
            this.dgBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBills.Location = new System.Drawing.Point(0, 134);
            this.dgBills.Name = "dgBills";
            this.dgBills.ReadOnly = true;
            this.dgBills.RowTemplate.Height = 23;
            this.dgBills.Size = new System.Drawing.Size(1044, 528);
            this.dgBills.TabIndex = 3;
            // 
            // Column24
            // 
            this.Column24.DataPropertyName = "RecordTime";
            this.Column24.HeaderText = "收货时间";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            // 
            // IdCardFront
            // 
            this.IdCardFront.DataPropertyName = "IdCardFront";
            this.IdCardFront.HeaderText = "IdCardFront";
            this.IdCardFront.Name = "IdCardFront";
            this.IdCardFront.ReadOnly = true;
            this.IdCardFront.Visible = false;
            // 
            // IdCardBack
            // 
            this.IdCardBack.DataPropertyName = "IdCardBack";
            this.IdCardBack.HeaderText = "IdCardBack";
            this.IdCardBack.Name = "IdCardBack";
            this.IdCardBack.ReadOnly = true;
            this.IdCardBack.Visible = false;
            // 
            // hasReceiveMoney
            // 
            this.hasReceiveMoney.DataPropertyName = "hasReceiveMoney";
            this.hasReceiveMoney.HeaderText = "hasReceiveMoney";
            this.hasReceiveMoney.Name = "hasReceiveMoney";
            this.hasReceiveMoney.ReadOnly = true;
            this.hasReceiveMoney.Visible = false;
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
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "件数";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Measure
            // 
            this.Measure.DataPropertyName = "Measure";
            this.Measure.HeaderText = "重量/体积";
            this.Measure.Name = "Measure";
            this.Measure.ReadOnly = true;
            // 
            // PriceTypeName
            // 
            this.PriceTypeName.DataPropertyName = "PriceTypeName";
            this.PriceTypeName.HeaderText = "收款方式";
            this.PriceTypeName.Name = "PriceTypeName";
            this.PriceTypeName.ReadOnly = true;
            // 
            // ColPayType
            // 
            this.ColPayType.DataPropertyName = "PayTypeName";
            this.ColPayType.HeaderText = "付款方式";
            this.ColPayType.Name = "ColPayType";
            this.ColPayType.ReadOnly = true;
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
            // PackingPrice
            // 
            this.PackingPrice.DataPropertyName = "PackingPrice";
            this.PackingPrice.HeaderText = "包装费";
            this.PackingPrice.Name = "PackingPrice";
            this.PackingPrice.ReadOnly = true;
            // 
            // InsurancePrice
            // 
            this.InsurancePrice.DataPropertyName = "InsurancePrice";
            this.InsurancePrice.HeaderText = "保险费";
            this.InsurancePrice.Name = "InsurancePrice";
            this.InsurancePrice.ReadOnly = true;
            // 
            // SumPrice
            // 
            this.SumPrice.DataPropertyName = "SumPrice";
            this.SumPrice.HeaderText = "总价";
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.ReadOnly = true;
            // 
            // ReceiveOper
            // 
            this.ReceiveOper.DataPropertyName = "RecorderName";
            this.ReceiveOper.HeaderText = "收货记录人";
            this.ReceiveOper.Name = "ReceiveOper";
            this.ReceiveOper.ReadOnly = true;
            // 
            // PackingType
            // 
            this.PackingType.DataPropertyName = "PackingTypeName";
            this.PackingType.HeaderText = "包装方式";
            this.PackingType.Name = "PackingType";
            this.PackingType.ReadOnly = true;
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
            // ColTransComp
            // 
            this.ColTransComp.DataPropertyName = "TransCompName";
            this.ColTransComp.HeaderText = "转运公司";
            this.ColTransComp.Name = "ColTransComp";
            this.ColTransComp.ReadOnly = true;
            this.ColTransComp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTransComp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TransBillID
            // 
            this.TransBillID.DataPropertyName = "TransBill";
            this.TransBillID.HeaderText = "转运单号";
            this.TransBillID.Name = "TransBillID";
            this.TransBillID.ReadOnly = true;
            // 
            // TransTime
            // 
            this.TransTime.DataPropertyName = "TransTime";
            this.TransTime.HeaderText = "转运时间";
            this.TransTime.Name = "TransTime";
            this.TransTime.ReadOnly = true;
            // 
            // Column28
            // 
            this.Column28.DataPropertyName = "TransRecorderID";
            this.Column28.HeaderText = "TransRecorderID";
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            this.Column28.Visible = false;
            // 
            // TransOper
            // 
            this.TransOper.DataPropertyName = "TransRecorderName";
            this.TransOper.HeaderText = "转运记录人";
            this.TransOper.Name = "TransOper";
            this.TransOper.ReadOnly = true;
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
            // FrmQueryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 662);
            this.Controls.Add(this.dgBills);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQueryMain";
            this.Text = "QueryMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAdv.ResumeLayout(false);
            this.pnlAdv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.DataGridView dgBills;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Panel pnlAdv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxGoodsType;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPriceEnd;
        private System.Windows.Forms.TextBox txtPriceStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMeasureEnd;
        private System.Windows.Forms.TextBox txtMeasureStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCardFront;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCardBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasReceiveMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTypeName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColPayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChinaPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsurancePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveOper;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColTransComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransBillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransOper;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeID;
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