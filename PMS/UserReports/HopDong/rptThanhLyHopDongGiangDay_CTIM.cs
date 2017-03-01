using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptThanhLyHopDongGiangDay_CTIM : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThanhLyHopDongGiangDay_CTIM()
        {
            InitializeComponent();
        }

        public void InitData(DateTime ngayIn, DataTable tb)
        {
            decimal tietQuyDoi = 0;
            decimal thanhTienGiangDay = 0, thanhTienRaDe = 0, thanhTienChamBai = 0, thanhTienTongCong = 0;
            foreach (DataColumn column in tb.Columns)
            {
                column.ReadOnly = false;
            }
            //Tính tổng cho các dòng được chọn in:
            foreach (DataRow item in tb.Rows)
            {
                item["Ngay"] = ngayIn.Day;
                item["Thang"] = ngayIn.Month;
                item["Nam"] = ngayIn.Year;
                tietQuyDoi += (decimal)item["SoTietQuyDoi"];
                thanhTienGiangDay += (decimal)item["ThanhTienGiangDay"];
                thanhTienRaDe += (decimal)item["ThanhTienRaDe"];
                thanhTienChamBai += (decimal)item["ThanhTienChamBai"];
                thanhTienTongCong += (decimal)item["ThanhTienTongCong"];
            }
            //Chỉ hiện ra dòng cuối cho nên cập nhật tất cả các dòng cho chắc:
            foreach (DataRow item in tb.Rows)
            {
                item["SoTietQuyDoi"] = tietQuyDoi;
                item["ThanhTienGiangDay"] = thanhTienGiangDay;
                item["ThanhTienRaDe"] = thanhTienRaDe;
                item["ThanhTienChamBai"] = thanhTienChamBai;
                item["ThanhTienTongCong"] = thanhTienTongCong;
                item["ThanhTienTongCongBangChu"] = PMS.Common.Globals.DocTien(thanhTienTongCong);
            }
            //Gán tb vào data source của report:
            bindingSourceThanhLyHopDong.DataSource = tb;
        }

        private void xrRichText3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }
    }
}
