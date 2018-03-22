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
    public partial class UC_Loading : UserControl
    {
        List<Color> m_colors;
        int m_cur_color;
        public UC_Loading()
        {
            InitializeComponent();
            m_cur_color = 0;
            m_colors = new List<Color>();
            m_colors.Add(Color.FromArgb(0, 150, 136));
            m_colors.Add(Color.FromArgb(0, 188, 212));
            m_colors.Add(Color.FromArgb(63, 81, 181));
            m_colors.Add(Color.FromArgb(156, 39, 176));

            CircleProgress.ProgressColor = m_colors[m_cur_color];
            Observer.onStopLoadingTimers += Observer_onStopLoadingTimers;
        }

        private void Observer_onStopLoadingTimers()
        {
            strech.Stop();
            color_Transition_Timer.Stop();
        }

        int dir = 1;
        private void strech_Tick(object sender, EventArgs e)
        {
            if (CircleProgress.Value == 80)
            {
                dir = -1; //reduce
                CircleProgress.animationIterval = 7;
                SwitchColor();
            }
            else if (CircleProgress.Value == 20)
            {
                dir = +1; //expand
                CircleProgress.animationIterval = 2;
                SwitchColor();
            }
            CircleProgress.Value += dir;
        }
        private void SwitchColor()
        {
            ColorTransition.Color1 = m_colors[m_cur_color];
            if (m_cur_color < m_colors.Count - 1)
            {
                m_cur_color++;
            }
            else
            {
                m_cur_color = 0;
            }
            ColorTransition.Color2 = m_colors[m_cur_color];
            color_Transition_Timer.Start();
        }

        private void color_Transition_Timer_Tick(object sender, EventArgs e)
        {
            if (ColorTransition.ProgessValue < 100)
            {
                ColorTransition.ProgessValue++;
                CircleProgress.ProgressColor = ColorTransition.Value;
            }
            else
            {
                color_Transition_Timer.Stop();
                ColorTransition.Color1 = ColorTransition.Color2;
                ColorTransition.ProgessValue = 0;
            }
        }


    }
}
