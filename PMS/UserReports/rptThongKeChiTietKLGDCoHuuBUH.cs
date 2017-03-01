using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeChiTietKLGDCoHuuBUH : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime NgayIn;
        public rptThongKeChiTietKLGDCoHuuBUH()
        {
            InitializeComponent();
        }

        public void InitData(string matruong, string tentruong, string namhoc, string hocky, string bacdaotao, string nguoilapbieu, string truongphongdaotao, DateTime ngayin, string loaigiangvien, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pNguoiLapBieu.Value = nguoilapbieu;
            pTruongPhongDaoTao.Value = truongphongdaotao;
            NgayIn = ngayin;
            pLoaiGiangVien.Value = loaigiangvien.ToUpper();
            bindingSourceThongKe.DataSource = tb;

            if (matruong == "UEL")
            {
                if (bacdaotao.ToUpper() == "DH")//Bậc đại học
                    pHeDaoDao.Value = "HỆ ĐẠI HỌC CHÍNH QUY";
                else if (!bacdaotao.ToUpper().Contains("DH"))
                    pHeDaoDao.Value = "HỆ SAU ĐẠI HỌC";
                else pHeDaoDao.Value = "TOÀN TRƯỜNG";
            }
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabelNgayIn.Text = "TP.HCM, Ngày " + NgayIn.ToString("dd") + " tháng " + NgayIn.ToString("MM") + " năm " + NgayIn.ToString("yyyy");
        }

    }
}
