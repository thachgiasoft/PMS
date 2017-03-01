using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class BangThanhTraGiangDayTheoThang : DevExpress.XtraReports.UI.XtraReport
    {
        public BangThanhTraGiangDayTheoThang()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string khoa, string thang, VList<ViewThanhTraGiangDay> list)
        {
            pTruong.Value = truong.ToUpper();
            pKhoa.Value = khoa;
            pThang.Value = thang;
            bindingSourceThanhTraGiangDay.DataSource = list;
        }
    }
}
