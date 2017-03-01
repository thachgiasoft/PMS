using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace PMS.UserReports
{
    public partial class rptThongKeChiTietDuTruKhiDaCoLHPNhungChuaCoTKB : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeChiTietDuTruKhiDaCoLHPNhungChuaCoTKB()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong,string tenkhoa,string namhoc,string hocky,string hieutruong,string phongdaotao,string truongkhoa,DateTime ngayin,DataTable dt)
            {
                pTruong.Value = tentruong.ToUpper();
                pKhoa.Value = tenkhoa.ToUpper();
                pNamHoc.Value = namhoc;
                pHocKy.Value = hocky;
                pHieuTruong.Value = hieutruong;
                pPhongDaoTao.Value = phongdaotao;
                pTruongKhoa.Value = truongkhoa;
                bindingSourceThongKe.DataSource = dt;
                lblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
        }

    }
}
