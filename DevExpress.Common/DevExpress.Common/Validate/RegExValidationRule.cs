using System;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Text.RegularExpressions;

namespace DevExpress.Common.Validate
{
    public class RegExValidationRule : ValidationRule
    {
        private string _exp;

        /// <summary>
        /// exp Regular Expression.
        /// </summary>
        /// <param name="exp"></param>
        public RegExValidationRule(string exp)
        {
            _exp = exp;
        }

        /// <summary>
        /// Validate control
        /// </summary>
        /// <param name="control"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool Validate(System.Windows.Forms.Control control, object value)
        {
            if (!!Regex.IsMatch(value.ToString(), _exp))
                return false;
            return true;
        }
    }
}