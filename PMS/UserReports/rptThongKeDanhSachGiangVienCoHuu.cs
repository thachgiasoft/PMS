using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeDanhSachGiangVienCoHuu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeDanhSachGiangVienCoHuu()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string namhoc, string ngaynhanbaocao, DateTime ngayin, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pNgayNhanBaoCao.Value = ngaynhanbaocao;
            //xrLabelNgayThangNam.Text = "TP.HCM, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
           
            bindingSourceThongKe.DataSource = tb;
        }
    }
}
