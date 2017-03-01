using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmKhoaTaiKhoanGiangVien : DevExpress.XtraEditors.XtraForm
    {

        public frmKhoaTaiKhoanGiangVien()
        {
            InitializeComponent();
        }

        private void frmKhoaTaiKhoanGiangVien_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoaTaiKhoan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewKhoaTaiKhoan, new string[] { "MaGiangVien", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi", "KhoaTaiKhoan" }
                    , new string[] { "Id", "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên", "Khoa - Đơn vị", "Khoá tài khoản" }
                    , new int[] { 99, 90, 140, 100, 100, 100, 100, 100 });

            AppGridView.AlignHeader(gridViewKhoaTaiKhoan, new string[] { "MaGiangVien", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi", "KhoaTaiKhoan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewKhoaTaiKhoan, new string[] { "MaGiangVien" });
            AppGridView.ReadOnlyColumn(gridViewKhoaTaiKhoan, new string[] { "MaGiangVien", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi" });
            AppGridView.SummaryField(gridViewKhoaTaiKhoan, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            #endregion
            InitData();
        }
        void InitData()
        {
            //bindingSourceKhoaTaiKhoan.DataSource = DataServices.ViewGiangVien.GetAll();\
            gridControlKhoaTaiKhoan.DataSource = DataServices.ViewGiangVien.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoaTaiKhoan);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewKhoaTaiKhoan.FocusedRowHandle = -1;
            VList<ViewGiangVien> list = gridControlKhoaTaiKhoan.DataSource as VList<ViewGiangVien>;
            if (list.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        string xmlData = "";
                        foreach (ViewGiangVien cv in list)
                        {

                            xmlData += String.Format("<Input M=\"{0}\" K=\"{1}\" />", cv.MaGiangVien, cv.KhoaTaiKhoan);
                        }
                        BindingContext[gridControlKhoaTaiKhoan.DataSource].EndCurrentEdit();
                        //bindingSourceKhoaTaiKhoan.EndEdit();
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);

                        int kq = 0;
                        DataServices.ViewGiangVien.LuuKhoaTaiKhoan(xmlData, ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void gridViewKhoaTaiKhoan_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoaTaiKhoan, e);
        }

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewKhoaTaiKhoan.DataRowCount; i++)
                {
                    gridViewKhoaTaiKhoan.SetRowCellValue(i, "KhoaTaiKhoan", "True");
                }                
            }
            if (checkEditChonTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewKhoaTaiKhoan.DataRowCount; i++)
                {
                    gridViewKhoaTaiKhoan.SetRowCellValue(i, "KhoaTaiKhoan", "False");
                }
            }
        }
    }
}