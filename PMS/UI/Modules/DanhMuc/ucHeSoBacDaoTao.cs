using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Common.Grid;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using DevExpress.XtraEditors;
using PMS.Core;
using PMS.Entities.Validation;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoBacDaoTao : DevExpress.XtraEditors.XtraUserControl
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
        public ucHeSoBacDaoTao()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucHeSoBacDaoTao_Load(object sender, EventArgs e)
        {
            #region InitGridview
            AppGridView.InitGridView(gridViewHeSoBacDaoTao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoBacDaoTao, new string[] { "Stt", "MaQuanLy", "TenBacDaoTao", "HeSo", "NgayBdApDung", "NgayKtApDung" },
                        new string[] { "STT", "Mã bậc đào tạo", "Tên bậc đào tạo", "Hệ số", "Ngày BD áp dụng", "Ngày KT áp dụng" },
                        new int[] { 70, 70, 200, 100, 150, 150 });
            AppGridView.AlignHeader(gridViewHeSoBacDaoTao, new string[] { "Stt", "MaQuanLy", "TenBacDaoTao", "HeSo", "NgayBdApDung", "NgayKtApDung" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewHeSoBacDaoTao, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            if (_maTruong != "LAW")
                AppGridView.HideField(gridViewHeSoBacDaoTao, new string[] { "NgayBdApDung", "NgayKtApDung" });
            #endregion
            
            InitData();
        }

        #region InitData
        private void InitData()
        {
            bindingSourceHeSoBacDaoTao.DataSource = DataServices.HeSoBacDaoTao.GetAll();
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoBacDaoTao);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoBacDaoTao.FocusedRowHandle = -1;
            TList<HeSoBacDaoTao> list = bindingSourceHeSoBacDaoTao.DataSource as TList<HeSoBacDaoTao>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoBacDaoTao.EndEdit();
                            DataServices.HeSoBacDaoTao.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoBacDaoTao, barManager1, layoutControl1 });
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

        private void gridViewHeSoBacDaoTao_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoBacDaoTao, e);
        }

        private void gridViewHeSoBacDaoTao_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoBacDaoTao, e);
        }

        private void gridViewHeSoBacDaoTao_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            HeSoBacDaoTao obj = e.Row as HeSoBacDaoTao;
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
            HeSoBacDaoTao obj = target as HeSoBacDaoTao;
            if (obj != null)
            {
                if (((TList<HeSoBacDaoTao>)bindingSourceHeSoBacDaoTao.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSoBacDaoTao_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }
}
