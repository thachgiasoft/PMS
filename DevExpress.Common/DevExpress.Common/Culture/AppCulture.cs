using System;
using System.Globalization;
using System.Windows.Forms;

namespace DevExpress.Common.Culture
{
    public class AppCulture
    {
        /// <summary>
        /// Init culture
        /// </summary>
        public static void InitCulture()
        {
            CultureInfo cul = new CultureInfo(("vi-VN"));
            cul.NumberFormat.CurrencyDecimalSeparator = ".";
            cul.NumberFormat.CurrencyGroupSeparator = ",";
            cul.NumberFormat.NumberDecimalSeparator = ".";
            cul.NumberFormat.NumberGroupSeparator = ",";
            cul.NumberFormat.PercentDecimalSeparator = ".";
            cul.NumberFormat.PercentGroupSeparator = ",";
            cul.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            Application.CurrentCulture = cul;
        }
    }
}