namespace LoveStats.UserControls
{
    partial class UC_AddNewStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddNewStat));
            this.lblNewStats = new System.Windows.Forms.Label();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblBad = new System.Windows.Forms.Label();
            this.txtGoodThing = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtBadThing = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lblNewStats
            // 
            this.lblNewStats.AutoSize = true;
            this.lblNewStats.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStats.ForeColor = System.Drawing.Color.Silver;
            this.lblNewStats.Location = new System.Drawing.Point(131, 51);
            this.lblNewStats.Name = "lblNewStats";
            this.lblNewStats.Size = new System.Drawing.Size(228, 37);
            this.lblNewStats.TabIndex = 0;
            this.lblNewStats.Text = "Add New Stats";
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGood.ForeColor = System.Drawing.Color.Silver;
            this.lblGood.Location = new System.Drawing.Point(69, 112);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(152, 30);
            this.lblGood.TabIndex = 1;
            this.lblGood.Text = "Good Thing";
            // 
            // lblBad
            // 
            this.lblBad.AutoSize = true;
            this.lblBad.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBad.ForeColor = System.Drawing.Color.Silver;
            this.lblBad.Location = new System.Drawing.Point(69, 281);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(129, 30);
            this.lblBad.TabIndex = 2;
            this.lblBad.Text = "Bad Thing";
            // 
            // txtGoodThing
            // 
            this.txtGoodThing.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGoodThing.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtGoodThing.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodThing.Location = new System.Drawing.Point(74, 150);
            this.txtGoodThing.Multiline = true;
            this.txtGoodThing.Name = "txtGoodThing";
            this.txtGoodThing.Size = new System.Drawing.Size(576, 123);
            this.txtGoodThing.TabIndex = 3;
            // 
            // txtBadThing
            // 
            this.txtBadThing.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBadThing.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtBadThing.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBadThing.Location = new System.Drawing.Point(74, 319);
            this.txtBadThing.Multiline = true;
            this.txtBadThing.Name = "txtBadThing";
            this.txtBadThing.Size = new System.Drawing.Size(576, 123);
            this.txtBadThing.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnClear.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClear.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.Location = new System.Drawing.Point(138, 491);
            this.btnClear.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 59);
            this.btnClear.TabIndex = 5;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnSave.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSave.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Location = new System.Drawing.Point(420, 491);
            this.btnSave.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 59);
            this.btnSave.TabIndex = 6;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UC_AddNewStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBadThing);
            this.Controls.Add(this.txtGoodThing);
            this.Controls.Add(this.lblBad);
            this.Controls.Add(this.lblGood);
            this.Controls.Add(this.lblNewStats);
            this.Name = "UC_AddNewStat";
            this.Size = new System.Drawing.Size(730, 590);
            this.Load += new System.EventHandler(this.UC_AddNewStat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewStats;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblBad;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtGoodThing;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtBadThing;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
    }
}
