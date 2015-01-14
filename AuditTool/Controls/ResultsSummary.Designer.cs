namespace AuditTool.Controls
{
    partial class ResultsSummary
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
            this.lblResultsText = new System.Windows.Forms.Label();
            this.lblNumResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResultsText
            // 
            this.lblResultsText.AutoSize = true;
            this.lblResultsText.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblResultsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultsText.Location = new System.Drawing.Point(456, 0);
            this.lblResultsText.Name = "lblResultsText";
            this.lblResultsText.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblResultsText.Size = new System.Drawing.Size(146, 27);
            this.lblResultsText.TabIndex = 0;
            this.lblResultsText.Text = "Result(s) Returned";
            // 
            // lblNumResults
            // 
            this.lblNumResults.AutoSize = true;
            this.lblNumResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNumResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumResults.Location = new System.Drawing.Point(427, 0);
            this.lblNumResults.Name = "lblNumResults";
            this.lblNumResults.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblNumResults.Size = new System.Drawing.Size(29, 27);
            this.lblNumResults.TabIndex = 1;
            this.lblNumResults.Text = "{0}";
            // 
            // ResultsSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumResults);
            this.Controls.Add(this.lblResultsText);
            this.Name = "ResultsSummary";
            this.Size = new System.Drawing.Size(602, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultsText;
        private System.Windows.Forms.Label lblNumResults;
    }
}
