using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptDanhSachGiangVienDuocSuDungTroGiang : DevExpress.XtraReports.UI.XtraReport
    {
        int _soLuongLopCLC = 0;
        public rptDanhSachGiangVienDuocSuDungTroGiang()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namhoc, string hocky, DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            DataSource = tb;
        }

        private void xrTableCell34_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell34.Text = _soLuongLopCLC.ToString();
        }

        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            if (xrTableCell21.Text == "X")
                _soLuongLopCLC++;
        }
    }
}
