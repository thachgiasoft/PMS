using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using PMS.Services;

namespace PMS.UserReports
{
    public partial class rptChiTietKhoiLuongGiangDay_VHU : DevExpress.XtraReports.UI.XtraReport
    {
        public rptChiTietKhoiLuongGiangDay_VHU()
        {
            InitializeComponent();
        }

        public void InitData(string namhoc, string hocky, string truong, string phongtochuccanbo, string phongdaotao, string nguoilapbieu, DataTable db)
        {
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pTruong.Value = truong.ToUpper();
            pNguoiLapBieu.Value = nguoilapbieu;
            pPhongToChucCanBo.Value = phongtochuccanbo;
            pPhongDaoTao.Value = phongdaotao;
            bindingSourceThongKe.DataSource = db;
        }

        private void xrTableCell35_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
        //Loai: LT, TH...
        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
        string IsNull(string s)
        {
            if (s == "")
                return "0";
            else
                return s;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

    }
}
