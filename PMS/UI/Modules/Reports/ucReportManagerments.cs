using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraGrid.Views.Grid;

namespace PMS.UI.Modules.Reports
{
    public partial class ucReportManagerments : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        #endregion
        public ucReportManagerments()
        {
            InitializeComponent();
        }

        private void ucReportManagerments_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewReport, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewReport, new string[] { "ReportName" }, new string[] { "Tên báo cáo" }, new int[] { 500 });
            AppGridView.ReadOnlyColumn(gridViewReport);
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            dateEditThoiDiemThongKe.EditValue = DateTime.Now;

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }

            bindingSourceReport.DataSource = DataServices.ReportManagerments.GetAll();
        }

        private void gridControlReport_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ReportManagerments row = gridViewReport.GetFocusedRow() as ReportManagerments;
            if (row != null)
            {
                DataTable data = new DataTable();
                IDataReader reader = DataServices.ReportManagerments.GetData(row.Id, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), dateEditThoiDiemThongKe.DateTime);
                data.Load(reader);

                //if (data == null)
                //    return;

                using (frmChonNgay frmChon = new frmChonNgay())
                {
                    frmChon.ShowDialog();
                    _ngayIn = frmChon.NgayIn;
                }

                gridViewReport.FocusedRowHandle = -1;
                bindingSourceReport.EndEdit();

               
                DataTable vListBaoCao = data;
                ////if (vListBaoCao == null)
                //    return;
                string sort = "";
                if (vListBaoCao != null)
                {
                    if (vListBaoCao.Rows.Count != 0)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewReport.SortedColumns)
                        {
                            switch (c.SortOrder)
                            {
                                case DevExpress.Data.ColumnSortOrder.Ascending:
                                    sort += string.Format("{0} ASC, ", c.FieldName);
                                    break;
                                case DevExpress.Data.ColumnSortOrder.Descending:
                                    sort += string.Format("{0} DESC, ", c.FieldName);
                                    break;
                            }
                        }
                    }
                    if (sort != "")
                        sort = sort.Substring(0, sort.Length - 2);
                }

                string filter = gridViewReport.ActiveFilterString;
                //if (filter.Contains(".0000m"))
                //    filter = filter.Replace(".0000m", "");
                //if (filter.Contains(".000m"))
                //    filter = filter.Replace(".000m", "");
                //if (filter.Contains(".00m"))
                //    filter = filter.Replace(".00m", "");
                //if (filter.Contains(".0m"))
                //    filter = filter.Replace(".0m", "");
                //if (filter.Contains(".m"))
                //    filter = filter.Replace(".m", "");

                //string filter = gridViewHopDongMoiGiangVien.ActiveFilterString;
                //vListBaoCao = dv.ToTable();
                ////if (vListBaoCao == null)
                //    return;

                if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
                {
                    using (frmBaoCao frm = new frmBaoCao())
                    {
                        if (row.Id == 1)
                        {
                            frm.InHoSoGiangVien(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 2)
                        {
                            frm.InDanhSachCanBoGiangVien(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.ToShortDateString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 3)
                        {
                            frm.InBaoCaoTrinhDoChuyenMonNghiepVu(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 4)
                        {
                            frm.InBaoCaoSoLuongVaChatLuongVienChuc(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 5)
                        {
                            frm.InBaoCaoThongKeKetQuaDaoTaoTaoBoiDuong(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.ToShortDateString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 6)
                        {
                            frm.InDanhSachGiangVienGiangDayChinhQuy(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 7)
                        {
                            frm.InBaoCaoChatLuongCanBo(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 8)
                        {
                            frm.InThongKeDoiNguCanBoQuanLyTrongCoSoDayNghe(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 9)
                        {
                            frm.InBaoCaoSoLuongChatLuongCoCauDoiNguVienChuc(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 10)
                        {
                            frm.InBaoCaoChatLuongCanBoCongChuc(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 11)
                        {
                            frm.InBaoCaoTHongKeDoiNguGiangVienGiaoVienDayNghe(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 12)
                        {
                            frm.InBaoCaoThongKeTrinhDoNghiepVuSuPhamTInHocNgoaiNgu(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 13)
                        {
                            frm.InBaoCaoThongKeTrinhDoNghiepVuSuPhamTinHocNgoaiNguChinhTri(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 14)
                        {
                            frm.InBaoCaoThongKeDoiNguCanBoQuanLyNhanVienNghiepVuCacTruongChuyenNghiep(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 15)
                        {
                            frm.InBaoCaoThongKeDoiNguCanBoQuanLyNhanVienNghiepVu(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 16)
                        {
                            frm.InBaoCaoThongKeTrinhDoChuyenMonVaThamNienGiangDay(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }

                        if (row.Id == 17)
                        {
                            frm.InBaoCaoThongKeToChucBoMay(PMS.Common.Globals._cauhinh.TenTruong, _ngayIn, dateEditThoiDiemThongKe.DateTime.Year.ToString(), vListBaoCao);
                            frm.ShowDialog();
                        }
                    }
                }
                
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewReport_Click(object sender, EventArgs e)
        {
            AppGridView.ConditionsAdjustment(gridViewReport, "ReportName", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.DarkOrange, "ReportName");
            
        }

        private void gridViewReport_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

    }
}
