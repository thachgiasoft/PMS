using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeChiTietGiangDayGiangVienTheoKhoa : DevExpress.XtraReports.UI.XtraReport
    {
        int sttGiangVien = 0, sttLop = 0;
        string _maTruong;
        public rptThongKeChiTietGiangDayGiangVienTheoKhoa()
        {
            InitializeComponent();
        }
        public void InitData(string namHoc, string hocKy, string maKhoa, string tenTruong, string maTruong, DataTable data)
        {
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            pKhoaDonVi.Value = maKhoa.ToUpper();
            pTruong.Value = tenTruong.ToUpper();
            bindingSourceThongKe.DataSource = data;
            this._maTruong = maTruong;
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sttGiangVien += 1;
            xrTableCellSTTGiangVien.Text = sttGiangVien.ToString() + ".";
            sttLop = 0;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sttLop += 1;
            xrTableCellSTTLopHoc.Text = sttLop.ToString();
        }

        private void xrLabelNoiKy_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabelNoiKy.Text = "Thành phố Hồ Chí Minh, ngày";
            if (this._maTruong == "MTU")
                xrLabelNoiKy.Text = "Thành phố Vĩnh Long, ngày";
        }
    }
}
