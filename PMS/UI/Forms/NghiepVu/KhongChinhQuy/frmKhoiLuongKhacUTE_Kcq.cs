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
using System.Reflection;

namespace PMS.UI.Forms.NghiepVu.KhongChinhQuy
{
    public partial class frmKhoiLuongKhacUTE_Kcq : DevExpress.XtraEditors.XtraForm
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
        TList<KcqHeSoDiaDiem> _listDiaDiem;
        string _maTruong;
        int kiemtra = 0;
        #endregion

        #region Event Form
        public frmKhoiLuongKhacUTE_Kcq()
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
            AppGridView.ShowField(gridViewKhoiLuongKhac, new string[]{ "MaQuanLy", "MaMonHoc", "MaLoaiHocPhan", "MaLopHocPhan", "MaLop","MaDiaDiem","TenDiaDiem","TienXeDiaDiem", "MaNhom", "SoTiet", "SoTuan", "SiSo", "SoTietQuyDoi", "DonGia", "GhiChu" }
                    , new string[] { "Họ tên giảng viên", "Tên môn học", "Loại học phần", "Mã lớp học phần", "Mã lớp", "Mã địa điểm", "Tên địa điểm", "Tiền xe địa điểm", "Mã nhóm", "Số tiết", "Số tuần", "Sĩ số", "Số tiết quy đổi", "Đơn giá", "Ghi chú" }
                    , new int[] { 150, 180, 80, 110, 90,90,150,90, 80, 70, 60, 50, 110, 100, 150 });
            AppGridView.AlignHeader(gridViewKhoiLuongKhac, new string[] { "MaQuanLy", "MaMonHoc", "MaLoaiHocPhan", "MaLopHocPhan", "MaLop", "MaDiaDiem", "TenDiaDiem", "TienXeDiaDiem", "MaNhom", "SoTiet", "SoTuan", "SiSo", "SoTietQuyDoi", "DonGia", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "MaQuanLy", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "MaLoaiHocPhan", repositoryItemGridLookUpEditLoaiHocPhan);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "MaDiaDiem", repositoryItemGridLookUpEditMaDiaDiem);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "SoTiet", repositoryItemSpinEditSoTiet);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "SoTuan", repositoryItemSpinEditSoTuan);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "SiSo", repositoryItemSpinEditSiSo);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.FormatDataField(gridViewKhoiLuongKhac, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongKhac, "TienXeDiaDiem", DevExpress.Utils.FormatType.Custom, "n0");
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
            #region MaDiaDiem
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMaDiaDiem, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMaDiaDiem, 360, 600);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMaDiaDiem, new string[] { "MaQuanLy", "TenDiaDiem", "HeSoDiaDiem", "DonGia", "TienXeDiaDiem" }, new string[] { "Mã địa điểm", "Tên địa điểm", "Hệ số địa điểm", "Đơn giá", "Tiền xe địa điểm" }, new int[] { 100, 150, 80, 80,90});
            repositoryItemGridLookUpEditMaDiaDiem.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditMaDiaDiem.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditMaDiaDiem.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region InitData()
        void InitData()
        {
            gridViewKhoiLuongKhac.FocusedRowHandle = -1;
    
            bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetAll();
            bindingSourceMonHoc.DataSource = DataServices.ViewMonHocKhoa.GetAll();
            bindingSourceLoaiHocPhan.DataSource = DataServices.ViewLoaiHocPhan.GetAll();
            bindingSourceDiaDiem.DataSource = DataServices.KcqHeSoDiaDiem.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            _listDiaDiem = DataServices.KcqHeSoDiaDiem.GetAll();

            if(cboNamHoc.EditValue !=null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable dt = new DataTable();
                dt.Load(DataServices.KcqUteKhoiLuongKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                bindingSourceKhoiLuongKhac.DataSource = dt;
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
            DataServices.KcqChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "KLK", ref kiemtra);
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
            DataServices.KcqChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "KLK", ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gridViewKhoiLuongKhac.FocusedRowHandle = -1;
            string xmlData = "";


            DataTable dt = bindingSourceKhoiLuongKhac.DataSource as DataTable;
        
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bindingSourceKhoiLuongKhac.EndEdit();
                foreach (DataRow klk in dt.Rows)
                {
                    xmlData += "<KcqUteKhoiLuongKhac Id = \"" + klk["Id"].ToString()
                                + "\" MaQuanLy = \"" + klk["MaQuanLy"].ToString()
                                + "\" MaMonHoc = \"" + klk["MaMonHoc"].ToString()
                                + "\" MaLoaiHocPhan = \"" + klk["MaLoaiHocPhan"].ToString()
                                + "\" MaLopHocPhan = \"" + klk["MaLopHocPhan"].ToString()
                                + "\" MaLop = \"" + klk["MaLop"].ToString()
                                + "\" MaNhom = \"" + klk["MaNhom"].ToString()
                                + "\" SoTiet = \"" + klk["SoTiet"].ToString()
                                + "\" SoTuan = \"" + klk["SoTuan"].ToString()
                                + "\" SiSo = \"" + klk["SiSo"].ToString()
                                + "\" SoTietQuyDoi = \"" + klk["SoTietQuyDoi"].ToString()
                                + "\" DonGia = \"" + klk["DonGia"].ToString()
                                + "\" GhiChu = \"" + klk["GhiChu"].ToString()
                                + "\" MaDiaDiem = \"" + klk["MaDiaDiem"].ToString()
                                + "\" />";
                }
                xmlData = String.Format("<Root>{0}</Root>", xmlData);

                int kq = 0;
                DataServices.KcqUteKhoiLuongKhac.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                if(kq == 0)
                    XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            {
                DataTable tb = new DataTable();
                tb.Load(DataServices.KcqUteKhoiLuongKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                bindingSourceKhoiLuongKhac.DataSource = tb;
            }

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
                    DataTable dt = new DataTable();
                    dt.Load(DataServices.KcqUteKhoiLuongKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                    bindingSourceKhoiLuongKhac.DataSource = dt;
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
                    DataTable dt = new DataTable();
                    dt.Load(DataServices.KcqUteKhoiLuongKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                    bindingSourceKhoiLuongKhac.DataSource = dt;
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
                int pos = e.RowHandle;
                DataRowView kl = gridViewKhoiLuongKhac.GetRow(e.RowHandle) as DataRowView;

                if (col.FieldName == "MaQuanLy" || col.FieldName == "MaNhom")
                {
                    
                    double _donGia = 0;
                    bool lopCLC = false;
                    if (kl["MaNhom"].ToString().ToUpper().Contains("CL"))
                            lopCLC = true;
                    DataServices.KcqDonGia.GetByMaQuanLyNamHocHocKyLopClc(kl["MaQuanLy"].ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lopCLC, ref _donGia);
                    gridViewKhoiLuongKhac.SetRowCellValue(e.RowHandle, "DonGia", _donGia);
                }

                if (col.FieldName == "MaDiaDiem")
                {
                    string _tenDiaDiem = _listDiaDiem.Find(p => p.MaQuanLy == kl["MaDiaDiem"].ToString()).TenDiaDiem;
                    decimal? _tienxeDiaDiem = _listDiaDiem.Find(p => p.MaQuanLy == kl["MaDiaDiem"].ToString()).TienXeDiaDiem;
                    gridViewKhoiLuongKhac.SetRowCellValue(e.RowHandle, "TenDiaDiem", _tenDiaDiem);
                    gridViewKhoiLuongKhac.SetRowCellValue(e.RowHandle, "TienXeDiaDiem", _tienxeDiaDiem);
                    gridViewKhoiLuongKhac.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now);
                }

                if (kl["MaLoaiHocPhan"].ToString() != "" && (col.FieldName == "MaMonHoc" || col.FieldName == "MaLoaiHocPhan"))
                {
                    DataTable tb = new DataTable();
                    tb.Load(DataServices.ViewMonHoc.GetSoTietMonHoc(kl["MaMonHoc"].ToString(), kl["MaLoaiHocPhan"].ToString()));
                    gridViewKhoiLuongKhac.SetRowCellValue(e.RowHandle, "SoTiet", tb.Rows[0]["VaLue"]);
                }
            }
            catch
            {}
        }
    }
}
