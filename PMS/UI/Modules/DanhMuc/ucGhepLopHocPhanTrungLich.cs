using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Modules.NghiepVu
{
    public partial class ucGhepLopHocPhanTrungLich : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion

        public ucGhepLopHocPhanTrungLich()
        {
            InitializeComponent();
        }

        private void ucGhepLopHocPhanTrungLich_Load(object sender, EventArgs e)
        {
            #region Init Grid
            AppGridView.InitGridView(gridViewGhepLHP, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewGhepLHP, new string[] { "TenDonVi", "MaCanBoGiangDay", "HoTen", "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLopHocPhan", "MaLopTruocGhep", "SiSoTruocGhep", "MaLopSauGhep", "SiSoSauGhep", "LopChinh", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Đơn vị", "Mã giảng viên", "Họ tên", "Mã môn học", "Tên môn học", "Bậc đào tạo", "Lớp học phần", "Mã lớp trước ghép", "Sĩ số trước ghép", "Mã lớp sau ghép", "Sĩ số sau ghép", "Lớp chính", "NgayCapNhat", "NguoiCapNhat" }
                    , new int[] { 130, 110, 150, 100, 150, 40, 120, 80, 60, 160, 60, 60, 99, 99 });
            AppGridView.AlignHeader(gridViewGhepLHP, new string[] { "MaCanBoGiangDay", "HoTen", "TenDonVi", "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLopHocPhan", "MaLopTruocGhep", "SiSoTruocGhep", "MaLopSauGhep", "SiSoSauGhep", "LopChinh", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            PMS.Common.Globals.WordWrapHeader(gridViewGhepLHP, 50);
            PMS.Common.Globals.GridRowColor(gridViewGhepLHP, new Font("Tahoma", 8, FontStyle.Bold), Color.White, "LopChinh", "True");
            AppGridView.MergeCell(gridViewGhepLHP, new string[] { "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLopHocPhan", "MaLopTruocGhep", "SiSoTruocGhep", "MaLopSauGhep", "SiSoSauGhep", "LopChinh" });
            AppGridView.SummaryField(gridViewGhepLHP, "MaCanBoGiangDay", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewGhepLHP, new string[] { "TenDonVi", "MaCanBoGiangDay", "HoTen", "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLopHocPhan", "MaLopTruocGhep", "SiSoTruocGhep" });
            AppGridView.HideField(gridViewGhepLHP, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.FixedField(gridViewGhepLHP, new string[] { "LopChinh", "SiSoSauGhep" }, FixedStyle.Right);
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, false, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" }, new int[] { 100 });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, false, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" }, new int[] { 100, 100 });
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            InitData();
        }

        void InitData()
        {

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.LopHocPhanGhepThoiKhoaBieu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceGhepLHP.DataSource = tbl;
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.LopHocPhanGhepThoiKhoaBieu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceGhepLHP.DataSource = tbl;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.LopHocPhanGhepThoiKhoaBieu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceGhepLHP.DataSource = tbl;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLayDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                try
                {
                    int kiemTra = 0;
                    DataServices.LopHocPhanGhepThoiKhoaBieu.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemTra);
                    if (kiemTra == 1)
                    {
                        if (XtraMessageBox.Show(string.Format("Dữ liệu lớp ghép năm học {0} - {1} đã có, tiếp tục lấy dữ liệu sẽ ghi đè dữ liệu cũ. \n Bạn có muốn lấy dữ liệu?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            DataServices.LopHocPhanGhepThoiKhoaBieu.LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                            InitData();
                            Cursor.Current = Cursors.Default;
                        }
                        else
                        {
                            return;
                        }
                    }
                    if (kiemTra != 1)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        DataServices.LopHocPhanGhepThoiKhoaBieu.LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                        InitData();
                        Cursor.Current = Cursors.Default;
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                            gridControlGhepLHP.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGhepLHP);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewGhepLHP.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataTable tb = bindingSourceGhepLHP.DataSource as DataTable;
                    string xmlData = "";
                    foreach (DataRow r in tb.Rows)
                    {
                        if (r.RowState != DataRowState.Deleted)
                        {
                            xmlData += "<Input Id=\"" + r["Id"]
                                    + "\" S=\"" + r["SiSoSauGhep"]
                                    + "\" M=\"" + r["MaLopSauGhep"]
                                    + "\" C=\"" + r["LopChinh"]
                                    + "\" D=\"" + r["NgayCapNhat"]
                                    + "\" U=\"" + r["NguoiCapNhat"]
                                    + "\" />";
                        }
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";
                    int kq = 0;
                    DataServices.LopHocPhanGhepThoiKhoaBieu.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                    InitData();
                    Cursor.Current = Cursors.Default;
                    if (kq == 0)
                        XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void gridViewGhepLHP_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGhepLHP, e);
        }

        private void gridViewGhepLHP_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "SiSoSauGhep" || col.FieldName == "MaLopSauGhep" || col.FieldName == "LopChinh")
            {
                gridViewGhepLHP.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewGhepLHP.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewGhepLHP_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        { 
            if (e.Column.FieldName == "LopChinh")
            {
                //MessageBox.Show(e.Value.ToString() + "\n" + gridViewGhepLHP.GetRowCellValue(e.RowHandle, "HoTen").ToString());
                int siSo;
                string maLop;
                if (((bool)e.Value))    //Giá trị mới là true
                {
                    maLop = (string)gridViewGhepLHP.GetRowCellValue(e.RowHandle, "MaLopTruocGhep");
                    siSo = (int)gridViewGhepLHP.GetRowCellValue(e.RowHandle, "SiSoTruocGhep");
                    //Lan lên trên:
                    for (int i = e.RowHandle - 1; 0 <= i && gridViewGhepLHP.GetRowCellValue(i, "HoTen").Equals(gridViewGhepLHP.GetRowCellValue(e.RowHandle, "HoTen")); i--)
                    {
                        if (siSo > 0)   //Chỉ xảy ra 1 lần, trên hoặc dưới.
                        {
                            //Cập nhật sĩ số sau ghép:
                            gridViewGhepLHP.SetRowCellValue(i, "LopChinh", false);
                            gridViewGhepLHP.SetRowCellValue(i, "MaLopSauGhep", "");
                            gridViewGhepLHP.SetRowCellValue(i, "SiSoSauGhep", 0);
                            
                        }
                        maLop += " + " + (string)gridViewGhepLHP.GetRowCellValue(i, "MaLopTruocGhep");
                        siSo += (int)gridViewGhepLHP.GetRowCellValue(i, "SiSoTruocGhep");
                    }
                    //Lan xuống dưới:
                    for (int i = e.RowHandle + 1; i < gridViewGhepLHP.RowCount && gridViewGhepLHP.GetRowCellValue(i, "HoTen").Equals(gridViewGhepLHP.GetRowCellValue(e.RowHandle, "HoTen")); i++)
                    {
                        if (siSo > 0)   //Chỉ xảy ra 1 lần, dưới hoặc trên.
                        {
                            //Cập nhật sĩ số sau ghép:
                            gridViewGhepLHP.SetRowCellValue(i, "LopChinh", false);
                            gridViewGhepLHP.SetRowCellValue(i, "MaLopSauGhep", "");
                            gridViewGhepLHP.SetRowCellValue(i, "SiSoSauGhep", 0);
                            gridViewGhepLHP.SetRowCellValue(e.RowHandle, "SiSoSauGhep", siSo);
                        }
                        maLop += " + " + (string)gridViewGhepLHP.GetRowCellValue(i, "MaLopTruocGhep");
                        siSo += (int)gridViewGhepLHP.GetRowCellValue(i, "SiSoTruocGhep");
                    }
                    //Cập nhật mã lớp sau ghép:
                    if (maLop.Equals(" + "))
                    {
                        gridViewGhepLHP.SetRowCellValue(e.RowHandle, "MaLopSauGhep", "");
                    }
                    else
                    {
                        gridViewGhepLHP.SetRowCellValue(e.RowHandle, "MaLopSauGhep", maLop);
                    }
                    gridViewGhepLHP.SetRowCellValue(e.RowHandle, "SiSoSauGhep", siSo);
                }
                else
                {
                    //Lan lên trên:
                    for (int i = e.RowHandle - 1; 0 <= i && gridViewGhepLHP.GetRowCellValue(i, "HoTen").Equals(gridViewGhepLHP.GetRowCellValue(e.RowHandle, "HoTen")); i--)
                    {
                        //Bỏ in đậm, không còn lớp nào là lớp chính thì xem như không ghép lớp nữa. Khi đồng bộ phải hiện đầy đủ lớp như cũ -> cập nhật [cust_View_KhoiLuong_GiangDay_DongBo].
                        gridViewGhepLHP.SetRowCellValue(i, "SiSoSauGhep", (int)gridViewGhepLHP.GetRowCellValue(i, "SiSoTruocGhep"));
                        gridViewGhepLHP.SetRowCellValue(i, "MaLopSauGhep", (string)gridViewGhepLHP.GetRowCellValue(i, "MaLopTruocGhep"));
                    }
                    //Lan xuống dưới:
                    for (int i = e.RowHandle + 1; i < gridViewGhepLHP.RowCount && gridViewGhepLHP.GetRowCellValue(i, "HoTen").Equals(gridViewGhepLHP.GetRowCellValue(e.RowHandle, "HoTen")); i++)
                    {
                        //Bỏ in đậm, không còn lớp nào là lớp chính thì xem như không ghép lớp nữa. Khi đồng bộ phải hiện đầy đủ lớp như cũ -> cập nhật [cust_View_KhoiLuong_GiangDay_DongBo].
                        gridViewGhepLHP.SetRowCellValue(i, "SiSoSauGhep", (int)gridViewGhepLHP.GetRowCellValue(i, "SiSoTruocGhep"));
                        gridViewGhepLHP.SetRowCellValue(i, "MaLopSauGhep", (string)gridViewGhepLHP.GetRowCellValue(i, "MaLopTruocGhep"));
                    }
                    gridViewGhepLHP.SetRowCellValue(e.RowHandle, "SiSoSauGhep", (int)gridViewGhepLHP.GetRowCellValue(e.RowHandle, "SiSoTruocGhep"));
                    gridViewGhepLHP.SetRowCellValue(e.RowHandle, "MaLopSauGhep", (string)gridViewGhepLHP.GetRowCellValue(e.RowHandle, "MaLopTruocGhep"));
                }
            }
        }

        private void gridControlGhepLHP_Click(object sender, EventArgs e)
        {

        }

        private void layoutControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSourceGhepLHP_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlBottom_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlLeft_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlRight_Click(object sender, EventArgs e)
        {

        }

        private void bindingSourceHocKy_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSourceNamHoc_CurrentChanged(object sender, EventArgs e)
        {

        }
        
    }
}
