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

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeSoLuongSinhVienCuaGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion
        public ucThongKeSoLuongSinhVienCuaGiangVien()
        {
            InitializeComponent();
        }

        private void ucThongKeSoLuongSinhVienCuaGiangVien_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenDonVi", "SoLuongSinhVien", "Lt", "Th", "Damh", "Datn", "Pbla", "Klk" }
                    , new string[] { "STT", "Mã giảng viên", "Họ tên", "Bộ môn", "Số lượng SV", "Tiết quy đổi LT", "Tiết quy đổi TH", "Tiết quy đổi DAMH", "Tiết quy đổi DATN", "Tiết quy đổi PBLA", "Tiết quy đổi KLK" }
                    , new int[] { 70, 90, 150, 130, 100, 100, 100, 110, 110, 100, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenDonVi", "SoLuongSinhVien", "Lt", "Th", "Damh", "Datn", "Pbla", "Klk" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            //gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;
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

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            InitData();
        }
        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ViewKetQuaThanhToanThuLao.ThongKeSiSoSinhVien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
            }
            gridViewThongKe.ExpandAllGroups();
        }
        #endregion
        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
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

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ViewKetQuaThanhToanThuLao.ThongKeSiSoSinhVien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
            }
            gridViewThongKe.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}
