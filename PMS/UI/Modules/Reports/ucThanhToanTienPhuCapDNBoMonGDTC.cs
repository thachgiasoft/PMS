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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThanhToanTienPhuCapDNBoMonGDTC : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        DateTime _ngayIn;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        #endregion

        #region Event Form
        public ucThanhToanTienPhuCapDNBoMonGDTC()
        {
            InitializeComponent();
            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }
        }

        private void ucThanhToanTienPhuCapDNBoMonGDTC_Load(object sender, EventArgs e)
        {
            #region InitGrid
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenDonVi", "SoTiet", "DonGia", "ThanhTien", "Thue", "SoTienThanhToan", "TienViet", "TienPhoTo", "ThucNhan", "GhiChu", "LanChot", "IdGiangVien" }
                    , new string[] { "STT", "Mã giảng viên", "Họ tên", "Đơn vị", "Số tiết", "Đơn giá", "Thành tiên", "T.TNCN", "Số tiền thanh toán", "Tiền viết", "Tiền photo đề", "Số tiền được nhận", "Ghi chú", "LanChot", "IdGiangVien" }
                    , new int[] { 50, 80, 150, 200, 50, 60, 70, 60, 70, 60, 60, 80, 90, 99, 99 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenDonVi", "SoTiet", "DonGia", "ThanhTien", "Thue", "SoTienThanhToan", "TienViet", "TienPhoTo", "ThucNhan", "GhiChu", "LanChot", "IdGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenDonVi", "SoTiet", "DonGia", "ThanhTien", "SoTienThanhToan", "TienViet", "TienPhoTo", "ThucNhan", "LanChot", "IdGiangVien" });
            AppGridView.SummaryField(gridViewThongKe, "Stt", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThongKe, "SoTiet", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "ThanhTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "Thue", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "SoTienThanhToan", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "ThucNhan", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "SoTienThanhToan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThucNhan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewThongKe, new string[] { "LanChot", "IdGiangVien" });
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 40);
            #endregion

            #region Init _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, false, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region _lanChot
            AppGridLookupEdit.InitGridLookUp(cboLanChot, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChot, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChot.Properties.ValueMember = "LanChot";
            cboLanChot.Properties.DisplayMember = "LanChot";
            cboLanChot.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            InitLanChot();
        }

        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboLanChot.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChot.DataSource = tblLanChot;
                cboLanChot.DataBindings.Add("EditValue", bindingSourceLanChot, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        #endregion

        #region Event CBO
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThanhToanPhuCapGdtc(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                tbl.Load(reader);

                tbl.Columns["Thue"].ReadOnly = false;
                tbl.Columns["SoTienThanhToan"].ReadOnly = false;
                tbl.Columns["ThucNhan"].ReadOnly = false;

                bindingSourceThongKe.DataSource = tbl;
            }
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
                    frm.InThongKeThanhToanTienPhuCapGDTC(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.Text
                        , UserInfo.UserName, "", _ngayIn, vListBaoCao);
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
        #endregion

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewThongKe.FocusedRowHandle = -1;
            DataTable tb = bindingSourceThongKe.DataSource as DataTable;
            if (tb != null && tb.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string xmlData = "";
                    int result = -1;
                    foreach (DataRow r in tb.Rows)
                    {
                        if (r.RowState == DataRowState.Modified)
                        {
                            xmlData += String.Format("<Input M=\"{0}\" T=\"{1}\" G=\"{2}\" />", r["IdGiangVien"], r["Thue"], r["GhiChu"]);
                        }
                    }

                    xmlData = "<Root>" + xmlData + "</Root>";

                    DataServices.KetQuaThanhToanThuLao.LuuThueTncn(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()), "(02) Thuế TNCN trên bảng thống kê thanh toán tiền phụ cấp DN bộ môn GDTC", ref result);

                    if (result == 0)
                        XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btnLocDuLieu.PerformClick();
                }
            }
        }

        private void gridViewThongKe_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Thue")
            {
                DataRowView r = gridViewThongKe.GetRow(e.RowHandle) as DataRowView;

                decimal b;
                decimal _thue = decimal.TryParse(r["Thue"].ToString(), out b) ? b : 0;
                decimal _thanhTien = decimal.TryParse(r["ThanhTien"].ToString(), out b) ? b : 0;
                decimal _SoTienThanhToan = _thanhTien - _thue;

                gridViewThongKe.SetRowCellValue(e.RowHandle, "SoTienThanhToan", _SoTienThanhToan);
                gridViewThongKe.SetRowCellValue(e.RowHandle, "ThucNhan", _SoTienThanhToan);

            }
        }


    }
}
