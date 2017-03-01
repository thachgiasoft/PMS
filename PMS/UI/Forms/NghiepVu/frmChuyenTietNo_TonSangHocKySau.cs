using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChuyenTietNo_TonSangHocKySau : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        #endregion
        public frmChuyenTietNo_TonSangHocKySau()
        {
            InitializeComponent();

            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }
        }

        private void frmChuyenTietNo_TonSangHocKySau_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewChuyenTietNoTon, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewChuyenTietNoTon, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocVi", "DonGia", "TenChucVu", "DinhMucGiangDay", "SoTietCoiThiTieuChuan", "SoTietNoKyTruoc", "TongTietDay", "SoTietCoiThi", "TietHdcmKhac", "TietTamUng", "SoTietChuyenSangNamSau", "SoTietThanhToan", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ tên", "Học vị", "Đơn giá", "Chức vụ", "Định mức giảng dạy", "Số tiết coi thi TC", "Số tiết nợ / tồn", "Tổng tiết giảng dạy", "Số tiết coi thi", "Tiết HDCM khác", "Số tiết tạm ứng", "Số tiết chuyển sang năm sau", "Số tiết thanh toán", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 99, 85, 150, 100, 70, 100, 70, 70, 70, 70, 80, 70, 70, 90, 70, 99, 99 });
            AppGridView.AlignHeader(gridViewChuyenTietNoTon, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocVi", "DonGia", "TenChucVu", "DinhMucGiangDay", "SoTietCoiThiTieuChuan", "SoTietNoKyTruoc", "TongTietDay", "SoTietCoiThi", "TietHdcmKhac", "TietTamUng", "SoTietThanhToan", "SoTietChuyenSangNamSau" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewChuyenTietNoTon, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewChuyenTietNoTon, "SoTietNoKyTruoc", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewChuyenTietNoTon, "TongTietDay", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewChuyenTietNoTon, "TietHdcmKhac", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewChuyenTietNoTon, "TietTamUng", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewChuyenTietNoTon, "SoTietCoiThi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewChuyenTietNoTon, "SoTietThanhToan", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewChuyenTietNoTon, "SoTietChuyenSangNamSau", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.HideField(gridViewChuyenTietNoTon, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.FormatDataField(gridViewChuyenTietNoTon, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewChuyenTietNoTon, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocVi", "DonGia", "TenChucVu", "DinhMucGiangDay", "SoTietCoiThiTieuChuan", "SoTietNoKyTruoc", "TongTietDay", "SoTietCoiThi", "TietHdcmKhac", "TietTamUng", "SoTietThanhToan" });
            gridViewChuyenTietNoTon.Columns["TenDonVi"].GroupIndex = 0;
            PMS.Common.Globals.WordWrapHeader(gridViewChuyenTietNoTon, 45);
            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetSoTietChuyeNoTon(cboNamHoc.EditValue.ToString());
                tb.Load(reader);
                bindingSourceChuyenTietNoTon.DataSource = tb;
                gridViewChuyenTietNoTon.ExpandAllGroups();
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewChuyenTietNoTon.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataTable _vList = bindingSourceChuyenTietNoTon.DataSource as DataTable;
                    string xmlData = "";
                    foreach (DataRow v in _vList.Rows)
                    {
                        if (v.RowState == DataRowState.Modified)
                        {
                            xmlData += "<Input M=\"" + v["MaGiangVien"]
                                    + "\" S=\"" + v["SoTietChuyenSangNamSau"]
                                    + "\" D=\"" + v["NgayCapNhat"]
                                    + "\" U=\"" + v["NguoiCapNhat"]
                                    + "\" />";
                        }
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";

                    int kq = 0;
                    DataServices.KetQuaThanhToanThuLao.LuuTietNoTon(xmlData, cboNamHoc.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                            gridControlChuyenTietNoTon.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetSoTietChuyeNoTon(cboNamHoc.EditValue.ToString());
                tb.Load(reader);
                bindingSourceChuyenTietNoTon.DataSource = tb;
                gridViewChuyenTietNoTon.ExpandAllGroups();
            }
        }

        private void gridViewChuyenTietNoTon_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if(col.FieldName == "SoTietChuyenSangNamSau")
            {
                DataRowView r = gridViewChuyenTietNoTon.GetRow(e.RowHandle) as DataRowView;
                decimal _soTiet = (decimal.Parse(PMS.Common.Globals.IsNull(r["SoTietNoKyTruoc"], "decimal").ToString())
                            + decimal.Parse(PMS.Common.Globals.IsNull(r["TongTietDay"], "decimal").ToString())
                            + decimal.Parse(PMS.Common.Globals.IsNull(r["SoTietCoiThi"], "decimal").ToString())
                            + decimal.Parse(PMS.Common.Globals.IsNull(r["TietHdcmKhac"], "decimal").ToString()))
                            - (decimal.Parse(PMS.Common.Globals.IsNull(r["DinhMucGiangDay"], "decimal").ToString())
                            + decimal.Parse(PMS.Common.Globals.IsNull(r["SoTietCoiThiTieuChuan"], "decimal").ToString())
                            + decimal.Parse(PMS.Common.Globals.IsNull(r["TietTamUng"], "decimal").ToString()))
                            - decimal.Parse(PMS.Common.Globals.IsNull(r["SoTietChuyenSangNamSau"], "decimal").ToString());
                //(SoTietNoKyTruoc + TongTietDay + SoTietCoiThi + TietHdcmKhac) - (DinhMucGiangDay + SoTietCoiThiTieuChuan + TietTamUng) - SoTietChuyenSangNamSau
                gridViewChuyenTietNoTon.SetRowCellValue(e.RowHandle, "SoTietThanhToan", _soTiet);
                gridViewChuyenTietNoTon.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewChuyenTietNoTon.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }
            Cursor.Current = Cursors.WaitCursor;
            gridViewChuyenTietNoTon.FocusedRowHandle = -1;
            bindingSourceChuyenTietNoTon.EndEdit();
            DataTable data = bindingSourceChuyenTietNoTon.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewChuyenTietNoTon, bindingSourceChuyenTietNoTon);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewChuyenTietNoTon.SortedColumns)
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

            //string filter = gridViewChuyenTietNoTon.ActiveFilterString;
            ////if (filter.Contains(".0000m"))
            ////    filter = filter.Replace(".0000m", "");
            ////if (filter.Contains(".000m"))
            ////    filter = filter.Replace(".000m", "");
            ////if (filter.Contains(".00m"))
            ////    filter = filter.Replace(".00m", "");
            ////if (filter.Contains(".0m"))
            ////    filter = filter.Replace(".0m", "");
            ////if (filter.Contains(".m"))
            ////    filter = filter.Replace(".m", "");

            //DataView dv = new DataView(vListBaoCao, filter, sort, DataViewRowState.CurrentRows);
            ////vListBaoCao = dv.ToTable();
            ////if (vListBaoCao == null)
            //    return;

            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThanhToanThuLaoDot2(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString()
                        , PMS.Common.Globals._cauhinh.NguoiLapbieu, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}