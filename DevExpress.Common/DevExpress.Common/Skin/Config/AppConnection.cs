using System;

namespace DevExpress.Common.Config
{
    public static class AppConnection
    {
        /// <summary>
        /// Get set connectionstring from configuration file.
        /// </summary>
        //public static string ConnectionString
        //{
        //    get { return Connection.GetConnection("netTiersConnectionString"); }
        //    set { Connection.SetConnection("netTiersConnectionString", value); }
        //}
        public static string ConnectionString
        {
            get
            {
              string conn = Connection.GetConnection("netTiersConnectionString");
              bool flag = false;
              try
              {
                  foreach (char c in conn)
                  {
                      if (c != '0' && c != '1')//Mã hoá cũ: bit 01
                      {
                          flag = true;
                          break;
                      }
                  }

                  if (flag)
                      conn = CipherLib.PSCExtensions.DecodeString(conn) + ";Max Pool Size=1000";
                  else
                      conn = DecodeString(conn);

                  return conn;
              }
              catch
              {
                  return conn;
              }
            }
            set
            {
                string conn = value;
                try
                {
                    conn = EncodeString(value);
                }
                catch { }
                Connection.SetConnection("netTiersConnectionString", conn);
            }
        }
        /// <summary>
        /// Init connection
        /// </summary>
        private static AppSetting Connection
        {
            get { return new AppSetting(); }
        }
        /// <summary>
        /// Ham giai ma hoa chuoi 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string DecodeString(string s)
        {
            string result = string.Empty;
            if (s == string.Empty) return string.Empty;
            for (int i = 0; i < s.Length; i += 16)
            {
                string temp = string.Empty;
                for (int j = 0; j < 16; j++)
                {
                    temp += s[i + j].ToString();
                }
                result += ConvertFromBinaryToCharacter(temp);
            }
            return result;
        }

        /// <summary>
        /// Ham ma hoa chuoi 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string EncodeString(string s)
        {
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                result += ConvertFromCharacterToBinary(s[i]);
            }
            return result;
        }

        /// <summary>
        /// Ham convert tu Binary sang Character
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        private static string ConvertFromBinaryToCharacter(string b)
        {
            double result = 0;
            for (int i = 0; i < 16; i++)
            {
                if (b[i] == '1') result += Math.Pow(2, 15 - i);
            }
            return Convert.ToChar(Convert.ToInt32(result)).ToString();
        }

        /// <summary>
        /// Ham convert tu Character sang Binary
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static string ConvertFromCharacterToBinary(char c)
        {
            string result = string.Empty;
            double value = Convert.ToDouble(Convert.ToInt32(c));
            for (double i = 15; i >= 0; i--)
            {
                if (value >= Math.Pow(2, i))
                {
                    result += "1";
                    value -= Math.Pow(2, i);
                }
                else
                    result += "0";
            }
            return result;
        }
    }
}
