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
using PMS.Services;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThanhToanVuotGioDinhMucGiangVienCoHuu : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0, lanchot2 = 0;
        DateTime _ngayIn;
        #endregion

        public ucThanhToanVuotGioDinhMucGiangVienCoHuu()
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

        private void ucThanhToanVuotGioDinhMucGiangVienCoHuu_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThanhToan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
          
            AppGridView.ShowField(gridViewThanhToan, new string[] {"MaQuanLy","HoTen","TenDonVi","TenHocHam","TenHocVi","TenChucVu","SoGioChuanDinhMuc","TietGiangDay","TietKhoiLuongKhac","TietCoiThi","TietChamBai","TietRaDe","TietNckh","SoGioQuyChuanThucHien","SoGioVuotDinhMuc","HeSoThanhToan","DonGia","TienThanhToanVuotMuc"}
                                                       , new string[] { "Mã giảng viên", "Họ tên", "Khoa - đơn vị", "Học hàm", "Học vị", "Chức vụ", "Số giờ chuẩn định mức", "Tiết giảng dạy", "Tiết khối lượng khác", "Tiết coi thi", "Tiết chấm bài", "Tiết ra đề", "Tiết NCKH", "Số giờ quy chuẩn thực hiện", "Số giờ vượt định mức", "Hệ số thanh toán", "Đơn giá", "Tiền thanh toán vượt mức" }
                                                       , new int[] { 80, 130, 100, 90, 90, 90, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 110, 100 });
            AppGridView.AlignHeader(gridViewThanhToan, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "SoGioChuanDinhMuc", "TietGiangDay", "TietKhoiLuongKhac", "TietCoiThi", "TietChamBai", "TietRaDe", "TietNckh", "SoGioQuyChuanThucHien", "SoGioVuotDinhMuc", "HeSoThanhToan", "DonGia", "TienThanhToanVuotMuc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhToan, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThanhToan, "HeSoThanhToan", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThanhToan, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToan, "TienThanhToanVuotMuc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewThanhToan);
            gridViewThanhToan.Columns["TenDonVi"].GroupIndex = 0;
            gridViewThanhToan.GroupPanelText = "Gom nhóm bằng cách kéo tên cột thả vào đây";
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region LanChot1
            AppGridLookupEdit.InitGridLookUp(cboLanChotHK01, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotHK01, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotHK01.Properties.ValueMember = "LanChot";
            cboLanChotHK01.Properties.DisplayMember = "LanChot";
            cboLanChotHK01.Properties.NullText = string.Empty;
            #endregion

            #region LanChot2
            AppGridLookupEdit.InitGridLookUp(cboLanChotHK02, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotHK02, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotHK02.Properties.ValueMember = "LanChot";
            cboLanChotHK02.Properties.DisplayMember = "LanChot";
            cboLanChotHK02.Properties.NullText = string.Empty;
            #endregion
            InitData();
        }

        void InitData()
        {

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            InitLanChot();
        }
        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null)
            {
                cboLanChotHK01.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), "HK01", ref lanchot);
                DataTable tblLanChotHK01 = new DataTable();
                tblLanChotHK01.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChotHK01.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotHK01.DataSource = tblLanChotHK01;
                cboLanChotHK01.DataBindings.Add("EditValue", bindingSourceLanChotHK01, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);

                cboLanChotHK02.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), "HK02", ref lanchot2);
                DataTable tblLanChotHK02 = new DataTable();
                tblLanChotHK02.Columns.Add("LanChot");
                if (lanchot2 > 0)
                {
                    for (int i = lanchot2; i >= 1; i--)
                    {
                        tblLanChotHK02.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotHK02.DataSource = tblLanChotHK02;
                cboLanChotHK02.DataBindings.Add("EditValue", bindingSourceLanChotHK02, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
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
                _ngayIn = frmChon.NgayIn;
            }

            Cursor.Current = Cursors.WaitCursor;
            gridViewThanhToan.FocusedRowHandle = -1;
            bindingSourceThanhToan.EndEdit();
            DataTable data = bindingSourceThanhToan.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThanhToan, bindingSourceThanhToan);

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThanhToanVuotGioDinhMucGiangVienCoHuu(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString()
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu, _ngayIn
                        , vListBaoCao);
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
                        gridControlThanhToan.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThanhToanGioVuotDinhMucVhu(cboNamHoc.EditValue.ToString(), int.Parse(cboLanChotHK01.EditValue.ToString()), int.Parse(cboLanChotHK02.EditValue.ToString()));
                tb.Load(reader);
                bindingSourceThanhToan.DataSource = tb;
                gridViewThanhToan.ExpandAllGroups();
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
