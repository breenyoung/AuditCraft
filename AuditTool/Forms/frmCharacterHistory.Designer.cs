namespace AuditTool.Forms
{
    partial class frmCharacterHistory
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
            this.fdlvHistory = new BrightIdeasSoftware.FastDataListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblRealm = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fdlvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // fdlvHistory
            // 
            this.fdlvHistory.AllColumns.Add(this.olvColumn1);
            this.fdlvHistory.AllColumns.Add(this.olvColumn2);
            this.fdlvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.fdlvHistory.DataSource = null;
            this.fdlvHistory.Location = new System.Drawing.Point(12, 66);
            this.fdlvHistory.Name = "fdlvHistory";
            this.fdlvHistory.ShowGroups = false;
            this.fdlvHistory.Size = new System.Drawing.Size(268, 175);
            this.fdlvHistory.TabIndex = 0;
            this.fdlvHistory.UseCompatibleStateImageBehavior = false;
            this.fdlvHistory.View = System.Windows.Forms.View.Details;
            this.fdlvHistory.VirtualMode = true;
            // 
            // olvColumn1
            // 
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Date Scanned";
            this.olvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn1.Width = 138;
            // 
            // olvColumn2
            // 
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn2.Text = "iLevel";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn2.Width = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // lblRealm
            // 
            this.lblRealm.AutoSize = true;
            this.lblRealm.Location = new System.Drawing.Point(80, 38);
            this.lblRealm.Name = "lblRealm";
            this.lblRealm.Size = new System.Drawing.Size(32, 13);
            this.lblRealm.TabIndex = 2;
            this.lblRealm.Text = "realm";
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(80, 13);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(54, 13);
            this.lblCharName.TabIndex = 3;
            this.lblCharName.Text = "charname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Realm";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(268, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCharacterHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 280);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCharName);
            this.Controls.Add(this.lblRealm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fdlvHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCharacterHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Character History";
            this.VisibleChanged += new System.EventHandler(this.frmCharacterHistory_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.fdlvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.FastDataListView fdlvHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRealm;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
    }
}