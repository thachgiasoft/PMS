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
using PMS.Core;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDanhMucHoatDongQuanLy : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem2.ShortCut = Shortcut.None;

                barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem1.ShortCut = Shortcut.None;
            }
            else
            {
                barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        public ucDanhMucHoatDongQuanLy()
        {
            InitializeComponent();
        }

        private void ucDanhMucHoatDongQuanLy_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridView1, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridView1, new string[] { "MaHoatDong", "TenHoatDong", "HienThiLenWeb", "GhiChu" }
                    , new string[] { "Mã hoạt động", "Tên hoạt động", "Hiển thị lên web", "Ghi chú" }
                    , new int[] { 100, 300, 150, 200 });
            AppGridView.ShowEditor(gridView1, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridView1, new string[] { "MaHoatDong", "TenHoatDong", "HienThiLenWeb", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            InitData();
        }

        private void InitData()
        {
            bsHoatDongQuanLy.DataSource = DataServices.DanhMucHoatDongQuanLy.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridView1);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.FocusedRowHandle = -1;
            TList<DanhMucHoatDongQuanLy> list = bsHoatDongQuanLy.DataSource as TList<DanhMucHoatDongQuanLy>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bsHoatDongQuanLy.EndEdit();
                            DataServices.DanhMucHoatDongQuanLy.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridView1, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Dòng dữ liệu này đang được sử dụng, không được phép xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
