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
using PMS.Entities;
using PMS.Core;
using DevExpress.XtraEditors.Controls;
using PMS.Entities.Validation;
using PMS.Services;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucDanhMucDotChiTra : DevExpress.XtraEditors.XtraUserControl
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
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion
        public ucDanhMucDotChiTra()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucDanhMucDotChiTra_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            AppGridView.InitGridView(gridViewHeSoChucDanhChuyenMon, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHeSoChucDanhChuyenMon, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHeSoChucDanhChuyenMon, new string[] { "ThuTu", "MaDotChiTra", "TenDotChiTra", "GhiChu" },
                        new string[] { "Thứ tự", "Mã đợt chi trả", "Tên đợt chi trả", "Ghi chú" }, new int[] { 70, 100, 200, 200 });
            AppGridView.AlignHeader(gridViewHeSoChucDanhChuyenMon, new string[] { "ThuTu", "MaDotChiTra", "TenDotChiTra", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewHeSoChucDanhChuyenMon, "MaDotChiTra", "{0}", DevExpress.Data.SummaryItemType.Count);
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
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoChucDanhChuyenMon.DataSource = DataServices.DotChiTra.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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
            AppGridView.DeleteSelectedRows(gridViewHeSoChucDanhChuyenMon);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewHeSoChucDanhChuyenMon.FocusedRowHandle = -1;
            TList<DotChiTra> list = bindingSourceHeSoChucDanhChuyenMon.DataSource as TList<DotChiTra>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (DotChiTra h in list)
                            {
                                h.NamHoc = cboNamHoc.EditValue.ToString();
                                h.HocKy = cboHocKy.EditValue.ToString();
                            }

                            bindingSourceHeSoChucDanhChuyenMon.EndEdit();
                            DataServices.DotChiTra.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoChucDanhChuyenMon, barManager1, layoutControl1 });
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
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeSoChucDanhChuyenMon_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoChucDanhChuyenMon, e);
        }

        private void gridViewHeSoChucDanhChuyenMon_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoChucDanhChuyenMon, e);
        }

        private void gridViewHeSoChucDanhChuyenMon_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoChucDanhChuyenMon.DataSource = DataServices.DotChiTra.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoChucDanhChuyenMon.DataSource = DataServices.DotChiTra.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (_cauHinhHeSoTheoNam.ToLower() == "true")
            //{
            //    using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepDotChiTra"))
            //    {
            //        frm.ShowDialog();
            //    }
            //}
            //else
            //{
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepDotChiTra"))
                {
                    frm.ShowDialog();
                }
            //}
            InitData();
        }

        private void gridViewHeSoChucDanhChuyenMon_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DotChiTra objDCT = e.Row as DotChiTra;
            if (objDCT.ThuTu == null)
            {
                e.Valid = false;
                XtraMessageBox.Show("Vui lòng nhập đúng thứ tự của các đợt thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else e.Valid = true;
        }

    }
}
