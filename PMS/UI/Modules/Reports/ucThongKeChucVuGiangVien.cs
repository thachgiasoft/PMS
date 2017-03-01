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
using DevExpress.XtraGrid.Views.Base;
using PMS.Entities;
using PMS.UI.Forms.NghiepVu;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeChucVuGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        public ucThongKeChucVuGiangVien()
        {
            InitializeComponent();
        }

        private void ucThongKeChucVuGiangVien_Load(object sender, EventArgs e)
        {
            #region Thong ke ho so giang vien
            AppGridView.InitGridView(gridViewThongKeChucVu, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThongKeChucVu, new string[] { "MaGiangVienQuanLy", "Ho", "Ten","TenChucVuHienTai", "ChiTiet" },
                new string[] { "Mã GV", "Họ", "Tên", "Chức vụ hiện tại", "Chi Tiết" },
                new int[] { 120, 100, 50, 300, 70});
            AppGridView.ReadOnlyColumn(gridViewThongKeChucVu, new string[] { "MaGiangVienQuanLy", "Ho", "Ten", "TenChucVuHienTai", "ChiTiet" });
            AppGridView.RegisterControlField(gridViewThongKeChucVu, "ChiTiet", repositoryItemButtonEdit1);
            #endregion

            #region Chuc vu 
            InitData();
            #endregion
        }
        public void InitData()
        {
            //bindingSourceThongKeChucVu.DataSource = DataServices.ViewThongKeChucVu.GetAll();
        }

        private void gridViewThongKeChucVu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //ColumnView view = sender as ColumnView;
            //if (view.ActiveFilter.IsEmpty)
            //{
            //    if (view.FocusedColumn.FieldName == "ChiTiet")
            //    {
            //        ViewThongKeChucVu obj = gridViewThongKeChucVu.GetFocusedRow() as ViewThongKeChucVu;
            //        if (obj != null)
            //        {
            //            if (!obj.IsNew)
            //            {
            //                using (frmThongKeChucVuGiangVienChiTiet frm = new frmThongKeChucVuGiangVienChiTiet(obj.MaGiangVienQuanLy, obj.MaGiangVien))
            //                {
            //                    frm.frm = this;
            //                    frm.ShowDialog();
            //                }
            //            }
            //            else
            //                XtraMessageBox.Show("Bạn chưa lưu lại dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //}
        }

        private void btn_Lamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void btn_In_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            //VList<ViewThongKeChucVu> vlist = bindingSourceThongKeChucVu.DataSource as VList<ViewThongKeChucVu>;
            //if (vlist != null)
            //{
            //    using (frmBaoCao frm = new frmBaoCao())
            //    {
            //        if (PMS.Common.Globals._cauhinh != null)
            //        {
            //            frm.InThongKeChucVuGiangvien(PMS.Common.Globals._cauhinh.TenTruong.ToUpper(), vlist);
            //            frm.ShowDialog();
            //        }
            //        else
            //        {
            //            XtraMessageBox.Show("Bạn chưa cấu hình tên trường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }
            //}
           
            //Cursor.Current = Cursors.WaitCursor;
        }
    }
}
