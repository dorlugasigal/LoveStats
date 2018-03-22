using LoveStats.Common;
using LoveStats.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveStats
{
    public partial class frmSignIn_SignUp : Form
    {
        UC_SignIn m_ucSignIn;
        UC_SignIn GetUCSignIn
        {
            get
            {
                if (m_ucSignIn == null)
                {
                    m_ucSignIn = new UC_SignIn();
                }
                return m_ucSignIn;
            }
        }
        UC_Loading m_ucLoading;
        UC_Loading GetUCLoading
        {
            get
            {
                if (m_ucLoading == null)
                {
                    m_ucLoading = new UC_Loading();
                }
                return m_ucLoading;
            }
        }
        UC_SignUp m_ucSignUp;
        UC_SignUp GetUCSignUp
        {
            get
            {
                if (m_ucSignUp == null)
                {
                    m_ucSignUp = new UC_SignUp();
                }
                return m_ucSignUp;
            }
        }
        UC_Welcome m_ucWelcome;
        UC_Welcome GetUCWelcome
        {
            get
            {
                if (m_ucWelcome == null)
                {
                    m_ucWelcome = new UC_Welcome();
                }
                return m_ucWelcome;
            }
        }
        frmMain m_frmMain;
        frmMain GetFrmMain
        {
            get
            {
                if (m_frmMain == null)
                {
                    m_frmMain = new frmMain();
                }
                return m_frmMain;
            }

        }

        public frmSignIn_SignUp()
        {
            InitializeComponent();
            Observer_Register();
            panel_UC_Sign.Controls.Add(GetUCWelcome);
            panel_UC_Sign.Controls.Add(GetUCSignUp);
            panel_UC_Sign.Controls.Add(GetUCSignIn);
            panel_UC_Sign.Controls.Add(GetUCLoading);

            //GetUCLoading.BringToFront();
            //GetUCSignIn.BringToFront();
            btnSignIn.Focus();
        }
        private void Observer_Register()
        {
            Observer.GetService().LoginGetAllUserDataAndStatsCompleted += FrmSignIn_SignUp_LoginGetAllUserDataAndStatsCompleted;
            Observer.onChangeToLoading += Observer_onChangeToLoading;
        }

        private void Observer_onChangeToLoading()
        {
            GetUCLoading.BringToFront();
        }

        private void FrmSignIn_SignUp_LoginGetAllUserDataAndStatsCompleted(object sender, WsBL.LoginGetAllUserDataAndStatsCompletedEventArgs e)
        {
            this.Visible = false;
            panel_UC_Sign.Controls.Remove(GetUCLoading);
            //loading screen


            DataSet ds = e.Result;
            Observer.SetUserData(int.Parse(ds.Tables["User"].Rows[0]["UserId"].ToString()),
                                ds.Tables["User"].Rows[0]["UserName"].ToString(),
                                ds.Tables["User"].Rows[0]["FirstName"].ToString(),
                                ds.Tables["User"].Rows[0]["LastName"].ToString(),
                                ds.Tables["User"].Rows[0]["Email"].ToString(),
                                ds.Tables["User"].Rows[0]["PhoneNumber"].ToString(),
                                int.Parse(ds.Tables["UserStats"].Rows[0]["GoodThings"].ToString()),
                                 int.Parse(ds.Tables["UserStats"].Rows[0]["BadThings"].ToString())
                                );
            GetFrmMain.ShowDialog();
            if (GetFrmMain.DialogResult == DialogResult.Yes)
            {
                Close();
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SeparatorForButton.Left = btnSignUp.Left;
            SeparatorForButton.Width = btnSignUp.Width;
            if (!panel_UC_Sign.Controls.Contains(GetUCSignUp))
            {
                panel_UC_Sign.Controls.Add(GetUCSignUp);
                //GetUCSignUp.Dock = DockStyle.Fill;
            }
            GetUCSignUp.BringToFront();
            btnSignIn.color = btnSignUp.color;
            btnSignUp.color = btnSignUp.colorActive;
            if (SeparatorForButton.Visible == false)
            {
                SeparatorForButton.Visible = true;
            }

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SeparatorForButton.Left = btnSignIn.Left;
            SeparatorForButton.Width = btnSignIn.Width;
            if (!panel_UC_Sign.Controls.Contains(GetUCSignIn))
            {
                panel_UC_Sign.Controls.Add(GetUCSignIn);
                //GetUCSignIn.Dock = DockStyle.Fill;
            }
            GetUCSignIn.BringToFront();
            btnSignUp.color = btnSignIn.color;
            btnSignIn.color = btnSignIn.colorActive;
            if (SeparatorForButton.Visible == false)
            {
                SeparatorForButton.Visible = true;
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
