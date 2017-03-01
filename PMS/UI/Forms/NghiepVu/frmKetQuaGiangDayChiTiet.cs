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

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKetQuaGiangDayChiTiet : DevExpress.XtraEditors.XtraForm
    {
        private string loaiKhoiLuong;
        private string maQuanLy;
        private string hoTen;
        private string namHoc;

        private string lanChot01, lanChot02, lanChot03;

        public frmKetQuaGiangDayChiTiet()
        {
            InitializeComponent();
        }

        public frmKetQuaGiangDayChiTiet(string loai_khoi_luong, string ma_quan_ly, string ho_ten, string nam_hoc)
        {
            InitializeComponent();
            this.loaiKhoiLuong = loai_khoi_luong;
            this.maQuanLy = ma_quan_ly;
            this.hoTen = ho_ten;
            this.namHoc = nam_hoc;
        }

        public frmKetQuaGiangDayChiTiet(string loai_khoi_luong, string ma_quan_ly, string ho_ten, string nam_hoc, string lanChot_01, string lanChot_02, string lanChot_03)
        {
            InitializeComponent();
            this.loaiKhoiLuong = loai_khoi_luong;
            this.maQuanLy = ma_quan_ly;
            this.hoTen = ho_ten;
            this.namHoc = nam_hoc;

            this.lanChot01 = lanChot_01;
            this.lanChot02 = lanChot_02;
            this.lanChot03 = lanChot_03;
        }

        private void frmChiTietThanhToanThuLao_Load(object sender, EventArgs e)
        {
            #region Init gridview
            if (loaiKhoiLuong.Equals("Khối lượng hoạt động quản lý"))
            {
                AppGridView.InitGridView(gridViewThuLaoChiTiet, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                AppGridView.ShowField(gridViewThuLaoChiTiet, new string[] { "NoiDungCongViec", "SoTiet", "SoPhut", "GhiChu", "NgayThucHien", "HocKy" },
                    new string[] { "Nội dung", "Số tiết", "Số phút", "Ghi chú", "Ngày thực hiện", "Học kỳ" },
                    new int[] { 200, 70, 70, 200, 100, 60 });
                AppGridView.AlignHeader(gridViewThuLaoChiTiet, new string[] { "NoiDungCongViec", "SoTiet", "SoPhut", "GhiChu", "NgayThucHien", "HocKy" }, DevExpress.Utils.HorzAlignment.Center);
                AppGridView.ReadOnlyColumn(gridViewThuLaoChiTiet);
                AppGridView.FormatDataField(gridViewThuLaoChiTiet, new string[] { "SoTiet", "SoPhut" }, DevExpress.Utils.FormatType.Custom, "n2");
                AppGridView.SummaryField(gridViewThuLaoChiTiet, "NoiDungCongViec", "Số việc: {0}", DevExpress.Data.SummaryItemType.Count);
                AppGridView.SummaryField(gridViewThuLaoChiTiet, "SoTiet", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
                AppGridView.BackColorFieldAppearance(gridViewThuLaoChiTiet, new string[] { "NoiDungCongViec", "SoPhut", "NgayThucHien"}, Color.Azure);
                AppGridView.BackColorFieldAppearance(gridViewThuLaoChiTiet, new string[] { "SoTiet", "GhiChu", "HocKy" }, Color.Snow);
            }
            else
            {
                AppGridView.InitGridView(gridViewThuLaoChiTiet, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                AppGridView.ShowField(gridViewThuLaoChiTiet, new string[] { "MaMonHoc", "TenMonHoc", "MaLop", "SiSo", "Loai", "Nhom", "TietThucDay", "TietQuyDoi", "HocKy" },
                    new string[] { "Mã môn học", "Tên môn học", "Mã lớp", "Sĩ số", "Loại", "Nhóm", "Tiết thực dạy", "Tiết quy đổi", "Học kỳ" },
                    new int[] { 75, 150, 110, 50, 50, 50, 85, 85, 50 });
                AppGridView.AlignHeader(gridViewThuLaoChiTiet, new string[] { "MaMonHoc", "TenMonHoc", "MaLop", "SiSo", "Loai", "Nhom", "TietThucDay", "TietQuyDoi", "HocKy" }, DevExpress.Utils.HorzAlignment.Center);
                AppGridView.ReadOnlyColumn(gridViewThuLaoChiTiet);
                AppGridView.FormatDataField(gridViewThuLaoChiTiet, new string[] { "TietThucDay", "TietQuyDoi" }, DevExpress.Utils.FormatType.Custom, "n2");
                AppGridView.SummaryField(gridViewThuLaoChiTiet, "MaMonHoc", "Số môn: {0}", DevExpress.Data.SummaryItemType.Count);
                AppGridView.SummaryField(gridViewThuLaoChiTiet, "TietQuyDoi", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
                AppGridView.BackColorFieldAppearance(gridViewThuLaoChiTiet, new string[] { "TenMonHoc", "SiSo", "Nhom", "TietQuyDoi" }, Color.Azure);
                AppGridView.BackColorFieldAppearance(gridViewThuLaoChiTiet, new string[] { "MaMonHoc", "MaLop", "Loai", "TietThucDay", "HocKy" }, Color.Snow);
            }
            #endregion

            this.Text = this.loaiKhoiLuong + " chi tiết";
            txtNamHoc.Text = this.namHoc;
            txtTenGiangVien.Text = this.hoTen;

            IDataReader idr = DataServices.KetQuaThanhToanThuLao.GetByMaGiangVienNamHoc(this.maQuanLy, this.namHoc, this.loaiKhoiLuong, lanChot01, lanChot02, lanChot03);
            DataTable dt = new DataTable();
            dt.Load(idr);
            bindingSourceChiTiet.DataSource = dt;
        }
    }
}