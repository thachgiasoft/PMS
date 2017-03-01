using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeDuTruTruocTKBTheoNam : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptThongKeDuTruTruocTKBTheoNam()
        {
            InitializeComponent();

        }



        public void InitData(string truong,string namhoc,string nguoiLapBieu,DateTime ngayin,DataTable dt)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            xrLabel5.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            pNguoiLapBieu.Value = nguoiLapBieu;
            bindingSourceThongKe.DataSource = dt;
        
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCellSTTKhoa.Text = _sttKhoa.ToString();
        }
    }
}
