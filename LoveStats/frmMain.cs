using LoveStats.Common;
using LoveStats.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoveStats
{
    public partial class frmMain : Form
    {

        UC_AddNewStat m_ucAddNewStats;
        UC_AddNewStat GetUCAddNewStats
        {
            get
            {
                if (m_ucAddNewStats == null)
                {
                    m_ucAddNewStats = new UC_AddNewStat();
                }
                return m_ucAddNewStats;
            }
        }
        UC_Stats m_ucStats;
        UC_Stats GetUCStats
        {
            get
            {
                if (m_ucStats == null)
                {
                    m_ucStats = new UC_Stats();
                }
                return m_ucStats;
            }
        }

        public frmMain()
        {
            InitializeComponent();
            Observer.GetService().RegisterNewStatsCompleted += FrmMain_RegisterNewStatsCompleted;
        }

        private void FrmMain_RegisterNewStatsCompleted(object sender, WsBL.RegisterNewStatsCompletedEventArgs e)
        {
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
            panelUC.Controls.Remove(GetUCAddNewStats);
            panelUC.Controls.Add(GetUCStats);
            panelUC.Controls[0].Dock = DockStyle.Fill;
            panelUC.Controls[0].BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelButtons.Width == 50)
            {
                panelButtons.Visible = false;
                panelButtons.Width = 270;
                btnMenu.Left = 230;
                //pictureBoxSmallLogo.Visible = false;
                PanelTransition.ShowSync(panelButtons);
                LogoTransition.ShowSync(pictureBoxLogo);
            }
            else
            {
                //panelButtons.Visible = false;
                //pictureBoxSmallLogo.Visible = true;
                LogoTransition.Hide(pictureBoxLogo);
                PanelTransition.ShowSync(panelButtons);
                panelButtons.Width = 50;
                btnMenu.Left = 12;

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PanelTransition.ShowSync(panelButtons);
            LogoTransition.ShowSync(pictureBoxLogo);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNewStats_Click(object sender, EventArgs e)
        {
            if (Observer.GetService().isStatsExistsToday(Observer.GetUser().userId))
            {
                MetroFramework.MetroMessageBox.Show(this, "You've already submitted stats for today, please wait for tommorrow.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!panelUC.Controls.Contains(GetUCAddNewStats))
            {
                panelUC.Controls.Add(GetUCAddNewStats);
            }
            GetUCAddNewStats.Dock = DockStyle.Fill;
            GetUCAddNewStats.BringToFront();

        }
    }
}
