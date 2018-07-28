namespace LogisticsClient.Query
{
    partial class FrmPayResult
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
            this.dgPayResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPayResult
            // 
            this.dgPayResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPayResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPayResult.Location = new System.Drawing.Point(0, 0);
            this.dgPayResult.Name = "dgPayResult";
            this.dgPayResult.RowTemplate.Height = 23;
            this.dgPayResult.Size = new System.Drawing.Size(284, 261);
            this.dgPayResult.TabIndex = 0;
            // 
            // FrmPayResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgPayResult);
            this.Name = "FrmPayResult";
            this.Text = "汇款审核";
            ((System.ComponentModel.ISupportInitialize)(this.dgPayResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPayResult;

    }
}