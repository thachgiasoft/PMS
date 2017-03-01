using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeChiTiet_Mau2_CDGTVT : DevExpress.XtraReports.UI.XtraReport
    {
        string _stt = "";
        public rptThongKeChiTiet_Mau2_CDGTVT()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string tenKhoa, string namhoc, string hocky, string hieutruong, string phongdaotao, string truongkhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pKhoa.Value = tenKhoa.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky.ToUpper();
            lblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            DataTable newTb = tb.Clone();
            newTb.Columns["RowNum"].DataType = typeof(string);
            newTb.Columns["RowNum"].ReadOnly = false;
            DataRow fi = tb.Rows[0];
            newTb.ImportRow(fi);
            for (int i = 1; i < tb.Rows.Count; i++)
            {
                newTb.ImportRow(tb.Rows[i]);
                DataRow bk = tb.Rows[i];
                if (fi["RowNum"].ToString() == tb.Rows[i]["RowNum"].ToString())
                {
                    newTb.Rows[i]["RowNum"] = "";
                }

                if (fi["ProfessorID"].ToString() == tb.Rows[i]["ProfessorID"].ToString())
                {
                    newTb.Rows[i]["ProfessorID"] = "";
                }

                if (fi["FullName"].ToString() == tb.Rows[i]["FullName"].ToString())
                {
                    newTb.Rows[i]["FullName"] = "";
                }

                fi = bk;
            }

            bindingSource1.DataSource = newTb;
        }

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (xrTableCell16.Text == "TỔNG CỘNG")
            {
                xrTable2.Font = new Font(new FontFamily("Times New Roman"), 8, FontStyle.Bold);
            }
            else
            {
                xrTable2.Font = new Font(new FontFamily("Times New Roman"), 9, FontStyle.Regular);
            }
        }


    }
}
