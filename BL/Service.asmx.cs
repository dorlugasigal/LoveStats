using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BL
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {


        public clsDal m_dal;

        public clsDal getDal
        {
            get
            {
                if (m_dal == null)
                {
                    m_dal = new clsDal();
                }
                return m_dal;
            }
        }


        [WebMethod]
        public DataSet LoginGetAllUserDataAndStats(string username, string password)
        {
            return getDal.LoginGetAllUserDataAndStats(username, password);
        }
        [WebMethod]
        public DataSet RegisterNewUser(string UserName, string FirstName, string LastName, string PassWord, string Email, string PhoneNumber)
        {
            return getDal.RegisterNewUser(UserName, FirstName, LastName, PassWord, Email, PhoneNumber);
        }
        [WebMethod]
        public DataSet RegisterNewStats(int UserId, string GoodThing, string BadThing)
        {
            return getDal.RegisterNewStats(UserId, GoodThing, BadThing);
        }
        [WebMethod]
        public bool isStatsExistsToday(int UserId)
        {
            return getDal.isStatsExistsToday(UserId);
        }
    }
}



