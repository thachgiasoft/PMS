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
//using Libraries.DevEx;
//using Libraries.BLL;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Core;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVienGiamDinhMuc : DevExpress.XtraEditors.XtraForm
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

        VList<ViewGiangVien> _listGiangVien;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _groupName = UserInfo.GroupName;
        bool _userRole;
        DataTable _dtData;
        public frmGiangVienGiamDinhMuc()
        {
            InitializeComponent();
        }

        private void frmGiangVienGiamDinhMuc_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewGiangVienGDM, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true
                , "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewGiangVienGDM, new string[] { "MaGiangVien", "HoTen", "MaDinhMucKhauTru", "NgayCapNhat", "NguoiCapNhat" },
                                    new string[] { "Mã giảng viên", "Họ tên", "Tên định mức", "Ngày cập nhật", "Người cập nhật" },
                                    new int[] { 90, 150, 250, 100, 99, 99 });
            AppGridView.ShowEditor(gridViewGiangVienGDM, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.SummaryField(gridViewGiangVienGDM, "MaGiangVien", "Tổng số lớp: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.AlignHeader(gridViewGiangVienGDM, new string[] { "MaGiangVien", "HoTen", "MaDinhMucKhauTru"
                , "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewGiangVienGDM, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.RegisterControlField(gridViewGiangVienGDM, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewGiangVienGDM, "MaDinhMucKhauTru", repositoryItemGridLookUpEditDanhMucGiamTru);
            AppGridView.ReadOnlyColumn(gridViewGiangVienGDM, new string[] { "HoTen" });
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

            #region danh Muc Giam Tru
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDanhMucGiamTru, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDanhMucGiamTru, new string[] { "MaQuanLy", "NoiDungGiamTru" },
                    new string[] { "Mã quản lý", "Nội dung giảm trừ" }, new int[] { 100, 300 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDanhMucGiamTru, 400, 650);
            repositoryItemGridLookUpEditDanhMucGiamTru.DisplayMember = "NoiDungGiamTru";
            repositoryItemGridLookUpEditDanhMucGiamTru.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditDanhMucGiamTru.NullText = string.Empty;
            #endregion

            #region Khoa bộ môn
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã bộ môn", "Tên bộ môn" });
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;

            #endregion

            InitData();
        }
        #region InitData
        void InitData()
        {
           
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            
            bindingSourceDanhMucGiamTru.DataSource = DataServices.GiamTruDinhMuc.GetAll();

            cboKhoaDonVi.DataBindings.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    _userRole = true;
                    break;
                }
                else
                {
                    _userRole = false;
                }
            }


            if (_userRole)
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
            }
            else
            {
                _vListKhoaBoMon.Add(new ViewKhoaBoMon() { ThuTu = 0, MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            }

            bindingSourceKhoaDonVi.DataSource = _vListKhoaBoMon;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                bindingSourceGiangVien.DataSource = _listGiangVien;
            }

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienDinhMucKhauTru.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dt.Load(reader);
                _dtData = dt;
                _dtData.Columns["MaDinhMucKhauTru"].ReadOnly = false;
                bindingSourceGiangVienNghienCuuKhoaHoc.DataSource = _dtData;
            }
        }
        #endregion

        private void gridViewGiangVienGDM_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                //_dtData.SetReadOnly(false);
                DataRow drCurr = gridViewGiangVienGDM.GetDataRow(e.RowHandle);
                string _hoTen = _listGiangVien.Find(p => p.MaGiangVien == (int)drCurr["MaGiangVien"]).HoTen;

                drCurr["HoTen"] = _hoTen;
                drCurr["NamHoc"] = cboNamHoc.EditValue.ToString();
                drCurr["HocKy"] = cboHocKy.EditValue.ToString();
            }

            if (col.FieldName == "MaGiangVien")
            {
                gridViewGiangVienGDM.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewGiangVienGDM.SetRowCellValue(e.RowHandle, "NguoiCapNhat", PMS.BLL.UserInfo.UserName);
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
        }

        private void btnLuu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewGiangVienGDM.FocusedRowHandle = -1;
            string XMLData = "<Root>";
            DataTable list = bindingSourceGiangVienNghienCuuKhoaHoc.DataSource as DataTable;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingSourceGiangVienNghienCuuKhoaHoc.EndEdit();
                foreach (DataRow v in list.Rows)
                {
                    if (v.RowState != DataRowState.Deleted)
                    {
                        XMLData += "<GiangVien_DinhMucKhauTru MaGiangVien = \"" + v["MaGiangVien"]
                                            + "\" MaDinhMucKhauTru = \"" + v["MaDinhMucKhauTru"]
                                            + "\" NgayCapNhat = \"" + v["NgayCapNhat"]
                                            + "\" NguoiCapNhat = \"" + v["NguoiCapNhat"]
                                            + "\" />";
                    }
                }
                XMLData += "</Root>";

                int kq = 0;

                DataServices.GiangVienDinhMucKhauTru.LuuTheoKhoa(XMLData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kq);
                if (kq == 0)
                    XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            InitData();
            Cursor.Current = Cursors.Default;

         
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienGDM);
           // _dtData = gridViewGiangVienGDM.DataSource as DataTable;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                bindingSourceGiangVien.DataSource = _listGiangVien;
            }

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienDinhMucKhauTru.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dt.Load(reader);
                // bindingSourceGiangVienNghienCuuKhoaHoc.DataSource = dt;
                _dtData = dt;
                _dtData.Columns["MaDinhMucKhauTru"].ReadOnly = false;
                bindingSourceGiangVienNghienCuuKhoaHoc.DataSource = _dtData;
                //_dtData = dt;
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
           
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienDinhMucKhauTru.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dt.Load(reader);
                // bindingSourceGiangVienNghienCuuKhoaHoc.DataSource = dt;
                _dtData = dt;
                _dtData.Columns["MaDinhMucKhauTru"].ReadOnly = false;
                bindingSourceGiangVienNghienCuuKhoaHoc.DataSource = _dtData;
                //_dtData = dt;
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienDinhMucKhauTru.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dt.Load(reader);
                // bindingSourceGiangVienNghienCuuKhoaHoc.DataSource = dt;
                _dtData = dt;
                _dtData.Columns["MaDinhMucKhauTru"].ReadOnly = false;
                bindingSourceGiangVienNghienCuuKhoaHoc.DataSource = _dtData;
                //_dtData = dt;
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
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
    }
}