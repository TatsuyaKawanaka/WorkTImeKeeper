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
        private static string db = "TimeManager";
        private static string user = "tkawa";
        private static string pswd = "KM9nj44*+";

        //TODO メソッドの分化
        private static void hoge(string commandText)
        {
            string conStr = string.Format("host={0};database={1};user={2};password={3};", host, db, user, pswd);

            using (MySqlConnection con = new MySqlConnection(conStr))
            using (MySqlCommand command = new MySqlCommand())
            {
                try
                {
                    con.Open();
                    command.Connection = con;
                    command.CommandText = commandText;
                }
                catch
                {

                }
            }
        }

        /// <summary>
        /// アカウントの存在チェック
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static bool GetAccount(string uid, string ps)
        {
            bool ret = false;
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

                        UserStatus.SetUserInfo(user, com.ToString());
                    }
                }
                catch (Exception e)
                {
                    string mes = e.Message;
                }
            }

            return ret;
        }

        /// <summary>
        /// 開始時間の登録・更新
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static bool UpdateStartTime(DateTime dt)
        {
            var ret = false;

            return ret;
        }

        /// <summary>
        /// 終了時間の登録・更新
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static bool UpdateEndTime(DateTime dt)
        {
            var ret = false;

            return ret;
        }

        /// <summary>
        /// 休憩時間の登録・更新
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static bool UpdateRestTime(DateTime dt)
        {
            var ret = false;



            return ret;
        }

        /// <summary>
        /// 特記事項の登録・更新
        /// </summary>
        /// <param name="remIdx"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static bool UpdateRemarks(int remIdx, string comment = "")
        {
            var ret = false;

            return ret;
        }

        /// <summary>
        /// 自由詳細の登録・更新
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static bool UpdateComment(string comment)
        {
            var ret = false;

            return ret;
        }
    }
}
