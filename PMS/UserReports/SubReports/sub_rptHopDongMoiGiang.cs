using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.SubReports
{
    public partial class sub_rptHopDongMoiGiang : DevExpress.XtraReports.UI.XtraReport
    {
        float _tongTien = 0;
        public float Tien;
        public sub_rptHopDongMoiGiang()
        {
            InitializeComponent();
        }

        public void InitData(DataTable tb)
        {
            bindingSource1.DataSource = tb;
        }

        private void xrTableCell30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell30.Text = _tongTien.ToString("n0");
            Tien = _tongTien;
            _tongTien = 0;
        }

        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            try
            {
                _tongTien += float.Parse(xrTableCell20.Text);
            }
            catch
            {
            }
            
        }
    }
}
