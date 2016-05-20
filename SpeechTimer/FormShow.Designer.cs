namespace SpeechTimer
{
    partial class FormShow
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
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.labelStage = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelMainTitle.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.labelMainTitle.Location = new System.Drawing.Point(0, 3);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(334, 33);
            this.labelMainTitle.TabIndex = 0;
            this.labelMainTitle.Text = "主标题";
            this.labelMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStage
            // 
            this.labelStage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStage.BackColor = System.Drawing.Color.Transparent;
            this.labelStage.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.labelStage.Location = new System.Drawing.Point(1, 36);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(334, 38);
            this.labelStage.TabIndex = 1;
            this.labelStage.Text = "环节";
            this.labelStage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 50F);
            this.labelTime.Location = new System.Drawing.Point(1, 64);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(334, 102);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "-00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 163);
            this.Controls.Add(this.labelStage);
            this.Controls.Add(this.labelMainTitle);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 150);
            this.Name = "FormShow";
            this.Text = "SpeechTimer - 计时";
            this.Load += new System.EventHandler(this.FormShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Label labelStage;
        private System.Windows.Forms.Label labelTime;
    }
}