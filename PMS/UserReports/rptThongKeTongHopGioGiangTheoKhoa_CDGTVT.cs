using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeTongHopGioGiangTheoKhoa_CDGTVT : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeTongHopGioGiangTheoKhoa_CDGTVT()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string namhoc, string hieutruong, string phongdaotao, string loaigiangvien, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pHieuTruong.Value = hieutruong;
            pPhongDaoTao.Value = phongdaotao;
            if (loaigiangvien.ToUpper() == "[TẤT CẢ]")
                pLoaiGiangVien.Value = "";
            else
                pLoaiGiangVien.Value = " " + loaigiangvien.ToUpper();
            lblNgayIn.Text = "TP. Hô Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " nãm " + ngayin.Year.ToString();
            bindingSourceBaoCao.DataSource = tb;
        }

    }
}
