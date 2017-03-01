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
using PMS.Entities;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDanhMucNghienCuuKhoaHoc : DevExpress.XtraEditors.XtraUserControl
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

        public ucDanhMucNghienCuuKhoaHoc()
        {
            InitializeComponent();
        }

        private void ucDanhMucNghienCuuKhoaHoc_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewDanhMucNCKH, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewDanhMucNCKH, new string[] { "MaQuanLy", "TenNghienCuuKhoaHoc", "MaLoaiNckh", "SoTiet", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                                    new string[] { "Mã quản lý", "Tên nghiên cứu khoa học", "Loại nghiên cứu", "Số tiết", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                                    new int[] { 90, 250, 200, 80, 200, 99, 99 });
            AppGridView.ShowEditor(gridViewDanhMucNCKH, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.SummaryField(gridViewDanhMucNCKH, "MaQuanLy", "Tổng số lớp: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.AlignHeader(gridViewDanhMucNCKH, new string[] { "MaQuanLy", "TenNghienCuuKhoaHoc", "MaLoaiNckh", "SoTiet", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewDanhMucNCKH, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.RegisterControlField(gridViewDanhMucNCKH, "MaLoaiNckh", repositoryItemGridLookUpEditLoaiNCKH);
            #endregion
            #region repositoryItemGridLookUpEditLoaiNCKH
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiNCKH, new string[] { "MaLoaiNckh", "TenLoaiNckh" }, new string[] { "Mã loại", "Tên loại" }, new int[] { 50, 150 });
            #endregion
            InitData();
        }

        void InitData()
        {
            bindingSourceDanhMucNCKH.DataSource = DataServices.DanhMucNghienCuuKhoaHoc.GetAll();
            bindingSourceLoaiNCKH.DataSource = DataServices.LoaiNghienCuuKhoaHoc.GetAll();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDanhMucNCKH.FocusedRowHandle = -1;
            TList<DanhMucNghienCuuKhoaHoc> list = bindingSourceDanhMucNCKH.DataSource as TList<DanhMucNghienCuuKhoaHoc>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceDanhMucNCKH.EndEdit();
                            DataServices.DanhMucNghienCuuKhoaHoc.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("FK_GiangVien"))
                        {
                            XtraMessageBox.Show("Không thể xóa vì có giảng viên đang nghiên cứu thuộc về mục này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            XtraMessageBox.Show("Lỗi chưa xác định trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        InitData();
                    }
                }
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
            Cursor.Current = Cursors.WaitCursor;
            gridViewDanhMucNCKH.DeleteSelectedRows();
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        sf.FileName = "Quy đổi giờ chuẩn";
                        if (sf.FileName != "")
                        {
                            gridControlDanhMuc.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            { }
        }


    }
}
