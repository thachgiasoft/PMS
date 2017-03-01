using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeChiTiet_CDGTVT : DevExpress.XtraEditors.XtraUserControl
    { 
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        #endregion

        public ucThongKeChiTiet_CDGTVT()
        {
            InitializeComponent();
        }

        private void frmScheduleDetail_Load(object sender, EventArgs e)
        {
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            
            #region Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã đơn vị", "Tên đơn vị" });
            cboDonVi.Properties.ValueMember = "MaBoMon";
            cboDonVi.Properties.DisplayMember = "TenBoMon";
            cboDonVi.Properties.NullText = string.Empty;
            #endregion

            #region LoaiGiangVien
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();

            TList<LoaiGiangVien> _tListLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();

            foreach (LoaiGiangVien l in _tListLoaiGiangVien)
                list.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, string.Format("{0} - {1}", l.MaQuanLy, l.TenLoaiGiangVien), CheckState.Unchecked, true));
            cboLoaiGiangVien.Properties.Items.AddRange(list.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
            #endregion

            InitData();
           
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if(cboNamHoc.EditValue!=null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            cboDonVi.DataBindings.Clear();
            bindingSourceDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void GetData()
        {
            DataTable tbl = new DataTable();
            IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeChiTiet_Cdgtvt(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
            tbl.Load(reader);

            MakeBand(MakeCol(tbl));
            bindingSource1.DataSource = tbl;
            FitColumnBand(tbl);
        }

        private void MakeBand(DataTable dt)
        {
            //level1: Month
            int M = -1;
            GridBand gb=null;
            gridBandGD.Children.Clear();
            DataView dv = new DataView(dt,"","DisPlayWeek,Month,BeginDate,EndDate", DataViewRowState.CurrentRows);
            
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
                gbE.Width = 50;;
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
                Col.Caption = dv.Table.Rows[i]["DisPlayWeek"].ToString()+"-"+dv.Table.Rows[i]["Month"].ToString()+"-"+
                    dv.Table.Rows[i]["BeginDate"].ToString()+"-"+dv.Table.Rows[i]["EndDate"].ToString();
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
                Col.DisplayFormat.FormatString= "{0:n0}";
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
                string s = c.ColumnName.Replace("-","");
                if (c.ColumnName.Length == s.Length + 3)
                {
                    DataRow dr = dtC.NewRow();
                    s = c.ColumnName;
                    dr["DisPlayWeek"] = int.Parse(s.Substring(0, s.IndexOf('-')));
                    s = s.Substring(dr["DisPlayWeek"].ToString().Length+1, s.Length - dr["DisPlayWeek"].ToString().Length-1);
                    dr["Month"] = int.Parse(s.Substring(0, s.IndexOf('-')));
                    s = s.Substring(dr["Month"].ToString().Length+1, s.Length - dr["Month"].ToString().Length-1);
                    dr["BeginDate"] = int.Parse(s.Substring(0, s.IndexOf('-')));
                    s = s.Substring(dr["BeginDate"].ToString().Length+1, s.Length - dr["BeginDate"].ToString().Length-1);
                    dr["EndDate"] = int.Parse(s);
                    dtC.Rows.Add(dr);
                }

            }
            DataView dv = new DataView(dtC, "", "DisPlayWeek,Month,BeginDate,EndDate", DataViewRowState.CurrentRows);
            return dv.Table;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
                GetData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControl1.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }
            Cursor.Current = Cursors.WaitCursor;
            bgv.FocusedRowHandle = -1;
            bindingSource1.EndEdit();
            DataTable data = bindingSource1.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(bgv, bindingSource1);
            
            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeChiTietKhoiLuongGiangDayCDGTVTMau2(PMS.Common.Globals._cauhinh.TenTruong, cboDonVi.Text, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.PhongDaoTao, "", PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}