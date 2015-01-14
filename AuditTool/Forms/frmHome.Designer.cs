namespace AuditTool.Forms
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            BrightIdeasSoftware.CellStyle cellStyle1 = new BrightIdeasSoftware.CellStyle();
            BrightIdeasSoftware.CellStyle cellStyle2 = new BrightIdeasSoftware.CellStyle();
            BrightIdeasSoftware.CellStyle cellStyle3 = new BrightIdeasSoftware.CellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearRecentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudMinLevel = new System.Windows.Forms.NumericUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbMatchILevel = new System.Windows.Forms.CheckBox();
            this.tbRealm = new System.Windows.Forms.TextBox();
            this.nudMinILevel = new System.Windows.Forms.NumericUpDown();
            this.gbSearchOptions = new System.Windows.Forms.GroupBox();
            this.cbLabels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIncludeAlts = new System.Windows.Forms.CheckBox();
            this.cbIncludeAudit = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQueryType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbGuild = new System.Windows.Forms.RadioButton();
            this.rbCharacter = new System.Windows.Forms.RadioButton();
            this.btnAudit = new System.Windows.Forms.Button();
            this.folvResults = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.hyperlinkStyle1 = new BrightIdeasSoftware.HyperlinkStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslResultCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslResultsText = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinILevel)).BeginInit();
            this.gbSearchOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folvResults)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(960, 24);
            this.msMain.TabIndex = 22;
            this.msMain.Text = "menuStrip1";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.clearRecentHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // clearRecentHistoryToolStripMenuItem
            // 
            this.clearRecentHistoryToolStripMenuItem.Name = "clearRecentHistoryToolStripMenuItem";
            this.clearRecentHistoryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.clearRecentHistoryToolStripMenuItem.Text = "Clear Recent History";
            this.clearRecentHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearRecentHistoryToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // nudMinLevel
            // 
            this.nudMinLevel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMinLevel.Location = new System.Drawing.Point(171, 128);
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
            this.nudMinLevel.Size = new System.Drawing.Size(232, 20);
            this.nudMinLevel.TabIndex = 16;
            this.nudMinLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinLevel.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(171, 87);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(232, 20);
            this.tbName.TabIndex = 21;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCharacterAudit_KeyDown);
            // 
            // cbMatchILevel
            // 
            this.cbMatchILevel.AutoSize = true;
            this.cbMatchILevel.Location = new System.Drawing.Point(171, 222);
            this.cbMatchILevel.Name = "cbMatchILevel";
            this.cbMatchILevel.Size = new System.Drawing.Size(215, 17);
            this.cbMatchILevel.TabIndex = 23;
            this.cbMatchILevel.Text = "Show only results at or above this iLevel";
            this.cbMatchILevel.UseVisualStyleBackColor = true;
            // 
            // tbRealm
            // 
            this.tbRealm.Location = new System.Drawing.Point(171, 52);
            this.tbRealm.Name = "tbRealm";
            this.tbRealm.Size = new System.Drawing.Size(232, 20);
            this.tbRealm.TabIndex = 20;
            this.tbRealm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCharacterAudit_KeyDown);
            // 
            // nudMinILevel
            // 
            this.nudMinILevel.Location = new System.Drawing.Point(171, 167);
            this.nudMinILevel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinILevel.Name = "nudMinILevel";
            this.nudMinILevel.Size = new System.Drawing.Size(232, 20);
            this.nudMinILevel.TabIndex = 10;
            this.nudMinILevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinILevel.Value = new decimal(new int[] {
            520,
            0,
            0,
            0});
            // 
            // gbSearchOptions
            // 
            this.gbSearchOptions.Controls.Add(this.cbLabels);
            this.gbSearchOptions.Controls.Add(this.label1);
            this.gbSearchOptions.Controls.Add(this.cbIncludeAlts);
            this.gbSearchOptions.Controls.Add(this.cbIncludeAudit);
            this.gbSearchOptions.Controls.Add(this.label6);
            this.gbSearchOptions.Controls.Add(this.label5);
            this.gbSearchOptions.Controls.Add(this.lblQueryType);
            this.gbSearchOptions.Controls.Add(this.label3);
            this.gbSearchOptions.Controls.Add(this.label2);
            this.gbSearchOptions.Controls.Add(this.rbGuild);
            this.gbSearchOptions.Controls.Add(this.rbCharacter);
            this.gbSearchOptions.Controls.Add(this.btnAudit);
            this.gbSearchOptions.Controls.Add(this.tbRealm);
            this.gbSearchOptions.Controls.Add(this.cbMatchILevel);
            this.gbSearchOptions.Controls.Add(this.nudMinLevel);
            this.gbSearchOptions.Controls.Add(this.tbName);
            this.gbSearchOptions.Controls.Add(this.nudMinILevel);
            this.gbSearchOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchOptions.Location = new System.Drawing.Point(0, 24);
            this.gbSearchOptions.Name = "gbSearchOptions";
            this.gbSearchOptions.Size = new System.Drawing.Size(960, 330);
            this.gbSearchOptions.TabIndex = 27;
            this.gbSearchOptions.TabStop = false;
            // 
            // cbLabels
            // 
            this.cbLabels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLabels.FormattingEnabled = true;
            this.cbLabels.Location = new System.Drawing.Point(171, 194);
            this.cbLabels.Name = "cbLabels";
            this.cbLabels.Size = new System.Drawing.Size(232, 21);
            this.cbLabels.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "With Label";
            // 
            // cbIncludeAlts
            // 
            this.cbIncludeAlts.AutoSize = true;
            this.cbIncludeAlts.Location = new System.Drawing.Point(171, 268);
            this.cbIncludeAlts.Name = "cbIncludeAlts";
            this.cbIncludeAlts.Size = new System.Drawing.Size(80, 17);
            this.cbIncludeAlts.TabIndex = 33;
            this.cbIncludeAlts.Text = "Include alts";
            this.cbIncludeAlts.UseVisualStyleBackColor = true;
            // 
            // cbIncludeAudit
            // 
            this.cbIncludeAudit.AutoSize = true;
            this.cbIncludeAudit.Checked = true;
            this.cbIncludeAudit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncludeAudit.Location = new System.Drawing.Point(171, 245);
            this.cbIncludeAudit.Name = "cbIncludeAudit";
            this.cbIncludeAudit.Size = new System.Drawing.Size(241, 17);
            this.cbIncludeAudit.TabIndex = 32;
            this.cbIncludeAudit.Text = "Include character audit results (affects speed)";
            this.cbIncludeAudit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Minimum iLevel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Minimum Level";
            // 
            // lblQueryType
            // 
            this.lblQueryType.AutoSize = true;
            this.lblQueryType.Location = new System.Drawing.Point(43, 90);
            this.lblQueryType.Name = "lblQueryType";
            this.lblQueryType.Size = new System.Drawing.Size(64, 13);
            this.lblQueryType.TabIndex = 28;
            this.lblQueryType.Text = "Character(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Realm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Audit";
            // 
            // rbGuild
            // 
            this.rbGuild.AutoSize = true;
            this.rbGuild.Location = new System.Drawing.Point(259, 25);
            this.rbGuild.Name = "rbGuild";
            this.rbGuild.Size = new System.Drawing.Size(49, 17);
            this.rbGuild.TabIndex = 23;
            this.rbGuild.Text = "Guild";
            this.rbGuild.UseVisualStyleBackColor = true;
            this.rbGuild.CheckedChanged += new System.EventHandler(this.rbGuild_CheckedChanged);
            // 
            // rbCharacter
            // 
            this.rbCharacter.AutoSize = true;
            this.rbCharacter.Checked = true;
            this.rbCharacter.Location = new System.Drawing.Point(171, 25);
            this.rbCharacter.Name = "rbCharacter";
            this.rbCharacter.Size = new System.Drawing.Size(82, 17);
            this.rbCharacter.TabIndex = 22;
            this.rbCharacter.TabStop = true;
            this.rbCharacter.Text = "Character(s)";
            this.rbCharacter.UseVisualStyleBackColor = true;
            this.rbCharacter.CheckedChanged += new System.EventHandler(this.rbCharacter_CheckedChanged);
            // 
            // btnAudit
            // 
            this.btnAudit.Location = new System.Drawing.Point(171, 293);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(232, 30);
            this.btnAudit.TabIndex = 0;
            this.btnAudit.Text = "Audit";
            this.btnAudit.UseVisualStyleBackColor = true;
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // folvResults
            // 
            this.folvResults.AllColumns.Add(this.olvColumn1);
            this.folvResults.AllColumns.Add(this.olvColumn2);
            this.folvResults.AllColumns.Add(this.olvColumn3);
            this.folvResults.AllColumns.Add(this.olvColumn4);
            this.folvResults.AllColumns.Add(this.olvColumn6);
            this.folvResults.AllColumns.Add(this.olvColumn5);
            this.folvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn6,
            this.olvColumn5});
            this.folvResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.folvResults.FullRowSelect = true;
            this.folvResults.GridLines = true;
            this.folvResults.HeaderUsesThemes = false;
            this.folvResults.HyperlinkStyle = this.hyperlinkStyle1;
            this.folvResults.Location = new System.Drawing.Point(0, 360);
            this.folvResults.MultiSelect = false;
            this.folvResults.Name = "folvResults";
            this.folvResults.OwnerDraw = true;
            this.folvResults.ShowGroups = false;
            this.folvResults.Size = new System.Drawing.Size(960, 225);
            this.folvResults.TabIndex = 33;
            this.folvResults.TintSortColumn = true;
            this.folvResults.UseAlternatingBackColors = true;
            this.folvResults.UseCellFormatEvents = true;
            this.folvResults.UseCompatibleStateImageBehavior = false;
            this.folvResults.UseHyperlinks = true;
            this.folvResults.View = System.Windows.Forms.View.Details;
            this.folvResults.VirtualMode = true;
            this.folvResults.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.folvResults_CellRightClick);
            this.folvResults.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.folvResults_FormatCell);
            this.folvResults.IsHyperlink += new System.EventHandler<BrightIdeasSoftware.IsHyperlinkEventArgs>(this.folvResults_IsHyperlink);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "CharacterName";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.Hyperlink = true;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Name";
            this.olvColumn1.Width = 200;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Level";
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Text = "Level";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn2.Width = 80;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.Text = "iLevel";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn3.Width = 100;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "";
            this.olvColumn4.CellPadding = null;
            this.olvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn4.IsEditable = false;
            this.olvColumn4.Text = "Equipped iLevel";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn4.Width = 100;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "";
            this.olvColumn6.CellPadding = null;
            this.olvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn6.Text = "Class";
            this.olvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn6.Width = 80;
            // 
            // olvColumn5
            // 
            this.olvColumn5.CellPadding = null;
            this.olvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn5.IsEditable = false;
            this.olvColumn5.Text = "Audit Result";
            this.olvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn5.Width = 100;
            // 
            // hyperlinkStyle1
            // 
            cellStyle1.Font = null;
            cellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.hyperlinkStyle1.Normal = cellStyle1;
            cellStyle2.Font = null;
            cellStyle2.FontStyle = System.Drawing.FontStyle.Underline;
            this.hyperlinkStyle1.Over = cellStyle2;
            this.hyperlinkStyle1.OverCursor = System.Windows.Forms.Cursors.Hand;
            cellStyle3.Font = null;
            cellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.hyperlinkStyle1.Visited = cellStyle3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.tsslResultCount,
            this.tsslResultsText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Step = 1;
            this.toolStripProgressBar1.Visible = false;
            // 
            // tsslResultCount
            // 
            this.tsslResultCount.Name = "tsslResultCount";
            this.tsslResultCount.Size = new System.Drawing.Size(850, 17);
            this.tsslResultCount.Spring = true;
            this.tsslResultCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsslResultCount.Visible = false;
            // 
            // tsslResultsText
            // 
            this.tsslResultsText.Name = "tsslResultsText";
            this.tsslResultsText.Size = new System.Drawing.Size(95, 17);
            this.tsslResultsText.Text = "Result(s) Returned";
            this.tsslResultsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsslResultsText.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHistoryToolStripMenuItem,
            this.markAsAltToolStripMenuItem,
            this.toolStripComboBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 95);
            // 
            // viewHistoryToolStripMenuItem
            // 
            this.viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            this.viewHistoryToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.viewHistoryToolStripMenuItem.Text = "View History";
            this.viewHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewHistoryToolStripMenuItem_Click);
            // 
            // markAsAltToolStripMenuItem
            // 
            this.markAsAltToolStripMenuItem.Name = "markAsAltToolStripMenuItem";
            this.markAsAltToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.markAsAltToolStripMenuItem.Text = "Mark As Alt";
            this.markAsAltToolStripMenuItem.Click += new System.EventHandler(this.markAsAltToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "No Label"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 21);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 610);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.folvResults);
            this.Controls.Add(this.gbSearchOptions);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "frmHome";
            this.Text = "AuditCraft";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinILevel)).EndInit();
            this.gbSearchOptions.ResumeLayout(false);
            this.gbSearchOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folvResults)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudMinLevel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox cbMatchILevel;
        private System.Windows.Forms.TextBox tbRealm;
        private System.Windows.Forms.NumericUpDown nudMinILevel;
        private System.Windows.Forms.GroupBox gbSearchOptions;
        private System.Windows.Forms.Button btnAudit;
        private System.Windows.Forms.RadioButton rbCharacter;
        private System.Windows.Forms.RadioButton rbGuild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQueryType;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearRecentHistoryToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbIncludeAudit;
        private BrightIdeasSoftware.FastObjectListView folvResults;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.HyperlinkStyle hyperlinkStyle1;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel tsslResultCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslResultsText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAsAltToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbIncludeAlts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLabels;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}