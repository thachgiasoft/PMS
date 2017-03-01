using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXetDuyetLuanVanCaoHoc : DevExpress.XtraEditors.XtraForm
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
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewGiangVien> _listGiangVien;
        #endregion
        public frmXetDuyetLuanVanCaoHoc()
        {
            InitializeComponent();
        }

        private void frmXetDuyetLuanVanCaoHoc_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewXetDuyet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewXetDuyet, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewXetDuyet, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaKhoaHoc", "SoLuong", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Khoá học", "Số lượng", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 90, 150, 160, 150, 90, 200, 99, 99 });
            AppGridView.AlignHeader(gridViewXetDuyet, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaKhoaHoc", "SoLuong", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewXetDuyet, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewXetDuyet, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewXetDuyet, "MaKhoaHoc", repositoryItemGridLookUpEditKhoaHoc);
            AppGridView.RegisterControlField(gridViewXetDuyet, "SoLuong", repositoryItemSpinEditSoLuong);
            AppGridView.HideField(gridViewXetDuyet, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.ReadOnlyColumn(gridViewXetDuyet, new string[] { "HoTen", "TenDonVi" });
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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien" },
                    new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Học hàm", "Học vị", "Loại giảng viên" }, new int[]{100, 150, 150, 100, 100, 100});
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 700, 650);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region KhoaHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditKhoaHoc, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditKhoaHoc, new string[] { "MaKhoaHoc", "TenKhoaHoc", "MaHeDaoTao", "MaBacDaoTao" },
                    new string[] { "Mã khoá học", "Tên khoá học", "Hệ đào tạo", "Bậc đào tạo" }, new int[] { 100, 200, 100, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditKhoaHoc, 500, 650);
            repositoryItemGridLookUpEditKhoaHoc.DisplayMember = "TenKhoaHoc";
            repositoryItemGridLookUpEditKhoaHoc.ValueMember = "MaKhoaHoc";
            repositoryItemGridLookUpEditKhoaHoc.NullText = string.Empty;
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceKhoaHoc.DataSource = DataServices.ViewKhoaHocBacHe.GetAll();
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceXetDuyet.DataSource = DataServices.ViewXetDuyetDeCuongLuanVanCaoHoc.GetBYNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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
            AppGridView.DeleteSelectedRows(gridViewXetDuyet);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kiemtra = 0;
            DataServices.XetDuyetDeCuongLuanVanCaoHoc.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng xét duyệt đề cương luận văn cao học năm học {0} - {1} đã bị chốt để thực hiện thanh toán thù lao. \nVui lòng liên hệ phòng KHTC để biết thêm chi tiết.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.WaitCursor;
                InitData();
                Cursor.Current = Cursors.Default;
                return;
            }
            gridViewXetDuyet.FocusedRowHandle = -1;
            VList<ViewXetDuyetDeCuongLuanVanCaoHoc> list = bindingSourceXetDuyet.DataSource as VList<ViewXetDuyetDeCuongLuanVanCaoHoc>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                            string xmlData = "";
                            foreach (ViewXetDuyetDeCuongLuanVanCaoHoc t in list)
                            {
                                xmlData += "<Input M=\"" + t.MaGiangVien
                                        + "\" MK=\"" + t.MaKhoaHoc
                                        + "\" S=\"" + t.SoLuong
                                        + "\" G=\"" + t.GhiChu
                                        + "\" N=\"" + t.NgayCapNhat
                                        + "\" U=\"" + t.NguoiCapNhat
                                        + "\" />";
                            }
                            xmlData = String.Format("<Root>{0}</Root>", xmlData);
                            bindingSourceXetDuyet.EndEdit();
                            int kq = 0;
                            DataServices.XetDuyetDeCuongLuanVanCaoHoc.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                            if (kq == 0)
                                XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                InitData();
                Cursor.Current = Cursors.Default;
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
                        gridControlXetDuyet.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceXetDuyet.DataSource = DataServices.ViewXetDuyetDeCuongLuanVanCaoHoc.GetBYNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceXetDuyet.DataSource = DataServices.ViewXetDuyetDeCuongLuanVanCaoHoc.GetBYNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void gridViewXetDuyet_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien" || col.FieldName == "MaKhoaHoc" || col.FieldName == "SoLuong" || col.FieldName == "GhiChu")
            {
                gridViewXetDuyet.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewXetDuyet.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
            if (col.FieldName == "MaGiangVien")
            {
                ViewXetDuyetDeCuongLuanVanCaoHoc v = gridViewXetDuyet.GetRow(e.RowHandle) as ViewXetDuyetDeCuongLuanVanCaoHoc;
                ViewGiangVien gv = _listGiangVien.Find(p=>p.MaGiangVien == v.MaGiangVien);
                gridViewXetDuyet.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                gridViewXetDuyet.SetRowCellValue(e.RowHandle, "TenDonVi", gv.TenDonVi);
            }
        }

        private void gridViewXetDuyet_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewXetDuyet, e);
        }

    }
}