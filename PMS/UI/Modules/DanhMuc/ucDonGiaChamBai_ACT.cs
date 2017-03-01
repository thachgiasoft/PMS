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
using PMS.Entities.Validation;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucDonGiaChamBai_ACT : DevExpress.XtraEditors.XtraUserControl
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
        public ucDonGiaChamBai_ACT()
        {
            InitializeComponent();
        }

        private void ucDonGiaChamBai_ACT_Load(object sender, EventArgs e)
        {
            #region Init GridView QuyDoiGioChuan
            //Cột TietQuyChuan là cột hệ số, cột BacDaoTao là ghi chú
            AppGridView.InitGridView(gridViewDonGiaChamBai, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewDonGiaChamBai, new string[] { "MaQuanLy", "MaKyThi", "MaHinhThucThi", "TietQuyChuan", "BacDaoTao", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "Mã quản lý", "Kỳ thi", "Hình thức thi", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 90, 200, 200, 150, 130, 99, 99 });
            AppGridView.ShowEditor(gridViewDonGiaChamBai, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewDonGiaChamBai, "MaKyThi", repositoryItemCheckedComboBoxEditKyThi);
            AppGridView.RegisterControlField(gridViewDonGiaChamBai, "MaHinhThucThi", repositoryItemCheckedComboBoxEditHinhThucThi);
            AppGridView.HideField(gridViewDonGiaChamBai, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion

            InitData();
        }
        void InitData()
        {
            InitKyThi();

            InitHinhThucThi();

            bindingSourceDonGiaChamBai.DataSource = DataServices.DonGiaChamBai.GetAll();

        }

        void InitKyThi()
        {
            #region Ky thi
            repositoryItemCheckedComboBoxEditKyThi.SelectAllItemCaption = "";
            repositoryItemCheckedComboBoxEditKyThi.Items.Clear();
            repositoryItemCheckedComboBoxEditKyThi.SeparatorChar = ';';
            repositoryItemCheckedComboBoxEditKyThi.TextEditStyle = TextEditStyles.Standard;
            VList<ViewKyThi> _Tlist = DataServices.ViewKyThi.GetAll();
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (ViewKyThi v in _Tlist)
            {
                list.Add(new CheckedListBoxItem(v.MaKyThi, v.TenKyThi, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditKyThi.Items.AddRange(list.ToArray());
            #endregion
        }

        void InitHinhThucThi()
        {
            repositoryItemCheckedComboBoxEditHinhThucThi.SelectAllItemCaption = "";
            repositoryItemCheckedComboBoxEditHinhThucThi.Items.Clear();
            repositoryItemCheckedComboBoxEditHinhThucThi.SeparatorChar = ';';
            repositoryItemCheckedComboBoxEditHinhThucThi.TextEditStyle = TextEditStyles.Standard;
            VList<ViewHinhThucThi> _Tlist = DataServices.ViewHinhThucThi.GetAll();
            
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (ViewHinhThucThi v in _Tlist)
            {
                list.Add(new CheckedListBoxItem(v.MaHinhThucThi, v.TenHinhThucThi + " - " + v.ThoiGianThi, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditHinhThucThi.Items.AddRange(list.ToArray());
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGiaChamBai);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDonGiaChamBai.FocusedRowHandle = -1;
            TList<DonGiaChamBai> list = bindingSourceDonGiaChamBai.DataSource as TList<DonGiaChamBai>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceDonGiaChamBai.EndEdit();
                            DataServices.DonGiaChamBai.Save(list);
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

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName != "")
                        {
                            gridControlDonGiaChambai.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            { }
        }

        private void gridViewDonGiaChamBai_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGiaChamBai, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            DonGiaChamBai obj = target as DonGiaChamBai;
            if (obj != null)
            {
                if (((TList<DonGiaChamBai>)bindingSourceDonGiaChamBai.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewDonGiaChamBai_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DonGiaChamBai obj = e.Row as DonGiaChamBai;
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

        private void gridViewDonGiaChamBai_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "MaKyThi" || col.FieldName == "MaHinhThucThi" || col.FieldName == "BacDaoTao" || col.FieldName == "TietQuyChuan")
            {
                gridViewDonGiaChamBai.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewDonGiaChamBai.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

    }
}
