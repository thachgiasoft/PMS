using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace PMS.UserReports
{
    public partial class rptThongKeChiTietDuTruGioGiangTruocTKB : DevExpress.XtraReports.UI.XtraReport
    {
        string _matruong;
        
        public rptThongKeChiTietDuTruGioGiangTruocTKB()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong,string tenkhoa,string namhoc,string hocky,string hieutruong,string phongdaotao,string truongkhoa,string nguoilapbieu,DateTime ngayin,DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pKhoa.Value = tenkhoa.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky.ToUpper();
            lblNgayIn.Text = "TP. Hồ Chí Minh. ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();

            DataTable newtb = tb.Clone();
            newtb.Columns["RowNum"].DataType = typeof(string);

            DataRow fi = tb.Rows[0];
            newtb.ImportRow(fi);
            for (int i = 1; i < tb.Rows.Count; i++)
            {
                newtb.Columns["RowNum"].ReadOnly = false;
                newtb.Columns["MaQuanLy"].ReadOnly = false;
                newtb.Columns["HoTen"].ReadOnly = false;

                newtb.ImportRow(tb.Rows[i]);
                DataRow bk = tb.Rows[i];
                if (fi["RowNum"].ToString() == tb.Rows[i]["RowNum"].ToString())
                {
                    newtb.Rows[i]["RowNum"] = "";
                }

                if (fi["MaQuanLy"].ToString()==tb.Rows[i]["MaQuanLy"].ToString())
                {
                newtb.Rows[i]["MaQuanLy"]="";
                }

                if (fi["HoTen"].ToString() == tb.Rows[i]["HoTen"].ToString())
                { 
                newtb.Rows[i]["HoTen"]="";
                }

                fi = bk;


            }
            bindingSourceThongKe.DataSource = newtb;
           

        }

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (xrTableCell21.Text.ToUpper() == "TỔNG CỘNG".ToUpper())
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
