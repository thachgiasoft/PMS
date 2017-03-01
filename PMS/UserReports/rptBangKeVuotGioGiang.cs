using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.Reports
{
    public partial class rptBangKeVuotGioGiang : DevExpress.XtraReports.UI.XtraReport
    {
        DataTable dtData;
        DataTable dtNoiDung;
        int _dem = 1;
        DataTable _listGiangVien = new DataTable();
        string _maGiangVien;

        decimal _tongMonHoc = 0, _tietChuanNghiaVu = 0, _tietVuot = 0, _tongTietThanhToanChuaTruNo = 0;
            

        public rptBangKeVuotGioGiang()
        {
            InitializeComponent();

            this.xrSubreport1.BeforePrint += xrSubreport1_BeforePrint;
        }

        void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DataRow[] dtS = dtData.Select(string.Format("MaGiangVien = '{0}'", GetCurrentColumnValue("MaGiangVien")));

            if (dtS.Length > 0)
            {
                this.xrSubreport1.Visible = true;
                xrLabel15.Visible = true;
                this.xrSubreport1.ReportSource.DataSource = dtS.CopyToDataTable();
            }
            else
            {
                this.xrSubreport1.Visible = false;
                xrLabel15.Visible = false;
            }
        }
        public void InitData(DataSet dsDataSource, DataTable dt, DateTime ngayIn)
        {
            //this.DataSource = dsDataSource.Tables["NoiDung"];
            dtData = dsDataSource.Tables["GiamDinhMuc"];
            this.xrSubreport1.ReportSource = new subGiamDinhMuc(dtData);
            this.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;

            dtNoiDung = dsDataSource.Tables["NoiDung"] as DataTable;

            //Tạo bảng tạm để show checkbox HH, HV
            DataColumn colMaGiangVien = new DataColumn("MaGiangVien", typeof(System.String));
            DataColumn colStt = new DataColumn("STT", typeof(System.Int32));
            DataColumn colChucDanh = new DataColumn("ChucDanh", typeof(System.String));
            DataColumn colHocHam_HocVi = new DataColumn("HocHam_HocVi", typeof(System.String));
            _listGiangVien.Columns.Add(colMaGiangVien);
            _listGiangVien.Columns.Add(colStt);
            _listGiangVien.Columns.Add(colChucDanh);
            _listGiangVien.Columns.Add(colHocHam_HocVi);
            int _stt = 0;
            foreach (DataRow r in dtNoiDung.Rows)
            {
                string _ma ="";
                try
                {
                    _ma = _listGiangVien.Select(String.Format("MaGiangVien ='{0}'", r["MaGiangVien"]))[0]["MaGiangVien"].ToString();
                }
                catch
                {
                    _ma = "";
                }
                
                if (r["MaGiangVien"].ToString() != _ma)
                {
                    _stt++;
                    DataRow gv = _listGiangVien.NewRow();
                    gv["MaGiangVien"] = r["MaGiangVien"].ToString();
                    gv["STT"] = _stt;
                    gv["ChucDanh"] = r["ChucDanh"].ToString();
                    gv["HocHam_HocVi"] = r["HocHam_HocVi"].ToString();

                    _listGiangVien.Rows.Add(gv);
                }
            }

            this.DataSource = dtNoiDung;

            if (ngayIn == DateTime.MinValue)
                lblNgayIn.Text = "Ngày ......... tháng ......... năm ......... ";
            else
                lblNgayIn.Text = string.Format("Ngày {0} tháng {1} năm {2}", ngayIn.Day, ngayIn.Month, ngayIn.Year);
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            checkEditGiangVien.EditValue = false;
            checkEditPGS_GVC.EditValue = false;
            checkEditGS_GVCC.EditValue = false;
            checkEditCuNhan.EditValue = false;
            checkEditThacSy.EditValue = false;
            checkEditThS_GVC.EditValue = false;
            checkEditTienSy.EditValue = false;
            checkEditTS_GVC.EditValue = false;
            checkEditPhoGiaoSu.EditValue = false;
            checkEditPGS_GVC.EditValue = false;

            DataRow r = _listGiangVien.NewRow();

            r = _listGiangVien.Select(String.Format("STT='{0}'", _dem))[0];

            {
                //Chức danh
                if (r["ChucDanh"].ToString() == "Giảng viên") checkEditGiangVien.EditValue = true;
                if (r["ChucDanh"].ToString() == "Phó giáo sư" || r["ChucDanh"].ToString() == "Giảng viên chính") checkEditPGS_GVC.EditValue = true;
                if (r["ChucDanh"].ToString() == "Giáo sư" || r["ChucDanh"].ToString() == "Giảng viên cao cấp") checkEditGS_GVCC.EditValue = true;

                //Học hàm học vị
                if (r["HocHam_HocVi"].ToString() == "Cử nhân") checkEditCuNhan.EditValue = true;
                if (r["HocHam_HocVi"].ToString() == "Thạc sĩ") checkEditThacSy.EditValue = true;
                if (r["HocHam_HocVi"].ToString() == "Thạc sĩ" && r["ChucDanh"].ToString() == "Giảng viên chính")
                {
                    checkEditThS_GVC.EditValue = true;
                    checkEditThacSy.EditValue = false;
                    checkEditPGS_GVC.EditValue = false;
                }
                if (r["HocHam_HocVi"].ToString() == "Tiến sĩ") checkEditTienSy.EditValue = true;
                if (r["HocHam_HocVi"].ToString() == "Tiến sĩ" && r["ChucDanh"].ToString() == "Giảng viên chính")
                {
                    checkEditTS_GVC.EditValue = true;
                    checkEditPGS_GVC.EditValue = false;
                    checkEditTienSy.EditValue = false;
                }
                if (r["ChucDanh"].ToString() == "Phó giáo sư") checkEditPhoGiaoSu.EditValue = true;
                if (r["ChucDanh"].ToString() == "Giáo sư") checkEditGS_GVCC.EditValue = true;
            }
        }

        private void lblMaGiangVien_AfterPrint(object sender, EventArgs e)
        {
            _dem++;
        }

        private void xrTableCell43_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void xrTableCell41_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            //_tongMonHoc = (decimal)e.Value;
        }

        private void xrTableCell42_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            //_tietChuanNghiaVu = (decimal)e.Value;
            //_tietVuot = (_tongMonHoc - _tietChuanNghiaVu);
        }

        private void xrTableCell43_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            //xrTableCell43.Text = _tietVuot.ToString();
        }

        private void xrTableCell41_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel6.Text = (decimal.Parse(PMS.Common.Globals.IsNull(xrLabel12.Text, "decimal").ToString()) 
                    + decimal.Parse(PMS.Common.Globals.IsNull(xrLabel14.Text, "decimal").ToString())).ToString();
        }

    }
}
