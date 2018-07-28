namespace LogisticsClient.Manage
{
    partial class FrmFunctions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFunctions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trUser = new System.Windows.Forms.TreeView();
            this.trFunctions = new System.Windows.Forms.TreeView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(31, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trUser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.trFunctions);
            this.splitContainer1.Size = new System.Drawing.Size(704, 453);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 1;
            // 
            // trUser
            // 
            this.trUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trUser.Location = new System.Drawing.Point(0, 0);
            this.trUser.Name = "trUser";
            this.trUser.Size = new System.Drawing.Size(234, 453);
            this.trUser.TabIndex = 0;
            this.trUser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trUser_AfterSelect);
            // 
            // trFunctions
            // 
            this.trFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trFunctions.Location = new System.Drawing.Point(0, 0);
            this.trFunctions.Name = "trFunctions";
            this.trFunctions.Size = new System.Drawing.Size(466, 453);
            this.trFunctions.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(123, 22);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 12);
            this.lblInfo.TabIndex = 1;
            // 
            // FrmFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 507);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFunctions";
            this.Text = "FrmFunctions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trUser;
        private System.Windows.Forms.TreeView trFunctions;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label lblInfo;

    }
}