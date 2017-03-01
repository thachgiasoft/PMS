using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.Entities;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDinhMucHuongDanKhoaLuanThucTap : DevExpress.XtraEditors.XtraUserControl
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

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        public ucDinhMucHuongDanKhoaLuanThucTap()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucDinhMucHuongDanKhoaLuanThucTap_Load(object sender, EventArgs e)
        {
            #region Init GridView LoaiKhoiLuong
            AppGridView.InitGridView(gridViewDinhMucHuongDanKhoaLuanThucTap, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewDinhMucHuongDanKhoaLuanThucTap, new string[] { "MaHinhThucDaoTao", "MaLoaiKhoiLuong", "SoLuong", "MaDonViTinh", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "Hình thức đào tạo", "Loại khối lượng", "Số tiết quy đổi", "Đơn vị tính", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 120, 250, 100, 100, 150, 99, 99 });
            AppGridView.RegisterControlField(gridViewDinhMucHuongDanKhoaLuanThucTap, "MaHinhThucDaoTao", repositoryItemGridLookUpEditHinhThucDaoTao);
            AppGridView.RegisterControlField(gridViewDinhMucHuongDanKhoaLuanThucTap, "MaLoaiKhoiLuong", repositoryItemGridLookUpEditLoaiKhoiLuong);
            AppGridView.RegisterControlField(gridViewDinhMucHuongDanKhoaLuanThucTap, "SoLuong", repositoryItemSpinEditSoLuong);
            AppGridView.RegisterControlField(gridViewDinhMucHuongDanKhoaLuanThucTap, "MaDonViTinh", repositoryItemGridLookUpEditDonViTinh);
            AppGridView.ShowEditor(gridViewDinhMucHuongDanKhoaLuanThucTap, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewDinhMucHuongDanKhoaLuanThucTap, new string[] { "MaHinhThucDaoTao", "MaLoaiKhoiLuong", "SoLuong", "MaDonViTinh", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewDinhMucHuongDanKhoaLuanThucTap, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if(_maTruong == "ACT")
                AppGridView.HideField(gridViewDinhMucHuongDanKhoaLuanThucTap, new string[] { "MaHinhThucDaoTao" });
            #endregion
            #region HinhThucDaoTao
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHinhThucDaoTao, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHinhThucDaoTao, new string[] { "MaHinhThucDaoTao", "TenHinhThucDaoTao" }, new string[] { "Mã hình thức đào tạo", "Tên hình thức đào tạo" }, new int[] { 130, 150 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHinhThucDaoTao, 280, 500);
            repositoryItemGridLookUpEditHinhThucDaoTao.ValueMember = "MaHinhThucDaoTao";
            repositoryItemGridLookUpEditHinhThucDaoTao.DisplayMember = "TenHinhThucDaoTao";
            repositoryItemGridLookUpEditHinhThucDaoTao.NullText = string.Empty;
            #endregion
            #region LoaiKhoiLuong
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiKhoiLuong, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong" }, new string[] { "Mã loại khối lượng", "Tên loại khối lượng" }, new int[] { 130, 150 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLoaiKhoiLuong, 280, 500);
            repositoryItemGridLookUpEditLoaiKhoiLuong.ValueMember = "MaLoaiKhoiLuong";
            repositoryItemGridLookUpEditLoaiKhoiLuong.DisplayMember = "TenLoaiKhoiLuong";
            repositoryItemGridLookUpEditLoaiKhoiLuong.NullText = string.Empty;
            #endregion
            #region DonViTinh
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDonViTinh, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDonViTinh, new string[] { "MaQuanLy", "TenDonVi" }, new string[] { "Mã đơn vị tính", "Tên đơn vị tính" }, new int[] { 130, 150 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDonViTinh, 280, 500);
            repositoryItemGridLookUpEditDonViTinh.ValueMember = "MaDonVi";
            repositoryItemGridLookUpEditDonViTinh.DisplayMember = "TenDonVi";
            repositoryItemGridLookUpEditDonViTinh.NullText = string.Empty;
            #endregion
            InitData();
        }
        void InitData()
        {
            bindingSourceDinhMucHuongDanKhoaLuanThucTap.DataSource = DataServices.DinhMucHuongDanKhoaLuanThucTap.GetAll();
            bindingSourceHinhThucDaoTao.DataSource = DataServices.HinhThucDaoTao.GetAll();
            bindingSourceLoaiKhoiLuong.DataSource = DataServices.LoaiKhoiLuong.GetAll();
            bindingSourceDonViTinh.DataSource = DataServices.DonViTinh.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDinhMucHuongDanKhoaLuanThucTap);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewDinhMucHuongDanKhoaLuanThucTap.FocusedRowHandle = -1;
            TList<DinhMucHuongDanKhoaLuanThucTap> list = bindingSourceDinhMucHuongDanKhoaLuanThucTap.DataSource as TList<DinhMucHuongDanKhoaLuanThucTap>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceDinhMucHuongDanKhoaLuanThucTap.EndEdit();
                            DataServices.DinhMucHuongDanKhoaLuanThucTap.Save(list);
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

        private void gridViewDinhMucHuongDanKhoaLuanThucTap_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDinhMucHuongDanKhoaLuanThucTap, e);
        }

        private void gridViewDinhMucHuongDanKhoaLuanThucTap_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaHinhThucDaoTao" || col.FieldName == "MaLoaiKhoiLuong" || col.FieldName == "SoLuong" || col.FieldName == "MaDonViTinh" || col.FieldName == "GhiChu")
            {
                gridViewDinhMucHuongDanKhoaLuanThucTap.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewDinhMucHuongDanKhoaLuanThucTap.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
    }
}
