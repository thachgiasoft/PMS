using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucThoiGianNghiTamThoiCuaGiangVien : DevExpress.XtraEditors.XtraUserControl
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
        string _maTruong, _cauHinhHeSoTheoNam;
        VList<ViewHocKy> _listHocKy;
        #endregion

        public ucThoiGianNghiTamThoiCuaGiangVien()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucThoiGianNghiTamThoiCuaGiangVien_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewThoiGian, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThoiGian, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThoiGian, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaGiamTruDinhMuc", "TuNgay", "DenNgay", "GioChuanHk01", "GioChuanHk02", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Lý do", "Từ ngày", "Đến ngày", "Giờ chuẩn HK01", "Giờ chuẩn HK02", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 70, 150, 160, 200, 75, 75, 100, 100, 200, 100, 100 });
            AppGridView.AlignHeader(gridViewThoiGian, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaGiamTruDinhMuc", "TuNgay", "DenNgay", "GioChuanHk01", "GioChuanHk02", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewThoiGian, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            AppGridView.RegisterControlField(gridViewThoiGian, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewThoiGian, "MaGiamTruDinhMuc", repositoryItemGridLookUpEditLyDo);
            AppGridView.RegisterControlField(gridViewThoiGian, "TuNgay", repositoryItemDateEditTuNgay);
            AppGridView.RegisterControlField(gridViewThoiGian, "DenNgay", repositoryItemDateEditDenNgay);
            #endregion

            #region Năm học
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Bộ môn" }, new int[] { 90, 170, 240 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 500, 650);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region LyDoNghi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLyDo, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLyDo, new string[] { "NoiDungGiamTru", "MucGiam", "DonVi" }, new string[] { "Lý do", "Mức giảm", "Đơn vị" }, new int[] { 250, 70, 80 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLyDo, 400, 650);
            repositoryItemGridLookUpEditLyDo.DisplayMember = "NoiDungGiamTru";
            repositoryItemGridLookUpEditLyDo.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditLyDo.NullText = string.Empty;
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceLyDo.DataSource = DataServices.GiamTruDinhMuc.GetAll();

            if (cboNamHoc.EditValue != null)
            {
                bindingSourceThoiGian.DataSource = DataServices.ViewThoiGianNghiTamThoiCuaGiangVien.GetByNamHoc(cboNamHoc.EditValue.ToString());
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
            AppGridView.DeleteSelectedRows(gridViewThoiGian);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThoiGian.FocusedRowHandle = -1;
            VList<ViewThoiGianNghiTamThoiCuaGiangVien> list = bindingSourceThoiGian.DataSource as VList<ViewThoiGianNghiTamThoiCuaGiangVien>;
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (ViewThoiGianNghiTamThoiCuaGiangVien v in list)
                        {
                            if(v.TuNgay != null && v.DenNgay != null)
                            {
                                xmlData += "<Input Id=\"" + v.Id
                                        + "\" M=\"" + v.MaGiangVien
                                        + "\" G=\"" + v.MaGiamTruDinhMuc
                                        + "\" Tu=\"" + ((DateTime)v.TuNgay).ToString("dd/MM/yyyy")
                                        + "\" Den=\"" + ((DateTime)v.DenNgay).ToString("dd/MM/yyyy")
                                        + "\" D=\"" + v.NgayCapNhat
                                        + "\" U=\"" + v.NguoiCapNhat
                                        + "\" H1=\"" + PMS.Common.Globals.IsNull(v.GioChuanHk01, "decimal")
                                        + "\" H2=\"" + PMS.Common.Globals.IsNull(v.GioChuanHk02, "decimal")
                                        + "\" GC=\"" + v.GhiChu
                                        + "\" />";
                            }
                            else
                            {
                                XtraMessageBox.Show("Thời gian từ ngày, đến ngày không được phép bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        xmlData="<Root>" + xmlData + "</Root>";
                        bindingSourceThoiGian.EndEdit();
                        int kq = 0;
                        DataServices.ThoiGianNghiTamThoiCuaGiangVien.LuuTheoNamHoc(xmlData, cboNamHoc.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlThoiGian.ExportToXls(sf.FileName);
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
                bindingSourceThoiGian.DataSource = DataServices.ViewThoiGianNghiTamThoiCuaGiangVien.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
        }

        private void gridViewThoiGian_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                ViewThoiGianNghiTamThoiCuaGiangVien v = gridViewThoiGian.GetRow(e.RowHandle) as ViewThoiGianNghiTamThoiCuaGiangVien;
                ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == v.MaGiangVien);
                gridViewThoiGian.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                gridViewThoiGian.SetRowCellValue(e.RowHandle, "TenDonVi", gv.TenDonVi);
            }
            if (col.FieldName == "MaGiangVien" || col.FieldName == "MaGiamTruDinhMuc" || col.FieldName == "TuNgay" || col.FieldName == "DenNgay")
            {
                gridViewThoiGian.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewThoiGian.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewThoiGian_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThoiGian);
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (_cauHinhHeSoTheoNam.ToLower() == "true")
            //{
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepThoiGianNghiTamThoi"))
                {
                    frm.ShowDialog();
                }
            //}
            InitData();
        }
    }
}
