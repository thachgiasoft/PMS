using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using PMS.Services;

namespace PMS.UserReports
{
    public partial class rptChiTietKhoiLuongGiangDay_HBU : DevExpress.XtraReports.UI.XtraReport
    {
        //decimal _tienChu;

        public rptChiTietKhoiLuongGiangDay_HBU()
        {
            InitializeComponent();
            //_tienChu = 0;
        }

        public void InitData(DateTime ngayIn, DataTable db)
        {
            pNgayIn.Value = ngayIn.Day;
            pThangIn.Value = ngayIn.Month;
            pNamIn.Value = ngayIn.Year;
            //foreach (DataColumn col in db.Columns)
            //{
            //    col.ReadOnly = false;
            //}
            //foreach (DataRow row in db.Rows)
            //{
            //    _tienChu += row["T"];
            //}
            //foreach (DataRow row in db.Rows)
            //{
            //    row["TienBangChu"] = PMS.Common.Globals.DocTien(_tienChu);
            //}
            this.DataSource = db;
        }
    }
}
