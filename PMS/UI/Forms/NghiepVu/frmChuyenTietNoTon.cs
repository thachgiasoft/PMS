using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChuyenTietNoTon : DevExpress.XtraEditors.XtraForm
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
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion
        public frmChuyenTietNoTon()
        {
            InitializeComponent();
        }

        private void frmChuyenTietNoTon_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewChuyenNoTon, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewChuyenNoTon, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "SoTietNoKyTruoc", "NamHoc", "NgayCapNhat", "NguoiCapNhat", "MaGiangVien" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ tên", "Số tiết chuyển", "Chuyển sang năm học", "NgayCapNhat", "NguioCapNhat", "MaGiangVien" }
                , new int[] { 150, 90, 160, 100, 130, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewChuyenNoTon, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "SoTietNoKyTruoc", "NamHoc", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewChuyenNoTon, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "SoTietNoKyTruoc" });
            AppGridView.SummaryField(gridViewChuyenNoTon, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewChuyenNoTon, new string[] { "NgayCapNhat", "NguoiCapNhat", "MaGiangVien" });
            AppGridView.RegisterControlField(gridViewChuyenNoTon, "NamHoc", repositoryItemGridLookUpEditNamHoc);
            #region Năm học
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Repo _namHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNamHoc, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            repositoryItemGridLookUpEditNamHoc.ValueMember = "NamHoc";
            repositoryItemGridLookUpEditNamHoc.DisplayMember = "NamHoc";
            repositoryItemGridLookUpEditNamHoc.NullText = string.Empty;
            #endregion
            InitData();
        }

        #region InitData
        void InitData()
        {
            VList<ViewNamHoc> _listNamHoc = DataServices.ViewNamHoc.GetAll();
            bindingSourceNamHoc.DataSource = _listNamHoc;
            bindingSourceRepoNamHoc.DataSource = _listNamHoc;

            if (cboNamHoc.EditValue != null)
            { 
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.TietNoKyTruoc.GetTietChuyenSangNamSau(cboNamHoc.EditValue.ToString());
                tb.Load(reader);
                bindingSourceChuyenNoTon.DataSource = tb;
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewChuyenNoTon.FocusedRowHandle = -1;
            DataTable tb = bindingSourceChuyenNoTon.DataSource as DataTable;
            if (tb != null)
            {
                if (XtraMessageBox.Show("Bạn muốn lưu những thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow r in tb.Rows)
                        {
                            xmlData += String.Format("<Input M=\"{0}\" S=\"{1}\" Y=\"{2}\" D=\"{3}\" U=\"{4}\" />"
                                    , r["MaGiangVien"], PMS.Common.Globals.IsNull(r["SoTietNoKyTruoc"].ToString(), "decimal")
                                    , r["NamHoc"], r["NgayCapNhat"], r["NguoiCapNhat"]);
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);

                        int result = -1;
                        DataServices.TietNoKyTruoc.LuuChuyenNoTon(xmlData, cboNamHoc.EditValue.ToString(), ref result);

                        if (result == 0)
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
                            gridControlChuyen.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void gridViewChuyenNoTon_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SoTietNoKyTruoc" || e.Column.FieldName == "NamHoc")
            {
                gridViewChuyenNoTon.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewChuyenNoTon.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
    }
}