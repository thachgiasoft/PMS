using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;
using PMS.Core;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucCauHinh : DevExpress.XtraEditors.XtraUserControl
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

        private TList<CauHinh> listCauHinh;

        public ucCauHinh()
        {
            InitializeComponent();
        }

        #region ucCauHinh_Load
        private void ucCauHinh_Load(object sender, EventArgs e)
        {
            #region Initgirdview
            AppGridView.InitGridView(gridViewCauHinh, true, true, GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCauHinh, new string[] { "TenTruong", "PhongDaoTao", "ChucVuDaoTao", "PhongToChucCanBo", "ChucVuToChucCanBo"
                ,"PhongKeHoachTaiChinh", "ChucVuKeHoachTaiChinh","BanGiamHieu", "ChucVuBanGiamHieu", "NguoiLapbieu", "KeToan", "ChucVuKeToan"
                , "DaiDienHopDongThinhGiang", "DaiDienHopDongThinhGiang02", "ChucVuDaiDienHopDongThinhGiang", "ChucVuDaiDienHopDongThinhGiang02"
                , "ChucVuKiemNhiemKhac", "DiaChiDaiDien", "DienThoaiDaiDien", "FaxDaiDien", "MaSoThue", "TrangThai" },
                new string[] { "Tên trường", "Người quản lý đào tạo", "Chức vụ đào tạo", "Người tổ chức hành chính", "Chức vụ tổ chức hành chính"
                , "Người kế hoạch tài chính", "Chức vụ kế hoạch tài chính", "Người giám hiệu", "Chức vụ giám hiệu", "Người lập biểu", "Người kế toán"
                , "Chức vụ kế toán", "Người đại diện hợp đồng", "Người đại diện hợp đồng thứ 2", "Chức vụ đại diện hợp đồng", "Chức vụ đại diện hợp đồng thứ 2"
                , "Chức vụ đại diện kiêm nhiệm", "Địa chỉ đai diện", "Điện thoại đại diện", "Fax đại diện", "Mã số thuế", "Trạng thái" },
                new int[] { 200, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 200, 100, 90, 80, 50 });
            AppGridView.AlignHeader(gridViewCauHinh, new string[] { "TenTruong", "PhongDaoTao", "ChucVuDaoTao", "PhongToChucCanBo", "ChucVuToChucCanBo"
                ,"PhongKeHoachTaiChinh", "ChucVuKeHoachTaiChinh","BanGiamHieu", "ChucVuBanGiamHieu", "NguoiLapbieu", "KeToan", "ChucVuKeToan"
                , "DaiDienHopDongThinhGiang", "DaiDienHopDongThinhGiang02", "ChucVuDaiDienHopDongThinhGiang", "ChucVuDaiDienHopDongThinhGiang02"
                , "ChucVuKiemNhiemKhac", "DiaChiDaiDien", "DienThoaiDaiDien", "FaxDaiDien", "MaSoThue", "TrangThai" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewCauHinh, new string[] { "TenTruong", "PhongDaoTao", "ChucVuDaoTao", "PhongToChucCanBo", "ChucVuToChucCanBo"
                ,"PhongKeHoachTaiChinh", "ChucVuKeHoachTaiChinh","BanGiamHieu", "ChucVuBanGiamHieu", "NguoiLapbieu", "KeToan", "ChucVuKeToan"
                , "DaiDienHopDongThinhGiang", "DaiDienHopDongThinhGiang02", "ChucVuDaiDienHopDongThinhGiang", "ChucVuDaiDienHopDongThinhGiang02"
                , "ChucVuKiemNhiemKhac", "DiaChiDaiDien", "DienThoaiDaiDien", "FaxDaiDien", "MaSoThue", "TrangThai" }, DevExpress.Utils.HorzAlignment.Center);
            PMS.Common.Globals.WordWrapHeader(gridViewCauHinh, 50);
            AppGridView.ShowEditor(gridViewCauHinh, NewItemRowPosition.Top);
            AppGridView.BackColorFieldAppearance(gridViewCauHinh, new string[] { "TenTruong", "ChucVuDaoTao", "ChucVuToChucCanBo", "ChucVuKeHoachTaiChinh"
                , "ChucVuBanGiamHieu", "KeToan", "DaiDienHopDongThinhGiang", "ChucVuDaiDienHopDongThinhGiang", "ChucVuKiemNhiemKhac", "DienThoaiDaiDien", "MaSoThue" }
            , System.Drawing.Color.DarkSeaGreen);
            AppGridView.BackColorFieldAppearance(gridViewCauHinh, new string[] { "PhongDaoTao", "PhongToChucCanBo","PhongKeHoachTaiChinh","BanGiamHieu", "NguoiLapbieu"
                , "ChucVuKeToan", "DaiDienHopDongThinhGiang02", "ChucVuDaiDienHopDongThinhGiang02", "DiaChiDaiDien", "FaxDaiDien", "TrangThai" }
            , System.Drawing.Color.LightBlue);
            #endregion

            #region Init Datasource
            bindingSourceCauHinh.DataSource = DataServices.CauHinh.GetAll();
            listCauHinh = bindingSourceCauHinh.DataSource as TList<CauHinh>;
            if (listCauHinh != null)
            {
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }
           #endregion
        }
        #endregion

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CauHinh obj = bindingSourceCauHinh.Current as CauHinh;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceCauHinh.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewCauHinh.RefreshData();
            }
        }

        private void gridViewCauHinh_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCauHinh, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewCauHinh.FocusedRowHandle = -1;
            TList<CauHinh> list = bindingSourceCauHinh.DataSource as TList<CauHinh>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceCauHinh.EndEdit();
                            DataServices.CauHinh.Save(list);
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
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }
        }

        private void btnLamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceCauHinh.DataSource = DataServices.CauHinh.GetAll();
            Cursor.Current = Cursors.Default;

        }

        private void gridViewCauHinh_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewCauHinh, e);
        }

        private void gridViewCauHinh_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CauHinh obj = e.Row as CauHinh;
            if (obj != null)
            {
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCauHinh);
        }
    }
}
