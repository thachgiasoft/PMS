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
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;
using PMS.Entities.Validation;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucDonGiaCoiThi_ACT : DevExpress.XtraEditors.XtraUserControl
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
        #region Event Form
        public ucDonGiaCoiThi_ACT()
        {
            InitializeComponent();
        }

        private void ucDonGiaCoiThi_ACT_Load(object sender, EventArgs e)
        {
            #region Init GridView QuyDoiGioChuan
            //cột đơn giá là cột hệ số
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewDonGia, new string[] { "MaQuanLy", "MaKyThi", "CaThi", "DonGia", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "Mã quản lý", "Kỳ thi", "Ca thi (Phút)", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 90, 150, 200, 150, 150, 100, 150, 99, 99 });
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewDonGia, "MaKyThi", repositoryItemCheckedComboBoxEditKyThi);
            AppGridView.RegisterControlField(gridViewDonGia, "CaThi", repositoryItemCheckedComboBoxEditCaThi);
            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion

          

            InitCaThi();

            InitData();
        }
        #endregion
        #region InitData
        void InitData()
        {
            InitKyThi();
            bindingSourceDonGia.DataSource = DataServices.DonGiaCoiThi.GetAll();
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

        void InitCaThi()
        {
            #region Ky thi
            repositoryItemCheckedComboBoxEditCaThi.SelectAllItemCaption = "";
            repositoryItemCheckedComboBoxEditCaThi.Items.Clear();
            repositoryItemCheckedComboBoxEditCaThi.SeparatorChar = ';';
            repositoryItemCheckedComboBoxEditCaThi.TextEditStyle = TextEditStyles.Standard;

            DataTable tblCaThi = new DataTable();
            IDataReader readerCaThi = DataServices.ViewHinhThucThi.GetThoiGianThi();
            tblCaThi.Load(readerCaThi);

            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();

            foreach (DataRow r in tblCaThi.Rows)
            {
                list.Add(new CheckedListBoxItem(r["ThoiGianThi"].ToString(), r["ThoiGianThi"].ToString(), CheckState.Unchecked, true));
            }

            repositoryItemCheckedComboBoxEditCaThi.Items.AddRange(list.ToArray());
            #endregion
        }

        #endregion
        #region Event Button
        private void btnlamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGia);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDonGia.FocusedRowHandle = -1;
            TList<DonGiaCoiThi> list = bindingSourceDonGia.DataSource as TList<DonGiaCoiThi>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceDonGia.EndEdit();
                            DataServices.DonGiaCoiThi.Save(list);
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName != "")
                        {
                            gridControlDonGia.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            { }
        }

        private void gridViewDonGia_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGia, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            DonGiaCoiThi obj = target as DonGiaCoiThi;
            if (obj != null)
            {
                if (((TList<DonGiaCoiThi>)bindingSourceDonGia.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewDonGia_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DonGiaCoiThi obj = e.Row as DonGiaCoiThi;
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
        #endregion

        #region Event Grid
        private void gridViewDonGia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "MaKyThi" || col.FieldName == "CaThi" || col.FieldName == "DonGia")
            {
                gridViewDonGia.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewDonGia.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
        #endregion
    }
}
