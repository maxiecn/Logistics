namespace LogisticsClient.Query
{
    partial class FrmAdvCondition
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstField = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstOper = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstHasSelect = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "字段";
            // 
            // lstField
            // 
            this.lstField.FormattingEnabled = true;
            this.lstField.ItemHeight = 12;
            this.lstField.Location = new System.Drawing.Point(14, 35);
            this.lstField.Name = "lstField";
            this.lstField.Size = new System.Drawing.Size(234, 280);
            this.lstField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "比较符";
            // 
            // lstOper
            // 
            this.lstOper.FormattingEnabled = true;
            this.lstOper.ItemHeight = 12;
            this.lstOper.Items.AddRange(new object[] {
            "大于",
            "大于等于",
            "等于",
            "小于等于",
            "小于",
            "不等于",
            "包含"});
            this.lstOper.Location = new System.Drawing.Point(283, 35);
            this.lstOper.Name = "lstOper";
            this.lstOper.Size = new System.Drawing.Size(174, 136);
            this.lstOper.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "值";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(283, 207);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(174, 21);
            this.txtValue.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(283, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加条件";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(283, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除条件";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstHasSelect
            // 
            this.lstHasSelect.FormattingEnabled = true;
            this.lstHasSelect.ItemHeight = 12;
            this.lstHasSelect.Location = new System.Drawing.Point(494, 35);
            this.lstHasSelect.Name = "lstHasSelect";
            this.lstHasSelect.Size = new System.Drawing.Size(289, 280);
            this.lstHasSelect.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "已选条件";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(324, 292);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmAdvCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 343);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstHasSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstOper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstField);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdvCondition";
            this.Text = "高级筛选条件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstOper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstHasSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
    }
}