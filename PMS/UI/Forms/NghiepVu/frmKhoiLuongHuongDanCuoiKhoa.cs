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
using PMS.BLL;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKhoiLuongHuongDanCuoiKhoa : DevExpress.XtraEditors.XtraForm
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
        string _maTruong;
        private string groupname = UserInfo.GroupName;
        #endregion
        public frmKhoiLuongHuongDanCuoiKhoa()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmKhoiLuongHuongDanCuoiKhoa_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewKhoiLuong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewKhoiLuong, new string[] { "MaGiangVienQuanLy", "HuongDanVietBaoCaoTotNghiep", "HuongDanChuyenDeThucTapTotNghiep", "HuongDanKhoaLuanTotNghiep", "PhanBienKhoaLuanTotNghiep", "SoLuongThamGiaHoiDongTotNghiep", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Họ tên", "Hướng dẫn viết BCTN", "Hướng dẫn chuyên đề TTTN", "Hướng dẫn khoá luận TN", "Phản biện khoá luận TN", "Tham gia hội đồng TN", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 200, 150, 160, 150, 150, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "MaGiangVienQuanLy", "HuongDanVietBaoCaoTotNghiep", "HuongDanChuyenDeThucTapTotNghiep", "HuongDanKhoaLuanTotNghiep", "PhanBienKhoaLuanTotNghiep", "SoLuongThamGiaHoiDongTotNghiep", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuong, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewKhoiLuong, "MaGiangVienQuanLy", repositoryItemGridLookUpEditGiangVien);
            AppGridView.HideField(gridViewKhoiLuong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
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
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen" },
                    new string[] { "Mã giảng viên", "Họ tên" });
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }
        void InitData()
        {
            bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetByNhomQuyen(groupname);
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceKhoiLuong.DataSource = DataServices.ThuLaoHuongDanCuoiKhoa.GetByNamHocHocKyNhomQuyen(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), groupname);
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
            AppGridView.DeleteSelectedRows(gridViewKhoiLuong);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kiemtra = 0;
            DataServices.ThuLaoHuongDanCuoiKhoa.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng hướng dẫn cuối khoá năm học {0} - {1} đã bị chốt để thực hiện thanh toán thù lao. \nVui lòng liên hệ phòng KHTC để biết thêm chi tiết.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.WaitCursor;
                InitData();
                Cursor.Current = Cursors.Default;
                return;
            }
            gridViewKhoiLuong.FocusedRowHandle = -1;
            TList<ThuLaoHuongDanCuoiKhoa> list = bindingSourceKhoiLuong.DataSource as TList<ThuLaoHuongDanCuoiKhoa>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            string xmlData = "";
                            foreach (ThuLaoHuongDanCuoiKhoa t in list)
                            {
                                xmlData += "<Input M=\"" + t.MaGiangVienQuanLy
                                        + "\" B=\"" + t.HuongDanVietBaoCaoTotNghiep
                                        + "\" C=\"" + t.HuongDanChuyenDeThucTapTotNghiep
                                        + "\" K=\"" + t.HuongDanKhoaLuanTotNghiep
                                        + "\" P=\"" + t.PhanBienKhoaLuanTotNghiep
                                        + "\" S=\"" + t.SoLuongThamGiaHoiDongTotNghiep
                                        + "\" N=\"" + t.NgayCapNhat
                                        + "\" U=\"" + t.NguoiCapNhat
                                        + "\" />";
                            }
                            xmlData = String.Format("<Root>{0}</Root>", xmlData);
                            bindingSourceKhoiLuong.EndEdit();
                            int kq = 0;
                            DataServices.ThuLaoHuongDanCuoiKhoa.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), groupname, ref kq);
                            if (kq == 0)
                                XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlKhoiLuong.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceKhoiLuong.DataSource = DataServices.ThuLaoHuongDanCuoiKhoa.GetByNamHocHocKyNhomQuyen(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), groupname);
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceKhoiLuong.DataSource = DataServices.ThuLaoHuongDanCuoiKhoa.GetByNamHocHocKyNhomQuyen(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), groupname);
            }
        }

        private void gridViewKhoiLuong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoiLuong, e);
        }

        private void gridViewKhoiLuong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVienQuanLy" || col.FieldName == "HuongDanVietBaoCaoTotNghiep" || col.FieldName == "HuongDanChuyenDeThucTapTotNghiep" || col.FieldName == "HuongDanKhoaLuanTotNghiep" || col.FieldName == "PhanBienKhoaLuanTotNghiep" || col.FieldName == "SoLuongThamGiaHoiDongTotNghiep")
            {
                gridViewKhoiLuong.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewKhoiLuong.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
    }
}