using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WorkTImeKeeper
{
    public static class UserStatus
    {
        private static string userName = "";
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
    }
}
