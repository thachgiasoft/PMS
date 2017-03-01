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
    public partial class frmTienDoGiangDayChiTiet : DevExpress.XtraEditors.XtraForm
    {
        private string maGocLopHocPhan;
        private string maLopHocPhan;
        private string tenHocPhan;
        public frmTienDoGiangDayChiTiet()
        {
            InitializeComponent();
        }

        public frmTienDoGiangDayChiTiet(string _maGocLopHocPhan,string _maLopHocPhan,string _tenHocPhan)
        {
            InitializeComponent();
            this.maGocLopHocPhan = _maGocLopHocPhan;
            this.maLopHocPhan = _maLopHocPhan;
            this.tenHocPhan = _tenHocPhan;
        }

        private void frmTienDoGiangDayChiTiet_Load(object sender, EventArgs e)
        {
            #region Thoi Khoa Bieu
            AppGridView.InitGridView(gridViewTienDoGiangDayChiTiet, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewTienDoGiangDayChiTiet, new string[] { "TuanHienThi", "NgayTrongTuan", "KhoanTiet", "SoTiet", "TenPhong", "NgayDay", "MaGiangVien", "HoTen" },
                new string[] { "Tuần", "Thứ", "Khoản tiết", "Số tiết", "Phòng", "Ngày dạy", "Mã giảng viên", "Họ tên" },
                new int[] { 80, 80, 80, 80, 70, 90, 100, 130 });
            AppGridView.ReadOnlyColumn(gridViewTienDoGiangDayChiTiet);
            AppGridView.SummaryField(gridViewTienDoGiangDayChiTiet, "TuanHienThi", "Số tuần= {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewTienDoGiangDayChiTiet, "SoTiet", "Số tiết= {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.BackColorFieldAppearance(gridViewTienDoGiangDayChiTiet, "TuanHienThi", Color.Gold);
            #endregion

            txtMaHP.Text = maLopHocPhan;
            txtTenHP.Text = tenHocPhan;
            bindingSourcePhanCongChiTiet.DataSource = DataServices.ViewChiTietPhanCongGiangDay.GetByMaLopHocPhan(maGocLopHocPhan);
        }
    }
}