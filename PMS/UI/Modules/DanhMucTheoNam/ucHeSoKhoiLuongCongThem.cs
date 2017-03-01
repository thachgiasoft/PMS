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
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucHeSoKhoiLuongCongThem : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btn_Luu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Luu.ShortCut = Shortcut.None;

                btn_Xoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Xoa.ShortCut = Shortcut.None;
            }
            else
            {
                btn_Luu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btn_Xoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion
        #region Variable
        TList<CauHinhChung> cauHinhchung = DataServices.CauHinhChung.GetAll();
        string _cauHinhHeSoTheoNam;
        #endregion
        public ucHeSoKhoiLuongCongThem()
        {
            InitializeComponent();
            _cauHinhHeSoTheoNam = cauHinhchung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoKhoiLuongCongThem_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewCauHinhChotGio, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCauHinhChotGio, new string[] { "Stt", "TuSoTiet", "DenSoTiet", "HeSo", "NamHoc", "HocKy" },
                new string[] { "STT", "Từ tiết", "Đến tiết", "Hệ số", "Năm học", "Học kỳ" },
                new int[] { 80, 120, 120, 120, 99, 99 });
            AppGridView.ShowEditor(gridViewCauHinhChotGio, NewItemRowPosition.Top);
            AppGridView.HideField(gridViewCauHinhChotGio, new string[] { "NamHoc", "HocKy" });
            AppGridView.AlignHeader(gridViewCauHinhChotGio, new string[] { "Stt", "TuSoTiet", "DenSoTiet", "HeSo", "NamHoc", "HocKy" }, DevExpress.Utils.HorzAlignment.Center);


            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            #region Nam Hoc
            AppGridLookupEdit.InitGridLookUp(cbNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cbNamHoc, 650, 300);
            AppGridLookupEdit.ShowField(cbNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" }, new int[] { 150 });
            cbNamHoc.Properties.DisplayMember = "NamHoc";
            cbNamHoc.Properties.ValueMember = "NamHoc";
            cbNamHoc.Properties.NullText = string.Empty;
            cbNamHoc.EditValue = cauHinhchung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            
            if (cauHinhchung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri == null)
            {
                cbNamHoc.DataBindings.Clear();
                cbNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            #endregion
            
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = cauHinhchung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            
            if (cauHinhchung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri == null)
            {
                cboHocKy.DataBindings.Clear();
                cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            if (cbNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cbNamHoc.EditValue.ToString());
            }

            LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cbNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceCauHinhChotGio.DataSource = DataServices.HeSoKhoiLuongCongThem.GetByNamHocHocKy(cbNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewCauHinhChotGio.FocusedRowHandle = -1;
            TList<HeSoKhoiLuongCongThem> list = bindingSourceCauHinhChotGio.DataSource as TList<HeSoKhoiLuongCongThem>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceCauHinhChotGio.EndEdit();
                            DataServices.HeSoKhoiLuongCongThem.Save(list);
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

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCauHinhChotGio);
        }

        private void btn_Phuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeSoKhoiLuongCongThem obj = bindingSourceCauHinhChotGio.Current as HeSoKhoiLuongCongThem;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceCauHinhChotGio.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewCauHinhChotGio.RefreshData();
            }
        }

        private void btn_Lamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void cbNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cbNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cbNamHoc.EditValue.ToString());
            }

            LoadDataSource();
        }

        private void gridViewCauHinhChotGio_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            if (cbNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                gridViewCauHinhChotGio.SetRowCellValue(gridViewCauHinhChotGio.FocusedRowHandle, "NamHoc", cbNamHoc.EditValue.ToString());
                gridViewCauHinhChotGio.SetRowCellValue(gridViewCauHinhChotGio.FocusedRowHandle, "HocKy", cboHocKy.EditValue.ToString());
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cbNamHoc.EditValue.ToString(), "SaoChepHeSoKhoiLuongCongThem"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cbNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoKhoiLuongCongThem"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }


    }
}
