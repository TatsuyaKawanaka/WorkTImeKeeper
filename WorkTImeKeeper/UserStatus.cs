using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WorkTImeKeeper
{
    public static class UserStatus
    {
        private static string company = "";
        private static string userName = "";

        public static string Company
        {
            get
            {
                return company;
            }
        }

        public static string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public static void SetUserInfo(string user, string com)
        {
            company = com;
            userName = user;
        }
    }
}
