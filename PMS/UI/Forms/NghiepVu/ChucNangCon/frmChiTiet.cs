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
    public partial class frmChiTiet : DevExpress.XtraEditors.XtraForm
    {
        private string _strTuyChinh01;
        private string _strTuyChinh02;
        private PMS.Common.LoaiChiTiet _loai;
        private List<object> _dsThamSo;

        public frmChiTiet()
        {
            InitializeComponent();
        }

        public frmChiTiet(string str1, string str2, PMS.Common.LoaiChiTiet loai_chi_tiet, List<object> ds_tham_so)
        {
            InitializeComponent();
            this._strTuyChinh01 = str1;
            this._strTuyChinh02 = str2;
            this._loai = loai_chi_tiet;
            this._dsThamSo = ds_tham_so;
        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            IDataReader reader;
            DataTable dt;

            #region Init Gridview
            switch (_loai)
            {
                case PMS.Common.LoaiChiTiet.ToChucThi:
                    this.Text = "Chi tiết tổ chức thi";
                    layoutControlItem01.Text = "Mã giảng viên:";
                    layoutControlItem02.Text = "Họ tên:";

                    AppGridView.InitGridView(gridViewChiTiet, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                    AppGridView.ShowField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "SoSvTrongDanhSach", "SoPhong", "SoNguoiThamGia", "HeSo", "TietQuyDoi" },
                        new string[] { "Môn thi", "Khoa tổ chức", "Lần", "Ngày", "Ca", "Phòng", "Thời lượng", "Số sinh viên", "Số phòng", "Số người tham gia", "Hệ số", "Tiết quy đổi" },
                        new int[] { 200, 170, 35, 80, 50, 60, 70, 80, 60, 70, 50, 70 });
                    AppGridView.ReadOnlyColumn(gridViewChiTiet);
                    AppGridView.SummaryField(gridViewChiTiet, "TenMonHoc", "{0:n0} mẫu tin", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.SummaryField(gridViewChiTiet, "SoSvTrongDanhSach", "{0:n0} SV", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.SummaryField(gridViewChiTiet, "SoPhong", "{0:n0} phòng", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.SummaryField(gridViewChiTiet, "TietQuyDoi", "{0:n2} tiết", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.AlignHeader(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "SoPhong", "SoNguoiThamGia", "HeSo", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.AlignField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "SoPhong", "SoNguoiThamGia", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.BackColorFieldAppearance(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, Color.Plum);
                    AppGridView.FixedField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
                    PMS.Common.Globals.WordWrapHeader(gridViewChiTiet, 35);

                    reader = DataServices.KetQuaThanhToanThuLao.GetSoTietToChucThi((string)_dsThamSo[0], (string)_dsThamSo[1], (string)_dsThamSo[2], (string)_dsThamSo[3], (int)_dsThamSo[4], (string)_dsThamSo[5]);
                    dt = new DataTable();
                    dt.Load(reader);
                    bindingSourceChiTiet.DataSource = dt;
                    break;

                case PMS.Common.LoaiChiTiet.CoiThi:
                    this.Text = "Chi tiết coi thi";
                    layoutControlItem01.Text = "Mã giảng viên:";
                    layoutControlItem02.Text = "Họ tên:";

                    AppGridView.InitGridView(gridViewChiTiet, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                    AppGridView.ShowField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "HeSo", "TietQuyDoi" },
                        new string[] { "Môn thi", "Khoa tổ chức", "Lần", "Ngày", "Ca", "Phòng", "Thời lượng", "Hệ số", "Tiết quy đổi" },
                        new int[] { 200, 170, 35, 80, 50, 60, 60, 50, 90 });
                    AppGridView.ReadOnlyColumn(gridViewChiTiet);
                    AppGridView.SummaryField(gridViewChiTiet, "TenMonHoc", "{0:n0} mẫu tin", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.SummaryField(gridViewChiTiet, "TietQuyDoi", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.AlignHeader(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "HeSo", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.AlignField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.BackColorFieldAppearance(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, Color.Plum);
                    AppGridView.FixedField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
                    PMS.Common.Globals.WordWrapHeader(gridViewChiTiet, 35);

                    reader = DataServices.KetQuaThanhToanThuLao.GetSoTietCoiThi((string)_dsThamSo[0], (string)_dsThamSo[1], (string)_dsThamSo[2], (string)_dsThamSo[3], (int)_dsThamSo[4], (string)_dsThamSo[5]);
                    dt = new DataTable();
                    dt.Load(reader);
                    bindingSourceChiTiet.DataSource = dt;
                    break;

                case PMS.Common.LoaiChiTiet.ChamBai:
                    this.Text = "Chi tiết chấm bài";
                    layoutControlItem01.Text = "Mã giảng viên:";
                    layoutControlItem02.Text = "Họ tên:";

                    AppGridView.InitGridView(gridViewChiTiet, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                    AppGridView.ShowField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "SoBai", "SoNguoiCham", "HeSo", "TietQuyDoi" },
                        new string[] { "Môn thi", "Khoa tổ chức", "Lần", "Ngày", "Ca", "Phòng", "Thời lượng", "Số bài", "Số người chấm", "Hệ số", "Tiết quy đổi" },
                        new int[] { 200, 170, 35, 80, 50, 60, 70, 60, 90, 50, 80 });
                    AppGridView.ReadOnlyColumn(gridViewChiTiet);
                    AppGridView.SummaryField(gridViewChiTiet, "SoBai", "{0} bài", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.SummaryField(gridViewChiTiet, "TietQuyDoi", "{0} tiết", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.AlignHeader(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "SoBai", "SoNguoiCham", "HeSo", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.AlignField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "SoBai", "SoNguoiCham", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.BackColorFieldAppearance(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, Color.Plum);
                    AppGridView.FixedField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);

                    reader = DataServices.KetQuaThanhToanThuLao.GetSoTietChamBai((string)_dsThamSo[0], (string)_dsThamSo[1], (string)_dsThamSo[2], (string)_dsThamSo[3], (int)_dsThamSo[4], (string)_dsThamSo[5]);
                    dt = new DataTable();
                    dt.Load(reader);
                    bindingSourceChiTiet.DataSource = dt;
                    break;

                case PMS.Common.LoaiChiTiet.RaDe:
                    this.Text = "Chi tiết ra đề";
                    layoutControlItem01.Text = "Mã giảng viên:";
                    layoutControlItem02.Text = "Họ tên:";

                    AppGridView.InitGridView(gridViewChiTiet, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                    AppGridView.ShowField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "TenHinhThucThi", "SoDe", "HeSo", "TietQuyDoi" },
                        new string[] { "Môn thi", "Khoa tổ chức", "Lần", "Hình thức", "Số đề", "Hệ số", "Tiết quy đổi" },
                        new int[] { 200, 170, 35, 70, 80, 60, 90 });
                    AppGridView.ReadOnlyColumn(gridViewChiTiet);
                    AppGridView.SummaryField(gridViewChiTiet, "SoDe", "{0} đề", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.SummaryField(gridViewChiTiet, "TietQuyDoi", "{0} tiết", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.AlignHeader(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "TenHinhThucThi", "SoDe", "HeSo", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.AlignField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "TenHinhThucThi", "SoDe", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.BackColorFieldAppearance(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, Color.Plum);
                    AppGridView.FixedField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);

                    reader = DataServices.KetQuaThanhToanThuLao.GetSoTietRaDe((string)_dsThamSo[0], (string)_dsThamSo[1], (string)_dsThamSo[2], (string)_dsThamSo[3], (int)_dsThamSo[4], (string)_dsThamSo[5]);
                    dt = new DataTable();
                    dt.Load(reader);
                    bindingSourceChiTiet.DataSource = dt;
                    break;

                case PMS.Common.LoaiChiTiet.DoDiem:
                    this.Text = "Chi tiết dò điểm";
                    layoutControlItem01.Text = "Mã giảng viên:";
                    layoutControlItem02.Text = "Họ tên:";

                    AppGridView.InitGridView(gridViewChiTiet, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                    AppGridView.ShowField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "SoBai", "ChiaCho", "TietQuyDoi" },
                        new string[] { "Môn thi", "Khoa tổ chức", "Lần", "Ngày", "Ca", "Phòng", "Thời lượng", "Số bài", "Chia cho", "Tiết quy đổi" },
                        new int[] { 200, 170, 35, 80, 50, 60, 70, 60, 50, 90 });
                    AppGridView.ReadOnlyColumn(gridViewChiTiet);
                    AppGridView.SummaryField(gridViewChiTiet, "SoBai", "{0} bài", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.SummaryField(gridViewChiTiet, "TietQuyDoi", "{0} tiết", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.AlignHeader(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "SoBai", "ChiaCho", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.AlignField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "ThoiLuong", "SoBai", "ChiaCho" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.BackColorFieldAppearance(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, Color.Plum);
                    AppGridView.FixedField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);

                    reader = DataServices.KetQuaThanhToanThuLao.GetSoTietDoDiem((string)_dsThamSo[0], (string)_dsThamSo[1], (string)_dsThamSo[2], (string)_dsThamSo[3], (int)_dsThamSo[4], (string)_dsThamSo[5]);
                    dt = new DataTable();
                    dt.Load(reader);
                    bindingSourceChiTiet.DataSource = dt;
                    break;

                case PMS.Common.LoaiChiTiet.NhapDiem:
                    this.Text = "Chi tiết nhập điểm";
                    layoutControlItem01.Text = "Mã giảng viên:";
                    layoutControlItem02.Text = "Họ tên:";

                    AppGridView.InitGridView(gridViewChiTiet, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                    AppGridView.ShowField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "SoNguoiNhap", "SoBai", "ChiaCho", "TietQuyDoi" },
                        new string[] { "Môn thi", "Khoa tổ chức", "Lần", "Ngày", "Ca", "Phòng", "Số người nhập", "Số bài", "Chia cho", "Tiết quy đổi" },
                        new int[] { 200, 170, 35, 80, 50, 60, 90, 60, 50, 90 });
                    AppGridView.ReadOnlyColumn(gridViewChiTiet);
                    AppGridView.SummaryField(gridViewChiTiet, "SoBai", "{0} bài", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.SummaryField(gridViewChiTiet, "TietQuyDoi", "{0} tiết", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.AlignHeader(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "SoNguoiNhap", "SoBai", "ChiaCho", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.AlignField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi", "NgayThi", "GioThi", "PhongThi", "SoNguoiNhap", "SoBai", "ChiaCho" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.BackColorFieldAppearance(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, Color.Plum);
                    AppGridView.FixedField(gridViewChiTiet, new string[] { "TenMonHoc", "TenKhoaToChuc", "LanThi" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);

                    reader = DataServices.KetQuaThanhToanThuLao.GetSoTietNhapDiem((string)_dsThamSo[0], (string)_dsThamSo[1], (string)_dsThamSo[2], (string)_dsThamSo[3], (int)_dsThamSo[4], (string)_dsThamSo[5]);
                    dt = new DataTable();
                    dt.Load(reader);
                    bindingSourceChiTiet.DataSource = dt;
                    break;

                default:
                    break;
            }
            #endregion

            txtTuyChinh01.Text = _strTuyChinh01;
            txtTuyChinh02.Text = _strTuyChinh02;
            
        }
    }
}

