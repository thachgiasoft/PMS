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

namespace PMS.UI.Modules.Reports
{
    public partial class ucSoSanhLHP_TKB_VS_KhoiLuongDongBo : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion
        public ucSoSanhLHP_TKB_VS_KhoiLuongDongBo()
        {
            InitializeComponent();
        }

        private void ucSoSanhLHP_TKB_VS_KhoiLuongDongBo_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "ScheduleStudyUnitID", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "SoGioThucGiangTrenLop", "SoGioChuanTinhThem", "HeSoHocKy", "TietQuyDoi", "DonGia", "TongThanhTien", "TenDonVi" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Mã LHP PMS", "Mã LHP TKB", "Loại", "Nhóm", "Lớp", "Sĩ số", "Số tiết", "Hệ số lớp đông", "Giờ thực giảng trên lớp", "Giờ chuẩn tính thêm", "Hệ số học kỳ", "Tiết quy đổi", "Đơn giá", "Thành tiền", "Đơn vị" }
                    , new int[] { 80, 150, 100, 100, 100, 90, 150, 100, 100, 60, 60, 90, 60, 70, 70, 70, 70, 70, 70, 70, 80, 140 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "ScheduleStudyUnitID", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "SoGioThucGiangTrenLop", "SoGioChuanTinhThem", "HeSoHocKy", "TietQuyDoi", "DonGia", "TongThanhTien", "TenDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
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
        }

        void LoadDataSource()
        {
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.UteKhoiLuongGiangDay.SoSanhMonHocPmsVsTkb(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    tb.Load(reader);
                    foreach (DataColumn col in tb.Columns)
                        col.ReadOnly = false;
                    bindingSourceThongKe.DataSource = tb;

                    ToMau();
                }
            }
            catch 
            {  }
        }

        void ToMau()
        {
            gridViewThongKe.FormatConditions.Clear();

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionMaLopHocPhan = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionMaLopHocPhan.Column = gridViewThongKe.Columns["MaLopHocPhan"];
            styleFormatConditionMaLopHocPhan.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionMaLopHocPhan.Expression = "[MaLopHocPhan] IS NULL";
            styleFormatConditionMaLopHocPhan.Appearance.Options.UseBackColor = true;
            styleFormatConditionMaLopHocPhan.Appearance.BackColor = System.Drawing.Color.Yellow;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionScheduleStudyUnitID = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionScheduleStudyUnitID.Column = gridViewThongKe.Columns["ScheduleStudyUnitID"];
            styleFormatConditionScheduleStudyUnitID.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionScheduleStudyUnitID.Expression = "[ScheduleStudyUnitID] IS NULL";
            styleFormatConditionScheduleStudyUnitID.Appearance.Options.UseBackColor = true;
            styleFormatConditionScheduleStudyUnitID.Appearance.BackColor = System.Drawing.Color.Orange;

            gridViewThongKe.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { styleFormatConditionMaLopHocPhan, styleFormatConditionScheduleStudyUnitID });
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
            Cursor.Current = Cursors.WaitCursor;
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlTK.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                gridViewThongKe.ActiveFilterString = "";
            }
            if (radioGroup1.SelectedIndex == 1)
            {
                gridViewThongKe.ActiveFilterString = "MaLopHocPhan IS NULL";
            }
            if (radioGroup1.SelectedIndex == 2)
            {
                gridViewThongKe.ActiveFilterString = "ScheduleStudyUnitID IS NULL";
            }
        }
    }
}
