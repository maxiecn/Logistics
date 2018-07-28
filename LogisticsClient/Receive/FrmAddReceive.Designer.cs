namespace LogisticsClient.Receive
{
    partial class FrmAddReceive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddReceive));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGoodsType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPriceType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPackingType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMeasure = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtReceiverAddress = new System.Windows.Forms.TextBox();
            this.txtReceiverTel = new System.Windows.Forms.TextBox();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.txtSenderTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxPayType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtChinaPrice = new System.Windows.Forms.TextBox();
            this.txtPackingPrice = new System.Windows.Forms.TextBox();
            this.txtInsurance = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.cbxTrans = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAssistant = new System.Windows.Forms.Button();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.chkHasReceiveMoney = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBillFee = new System.Windows.Forms.TextBox();
            this.pnlCIQ = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.txtTaxPrice = new System.Windows.Forms.TextBox();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.txtCIQPrice = new System.Windows.Forms.TextBox();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.chkCIQ = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.pnlCIQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "货物类型";
            // 
            // cbxGoodsType
            // 
            this.cbxGoodsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoodsType.FormattingEnabled = true;
            this.cbxGoodsType.Location = new System.Drawing.Point(102, 323);
            this.cbxGoodsType.Name = "cbxGoodsType";
            this.cbxGoodsType.Size = new System.Drawing.Size(349, 20);
            this.cbxGoodsType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "收费方式";
            // 
            // cbxPriceType
            // 
            this.cbxPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPriceType.FormattingEnabled = true;
            this.cbxPriceType.Location = new System.Drawing.Point(585, 65);
            this.cbxPriceType.Name = "cbxPriceType";
            this.cbxPriceType.Size = new System.Drawing.Size(298, 20);
            this.cbxPriceType.TabIndex = 8;
            this.cbxPriceType.SelectedIndexChanged += new System.EventHandler(this.cbxPriceType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "打包方式";
            // 
            // cbxPackingType
            // 
            this.cbxPackingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPackingType.FormattingEnabled = true;
            this.cbxPackingType.Location = new System.Drawing.Point(585, 191);
            this.cbxPackingType.Name = "cbxPackingType";
            this.cbxPackingType.Size = new System.Drawing.Size(298, 20);
            this.cbxPackingType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "发货人";
            // 
            // txtMeasure
            // 
            this.txtMeasure.Location = new System.Drawing.Point(585, 21);
            this.txtMeasure.Name = "txtMeasure";
            this.txtMeasure.Size = new System.Drawing.Size(128, 21);
            this.txtMeasure.TabIndex = 6;
            this.txtMeasure.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            this.txtMeasure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolumn_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(585, 151);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(298, 21);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.Text = "0";
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtReceiverAddress
            // 
            this.txtReceiverAddress.Location = new System.Drawing.Point(102, 195);
            this.txtReceiverAddress.Multiline = true;
            this.txtReceiverAddress.Name = "txtReceiverAddress";
            this.txtReceiverAddress.Size = new System.Drawing.Size(349, 63);
            this.txtReceiverAddress.TabIndex = 4;
            // 
            // txtReceiverTel
            // 
            this.txtReceiverTel.Location = new System.Drawing.Point(102, 151);
            this.txtReceiverTel.Name = "txtReceiverTel";
            this.txtReceiverTel.Size = new System.Drawing.Size(349, 21);
            this.txtReceiverTel.TabIndex = 3;
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Location = new System.Drawing.Point(102, 108);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(349, 21);
            this.txtReceiverName.TabIndex = 2;
            // 
            // txtSenderTel
            // 
            this.txtSenderTel.Location = new System.Drawing.Point(102, 65);
            this.txtSenderTel.Name = "txtSenderTel";
            this.txtSenderTel.Size = new System.Drawing.Size(349, 21);
            this.txtSenderTel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "收货人";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "收货人电话";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "收货人地址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "重量/体积";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "发货人电话";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(526, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "国际运费";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "件数";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(102, 405);
            this.numAmount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(349, 21);
            this.numAmount.TabIndex = 11;
            this.numAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSenderName
            // 
            this.txtSenderName.Location = new System.Drawing.Point(102, 22);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(349, 21);
            this.txtSenderName.TabIndex = 0;
            this.txtSenderName.TextChanged += new System.EventHandler(this.txtSenderName_TextChanged);
            this.txtSenderName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenderName_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 447);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "备注信息";
            // 
            // txtRemark
            // 
            this.txtRemark.AcceptsReturn = true;
            this.txtRemark.Location = new System.Drawing.Point(102, 447);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(349, 112);
            this.txtRemark.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(526, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 27;
            this.label14.Text = "付款方式";
            // 
            // cbxPayType
            // 
            this.cbxPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayType.FormattingEnabled = true;
            this.cbxPayType.Location = new System.Drawing.Point(585, 234);
            this.cbxPayType.Name = "cbxPayType";
            this.cbxPayType.Size = new System.Drawing.Size(225, 20);
            this.cbxPayType.TabIndex = 28;
            this.cbxPayType.SelectedIndexChanged += new System.EventHandler(this.cbxPayType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "国内运费";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(538, 328);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 30;
            this.label15.Text = "包装费";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(550, 370);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 31;
            this.label16.Text = "保险";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(550, 547);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 32;
            this.label17.Text = "总价";
            // 
            // txtChinaPrice
            // 
            this.txtChinaPrice.Location = new System.Drawing.Point(585, 276);
            this.txtChinaPrice.Name = "txtChinaPrice";
            this.txtChinaPrice.Size = new System.Drawing.Size(298, 21);
            this.txtChinaPrice.TabIndex = 33;
            this.txtChinaPrice.Text = "0";
            this.txtChinaPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtChinaPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSum_KeyPress);
            // 
            // txtPackingPrice
            // 
            this.txtPackingPrice.Location = new System.Drawing.Point(585, 319);
            this.txtPackingPrice.Name = "txtPackingPrice";
            this.txtPackingPrice.Size = new System.Drawing.Size(298, 21);
            this.txtPackingPrice.TabIndex = 34;
            this.txtPackingPrice.Text = "0";
            this.txtPackingPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPackingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSum_KeyPress);
            // 
            // txtInsurance
            // 
            this.txtInsurance.Location = new System.Drawing.Point(585, 361);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.Size = new System.Drawing.Size(298, 21);
            this.txtInsurance.TabIndex = 35;
            this.txtInsurance.Text = "0";
            this.txtInsurance.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSum_KeyPress);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(585, 538);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(298, 21);
            this.txtSum.TabIndex = 36;
            this.txtSum.Text = "0";
            this.txtSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSum_KeyPress);
            // 
            // cbxTrans
            // 
            this.cbxTrans.FormattingEnabled = true;
            this.cbxTrans.Location = new System.Drawing.Point(102, 281);
            this.cbxTrans.Name = "cbxTrans";
            this.cbxTrans.Size = new System.Drawing.Size(349, 20);
            this.cbxTrans.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 289);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 37;
            this.label18.Text = "转运公司";
            // 
            // btnAssistant
            // 
            this.btnAssistant.AutoSize = true;
            this.btnAssistant.Location = new System.Drawing.Point(467, 22);
            this.btnAssistant.Name = "btnAssistant";
            this.btnAssistant.Size = new System.Drawing.Size(27, 23);
            this.btnAssistant.TabIndex = 39;
            this.btnAssistant.Text = "辅";
            this.btnAssistant.UseVisualStyleBackColor = true;
            this.btnAssistant.Click += new System.EventHandler(this.btnAssistant_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(808, 565);
            this.btnClose.Name = "btnClose";
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(102, 565);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkHasReceiveMoney
            // 
            this.chkHasReceiveMoney.AutoSize = true;
            this.chkHasReceiveMoney.Location = new System.Drawing.Point(824, 237);
            this.chkHasReceiveMoney.Name = "chkHasReceiveMoney";
            this.chkHasReceiveMoney.Size = new System.Drawing.Size(60, 16);
            this.chkHasReceiveMoney.TabIndex = 42;
            this.chkHasReceiveMoney.Text = "已收款";
            this.chkHasReceiveMoney.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(720, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 44;
            this.label19.Text = "单价";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(755, 22);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(128, 21);
            this.txtUnitPrice.TabIndex = 43;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(43, 370);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 46;
            this.label20.Text = "货物名称";
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(102, 361);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(349, 21);
            this.txtGoodsName.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(538, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 48;
            this.label21.Text = "面单费";
            // 
            // txtBillFee
            // 
            this.txtBillFee.Location = new System.Drawing.Point(585, 108);
            this.txtBillFee.Name = "txtBillFee";
            this.txtBillFee.Size = new System.Drawing.Size(298, 21);
            this.txtBillFee.TabIndex = 47;
            this.txtBillFee.Text = "0";
            this.txtBillFee.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            this.txtBillFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // pnlCIQ
            // 
            this.pnlCIQ.Controls.Add(this.label26);
            this.pnlCIQ.Controls.Add(this.txtTaxPrice);
            this.pnlCIQ.Controls.Add(this.txtTaxRate);
            this.pnlCIQ.Controls.Add(this.txtCIQPrice);
            this.pnlCIQ.Controls.Add(this.txtIdCard);
            this.pnlCIQ.Controls.Add(this.label25);
            this.pnlCIQ.Controls.Add(this.label24);
            this.pnlCIQ.Controls.Add(this.label23);
            this.pnlCIQ.Controls.Add(this.label22);
            this.pnlCIQ.Enabled = false;
            this.pnlCIQ.Location = new System.Drawing.Point(585, 401);
            this.pnlCIQ.Name = "pnlCIQ";
            this.pnlCIQ.Size = new System.Drawing.Size(313, 122);
            this.pnlCIQ.TabIndex = 50;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(252, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(11, 12);
            this.label26.TabIndex = 56;
            this.label26.Text = "%";
            // 
            // txtTaskPrice
            // 
            this.txtTaxPrice.Location = new System.Drawing.Point(63, 96);
            this.txtTaxPrice.Name = "txtTaskPrice";
            this.txtTaxPrice.Size = new System.Drawing.Size(234, 21);
            this.txtTaxPrice.TabIndex = 55;
            this.txtTaxPrice.Text = "0";
            this.txtTaxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSum_KeyPress);
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(63, 67);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(183, 21);
            this.txtTaxRate.TabIndex = 54;
            this.txtTaxRate.Text = "0";
            this.txtTaxRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSum_KeyPress);
            // 
            // txtCIQPrice
            // 
            this.txtCIQPrice.Location = new System.Drawing.Point(63, 38);
            this.txtCIQPrice.Name = "txtCIQPrice";
            this.txtCIQPrice.Size = new System.Drawing.Size(234, 21);
            this.txtCIQPrice.TabIndex = 53;
            this.txtCIQPrice.Text = "0";
            this.txtCIQPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSum_KeyPress);
            // 
            // txtIdCard
            // 
            this.txtIdCard.Location = new System.Drawing.Point(63, 9);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(234, 21);
            this.txtIdCard.TabIndex = 52;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(28, 99);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 3;
            this.label25.Text = "税额";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(28, 70);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "税率";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 1;
            this.label23.Text = "认定价值";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "身份证";
            // 
            // chkCIQ
            // 
            this.chkCIQ.AutoSize = true;
            this.chkCIQ.Location = new System.Drawing.Point(519, 401);
            this.chkCIQ.Name = "chkCIQ";
            this.chkCIQ.Size = new System.Drawing.Size(60, 16);
            this.chkCIQ.TabIndex = 51;
            this.chkCIQ.Text = "海关税";
            this.chkCIQ.UseVisualStyleBackColor = true;
            this.chkCIQ.CheckedChanged += new System.EventHandler(this.chkCIQ_CheckedChanged);
            // 
            // FrmAddReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 613);
            this.Controls.Add(this.chkCIQ);
            this.Controls.Add(this.pnlCIQ);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtBillFee);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.chkHasReceiveMoney);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAssistant);
            this.Controls.Add(this.cbxTrans);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtInsurance);
            this.Controls.Add(this.txtPackingPrice);
            this.Controls.Add(this.txtChinaPrice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxPayType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSenderName);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenderTel);
            this.Controls.Add(this.txtReceiverName);
            this.Controls.Add(this.txtReceiverTel);
            this.Controls.Add(this.txtReceiverAddress);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMeasure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxPackingType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPriceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxGoodsType);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加收货信息";
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.pnlCIQ.ResumeLayout(false);
            this.pnlCIQ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGoodsType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPriceType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPackingType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMeasure;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReceiverAddress;
        private System.Windows.Forms.TextBox txtReceiverTel;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.TextBox txtSenderTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxPayType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtChinaPrice;
        private System.Windows.Forms.TextBox txtPackingPrice;
        private System.Windows.Forms.TextBox txtInsurance;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.ComboBox cbxTrans;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnAssistant;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.CheckBox chkHasReceiveMoney;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBillFee;
        private System.Windows.Forms.Panel pnlCIQ;
        private System.Windows.Forms.CheckBox chkCIQ;
        private System.Windows.Forms.TextBox txtTaxPrice;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.TextBox txtCIQPrice;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
    }
}