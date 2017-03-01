using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraEditors;
using PMS.Core;
using PMS.Entities.Validation;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc.SauDaiHoc
{
    public partial class ucHeSoLopDong_SDH : DevExpress.XtraEditors.XtraUserControl
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
        public ucHeSoLopDong_SDH()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucHeSoLopDong_SDH_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewHeSoLopDong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoLopDong, new string[] { "Stt", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "STT", "Nhóm môn học", "Từ khoản", "Đến khoản", "Hệ số", "Ngày cập nhật", "Người cập nhật" },
                        new int[] { 50, 200, 90, 90, 80, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoLopDong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoLopDong, new string[] { "Stt", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.HideField(gridViewHeSoLopDong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion
           
            #region NhomMonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomMonHoc, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" }, new string[] { "Mã nhóm môn học", "Tên nhóm môn học" });
            repositoryItemGridLookUpEditNhomMonHoc.DisplayMember = "TenNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.ValueMember = "MaNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.NullText = string.Empty;
            #endregion
            InitData();
        }

        #region InitData
        private void InitData()
        {
            bindingSourceNhomMonHoc.DataSource = DataServices.SdhNhomMonHoc.GetAll();
            bindingSourceHeSoLopDong.DataSource = DataServices.SdhHeSoLopDong.GetAll();
        }
        #endregion

        private void btnLamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoLopDong.FocusedRowHandle = -1;
            TList<SdhHeSoLopDong> list = bindingSourceHeSoLopDong.DataSource as TList<SdhHeSoLopDong>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoLopDong.EndEdit();
                            DataServices.SdhHeSoLopDong.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoLopDong, barManager1, layoutControl1 });
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

        private void gridViewHeSoLopDong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoLopDong, e);
        }

        private void gridViewHeSoLopDong_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoLopDong, e);
        }

        private void gridViewHeSoLopDong_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //HeSoLopDong obj = e.Row as HeSoLopDong;
            //if (obj != null)
            //{
            //    obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy");
            //    if (obj.IsValid)
            //        e.Valid = true;
            //    else
            //    {
            //        XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        e.Valid = false;
            //    }
            //}
        }

        //private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        //{
        //    HeSoLopDong obj = target as HeSoLopDong;
        //    if (obj != null)
        //    {
        //        if (((TList<HeSoLopDong>)bindingSourceHeSoLopDong.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
        //        {
        //            e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaQuanLy);
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        private void gridViewHeSoLopDong_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlHeSoLopDong.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeSoLopDong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "Stt" || col.FieldName == "MaNhomMonHoc" || col.FieldName == "TuKhoan" || col.FieldName == "DenKhoan" || col.FieldName == "HeSo")
            {
                gridViewHeSoLopDong.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewHeSoLopDong.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoLopDong);
        }
    }
}
