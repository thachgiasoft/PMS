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
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.Entities.Validation;
using PMS.Entities;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucLyDoTamNghi : DevExpress.XtraEditors.XtraUserControl
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

        public ucLyDoTamNghi()
        {
            InitializeComponent();
        }

        private void ucLyDoTamNghi_Load(object sender, EventArgs e)
        {
            #region Init GridView QuyDoiGioChuan
            AppGridView.InitGridView(gridViewLyDoTamNghi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewLyDoTamNghi, new string[] { "MaQuanLy", "TenLyDoTamNghi", "TinhGiamTruGioChuan" },
                new string[] { "Mã quản lý", "Tên lý do tạm nghỉ", "Được giảm trừ giờ chuẩn" },
                new int[] { 90, 350, 100 });
            AppGridView.ShowEditor(gridViewLyDoTamNghi, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            PMS.Common.Globals.WordWrapHeader(gridViewLyDoTamNghi, 45);
            AppGridView.AlignHeader(gridViewLyDoTamNghi, new string[] { "MaQuanLy", "TenLyDoTamNghi", "TinhGiamTruGioChuan" }, DevExpress.Utils.HorzAlignment.Center);
            #endregion
            InitData();
        }

        void InitData()
        {
            bindingSourceLyDoTamNghi.DataSource = DataServices.LyDoTamNghi.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewLyDoTamNghi);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLyDoTamNghi.FocusedRowHandle = -1;
            TList<LyDoTamNghi> list = bindingSourceLyDoTamNghi.DataSource as TList<LyDoTamNghi>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceLyDoTamNghi.EndEdit();
                            DataServices.LyDoTamNghi.Save(list);
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
        }

        private void gridViewKyThi_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewLyDoTamNghi, e);
        }

        private void gridViewKyThi_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            KyThi obj = e.Row as KyThi;
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
            LyDoTamNghi obj = target as LyDoTamNghi;
            if (obj != null)
            {
                if (((TList<LyDoTamNghi>)bindingSourceLyDoTamNghi.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }
    }
}
