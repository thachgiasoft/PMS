using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using PMS.Common;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmTinhXetDuyetLuanVanCaoHoc : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ShortCut = Shortcut.None;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = false;
            }
            else
            {
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = true;
            }
        }
        #endregion

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int kiemtra = 0;
        public frmTinhXetDuyetLuanVanCaoHoc()
        {
            InitializeComponent();
            btnChot.Enabled = false;
            btnHuyChot.Enabled = false;
            btnQuyDoi.Enabled = false;
            lblGhiChu.Text = "";
        }

        private void frmTinhXetDuyetLuanVanCaoHoc_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewXetDuyet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewXetDuyet, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenKhoaHoc", "SoLuong", "DonGia", "ThanhTien", "Thue", "ThucLinh", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Khoá học", "Số lượng", "Đơn giá", "Thành tiền", "Thuế TNCN", "Thực lĩnh", "Ghi chú" }
                    , new int[] { 90, 150, 150, 80, 70, 80, 80, 80, 80, 80, 150 });
            AppGridView.AlignHeader(gridViewXetDuyet, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenKhoaHoc", "SoLuong", "DonGia", "ThanhTien", "Thue", "ThucLinh", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewXetDuyet, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewXetDuyet, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewXetDuyet, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewXetDuyet, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewXetDuyet, "ThucLinh", DevExpress.Utils.FormatType.Custom, "n0");
            #endregion
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceXetDuyet.DataSource = DataServices.ViewXetDuyetDeCuongLuanVanCaoHoc.GetBYNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                DataServices.XetDuyetDeCuongLuanVanCaoHoc.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
            }
            if (kiemtra == 1)
            {
                btnQuyDoi.Enabled = false;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = true;
                lblGhiChu.Text = string.Format("Dữ liệu xét duyệt luận văn cao học năm học {0} - {1} đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            else
            {
                btnQuyDoi.Enabled = true;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = false;
                lblGhiChu.Text = "";
            }
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Quy đổi khối lượng xét duyệt luận văn cao học năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        DataServices.XetDuyetDeCuongLuanVanCaoHoc.QuyDoi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                        Cursor.Current = Cursors.Default;

                        XtraMessageBox.Show("Quy đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    btnLocDuLieu.PerformClick();
                }
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn chốt khối lượng xét duyệt đề cương luận văn cao học năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.XetDuyetDeCuongLuanVanCaoHoc.Chot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLocDuLieu.PerformClick();
                }
            }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt khối lượng hướng dẫn cuối khoá năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (frmXacNhanLaiMatKhau frm = new frmXacNhanLaiMatKhau(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "HuyXetDuyetLuanVanCaoHoc"))
                    {
                        frm.ShowDialog();
                    }
                    btnLocDuLieu.PerformClick();
                }
            }
        }
    }
}