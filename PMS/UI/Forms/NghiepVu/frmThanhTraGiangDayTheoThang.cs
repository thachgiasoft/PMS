using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;

using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using System.Globalization;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThanhTraGiangDayTheoThang : DevExpress.XtraEditors.XtraForm
    {
        public DateTime FirstDayOfMonthFromDateTime(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public DateTime LastDayOfMonthFromDateTime(DateTime dateTime)
        {
            DateTime firstDayOfTheMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }

        public frmThanhTraGiangDayTheoThang()
        {
            InitializeComponent();
            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }
        }

        private void frmThanhTraGiangDayTheoThang_Load(object sender, EventArgs e)
        {
            #region Init GridView Thanh tra giang day
            AppGridView.InitGridView(gridViewThanhTraGiangDayTheoNgay, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewThanhTraGiangDayTheoNgay, new string[] { "HoTen", "MaQuanLy", "Khoa", "LoaiGiangVien", "TenHocPhan", "TinhHinhGhiNhan", "Ngay", "Tiet", "Lop", "Phong", "ThoiDiemGhiNhan", "LyDo", "GhiChu" },
                new string[] { "Họ tên", "Mã giảng viên", "Phòng/Khoa", "Loại GV", "Tên HP", "Tình hình ghi nhận", "Ngày", "Tiết", "Lớp", "Phòng", "Thời điểm", "Lý do vi phạm", "Ghi chú" },
                new int[] { 120, 120, 80, 80, 80, 180, 80, 50, 50, 50, 50, 90, 70 });
            #endregion

            #region Init Khoa - don vi
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(gridLookUpEditDonVi, 650, 300);
            AppGridLookupEdit.ShowField(gridLookUpEditDonVi, new string[] { "MaKhoa", "TenKhoa", "MaBoMon", "TenBoMon" }, new string[] { "Mã khoa", "Tên khoa", "Mã bộ môn", "Tên bộ môn" }, new int[] { 90, 210, 90, 210 });
            gridLookUpEditDonVi.Properties.DisplayMember = "TenBoMon";
            gridLookUpEditDonVi.Properties.ValueMember = "MaBoMon";
            gridLookUpEditDonVi.Properties.NullText = string.Empty;
            #endregion

            #region Init Data
            bindingSourceDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            #endregion
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            ViewKhoaBoMon objkhoa = bindingSourceDonVi.Current as ViewKhoaBoMon;
            if (objkhoa != null)
            {
                if (monthYearEdit1.DateTime == DateTime.MinValue || monthYearEdit1.DateTime == DateTime.MaxValue)
                {
                    XtraMessageBox.Show("Bạn chưa chọn từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    monthYearEdit1.Focus();
                    return;
                }

                DateTime firstDayOfMonth = FirstDayOfMonthFromDateTime(monthYearEdit1.DateTime);
                DateTime lastDayOfThisMonth = LastDayOfMonthFromDateTime(monthYearEdit1.DateTime);

                bindingSourceThanhTraGiangDay.DataSource = DataServices.ViewThanhTraGiangDay.GetByTuNgayDenNgayMaDonVi(firstDayOfMonth, lastDayOfThisMonth, objkhoa.MaBoMon);
            }
        }

        private void btn_In_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VList<ViewThanhTraGiangDay> tlist = bindingSourceThanhTraGiangDay.DataSource as VList<ViewThanhTraGiangDay>;
            ViewKhoaBoMon v = bindingSourceDonVi.Current as ViewKhoaBoMon;
            if(tlist!=null && v!=null)
            {
                if (monthYearEdit1.DateTime == DateTime.MinValue || monthYearEdit1.DateTime == DateTime.MaxValue)
                {
                    XtraMessageBox.Show("Bạn chưa chọn từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    monthYearEdit1.Focus();
                    return;
                }

                int month = monthYearEdit1.DateTime.Month;
                using(frmBaoCao frm = new frmBaoCao())
                {
                    frm.InBangThanhTraGiangDayTheoThang(PMS.Common.Globals._cauhinh.TenTruong, v.TenBoMon, month.ToString(), tlist);
                    frm.ShowDialog();
                }
            }
        }
    }
}