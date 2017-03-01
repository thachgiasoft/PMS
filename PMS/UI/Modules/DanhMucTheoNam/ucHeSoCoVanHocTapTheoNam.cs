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
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoCoVanHocTapTheoNam : DevExpress.XtraEditors.XtraUserControl
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

                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion
        public ucHeSoCoVanHocTapTheoNam()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoCoVanHocTapTheoNam_Load(object sender, EventArgs e)
        {
            #region InitGridview
            AppGridView.InitGridView(gridViewHeSoBacDaoTao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoBacDaoTao, new string[] { "TuKhoan", "DenKhoan", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Từ khoản", "Đến khoản", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                        new int[] { 100, 100, 100, 250, 150, 150 });
            AppGridView.AlignHeader(gridViewHeSoBacDaoTao, new string[] { "TuKhoan", "DenKhoan", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewHeSoBacDaoTao, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.SummaryField(gridViewHeSoBacDaoTao, "HeSo", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewHeSoBacDaoTao, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion


            InitData();
        }

        #region InitData
        private void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceHeSoBacDaoTao.DataSource = DataServices.HeSoCoVanHocTap.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
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
            TList<HeSoCoVanHocTap> list = bindingSourceHeSoBacDaoTao.DataSource as TList<HeSoCoVanHocTap>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoCoVanHocTap h in list)
                            {
                                h.NamHoc = cboNamHoc.EditValue.ToString();
                                h.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceHeSoBacDaoTao.EndEdit();
                            DataServices.HeSoCoVanHocTap.Save(list);
                            
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


        private void gridViewHeSoBacDaoTao_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewHeSoBacDaoTao_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;

                if (col.FieldName == "TuKhoan" || col.FieldName == "DenKhoan" || col.FieldName == "HeSo" || col.FieldName == "GhiChu")
                {
                    gridViewHeSoBacDaoTao.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    gridViewHeSoBacDaoTao.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                }
            }
            catch 
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceHeSoBacDaoTao.DataSource = DataServices.HeSoCoVanHocTap.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceHeSoBacDaoTao.DataSource = DataServices.HeSoCoVanHocTap.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoCoVanHocTap"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoCoVanHocTap"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
    }
}
