using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVienNghienCuuKhoaHoc : DevExpress.XtraEditors.XtraForm
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
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        VList<ViewGiangVien> _listGiangVien;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        TList<DanhMucNghienCuuKhoaHoc> _danhMucNCKH;
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public frmGiangVienNghienCuuKhoaHoc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void frmGiangVienNghienCuuKhoaHoc_Load(object sender, EventArgs e)
        {
            #region InitGridView
            switch (_maTruong)
            { 
                case "VHU"://Giữ nguyên, ko dùng riêng
                    InitRemaining();
                    break;
                default:
                    InitRemaining();
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

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" },
                    new string[] { "Mã giảng viên", "Họ tên", "Bộ môn" }, new int[] { 100, 150, 180 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 430, 650);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion
            #region DanhMuc NCKH
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDanhMucNCKH, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDanhMucNCKH, new string[] { "MaQuanLy", "TenNghienCuuKhoaHoc", "SoTiet", "GhiChu" },
                    new string[] { "Mã NCKH", "Tên nghiên cứu khoa học", "Số tiết", "Chi chú" }, new int[] { 100, 280, 100, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDanhMucNCKH, 500, 650);
            repositoryItemGridLookUpEditDanhMucNCKH.DisplayMember = "TenNghienCuuKhoaHoc";
            repositoryItemGridLookUpEditDanhMucNCKH.ValueMember = "Id";
            repositoryItemGridLookUpEditDanhMucNCKH.NullText = string.Empty;
            #endregion
            InitData();
        }
        #region InitData
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            _danhMucNCKH = DataServices.DanhMucNghienCuuKhoaHoc.GetAll();
            bindingSourceDanhMucNCKH.DataSource = _danhMucNCKH;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceGiangVienNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNckh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }
        #endregion

        #region InitGrid
        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewGiangVienNCKH, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewGiangVienNCKH, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TenNghienCuuKhoaHoc", "SoTiet", "NgayCapNhat", "NguoiCapNhat" },
                                    new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Tên nghiên cứu khoa học", "Số tiết", "Ngày cập nhật", "Người cập nhật" },
                                    new int[] { 90, 150, 200, 250, 100, 99, 99 });
            AppGridView.ShowEditor(gridViewGiangVienNCKH, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.SummaryField(gridViewGiangVienNCKH, "MaGiangVien", "Tổng số lớp: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.AlignHeader(gridViewGiangVienNCKH, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TenNghienCuuKhoaHoc", "SoTiet", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewGiangVienNCKH, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.RegisterControlField(gridViewGiangVienNCKH, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.SummaryField(gridViewGiangVienNCKH, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewGiangVienNCKH, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewGiangVienNCKH, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "Id", "SoTiet", "NgayCapNhat", "NguoiCapNhat" },
                                    new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Tên nghiên cứu khoa học", "Số tiết", "Ngày cập nhật", "Người cập nhật" },
                                    new int[] { 90, 150, 200, 250, 100, 99, 99 });
            AppGridView.ShowEditor(gridViewGiangVienNCKH, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.SummaryField(gridViewGiangVienNCKH, "MaGiangVien", "Tổng số lớp: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.AlignHeader(gridViewGiangVienNCKH, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "Id", "SoTiet", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewGiangVienNCKH, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.RegisterControlField(gridViewGiangVienNCKH, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewGiangVienNCKH, "Id", repositoryItemGridLookUpEditDanhMucNCKH);

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienNCKH);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewGiangVienNCKH.FocusedRowHandle = -1;
            VList<ViewGiangVienNckh> list = bindingSourceGiangVienNghienCuuKhoaHoc.DataSource as VList<ViewGiangVienNckh>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        bindingSourceGiangVienNghienCuuKhoaHoc.EndEdit();
                        string xmlData = "";
                        int kq = 0;

                        foreach (ViewGiangVienNckh v in list)
                        {
                            if ((int)PMS.Common.Globals.IsNull(v.MaGiangVien, "int") != 0 && (int)PMS.Common.Globals.IsNull(v.Id, "int") != 0)
                            {
                                xmlData += String.Format("<Input M=\"{0}\" Id=\"{1}\" S=\"{2}\" D=\"{3}\" U=\"{4}\" />", v.MaGiangVien, v.Id, v.SoTiet, v.NgayCapNhat, v.NguoiCapNhat);
                            }
                            else
                            {
                                XtraMessageBox.Show("Vui lòng nhập đủ thông tin giảng viên và loại NCKH.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);

                        DataServices.GiangVienNghienCuuKh.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);

                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        InitData();
                        Cursor.Current = Cursors.Default;
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                            gridControlGiangVienNCKH.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
        #endregion
        #region Event Grid
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceGiangVienNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNckh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceGiangVienNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNckh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewGiangVienNCKH_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienNCKH, e);
        }

        private void gridViewGiangVienNCKH_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                ViewGiangVienNckh nckh = gridViewGiangVienNCKH.GetRow(e.RowHandle) as ViewGiangVienNckh;
                string _hoTen = _listGiangVien.Find(p => p.MaGiangVien == nckh.MaGiangVien).HoTen;
                string _tenDonVi = _listGiangVien.Find(p => p.MaGiangVien == nckh.MaGiangVien).TenDonVi;
                gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "HoTen", _hoTen);
                gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "TenDonVi", _tenDonVi);
            }

            if (col.FieldName == "Id")
            {
                ViewGiangVienNckh nckh = gridViewGiangVienNCKH.GetRow(e.RowHandle) as ViewGiangVienNckh;
                decimal? _sotiet = _danhMucNCKH.Find(p => p.Id == nckh.Id).SoTiet;
                gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "SoTiet", _sotiet);
            }

            if (col.FieldName == "MaGiangVien" || col.FieldName == "Id" || col.FieldName == "SoTiet" || col.FieldName == "TenNghienCuuKhoaHoc")
            {
                gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
        #endregion
    }
}