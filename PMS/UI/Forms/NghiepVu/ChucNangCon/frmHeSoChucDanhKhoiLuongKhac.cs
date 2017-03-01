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
using PMS.Entities.Validation;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    public partial class frmHeSoChucDanhKhoiLuongKhac : DevExpress.XtraEditors.XtraForm
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
        int MaKhoiLuong;
        string TenLoaiKhoiLuong;
        #endregion
        #region Event Form
        public frmHeSoChucDanhKhoiLuongKhac()
        {
            InitializeComponent();
        }

        public frmHeSoChucDanhKhoiLuongKhac(int _maKhoiLuong, string _tenLKL)
        {
            InitializeComponent();
            MaKhoiLuong = _maKhoiLuong;
            TenLoaiKhoiLuong = _tenLKL;
        }

        private void frmHeSoChucDanhKhoiLuongKhac_Load(object sender, EventArgs e)
        {
            #region Init Grid
            AppGridView.InitGridView(gridViewHeSo, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHeSo, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHeSo, new string[] { "Stt", "MaHocHam", "MaHocVi", "HeSo" },
                        new string[] { "STT", "Học hàm", "Học vị", "Hệ số" }, new int[] {50, 150, 150, 100 });
            AppGridView.AlignHeader(gridViewHeSo, new string[] { "Stt", "MaHocHam", "MaHocVi", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);
            
            AppGridView.RegisterControlField(gridViewHeSo, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewHeSo, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            #endregion

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion

            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion
        #region InitData
        void InitData()
        {
            txtLoaiKhoiLuong.Text = TenLoaiKhoiLuong;
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();

            if (MaKhoiLuong != null)
            {
                bindingSourceHeSo.DataSource = DataServices.HeSoChucDanhKhoiLuongKhac.GetByMaKhoiLuong(MaKhoiLuong);
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
            AppGridView.DeleteSelectedRows(gridViewHeSo);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSo.FocusedRowHandle = -1;
            TList<HeSoChucDanhKhoiLuongKhac> list = bindingSourceHeSo.DataSource as TList<HeSoChucDanhKhoiLuongKhac>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoChucDanhKhoiLuongKhac k in list)
                                k.MaKhoiLuong = MaKhoiLuong;
                            bindingSourceHeSo.EndEdit();
                            DataServices.HeSoChucDanhKhoiLuongKhac.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        #endregion

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            HeSoChucDanhKhoiLuongKhac obj = target as HeSoChucDanhKhoiLuongKhac;
            if (obj != null)
            {
                if (((TList<HeSoChucDanhKhoiLuongKhac>)bindingSourceHeSo.DataSource).FindAll(p => p.MaHocHam == obj.MaHocHam & p.MaHocVi == obj.MaHocVi).Count > 1)
                {
                    e.Description = string.Format("Dòng dữ liệu {0} hiện tại đã có.", obj.Stt);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSo_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewHeSo_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            HeSoChucDanhKhoiLuongKhac obj = e.Row as HeSoChucDanhKhoiLuongKhac;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaHocHam, MaHocVi");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }
    }
}