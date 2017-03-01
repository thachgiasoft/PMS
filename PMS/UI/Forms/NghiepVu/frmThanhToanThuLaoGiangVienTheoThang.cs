using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThanhToanThuLaoGiangVienTheoThang : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnImport.ShortCut = Shortcut.None;

            }
            else
            {
                btnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public frmThanhToanThuLaoGiangVienTheoThang()
        {
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            InitializeComponent();
        }

        private void frmThanhToanThuLaoGiangVienTheoThang_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThuLao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThuLao, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "MaLop", "NgayDay", "TenMonHoc", "HeSoLopDong", "SoTiet", "DonGia", "ThanhTien", "CongTacPhi", "TienGiangNgoaiGio", "TongThanhTien" }
                    , new string[] { "Mã giảng viên", "Họ và tên", "Khoa - Đơn vị", "Lớp", "Ngày", "Nội dung lên lớp", "Hệ số", "Số tiết", "Tiền giảng 1 tiết", "Thành tiền", "Công tác phí", "Tiền giảng ngoài giờ", "Tổng số tiền chi trả qua ATM" }
                    , new int[] { 85, 135, 110, 90, 100, 180, 60, 60, 100, 100, 90, 120, 150 });
            AppGridView.AlignHeader(gridViewThuLao, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "MaLop", "NgayDay", "TenMonHoc", "HeSoLopDong", "SoTiet", "DonGia", "ThanhTien", "CongTacPhi", "TienGiangNgoaiGio", "TongThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThuLao, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThuLao, "ThanhTien", "{0:n0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThuLao, "CongTacPhi", "{0:n0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThuLao, "TienGiangNgoaiGio", "{0:n0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThuLao, "TongThanhTien", "{0:n0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.ReadOnlyColumn(gridViewThuLao);
            AppGridView.FormatDataField(gridViewThuLao, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLao, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLao, "CongTacPhi", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLao, "TienGiangNgoaiGio", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLao, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            #endregion
        }
        #region Event Button
        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlThuLao.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

        private void btnImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmImportThanhToanThuLao frm = new frmImportThanhToanThuLao())
            {
                frm.ShowDialog();
            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (dateEditTuNgay.Text != "" && dateEditDenNgay.Text != "")
            {
                DataTable tb = new DataTable();
                 IDataReader reader = DataServices.TcbKetQuaQuyDoi.GetByNgay(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
                tb.Load(reader);
                bindingSourceThuLao.DataSource = tb;
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn từ ngày - đến ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateEditTuNgay.Focus();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dateEditTuNgay.Text = "";
            dateEditDenNgay.Text = "";
            bindingSourceThuLao.DataSource = null;
            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}