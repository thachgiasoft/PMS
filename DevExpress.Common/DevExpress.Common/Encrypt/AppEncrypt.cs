using System;
using System.Text;
using System.Security.Cryptography;

namespace DevExpress.Common.Encrypt
{
    public static class AppEncrypt
    {
        /// <summary>
        /// Encrypt by SHA1
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string EncryptValue(string value)
        {
            using (SHA1CryptoServiceProvider md5 = new SHA1CryptoServiceProvider())
            {
                UTF8Encoding utf = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
    }
}
