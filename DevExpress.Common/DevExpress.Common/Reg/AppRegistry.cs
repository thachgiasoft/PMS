using System;
using Microsoft.Win32;

namespace DevExpress.Common.Reg
{
    public static class AppRegistry
    {
        private const string SOFTWARE_KEY = "SOFTWARE";
        private const string COMPANY_NAME = "PSC";
        private const string APPLICATION_NAME = "GLOBALIZATION";

        /// <summary>
        /// Get value from registry
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string GetStringRegistryValue(string key, string defaultValue)
        {
            RegistryKey rkCompany = Registry.CurrentUser.OpenSubKey(SOFTWARE_KEY, false).OpenSubKey(COMPANY_NAME, false);
            RegistryKey rkApplication;
            if (rkCompany != null)
            {
                rkApplication = rkCompany.OpenSubKey(APPLICATION_NAME, true);
                if (rkApplication != null)
                {
                    foreach (string sKey in rkApplication.GetValueNames())
                    {
                        if (sKey == key)
                        {
                            return (string)rkApplication.GetValue(sKey);
                        }
                    }
                }
            }
            return defaultValue;
        }

        /// <summary>
        /// Save value to Registry
        /// </summary>
        /// <param name="key"></param>
        /// <param name="stringValue"></param>
        public static void SetStringRegistryValue(string key, string stringValue)
        {
            RegistryKey rkSoftware = Registry.CurrentUser.OpenSubKey(SOFTWARE_KEY, true);
            RegistryKey rkCompany = rkSoftware.CreateSubKey(COMPANY_NAME);
            RegistryKey rkApplication;
            if (rkCompany != null)
            {
                rkApplication = rkCompany.CreateSubKey(APPLICATION_NAME);
                if (rkApplication != null)
                    rkApplication.SetValue(key, stringValue);
            }
        }
    }
}
