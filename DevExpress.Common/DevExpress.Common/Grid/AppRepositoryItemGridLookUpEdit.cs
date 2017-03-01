using System;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;

namespace DevExpress.Common.Grid
{
    public static class AppRepositoryItemGridLookUpEdit
    {
        /// <summary>
        /// Thiet lap cau hinh luoi
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="autoFilter"></param>
        /// <param name="autoPopup"></param>
        /// <param name="textEditStyle"></param>
        public static void InitRepositoryItemGridLookUp(RepositoryItemGridLookUpEdit grid, bool autoPopup, TextEditStyles textEditStyle)
        {
            //Show filter
            grid.View.OptionsView.ShowAutoFilterRow = true;
            grid.TextEditStyle = textEditStyle;
            grid.ImmediatePopup = autoPopup;
            grid.PopupFilterMode = PopupFilterMode.Contains;
            //grid.BestFitMode = BestFitMode.BestFit;
            for (int i = 0; i < grid.View.Columns.Count; i++)
                grid.View.Columns[i].Visible = false;
        }

        /// <summary>
        /// Thiet lap cau hinh luoi
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="autoFilter"></param>
        public static void InitRepositoryItemGridLookUp(RepositoryItemGridLookUpEdit grid, TextEditStyles textEditStyle)
        {
            //Show filter
            grid.View.OptionsView.ShowAutoFilterRow = true;
            grid.TextEditStyle = textEditStyle;
            grid.PopupFilterMode = PopupFilterMode.Contains;
            //grid.BestFitMode = BestFitMode.BestFit;
            for (int i = 0; i < grid.View.Columns.Count; i++)
                grid.View.Columns[i].Visible = false;
        }

        /// <summary>
        /// Thiet lap kich co popup cho form
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void InitPopupFormSize(RepositoryItemGridLookUpEdit grid, int width, int height)
        {
            grid.PopupFormSize = new Size(width, height);
        }

        /// <summary>
        /// Chi dinh cac field trong luoi duoc hien thi
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="fieldName"></param>
        /// <param name="caption"></param>
        public static void ShowField(RepositoryItemGridLookUpEdit grid, string[] fieldName, string[] caption)
        {
            grid.View.OptionsView.ColumnAutoWidth = true;
            for (int i = 0; i < fieldName.Length; i++)
            {
                grid.View.Columns.AddField(fieldName[i]);
                grid.View.Columns[fieldName[i]].Visible = true;
                grid.View.Columns[fieldName[i]].Caption = caption[i];
                grid.View.Columns[fieldName[i]].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            }
            grid.BestFitMode = BestFitMode.BestFit;
        }

        /// <summary>
        /// An di cac cot, dung sau ShowField
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="fieldName"></param>
        public static void HideField(RepositoryItemGridLookUpEdit grid, string[] fieldName)
        {
            for (int i = 0; i < fieldName.Length; i++)
                grid.View.Columns[fieldName[i]].Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="fieldName"></param>
        /// <param name="visible"></param>
        public static void ShowAssignField(RepositoryItemGridLookUpEdit grid, string[] fieldName, bool visible)
        {
            for (int i = 0; i < fieldName.Length; i++)
                grid.View.Columns[fieldName[i]].Visible = visible;
        }

        /// <summary>
        /// Chi dinh cac field trong luoi duoc hien thi
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="fieldName"></param>
        /// <param name="caption"></param>
        /// <param name="width"></param>
        public static void ShowField(RepositoryItemGridLookUpEdit grid, string[] fieldName, string[] caption, int[] width)
        {
            grid.View.OptionsView.ColumnAutoWidth = true;
            for (int i = 0; i < fieldName.Length; i++)
            {
                grid.View.Columns.AddField(fieldName[i]);
                grid.View.Columns[fieldName[i]].Visible = true;
                grid.View.Columns[fieldName[i]].Caption = caption[i];
                grid.View.Columns[fieldName[i]].Width = width[i];
                grid.View.Columns[fieldName[i]].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            }
        }
    }
}
