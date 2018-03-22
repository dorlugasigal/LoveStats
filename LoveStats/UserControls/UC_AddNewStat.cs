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
    public partial class UC_AddNewStat : UserControl
    {
        public UC_AddNewStat()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBadThing.Text = string.Empty;
            txtGoodThing.Text = string.Empty;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBadThing.Text == string.Empty && txtGoodThing.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must fill at least one field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            string good = null;
            string bad = null;
            good = txtGoodThing.Text == string.Empty ? null : txtGoodThing.Text;
            bad = txtBadThing.Text == string.Empty ? null : txtBadThing.Text;

            Observer.GetService().RegisterNewStatsAsync(Observer.GetUser().userId, good, bad);
        }

        private void UC_AddNewStat_Load(object sender, EventArgs e)
        {
            if (lblNewStats.Text == "Add New Stats")
            {
                lblNewStats.Text += " For " + DateTime.Today.ToShortDateString();
            }
        }
    }
}
