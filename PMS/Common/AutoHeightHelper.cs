using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing;
using DevExpress.XtraGrid.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Drawing;

namespace PMS.Common
{
    public class AutoHeightHelper
    {
        GridView view;
        int _height;
        public AutoHeightHelper(GridView view, int height)
        {
            this.view = view;
            this._height = height;
            EnableColumnPanelAutoHeight();
        }

        public void EnableColumnPanelAutoHeight()
        {
            SetColumnPanelHeight();
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            view.ColumnWidthChanged += OnColumnWidthChanged;
            view.GridControl.Resize += OnGridControlResize;
            view.EndSorting += OnGridColumnEndSorting;
        }

        void OnGridColumnEndSorting(object sender, EventArgs e)
        {
            view.GridControl.BeginInvoke(new MethodInvoker(SetColumnPanelHeight));
        }

        void OnGridControlResize(object sender, EventArgs e)
        {
            SetColumnPanelHeight();
        }

        void OnColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            SetColumnPanelHeight();
        }

        private void SetColumnPanelHeight()
        {
            GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
            int height = 0;
            for (int i = 0; i < view.VisibleColumns.Count; i++)
                height = Math.Max(GetColumnBestHeight(viewInfo, view.VisibleColumns[i], _height), height);
            view.ColumnPanelRowHeight = height;
        }

        private int GetColumnBestHeight(GridViewInfo viewInfo, GridColumn column, int height)
        {
            GridColumnInfoArgs ex = viewInfo.ColumnsInfo[column];
            if (ex == null)
            {
                viewInfo.GInfo.AddGraphics(null);
                ex = new GridColumnInfoArgs(viewInfo.GInfo.Cache, null);
                try
                {
                    ex.InnerElements.Add(new DrawElementInfo(new GlyphElementPainter(),
                                                            new GlyphElementInfoArgs(viewInfo.View.Images, 0, null),
                                                            StringAlignment.Near));
                    if (viewInfo.View.CanShowFilterButton(null))
                    {
                        ex.InnerElements.Add(viewInfo.Painter.ElementsPainter.FilterButton, new GridFilterButtonInfoArgs());
                    }
                    ex.SetAppearance(viewInfo.PaintAppearance.HeaderPanel);
                    ex.Caption = column.Caption;
                    ex.CaptionRect = new Rectangle(0, 0, column.Width - 20, 17);
                }
                finally
                {
                    viewInfo.GInfo.ReleaseGraphics();
                }
            }
            GraphicsInfo grInfo = new GraphicsInfo();
            grInfo.AddGraphics(null);
            ex.Cache = grInfo.Cache;
            bool canDrawMore = true;
            Size captionSize = CalcCaptionTextSize(grInfo.Cache, ex as HeaderObjectInfoArgs, column.GetCaption());
            Size res = ex.InnerElements.CalcMinSize(grInfo.Graphics, ref canDrawMore);
            //res.Height = Math.Max(res.Height, captionSize.Height);
            res.Height = height;
            res.Width += captionSize.Width;
            //res = viewInfo.Painter.ElementsPainter.Column.CalcBoundsByClientRectangle(ex, new Rectangle(Point.Empty, res)).Size;
            //res =new Size(180, 33);
            grInfo.ReleaseGraphics();
            return res.Height;
        }

        Size CalcCaptionTextSize(GraphicsCache cache, HeaderObjectInfoArgs ee, string caption)
        {
            Size captionSize = ee.Appearance.CalcTextSize(cache, caption, ee.CaptionRect.Width).ToSize();
            captionSize.Height++; captionSize.Width++;
            return captionSize;
        }

        public void DisableColumnPanelAutoHeight()
        {
            UnsubscribeFromEvents();
        }

        private void UnsubscribeFromEvents()
        {
            view.ColumnWidthChanged -= OnColumnWidthChanged;
            view.GridControl.Resize -= OnGridControlResize;
            view.EndSorting -= OnGridColumnEndSorting;
        }
    }
}
