using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.Entities;
using PMS.BLL;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmNhapHuongDanKhoaLuanThucTap : DevExpress.XtraEditors.XtraForm
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
        string _maDonViTinh = "", _maTruong;
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        private string groupname = UserInfo.GroupName;
        private bool user = false;
        #endregion

        #region Event Form
        public frmNhapHuongDanKhoaLuanThucTap()
        {
            InitializeComponent();

            _maTruong = _listCauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            if (_maTruong == "ACT")
            {
                layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHinhThucDaoTao.EditValue = "";
            }
        }

        private void frmNhapHuongDanKhoaLuanThucTap_Load(object sender, EventArgs e)
        {
            #region Init GridView LoaiKhoiLuong
            AppGridView.InitGridView(gridViewHuongDanKhoaLuanThucTap, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHuongDanKhoaLuanThucTap, new string[] { "MaGiangVien", "HoTen", "MaLop", "SoLuong", "MaDonViTinh", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaDonVi" },
                new string[] { "Mã giảng viên", "Họ tên", "Lớp", "Số lượng", "Đơn vị tính", "Ghi chú", "Ngày cập nhật", "Người cập nhật", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaDonVi" },
                new int[] { 120, 150, 90, 100, 100, 150, 99, 99, 99, 99, 99, 99 });
            AppGridView.RegisterControlField(gridViewHuongDanKhoaLuanThucTap, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewHuongDanKhoaLuanThucTap, "SoLuong", repositoryItemSpinEditSoLuong);
            AppGridView.RegisterControlField(gridViewHuongDanKhoaLuanThucTap, "MaDonViTinh", repositoryItemGridLookUpEditDonVITinh);
            AppGridView.ShowEditor(gridViewHuongDanKhoaLuanThucTap, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHuongDanKhoaLuanThucTap, new string[] { "MaGiangVien", "HoTen", "MaLop", "SoLuong", "MaDonViTinh", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewHuongDanKhoaLuanThucTap, new string[] { "NgayCapNhat", "NguoiCapNhat", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaDonVi" });
            AppGridView.ReadOnlyColumn(gridViewHuongDanKhoaLuanThucTap, new string[] { "HoTen", "MaDonViTinh" });

            if (_maTruong != "ACT")
                AppGridView.HideField(gridViewHuongDanKhoaLuanThucTap, new string[] { "MaLop" });
            #endregion
            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            #region HinhThucDaoTao
            AppGridLookupEdit.InitGridLookUp(cboHinhThucDaoTao, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHinhThucDaoTao, new string[] { "MaHinhThucDaoTao", "TenHinhThucDaoTao" }, new string[] { "Mã hình thức đào tạo", "Tên hình thức đào tạo" });
            cboHinhThucDaoTao.Properties.ValueMember = "MaHinhThucDaoTao";
            cboHinhThucDaoTao.Properties.DisplayMember = "TenHinhThucDaoTao";
            cboHinhThucDaoTao.Properties.NullText = string.Empty;
            #endregion
            #region LoaiKhoiLuong
            AppGridLookupEdit.InitGridLookUp(cboLoaiKhoiLuong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong" }, new string[] { "Mã loại khối lượng", "Tên loại khối lượng" });
            cboLoaiKhoiLuong.Properties.ValueMember = "MaLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.DisplayMember = "TenLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.NullText = string.Empty;
            #endregion
            #region _khoaDonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion
            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên", "Đơn vị" }, new int[] { 90, 130, 100, 100, 100, 150 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 670, 650);
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region DonViTinh
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDonVITinh, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDonVITinh, new string[] { "MaQuanLy", "TenDonVi" }, new string[] { "Mã đơn vị tính", "Tên đơn vị tính" }, new int[] { 150, 150 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDonVITinh, 300, 500);
            repositoryItemGridLookUpEditDonVITinh.ValueMember = "MaDonVi";
            repositoryItemGridLookUpEditDonVITinh.DisplayMember = "TenDonVi";
            repositoryItemGridLookUpEditDonVITinh.NullText = string.Empty;
            #endregion
            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceDonViTinh.DataSource = DataServices.DonViTinh.GetAll();
            cboLoaiKhoiLuong.DataBindings.Clear();
            cboHinhThucDaoTao.DataBindings.Clear();
            cboKhoaDonVi.DataBindings.Clear();
            bindingSourceHinhThucDaoTao.DataSource = DataServices.HinhThucDaoTao.GetAll();
            bindingSourceLoaiKhoiLuong.DataSource = DataServices.LoaiKhoiLuong.GetAll();
            //bindingSourceKhoaDonVi.DataSource = DataServices.ViewKhoa.GetAll();
            #region khoa - bo mon
            VList<ViewKhoaBoMon> vKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in vKhoaBoMon)
            {
                if (groupname == v.MaBoMon)
                {
                    user = true; break;
                }
            }
            #endregion
            if (user == true)
            {
                vKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(groupname);
            }
            else
            {
                vKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            }
            bindingSourceKhoaDonVi.DataSource = vKhoaBoMon;

            cboLoaiKhoiLuong.DataBindings.Add("EditValue", bindingSourceLoaiKhoiLuong, "MaLoaiKhoiLuong", true, DataSourceUpdateMode.OnPropertyChanged);
            cboHinhThucDaoTao.DataBindings.Add("EditValue", bindingSourceHinhThucDaoTao, "MaHinhThucDaoTao", true, DataSourceUpdateMode.OnPropertyChanged);
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                bindingSourceGiangVien.DataSource = _listGiangVien;
            }
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHinhThucDaoTao.EditValue != null && cboLoaiKhoiLuong.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourceHuongDanKhoaLuanThucTap.DataSource = DataServices.HuongDanKhoaLuanThucTap.GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboHinhThucDaoTao.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
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
            AppGridView.DeleteSelectedRows(gridViewHuongDanKhoaLuanThucTap);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            int kiemtra = 0;
            DataServices.HuongDanKhoaLuanThucTap.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã bị chốt để thực hiện thanh toán thù lao. \nVui lòng liên hệ phòng ban quản lý để biết thêm chi tiết.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.WaitCursor;
                InitData();
                Cursor.Current = Cursors.Default;
                return;
            }

            gridViewHuongDanKhoaLuanThucTap.FocusedRowHandle = -1;
            TList<HuongDanKhoaLuanThucTap> list = bindingSourceHuongDanKhoaLuanThucTap.DataSource as TList<HuongDanKhoaLuanThucTap>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HuongDanKhoaLuanThucTap cv in list)
                            {
                                cv.NamHoc = cboNamHoc.EditValue.ToString();
                                cv.HocKy = cboHocKy.EditValue.ToString();
                                cv.MaHinhThucDaoTao = cboHinhThucDaoTao.EditValue.ToString();
                                cv.MaLoaiKhoiLuong = cboLoaiKhoiLuong.EditValue.ToString();
                            }
                            bindingSourceHuongDanKhoaLuanThucTap.EndEdit();
                            DataServices.HuongDanKhoaLuanThucTap.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Grid
        private void gridViewHuongDanKhoaLuanThucTap_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHuongDanKhoaLuanThucTap, e);
        }

        private void gridViewHuongDanKhoaLuanThucTap_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                HuongDanKhoaLuanThucTap objHD = gridViewHuongDanKhoaLuanThucTap.GetRow(e.RowHandle) as HuongDanKhoaLuanThucTap;
                ViewGiangVien objGV = _listGiangVien.Find(p => p.MaGiangVien == objHD.MaGiangVien);
                gridViewHuongDanKhoaLuanThucTap.SetRowCellValue(e.RowHandle, "HoTen", objGV.HoTen);
                gridViewHuongDanKhoaLuanThucTap.SetRowCellValue(e.RowHandle, "MaHocHam", objGV.MaHocHam);
                gridViewHuongDanKhoaLuanThucTap.SetRowCellValue(e.RowHandle, "MaHocVi", objGV.MaHocVi);
                gridViewHuongDanKhoaLuanThucTap.SetRowCellValue(e.RowHandle, "MaLoaiGiangVien", objGV.MaLoaiGiangVien);
                gridViewHuongDanKhoaLuanThucTap.SetRowCellValue(e.RowHandle, "MaDonVi", objGV.MaDonVi);
            }
            if (col.FieldName == "MaGiangVien" || col.FieldName == "SoLuong" || col.FieldName == "GhiChu")
            {
                gridViewHuongDanKhoaLuanThucTap.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewHuongDanKhoaLuanThucTap.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                try
                {
                    gridViewHuongDanKhoaLuanThucTap.SetRowCellValue(e.RowHandle, "MaDonViTinh", _maDonViTinh);
                }
                catch
                {  }
                
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Cbo
        private void cboLoaiKhoiLuong_EditValueChanged(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            DataServices.DonViTinh.GetByLoaiKhoiLuong(cboLoaiKhoiLuong.EditValue.ToString(), ref _maDonViTinh);
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHinhThucDaoTao.EditValue != null && cboLoaiKhoiLuong.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourceHuongDanKhoaLuanThucTap.DataSource = DataServices.HuongDanKhoaLuanThucTap.GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboHinhThucDaoTao.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default; 
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHinhThucDaoTao.EditValue != null && cboLoaiKhoiLuong.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourceHuongDanKhoaLuanThucTap.DataSource = DataServices.HuongDanKhoaLuanThucTap.GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboHinhThucDaoTao.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHinhThucDaoTao.EditValue != null && cboLoaiKhoiLuong.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourceHuongDanKhoaLuanThucTap.DataSource = DataServices.HuongDanKhoaLuanThucTap.GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboHinhThucDaoTao.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHinhThucDaoTao_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHinhThucDaoTao.EditValue != null && cboLoaiKhoiLuong.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourceHuongDanKhoaLuanThucTap.DataSource = DataServices.HuongDanKhoaLuanThucTap.GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboHinhThucDaoTao.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                bindingSourceGiangVien.DataSource = _listGiangVien;
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHinhThucDaoTao.EditValue != null && cboLoaiKhoiLuong.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourceHuongDanKhoaLuanThucTap.DataSource = DataServices.HuongDanKhoaLuanThucTap.GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboHinhThucDaoTao.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}