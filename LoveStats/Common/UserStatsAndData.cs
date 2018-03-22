using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveStats.Common
{
    public class UserStatsAndData
    {
        public int userId;
        public string UserName, FirstName, LastName, Email, PhoneNumber;
        public int GoodThings, BadThings;
        public UserStatsAndData(int userId, string UserName, string FirstName, string LastName, string Email, string PhoneNumber,int GoodThings, int BadThings)
        {
            this.userId = userId;
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.GoodThings = GoodThings;
            this.BadThings = BadThings;
        }

        public void SetData(int userId, string UserName, string FirstName, string LastName, string Email, string PhoneNumber, int GoodThings, int BadThings)
        {
            this.userId = userId;
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.GoodThings = GoodThings;
            this.BadThings = BadThings;
        }
    }
}
