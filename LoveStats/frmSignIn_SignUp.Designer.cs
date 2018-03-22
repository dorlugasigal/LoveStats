namespace LoveStats
{
    partial class frmSignIn_SignUp
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
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_UC_Sign = new System.Windows.Forms.Panel();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSignIn = new Bunifu.Framework.UI.BunifuTileButton();
            this.SeparatorForButton = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.FormFadeTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 20;
            this.bunifuElipse.TargetControl = this;
            // 
            // panel_UC_Sign
            // 
            this.panel_UC_Sign.Location = new System.Drawing.Point(45, 176);
            this.panel_UC_Sign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_UC_Sign.Name = "panel_UC_Sign";
            this.panel_UC_Sign.Size = new System.Drawing.Size(482, 435);
            this.panel_UC_Sign.TabIndex = 3;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnSignUp.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnSignUp.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Image = null;
            this.btnSignUp.ImagePosition = 0;
            this.btnSignUp.ImageZoom = 0;
            this.btnSignUp.LabelPosition = 40;
            this.btnSignUp.LabelText = "Sign Up";
            this.btnSignUp.Location = new System.Drawing.Point(292, 71);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(219, 74);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnSignIn.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnSignIn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Image = null;
            this.btnSignIn.ImagePosition = 0;
            this.btnSignIn.ImageZoom = 0;
            this.btnSignIn.LabelPosition = 40;
            this.btnSignIn.LabelText = "Sign In";
            this.btnSignIn.Location = new System.Drawing.Point(66, 71);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(219, 74);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // SeparatorForButton
            // 
            this.SeparatorForButton.BackColor = System.Drawing.Color.Transparent;
            this.SeparatorForButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.SeparatorForButton.LineThickness = 5;
            this.SeparatorForButton.Location = new System.Drawing.Point(66, 136);
            this.SeparatorForButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeparatorForButton.Name = "SeparatorForButton";
            this.SeparatorForButton.Size = new System.Drawing.Size(219, 14);
            this.SeparatorForButton.TabIndex = 7;
            this.SeparatorForButton.Transparency = 255;
            this.SeparatorForButton.Vertical = false;
            this.SeparatorForButton.Visible = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(120)))));
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(574, 47);
            this.panelTop.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::LoveStats.Properties.Resources.icons8_Delete_32px;
            this.btnExit.Location = new System.Drawing.Point(519, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 38);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormFadeTransition
            // 
            this.FormFadeTransition.Delay = 1;
            // 
            // frmSignIn_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(574, 640);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.SeparatorForButton);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.panel_UC_Sign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSignIn_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignIn_SignUp";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Panel panel_UC_Sign;
        private Bunifu.Framework.UI.BunifuTileButton btnSignUp;
        private Bunifu.Framework.UI.BunifuTileButton btnSignIn;
        private Bunifu.Framework.UI.BunifuSeparator SeparatorForButton;
        private System.Windows.Forms.Panel panelTop;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox btnExit;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormFadeTransition;
    }
}