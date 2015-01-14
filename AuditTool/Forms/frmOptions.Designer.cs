namespace AuditTool.Forms
{
    partial class frmOptions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearDb = new System.Windows.Forms.Button();
            this.nudHistoryCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.nudMinILevel = new System.Windows.Forms.NumericUpDown();
            this.nudMinLevel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPreferredAuditMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPreferredRealm = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNewLabel = new System.Windows.Forms.TextBox();
            this.btnAddLabel = new System.Windows.Forms.Button();
            this.btnDeleteLabel = new System.Windows.Forms.Button();
            this.lbLabels = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbUseCache = new System.Windows.Forms.CheckBox();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.lblDaysOld2 = new System.Windows.Forms.Label();
            this.lblDaysOld1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHistoryCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinILevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLevel)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDaysOld1);
            this.tabPage1.Controls.Add(this.lblDaysOld2);
            this.tabPage1.Controls.Add(this.nudDays);
            this.tabPage1.Controls.Add(this.cbUseCache);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnClearDb);
            this.tabPage1.Controls.Add(this.nudHistoryCount);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbRegion);
            this.tabPage1.Controls.Add(this.nudMinILevel);
            this.tabPage1.Controls.Add(this.nudMinLevel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbPreferredAuditMode);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbPreferredRealm);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Clear Character Database";
            // 
            // btnClearDb
            // 
            this.btnClearDb.Location = new System.Drawing.Point(147, 194);
            this.btnClearDb.Name = "btnClearDb";
            this.btnClearDb.Size = new System.Drawing.Size(217, 23);
            this.btnClearDb.TabIndex = 23;
            this.btnClearDb.Text = "Clear";
            this.btnClearDb.UseVisualStyleBackColor = true;
            this.btnClearDb.Click += new System.EventHandler(this.btnClearDb_Click);
            // 
            // nudHistoryCount
            // 
            this.nudHistoryCount.Location = new System.Drawing.Point(147, 167);
            this.nudHistoryCount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudHistoryCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHistoryCount.Name = "nudHistoryCount";
            this.nudHistoryCount.Size = new System.Drawing.Size(218, 20);
            this.nudHistoryCount.TabIndex = 22;
            this.nudHistoryCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHistoryCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "History Entries to Keep";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Region";
            // 
            // cbRegion
            // 
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "CN",
            "EU",
            "KR",
            "TW",
            "US"});
            this.cbRegion.Location = new System.Drawing.Point(147, 35);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(217, 21);
            this.cbRegion.TabIndex = 19;
            // 
            // nudMinILevel
            // 
            this.nudMinILevel.Location = new System.Drawing.Point(147, 141);
            this.nudMinILevel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinILevel.Name = "nudMinILevel";
            this.nudMinILevel.Size = new System.Drawing.Size(218, 20);
            this.nudMinILevel.TabIndex = 18;
            this.nudMinILevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinILevel.Value = new decimal(new int[] {
            520,
            0,
            0,
            0});
            // 
            // nudMinLevel
            // 
            this.nudMinLevel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMinLevel.Location = new System.Drawing.Point(147, 116);
            this.nudMinLevel.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMinLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinLevel.Name = "nudMinLevel";
            this.nudMinLevel.Size = new System.Drawing.Size(218, 20);
            this.nudMinLevel.TabIndex = 17;
            this.nudMinLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinLevel.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Preferred Min iLevel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preferred Min Level";
            // 
            // cbPreferredAuditMode
            // 
            this.cbPreferredAuditMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPreferredAuditMode.FormattingEnabled = true;
            this.cbPreferredAuditMode.Items.AddRange(new object[] {
            "Character",
            "Guild"});
            this.cbPreferredAuditMode.Location = new System.Drawing.Point(147, 89);
            this.cbPreferredAuditMode.Name = "cbPreferredAuditMode";
            this.cbPreferredAuditMode.Size = new System.Drawing.Size(217, 21);
            this.cbPreferredAuditMode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preferred Audit Mode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preferred Realm";
            // 
            // tbPreferredRealm
            // 
            this.tbPreferredRealm.Location = new System.Drawing.Point(148, 62);
            this.tbPreferredRealm.Name = "tbPreferredRealm";
            this.tbPreferredRealm.Size = new System.Drawing.Size(216, 20);
            this.tbPreferredRealm.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnDeleteLabel);
            this.tabPage2.Controls.Add(this.lbLabels);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Labels";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNewLabel);
            this.groupBox1.Controls.Add(this.btnAddLabel);
            this.groupBox1.Location = new System.Drawing.Point(18, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 105);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Label";
            // 
            // tbNewLabel
            // 
            this.tbNewLabel.Location = new System.Drawing.Point(17, 39);
            this.tbNewLabel.Name = "tbNewLabel";
            this.tbNewLabel.Size = new System.Drawing.Size(227, 20);
            this.tbNewLabel.TabIndex = 3;
            // 
            // btnAddLabel
            // 
            this.btnAddLabel.Location = new System.Drawing.Point(250, 39);
            this.btnAddLabel.Name = "btnAddLabel";
            this.btnAddLabel.Size = new System.Drawing.Size(75, 23);
            this.btnAddLabel.TabIndex = 1;
            this.btnAddLabel.Text = "Add";
            this.btnAddLabel.UseVisualStyleBackColor = true;
            this.btnAddLabel.Click += new System.EventHandler(this.btnAddLabel_Click);
            // 
            // btnDeleteLabel
            // 
            this.btnDeleteLabel.Location = new System.Drawing.Point(268, 23);
            this.btnDeleteLabel.Name = "btnDeleteLabel";
            this.btnDeleteLabel.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLabel.TabIndex = 2;
            this.btnDeleteLabel.Text = "Delete";
            this.btnDeleteLabel.UseVisualStyleBackColor = true;
            this.btnDeleteLabel.Click += new System.EventHandler(this.btnDeleteLabel_Click);
            // 
            // lbLabels
            // 
            this.lbLabels.FormattingEnabled = true;
            this.lbLabels.Location = new System.Drawing.Point(18, 23);
            this.lbLabels.Name = "lbLabels";
            this.lbLabels.Size = new System.Drawing.Size(244, 108);
            this.lbLabels.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(164, 379);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(326, 379);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbUseCache
            // 
            this.cbUseCache.AutoSize = true;
            this.cbUseCache.Checked = true;
            this.cbUseCache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseCache.Location = new System.Drawing.Point(20, 233);
            this.cbUseCache.Name = "cbUseCache";
            this.cbUseCache.Size = new System.Drawing.Size(220, 17);
            this.cbUseCache.TabIndex = 25;
            this.cbUseCache.Text = "Use Cached Character Values If Possible";
            this.cbUseCache.UseVisualStyleBackColor = true;
            this.cbUseCache.CheckedChanged += new System.EventHandler(this.cbUseCache_CheckedChanged);
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(103, 251);
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(57, 20);
            this.nudDays.TabIndex = 26;
            // 
            // lblDaysOld2
            // 
            this.lblDaysOld2.AutoSize = true;
            this.lblDaysOld2.Location = new System.Drawing.Point(166, 253);
            this.lblDaysOld2.Name = "lblDaysOld2";
            this.lblDaysOld2.Size = new System.Drawing.Size(29, 13);
            this.lblDaysOld2.TabIndex = 27;
            this.lblDaysOld2.Text = "days";
            // 
            // lblDaysOld1
            // 
            this.lblDaysOld1.AutoSize = true;
            this.lblDaysOld1.Location = new System.Drawing.Point(17, 253);
            this.lblDaysOld1.Name = "lblDaysOld1";
            this.lblDaysOld1.Size = new System.Drawing.Size(80, 13);
            this.lblDaysOld1.TabIndex = 28;
            this.lblDaysOld1.Text = "No Older Than:";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 414);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHistoryCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinILevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLevel)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPreferredRealm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPreferredAuditMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudMinLevel;
        private System.Windows.Forms.NumericUpDown nudMinILevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudHistoryCount;
        private System.Windows.Forms.Button btnClearDb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbLabels;
        private System.Windows.Forms.TextBox tbNewLabel;
        private System.Windows.Forms.Button btnDeleteLabel;
        private System.Windows.Forms.Button btnAddLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbUseCache;
        private System.Windows.Forms.Label lblDaysOld2;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Label lblDaysOld1;
    }
}