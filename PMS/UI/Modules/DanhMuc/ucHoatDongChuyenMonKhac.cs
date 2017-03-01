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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMS.UI.Forms.NghiepVu;
using PMS.Services;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHoatDongChuyenMonKhac : DevExpress.XtraEditors.XtraUserControl
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

                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();

        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public ucHoatDongChuyenMonKhac()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHoatDongChuyenMonKhac_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            switch (_maTruong)
            {
                
                case "VHU":
                    InitGridVHU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

          

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMaGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMaGiangVien, new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã giảng viên", "Tên giảng viên" }, new int[] { 150, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMaGiangVien, 350, 400);
            repositoryItemGridLookUpEditMaGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditMaGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditMaGiangVien.NullText = string.Empty;
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

            InitData();
        }

        void InitGridVHU()
        {
            #region InitGridview
            AppGridView.InitGridView(gridViewHoatDongChuyenMonKhac, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHoatDongChuyenMonKhac, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHoatDongChuyenMonKhac, new string[] { "MaGiangVien", "TenHoatDong", "SoTiet", "GhiChu" }
                , new string[] { "Mã giảng viên", "Tên hoạt động", "Số tiết", "Ghi chú" }
                , new int[] { 120, 450, 80, 130 });
            AppGridView.AlignHeader(gridViewHoatDongChuyenMonKhac, new string[] { "MaGiangVien", "TenHoatDong", "SoTiet", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewHoatDongChuyenMonKhac, "TenHoatDong", "{0}", DevExpress.Data.SummaryItemType.Count);

            AppGridView.RegisterControlField(gridViewHoatDongChuyenMonKhac, "MaGiangVien", repositoryItemGridLookUpEditMaGiangVien);
            AppGridView.RegisterControlField(gridViewHoatDongChuyenMonKhac, "SoTiet", repositoryItemSpinEditSoTiet);


            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
            #endregion

        }

        void InitRemaining()
        {
            #region InitGridview
            AppGridView.InitGridView(gridViewHoatDongChuyenMonKhac, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHoatDongChuyenMonKhac, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHoatDongChuyenMonKhac, new string[] { "MaGiangVien", "TenHoatDong", "SoTiet", "GhiChu" }
                , new string[] { "Mã giảng viên", "Tên hoạt động", "Số tiết", "Ghi chú" }
                , new int[] { 120, 450, 80, 130 });
            AppGridView.AlignHeader(gridViewHoatDongChuyenMonKhac, new string[] { "MaGiangVien", "TenHoatDong", "SoTiet", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewHoatDongChuyenMonKhac, "TenHoatDong", "{0}", DevExpress.Data.SummaryItemType.Count);

            AppGridView.RegisterControlField(gridViewHoatDongChuyenMonKhac, "MaGiangVien", repositoryItemGridLookUpEditMaGiangVien);
            AppGridView.RegisterControlField(gridViewHoatDongChuyenMonKhac, "SoTiet", repositoryItemSpinEditSoTiet);

            #endregion
        }

        void InitData()
        {
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                bindingSourceHoatDongChuyenMonKhac.DataSource = DataServices.HoatDongChuyenMonKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewHoatDongChuyenMonKhac.FocusedRowHandle = -1;
            TList<HoatDongChuyenMonKhac> list = bindingSourceHoatDongChuyenMonKhac.DataSource as TList<HoatDongChuyenMonKhac>;
            if (list != null)
            {
                foreach (HoatDongChuyenMonKhac h in list)
                {

                    h.NgayCapNhat= DateTime.Now;
                    h.NguoiCapNhat = UserInfo.UserName;
                    h.NamHoc = cboNamHoc.EditValue.ToString();
                    h.HocKy = cboHocKy.EditValue.ToString();
                }
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHoatDongChuyenMonKhac.EndEdit();
                            DataServices.HoatDongChuyenMonKhac.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridLookUpEditNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                bindingSourceHoatDongChuyenMonKhac.DataSource = DataServices.HoatDongChuyenMonKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void gridLookUpEditHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                bindingSourceHoatDongChuyenMonKhac.DataSource = DataServices.HoatDongChuyenMonKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHoatDongChuyenMonKhac);
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHoatDongChuyenMonKhac"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHoatDongChuyenMonKhac"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
    }
}
