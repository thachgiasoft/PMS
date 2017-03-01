using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucChiTietTienCanTren : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public ucChiTietTienCanTren()
        {
            InitializeComponent();
            try
            {
                _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
                _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi khi khởi tạo các giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucChiTietTienCanTrenTheoNam_Load(object sender, EventArgs e)
        {
            #region InitGridView
            switch (_maTruong)
            {
                default:    //UTE
                    InitRemaining();
                    break;
            }
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region LoaiGiangVien
            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] { "MaLoaiGiangVien", "TenLoaiGiangVien" }, new string[] { "Mã loại", "Tên loại" }, new int[] { 60, 140 });
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region Init GridView
        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewChiTietTienCanTren, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewChiTietTienCanTren, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiNhanVien", "TienCanTren", "BiChan", "GhiChu" },
                        new string[] { "Mã quản lý", "Họ tên", "Học hàm", "Học vị", "Loại nhân viên", "Tiền cận trên", "Bị chặn", "Ghi chú" },
                        new int[] { 70, 150, 120, 120, 120, 100, 60, 170 });
            AppGridView.ShowEditor(gridViewChiTietTienCanTren, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            //AppGridView.HideField(gridViewChiTietTienCanTren, new string[] {"GhiChu"} );
            AppGridView.AlignHeader(gridViewChiTietTienCanTren, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiNhanVien", "TienCanTren", "BiChan", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.FormatDataField(gridViewChiTietTienCanTren, "TienCanTren", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewChiTietTienCanTren, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiNhanVien", "TienCanTren" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }
        #endregion

        #region InitData
        private void InitData()
        {
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            if (bindingSourceLoaiGiangVien.Count > 0)
            {
                cboLoaiGiangVien.EditValue = "17";  //Hiện tại ẩn cbo này đi và cho cố định là giảng viên thỉnh giảng. Vì giảng viên cơ hữu được xem trong "Tiết nghĩa vụ giảng viên" rồi.
            }
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if ((cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true") && cboLoaiGiangVien.EditValue != null)
                {
                    IDataReader reader = DataServices.GiangVien.GetTienCanTren(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    foreach (DataColumn dc in dt.Columns) dc.ReadOnly = false;
                    bindingSourceTienCanTren.DataSource = dt;
                    
                }
            }
        }
        #endregion

        private void btnLamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlChiTietTienCanTren.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if ((cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true") && cboLoaiGiangVien.EditValue != null)
            {
                IDataReader reader = DataServices.GiangVien.GetTienCanTren(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataColumn dc in dt.Columns) dc.ReadOnly = false;
                bindingSourceTienCanTren.DataSource = dt;
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if ((cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true") && cboLoaiGiangVien.EditValue != null)
            {
                IDataReader reader = DataServices.GiangVien.GetTienCanTren(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataColumn dc in dt.Columns) dc.ReadOnly = false;
                bindingSourceTienCanTren.DataSource = dt;
            }
        }

        private void cboLoaiGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true") && cboLoaiGiangVien.EditValue != null)
            {
                IDataReader reader = DataServices.GiangVien.GetTienCanTren(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataColumn dc in dt.Columns) dc.ReadOnly = false;
                bindingSourceTienCanTren.DataSource = dt;
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewChiTietTienCanTren.FocusedRowHandle = -1;
            DataTable list = bindingSourceTienCanTren.DataSource as DataTable;
            if (list != null)
            {
                try
                {
                    string xmlData = "";
                    foreach (DataRow kl in list.Rows)
                    {
                        if (kl["MaGiangVien"] != null && kl["GhiChu"].ToString().Equals("Thay đổi chặn"))
                        {
                            xmlData += String.Format("<Input MGV=\"{0}\" BC=\"{1}\" GC=\"{2}\" NH=\"{3}\" HK=\"{4}\"/>"
                                        , kl["MaGiangVien"]
                                        , kl["BiChan"]
                                        , kl["GhiChu"]
                                        , cboNamHoc.EditValue.ToString()
                                        , cboHocKy.EditValue.ToString() );
                        }
                    }
                    xmlData = string.Format("<Root>{0}</Root>", xmlData);
                    bindingSourceTienCanTren.EndEdit();
                    int kq = 0;
                    DataServices.GiangVienBiChanTien.LuuThayDoi(xmlData, ref kq);
                    if (kq == 0)
                    {
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IDataReader reader = DataServices.GiangVien.GetTienCanTren(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        foreach (DataColumn dc in dt.Columns) dc.ReadOnly = false;
                        bindingSourceTienCanTren.DataSource = dt;
                    }
                    else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridViewChiTietTienCanTren_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            if (col.FieldName.Equals("BiChan"))
            {
                gridViewChiTietTienCanTren.SetRowCellValue(pos, "GhiChu", "Thay đổi chặn");
            }
        }
    }
}
