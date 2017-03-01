using System;

namespace DevExpress.Common.Grid
{
    public class BaseFormatter : IFormatProvider, ICustomFormatter
    {
        /// <summary>
        /// Nhan dinh dang
        /// </summary>
        /// <param name="fFormat"></param>
        /// <returns></returns>
        public object GetFormat(Type fFormat)
        {
            if (fFormat == typeof(ICustomFormatter)) return this;
            else return null;
        }

        /// <summary>
        /// Dinh dang kieu du lieu trong luoi
        /// </summary>
        /// <param name="fFormat"></param>
        /// <param name="arg"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public string Format(string fFormat, object arg, IFormatProvider provider)
        {
            if (fFormat == "vnd")
                return String.Format("{0} VNĐ", arg);
            else if (fFormat == "b")
                return Convert.ToString((int)arg, 2);
            else
            {
                if (arg is IFormattable)
                    return ((IFormattable)arg).ToString(fFormat, provider);
                else
                    return arg.ToString();
            }
        }
    }
}