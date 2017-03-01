using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class BCThongKeKQDT_BoiDuongNangCaoCLNguonNhanLuc : DevExpress.XtraReports.UI.XtraReport
    {
        public BCThongKeKQDT_BoiDuongNangCaoCLNguonNhanLuc()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, DateTime ngayIn, string nam, DataTable tb)
        {
            pThoiDiem.Value = nam;
            //pNam.Value = nam;
            bindingSourceThongKe.DataSource = tb;
        }
    }
}
