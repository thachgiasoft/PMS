using System;
using System.Configuration;

namespace DevExpress.Common.Config
{
    public class AppSetting
    {
        private Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        /// <summary>
        /// public AppSetting(string fileName)
        /// </summary>
        /// <param name="fileName"></param>
        public AppSetting(string fileName)
        {
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap { ExeConfigFilename = fileName };
            config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
        }

        /// <summary>
        /// Nhan gia tri trong phan setting
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetSetting(string key)
        {
            try { return config.AppSettings.Settings[key].Value.ToString().Trim(); }
            catch { return null; }
        }

        /// <summary>
        /// Cai dat trong phan setting
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetSetting(string key, object value)
        {
            try
            {
                config.AppSettings.Settings[key].Value = value.ToString();
                config.Save(ConfigurationSaveMode.Full);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Nhan cau hinh ket noi
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetConnection(string key)
        {
            try { return config.ConnectionStrings.ConnectionStrings[key].ConnectionString; }
            catch { return null; }
        }

        /// <summary>
        /// Thiet lap cau hinh ket noi
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetConnection(string key, object value)
        {
            try
            {
                config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value.ToString();
                config.Save(ConfigurationSaveMode.Full);
                return true;
            }
            catch { return false; }
        }
    }
}
