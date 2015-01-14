namespace AuditTool.Controls
{
    partial class GuildMemberRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.llName = new System.Windows.Forms.LinkLabel();
            this.lblAverageILevel = new System.Windows.Forms.Label();
            this.lblAverageILevelEquipped = new System.Windows.Forms.Label();
            this.pbClass = new System.Windows.Forms.PictureBox();
            this.pbAuditResult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuditResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(3, 3);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(59, 50);
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // llName
            // 
            this.llName.AutoSize = true;
            this.llName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llName.Location = new System.Drawing.Point(90, 18);
            this.llName.Name = "llName";
            this.llName.Size = new System.Drawing.Size(80, 20);
            this.llName.TabIndex = 1;
            this.llName.TabStop = true;
            this.llName.Text = "linkLabel1";
            this.llName.Click += new System.EventHandler(this.llName_Click);
            // 
            // lblAverageILevel
            // 
            this.lblAverageILevel.AutoSize = true;
            this.lblAverageILevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageILevel.Location = new System.Drawing.Point(295, 23);
            this.lblAverageILevel.Name = "lblAverageILevel";
            this.lblAverageILevel.Size = new System.Drawing.Size(102, 13);
            this.lblAverageILevel.TabIndex = 2;
            this.lblAverageILevel.Text = "lblAverageILevel";
            // 
            // lblAverageILevelEquipped
            // 
            this.lblAverageILevelEquipped.AutoSize = true;
            this.lblAverageILevelEquipped.Location = new System.Drawing.Point(403, 23);
            this.lblAverageILevelEquipped.Name = "lblAverageILevelEquipped";
            this.lblAverageILevelEquipped.Size = new System.Drawing.Size(74, 13);
            this.lblAverageILevelEquipped.TabIndex = 3;
            this.lblAverageILevelEquipped.Text = "({0} equipped)";
            // 
            // pbClass
            // 
            this.pbClass.Location = new System.Drawing.Point(268, 20);
            this.pbClass.Name = "pbClass";
            this.pbClass.Size = new System.Drawing.Size(18, 18);
            this.pbClass.TabIndex = 4;
            this.pbClass.TabStop = false;
            // 
            // pbAuditResult
            // 
            this.pbAuditResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbAuditResult.Location = new System.Drawing.Point(542, 0);
            this.pbAuditResult.Name = "pbAuditResult";
            this.pbAuditResult.Size = new System.Drawing.Size(60, 58);
            this.pbAuditResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAuditResult.TabIndex = 5;
            this.pbAuditResult.TabStop = false;
            this.pbAuditResult.Visible = false;
            // 
            // GuildMemberRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbAuditResult);
            this.Controls.Add(this.pbClass);
            this.Controls.Add(this.lblAverageILevelEquipped);
            this.Controls.Add(this.lblAverageILevel);
            this.Controls.Add(this.llName);
            this.Controls.Add(this.pbAvatar);
            this.Name = "GuildMemberRow";
            this.Size = new System.Drawing.Size(602, 58);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuditResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.LinkLabel llName;
        private System.Windows.Forms.Label lblAverageILevel;
        private System.Windows.Forms.Label lblAverageILevelEquipped;
        private System.Windows.Forms.PictureBox pbClass;
        private System.Windows.Forms.PictureBox pbAuditResult;
    }
}
