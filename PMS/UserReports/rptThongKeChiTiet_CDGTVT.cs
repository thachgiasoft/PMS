using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace PMS.UserReports
{
    public partial class rptThongKeChiTiet_CDGTVT : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeChiTiet_CDGTVT()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string tenKhoa, string namhoc, string hocky, string hieutruong, string phongdaotao, string truongkhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pKhoa.Value = tenKhoa.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky.ToUpper();
            lblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("temp", typeof(string));
            dt.Rows.Add(dt.NewRow());
            bindingSource1.DataSource = dt;
            MakeBand(MakeCol(tb));
            bindingSource2.DataSource= tb;
            FitColumnBand(tb);
        }


        private void MakeBand(DataTable dt)
        {
            //level1: Month
            int M = -1;
            GridBand gb = null;
            gridBandGD.Children.Clear();
            DataView dv = new DataView(dt, "", "DisPlayWeek,Month,BeginDate,EndDate", DataViewRowState.CurrentRows);

            for (int i = 0; i < dv.Table.Rows.Count; i++)
            {
                //month
                if (M != (int)dv.Table.Rows[i]["Month"])
                {
                    M = (int)dv.Table.Rows[i]["Month"];
                    GridBand gbn = new GridBand();
                    gbn.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                    gbn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gbn.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
                    gbn.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
                    gbn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    gbn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                    gbn.Caption = M.ToString();
                    gbn.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
                    gbn.ImageAlignment = System.Drawing.StringAlignment.Center;
                    gbn.Width = 50;
                    this.gridBandGD.Children.Add(gbn);
                    gb = gbn;
                }
                //Week
                GridBand gbW = new GridBand();
                gbW.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                gbW.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gbW.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
                gbW.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
                gbW.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                gbW.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                gbW.Caption = dv.Table.Rows[i]["DisPlayWeek"].ToString();
                gbW.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
                gbW.ImageAlignment = System.Drawing.StringAlignment.Center;

                gbW.Width = 50;
                gb.Children.Add(gbW);
                //Begin
                GridBand gbB = new GridBand();
                gbB.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                gbB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gbB.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
                gbB.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
                gbB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                gbB.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                gbB.Caption = dv.Table.Rows[i]["BeginDate"].ToString();
                gbB.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
                gbB.ImageAlignment = System.Drawing.StringAlignment.Center;
                gbB.Width = 50;
                gbW.Children.Add(gbB);

                //END
                GridBand gbE = new GridBand();
                gbE.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                gbE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gbE.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
                gbE.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
                gbE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                gbE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                gbE.Caption = dv.Table.Rows[i]["EndDate"].ToString();
                gbE.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
                gbE.ImageAlignment = System.Drawing.StringAlignment.Center;
                gbE.Width = 50; ;
                gbW.MinWidth = 10;
                gbB.Children.Add(gbE);

                //Column
                BandedGridColumn Col = new BandedGridColumn();
                Col.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                Col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                Col.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
                Col.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
                Col.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                Col.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                Col.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                Col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                Col.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
                Col.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
                Col.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                Col.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                Col.Caption = dv.Table.Rows[i]["DisPlayWeek"].ToString() + "-" + dv.Table.Rows[i]["Month"].ToString() + "-" +
                    dv.Table.Rows[i]["BeginDate"].ToString() + "-" + dv.Table.Rows[i]["EndDate"].ToString();
                Col.FieldName = dv.Table.Rows[i]["DisPlayWeek"].ToString() + "-" + dv.Table.Rows[i]["Month"].ToString() + "-" +
                    dv.Table.Rows[i]["BeginDate"].ToString() + "-" + dv.Table.Rows[i]["EndDate"].ToString();
                Col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                Col.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                Col.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
                Col.ImageAlignment = System.Drawing.StringAlignment.Center;
                Col.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
                Col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
                Col.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
                Col.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
                Col.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
                Col.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
                Col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
                Col.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
                Col.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
                Col.DisplayFormat.FormatString = "{0:n0}";
                Col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                Col.Visible = true;
                gbE.Columns.Add(Col);

            }
        }

        private void FitColumnBand(DataTable dt)
        {
            bgv.OptionsView.ColumnAutoWidth = false;
            bgv.BestFitColumns();
        }

        private DataTable MakeCol(DataTable dt)
        {
            DataTable dtC = new DataTable();
            dtC.Columns.Add("DisPlayWeek", typeof(int));
            dtC.Columns.Add("Month", typeof(int));
            dtC.Columns.Add("BeginDate", typeof(int));
            dtC.Columns.Add("EndDate", typeof(int));
            foreach (DataColumn c in dt.Columns)
            {
                string s = c.ColumnName.Replace("-", "");
                if (c.ColumnName.Length == s.Length + 3)
                {
                    DataRow dr = dtC.NewRow();
                    s = c.ColumnName;
                    dr["DisPlayWeek"] = int.Parse(s.Substring(0, s.IndexOf('-')));
                    s = s.Substring(dr["DisPlayWeek"].ToString().Length + 1, s.Length - dr["DisPlayWeek"].ToString().Length - 1);
                    dr["Month"] = int.Parse(s.Substring(0, s.IndexOf('-')));
                    s = s.Substring(dr["Month"].ToString().Length + 1, s.Length - dr["Month"].ToString().Length - 1);
                    dr["BeginDate"] = int.Parse(s.Substring(0, s.IndexOf('-')));
                    s = s.Substring(dr["BeginDate"].ToString().Length + 1, s.Length - dr["BeginDate"].ToString().Length - 1);
                    dr["EndDate"] = int.Parse(s);
                    dtC.Rows.Add(dr);
                }

            }
            DataView dv = new DataView(dtC, "", "DisPlayWeek,Month,BeginDate,EndDate", DataViewRowState.CurrentRows);
            return dv.Table;
        }

    }
}
