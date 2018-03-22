using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoveStats.Common;

namespace LoveStats.UserControls
{
    public partial class UC_SignIn : UserControl
    {
        public UC_SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn();
        }
        private void SignIn()
        {
            lblResult.Text = string.Empty;
            if (txtUsername.Text == string.Empty || txtUsername.Text == "User Name")
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter your User Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (txtPassword.Text == string.Empty || txtPassword.Text == "Password")
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter your Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            Observer.ChangeToLoading();
            Observer.GetService().LoginGetAllUserDataAndStatsAsync(txtUsername.Text, txtPassword.Text);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SignIn();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

    }
}
