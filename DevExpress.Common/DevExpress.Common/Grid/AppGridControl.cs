using System;
using DevExpress.XtraGrid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.Common.Grid
{
    public static class AppGridControl
    {
        /// <summary>
        /// Thiet lap tooltip cho luoi
        /// </summary>
        /// <param name="view"></param>
        /// <param name="rowHandle"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        private static string GetCellHintText(GridView view, int rowHandle, DevExpress.XtraGrid.Columns.GridColumn column)
        {
            string ret = view.GetRowCellDisplayText(rowHandle, column);
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in view.Columns)
                if (col.VisibleIndex < 0)
                    ret += string.Format("\r\n {0}: {1}", col.GetTextCaption(), view.GetRowCellDisplayText(rowHandle, col));
            return ret;
        }

        /// <summary>
        /// Thiet lap tooltip tu cell
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        private static string GetColumnHintText(DevExpress.XtraGrid.Columns.GridColumn column)
        {
            return column.GetTextCaption();
        }

        /// <summary>
        /// Hien thi tooltip trong luoi
        /// </summary>
        /// <param name="gridControl"></param>
        /// <param name="grid"></param>
        /// <param name="e"></param>
        public static void ShowToolTip(GridControl gridControl, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl != gridControl)
                return;
            ToolTipControlInfo info = null;
            GridView view = gridControl.GetViewAt(e.ControlMousePosition) as GridView;
            if (view == null)
                return;
            GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
            if (hi.InRowCell)
                info = new ToolTipControlInfo(new CellToolTipInfo(hi.RowHandle, hi.Column, "cell"), GetCellHintText(view, hi.RowHandle, hi.Column));
            else if (hi.Column != null)
                info = new ToolTipControlInfo(hi.Column, GetColumnHintText(hi.Column));
            else if (hi.HitTest == GridHitTest.GroupPanel)
                info = new ToolTipControlInfo(hi.HitTest, "Group panel");
            else if (hi.HitTest == GridHitTest.RowIndicator)
                info = new ToolTipControlInfo(GridHitTest.RowIndicator.ToString() + hi.RowHandle.ToString(), String.Format("Row Handle: {0}", hi.RowHandle));
            e.Info = info;
        }
    }
}