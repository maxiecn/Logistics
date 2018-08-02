namespace LogisticsClient.Receive
{
    partial class FrmTaxAssitant
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lstTax = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(329, 21);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lstTax
            // 
            this.lstTax.FormattingEnabled = true;
            this.lstTax.ItemHeight = 12;
            this.lstTax.Location = new System.Drawing.Point(12, 39);
            this.lstTax.Name = "lstTax";
            this.lstTax.Size = new System.Drawing.Size(329, 436);
            this.lstTax.TabIndex = 1;
            this.lstTax.DoubleClick += new System.EventHandler(this.lstTax_DoubleClick);
            // 
            // FrmTaxAssitant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 491);
            this.Controls.Add(this.lstTax);
            this.Controls.Add(this.txtFilter);
            this.Name = "FrmTaxAssitant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ListBox lstTax;
    }
}