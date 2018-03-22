namespace LoveStats.UserControls
{
    partial class UC_SignIn
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
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSignIn = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSignIn.Location = new System.Drawing.Point(183, 14);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(111, 37);
            this.lblSignIn.TabIndex = 9;
            this.lblSignIn.Text = "Sign In";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPassword.Location = new System.Drawing.Point(18, 203);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 21);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 15.2F);
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(13, 228);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(456, 39);
            this.txtPassword.TabIndex = 25;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(18, 137);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 21);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "User Name";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 15.2F);
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(13, 162);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(456, 39);
            this.txtUsername.TabIndex = 23;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(20, 271);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 21);
            this.lblResult.TabIndex = 28;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSignIn.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSignIn.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Image = null;
            this.btnSignIn.ImagePosition = 0;
            this.btnSignIn.ImageZoom = 0;
            this.btnSignIn.LabelPosition = 29;
            this.btnSignIn.LabelText = "Sign In";
            this.btnSignIn.Location = new System.Drawing.Point(14, 358);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(456, 43);
            this.btnSignIn.TabIndex = 29;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // UC_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSignIn);
            this.Name = "UC_SignIn";
            this.Size = new System.Drawing.Size(485, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblPassword;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtUsername;
        private System.Windows.Forms.Label lblResult;
        private Bunifu.Framework.UI.BunifuTileButton btnSignIn;
    }
}
