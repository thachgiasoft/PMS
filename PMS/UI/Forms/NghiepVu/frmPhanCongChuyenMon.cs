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
using PMS.Entities.Validation;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmPhanCongChuyenMon : DevExpress.XtraEditors.XtraForm
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

        string xmlData = string.Empty;
        public frmPhanCongChuyenMon()
        {
            InitializeComponent();
        }

        private void frmPhanCongChuyenMon_Load(object sender, EventArgs e)
        {
            #region Phan cong chuyen mon
            AppGridView.InitGridView(gridViewMonHoc, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewMonHoc, new string[] { "MaBoMon", "TenBoMon", "MaMonHoc", "TenMonHoc", "SoTinChi", "NgayPhanCong", "Chon" },
                new string[] { "Mã bộ môn", "Tên bộ môn", "Mã môn học", "Tên môn học", "Tín chỉ", "Ngày phân công", "Chọn" },
                new int[] { 80, 200, 80, 260, 55, 115, 55 });
            AppGridView.UnSortField(gridViewMonHoc, new string[] { "Chon" });
            AppGridView.AlignHeader(gridViewMonHoc, new string[] { "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewMonHoc, new string[] { "MaBoMon", "TenBoMon", "MaMonHoc", "TenMonHoc", "SoTinChi" });
            AppGridView.MergeCell(gridViewMonHoc, new string[] { "MaMonHoc", "SoTinChi", "NgayPhanCong", "Chon" });
            #endregion

            #region GiangVien
            AppGridView.InitGridView(gridViewGiangVien, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewGiangVien, new string[] { "MaQuanLy", "HoTen" },
                new string[] { "Mã GV", "Họ tên" },
                new int[] { 70, 160 });
            AppGridView.ReadOnlyColumn(gridViewGiangVien);
            AppGridView.SummaryField(gridViewGiangVien, "HoTen", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region DonVi - KhoaBoMon
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboDonVi, 400, 300);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã đơn vị", "Tên đơn vị" }, new int[] { 100, 250 });
            cboDonVi.Properties.DisplayMember = "TenBoMon";
            cboDonVi.Properties.ValueMember = "MaBoMon";
            cboDonVi.Properties.NullText = string.Empty;
            #endregion
            VList<ViewKhoaBoMon> vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            vListKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "[Tất cả]", TenKhoa = "[Tất cả]", MaBoMon = "[Tất cả]", TenBoMon = "[Tất cả]" });
            bindingSourceDonVi.DataSource = vListKhoaBoMon;
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            ViewKhoaBoMon objDonVi = bindingSourceDonVi.Current as ViewKhoaBoMon;
            if (objDonVi != null)
            {
                if (objDonVi.ThuTu == -1)
                    bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetAll();
                //else
                //    bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetByMaDonVi(objDonVi.MaBoMon);
            }

            bindingSourceMonHoc.DataSource = DataServices.ViewMonHocKhoa.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            VList<ViewKhoaBoMon> vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            vListKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "[Tất cả]", TenKhoa = "[Tất cả]", MaBoMon = "[Tất cả]", TenBoMon = "[Tất cả]" });
            bindingSourceDonVi.DataSource = vListKhoaBoMon;
            cboDonVi.DataBindings.Clear();
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewMonHoc.FocusedRowHandle = -1;
            VList<ViewMonHocKhoa> vListMonHoc = bindingSourceMonHoc.DataSource as VList<ViewMonHocKhoa>;
            if (vListMonHoc != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        GiangVien objGiangVien = bindingSourceGiangVien.Current as GiangVien;
                        if (objGiangVien != null)
                        {
                            TList<GiangVienChuyenMon> listGiangVienChuyenMon = DataServices.GiangVienChuyenMon.GetByMaGiangVien(objGiangVien.MaGiangVien);
                            foreach (ViewMonHocKhoa v in vListMonHoc)
                            {
                                GiangVienChuyenMon objChuyenMon = listGiangVienChuyenMon.Find(p => p.MaMonHoc == v.MaMonHoc);
                                if (v.Chon)
                                {
                                    if (objChuyenMon != null)
                                        objChuyenMon.NgayPhanCong = v.NgayPhanCong;
                                    else
                                    {
                                        objChuyenMon = new GiangVienChuyenMon() { MaGiangVien = objGiangVien.MaGiangVien, MaMonHoc = v.MaMonHoc, NgayPhanCong = v.NgayPhanCong };
                                        listGiangVienChuyenMon.Add(objChuyenMon);
                                    }
                                }
                                else
                                {
                                    if (objChuyenMon != null)
                                        objChuyenMon.MarkToDelete();
                                }
                            }
                            //Luu du lieu
                            if (listGiangVienChuyenMon.IsValid)
                            {
                                DataServices.GiangVienChuyenMon.Save(listGiangVienChuyenMon);
                                listGiangVienChuyenMon = DataServices.GiangVienChuyenMon.GetByMaGiangVien(objGiangVien.MaGiangVien);
                                xmlData = "<Root>";

                                foreach (GiangVienChuyenMon cm in listGiangVienChuyenMon)
                                {
                                    xmlData += "<ProfessorTechnician ProfessorID=\"" + cm.MaGiangVien + "\" CurriculumID=\""
                                        + cm.MaMonHoc +"\"></ProfessorTechnician>";
                                }
                                xmlData += "</Root>";
                                //DataServices.GiangVienChuyenMon.Luu(xmlData, objGiangVien.MaQuanLy);

                               
                                XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", listGiangVienChuyenMon.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gridViewGiangVien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            VList<ViewMonHocKhoa> vListMonHoc = bindingSourceMonHoc.DataSource as VList<ViewMonHocKhoa>;
            if (vListMonHoc != null)
            {
                GiangVien objGiangVien = bindingSourceGiangVien.Current as GiangVien;
                if (objGiangVien != null)
                {
                    TList<GiangVienChuyenMon> listGiangVienChuyenMon = DataServices.GiangVienChuyenMon.GetByMaGiangVien(objGiangVien.MaGiangVien);
                    foreach (ViewMonHocKhoa v in vListMonHoc)
                    {
                        GiangVienChuyenMon objChuyenMon = listGiangVienChuyenMon.Find(p => p.MaMonHoc == v.MaMonHoc);
                        if (objChuyenMon != null)
                        {
                            v.Chon = true;
                            v.NgayPhanCong = objChuyenMon.NgayPhanCong;
                        }
                        else
                        {
                            v.Chon = false;
                            v.NgayPhanCong = null;
                        }
                    }
                    gridViewMonHoc.RefreshData();
                }
            }
        }

        private void cboDonVi_CloseUp(object sender, CloseUpEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewKhoaBoMon objDonVi = bindingSourceDonVi.Current as ViewKhoaBoMon;
            if (objDonVi != null)
            {
                if (objDonVi.ThuTu == -1)
                    bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetAll();
                //else
                //    bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetByMaDonVi(objDonVi.MaBoMon);
            }
            else
                XtraMessageBox.Show("Bạn chưa chọn đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Cursor.Current = Cursors.Default;
        }
    }
}