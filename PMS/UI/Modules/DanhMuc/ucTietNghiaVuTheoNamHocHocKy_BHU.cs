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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMS.UI.Forms.NghiepVu;
using PMS.Services;
using PMS.BLL;
//using Libraries.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucTietNghiaVuTheoNamHocHocKy_BHU : DevExpress.XtraEditors.XtraUserControl
    {

        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewTietNghiaVu> _listTietNghiaVu;
        string _maTruong;

        DataTable _dtData;

        #endregion
        public ucTietNghiaVuTheoNamHocHocKy_BHU()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucTietNghiaVuTheoNamHocHocKy_BHU_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu"
                , "DinhMucToiThieu","TietNghiaVuNckh", "TietGiamDoChucVu", "PhanTramGiamTruKhac", "SoTietGiamKhac", "SoTietNckhDuocGiam", "TietNghiaVuGiangDaySauGiam", "TietNghiaVuNckhSauGiam", "TongGioChuan", "GhiChu" }
                , new string[] { "Mã giảng viên", "Họ và tên", "Đơn vị", "Học hàm", "Học vị", "Chức vụ", "Số tiết nghĩa vụ"
                    , "Định mức tối thiểu theo chức vụ(%)","Tiết nghĩa vụ NCKH", "Tiết giảm do chức vụ", "Phần trăm giảm trừ khác", "Số tiết giảm khác", "Tiết NCKH được giảm", "Tiết nghĩa vụ sau giảm", "Tiết nghĩa vụ NCKH sau giảm", "Tổng giờ chuẩn", "Ghi chú" }
                    , new int[] { 90, 140, 170, 80, 80, 100, 80, 110, 80, 80, 80, 70, 80, 80, 90, 90, 90, 150 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu"
                , "DinhMucToiThieu","TietNghiaVuNckh", "TietGiamDoChucVu", "PhanTramGiamTruKhac", "SoTietGiamKhac", "SoTietNckhDuocGiam", "TietNghiaVuGiangDaySauGiam", "TietNghiaVuNckhSauGiam", "TongGioChuan", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu"
                , "DinhMucToiThieu","TietNghiaVuNckh", "TietGiamDoChucVu", "PhanTramGiamTruKhac", "SoTietGiamKhac", "SoTietNckhDuocGiam", "TongGioChuan" });
            PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 45);
            gridViewTietNghiaVu.Columns["TenDonVi"].GroupIndex = 0;
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
            LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                //_dtData = DBComunication.ExecProc("sp_psc_pms_getTietNghiaVu_NamHocHocKy", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.TietNghiaVu.GetTietNghiaVuBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["TietNghiaVuGiangDaySauGiam"].ReadOnly = false;
                tb.Columns["TietNghiaVuNckhSauGiam"].ReadOnly = false;
                tb.Columns["TongGioChuan"].ReadOnly = false;
                tb.Columns["GhiChu"].ReadOnly = false;
                bindingSourceTietNghiaVu.DataSource = tb;
                gridViewTietNghiaVu.ExpandAllGroups();
            }
        }
        #endregion
        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTietNghiaVu.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable tb = bindingSourceTietNghiaVu.DataSource as DataTable;
                {
                    if (tb != null)
                    {
                        try
                        {
                            string xmlData = "";
                            foreach (DataRow r in tb.Rows)
                            {
                                if (r.RowState == DataRowState.Modified)
                                {
                                    xmlData += String.Format("<Input M=\"{0}\" T=\"{1}\" N=\"{2}\" G=\"{3}\" />", r["MaGiangVien"], PMS.Common.Globals.IsNull(r["TietNghiaVuGiangDaySauGiam"], "decimal"), PMS.Common.Globals.IsNull(r["TietNghiaVuNckhSauGiam"], "decimal"), PMS.Common.Globals.IsNull(r["GhiChu"], "string"));
                                }
                            }
                            xmlData = string.Format("<Root>{0}</Root>", xmlData);
                            bindingSourceTietNghiaVu.EndEdit();
                            int kq = 0;
                            DataServices.TietNghiaVu.LuuBuh(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                            if (kq == 0)
                                XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepTietNghiaVu"))
            {
                frm.ShowDialog();
            }
            InitData();
        }
        #endregion
        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }
        #endregion

        private void gridViewTietNghiaVu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                int pos = e.RowHandle;

                if (col.FieldName == "TietNghiaVuGiangDaySauGiam" || col.FieldName == "TietNghiaVuNckhSauGiam")
                {
                    DataRowView v = gridViewTietNghiaVu.GetRow(e.RowHandle) as DataRowView;
                    decimal _tongGioChuan = decimal.Parse(PMS.Common.Globals.IsNull(v["TietNghiaVuGiangDaySauGiam"], "decimal").ToString())
                        + decimal.Parse(PMS.Common.Globals.IsNull(v["TietNghiaVuNckhSauGiam"], "decimal").ToString());

                    gridViewTietNghiaVu.SetRowCellValue(pos, "TongGioChuan", _tongGioChuan);
                }
            }
            catch
            { }
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlTietNghiaVu.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
    }
}
