﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeTongHopGioGiangBUH : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime NgayIn;
        public rptThongKeTongHopGioGiangBUH()
        {
            InitializeComponent();
        }
        public void InitData(string tentruong, string namhoc, string hocky, string nguoilapbieu, string truongphongKHTC, string hieutruong, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pNguoiLapBieu.Value = nguoilapbieu;
            pTruongPhongKHTC.Value = truongphongKHTC;
            pHieuTruong.Value = hieutruong;
            NgayIn = ngayin;
            bindingSourceThongKe.DataSource = tb;
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabelNgayIn.Text = "TP.HCM, Ngày " + NgayIn.ToString("dd") + " tháng " + NgayIn.ToString("MM") + " năm " + NgayIn.ToString("yyyy");
        }
    }
}