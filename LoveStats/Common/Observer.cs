using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoveStats.Common
{
    public static class Observer
    {
        //public static Delegate DlWriteError(string error, string stack);
        public static WsBL.Service m_bl;
        public static WsBL.Service getBl
        {
            get
            {
                if (m_bl == null)
                {
                    m_bl = new WsBL.Service();
                    m_bl.Credentials = System.Net.CredentialCache.DefaultCredentials;
                }
                return m_bl;
            }
        }
        public static UserStatsAndData m_user;




        //switch user control
        public delegate void dlChangeToLoading();
        public static event dlChangeToLoading onChangeToLoading;
        public static void ChangeToLoading()
        {
            if (onChangeToLoading != null)
            {
                onChangeToLoading();
            }
            else return;
        }



        //update stats data in stats page
        public delegate void dlUpdateStatsData();
        public static event dlUpdateStatsData onUpdateStatsData;
        public static void UpdateStatsData()
        {
            if (onUpdateStatsData != null)
            {
                onUpdateStatsData();
            }
            else return;
        }



        //turn off timers
        public delegate void dlStopLoadingTimers();
        public static event dlStopLoadingTimers onStopLoadingTimers;
        public static void StopLoadingTimers()
        {
            if (onStopLoadingTimers != null)
            {
                onStopLoadingTimers();
            }
            else return;
        }



        public static UserStatsAndData SetUserData(int userId, string UserName, string FirstName, string LastName, string Email, string PhoneNumber,int GoodThings,int BadThings)
        {
            m_user = new UserStatsAndData(userId, UserName, FirstName, LastName, Email, PhoneNumber,GoodThings,BadThings);
            return m_user;
        }


        public static UserStatsAndData GetUser()
        {
            return m_user;
        }

        public static WsBL.Service GetService()
        {
            return getBl;
        }

    }
}
