using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.Common
{
    public class XuLyGiaoDien
    {
        /// <summary>
        /// In 
        /// </summary>
        public static DataTable LayDuLieuIn(GridView gridViewThongKe, BindingSource bindingsourceThongKe)
        {

            Cursor.Current = Cursors.WaitCursor;

            gridViewThongKe.FocusedRowHandle = -1;
            //bindingSourceThongKe.EndEdit();
            DataTable data = bindingsourceThongKe.DataSource as DataTable;

            if (data == null)
                return null;
            DataTable vListBaoCao = data;
            if (vListBaoCao == null)
                return null;

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
                    {
                        switch (c.SortOrder)
                        {
                            case DevExpress.Data.ColumnSortOrder.Ascending:
                                sort += string.Format("{0} ASC, ", c.FieldName);
                                break;
                            case DevExpress.Data.ColumnSortOrder.Descending:
                                sort += string.Format("{0} DESC, ", c.FieldName);
                                break;
                        }
                    }
                }
                if (sort != "")
                    sort = sort.Substring(0, sort.Length - 2);
            }

            string filter = gridViewThongKe.ActiveFilterString;
            if (filter.Contains(".0000m"))
                filter = filter.Replace(".0000m", "");
            if (filter.Contains(".000m"))
                filter = filter.Replace(".000m", "");
            if (filter.Contains(".00m"))
                filter = filter.Replace(".00m", "");
            if (filter.Contains(".0m"))
                filter = filter.Replace(".0m", "");
            if (filter.Contains(".m"))
                filter = filter.Replace(".m", "");

            if (gridViewThongKe.ActiveFilter == null || ! gridViewThongKe.ActiveFilterEnabled
                || gridViewThongKe.ActiveFilter.Expression == "")
                return data;

            DataView dv = new DataView(data);
            dv.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(gridViewThongKe.ActiveFilterCriteria);

            vListBaoCao = dv.ToTable();
            if (vListBaoCao == null)
                return null;

            vListBaoCao.AcceptChanges();

            //foreach (DataColumn column in vListBaoCao.Columns)
            //{
            //    column.ReadOnly = false;
            //}

            Cursor.Current = Cursors.Default;

            return vListBaoCao;
        }

        public static DataTable LayDuLieuIn(GridView gridViewThongKe, DataTable data)
        {

            Cursor.Current = Cursors.WaitCursor;

            gridViewThongKe.FocusedRowHandle = -1;

            if (data == null)
                return null;
            DataTable vListBaoCao = data;
            if (vListBaoCao == null)
                return null;

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
                    {
                        switch (c.SortOrder)
                        {
                            case DevExpress.Data.ColumnSortOrder.Ascending:
                                sort += string.Format("{0} ASC, ", c.FieldName);
                                break;
                            case DevExpress.Data.ColumnSortOrder.Descending:
                                sort += string.Format("{0} DESC, ", c.FieldName);
                                break;
                        }
                    }
                }
                if (sort != "")
                    sort = sort.Substring(0, sort.Length - 2);
            }

            string filter = gridViewThongKe.ActiveFilterString;
            if (filter.Contains(".0000m"))
                filter = filter.Replace(".0000m", "");
            if (filter.Contains(".000m"))
                filter = filter.Replace(".000m", "");
            if (filter.Contains(".00m"))
                filter = filter.Replace(".00m", "");
            if (filter.Contains(".0m"))
                filter = filter.Replace(".0m", "");
            if (filter.Contains(".m"))
                filter = filter.Replace(".m", "");

            if (gridViewThongKe.ActiveFilter == null || !gridViewThongKe.ActiveFilterEnabled
                || gridViewThongKe.ActiveFilter.Expression == "")
                return data;

            DataView dv = new DataView(data);
            dv.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(gridViewThongKe.ActiveFilterCriteria);

            vListBaoCao = dv.ToTable();
            if (vListBaoCao == null)
                return null;

            vListBaoCao.AcceptChanges();

            Cursor.Current = Cursors.Default;

            return vListBaoCao;
        }

        public static void ThongBao(string message, MessageBoxIcon icon, bool useDevExpress)
        {
            string title;
            switch (icon)
            {
                case MessageBoxIcon.Information:
                    title = "Thông báo";
                    break;
                case MessageBoxIcon.Warning:
                    title = "Cảnh báo";
                    break;
                default:
                    title = "";
                    break;
            }
            if (useDevExpress)
            {
                XtraMessageBox.Show(message, title, MessageBoxButtons.OK, icon);
            }
            else
            {
                XtraMessageBox.Show(message, title, MessageBoxButtons.OK, icon);
            }
        }

        public static void ThongBaoLoi(Exception ex, bool useDevExpress)
        {
            string message;
            if (ex.Message.Contains("is being used by another process"))
            {
                message = "Tập tin hoặc ứng dụng đang mở. Hãy đóng lại trước khi thực hiện thao tác này.";
            }
            else if (ex.Message.Contains("number") && ex.Message.Contains("format"))
            {
                message = "Không thể chuyển đổi chữ sang số.";
            }
            else
            {
                message = ex.Message;
            }
            if(useDevExpress)
            {
                XtraMessageBox.Show(message, "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(message, "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
