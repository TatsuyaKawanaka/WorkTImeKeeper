using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace WorkTImeKeeper
{
    public static class DatabaseManager
    {
        private static string host = "150.95.137.40";
        private static string user = "tkawa";
        private static string pswd = "KM9nj44*+";

        public static bool GetAccount(string uid, string ps)
        {
            bool ret = false;
            string db = "TimeManager";
            string conStr = string.Format("host={0};database={1};user={2};password={3};", host, db, user, pswd);

            using (MySqlConnection con = new MySqlConnection(conStr))
            using (MySqlCommand command = new MySqlCommand())
            {
                try
                {
                    con.Open();
                    command.Connection = con;
                    command.CommandText = string.Format("SELECT * FROM Auth WHERE uid='{0}' AND pswd='{1}';", uid, ps);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        ret = reader.HasRows;
                    }

                    command.CommandText = string.Format("SELECT comid, name FROM UserInfo WHERE uid = '{0}';", uid);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        var com = reader.GetInt32("comid");
                        var name = reader.GetString("name");


                    }
                }
                catch (Exception e)
                {
                    string mes = e.Message;
                }
            }

            return ret;
        }
    }
}
