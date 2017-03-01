using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using PMS.BLL;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeDuTruCaNamTruocThoiKhoaBieu : DevExpress.XtraEditors.XtraUserControl
    {

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        string _maTruong;
        private string groupname = UserInfo.GroupName;
        private bool user = false;
        #endregion
        public ucThongKeDuTruCaNamTruocThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void ucThongKeDuTruCaNamTruocThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenDonVi", "GioGiangHk01", "GioKhacHk01", "SoTietGiamTruKhacHk01", "SoTietNghiaVuHk01", "GioVuotHk01", "GioGiangHk02", "GioKhacHk02", "SoTietGiamTruKhacHk02", "SoTietNghiaVuHk02", "GioVuotHk02", "GioGiangCaNam", "GioKhacCaNam", "SoTietGiamTruKhacCaNam", "SoTietNghiaVuCaNam", "GioVuotCaNam", "TenChucVu" }
                    , new string[] { "STT", "Mã giảng viên", "Họ tên", "Tên Bộ Môn", "Tổng giờ dạy HK01", "Giờ thực hiện các nhiệm vụ khác HK01", "Giảm trừ giờ chuẩn các HĐ khác HK01", "Định mức giờ tiêu chuẩn HK01", "Giờ vượt HK01", "Tổng giờ dạy HK02", "Giờ thực hiện các nhiệm vụ khác HK02", "Giảm trừ giờ chuẩn các HĐ khác HK02", "Định mức giờ tiêu chuẩn HK02", "Giờ vượt HK02", "Tổng giờ dạy cả năm", "Giờ thực hiện các nhiệm vụ khác cả năm", "Giảm trừ giờ chuẩn các HĐ khác cả năm", "Định mức giờ tiêu chuẩn cả năm", "Giờ vượt cả năm", "Ghi chú" }
                    , new int[] { 60, 90, 170, 150, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 150 });
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenDonVi", "GioGiangHk01", "GioKhacHk01", "SoTietGiamTruKhacHk01", "SoTietNghiaVuHk01", "GioVuotHk01", "GioGiangHk02", "GioKhacHk02", "SoTietGiamTruKhacHk02", "SoTietNghiaVuHk02", "GioVuotHk02", "GioGiangCaNam", "GioKhacCaNam", "SoTietGiamTruKhacCaNam", "SoTietNghiaVuCaNam", "GioVuotCaNam", "TenChucVu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "GioGiangHk01", "GioKhacHk01", "SoTietGiamTruKhacHk01", "SoTietNghiaVuHk01", "GioVuotHk01", "GioGiangHk02", "GioKhacHk02", "SoTietGiamTruKhacHk02", "SoTietNghiaVuHk02", "GioVuotHk02", "GioGiangCaNam", "GioKhacCaNam", "SoTietGiamTruKhacCaNam", "SoTietNghiaVuCaNam", "GioVuotCaNam", "TenChucVu" }, DevExpress.Utils.HorzAlignment.Center);
            gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 50);

            gridViewThongKe.Columns["GioVuotHk01"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);
            gridViewThongKe.Columns["GioVuotHk02"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);
            gridViewThongKe.Columns["GioVuotCaNam"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region LoaiGiangVien
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vlistKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            List<CheckedListBoxItem> listKhoaBoMon = new List<CheckedListBoxItem>();

            foreach (ViewKhoaBoMon l in _vlistKhoaBoMon)
                listKhoaBoMon.Add(new CheckedListBoxItem(l.MaBoMon, string.Format("{0} - {1}", l.MaBoMon, l.TenBoMon), CheckState.Unchecked, true));
            cboDonVi.Properties.Items.AddRange(listKhoaBoMon.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion

            #region LoaiGiangVien
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();

            TList<LoaiGiangVien> _tListLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();

            foreach (LoaiGiangVien l in _tListLoaiGiangVien)
                list.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, string.Format("{0} - {1}", l.MaQuanLy, l.TenLoaiGiangVien), CheckState.Unchecked, true));
            cboLoaiGiangVien.Properties.Items.AddRange(list.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.DuTruGioGiangTruocThoiKhoaBieu.ThongKeCaNamTheoGiangVien(cboNamHoc.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceThongKe.DataSource = tbl;
            }
            gridViewThongKe.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
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

                    frm.InThongKeDuTruCaNamCuaGiangVienTruocTKB(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString()
                          , PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.PhongDaoTao, _ngayIn, vListBaoCao);

                    frm.ShowDialog();

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
    }
}
