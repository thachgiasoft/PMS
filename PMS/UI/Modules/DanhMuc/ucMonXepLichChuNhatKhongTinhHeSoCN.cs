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
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucMonXepLichChuNhatKhongTinhHeSoCN : DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewMonHocKhoa> _listMonHoc;
        #endregion
        public ucMonXepLichChuNhatKhongTinhHeSoCN()
        {
            InitializeComponent();
        }

        private void ucMonXepLichChuNhatKhongTinhHeSoCN_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewData, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewData, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewData, new string[] { "MaGiangVien", "HoTen", "MaMonHoc", "TenMonHoc", "MaLoaiHocPhan", "NgayCapNhat" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Mã môn học", "Tên môn học", "Loại học phần", "Ngày cập nhật" }
                    , new int[] { 90, 150, 90, 150, 100, 100 });
            AppGridView.AlignHeader(gridViewData, new string[] { "MaGiangVien", "HoTen", "MaMonHoc", "TenMonHoc", "MaLoaiHocPhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewData, new string[] { "HoTen", "TenMonHoc" });
            AppGridView.RegisterControlField(gridViewData, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewData, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.RegisterControlField(gridViewData, "MaLoaiHocPhan", repositoryItemGridLookUpEditLoaiHocPhan);
            AppGridView.HideField(gridViewData, new string[] { "NgayCapNhat" });
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
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Đơn vị" }, new int[] { 90, 150, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 360, 600);
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenKhoa", "TenBoMon" }, new string[] { "Mã môn học", "Tên môn học", "STC", "Khoa", "Bộ môn" }, new int[] { 90, 150, 50, 120, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 530, 600);
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            #endregion

            #region LoaiHocPhan 
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiHocPhan, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiHocPhan, new string[] { "MaLoaiHocPhan", "TenLoaiHocPhan", "VietTat" }, new string[] { "Mã loại học phần", "Tên loại học phần", "Viết tắt" }, new int[] { 100, 120, 80 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLoaiHocPhan, 300, 600);
            repositoryItemGridLookUpEditLoaiHocPhan.ValueMember = "MaLoaiHocPhan";
            repositoryItemGridLookUpEditLoaiHocPhan.DisplayMember = "TenLoaiHocPhan";
            repositoryItemGridLookUpEditLoaiHocPhan.NullText = string.Empty;
            #endregion
            InitData();
        }
        #region InitData
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            _listMonHoc = DataServices.ViewMonHocKhoa.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceMonHoc.DataSource = _listMonHoc;
            bindingSourceLoaiHocPhan.DataSource = DataServices.ViewLoaiHocPhan.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceData.DataSource = DataServices.ViewMonXepLichChuNhatKhongTinhHeSo.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewData);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewData.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VList<ViewMonXepLichChuNhatKhongTinhHeSo> list = bindingSourceData.DataSource as VList<ViewMonXepLichChuNhatKhongTinhHeSo>;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (ViewMonXepLichChuNhatKhongTinhHeSo kl in list)
                        {
                            if (kl.MaLoaiHocPhan == null)
                            {
                                XtraMessageBox.Show("Thông báo", "Thông tin loại học phần không được bỏ trống. Vui lòng chọn loại học phần.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (kl.MaGiangVien != null)
                            {
                                xmlData += String.Format("<Input M=\"{0}\" Mh=\"{1}\" L=\"{2}\" N=\"{3:yyyy/MM/dd HH:mm:ss}\" Id=\"{4}\" />", kl.MaGiangVien, kl.MaMonHoc, kl.MaLoaiHocPhan, (DateTime)kl.NgayCapNhat, kl.Id);
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceData.EndEdit();
                        int kq = 0;
                        DataServices.MonXepLichChuNhatKhongTinhHeSo.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
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
            Cursor.Current = Cursors.Default;
        }

        private void gridViewData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            if (col.FieldName == "MaGiangVien")
            {
                ViewMonXepLichChuNhatKhongTinhHeSo v = (ViewMonXepLichChuNhatKhongTinhHeSo)gridViewData.GetRow(pos);
                string _hoTen = _listGiangVien.Find(p => p.MaGiangVien == v.MaGiangVien).HoTen;
                gridViewData.SetRowCellValue(pos, "HoTen", _hoTen);
                gridViewData.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now);
            }
            if (col.FieldName == "MaMonHoc")
            {
                ViewMonXepLichChuNhatKhongTinhHeSo v = (ViewMonXepLichChuNhatKhongTinhHeSo)gridViewData.GetRow(pos);
                string _tenMonHoc = _listMonHoc.Find(p => p.MaMonHoc == v.MaMonHoc).TenMonHoc;
                gridViewData.SetRowCellValue(pos, "TenMonHoc", _tenMonHoc);
                gridViewData.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now);
            }
        }

        string IsNull(object o)
        {
            if (o == null)
                return "";
            else return o.ToString();
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceData.DataSource = DataServices.ViewMonXepLichChuNhatKhongTinhHeSo.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceData.DataSource = DataServices.ViewMonXepLichChuNhatKhongTinhHeSo.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlData.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}
