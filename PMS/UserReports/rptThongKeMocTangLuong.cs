using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptThongKeMocTangLuong : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0,_sttGV=0;
        string _matruong;


        public rptThongKeMocTangLuong()
        {
            InitializeComponent();
            xrLabel8.Visible = false;
        }

        public void InitData(string truong,string khoa,string nguoilapbieu,DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            pKhoa.Value = khoa.ToUpper();
            if (_matruong == "UTE")
                pKhoa.Value = "KHOA" + khoa.ToUpper();
            pNguoiLapBieu.Value = nguoilapbieu;
            
            bindingSourceBaocao.DataSource = tb;

        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            _sttGV = 0;
            xrTableCellSTTKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttGV++;
            xrTableCellSTTGV.Text = _sttGV.ToString();
        }

        private void rptThongKeMocTangLuong_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if(_matruong=="UTE")
            {
                if (pKhoa.Value != "KHOA")
                {
                    GroupHeader1.Visible = false;
                    GroupFooter1.Visible = false;
                    xrLabel8.Visible = true;
                }
            }
            else
            {
                if (pKhoa.Value != "")
                {
                    GroupHeader1.Visible = false;
                    GroupFooter1.Visible = false;
                    xrLabel8.Visible = true;
                }
            }
        }

    }
}
