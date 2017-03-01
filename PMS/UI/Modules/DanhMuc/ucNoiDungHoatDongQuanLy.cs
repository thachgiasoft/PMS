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
    public partial class ucNoiDungHoatDongQuanLy : DevExpress.XtraEditors.XtraUserControl
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

        public ucNoiDungHoatDongQuanLy()
        {
            InitializeComponent();
        }

        private void ucNoiDungHoatDongQuanLy_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewNoiDung, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewNoiDung, new string[] { "Id", "MaCongViec", "NoiDung" }
                    , new string[] { "Id", "Công việc", "Nội dung" }
                    , new int[] { 20, 300, 500 });
            AppGridView.ShowEditor(gridViewNoiDung, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewNoiDung, new string[] { "Id", "MaCongViec", "NoiDung" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewNoiDung, new string[] { "Id" });
            //AppGridView.ReadOnlyColumn(gridView1, new string[] { "HoTen" });

            #region HoatDong
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHoatDong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHoatDong, new string[] { "TenHoatDong" }, new string[] { "Tên hoạt động" });
            repositoryItemGridLookUpEditHoatDong.DisplayMember = "TenHoatDong";
            repositoryItemGridLookUpEditHoatDong.ValueMember = "Id";
            repositoryItemGridLookUpEditHoatDong.NullText = string.Empty;
            repositoryItemGridLookUpEditHoatDong.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            #endregion

            InitData();
        }

        private void InitData()
        {
            bindingSourceNoiDung.DataSource = DataServices.NoiDungCongViecQuanLy.GetAll();
            bindingSourceHoatDong.DataSource = DataServices.DanhMucHoatDongQuanLy.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewNoiDung);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewNoiDung.FocusedRowHandle = -1;
            TList<DanhMucHoatDongQuanLy> list = bindingSourceNoiDung.DataSource as TList<DanhMucHoatDongQuanLy>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceNoiDung.EndEdit();
                            DataServices.DanhMucHoatDongQuanLy.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewNoiDung, barManager1, layoutControl1 });
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
