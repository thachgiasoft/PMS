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
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Modules.Reports.ThongKeThanhTra
{
    public partial class ucThongKeTongTietThucGiangTheoKhoa : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        VList<ViewKhoaBoMon> _listKhoaDonVi;
        string _maTruong;
        #endregion

        public ucThongKeTongTietThucGiangTheoKhoa()
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

            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            if (_maTruong == "IUH")
                btnLamTuoi.Caption = "Cập nhật mới";
        }

        private void ucThongKeTongTietThucGiangTheoKhoa_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaCanBoGiangDay", "HoTen", "LyThuyetKeHoach", "ThucHanhKeHoach", "SoTietKeHoach", "LyThuyetThucGiang", "ThucHanhThucGiang", "SoTietThucGiang", "TenDonVi" }
                    , new string[] { "STT", "Mã giảng viên", "Họ tên", "LT kế hoạch", "TH kế hoạch", "Tổng cộng kế hoạch", "LT thực giảng", "TH thực giảng", "Tổng cộng thực giảng", "Đơn vị: " }
                    , new int[] { 45, 100, 160, 80, 80, 100, 80, 80, 100, 99 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaCanBoGiangDay", "HoTen", "LyThuyetKeHoach", "ThucHanhKeHoach", "SoTietKeHoach", "LyThuyetThucGiang", "ThucHanhThucGiang", "SoTietThucGiang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.SummaryField(gridViewThongKe, "Stt", "{0}", DevExpress.Data.SummaryItemType.Count);
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 45);
            gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;
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

            #region _khoaDonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon", "TenCoSo" }, new string[] { "Mã khoa-Đơn vị", "Tên Khoa-Đơn vị", "Cơ sở" }, new int[] { 90, 250, 190 });
            AppGridLookupEdit.InitPopupFormSize(cboKhoaDonVi, 530, 650);
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            cboKhoaDonVi.DataBindings.Clear();
            _listKhoaDonVi = DataServices.ViewKhoaBoMon.GetAll();
            _listKhoaDonVi.Add(new ViewKhoaBoMon { MaBoMon = "-1", TenBoMon = "[Tất cả]", ThuTu = 0 });
            bindingSourceKhoaDonVi.DataSource = _listKhoaDonVi;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThanhTraTheoThoiKhoaBieu.ThongKeTongHopTheoHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;

                gridViewThongKe.ExpandAllGroups();
                Cursor.Current = Cursors.Default;
            }
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
                    frm.InThongKeTongHopTheoHocKyMaDonVi(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.Text, UserInfo.FullName, _ngayIn, vListBaoCao);
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

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }
    }
}
