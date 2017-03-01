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
using PMS.Entities;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmTinhKhoiLuongGiangDayTheoThang : DevExpress.XtraEditors.XtraForm
    {

        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongBo.ShortCut = Shortcut.None;

                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ShortCut = Shortcut.None;
            }
            else
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion


        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public frmTinhKhoiLuongGiangDayTheoThang()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmTinhKhoiLuongGiangDayTheoThang_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoiLuongGiangDay, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewKhoiLuongGiangDay, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "MaLop", "NgayDay", "TenMonHoc", "HeSoLopDong", "SoTiet", "DonGia", "ThanhTien", "CongTacPhi", "TienGiangNgoaiGio", "TongThanhTien" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Lớp", "Ngày", "Nội dung lên lớp", "Hệ số lớp đông", "Số tiết", "Đơn giá", "Thành tiền", "Công tác phí", "Tiền giảng ngoài giờ", "Tổng tiền chi trả qua ATM" }
                    , new int[] { 90, 135, 120, 80, 90, 120, 100, 65, 70, 80, 90, 100, 150 });
            AppGridView.AlignHeader(gridViewKhoiLuongGiangDay, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "MaLop", "NgayDay", "TenMonHoc", "HeSoLopDong", "SoTiet", "DonGia", "ThanhTien", "CongTacPhi", "TienGiangNgoaiGio", "TongThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongGiangDay);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "SoTiet", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "ThanhTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "CongTacPhi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "TienGiangNgoaiGio", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "TongThanhTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongGiangDay, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongGiangDay, "CongTacPhi", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongGiangDay, "TienGiangNgoaiGio", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongGiangDay, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            #endregion

            #region Init KyTinhLuong
            AppGridLookupEdit.InitGridLookUp(cboKyTinhLuong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKyTinhLuong, new string[] { "MaQuanLy", "TuNgay", "DenNgay" }, new string[] { "Kỳ tính lương", "Từ ngày", "Đến ngày" }, new int[] { 120, 100, 100 });
            AppGridLookupEdit.InitPopupFormSize(cboKyTinhLuong, 320, 600);
            cboKyTinhLuong.Properties.DisplayMember = "MaQuanLy";
            cboKyTinhLuong.Properties.ValueMember = "MaQuanLy";
            cboKyTinhLuong.Properties.NullText = string.Empty;
            #endregion
            InitData();
        }
        void InitData()
        {
            bindingSourceKyTinhLuong.DataSource = DataServices.KyTinhLuong.GetAll();
        }
        #region Event Button
        private void btnDongBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKyTinhLuong.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn kỳ tính lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKyTinhLuong.Focus();
                return;
            }
            int kiemTraDongBo = 0;
            DataServices.KhoiLuongGiangDayChiTiet.KiemTraDongBoTheoNgay(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime, ref kiemTraDongBo);
            if (kiemTraDongBo == 0)
                XtraMessageBox.Show(string.Format("Dữ liệu từ ngày {0} đến ngày {1} đã được đồng bộ.\nLưu ý: nếu đồng bộ lại toàn bộ dữ liệu cũ từ ngày {0} đến ngày {1} sẽ bị thay thế.",dateEditTuNgay.Text, dateEditDenNgay.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (XtraMessageBox.Show("Bạn có muốn đồng bộ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    using (frmXuLyDongBoDuLieu frm = new frmXuLyDongBoDuLieu(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime, _maTruong))
                    {
                        frm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Đã xãy ra lỗi trong quá trình đồng bộ." + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKyTinhLuong.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn kỳ tính lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKyTinhLuong.Focus();
                return;
            }

            using (frmXuLyQuyDoiGioiChuan frm = new frmXuLyQuyDoiGioiChuan(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime, _maTruong))
            {
                frm.ShowDialog();
            }

            btnLocDuLieu.PerformClick();
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
           
            Cursor.Current = Cursors.WaitCursor;
            if (cboKyTinhLuong.EditValue==null)
            {
                XtraMessageBox.Show("Bạn chưa chọn kỳ tính lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKyTinhLuong.Focus();
                return;
            }

            DataTable dataTable = new DataTable();
            IDataReader reader = DataServices.TcbKetQuaQuyDoi.GetByNgay(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
            dataTable.Load(reader);

            bindingSourceKhoiLuongGiangDay.DataSource = dataTable;
            gridViewKhoiLuongGiangDay.ExpandAllGroups();
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
        }

        private void cboKyTinhLuong_EditValueChanged(object sender, EventArgs e)
        {
            if (cboKyTinhLuong.EditValue != null)
            { 
                KyTinhLuong k = bindingSourceKyTinhLuong.Current as KyTinhLuong;
                dateEditTuNgay.DateTime = (DateTime)k.TuNgay;
                dateEditDenNgay.DateTime = (DateTime)k.DenNgay; 
            }
        }
    }
}