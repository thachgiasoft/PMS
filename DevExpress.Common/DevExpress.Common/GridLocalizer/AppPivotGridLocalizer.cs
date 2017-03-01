using System;
using DevExpress.XtraPivotGrid.Localization;

namespace DevExpress.Common.GridLocalizer
{
    public class AppPivotGridLocalizer : PivotGridLocalizer
    {
        /// <summary>
        /// Override Sum
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override string GetLocalizedString(PivotGridStringId id)
        {
            switch (id)
            {
                case PivotGridStringId.GrandTotal:
                    return "Tổng";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
