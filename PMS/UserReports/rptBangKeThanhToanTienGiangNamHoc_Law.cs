using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using PMS.UserReports.SubReports;

namespace ReportManager.GV
{
    public partial class rptBangKeThanhToanTienGiangNamHoc_Law : DevExpress.XtraReports.UI.XtraReport
    {
        DataTable _tblTamUng = new DataTable();
        public rptBangKeThanhToanTienGiangNamHoc_Law()
        {
            InitializeComponent();


        }

        public void InitData(string truong, string namHoc, string hocKy, string hieuTruong, string nguoiKeKhai, DateTime _ngayIn, DataTable tb, DataTable tamUng)
        {
            pBGDT.Value = "BỘ GIÁO DỤC VÀ ĐÀO TẠO";
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namHoc.ToUpper();
            pHocKy.Value = hocKy.ToUpper();
            pHieuTruong.Value = hieuTruong;
            pNguoiKeKhai.Value = nguoiKeKhai;
            pNgayIn.Value = string.Format("Tp. Hồ Chí Minh, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", _ngayIn);
            DataSource = tb;

            _tblTamUng = tamUng;
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DataTable tb = new DataTable();
            try
            {
                tb = _tblTamUng.Select("MaGiangVien = '" + lblMaGiangVien.Text + "'").CopyToDataTable();
                sub_rptBangKeThanhToanTienGiangNamHoc_Law2.InitData(pNamHoc.Value.ToString(), tb);
                sub_rptBangKeThanhToanTienGiangNamHoc_Law2.Visible = true;
                xrLabel21.Visible = false;
                xrLabel67.Visible = false;
                xrLabel77.Visible = false;
            }
            catch
            {
                sub_rptBangKeThanhToanTienGiangNamHoc_Law2.Visible = false;
                xrLabel21.Visible = true;
                xrLabel67.Visible = true;
                xrLabel77.Visible = true;
            }
        }
    }
}
