using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptThongKeDuTruCaNamTheoGiangVien : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0,_sttGV=0;
        public rptThongKeDuTruCaNamTheoGiangVien()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong,string namhoc,string hieutruong,string phongdaotao,DateTime ngayin,DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pHieuTruong.Value = hieutruong;
            pPhongDaoTao.Value = phongdaotao;
            lblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            bindingSourceBaoCao.DataSource = tb;

        }

        private void xrTableCell42_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            _sttGV = 0;
            xrTableCellSTTKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true)+".";
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttGV++;
            xrTableCellSTTGV.Text = _sttGV.ToString();
        }

    }
}
