using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeChiTietKLGDThinhGiangUEL : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime NgayIn;
        public rptThongKeChiTietKLGDThinhGiangUEL()
        {
            InitializeComponent();
        }
        public void InitData(string tentruong, string namhoc, string hocky, string nguoilapbieu, string truongphongdaotao, DateTime ngayin, string loaigiangvien, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pNguoiLapBieu.Value = nguoilapbieu;
            pTruongPhongDaoTao.Value = truongphongdaotao;
            NgayIn = ngayin;
            pLoaiGiangVien.Value = loaigiangvien.ToUpper();
            bindingSourceThongKe.DataSource = tb;
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabelNgayIn.Text = "TP.HCM, Ngày " + NgayIn.ToString("dd") + " tháng " + NgayIn.ToString("MM") + " năm " + NgayIn.ToString("yyyy");
        }
    }
}
