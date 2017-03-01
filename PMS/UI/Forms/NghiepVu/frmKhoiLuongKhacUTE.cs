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
using PMS.Services;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKhoiLuongKhacUTE : DevExpress.XtraEditors.XtraForm
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
        int kiemtra = 0;
        #endregion
        #region Event Form
        public frmKhoiLuongKhacUTE()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            if (_maTruong != "UTE")
                labelControl1.Visible = false;
        }

        private void frmKhoiLuongKhacUTE_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoiLuongKhac, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewKhoiLuongKhac, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewKhoiLuongKhac, new string[]{ "MaQuanLy", "MaMonHoc", "MaLoaiHocPhan", "MaLopHocPhan", "MaLop", "MaNhom", "SoTiet", "SoTuan", "SiSo", "SoTietQuyDoi", "DonGia", "GhiChu" }
                    , new string[]{ "Họ tên giảng viên", "Tên môn học", "Loại học phần", "Mã lớp học phần", "Mã lớp", "Mã nhóm", "Số tiết", "Số tuần", "Sĩ số", "Số tiết quy đổi", "Đơn giá", "Ghi chú" }
                    , new int[] { 150, 180, 80, 110, 90, 80, 70, 60, 50, 110, 100, 150 });
            AppGridView.AlignHeader(gridViewKhoiLuongKhac, new string[] { "MaQuanLy", "MaMonHoc", "MaLoaiHocPhan", "MaLopHocPhan", "MaLop", "MaNhom", "SoTiet", "SoTuan", "SiSo", "SoTietQuyDoi", "DonGia", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "MaQuanLy", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "MaLoaiHocPhan", repositoryItemGridLookUpEditLoaiHocPhan);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "SoTiet", repositoryItemSpinEditSoTiet);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "SoTuan", repositoryItemSpinEditSoTuan);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "SiSo", repositoryItemSpinEditSiSo);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.FormatDataField(gridViewKhoiLuongKhac, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.SummaryField(gridViewKhoiLuongKhac, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            #endregion
            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 250, 600);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã giảng viên", "Họ tên" }, new int[]{ 100, 150 });
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion
            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 510, 600);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenKhoa", "TenBoMon" }, new string[] { "Mã môn học", "Tên môn học", "STC", "Tên khoa", "Tên bộ môn" }, new int[] { 90, 150, 50, 120, 100 });
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "TenHienThi";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            #endregion
            #region LoaiHocPhan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiHocPhan, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLoaiHocPhan, 360, 600);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiHocPhan, new string[] { "MaLoaiHocPhan", "TenLoaiHocPhan", "VietTat", "DonViTinh" }, new string[] { "Mã loại học phần", "Tên loại học phần", "Viết tắt", "Đơn vị tính" }, new int[] { 100, 100, 80, 80 });
            repositoryItemGridLookUpEditLoaiHocPhan.ValueMember = "MaLoaiHocPhan";
            repositoryItemGridLookUpEditLoaiHocPhan.DisplayMember = "TenLoaiHocPhan";
            repositoryItemGridLookUpEditLoaiHocPhan.NullText = string.Empty;
            #endregion
            InitData();
        }
        #endregion
        #region InitData()
        void InitData()
        {
            bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetAll();
            bindingSourceMonHoc.DataSource = DataServices.ViewMonHocKhoa.GetAll();
            bindingSourceLoaiHocPhan.DataSource = DataServices.ViewLoaiHocPhan.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if(cboNamHoc.EditValue !=null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceKhoiLuongKhac.DataSource = DataServices.UteKhoiLuongKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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
            DataServices.ChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "KLK", ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AppGridView.DeleteSelectedRows(gridViewKhoiLuongKhac);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataServices.ChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "KLK", ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gridViewKhoiLuongKhac.FocusedRowHandle = -1;
            string xmlData = "";
            TList<UteKhoiLuongKhac> list = bindingSourceKhoiLuongKhac.DataSource as TList<UteKhoiLuongKhac>;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingSourceKhoiLuongKhac.EndEdit();
                foreach (UteKhoiLuongKhac klk in list)
                {
                    xmlData += "<UteKhoiLuongKhac Id = \"" + klk.Id
                                + "\" MaQuanLy = \"" + klk.MaQuanLy
                                + "\" MaMonHoc = \"" + klk.MaMonHoc
                                + "\" MaLoaiHocPhan = \"" + klk.MaLoaiHocPhan
                                + "\" MaLopHocPhan = \"" + klk.MaLopHocPhan
                                + "\" MaLop = \"" + klk.MaLop
                                + "\" MaNhom = \"" + klk.MaNhom
                                + "\" SoTiet = \"" + klk.SoTiet
                                + "\" SoTuan = \"" + klk.SoTuan
                                + "\" SiSo = \"" + klk.SiSo
                                + "\" SoTietQuyDoi = \"" + klk.SoTietQuyDoi
                                + "\" DonGia = \"" + klk.DonGia
                                + "\" GhiChu = \"" + klk.GhiChu
                                + "\" />";
                }
                xmlData = String.Format("<Root>{0}</Root>", xmlData);

                int kq = 0;
                DataServices.UteKhoiLuongKhac.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                if(kq == 0)
                    XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bindingSourceKhoiLuongKhac.DataSource = DataServices.UteKhoiLuongKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue.ToString() != "")
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue.ToString() != "" && cboHocKy.EditValue.ToString() != "")
                {
                    bindingSourceKhoiLuongKhac.DataSource = DataServices.UteKhoiLuongKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            catch 
            { }
           
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue.ToString() != "" && cboHocKy.EditValue.ToString() != "")
                {
                    bindingSourceKhoiLuongKhac.DataSource = DataServices.UteKhoiLuongKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            catch
            {  }
          
        }

        private void gridViewKhoiLuongKhac_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                if (col.FieldName == "MaQuanLy" || col.FieldName == "MaNhom")
                {
                    UteKhoiLuongKhac kl = gridViewKhoiLuongKhac.GetRow(e.RowHandle) as UteKhoiLuongKhac;
                    double _donGia = 0;
                    bool lopCLC = false;
                    if (kl.MaNhom == null) lopCLC = false;
                    else
                        if (kl.MaNhom.ToUpper().Contains("CL"))
                            lopCLC = true;
                    DataServices.DonGia.GetByMaQuanLyNamHocHocKyLopClc(kl.MaQuanLy, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lopCLC, ref _donGia);
                    gridViewKhoiLuongKhac.SetRowCellValue(e.RowHandle, "DonGia", _donGia);
                }
            }
            catch
            {}
        }
    }
}
