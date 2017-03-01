using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports.KhongChinhQuy
{
    public partial class rptThanhToanThuLaoTheoKhoaUTE_Kcq : DevExpress.XtraReports.UI.XtraReport
    {
        int sttGV = 0;
        public rptThanhToanThuLaoTheoKhoaUTE_Kcq()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string khoa, string loaiGiangVien, string namHoc, string hocKy, string nguoiLapBieu, TList<UteThanhToanThuLao> dt)
        {
            pTruong.Value = truong.ToUpper();
            pKhoa.Value = khoa.ToUpper();
            pLoaiGiangVien.Value = loaiGiangVien.ToUpper();
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            pNguoiLapBieu.Value = nguoiLapBieu;
            bindingSourceBaoCao.DataSource = dt;
        }

        private void xrTableCell24_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int loaiHocPhan = int.Parse(xrTableCell24.Text);
                switch (loaiHocPhan)
                {
                    case 1:
                        xrTableCell24.Text = "Lý thuyết";
                        break;
                    case 2:
                        xrTableCell24.Text = "Thực hành";
                        break;
                }
            }
            catch
            {
            }
            
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sttGV++;
            xrTableCell15.Text = sttGV.ToString();
        }
    }
}
