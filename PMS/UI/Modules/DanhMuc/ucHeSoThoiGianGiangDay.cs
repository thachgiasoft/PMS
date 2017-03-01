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
using PMS.Core;
using PMS.Entities.Validation;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoThoiGianGiangDay : DevExpress.XtraEditors.XtraUserControl
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

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        public ucHeSoThoiGianGiangDay()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void gridControlHeSoThoiGianGiangDay_Load(object sender, EventArgs e)
        {
            #region Init Grid
            if (_maTruong == "UEL")
            {
                AppGridView.InitGridView(gridViewHeSoThoiGianGiangDay, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
                AppGridView.ShowEditor(gridViewHeSoThoiGianGiangDay, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
                AppGridView.ShowField(gridViewHeSoThoiGianGiangDay, new string[] { "MaQuanLy", "TenHeSo", "GhiChu" },
                            new string[] { "Mã quản lý", "Tên buổi học", "Ghi chú" }, new int[] { 90, 200, 250 });
                AppGridView.AlignHeader(gridViewHeSoThoiGianGiangDay, new string[] { "MaQuanLy", "TenHeSo", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);

            }
            else
            {
                AppGridView.InitGridView(gridViewHeSoThoiGianGiangDay, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
                AppGridView.ShowEditor(gridViewHeSoThoiGianGiangDay, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
                AppGridView.ShowField(gridViewHeSoThoiGianGiangDay, new string[] { "MaQuanLy", "TenHeSo", "HeSo", "GhiChu" },
                            new string[] { "Mã quản lý", "Tên hệ số", "Hệ số", "Ghi chú" }, new int[] { 90, 200, 150, 150 });
                AppGridView.AlignHeader(gridViewHeSoThoiGianGiangDay, new string[] { "MaQuanLy", "TenHeSo", "HeSo", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);

                AppGridView.RegisterControlField(gridViewHeSoThoiGianGiangDay, "HeSo", repositoryItemSpinEditHeSo);
            }

            bindingSourceHeSoThoiGianGiangDay.DataSource = DataServices.HeSoThoiGianGiangDay.GetAll();
            #endregion
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceHeSoThoiGianGiangDay.DataSource = DataServices.HeSoThoiGianGiangDay.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoThoiGianGiangDay);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewHeSoThoiGianGiangDay.FocusedRowHandle = -1;
            TList<HeSoThoiGianGiangDay> list = bindingSourceHeSoThoiGianGiangDay.DataSource as TList<HeSoThoiGianGiangDay>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoThoiGianGiangDay.EndEdit();
                            DataServices.HeSoThoiGianGiangDay.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoThoiGianGiangDay, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeSoThoiGianGiangDay_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoThoiGianGiangDay, e);
        }

        private void gridViewHeSoThoiGianGiangDay_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoThoiGianGiangDay, e);
        }

        private void gridViewHeSoThoiGianGiangDay_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            HeSoThoiGianGiangDay obj = e.Row as HeSoThoiGianGiangDay;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            HeSoThoiGianGiangDay obj = target as HeSoThoiGianGiangDay;
            if (obj != null)
            {
                if (((TList<HeSoThoiGianGiangDay>)bindingSourceHeSoThoiGianGiangDay.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã quản lý {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSoThoiGianGiangDay_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }
}
