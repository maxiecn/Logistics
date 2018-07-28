namespace LogisticsClient.Query
{
    partial class FrmCountMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCountMoney));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgMoney = new System.Windows.Forms.DataGridView();
            this.dtPickerStart = new System.Windows.Forms.DateTimePicker();
            this.dtPickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCount = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtPickerEnd);
            this.panel1.Controls.Add(this.dtPickerStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 57);
            this.panel1.TabIndex = 0;
            // 
            // dgMoney
            // 
            this.dgMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMoney.Location = new System.Drawing.Point(0, 57);
            this.dgMoney.Name = "dgMoney";
            this.dgMoney.RowTemplate.Height = 23;
            this.dgMoney.Size = new System.Drawing.Size(947, 522);
            this.dgMoney.TabIndex = 1;
            // 
            // dtPickerStart
            // 
            this.dtPickerStart.Location = new System.Drawing.Point(12, 18);
            this.dtPickerStart.Name = "dtPickerStart";
            this.dtPickerStart.Size = new System.Drawing.Size(200, 21);
            this.dtPickerStart.TabIndex = 0;
            // 
            // dtPickerEnd
            // 
            this.dtPickerEnd.Location = new System.Drawing.Point(241, 18);
            this.dtPickerEnd.Name = "dtPickerEnd";
            this.dtPickerEnd.Size = new System.Drawing.Size(200, 21);
            this.dtPickerEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "至";
            // 
            // btnCount
            // 
            this.btnCount.Image = ((System.Drawing.Image)(resources.GetObject("btnCount.Image")));
            this.btnCount.Location = new System.Drawing.Point(464, 18);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(113, 23);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "统计";
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // FrmCountMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 579);
            this.Controls.Add(this.dgMoney);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCountMoney";
            this.Text = "FrmCountMoney";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPickerEnd;
        private System.Windows.Forms.DateTimePicker dtPickerStart;
        private DevExpress.XtraEditors.SimpleButton btnCount;
    }
}