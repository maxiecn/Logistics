namespace LogisticsClient.Manage
{
    partial class FrmTransCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransCompany));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dgTrans = new System.Windows.Forms.DataGridView();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 52);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(31, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgTrans
            // 
            this.dgTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTrans.Location = new System.Drawing.Point(0, 52);
            this.dgTrans.Name = "dgTrans";
            this.dgTrans.RowTemplate.Height = 23;
            this.dgTrans.Size = new System.Drawing.Size(927, 392);
            this.dgTrans.TabIndex = 2;
            // 
            // btnModify
            // 
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(136, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // FrmTransCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 444);
            this.Controls.Add(this.dgTrans);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTransCompany";
            this.Text = "FrmTransCompany";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.DataGridView dgTrans;
        private DevExpress.XtraEditors.SimpleButton btnModify;


    }
}