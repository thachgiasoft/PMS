using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace HocPhi.UI.Forms.New.Report
{
    public partial class ThongKeDSSVRaKTX : DevExpress.XtraReports.UI.XtraReport
    {
        public ThongKeDSSVRaKTX()
        {
            InitializeComponent();
        }

        public void InitData(string boGiaoDuc, string tenTruong, string tuNgay, string denNgay, string nguoiLapBieu, DataTable dt)
        {
            pBoGiaoDuc.Value = boGiaoDuc;
            pTenTruong.Value = tenTruong;
            pTuNgay.Value = tuNgay;
            pDenNgay.Value = denNgay;
            pNguoiLapBieu.Value = nguoiLapBieu;
            DataTable dt2 = dt.Copy();
            AdColumns(dt2);
            bindingSourceSinhVien.DataSource = dt2;
            pNgay.Value = DateTime.Now.Day.ToString();
            pThang.Value = DateTime.Now.Month.ToString();
            pNam.Value = DateTime.Now.Year.ToString();
            
        }
        
        void AdColumns(DataTable dt)
        {

            int countCel = xrTableRow1.Cells.Count;
            int countCel2 = xrTableRow2.Cells.Count;
            int countCel3 = xrTableRow3.Cells.Count;
            float width = xrTableRow3.WidthF;
            if (dt.Columns.Count > 15)
            {
                xrTableRow1.Cells[countCel - 1].WidthF = 820;
                xrTableRow2.Cells[countCel2 - 1].WidthF = 820;
                xrTable4.WidthF = 820;
                xrTable5.WidthF = 820;
                xrTable6.WidthF = 820;
                xrTableRow3.Cells[countCel3 - 1].WidthF = width;
                xrTableRow5.Cells.Clear();
                xrTableRow6.Cells.Clear();
                xrTableRow7.Cells.Clear();
                
                for (int i = 15; i < dt.Columns.Count; i++)
                {
                    XRTableCell tc = new XRTableCell();
                    tc.Name = dt.Columns[i].ColumnName;
                    tc.WidthF = 70;
                    tc.Text = dt.Columns[i].ColumnName;
                    tc.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom;
                    xrTableRow5.Cells.Add(tc);

                    XRTableCell tcdata = new XRTableCell();
                    tcdata.Name = dt.Columns[i].ColumnName + "data";
                    tcdata.StylePriority.UseTextAlignment = false;                        
                    tcdata.Text = "[" + dt.Columns[i].ColumnName + "!n0]";
                    tcdata.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    tcdata.WidthF = 70;
                    tcdata.Borders = DevExpress.XtraPrinting.BorderSide.Left;
                    xrTableRow6.Cells.Add(tcdata);
                    
                    XRTableCell tcsum = new XRTableCell();
                    tcsum.Name = dt.Columns[i].ColumnName + "sum";
                    tcsum.StylePriority.UseTextAlignment = false;
                    tcsum.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                            new DevExpress.XtraReports.UI.XRBinding("Text", null, dt.Columns[i].ColumnName)});
                    tcsum.Summary.Func = SummaryFunc.Count;
                    tcsum.Summary.Running = SummaryRunning.Group;
                    tcsum.Summary.IgnoreNullValues = true;
                    tcsum.Summary.FormatString = "{0:n0}";
                    tcsum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    tcsum.WidthF = 70;
                    tcsum.Borders = DevExpress.XtraPrinting.BorderSide.Left;
                    xrTableRow7.Cells.Add(tcsum);
                }
            }            
            width = 524 + (xrTableRow5.Cells.Count) * 70;

            xrTableRow1.WidthF = width;
            xrTableRow2.WidthF = width;
            xrTableRow3.WidthF = width;
            xrTable4.WidthF = (xrTableRow5.Cells.Count) * 70;
            xrTable5.WidthF = (xrTableRow5.Cells.Count) * 70;
            xrTable6.WidthF = (xrTableRow5.Cells.Count) * 70;
            xrcTDLyDo.WidthF = (xrTableRow5.Cells.Count) * 70;
            xrTableRow4.WidthF = (xrTableRow5.Cells.Count) * 70;
            xrTableRow5.WidthF = (xrTableRow5.Cells.Count) * 70;
            xrTableRow6.WidthF = (xrTableRow5.Cells.Count) * 70;
            xrTableRow7.WidthF = (xrTableRow5.Cells.Count) * 70;

            width = (xrTableRow5.Cells.Count) * 70;
            xrcTinhTrang.WidthF = width;
            xrcTinhTrang2.WidthF = width;
            xrcTinhTrangSum.WidthF = width;

            xrTableRow1.Cells[0].WidthF = 39;
            xrTableRow2.Cells[0].WidthF = 39;
            xrTableRow3.Cells[0].WidthF = 136;

            xrcMSSV.WidthF = 97;
            xrcHoTen.WidthF = 213;
            xrcLop.WidthF = 109;
            xrcPhong.WidthF = 66;
            
            xrcMSSV2.WidthF = 97;
            xrcHo.WidthF = 146;
            xrTen.WidthF = 67;
            xrcLop2.WidthF = 109;
            xrcPhong2.WidthF = 66;

            for (int i = 0; i < xrTableRow5.Cells.Count; i ++)
            {
                xrTableRow5.Cells[i].WidthF = 70;
                xrTableRow6.Cells[i].WidthF = 70;
                xrTableRow7.Cells[i].WidthF = 70;
            }

            width = 0;
            for (int i = 2; i < countCel - 1; i++)
            {
                width += xrTableRow1.Cells[i].WidthF;
            }
            xrTableRow3.Cells[1].WidthF = width;

            if (xrTableRow1.WidthF <= 850 - this.Margins.Left - this.Margins.Right)
            {
                this.Landscape = false;
                xrLabel1.LocationF = new PointF() { X = 522, Y = 0 };
                xrLabel14.LocationF = new PointF() { X = 522, Y = 23 };
                xrLabel4.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
                xrLabel3.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
                xrPanel1.LocationF = new PointF() { X = 0, Y = 0 };
                float canhGiua = (this.PageWidth - this.Margins.Left - this.Margins.Right - xrTableRow1.WidthF) / 2;
                xrTable1.LocationF = new PointF() { X = canhGiua, Y = 0 };
                xrTable2.LocationF = new PointF() { X = canhGiua, Y = 0 };
                xrTable3.LocationF = new PointF() { X = canhGiua, Y = 0 };
            }
            else
            {
                this.Landscape = true;
                xrLabel1.LocationF = new PointF() { X = 769, Y = 0 };
                xrLabel14.LocationF = new PointF() { X = 769, Y = 23 };
                xrLabel4.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
                xrLabel3.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
                xrPanel1.LocationF = new PointF() { X = 246, Y = 0 };
                float canhGiua = (this.PageWidth - this.Margins.Left - this.Margins.Right - xrTableRow1.WidthF) / 2;
                xrTable1.LocationF = new PointF() { X = canhGiua, Y = 0 };
                xrTable2.LocationF = new PointF() { X = canhGiua, Y = 0 };
                xrTable3.LocationF = new PointF() { X = canhGiua, Y = 0 };
            }
        }

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {            
            //for (int i = 1; i < xrTableRow1.Cells.Count - c1 + 1; i++)
            //{
                
            //    //if (xrTableRow2.Cells[c2 + i - 1].Text == "1")
            //        xrTableRow2.Cells[c2 + i - 1].Text = "X";
            //}
        }
    }
}