using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.UI.Modules.Reports;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThongKeChucVuGiangVienChiTiet : DevExpress.XtraEditors.XtraForm
    {

        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btn_Luu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Luu.ShortCut = Shortcut.None;
            }
            else
            {
                btn_Luu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion


        private string maGiangVienQuanLy;
        private int maGiangVien;
        public ucThongKeChucVuGiangVien frm;
        public frmThongKeChucVuGiangVienChiTiet()
        {
            InitializeComponent();
        }

        public frmThongKeChucVuGiangVienChiTiet(string _maGiangVienQuanLy, int _maGiangVien)
        {
            InitializeComponent();
            this.maGiangVienQuanLy = _maGiangVienQuanLy;
            this.maGiangVien = _maGiangVien;
        }

        private void frmThongKeChucVuGiangVienChiTiet_Load(object sender, EventArgs e)
        {
            #region Thong ke ho so chi tiet
            AppGridView.InitGridView(gridViewThongKeChucVuChiTiet, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThongKeChucVuChiTiet, new string[] {"Ho", "Ten", "MaChucVuQuanLy", "TenChucVu" ,"KyHieu", "Sotiet", "PhanTramGio","NguongTiet","NgayHieuLuc","NgayHetHieuLuc","TrangThai","DamNhiem" },
                new string[] { "Họ", "Tên", "Mã chức vụ", "Chức vụ", "Ký hiệu", "Số tiết", "% Giờ","Ngưỡng tiết","Ngày hiệu lực","Ngày hết hiệu lực","Trạng thái","Đảm nhiệm" },
                new int[] { 80, 50, 75, 150 , 55, 60, 50,75,90,100,70,70 });
            AppGridView.RegisterControlField(gridViewThongKeChucVuChiTiet, "TrangThai", repositoryItemCheckEdit1);
            AppGridView.RegisterControlField(gridViewThongKeChucVuChiTiet, "DamNhiem", repositoryItemCheckEdit2);
            #endregion
            #region Init Data
            InitData();
            #endregion
        }

        private void InitData()
        {
            //Cursor.Current = Cursors.WaitCursor;
            //bindingSourceThongKeChucVuChiTiet.DataSource = DataServices.ViewThongKeChucVuChiTiet.GetByMaGiangVienQuanLy(maGiangVienQuanLy);
            //Cursor.Current = Cursors.Default;
        }

        private void btn_Lamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //VList<ViewThongKeChucVuChiTiet> vlist = bindingSourceThongKeChucVuChiTiet.DataSource as VList<ViewThongKeChucVuChiTiet>;
            //if (vlist != null)
            //{
            //    if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        gridViewThongKeChucVuChiTiet.FocusedRowHandle = -1;
            //        foreach (ViewThongKeChucVuChiTiet d in vlist)
            //        {
            //            try
            //            {
            //                GiangVienChucVu obj = DataServices.GiangVienChucVu.GetByMaGiangVienMaChucVu(maGiangVien, (int)d.MaChucVu);
            //                if (obj == null)
            //                {
            //                    if (d.DamNhiem == true)
            //                    {
            //                        if (d.NgayHieuLuc != null)
            //                        {
            //                            obj = new GiangVienChucVu();
            //                            obj.MaGiangVien = d.MaGiangVien;
            //                            obj.MaChucVu = (int)d.MaChucVu;
            //                            obj.NgayHieuLuc = d.NgayHieuLuc;
            //                            obj.NgayHetHieuLuc = d.NgayHetHieuLuc;
            //                            obj.TrangThai = d.TrangThai;
            //                            DataServices.GiangVienChucVu.Save(obj);
            //                        }
            //                        else
            //                        {
            //                            XtraMessageBox.Show("Ngày bắt đầu đảm nhiệm chức vụ không được trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                            return;
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    obj.NgayHieuLuc = d.NgayHieuLuc;
            //                    obj.NgayHetHieuLuc = d.NgayHetHieuLuc;
            //                    obj.TrangThai = d.TrangThai;
            //                    if (d.DamNhiem == false)
            //                    {
            //                        DataServices.GiangVienChucVu.Delete(obj);
            //                    }
            //                    DataServices.GiangVienChucVu.Update(obj);
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                XtraMessageBox.Show("Lỗi cập nhật dữ liệu.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        private void frmThongKeChucVuGiangVienChiTiet_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.InitData();
        }
    }
}