using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DevExpress.Common.Grid
{
    public static class AppRepositoryItemCheckedComboBoxEdit
    {
        /// <summary>
        /// Độ rộng và cao khi mở
        /// </summary>
        /// <param name="sender"> CheckedComboBoxEdit cần thiết lập </param>
        /// <param name="width"> chiều rộng </param>
        /// <param name="height"> chiều cao </param>
        public static void PopupSize(object sender, int width, int height)
        {
            (sender as DevExpress.Utils.Win.IPopupControl).PopupWindow.Width = width;
            (sender as DevExpress.Utils.Win.IPopupControl).PopupWindow.Height = height;
        }

    }
}
