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
    public partial class ucHinhThucDaoTao : DevExpress.XtraEditors.XtraUserControl
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
        #endregion

        #region Event Form
        public ucHinhThucDaoTao()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucHinhThucDaoTao_Load(object sender, EventArgs e)
        {
            #region Init GridView
            switch (_maTruong)
            {
                case "UFM":
                    InitGridUFM();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion
            InitData();
        }
        #endregion 

        #region InitData()
        void InitData()
        {
            bindingSourceHinhThucDaoTao.DataSource = DataServices.HinhThucDaoTao.GetAll();
        }

        void InitGridUFM()
        {
            AppGridView.InitGridView(gridViewHinhThucDaoTao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHinhThucDaoTao, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHinhThucDaoTao, new string[] { "MaHinhThucDaoTao", "TenHinhThucDaoTao", "GhiChu" }
                    , new string[] { "Mã hình thức đào tạo", "Tên hình thức đào tạo", "Ghi chú" }
                    , new int[] { 120, 200, 300 });
            AppGridView.AlignHeader(gridViewHinhThucDaoTao, new string[] { "MaHinhThucDaoTao", "TenHinhThucDaoTao", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewHinhThucDaoTao, "MaHinhThucDaoTao", "{0}", DevExpress.Data.SummaryItemType.Count);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewHinhThucDaoTao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHinhThucDaoTao, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHinhThucDaoTao, new string[] { "MaHinhThucDaoTao", "TenHinhThucDaoTao", "HeSoNhanDonGia", "TinhGioChuan", "GhiChu" }
                    , new string[] { "Mã hình thức đào tạo", "Tên hình thức đào tạo", "Hệ số nhân đơn giá", "Có tính giờ chuẩn", "Ghi chú" }
                    , new int[] { 120, 200, 120, 120, 300 });
            AppGridView.AlignHeader(gridViewHinhThucDaoTao, new string[] { "MaHinhThucDaoTao", "TenHinhThucDaoTao", "HeSoNhanDonGia", "TinhGioChuan", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewHinhThucDaoTao, "MaHinhThucDaoTao", "{0}", DevExpress.Data.SummaryItemType.Count);
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
            AppGridView.DeleteSelectedRows(gridViewHinhThucDaoTao);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHinhThucDaoTao.FocusedRowHandle = -1;
            TList<HinhThucDaoTao> list = bindingSourceHinhThucDaoTao.DataSource as TList<HinhThucDaoTao>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHinhThucDaoTao.EndEdit();
                            DataServices.HinhThucDaoTao.Save(list);
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
        }

        private void gridViewHinhThucDaoTao_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHinhThucDaoTao, e);
        }
    }
}
