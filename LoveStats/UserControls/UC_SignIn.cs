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
            lblResult.Text = string.Empty;
            if (txtUsername.Text == string.Empty || txtUsername.Text == "User Name")
            {
                lblResult.Text += Environment.NewLine;
                lblResult.Text += "Enter a User Name";
            }
            if (txtPassword.Text == string.Empty || txtPassword.Text == "Password")
            {
                lblResult.Text += Environment.NewLine;
                lblResult.Text += "Enter a Password";
            }
            if (lblResult.Text != string.Empty)
            {
                return;
            }
            Observer.ChangeToLoading();
            Observer.GetService().LoginGetAllUserDataAndStatsAsync(txtUsername.Text, txtPassword.Text);
      }
    }
}
