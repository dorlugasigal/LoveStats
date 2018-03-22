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
    public partial class UC_Stats : UserControl
    {
        int good, bad, value;
        public UC_Stats()
        {
            InitializeComponent();
        }

        private void UC_Stats_Load(object sender, EventArgs e)
        {
            Observer.onUpdateStatsData += Observer_onUpdateStatsData;
        }

        private void Observer_onUpdateStatsData()
        {
            good = Observer.m_user.GoodThings;
            bad = Observer.m_user.BadThings;
            if (good + bad != 0)
            {
                value = (good / (good + bad))*100;
                lblEmptyStats.Visible = false;
                statsCircle.Value = value;
                statsCircle.Visible = true;
            }
            else
            {
                lblEmptyStats.Text = "You have no stats record";
                statsCircle.Visible = false;
                lblEmptyStats.Visible = true;
            }
        }
    }
}
