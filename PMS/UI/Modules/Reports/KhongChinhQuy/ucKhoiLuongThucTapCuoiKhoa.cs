using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using DevExpress.Common.Grid;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;

namespace PMS.UI.Modules.zKhanh
{
    public partial class ucKhoiLuongThucTapCuoiKhoa : DevExpress.XtraEditors.XtraUserControl
    {
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        DateTime _ngayIn;
        int lanchot = 0;
        DataTable _tblDuLieu;

        public ucKhoiLuongThucTapCuoiKhoa()
        {
            InitializeComponent();
        }

        private void ucKhoiLuongThucTapCuoiKhoa_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridView1, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridView1, new string[] {"MaGiangVien", "HoTen", "MaLop", "MaNhom", "SiSo", "Loai", "MaMonHoc", "CurriculumName", "SoTinChi", "SoTuan", "HeSoQuyDoi", "TietQuyDoi", "DonGia", "HeSoDiaDiem"
		                                                            , "DonGiaDiaDiem", "DonGiaDDQuyDoi", "TongDonGia", "ThanhTienGiangDay", "TienXeDiaDiem", "TongTien", "DepartmentName", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDiaDiem", "GhiChu" }
                                                         , new string[] {"Mã giảng viên", "Họ tên", "Mã lớp", "Mã nhóm", "Sĩ số", "Loại", "Mã môn học", "Tên môn học", "Số tín chỉ", "Số tiết (tuần)", "Hệ số quy đổi", "Tiết quy đổi", "Đơn giá học vị", "Hệ số địa điểm"
		                                                            , "Đơn giá địa điểm", "Đơn giá địa điểm quy đổi", "Tổng đơn giá", "Thành tiền giảng dạy", "Tiền xe địa điểm", "Tổng tiền", "Đơn vị", "Tên học hàm", "Tên học vị", "Tên loại giảng viên", "Tên địa điểm", "Ghi chú" }
                                                         , new int[] { 90, 150, 90, 90, 50, 90, 90,  150, 50, 50, 50, 50, 50, 50, 50, 50, 70, 50, 50, 50, 130, 90, 90, 80, 150, 100 });
            AppGridView.AlignHeader(gridView1, new string[] { "MaGiangVien", "HoTen", "MaLop", "MaNhom", "SiSo", "Loai", "MaMonHoc", "CurriculumName", "SoTinChi", "SoTuan", "HeSoQuyDoi", "TietQuyDoi", "DonGia", "HeSoDiaDiem"
		                                                            , "DonGiaDiaDiem", "DonGiaDDQuyDoi", "TongDonGia", "TongDonGia", "ThanhTienGiangDay", "TienXeDiaDiem", "TongTien", "DepartmentName", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDiaDiem", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridView1, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridView1, "TietQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridView1, "TongTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridView1, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridView1, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridView1, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridView1, new string[] { "MaGiangVien", "HoTen", "MaLop", "MaNhom", "SiSo", "Loai", "MaMonHoc", "CurriculumName", "SoTinChi", "SoTuan", "HeSoQuyDoi", "TietQuyDoi", "DonGia", "HeSoDiaDiem"
		                                                            , "DonGiaDiaDiem", "DonGiaDDQuyDoi", "TongDonGia", "TongDonGia", "ThanhTienGiangDay", "TienXeDiaDiem", "TongTien", "DepartmentName", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDiaDiem", "GhiChu" });
            //AppGridView.HideField(gridView1, new string[] { "MucThanhToan", "ThanhTien" });
            #endregion
            PMS.Common.Globals.WordWrapHeader(gridView1, 40);
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Học kỳ
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy" }, new string[] { "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Init data
            InitData();
            #endregion
        }

        void InitData()
        {
            bsNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue.ToString() != "")
            {
                bsHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (cboNamHoc.EditValue.ToString() != "" && cboHocKy.EditValue.ToString() != "")
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KcqKhoiLuongThucTapCuoiKhoa.ThongKeTheoNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bsDuLieu.DataSource = tb;
                //MessageBox.Show("Lọc được " + tb.Rows.Count + " dòng.");
            }
            gridView1.ExpandAllGroups();

            Cursor.Current = Cursors.Default;

        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlDuLieu.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataTable tb = bsDuLieu.DataSource as DataTable;
                gridView1.FocusedRowHandle = -1;
                if (tb.Rows.Count == 0) return;
                //DataTable vListBaoCao = tb.Select("ChonIn = 'True'").CopyToDataTable();
                DataTable vListBaoCao = tb;

                if (vListBaoCao.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn dòng muốn in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                using (frmChonNgay frmChon = new frmChonNgay())
                {
                    frmChon.ShowDialog();

                    if (frmChon.NgayIn.ToString("dd/MM/yyyy") == "01/01/0001")
                        return;
                    _ngayIn = frmChon.NgayIn;

                }

                string sort = "";
                if (vListBaoCao != null)
                {
                    if (vListBaoCao.Rows.Count != 0)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridView1.SortedColumns)
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

                string filter = gridView1.ActiveFilterString;
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
                    return;
                if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
                {
                    using (frmBaoCao frm = new frmBaoCao())
                    {
                        frm.InThongkeKhoiLuongThucTapCuoiKhoa(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), UserInfo.FullName, _ngayIn, vListBaoCao);
                        frm.ShowDialog();
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Không in được! Lỗi: " + ex.Message + "\nChi tiết: " + ex.StackTrace);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }
    }
}
