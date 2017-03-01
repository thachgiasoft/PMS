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
using PMS.BLL;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmPhanQuyenTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        int MaTaiKhoan;
        public frmPhanQuyenTaiKhoan()
        {
            InitializeComponent();
        }

        public frmPhanQuyenTaiKhoan(int maTaiKhoan)
        {
            InitializeComponent();
            MaTaiKhoan = maTaiKhoan;
        }

        private void frmPhanQuyenTaiKhoan_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewPhanQuyenTaiKhoan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false);
            AppGridView.ShowField(gridViewPhanQuyenTaiKhoan, new string[] { "TenChucNang", "KhongDuocPhepCapNhat" }
                    , new string[] { "Tên chức năng", "Không được phép cập nhật" }, new int[] { 350, 150 });
            AppGridView.AlignHeader(gridViewPhanQuyenTaiKhoan, new string[] { "TenChucNang", "KhongDuocPhepCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewPhanQuyenTaiKhoan, new string[] { "TenChucNang" });

            InitData();
        }

        void InitData()
        {
            DataTable tbl = new DataTable();
            IDataReader reader = DataServices.ChucNang.GetByMaTaiKhoan(MaTaiKhoan);
            tbl.Load(reader);
            bindingSourcePhanQuyen.DataSource = tbl;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewPhanQuyenTaiKhoan.FocusedRowHandle = -1;
            DataTable tbl = bindingSourcePhanQuyen.DataSource as DataTable;

            if (tbl != null && tbl.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn muốn lưu các thay đồi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow r in tbl.Rows)
                        {
                            if (r.RowState == DataRowState.Modified)
                            {
                                xmlData += String.Format("<Input M=\"{0}\" T=\"{1}\" K=\"{2}\" />", r["MaTaiKhoan"], r["TenForm"], r["KhongDuocPhepCapNhat"]);
                            }
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);

                        int result = -1;
                        DataServices.PhanQuyenControlTrenForm.Luu(xmlData, ref result);
                        if (result == 0)
                        {
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    { XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }       
                }
            }
        }


    }
}