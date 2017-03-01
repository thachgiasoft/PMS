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
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.BLL;

namespace PMS.UI.Modules.Reports
{
    public partial class ucTongHopThanhToan_VHU : DevExpress.XtraEditors.XtraUserControl
    {
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;

        public ucTongHopThanhToan_VHU()
        {
            InitializeComponent();
        }

        private void ucTongHopThanhToan_VHU_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenChucVu", "TenHocHam", "BacLuong", "TietNghiaVuGiangDay", "TongTietGiangDay", "TongCoiThiChamThi", "TongGioThucTe", "GioVuotDinhMuc", "GioGiangChuyenSangNckh", "GioGiangThucTeSauQuyDoi", "TietNghiaVuNckh", "SoTietNckh", "GioVuotNckh", "GioNckhQuyDoiTuGioGiang", "GioNckhSauQuyDoi", "TongGioDinhMuc", "TongGioThucTeTruocQuyDoi", "TongGioThucTeSoVoiDinhMuc", "GioChuanThanhToanBanDau", "GioChuanThanhToanMuc1", "GioChuanThanhToanMuc2", "HeSo", "DonGia", "ThanhTienMuc1", "ThanhTienMuc2", "TongThanhTien", "TenDonVi" }
                    , new string[] { "STT", "Mã giảng viên", "Họ tên", "Chức vụ", "Học hàm", "Bậc lượng", "GCGD định mức", "GCGD LT, TH, DA, TT thực tế", "GC coi thi, chấm thi", "Tổng GCGD thực tế trước quy đổi", "GCGD thực tế so với định mức trước quy đổi", "GCGD quy đổi sang NCKH", "GCGD thực tế so với định mức sau quy đổi", "Giờ chuẩn NCKH định mức", "Tổng GC NCKH thực tế trước quy đổi", "GC NCKH thực tế so với định mức trước quy đổi", "GC NCKH quy đổi từ GCGD", "GC NCKH thực tế so với định mức sau quy đổi", "Tổng GC định mức", "Tổng GC thực tế trước quy đổi", "Tổng GC thực tế so với định mức", "GC thanh toán ban đầu", "GC thanh toán mức 1 (từ 1-200 giờ)", "GC thanh toán mức 2 (từ giờ 201)", "Hệ số thanh toán", "Đơn giá", "Thành tiền thanh toán mức 1", "Thành tiền thanh toán mức 2", "Tổng thành tiền", "Đơn vị" }
                    , new int[] { 50, 80, 150, 100, 100, 70, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 90, 90, 90, 99 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenChucVu", "TenHocHam", "BacLuong", "TietNghiaVuGiangDay", "TongTietGiangDay", "TongCoiThiChamThi", "TongGioThucTe", "GioVuotDinhMuc", "GioGiangChuyenSangNckh", "GioGiangThucTeSauQuyDoi", "TietNghiaVuNckh", "SoTietNckh", "GioVuotNckh", "GioNckhQuyDoiTuGioGiang", "GioNckhSauQuyDoi", "TongGioDinhMuc", "TongGioThucTeTruocQuyDoi", "TongGioThucTeSoVoiDinhMuc", "GioChuanThanhToanBanDau", "GioChuanThanhToanMuc1", "GioChuanThanhToanMuc2", "HeSo", "DonGia", "ThanhTienMuc1", "ThanhTienMuc2", "TongThanhTien", "TenDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThongKe, "ThanhTienMuc1", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "ThanhTienMuc2", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "TongThanhTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            
            AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTienMuc1", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTienMuc2", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 100);
            gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;

            #region Init _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, false, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            #region Init Khoa-DonVi
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
            _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, v.TenBoMon, CheckState.Unchecked, true));
            }
            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
            #endregion
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTongHopVhu(cboNamHoc.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
                gridViewThongKe.ExpandAllGroups();
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();

                if (frmChon.NgayIn.ToString("dd/MM/yyyy") == "01/01/0001")
                    return;
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

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeTongHopVHU(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), UserInfo.FullName, PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.KeToan, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlThongKe.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
