using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class BangKeThangToanTienGiangHK_NH : DevExpress.XtraReports.UI.XtraReport
    {
        public BangKeThangToanTienGiangHK_NH()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namHoc, string hocKy, string hieuTruong, string nguoiKeKhai, DateTime _ngayIn, DataTable tb)
        {
            pBGDT.Value = "BỘ GIÁO DỤC VÀ ĐÀO TẠO";
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namHoc.ToUpper();
            pHocKy.Value = hocKy.ToUpper();
            pHieuTruong.Value = hieuTruong;
            pNguoiKeKhai.Value = nguoiKeKhai;
            pNgayIn.Value = string.Format("Tp. Hồ Chí Minh, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", _ngayIn);
            DataSource = tb;
        }

        private void xrLabel27_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            try
            {
                lblTienChu.Text = PMS.Common.Globals.DocTien((int)decimal.Parse(e.Value.ToString()) * (decimal)1.0);
            }
            catch (Exception ex)
            {
                lblTienChu.Text = "Có lỗi xảy ra khi chuyển số thành chữ!";
            }
        }
    }
}
