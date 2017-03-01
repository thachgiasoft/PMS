using System;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Windows.Forms;

namespace DevExpress.Common.Validate
{
    public static class AppValidation
    {
        /// <summary>
        /// Init validation
        /// </summary>
        /// <param name="dxProvider"></param>
        /// <param name="mode"></param>
        public static void InitValidate(DXValidationProvider dxProvider, ValidationMode mode)
        {
            dxProvider.ValidationMode = mode;
            dxProvider.Validate();
        }

        /// <summary>
        /// Validate data
        /// </summary>
        /// <param name="dxProvider"></param>
        public static bool Validate(DXValidationProvider dxProvider)
        {
            return dxProvider.Validate();
        }

        /// <summary>
        /// Notblank
        /// </summary>
        /// <param name="dxProvider"></param>
        /// <param name="control"></param>
        /// <param name="align"></param>
        /// <param name="type"></param>
        /// <param name="errorText"></param>
        public static void NotBlank(DXValidationProvider dxProvider, Control control, ErrorIconAlignment align, ErrorType type, string errorText)
        {
            ConditionValidationRule rule = new ConditionValidationRule { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = errorText, ErrorType = type };
            dxProvider.SetIconAlignment(control, align);
            dxProvider.SetValidationRule(control, rule);
        }

        /// <summary>
        /// Between
        /// </summary>
        /// <param name="dxProvider"></param>
        /// <param name="control"></param>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="align"></param>
        /// <param name="type"></param>
        /// <param name="errorText"></param>
        public static void Between(DXValidationProvider dxProvider, Control control, object value1, object value2, ErrorIconAlignment align, ErrorType type, string errorText)
        {
            ConditionValidationRule rule = new ConditionValidationRule { ConditionOperator = ConditionOperator.Between, ErrorText = errorText, ErrorType = type, Value1 = value1, Value2 = value2 };
            dxProvider.SetIconAlignment(control, align);
            dxProvider.SetValidationRule(control, rule);
        }

        /// <summary>
        /// NotEquals
        /// </summary>
        /// <param name="dxProvider"></param>
        /// <param name="control"></param>
        /// <param name="value"></param>
        /// <param name="align"></param>
        /// <param name="type"></param>
        /// <param name="errorText"></param>
        public static void NotEquals(DXValidationProvider dxProvider, Control control, object value, ErrorIconAlignment align, ErrorType type, string errorText)
        {
            ConditionValidationRule rule = new ConditionValidationRule { ConditionOperator = ConditionOperator.NotEquals, ErrorText = errorText, ErrorType = type, Value1 = value };
            dxProvider.SetIconAlignment(control, align);
            dxProvider.SetValidationRule(control, rule);
        }

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="dxProvider"></param>
        /// <param name="control"></param>
        /// <param name="value"></param>
        /// <param name="align"></param>
        /// <param name="type"></param>
        /// <param name="errorText"></param>
        public static void Contains(DXValidationProvider dxProvider, Control control, object value, ErrorIconAlignment align, ErrorType type, string errorText)
        {
            ConditionValidationRule rule = new ConditionValidationRule { ConditionOperator = ConditionOperator.Contains, ErrorText = errorText, ErrorType = type, Value1 = value };
            dxProvider.SetIconAlignment(control, align);
            dxProvider.SetValidationRule(control, rule);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="dxProvider"></param>
        /// <param name="control"></param>
        /// <param name="value"></param>
        /// <param name="align"></param>
        /// <param name="type"></param>
        /// <param name="errorText"></param>
        public static void Equals(DXValidationProvider dxProvider, Control control, object value, ErrorIconAlignment align, ErrorType type, string errorText)
        {
            ConditionValidationRule rule = new ConditionValidationRule { ConditionOperator = ConditionOperator.Equals, ErrorText = errorText, ErrorType = type, Value1 = value };
            dxProvider.SetIconAlignment(control, align);
            dxProvider.SetValidationRule(control, rule);
        }

        /// <summary>
        /// BeginsWith
        /// </summary>
        /// <param name="dxProvider"></param>
        /// <param name="control"></param>
        /// <param name="value"></param>
        /// <param name="align"></param>
        /// <param name="type"></param>
        /// <param name="errorText"></param>
        public static void BeginsWith(DXValidationProvider dxProvider, Control control, object value, ErrorIconAlignment align, ErrorType type, string errorText)
        {
            ConditionValidationRule rule = new ConditionValidationRule { ConditionOperator = ConditionOperator.BeginsWith, ErrorText = errorText, ErrorType = type, Value1 = value };
            dxProvider.SetIconAlignment(control, align);
            dxProvider.SetValidationRule(control, rule);
        }

        /// <summary>
        /// EndsWith
        /// </summary>
        /// <param name="dxProvider"></param>
        /// <param name="control"></param>
        /// <param name="value"></param>
        /// <param name="align"></param>
        /// <param name="type"></param>
        /// <param name="errorText"></param>
        public static void EndsWith(DXValidationProvider dxProvider, Control control, object value, ErrorIconAlignment align, ErrorType type, string errorText)
        {
            ConditionValidationRule rule = new ConditionValidationRule { ConditionOperator = ConditionOperator.EndsWith, ErrorText = errorText, ErrorType = type, Value1 = value };
            dxProvider.SetIconAlignment(control, align);
            dxProvider.SetValidationRule(control, rule);
        }

        /// <summary>
        /// NotContains
        /// </summary>
        /// <param name="dxProvider"></param>
        /// <param name="control"></param>
        /// <param name="value"></param>
        /// <param name="align"></param>
        /// <param name="type"></param>
        /// <param name="errorText"></param>
        public static void NotContains(DXValidationProvider dxProvider, Control control, object value, ErrorIconAlignment align, ErrorType type, string errorText)
        {
            ConditionValidationRule rule = new ConditionValidationRule { ConditionOperator = ConditionOperator.NotContains, ErrorText = errorText, ErrorType = type, Value1 = value };
            dxProvider.SetIconAlignment(control, align);
            dxProvider.SetValidationRule(control, rule);
        }
    }
}
