using System;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Threading;
using DevExpress.Common.Config;

namespace DevExpress.Common.Global
{
    public static class AppCulture
    {
        public static ResourceManager RM { get; private set; }

        /// <summary>
        /// Init culture for application
        /// </summary>
        public static void InitCulture()
        {
            //Culture
            CultureInfo objCI = new CultureInfo(AppConfig.Lang);

            objCI.NumberFormat.CurrencyDecimalSeparator = ".";
            objCI.NumberFormat.CurrencyGroupSeparator = ",";
            objCI.NumberFormat.NumberDecimalSeparator = ".";
            objCI.NumberFormat.NumberGroupSeparator = ",";
            objCI.NumberFormat.PercentDecimalSeparator = ".";
            objCI.NumberFormat.PercentGroupSeparator = ",";
            objCI.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";

            Thread.CurrentThread.CurrentCulture = objCI;
            Thread.CurrentThread.CurrentUICulture = objCI;
            //Resource
            RM = ResourceManager.CreateFileBasedResourceManager("resource", Application.StartupPath, null);
        }
    }
}