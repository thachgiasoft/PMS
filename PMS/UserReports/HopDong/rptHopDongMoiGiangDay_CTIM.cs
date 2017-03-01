using System;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptHopDongMoiGiangDay_CTIM : XtraReport
    {
        string tienChu = "";

        public rptHopDongMoiGiangDay_CTIM()
        {
            InitializeComponent();
        }

        public void InitData(DateTime ngayIn, DataTable tb)
        {
            bindingSourceHDMoiGiangDay.DataSource = tb;

            foreach (DataColumn column in tb.Columns)
            {
                column.ReadOnly = false;
            }

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tb.Rows[i]["Ngay"] = ngayIn.Day;
                tb.Rows[i]["Thang"] = ngayIn.Month;
                tb.Rows[i]["Nam"] = ngayIn.Year;
            }
        }

        private void xrLabel66_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                //decimal tien = decimal.Parse(xrLabel66.Text);
                //tienChu = PMS.Common.Globals.DocTien(tien);
                pTongGiaTriHDBangChu.Value = tienChu.Trim();

                //lblTienChu.Text = tienChu.Trim() +  "), được tạm tính như sau:";

                DataTable data = bindingSourceHDMoiGiangDay.DataSource as DataTable;

                if (data == null)
                    return;
                DataTable vListBaoCao = data;
                //if (vListBaoCao == null)
                    return;
                string sort = "";
              
                string filter = "MaGiangVien = '" + lblMaGiangVien.Text + "'";

                //string filter = gridViewHopDongMoiGiangVien.ActiveFilterString;
                //vListBaoCao = dv.ToTable();
                //if (vListBaoCao == null)
                    return;

                vListBaoCao.AcceptChanges();
                //sub_rptHopDongMoiGiang2.InitData(vListBaoCao);
            }
            catch
            { }
        }

        private void lblKhoaBoMon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void xrLabel44_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
