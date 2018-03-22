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
using System.Text.RegularExpressions;

namespace LoveStats.UserControls
{
    public partial class UC_SignUp : UserControl
    {
        public UC_SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!ManageTextInputs())
            {
                return;
            }
            Observer.GetService().RegisterNewUserAsync(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPhoneNumber.Text, txtEmail.Text, txtPassword.Text);
        }
        private bool ManageTextInputs()
        {
            if (txtFirstName.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this,"Fill in your first name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtLastName.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this,  "Fill in your last name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtUserName.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this,  "Fill in a Username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string error=string.Empty;
            if (!ValidatePassword(txtPassword.Text,out error))
            {
                MetroFramework.MetroMessageBox.Show(this, error, "Fill in a valid Password.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");//email regular expression
            if (!reg.IsMatch(txtEmail.Text)|| txtEmail.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Fill a valid Email, e.g: example@example.com", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (!ValidatePhoneNumber(txtPhoneNumber.Text,out error))
            {
                MetroFramework.MetroMessageBox.Show(this, error, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidatePhoneNumber(string phone, out string ErrorMessage)
        {
            var input = phone;
            ErrorMessage = string.Empty;
            var has10Chars = new Regex(@".{10}");
            var hasNumber = new Regex(@"[0-9]+");
            if (!has10Chars.IsMatch(input))
            {
                ErrorMessage = "Phone Number should length 10 numbers, e.g: 0521234567";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Phone number contain only numbers.";
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                ErrorMessage="Password should not be empty";
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one lower case letter";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one upper case letter";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password length should be greater than 8 characters";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one special case characters";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
