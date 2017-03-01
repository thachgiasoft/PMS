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
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.Core;
using PMS.Entities.Validation;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDanhMucLopChatLuongCao : DevExpress.XtraEditors.XtraUserControl
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
        #endregion

        public ucDanhMucLopChatLuongCao()
        {
            InitializeComponent();
        }

        private void ucDanhMucLopChatLuongCao_Load(object sender, EventArgs e)
        {
            #region Init gridview
            AppGridView.InitGridView(gridViewDMChatLuongCao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewDMChatLuongCao, new string[] { "MaLop", "TenLop", "TenKhoaHoc", "TenKhoa", "NamHoc", "Chon" },
                        new string[] { "Mã lớp", "Tên lớp", "Tên khóa học", "Tên khoa", "Năm học", "Chọn" },
                        new int[] { 100, 140, 120, 250, 100, 100 });
            AppGridView.AlignHeader(gridViewDMChatLuongCao, new string[] { "MaLop", "TenLop", "TenKhoaHoc", "TenKhoa", "NamHoc", "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewDMChatLuongCao, new string[] { "MaLop", "TenLop", "TenKhoaHoc", "TenKhoa", "NamHoc" });
            AppGridView.SummaryField(gridViewDMChatLuongCao, "MaLop", "Tổng: {0} Lớp", DevExpress.Data.SummaryItemType.Count);
            gridViewDMChatLuongCao.Columns["TenKhoa"].GroupIndex = 0;
            #endregion

            #region AppGridLookupEdit _namHoc
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(gridLookUpEditNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            gridLookUpEditNamHoc.Properties.ValueMember = "NamHoc";
            gridLookUpEditNamHoc.Properties.DisplayMember = "NamHoc";
            gridLookUpEditNamHoc.Properties.NullText = "[Chọn năm học]";
            #endregion

            gridLookUpEditNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;

            SetNamHoc();
            bindingSourceDMLopChatLuongCao.DataSource = DataServices.ViewLopChatLuongCao.GetByNamHoc(gridLookUpEditNamHoc.EditValue.ToString());
            gridViewDMChatLuongCao.ExpandAllGroups();
        }

        #region SetNamHoc, SetHocKy
        private void SetNamHoc()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
        }
        #endregion

        private void bntLocDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceDMLopChatLuongCao.DataSource = DataServices.ViewLopChatLuongCao.GetByNamHoc(gridLookUpEditNamHoc.EditValue.ToString());
            gridViewDMChatLuongCao.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewDMChatLuongCao.RowCount > 0)
                if (gridViewDMChatLuongCao.GetSelectedRows().Length > 0)
                    if (XtraMessageBox.Show(String.Format("Bạn có muốn xóa {0} dòng đã chọn không ?", gridViewDMChatLuongCao.GetSelectedRows().Length), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        foreach (int rowIndex in gridViewDMChatLuongCao.GetSelectedRows())
                            ((ViewLopChatLuongCao)gridViewDMChatLuongCao.GetRow(rowIndex)).Chon = null;
        }

        private void gridLookUpEditNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceDMLopChatLuongCao.DataSource = DataServices.ViewLopChatLuongCao.GetByNamHoc(gridLookUpEditNamHoc.EditValue.ToString());
            gridViewDMChatLuongCao.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void gridControlDMChatLuongCao_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void gridViewDMChatLuongCao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                if (gridViewDMChatLuongCao.RowCount > 0)
                    if (gridViewDMChatLuongCao.GetSelectedRows().Length > 0)
                        if (XtraMessageBox.Show(String.Format("Bạn có muốn xóa {0} dòng đã chọn không ?", gridViewDMChatLuongCao.GetSelectedRows().Length), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            foreach (int rowIndex in gridViewDMChatLuongCao.GetSelectedRows())
                                ((ViewLopChatLuongCao)gridViewDMChatLuongCao.GetRow(rowIndex)).Chon = null;
        }

        private void gridViewDMChatLuongCao_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDMChatLuongCao.FocusedRowHandle = -1;
            string xmlData = "<Root>";
            int kq = 0;
            VList<ViewLopChatLuongCao> list = bindingSourceDMLopChatLuongCao.DataSource as VList<ViewLopChatLuongCao>;
            foreach (ViewLopChatLuongCao v in list)
            {
                if (v.Chon != null && v.Chon != false)
                {
                    xmlData += "<Input L = \"" + v.MaLop
                                + "\" D = \"" + DateTime.Now.ToString()
                                +"\" U = \"" + UserInfo.UserName
                                + "\" />";
                }
            }
            xmlData += "</Root>";

            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataServices.LopChatLuongCao.Luu(xmlData,gridLookUpEditNamHoc.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Thao tác thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
