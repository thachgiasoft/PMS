using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Services;
using PMS.Entities;
using PMS.Core;
using PMS.Entities.Validation;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucCauHinhChung : DevExpress.XtraEditors.XtraUserControl
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

        public ucCauHinhChung()
        {
            InitializeComponent();
        }

        private void ucCauHinhChung_Load(object sender, EventArgs e)
        {
            #region Init gridview
            AppGridView.InitGridView(gridViewCauHinhChung, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCauHinhChung, new string[] { "TenCauHinh", "GiaTri" },
                        new string[] { "Tên cấu hình", "Giá trị" },
                        new int[] { 200, 300 });
            AppGridView.AlignHeader(gridViewCauHinhChung, new string[] { "TenCauHinh", "GiaTri" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewCauHinhChung, NewItemRowPosition.Top);
            #endregion
            bindingSourceCauHinhChung.DataSource = DataServices.CauHinhChung.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceCauHinhChung.DataSource = DataServices.CauHinhChung.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCauHinhChung);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewCauHinhChung.FocusedRowHandle = -1;
            TList<CauHinhChung> list = bindingSourceCauHinhChung.DataSource as TList<CauHinhChung>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceCauHinhChung.EndEdit();
                            DataServices.CauHinhChung.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewCauHinhChung, barManager1, layoutControl1 });
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

        private void gridViewCauHinhChung_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCauHinhChung, e);
        }

        private void gridViewCauHinhChung_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewCauHinhChung, e);
        }

        private void gridViewCauHinhChung_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CauHinhChung obj = e.Row as CauHinhChung;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "TenCauHinh");
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
            CauHinhChung obj = target as CauHinhChung;
            if (obj != null)
            {
                if (((TList<CauHinhChung>)bindingSourceCauHinhChung.DataSource).FindAll(p => p.TenCauHinh == obj.TenCauHinh).Count > 1)
                {
                    e.Description = string.Format("Tên cấu hình {0} hiện tại đã có.", obj.TenCauHinh);
                    return false;
                }
            }
            return true;
        }
    }
}
