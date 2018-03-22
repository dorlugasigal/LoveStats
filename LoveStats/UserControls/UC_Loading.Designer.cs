namespace LoveStats.UserControls
{
    partial class UC_Loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Loading));
            this.CircleProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.strech = new System.Windows.Forms.Timer(this.components);
            this.color_Transition_Timer = new System.Windows.Forms.Timer(this.components);
            this.ColorTransition = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.lblWait = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CircleProgress
            // 
            this.CircleProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CircleProgress.animated = true;
            this.CircleProgress.animationIterval = 2;
            this.CircleProgress.animationSpeed = 1;
            this.CircleProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.CircleProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleProgress.BackgroundImage")));
            this.CircleProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.CircleProgress.ForeColor = System.Drawing.Color.SeaGreen;
            this.CircleProgress.LabelVisible = false;
            this.CircleProgress.LineProgressThickness = 15;
            this.CircleProgress.LineThickness = 5;
            this.CircleProgress.Location = new System.Drawing.Point(131, 149);
            this.CircleProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.CircleProgress.MaxValue = 100;
            this.CircleProgress.Name = "CircleProgress";
            this.CircleProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.CircleProgress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.CircleProgress.Size = new System.Drawing.Size(174, 174);
            this.CircleProgress.TabIndex = 0;
            this.CircleProgress.Value = 30;
            // 
            // strech
            // 
            this.strech.Enabled = true;
            this.strech.Interval = 10;
            this.strech.Tick += new System.EventHandler(this.strech_Tick);
            // 
            // color_Transition_Timer
            // 
            this.color_Transition_Timer.Interval = 10;
            this.color_Transition_Timer.Tick += new System.EventHandler(this.color_Transition_Timer_Tick);
            // 
            // ColorTransition
            // 
            this.ColorTransition.Color1 = System.Drawing.Color.White;
            this.ColorTransition.Color2 = System.Drawing.Color.White;
            this.ColorTransition.ProgessValue = 1;
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.ForeColor = System.Drawing.Color.Silver;
            this.lblWait.Location = new System.Drawing.Point(52, 25);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(253, 58);
            this.lblWait.TabIndex = 1;
            this.lblWait.Text = "Loading...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(209, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Wait";
            // 
            // UC_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.CircleProgress);
            this.Name = "UC_Loading";
            this.Size = new System.Drawing.Size(482, 435);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar CircleProgress;
        private System.Windows.Forms.Timer strech;
        private System.Windows.Forms.Timer color_Transition_Timer;
        private Bunifu.Framework.UI.BunifuColorTransition ColorTransition;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.Label label1;
    }
}
