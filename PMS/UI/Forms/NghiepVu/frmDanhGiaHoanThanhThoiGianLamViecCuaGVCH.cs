using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Common;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmDanhGiaHoanThanhThoiGianLamViecCuaGVCH : DevExpress.XtraEditors.XtraForm
    {

        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ShortCut = Shortcut.None;

                barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem1.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        private string groupname = UserInfo.GroupName;
        string _maTruong;
        VList<ViewKhoaBoMon> _vListKhoaBoMon;

        public frmDanhGiaHoanThanhThoiGianLamViecCuaGVCH()
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
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmDanhGiaHoanThanhThoiGianLamViecCuaGVCH_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewDanhGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewDanhGia, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TietNghiaVu", "TenHocVi", "MaNoiDungDanhGia", "ThoiGianLamViecQuyDinh", "DanhGiaThoiGianThucHien", "PhanTramDanhGia", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Chức danh", "Định mức chuẩn", "Trình độ", "Nội dung đánh giá", "Thời gian làm việc quy định", "Giờ thực hiện", "Phần trăm đánh giá (%)", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 90, 140, 90, 90, 90, 100, 90, 90, 90, 90, 99, 99 });
            AppGridView.AlignHeader(gridViewDanhGia, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TietNghiaVu", "TenHocVi", "MaNoiDungDanhGia", "ThoiGianLamViecQuyDinh", "DanhGiaThoiGianThucHien", "PhanTramDanhGia", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewDanhGia, "MaNoiDungDanhGia", repositoryItemGridLookUpEditNoiDungDanhGia);
            AppGridView.ReadOnlyColumn(gridViewDanhGia, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TietNghiaVu", "TenHocVi", "MaNoiDungDanhGia" });
            AppGridView.HideField(gridViewDanhGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.SummaryField(gridViewDanhGia, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.MergeCell(gridViewDanhGia, new string[] { "ThoiGianLamViecQuyDinh", "DanhGiaThoiGianThucHien", "PhanTramDanhGia", "GhiChu", "NgayCapNhat", "NguoiCapNhat" });
            WordWrapHeader(gridViewDanhGia, 50);

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Khoa - Don vi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNoiDungDanhGia, 390, 500);
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNoiDungDanhGia, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNoiDungDanhGia, new string[] { "MaQuanLy", "TenNoiDungDanhGia", "VietTat", "SoThuTu" }, new string[] { "Mã quản lý", "tên nội dung đánh giá", "Viết tắt", "STT" }, new int[] { 90, 150, 100, 50 });
            repositoryItemGridLookUpEditNoiDungDanhGia.DisplayMember = "VietTat";
            repositoryItemGridLookUpEditNoiDungDanhGia.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditNoiDungDanhGia.NullText = string.Empty;
            InitData();
        }

        void WordWrapHeader(GridView grid, int height)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
                grid.Columns[i].AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            AutoHeightHelper a = new AutoHeightHelper(gridViewDanhGia, height);
            a.EnableColumnPanelAutoHeight();
        }

        void InitData()
        {
            bindingSourceNoiDungDanhGia.DataSource = DataServices.NoiDungDanhGia.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboKhoaDonVi.DataBindings.Clear();

            _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            if (_maTruong == "CTIM")
            {
                VList<ViewKhoaBoMon> v = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
                if (v.Count > 0)
                {
                    _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
                }
                else
                    _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            }
            bindingSourceKhoaDonVi.DataSource = _vListKhoaBoMon;

            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);
            if (cboNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaDanhGiaVuotGio.GetByNamHocMaDonVi(cboNamHoc.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["DanhGiaThoiGianThucHien"].ReadOnly = false;
                bindingSourceDanhGia.DataSource = tb;
                
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDanhGia.FocusedRowHandle = -1;
            DataTable list = bindingSourceDanhGia.DataSource as DataTable;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow row in list.Rows)
                        {
                            xmlData += String.Format("<Input M=\"{0}\" MN=\"{1}\" T=\"{2}\" D=\"{3}\" P=\"{4}\" G=\"{5}\" N=\"{6}\" U=\"{7}\" />"
                                        , row["MaQuanLy"].ToString()
                                        , row["MaNoiDungDanhGia"].ToString()
                                        , row["ThoiGianLamViecQuyDinh"].ToString()
                                        , row["DanhGiaThoiGianThucHien"].ToString()
                                        , row["PhanTramDanhGia"].ToString()
                                        , row["GhiChu"].ToString()
                                        , row["NgayCapNhat"].ToString()
                                        , row["NguoiCapNhat"].ToString());
                        }
                        bindingSourceDanhGia.EndEdit();
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);

                        int kq = 0;
                        DataServices.KetQuaDanhGiaVuotGio.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlDanhGia.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaDanhGiaVuotGio.GetByNamHocMaDonVi(cboNamHoc.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["DanhGiaThoiGianThucHien"].ReadOnly = false;
                bindingSourceDanhGia.DataSource = tb;
            }
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaDanhGiaVuotGio.GetByNamHocMaDonVi(cboNamHoc.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["DanhGiaThoiGianThucHien"].ReadOnly = false;
                bindingSourceDanhGia.DataSource = tb;
            }
        }

        private void gridViewDanhGia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "ThoiGianLamViecQuyDinh" || col.FieldName == "DanhGiaThoiGianThucHien" || col.FieldName == "PhanTramDanhGia" || col.FieldName == "GhiChu")
            {
                gridViewDanhGia.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewDanhGia.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
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
            gridViewDanhGia.FocusedRowHandle = -1;
            bindingSourceDanhGia.EndEdit();
            DataTable data = bindingSourceDanhGia.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewDanhGia, bindingSourceDanhGia);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewDanhGia.SortedColumns)
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

            //string filter = gridViewDanhGia.ActiveFilterString;
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

            int dem = vListBaoCao.Rows.Count;


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeNhanXetDanhGiaVuotGio(cboKhoaDonVi.Text, cboNamHoc.EditValue.ToString(), UserInfo.FullName, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //DataTable dtData = bindingSourceDanhGia.DataSource as DataTable;

                //if (dtData == null)
                //{
                //    dtData = new DataTable();
                //    dtData.Load(DataServices.KetQuaDanhGiaVuotGio.GetByNamHocMaDonVi(cboNamHoc.EditValue.ToString()
                //    , cboKhoaDonVi.EditValue.ToString()));
                //}

                //if (dtData.Rows.Count == 0) return;

                //if (dtData.Columns["MaDonVi"] != null && dtData.Columns["_namHoc"] != null)
                //{
                //    DataTable dtDongBo = new DataTable();
                //    dtDongBo.Load(DataServices.KetQuaDanhGiaVuotGio.GetDanhGiaThucHienByNamHocMaDonVi(dtData.Rows[0]["_namHoc"].ToString()
                //         , dtData.Rows[0]["MaDonVi"].ToString()));

                //    dtData.Columns["DanhGiaThoiGianThucHien"].ReadOnly = false;
                //    for (int i = 0; i < dtData.Rows.Count; i++)
                //    {
                //        for (int j = 0; j < dtDongBo.Rows.Count; j++)
                //        {
                //            if (dtData.Rows[i]["MaQuanLy"] == dtDongBo.Rows[j]["MaQuanLy"])
                //            {
                //                if (dtData.Rows[i]["MaNoiDungDanhGia"] == "GD")
                //                    dtData.Rows[i]["DanhGiaThoiGianThucHien"] = dtDongBo.Rows[i]["TietQuyDoi"];
                //                break;
                //            }
                //        }
                //    }
                //    XtraMessageBox.Show("Đồng bộ thành công.");
                //}
                if (cboNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null)
                {
                    if (XtraMessageBox.Show(string.Format("Bạn muốn đồng bộ giờ thực hiện giảng dạy năm học {0}?", cboNamHoc.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        int kq = 0;
                        DataServices.KetQuaDanhGiaVuotGio.DongBoTheoNamHocKhoaDonVi(cboNamHoc.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kq);
                        Cursor.Current = Cursors.Default;

                        if (kq == 0)
                            XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnLamTuoi.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.InnerException.Message);
            }
        }
    }
}