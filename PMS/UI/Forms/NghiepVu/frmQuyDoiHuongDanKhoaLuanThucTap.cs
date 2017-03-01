using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Services;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmQuyDoiHuongDanKhoaLuanThucTap : DevExpress.XtraEditors.XtraForm
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

        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        int kiemtra = 0;

        #region Event Form
        public frmQuyDoiHuongDanKhoaLuanThucTap()
        {
            InitializeComponent();
            _maTruong = _listCauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            btnChot.Enabled = false;
            btnHuyChot.Enabled = false;
            btnQuyDoi.Enabled = false;
            lblGhiChu.Text = "";
        }

        private void frmQuyDoiHuongDanKhoaLuanThucTap_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewQuyDoi, false, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewQuyDoi, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHinhThucDaoTao", "TenLoaiKhoiLuong", "TenDonViTinh", "MaLop", "HeSoQuyDoi", "SoLuong", "SoTietQuyDoi" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Hình thức đào tạo", "Loại khối lượng", "Đơn vị tính", "Lớp", "Hệ số quy đổi", "Số lượng", "Số tiết quy đổi" }
                    , new int[] { 100, 130, 150, 120, 100, 100, 90, 100, 100, 120 });
            AppGridView.AlignHeader(gridViewQuyDoi, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHinhThucDaoTao", "TenLoaiKhoiLuong", "TenDonViTinh", "MaLop", "HeSoQuyDoi", "SoLuong", "SoTietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewQuyDoi, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            if (_maTruong != "ACT")
                AppGridView.HideField(gridViewQuyDoi, new string[] { "MaLop" });
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Init Khoa-DonVi
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (v.MaBoMon == v.MaKhoa)
                    _list.Add(new CheckedListBoxItem(v.MaBoMon, v.MaBoMon + " - " + v.TenBoMon, CheckState.Unchecked, true));
            }

            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
            #endregion

            InitData();
            gridViewQuyDoi.GroupPanelText = "Gom nhóm bằng cách kéo tên cột thả vào đây";
        }

        #endregion

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.HuongDanKhoaLuanThucTap.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceQuyDoi.DataSource = tb;

                DataServices.HuongDanKhoaLuanThucTap.KiemTraChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kiemtra);
            }
            if (kiemtra == 1)
            {
                btnQuyDoi.Enabled = false;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = true;
                lblGhiChu.Text = string.Format("Dữ liệu của năm học {0} - {1} đã được chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            else
            {
                btnQuyDoi.Enabled = true;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = false;
                lblGhiChu.Text = "";
            }
        }

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                using (frmXuLyQuyDoi frm = new frmXuLyQuyDoi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong))
                {
                    frm.ShowDialog();
                }
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.HuongDanKhoaLuanThucTap.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bindingSourceQuyDoi.DataSource = tb;
            }
            else
                XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlQuyDoi.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.HuongDanKhoaLuanThucTap.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceQuyDoi.DataSource = tb;
                DataServices.HuongDanKhoaLuanThucTap.KiemTraChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kiemtra);
            }
            if (kiemtra == 1)
            {
                btnQuyDoi.Enabled = false;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = true;
                lblGhiChu.Text = string.Format("Dữ liệu của năm học {0} - {1} đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            else
            {
                btnQuyDoi.Enabled = true;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = false;
                lblGhiChu.Text = "";
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.HuongDanKhoaLuanThucTap.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceQuyDoi.DataSource = tb;
                DataServices.HuongDanKhoaLuanThucTap.KiemTraChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kiemtra);
            }
            if (kiemtra == 1)
            {
                btnQuyDoi.Enabled = false;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = true;
                lblGhiChu.Text = string.Format("Dữ liệu của năm học {0} - {1} đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            else
            {
                btnQuyDoi.Enabled = true;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = false;
                lblGhiChu.Text = "";
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.HuongDanKhoaLuanThucTap.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceQuyDoi.DataSource = tb;
                DataServices.HuongDanKhoaLuanThucTap.KiemTraChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kiemtra);
            }
            if (kiemtra == 1)
            {
                btnQuyDoi.Enabled = false;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = true;
                lblGhiChu.Text = string.Format("Dữ liệu của năm học {0} - {1} đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            else
            {
                btnQuyDoi.Enabled = true;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = false;
                lblGhiChu.Text = "";
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void btnChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn chốt khối lượng năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.HuongDanKhoaLuanThucTap.ChotKhoiLuongTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitData();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt khối lượng năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    using (frmXacNhanLaiMatKhau frm = new frmXacNhanLaiMatKhau(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "HuyHuongDanKhoaLuanThucTap"))
                    {
                        frm.KhoaDonVi = cboKhoaDonVi.EditValue.ToString();
                        frm.ShowDialog();
                    }
                    InitData();
                    Cursor.Current = Cursors.Default;
                }
            }
        }
    }
}