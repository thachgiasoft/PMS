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
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoTroCapTheoKhoa: DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewKhoa> _listKhoaDonVi;
        #endregion
        public ucHeSoTroCapTheoKhoa()
        {
            InitializeComponent();
        }

        private void ucHeSoTroCapTheoKhoa_Load(object sender, EventArgs e)
        {
            #region InitGridview
            AppGridView.InitGridView(gridViewHeSoTCByKhoa, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoTCByKhoa, new string[] { "MaKhoa", "TenKhoa", "HeSo"},
                        new string[] { "Mã khoa", "Tên khoa", "Hệ số"},
                        new int[] { 70, 200, 70 });
            AppGridView.AlignHeader(gridViewHeSoTCByKhoa, new string[] { "MaKhoa", "TenKhoa", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewHeSoTCByKhoa, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewHeSoTCByKhoa, "MaKhoa", repositoryItemGridLookUpEditKhoaDonVi);
            AppGridView.ReadOnlyColumn(gridViewHeSoTCByKhoa, new string[] { "TenKhoa" });
            #endregion
            #region Init _khoaDonVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditKhoaDonVi, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditKhoaDonVi, 500, 650);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" }, new int[] { 100, 300 });
            repositoryItemGridLookUpEditKhoaDonVi.DisplayMember = "MaKhoa";
            repositoryItemGridLookUpEditKhoaDonVi.ValueMember = "MaKhoa";
            repositoryItemGridLookUpEditKhoaDonVi.NullText = string.Empty;
            #endregion
            InitData();
        }

        #region InitData
        private void InitData()
        {
            _listKhoaDonVi = DataServices.ViewKhoa.GetAll();
            bindingSourceKhoaDonVi.DataSource = _listKhoaDonVi;
            bindingSourceHeSoTroCapTheoKhoa.DataSource = DataServices.HeSoTroCapTheoKhoa.GetAll();
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
            AppGridView.DeleteSelectedRows(gridViewHeSoTCByKhoa);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoTCByKhoa.FocusedRowHandle = -1;
            TList<HeSoTroCapTheoKhoa> list = bindingSourceHeSoTroCapTheoKhoa.DataSource as TList<HeSoTroCapTheoKhoa>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoTroCapTheoKhoa.EndEdit();
                            DataServices.HeSoTroCapTheoKhoa.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoTCByKhoa, barManager1, layoutControl1 });
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

        private void gridViewHeSoTroCapTheoKhoa_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoTCByKhoa, e);
        }

        private void gridViewHeSoTroCapTheoKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoTCByKhoa, e);
        }

        private void gridViewHeSoTroCapTheoKhoa_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            HeSoTroCapTheoKhoa obj = e.Row as HeSoTroCapTheoKhoa;
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
            HeSoTroCapTheoKhoa obj = target as HeSoTroCapTheoKhoa;
            if (obj != null)
            {
                if (((TList<HeSoTroCapTheoKhoa>)bindingSourceHeSoTroCapTheoKhoa.DataSource).FindAll(p => p.MaKhoa == obj.MaKhoa).Count > 1)
                {
                    e.Description = string.Format("Mã khoa {0} hiện tại đã có.", obj.MaKhoa);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSoTroCapTheoKhoa_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewHeSoTCByKhoa_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaKhoa")
            {
                HeSoTroCapTheoKhoa h = gridViewHeSoTCByKhoa.GetRow(e.RowHandle) as HeSoTroCapTheoKhoa;
                ViewKhoa k = _listKhoaDonVi.Find(p => p.MaKhoa == h.MaKhoa);
                gridViewHeSoTCByKhoa.SetRowCellValue(e.RowHandle, "TenKhoa", k.TenKhoa);
            }
        }
    }
}
