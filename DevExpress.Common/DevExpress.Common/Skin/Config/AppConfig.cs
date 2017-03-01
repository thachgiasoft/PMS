using System;

namespace DevExpress.Common.Config
{
    public static class AppConfig
    {
        private static AppSetting config;

        static AppConfig() { config = new AppSetting(); }

        /// <summary>
        /// Get SkinID from configuration file.
        /// </summary>
        public static int SkinID
        {
            get
            {
                try { return int.Parse(config.GetSetting("SkinID")); }
                catch { return 1; }
            }
            set { config.SetSetting("SkinID", value); }
        }

        /// <summary>
        /// Get language from configuration file.
        /// </summary>
        public static string Lang
        {
            get { return config.GetSetting("Lang"); }
            set { config.SetSetting("Lang", value); }
        }

        /// <summary>
        /// Get format numeric from configuration file.
        /// </summary>
        public static string FormatNumeric
        {
            get { return config.GetSetting("FormatNumeric"); }
        }            
    }
}
