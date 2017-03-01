using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptCoVanHocTapTheoNamHocKhoaDonVi : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptCoVanHocTapTheoNamHocKhoaDonVi()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string namHoc, string khoa, int tongSoCoVan, int tongSoSinhVien, string nguoiLapBieu, DataTable data)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namHoc;
            pKhoa.Value = khoa.ToUpper();
            pSoCoVan.Value = tongSoCoVan;
            pSoSinhVien.Value = tongSoSinhVien;
            pNguoiLapBieu.Value = nguoiLapBieu;
            bindingSourceThongke.DataSource = data;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCell40.Text = PMS.Common.Globals.Roman(_sttKhoa, true);
        }

        private void rptCoVanHocTapTheoNamHocKhoaDonVi_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (pKhoa.Value.ToString().Contains(";") == false && pKhoa.Value.ToString() != ("Toàn trường").ToUpper())
            {
                GroupHeader1.Visible = false;
                GroupFooter1.Visible = false;
            }
            if (pKhoa.Value.ToString() == ("Toàn trường").ToUpper())
            {
                xrLabel6.Visible = false;
            }
        }
    }
}
