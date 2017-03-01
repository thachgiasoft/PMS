using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Services;
using PMS.Entities;
using PMS.Core;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucTruongKhoa : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btn_Luu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Luu.ShortCut = Shortcut.None;

                btn_Xoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Xoa.ShortCut = Shortcut.None;
            }
            else
            {
                btn_Luu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btn_Xoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        public ucTruongKhoa()
        {
            InitializeComponent();
        }

        private void ucTruongKhoa_Load(object sender, EventArgs e)
        {
            #region Init GridView Truong Khoa
            AppGridView.InitGridView(gridViewTruongKhoa, true, true, GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewTruongKhoa, new string[] { "MaDonVi", "MaGiangVien" },
                new string[] { "Đơn vị - Khoa", "Trưởng khoa" },
                new int[] { 150, 150 });
            AppGridView.RegisterControlField(gridViewTruongKhoa, "MaDonVi", repositoryItemGridLookUpEdit1);
            AppGridView.RegisterControlField(gridViewTruongKhoa, "MaGiangVien", repositoryItemGridLookUpEdit2);
            AppGridView.ShowEditor(gridViewTruongKhoa, NewItemRowPosition.Top);
            #endregion
            #region InitData
            InitData();
            #endregion
        }

        private void InitData()
        {
            #region Truong khoa 
            //TList<TruongKhoa> list = DataServices.TruongKhoa.GetAll();
            //bindingSourceTruongKhoa.DataSource = list;
            #endregion
            #region Init Don vi - khoa
            VList<ViewKhoaBoMon> vlistkhoa = DataServices.ViewKhoaBoMon.GetAll();
            bindingSourceDonVi.DataSource = vlistkhoa;

            repositoryItemGridLookUpEdit1.DataSource = vlistkhoa;
            repositoryItemGridLookUpEdit1.DisplayMember = "TenKhoa";
            repositoryItemGridLookUpEdit1.ValueMember = "MaKhoa";
            #endregion

            #region Don vi - khoa
            AppRepositoryItemGridLookUpEdit.HideField(repositoryItemGridLookUpEdit1, new string[] { "ThuTu", "MaBoMon", "TenBoMon", "MaKhoa", "TenKhoa" });
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEdit1, new string[] { "ThuTu", "MaKhoa", "TenKhoa" }, new string[] { "Thứ tự", "Mã khoa - đơn vị", "Khoa - Đơn vị" });
            #endregion

            #region Init Giang vien
            //VList<ViewGiangVien> vlistGiangVien = DataServices.ViewGiangVien.GetAll();
            //bindingSourceGiangVien.DataSource = vlistGiangVien;

            //repositoryItemGridLookUpEdit2.DataSource = vlistGiangVien;
            //repositoryItemGridLookUpEdit2.DisplayMember = "HoTen";
            //repositoryItemGridLookUpEdit2.ValueMember = "MaGiangVien";
            #endregion

            #region Don vi - khoa
            AppRepositoryItemGridLookUpEdit.HideField(repositoryItemGridLookUpEdit2, new string[] { "ThuTu", "MaGiangVien", "MaQuanLy", "HoTen", "DonGia" });
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEdit2, new string[] { "ThuTu", "MaGiangVien", "HoTen" }, new string[] { "Thứ tự", "Mã giảng viên", "Họ tên" });
            #endregion
        }

        private void btn_Lamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //TruongKhoa obj = bindingSourceTruongKhoa.Current as TruongKhoa;
            //if (obj != null)
            //{
            //    if (obj.IsNew)
            //        bindingSourceTruongKhoa.Remove(obj);
            //    else
            //        obj.CancelChanges();
            //    gridViewTruongKhoa.RefreshData();
            //}
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //AppGridView.DeleteSelectedRows(gridViewTruongKhoa);
        }

        private void gridControlTruongKhoa_KeyUp(object sender, KeyEventArgs e)
        {
           // AppGridView.DeleteSelectedRows(gridViewTruongKhoa, e);
        }

        private void gridControlTruongKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            //AppGridView.CopyCell(gridViewTruongKhoa, e);
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //gridViewTruongKhoa.FocusedRowHandle = -1;
            //TList<TruongKhoa> list = bindingSourceTruongKhoa.DataSource as TList<TruongKhoa>;
            //if (list != null)
            //{
            //    if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            if (list.IsValid)
            //            {
            //                bindingSourceTruongKhoa.EndEdit();
            //                DataServices.TruongKhoa.Save(list);
            //                PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewTruongKhoa, barManager1, layoutControl1 });
            //                XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //                XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        catch
            //        {
            //            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
        }
    }
}
