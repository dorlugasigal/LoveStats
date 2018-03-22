using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace DAL
{
    public class clsDal
    {
        public Database m_db;

        public Database getDb
        {
            get
            {
                if (m_db == null)
                {
                    m_db = DatabaseFactory.CreateDatabase("ConStr");
                }
                return m_db;
            }
        }


        public DataSet LoginGetAllUserDataAndStats(string username, string password)
        {
            DataSet ds = new DataSet();
            DbCommand cmd = getDb.GetStoredProcCommand("dbo.LoginGetAllUserDataAndStats");
            getDb.AddInParameter(cmd, "username", DbType.String, username);
            getDb.AddInParameter(cmd, "password", DbType.String, password);
            getDb.LoadDataSet(cmd, ds, "data");
            if (ds != null)
            {
                if (ds.Tables.Count == 1)
                {
                    ds.Tables[0].TableName = "LoginResult";
                }
                if (ds.Tables.Count == 2)
                {
                    ds.Tables[0].TableName = "User";
                    ds.Tables[1].TableName = "UserStats";
                }
            }
            return ds;
        }

        public DataSet RegisterNewUser(string Username, string FirstName, string LastName, string Password, string Email, string PhoneNumber)
        {
            DataSet ds = new DataSet();
            DbCommand cmd = getDb.GetStoredProcCommand("dbo.RegisterNewUser");
            getDb.AddInParameter(cmd, "FirstName", DbType.String, FirstName);
            getDb.AddInParameter(cmd, "LastName", DbType.String, LastName);
            getDb.AddInParameter(cmd, "UserName", DbType.String, Username);
            getDb.AddInParameter(cmd, "Password", DbType.String, Password);
            getDb.AddInParameter(cmd, "Email", DbType.String, Email);
            getDb.AddInParameter(cmd, "PhoneNumber", DbType.String, PhoneNumber);
            getDb.LoadDataSet(cmd, ds, "data");
            if (ds != null)
            {
                if (ds.Tables.Count == 1)
                {
                    ds.Tables[0].TableName = "Register Failed";
                }
            }
            return ds;
        }
        public DataSet RegisterNewStats(int UserId, string GoodThing, string BadThing)
        {
            DataSet ds = new DataSet();
            DbCommand cmd = getDb.GetStoredProcCommand("dbo.RegisterNewStats");
            getDb.AddInParameter(cmd, "BadThing", DbType.String, BadThing);
            getDb.AddInParameter(cmd, "GoodThing", DbType.String, GoodThing);
            getDb.AddInParameter(cmd, "UserId", DbType.Int32, UserId);
            getDb.LoadDataSet(cmd, ds, "data");
            if (ds != null)
            {
                if (ds.Tables.Count == 2)
                {
                    ds.Tables[0].TableName = "User";
                    ds.Tables[1].TableName = "UserStats";
                }
            }
            return ds;
        }


        public bool isStatsExistsToday(int UserId)
        {
            DataSet ds = new DataSet();
            DbCommand cmd = getDb.GetStoredProcCommand("dbo.isStatsExistsToday");

            getDb.AddInParameter(cmd, "UserId", DbType.Int32, UserId);
            getDb.LoadDataSet(cmd, ds, "data");
            if (ds != null)
            {
                if (ds.Tables.Count == 1)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
