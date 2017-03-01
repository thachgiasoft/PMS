using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptDanhSachGiangVien : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0, _sttGV = 0;
        string _maTruong;
        public rptDanhSachGiangVien()
        {
            InitializeComponent();
            xrLabel2.Visible = false;
        }

        public void InitData(string maTruong, string truong, string khoa, string nguoiLapBieu, DataTable tb)
        {
            this._maTruong = maTruong;
            pTruong.Value = truong.ToUpper();
            pKhoa.Value = khoa.ToUpper();
            if (_maTruong == "UTE")
                pKhoa.Value = "KHOA " + khoa.ToUpper();
            pNguoiLapBieu.Value = nguoiLapBieu;
            bindingSourceBaoCao.DataSource = tb;
        }

        private void rptDanhSachGiangVien_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (_maTruong == "UTE")
            {
                if (pKhoa.Value != "KHOA ")
                {
                    GroupHeader2.Visible = false;
                    GroupFooter2.Visible = false;
                    xrLabel2.Visible = true;
                }
            }
            else
            { 
                if(pKhoa.Value != "")
                {
                    GroupHeader2.Visible = false;
                    GroupFooter2.Visible = false;
                    xrLabel2.Visible = true;
                }
            }
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            _sttGV = 0;
            xrTableCellSTTKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true);

            if (_maTruong == "VHU")
            {
                xrTableCell25.Text = "";
                xrTableCell25.WidthF = 5;
            }
            //xrTable4.DeleteColumn(xrTableCell25);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttGV++;
            xrTableCellSTTGV.Text = _sttGV.ToString();
        }
    }
}
