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
using PMS.UI.Forms.NghiepVu;
using PMS.Services;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Modules.DanhMuc
{
    
    public partial class ucMonHocCoNganHangDeThi : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        DataTable _listMonHoc = new DataTable();
        #endregion

        public ucMonHocCoNganHangDeThi()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucMonHocCoNganHangDeThi_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            AppGridView.InitGridView(gridViewData, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            //AppGridView.ShowEditor(gridViewData, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewData, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "Chon" }
                        , new string[] { "Mã môn học", "Tên môn học", "Số tín chỉ", "Lớp học phần", "Chọn" }
                        , new int[] { 130, 300, 70, 130, 70});
            AppGridView.AlignHeader(gridViewData, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "Chon" }, DevExpress.Utils.HorzAlignment.Center);
           // AppGridView.ReadOnlyColumn(gridViewData, new string[] { "MaMonHoc", "TenMonHoc" });
            //AppGridView.RegisterControlField(gridViewData, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.SummaryField(gridViewData, "MaMonHoc", "Số lớp: {0}", DevExpress.Data.SummaryItemType.Count);

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

            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi" }, new string[] { "Mã môn học", "Tên môn học", "Số tín chỉ" }, new int[] { 80, 270, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 450, 600);
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "MaMonHoc";
            
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            try
            {

                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    DataTable tb= new DataTable();
                    IDataReader readerda =DataServices.MonHocCoNganHangDeThi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    tb.Load(readerda);
                    tb.Columns["Chon"].ReadOnly = false;
                    bindingSourceData.DataSource = tb;

                    //IDataReader reader = DataServices.ViewMonHoc.GetBYNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());//Chỉ lấy ra những môn học có tổ chức trong học kỳ đó
                    //_listMonHoc.Clear();
                    //_listMonHoc.Load(reader);
                    //bindingSourceMonHoc.DataSource = _listMonHoc;
                }
            }
            catch
            { }

        }
        #endregion

        private void gridViewData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaMonHoc")
            {
                DataRowView dv = gridViewData.GetRow(e.RowHandle) as DataRowView;
                //MonHocCoNganHangDeThi t = gridViewData.GetRow(e.RowHandle) as MonHocCoNganHangDeThi;
                foreach (DataRow dr in _listMonHoc.Rows)
                    if (dr["MaMonHoc"].ToString() == dv["MaMonHoc"])
                    {
                        gridViewData.SetRowCellValue(e.RowHandle, "TenMonHoc", dr["TenMonHoc"].ToString());
                    }
            }
        }

        private void gridViewData_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewData, e);
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            try
            {

                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader readerda = DataServices.MonHocCoNganHangDeThi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    tb.Load(readerda);
                    tb.Columns["Chon"].ReadOnly = false;
                    bindingSourceData.DataSource = tb;

                    //IDataReader reader = DataServices.ViewMonHoc.GetBYNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());//Chỉ lấy ra những môn học có tổ chức trong học kỳ đó
                    //_listMonHoc.Clear();
                    //_listMonHoc.Load(reader);
                    //bindingSourceMonHoc.DataSource = _listMonHoc;
                }
            }
            catch
            { }
            Cursor.Current=Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader readerda = DataServices.MonHocCoNganHangDeThi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    tb.Load(readerda);
                    tb.Columns["Chon"].ReadOnly = false;
                    bindingSourceData.DataSource = tb;

                    //IDataReader reader = DataServices.ViewMonHoc.GetBYNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());//Chỉ lấy ra những môn học có tổ chức trong học kỳ đó
                    //_listMonHoc.Clear();
                    //_listMonHoc.Load(reader);
                    //bindingSourceMonHoc.DataSource = _listMonHoc;
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewData);
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                InitData();
            }
            catch
            { }
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
                            gridControlData.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewData.FocusedRowHandle = -1;
            DataTable tb = bindingSourceData.DataSource as DataTable;
            if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string xmlData = "";
                    foreach (DataRow r in tb.Rows)
                    {
                        if (r.RowState == DataRowState.Modified)
                        {
                            xmlData += "<MonHocCoNganHangDeThi MaMonHoc=\"" + r["MaMonHoc"].ToString()
                                + "\" MaLopHocPhan=\"" + r["MaLopHocPhan"].ToString()
                                + "\" Chon=\"" + r["Chon"]
                                + "\" />";
                        }
                    }

                    if (xmlData == "")
                        return;
                    else
                    {
                        xmlData = "<Root>" + xmlData + "</Root>";
                        int kq = 0;
                       DataServices.MonHocCoNganHangDeThi.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);

                        if (kq == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Cursor.Current = Cursors.WaitCursor;
                        InitData();
                        Cursor.Current = Cursors.Default;
                    }
                    Cursor.Current = Cursors.Default;
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
