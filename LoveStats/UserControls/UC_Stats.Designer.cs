namespace LoveStats.UserControls
{
    partial class UC_Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Stats));
            this.lblStats = new System.Windows.Forms.Label();
            this.statsCircle = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblEmptyStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.Color.Silver;
            this.lblStats.Location = new System.Drawing.Point(323, 37);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(84, 37);
            this.lblStats.TabIndex = 1;
            this.lblStats.Text = "Stats";
            // 
            // statsCircle
            // 
            this.statsCircle.animated = false;
            this.statsCircle.animationIterval = 5;
            this.statsCircle.animationSpeed = 300;
            this.statsCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.statsCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statsCircle.BackgroundImage")));
            this.statsCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.statsCircle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.statsCircle.LabelVisible = true;
            this.statsCircle.LineProgressThickness = 20;
            this.statsCircle.LineThickness = 20;
            this.statsCircle.Location = new System.Drawing.Point(186, 121);
            this.statsCircle.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.statsCircle.MaxValue = 100;
            this.statsCircle.Name = "statsCircle";
            this.statsCircle.ProgressBackColor = System.Drawing.Color.Maroon;
            this.statsCircle.ProgressColor = System.Drawing.Color.LimeGreen;
            this.statsCircle.Size = new System.Drawing.Size(359, 359);
            this.statsCircle.TabIndex = 2;
            this.statsCircle.Value = 30;
            // 
            // lblEmptyStats
            // 
            this.lblEmptyStats.AutoSize = true;
            this.lblEmptyStats.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblEmptyStats.ForeColor = System.Drawing.Color.Silver;
            this.lblEmptyStats.Location = new System.Drawing.Point(48, 268);
            this.lblEmptyStats.Name = "lblEmptyStats";
            this.lblEmptyStats.Size = new System.Drawing.Size(635, 61);
            this.lblEmptyStats.TabIndex = 3;
            this.lblEmptyStats.Text = "You have no stats record";
            this.lblEmptyStats.Visible = false;
            // 
            // UC_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lblEmptyStats);
            this.Controls.Add(this.statsCircle);
            this.Controls.Add(this.lblStats);
            this.Name = "UC_Stats";
            this.Size = new System.Drawing.Size(730, 590);
            this.Load += new System.EventHandler(this.UC_Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStats;
        private Bunifu.Framework.UI.BunifuCircleProgressbar statsCircle;
        private System.Windows.Forms.Label lblEmptyStats;
    }
}
