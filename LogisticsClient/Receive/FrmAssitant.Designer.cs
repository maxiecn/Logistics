namespace LogisticsClient.Receive
{
    partial class FrmAssitant
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.dgHint = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgHint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(279, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "关键字";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(59, 9);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(214, 21);
            this.txtKeyword.TabIndex = 2;
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            // 
            // dgHint
            // 
            this.dgHint.AllowUserToAddRows = false;
            this.dgHint.AllowUserToDeleteRows = false;
            this.dgHint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgHint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgHint.Location = new System.Drawing.Point(0, 36);
            this.dgHint.Name = "dgHint";
            this.dgHint.ReadOnly = true;
            this.dgHint.RowTemplate.Height = 23;
            this.dgHint.Size = new System.Drawing.Size(575, 449);
            this.dgHint.TabIndex = 3;
            this.dgHint.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHint_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TransCompID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // FrmAssitant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 485);
            this.Controls.Add(this.dgHint);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Name = "FrmAssitant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "辅助录入";
            ((System.ComponentModel.ISupportInitialize)(this.dgHint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridView dgHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}