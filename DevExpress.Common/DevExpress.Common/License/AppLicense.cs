using System;
using System.Text;
using System.Security.Cryptography;
using System.Collections;

namespace DevExpress.Common.License
{
    public static class AppLicense
    {
        /// <summary>
        /// public static string GetProductID(string ProductName)
        /// </summary>
        /// <param name="ProductName"></param>
        /// <returns></returns>
        public static string GetProductID(string ProductName)
        {
            return FormatProductID(EncryptKey(ProductID(Hardware.GetMachineID(), ProductName)));
        }

        /// <summary>
        /// public static string GetRegistration(string ProductID)
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public static string GetRegistration(string ProductID)
        {
            return FormatProductKey(EncryptKey(ProductID.Replace("-", "").Trim()));
        }

        /// <summary>
        /// public static void SaveLicense(string ID, string Registration, string fileName)
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Registration"></param>
        /// <param name="fileName"></param>
        public static void SaveLicense(string ID, string Registration, string fileName)
        {
            ObjectPacketLicense lic = new ObjectPacketLicense(fileName);
            lic.CreateLicense(ID, Registration, Version.License);
        }

        /// <summary>
        /// public static bool IsRegistration(string ID, string Registration)
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Registration"></param>
        /// <returns></returns>
        public static bool IsRegistration(string ID, string Registration)
        {
            ObjectPacketLicense opl = new ObjectPacketLicense("Key.lic");
            if (opl.IsRegister(ID, Registration, Version.License))
                return true;
            else
                return false;
        }

        /// <summary>
        /// private static string ProductID(string MachineID, string ProductName)
        /// </summary>
        /// <param name="MachineID"></param>
        /// <param name="ProductName"></param>
        /// <returns></returns>
        private static string ProductID(string MachineID, string ProductName)
        {
            return MachineID + ProductName;
        }

        /// <summary>
        /// private static string EncryptKey(string ID)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private static string EncryptKey(string ID)
        {
            byte[] data;
            using (SHA1CryptoServiceProvider md5 = new SHA1CryptoServiceProvider())
            {
                UTF8Encoding utf = new UTF8Encoding();
                data = md5.ComputeHash(utf.GetBytes(ID));
                return Convert.ToBase64String(data).Replace("/", "T").Replace("+", "U").Replace("=", "A").Replace("-", "N").ToUpper();
            }
        }

        /// <summary>
        /// private static string FormatProductyID(string ProductIDEncrypt)
        /// </summary>
        /// <param name="ProductIDEncrypt"></param>
        /// <returns></returns>
        private static string FormatProductID(string ProductIDEncrypt)
        {
            StringBuilder sb = new StringBuilder();
            int i = 1;
            foreach (char c in ProductIDEncrypt)
            {
                if (i % 4 == 0 && i != 28)
                    sb.Append(String.Format("{0}-", c));
                else
                    sb.Append(c.ToString());
                i++;
            }
            return sb.ToString();
        }

        /// <summary>
        /// private static string FormatProductKey(string ProductKey)
        /// </summary>
        /// <param name="ProductKey"></param>
        /// <returns></returns>
        private static string FormatProductKey(string ProductKey)
        {
            StringBuilder sb = new StringBuilder();
            ArrayList list = new ArrayList();
            foreach (char c in ProductKey)
                list.Add(c);
            int i = 1, j = 0;
            foreach (char c in ProductKey)
            {
                if ((i % 4 == 0) && i != 28)
                    sb.Append(String.Format("{0}{1}-", c, list[j++]));
                else
                {
                    if (i == 28)
                        sb.Append(c.ToString() + list[list.Count - 1]);
                    else
                        sb.Append(c.ToString());
                }
                i++;
            }
            return sb.ToString();
        }
    }
}
