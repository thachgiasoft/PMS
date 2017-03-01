using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMS.UI.Forms.NghiepVu;
using PMS.Services;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucTietNghiaVuTheoNamHoc : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;


                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        TList<GiamTruDinhMuc> _listGiamTruKhac = new TList<GiamTruDinhMuc>();
        string _maTruong;
        #endregion

        public ucTietNghiaVuTheoNamHoc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucTietNghiaVuTheoNamHoc_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            switch (_maTruong)
            { 
                case "VHU":
                    InitGridVHU();
                    break;
                case "DLU":
                    InitGridDLU();
                    break;
                case "HBU":
                    InitGridHBU();
                    break;
                default:
                    InitGridVHU();
                    break;
            }
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            InitGiamTruKhac();

            InitData();
        }

        #region InitGridView { }
        void InitGiamTruKhac()
        {
            switch (_maTruong)
            {
                case "DLU":
                    #region GiamTruKhac
                    AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiamTruKhac, TextEditStyles.Standard);
                    AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiamTruKhac, new string[] { "NoiDungGiamTru", "MucGiam", "MucGiamNckh", "DonVi" }, new string[] { "Nội dung giảm trừ", "Mức giảm giảng dạy", "Mức giảm NCKH", "Đơn vị" }, new int[] { 200, 100, 100, 100 });
                    AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiamTruKhac, 500, 500);
                    repositoryItemGridLookUpEditGiamTruKhac.DisplayMember = "NoiDungGiamTru";
                    repositoryItemGridLookUpEditGiamTruKhac.ValueMember = "MaQuanLy";
                    repositoryItemGridLookUpEditGiamTruKhac.NullText = String.Empty;
                    #endregion
                    break;
                default:
                    #region GiamTruKhac
                    AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiamTruKhac, TextEditStyles.Standard);
                    AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiamTruKhac, new string[] { "NoiDungGiamTru", "MucGiam", "DonVi" }, new string[] { "Nội dung giảm trừ", "Mức giảm", "Đơn vị" }, new int[] { 200, 100, 100 });
                    AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiamTruKhac, 400, 500);
                    repositoryItemGridLookUpEditGiamTruKhac.DisplayMember = "NoiDungGiamTru";
                    repositoryItemGridLookUpEditGiamTruKhac.ValueMember = "MaQuanLy";
                    repositoryItemGridLookUpEditGiamTruKhac.NullText = String.Empty;
                    #endregion
                    break;
            }
        }

        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu"
                    , "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy", "DinhMucToiThieuCuaChucVu", "TietGiangDayGiamDoChucVu"
                    , "TietNghiaVuQuanLyKiemNhiem", "MaGiamTruKhac", "SoTietGiamTruKhac", "TongTietGiamDoTamNghi", "TietNoGiangDay", "TietNoNcKh", "TietBaoLuuNckh", "TietNoQuanLy"
                    , "GioChuanGiangDayChuyenSangNckh", "SumTietnghiaVuGiangDay", "SumTietNghiaVuNckh", "SumTietNghiaVuQuanLy", "GhiChu", "MaGiangVien" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Định mức GC giảng dạy", "Định mức GC NCKH"
                    , "Định mức GC TGQL", "Định mức tối thiểu chức vụ", "GC giảm do chức vụ", "Định mức TGQL kiêm nhiệm", "Giảm trừ khác", "Số GC giảm khác"
                    , "Tiết giảm theo thời gian", "GC giảng dạy nợ", "GC NCKH nợ", "GC NCKH bảo lưu", "GC TGQL nợ", "GC giảng dạy chuyển sang NCKH"
                    , "Tổng GC giảng dạy", "Tổng GC NCKH", "Tổng GC TGQL", "Ghi chú", "MaGiangVien" }
                , new int[] { 90, 90, 140, 100, 100, 100, 90, 90, 90, 90, 90, 100, 100, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 120, 99 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy"
                , "DinhMucToiThieuCuaChucVu", "TietGiangDayGiamDoChucVu", "TietNghiaVuQuanLyKiemNhiem", "MaGiamTruKhac", "SoTietGiamTruKhac", "TongTietGiamDoTamNghi"
                , "TietNoGiangDay", "TietNoNcKh", "TietBaoLuuNckh", "TietNoQuanLy", "GioChuanGiangDayChuyenSangNckh", "SumTietnghiaVuGiangDay", "SumTietNghiaVuNckh", "SumTietNghiaVuQuanLy", "GhiChu", "MaGiangVien" }
                , DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy", "DinhMucToiThieuCuaChucVu"
                , "TietGiangDayGiamDoChucVu", "TietNghiaVuQuanLyKiemNhiem", "SoTietGiamTruKhac", "TongTietGiamDoTamNghi", "TietNoGiangDay", "TietNoNcKh", "TietBaoLuuNckh", "TietNoQuanLy", "SumTietnghiaVuGiangDay"
                , "SumTietNghiaVuNckh", "SumTietNghiaVuQuanLy", "MaGiangVien" });
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "MaGiangVien" });
            AppGridView.RegisterControlField(gridViewTietNghiaVu, "MaGiamTruKhac", repositoryItemGridLookUpEditGiamTruKhac);
            AppGridView.FixedField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen" }, FixedStyle.Left);
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNoGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNoNcKh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietBaoLuuNckh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNoQuanLy", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietGiamTruKhac", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TongTietGiamDoTamNghi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietnghiaVuGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietNghiaVuNckh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietNghiaVuQuanLy", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewTietNghiaVu.Columns["TenDonVi"].GroupIndex = 0;
            PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 45);
        }

        void InitGridHBU()
        {
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy", "DinhMucToiThieuCuaChucVu", "TietGiangDayGiamDoChucVu", "TietNghiaVuQuanLyKiemNhiem", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "TietNo_BaoLuuQuanLy", "GioChuanGiangDayChuyenSangNckh", "SumTietnghiaVuGiangDay", "SumTietNghiaVuNckh", "SumTietNghiaVuQuanLy", "GhiChu", "MaGiangVien" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Định mức GC giảng dạy", "Định mức GC NCKH", "Định mức GC khác", "Định mức tối thiểu chức vụ", "Tiết giảm do chức vụ", "Định mức GC TGQL kiêm nhiệm", "Giảm trừ khác", "Số tiết giảm khác", "GC giảng dạy nợ/bảo lưu", "GC NCKH nợ/bảo lưu", "GC khác nợ/bảo lưu", "GC giảng dạy chuyển sang NCKH", "Tổng GC giảng dạy", "Tổng GC NCKH", "Tổng GC khác", "Ghi chú", "MaGiangVien" }
                , new int[] { 90, 90, 140, 100, 100, 100, 90, 90, 90, 90, 90, 100, 100, 90, 90, 90, 90, 90, 90, 90, 90, 120, 99 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy", "DinhMucToiThieuCuaChucVu", "TietGiangDayGiamDoChucVu", "TietNghiaVuQuanLyKiemNhiem", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "TietNo_BaoLuuQuanLy", "GioChuanGiangDayChuyenSangNckh", "SumTietnghiaVuGiangDay", "SumTietNghiaVuNckh", "SumTietNghiaVuQuanLy", "GhiChu", "MaGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy", "DinhMucToiThieuCuaChucVu", "TietGiangDayGiamDoChucVu", "TietNghiaVuQuanLyKiemNhiem", "SoTietGiamTruKhac", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "TietNo_BaoLuuQuanLy", "SumTietnghiaVuGiangDay", "SumTietNghiaVuNckh", "SumTietNghiaVuQuanLy", "MaGiangVien" });
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "MaGiangVien", "TietNghiaVuQuanLyKiemNhiem" });
            AppGridView.RegisterControlField(gridViewTietNghiaVu, "MaGiamTruKhac", repositoryItemGridLookUpEditGiamTruKhac);
            AppGridView.FixedField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen" }, FixedStyle.Left);
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietGiamTruKhac", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietnghiaVuGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietNghiaVuNckh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietNghiaVuQuanLy", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewTietNghiaVu.Columns["TenDonVi"].GroupIndex = 0;
            PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 45);
        }

        void InitGridDLU()
        {
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDayBanDau", "TietNghiaVuNckhBanDau", "DinhMucToiThieuCuaChucVu", "TietGiangDayDuocGiam", "TietNckhDuocGiam", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "SumTietnghiaVuGiangDay", "SumTietNghiaVuNckh", "MaGiangVien", "GhiChu" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Định mức GC giảng dạy", "Định mức GC NCKH", "Định mức do chức vụ (%)", "Tiết giảng dạy được giảm", "Tiết NCKH được giảm", "Giảm trừ khác", "Số tiết giảm khác", "Giờ chuẩn giảng dạy nợ/bảo lưu", "Giờ chuẩn NCKH nợ/bảo lưu", "Tổng giờ chuẩn giảng dạy", "Tổng giờ chuẩn NCKH", "MaGiangVien", "Ghi chú" }
                , new int[] { 100, 110, 130, 90, 80, 100, 90, 90, 90, 100, 90, 90, 90, 110, 100, 90, 90, 50, 500 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDayBanDau", "TietNghiaVuNckhBanDau", "DinhMucToiThieuCuaChucVu", "TietGiangDayDuocGiam", "TietNckhDuocGiam", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "SumTietnghiaVuGiangDay", "SumTietNghiaVuNckh", "MaGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDayBanDau", "TietNghiaVuNckhBanDau", "DinhMucToiThieuCuaChucVu", "TietGiangDayDuocGiam", "TietNckhDuocGiam", "SoTietGiamTruKhac", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "SumTietnghiaVuGiangDay", "SumTietNghiaVuNckh", "MaGiangVien" });
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "MaGiangVien", "MaGiamTruKhac", "SoTietGiamTruKhac" });
            AppGridView.RegisterControlField(gridViewTietNghiaVu, "MaGiamTruKhac", repositoryItemGridLookUpEditGiamTruKhac);
            AppGridView.FixedField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen" }, FixedStyle.Left);
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietnghiaVuGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietNghiaVuNckh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietGiamTruKhac", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewTietNghiaVu.Columns["TenDonVi"].GroupIndex = 0;
            PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 35);
        }
        #endregion

        #region InitData
        void InitData()
        {
            _listGiamTruKhac = DataServices.GiamTruDinhMuc.GetAll();
            bindingSourceGiamTruKhac.DataSource = _listGiamTruKhac;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.TietNghiaVu.GetByNamHoc(cboNamHoc.EditValue.ToString());
                tb.Load(reader);

                foreach (DataColumn col in tb.Columns)
                    col.ReadOnly = false;

                bindingSourceTietNghiaVu.DataSource = tb;

                gridViewTietNghiaVu.ExpandAllGroups();
            }
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTietNghiaVu.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable list = bindingSourceTietNghiaVu.DataSource as DataTable;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow kl in list.Rows)
                        {
                            if (kl.RowState == DataRowState.Modified)
                            {
                                xmlData += String.Format("<Input M=\"{0}\" G=\"{1}\" TG=\"{2}\" GD=\"{3}\" NC=\"{4}\" QL=\"{5}\" C=\"{6}\" GK=\"{7}\" NK=\"{8}\" />"
                                        , kl["MaGiangVien"]
                                        , PMS.Common.Globals.IsNull(kl["MaGiamTruKhac"], "int").ToString()
                                        , PMS.Common.Globals.IsNull(kl["SoTietGiamTruKhac"], "decimal")
                                        , PMS.Common.Globals.IsNull(kl["SumTietNghiaVuGiangDay"], "decimal")
                                        , PMS.Common.Globals.IsNull(kl["SumTietNghiaVuNckh"], "decimal")
                                        , PMS.Common.Globals.IsNull(kl["SumTietNghiaVuQuanly"], "decimal")
                                        , PMS.Common.Globals.IsNull(kl["GioChuanGiangDayChuyenSangNckh"], "decimal")
                                        , PMS.Common.Globals.IsNull(kl["TietGiamKhacGiangDay"], "decimal")
                                        , PMS.Common.Globals.IsNull(kl["TietGiamKhacNckh"], "decimal")
                                        );
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceTietNghiaVu.EndEdit();
                        int kq = 0;
                        DataServices.TietNghiaVu.LuuTietNghiaVu(xmlData, cboNamHoc.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepTietNghiaVu"))
            {
                frm.ShowDialog();
            }
            InitData();
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        #endregion

        private void gridViewTietNghiaVu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                int pos = e.RowHandle;

                if (_maTruong == "DLU")
                {
                    if (col.FieldName == "MaGiamTruKhac" || col.FieldName == "GioChuanGiangDayChuyenSangNckh")
                    {
                        DataRowView row = gridViewTietNghiaVu.GetRow(e.RowHandle) as DataRowView;
                        GiamTruDinhMuc g;

                        decimal? _tietNghiaVuGiangDay = 0, _tietGiangDayGiamDoChucVu, _tietGiangDayGiamKhac = 0, _tietKyTruoc, _reSult, _gioChuanGiangDayChuyenSangNckh, _tietNCKH
                                , _dinhMucNcKh, _noNckh, _tietNCKHGiamDoChucVu, _tietNCKHGiamKhac = 0, _tietGiangDayGiamDoTamNghi, _tietNckhGiamDoTamNghi;

                        _tietNghiaVuGiangDay = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNghiaVuGiangDay"], "decimal").ToString());
                        _tietGiangDayGiamDoChucVu = decimal.Parse(PMS.Common.Globals.IsNull(row["SubTietGiangDayGiamDoChucVu"], "decimal").ToString());
                        _tietNCKHGiamDoChucVu = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNckhGiamDoChucVu"], "decimal").ToString());
                        _tietKyTruoc = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNo_BaoLuuGiangDay"], "decimal").ToString());
                        _gioChuanGiangDayChuyenSangNckh = decimal.Parse(PMS.Common.Globals.IsNull(row["GioChuanGiangDayChuyenSangNckh"], "decimal").ToString());
                        _dinhMucNcKh = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNghiaVuNckh"], "decimal").ToString());
                        _noNckh = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNo_BaoLuuNcKh"], "decimal").ToString());
                        _tietGiangDayGiamDoTamNghi = decimal.Parse(PMS.Common.Globals.IsNull(row["SoTietGiangDayDuocGiamDoTamNghi"], "decimal").ToString());
                        _tietNckhGiamDoTamNghi = decimal.Parse(PMS.Common.Globals.IsNull(row["SoTietNckhDuocGiamDoTamNghi"], "decimal").ToString());

                        try
                        {
                            g = _listGiamTruKhac.Find(p => p.MaQuanLy == int.Parse(row["MaGiamTruKhac"].ToString()));

                            if (g.DonVi.ToLower() == "phantram")
                            {
                                _tietGiangDayGiamKhac = (_tietNghiaVuGiangDay * (g.MucGiam)) / 100;
                                _tietNCKHGiamKhac = (_dinhMucNcKh * g.MucGiamNckh) / 100;
                            }
                            else
                            {
                                _tietGiangDayGiamKhac = g.MucGiam;
                                _tietNCKHGiamKhac = g.MucGiamNckh;
                            }
                        }
                        catch
                        { }

                        _reSult = _tietNghiaVuGiangDay - _tietGiangDayGiamDoChucVu - _tietGiangDayGiamKhac - _tietKyTruoc - _gioChuanGiangDayChuyenSangNckh - _tietGiangDayGiamDoTamNghi;
                        _tietNCKH = _dinhMucNcKh - _tietNCKHGiamDoChucVu - _tietNCKHGiamKhac - _noNckh + _gioChuanGiangDayChuyenSangNckh - _tietNckhGiamDoTamNghi;
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SoTietGiamTruKhac", _tietGiangDayGiamKhac + _tietNCKHGiamKhac);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SumTietnghiaVuGiangDay", _reSult);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SumTietNghiaVuNckh", _tietNCKH);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "TietGiamKhacGiangDay", _tietGiangDayGiamKhac);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "TietGiamKhacNckh", _tietNCKHGiamKhac);
                    }
                }
                else
                {
                    if (col.FieldName == "MaGiamTruKhac" || col.FieldName == "GioChuanGiangDayChuyenSangNckh")
                    {
                        DataRowView row = gridViewTietNghiaVu.GetRow(e.RowHandle) as DataRowView;
                        GiamTruDinhMuc g;

                        decimal? _tietNghiaVuGiangDay = 0, _tietGiamDoChucVu, _tietGiamKhac = 0, _tietKyTruoc, _reSult, _gioChuanGiangDayChuyenSangNckh, _tietNCKH
                                , _dinhMucNcKh, _noNckh;

                        _tietNghiaVuGiangDay = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNghiaVuGiangDay"], "decimal").ToString());
                        _tietGiamDoChucVu = decimal.Parse(PMS.Common.Globals.IsNull(row["TietGiangDayGiamDoChucVu"], "decimal").ToString());
                        _tietKyTruoc = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNo_BaoLuuGiangDay"], "decimal").ToString());
                        _gioChuanGiangDayChuyenSangNckh = decimal.Parse(PMS.Common.Globals.IsNull(row["GioChuanGiangDayChuyenSangNckh"], "decimal").ToString());
                        _dinhMucNcKh = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNghiaVuNckh"], "decimal").ToString());
                        _noNckh = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNo_BaoLuuNcKh"], "decimal").ToString());

                        try
                        {
                            g = _listGiamTruKhac.Find(p => p.MaQuanLy == int.Parse(row["MaGiamTruKhac"].ToString()));

                            if (g.DonVi.ToLower() == "phantram")
                            {
                                _tietGiamKhac = (_tietNghiaVuGiangDay * (g.MucGiam)) / 100;
                            }
                            else
                            {
                                _tietGiamKhac = g.MucGiam;
                            }
                        }
                        catch
                        { }

                        _reSult = _tietNghiaVuGiangDay - _tietGiamDoChucVu - _tietGiamKhac - _tietKyTruoc - _gioChuanGiangDayChuyenSangNckh;
                        _tietNCKH = _dinhMucNcKh + _noNckh + _gioChuanGiangDayChuyenSangNckh;
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SoTietGiamTruKhac", _tietGiamKhac);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SumTietnghiaVuGiangDay", _reSult);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SumTietNghiaVuNckh", _tietNCKH);
                    }
                }
            }
            catch
            {}
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlTietNghiaVu.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
    }
}
