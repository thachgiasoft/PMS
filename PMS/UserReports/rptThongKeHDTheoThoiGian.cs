using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeHDTheoThoiGian : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0,_sttHD=0;
        string _matruong;
        public rptThongKeHDTheoThoiGian()
        {
            InitializeComponent();
            xrLabel3.Visible = false;
        }

        public void InitData(string truong, string khoa, string nguoiLapBieu, DataTable tb)
        {
     
            pTruong.Value = truong.ToUpper();
            pKhoa.Value = khoa.ToUpper();
            if (_matruong == "UTE")
                pKhoa.Value = "KHOA" + khoa.ToUpper();
            pNguoiLapBieu.Value = nguoiLapBieu;
            bindingSourceBaoCao.DataSource = tb;

        }

        
        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            _sttHD = 0;
            xrTableCell1STTKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttHD++;
            xrTableCellSTTHD.Text = _sttHD.ToString();
        }

        private void rptThongKeHDTheoThoiGian_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (_matruong == "UTE")
            {
                if (pKhoa.Value != "KHOA")
                {
                    GroupHeader2.Visible = false;
                    GroupFooter1.Visible = false;
                    xrLabel3.Visible = true;

                }
            }
            else
            {
                if (pKhoa.Value != "")
                {
                    GroupHeader2.Visible = false;
                    GroupFooter1.Visible = false;
                    xrLabel3.Visible = true;
                }
            }
        }

        private void bindingSourceBaoCao_CurrentChanged(object sender, EventArgs e)
        {

        }


    }
}
