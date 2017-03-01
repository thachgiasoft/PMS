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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeKhoiLuongHuongDanThucTapTheoNamHoc : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        #endregion
        public ucThongKeKhoiLuongHuongDanThucTapTheoNamHoc()
        {
            InitializeComponent();
        }

        private void ucThongKeKhoiLuongHuongDanThucTapTheoNamHoc_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "MaBacDaoTao", "MaLopHocPhan", "TenHocPhan", "LopSinhVien", "TenNganh", "Nhom", "SiSo", "SoTuan", "HeSo", "TietQuyDoi", "DonGia", "ThanhTien" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Bậc đào tạo", "Mã lớp học phần", "Tên học phần", "Lớp", "Ngành", "Nhóm", "Sĩ số", "Số tuần", "Hệ số", "Tiết quy đổi", "Đơn giá", "Thành tiền" }
                    , new int[] { 100, 160, 160, 60, 110, 150, 70, 90, 70, 50, 60, 60, 80, 70, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "MaBacDaoTao", "MaLopHocPhan", "TenHocPhan", "LopSinhVien", "TenNganh", "Nhom", "SiSo", "SoTuan", "HeSo", "TietQuyDoi", "DonGia", "ThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "TietQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "ThanhTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            #region Init Bac Dao Tao
            cboBacDaoTao.Properties.SelectAllItemCaption = "Tất cả";
            cboBacDaoTao.Properties.TextEditStyle = TextEditStyles.Standard;
            cboBacDaoTao.Properties.Items.Clear();

            VList<ViewBacDaoTao> _vListBacDaoTao = DataServices.ViewBacDaoTao.GetAll();

            List<CheckedListBoxItem> _listBac = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _vListBacDaoTao)
            {
                _listBac.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            }
            cboBacDaoTao.Properties.Items.AddRange(_listBac.ToArray());
            cboBacDaoTao.Properties.SeparatorChar = ';';
            cboBacDaoTao.CheckAll();
            #endregion

            #region Init Khoa-DonVi
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoa> _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion
            
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboBacDaoTao.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KhoiLuongHuongDanThucTap.ThongKeTheoNamHocBacDaoTaoDonVi(cboNamHoc.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
                gridViewThongKe.BestFitColumns();
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

            ////string filter = gridViewThongKe.ActiveFilterString;
            ////if (filter.Contains(".0000m"))
            ////    filter = filter.Replace(".0000m", "");
            ////if (filter.Contains(".000m"))
            ////    filter = filter.Replace(".000m", "");
            ////if (filter.Contains(".00m"))
            ////    filter = filter.Replace(".00m", "");
            ////if (filter.Contains(".0m"))
            ////    filter = filter.Replace(".0m", "");
            ////if (filter.Contains(".m"))
            ////    filter = filter.Replace(".m", "");

            ////string filter = gridViewHopDongMoiGiangVien.ActiveFilterString;
            ////vListBaoCao = dv.ToTable();
            ////if (vListBaoCao == null)
            //    return;
            //int dem = vListBaoCao.Rows.Count;


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    //frm.InThongKeThanhToanTienGiangThucHanhCBKGHDDH(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.Text, cboKhoaDonVi.Text
                    //    , PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.KeToan, PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.NguoiLapbieu
                    //    , cboKhoaHoc.Text, cboBacDaoTao.Text, _ngayIn
                    //    , vListBaoCao);
                    //frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
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

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }
    }
}
