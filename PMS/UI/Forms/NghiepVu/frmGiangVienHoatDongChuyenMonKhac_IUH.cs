using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using PMS.Services;
using DevExpress.XtraEditors.Repository;
//using Libraries.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVienHoatDongChuyenMonKhac_IUH : DevExpress.XtraEditors.XtraForm
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
        string _maTruong;
        #endregion
        public frmGiangVienHoatDongChuyenMonKhac_IUH()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Where(i => i.TenCauHinh == "Mã trường").First().GiaTri;
        }

        private void frmGiangVienHoatDongChuyenMonKhac_IUH_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewGiangVienHDNGD, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewGiangVienHDNGD, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewGiangVienHDNGD, new string[] { "MaGiangVien", "GhiChu", "SoLuong" }
                        , new string[] { "Họ tên GV", "Tên hoạt động", "Số tiết" }
                        , new int[] { 180, 350, 90 });
            AppGridView.AlignHeader(gridViewGiangVienHDNGD, new string[] { "MaGiangVien", "GhiChu", "SoLuong"  }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewGiangVienHDNGD, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);

            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "NgaySinh" }, new string[] { "Mã giảng viên", "Họ tên", "Ngày sinh" }
                        , new int[] { 100, 180, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 500);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHoc(cboNamHoc.EditValue.ToString());
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienHDNGD);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
           
                gridViewGiangVienHDNGD.FocusedRowHandle = -1;
                TList<GiangVienHoatDongNgoaiGiangDay> list = bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource as TList<GiangVienHoatDongNgoaiGiangDay>;
                if (list != null)
                {
                    foreach (GiangVienHoatDongNgoaiGiangDay g in list)
                    {
                        g.NamHoc = cboNamHoc.EditValue.ToString();
                    }
                    if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (list.IsValid)
                        {
                            try
                            {
                                bindingSourceGiangVienHoatDongNgoaiGiangDay.EndEdit();
                                DataServices.GiangVienHoatDongNgoaiGiangDay.Save(list);
                                XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void gridViewGiangVienHDNGD_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienHDNGD, e);
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
        }

    }
}
