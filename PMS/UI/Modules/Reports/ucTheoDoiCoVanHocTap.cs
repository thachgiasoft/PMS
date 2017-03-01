using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Modules.Reports
{
    public partial class ucTheoDoiCoVanHocTap : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        #endregion
        public ucTheoDoiCoVanHocTap()
        {
            InitializeComponent();
            #region Init CauHinh
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll() as TList<CauHinh>;
            foreach (CauHinh ch in listCauHinh)
                if (ch.TrangThai == true)
                    PMS.Common.Globals._cauhinh = ch;
            #endregion
        }

        private void ucTheoDoiCoVanHocTap_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenMonHoc", "SiSo", "SoTiet", "HeSoCoVanHocTap", "TietQuyDoi" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ tên", "Chức vụ", "Sĩ số", "Số tiết", "Hệ số CVHT", "Tiết quy đổi" }
                , new int[] { 180, 100, 170, 120, 70, 70, 70, 70 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenMonHoc", "SiSo", "SoTiet", "HeSoCoVanHocTap", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.AlignField(gridViewThongKe, new string[] { "SiSo", "SoTiet", "HeSoCoVanHocTap" }, DevExpress.Utils.HorzAlignment.Center);
            gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.CoVanHocTap.TheoDoiTheoNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
                gridViewThongKe.ExpandAllGroups();
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
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

            //string filter = gridViewThongKe.ActiveFilterString;
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
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InTheoDoiCVHT(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlThongKe.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

    }
}
