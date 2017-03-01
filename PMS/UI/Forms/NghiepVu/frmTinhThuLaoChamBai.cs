using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmTinhThuLaoChamBai : DevExpress.XtraEditors.XtraForm
    {

        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongBo.ShortCut = Shortcut.None;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ShortCut = Shortcut.None;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = false;
            }
            else
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = true;
            }
        }
        #endregion

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int kiemtra = 0;
        public frmTinhThuLaoChamBai()
        {
            InitializeComponent();

            btnChot.Enabled = false;
            btnHuyChot.Enabled = false;
            btnDongBo.Enabled = false;
            btnQuyDoi.Enabled = false;
            lblGhiChu.Text = "";
        }

        private void frmTinhThuLaoChamBai_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThuLaoChamBai, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThuLaoChamBai, new string[] { "MaGiangVienQuanLy", "HoTen", "TenDonVi", "MaLop", "LanThi", "TenMonHoc", "SoBaiGiuaKy", "SoBaiQuaTrinh", "SoBaiCuoiKy", "DonGiaCuoiKy", "TienGiuaKy", "TienQuaTrinh", "TienCuoiKy", "TongCong", "TongTienGv" }
                , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Lớp", "Lần thi", "Môn học", "Số bài giữa kỳ", "Số bài quá trình", "Số bài cuối kỳ", "Đơn giá cuối kỳ", "Tiền giữa kỳ", "Tiền quá trình", "Tiền cuối kỳ", "Cộng", "Tổng cộng" }
                    , new int[] { 90, 150, 150, 80, 60, 150, 100, 100, 100, 100, 100, 100, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewThuLaoChamBai, new string[] { "MaGiangVienQuanLy", "HoTen", "TenDonVi", "MaLop", "LanThi", "TenMonHoc", "SoBaiGiuaKy", "SoBaiQuaTrinh", "SoBaiCuoiKy", "DonGiaCuoiKy", "TienGiuaKy", "TienQuaTrinh", "TienCuoiKy", "TongCong", "TongTienGv" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThuLaoChamBai, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "DonGiaCuoiKy", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "TienGiuaKy", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "TienQuaTrinh", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "TienCuoiKy", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "TongCong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "TongTienGv", DevExpress.Utils.FormatType.Custom, "n0");
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
            
            #region Dot thanh toan
            AppGridLookupEdit.InitGridLookUp(cboDotThanhToan, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotThanhToan, new string[] { "MaDot", "TenDot" }, new string[] { "Mã đợt thanh toán", "Tên đợt thanh toán" });
            cboDotThanhToan.Properties.ValueMember = "MaDot";
            cboDotThanhToan.Properties.DisplayMember = "TenDot";
            cboDotThanhToan.Properties.NullText = string.Empty;
            #endregion
            InitData();
        }

        void InitData()
        {
            try
            {
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    cboDotThanhToan.DataBindings.Clear();
                    DataTable tbl = new DataTable();
                    IDataReader r = DataServices.ThuLaoChamBai.GetDotThanhToanByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    tbl.Load(r);
                    bindingSourceDotThanhToan.DataSource = tbl;
                    cboDotThanhToan.DataBindings.Add("EditValue", bindingSourceDotThanhToan, "MaDot", true, DataSourceUpdateMode.OnPropertyChanged);
                }
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDotThanhToan.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.ThuLaoChamBai.GetByNamHocHocKyDotThanhToanDongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString());
                    tb.Load(reader);
                    bindingSourceThulaoChamBai.DataSource = tb;

                    DataServices.ThuLaoChamBai.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString(), ref kiemtra);
                    if (kiemtra == 1)
                    {

                        btnChot.Enabled = false;
                        btnHuyChot.Enabled = true;
                        btnDongBo.Enabled = false;
                        btnQuyDoi.Enabled = false;
                        lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} - đợt {2} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString());

                    }
                    else
                    {
                        btnChot.Enabled = true;
                        btnHuyChot.Enabled = false;
                        btnDongBo.Enabled = true;
                        btnQuyDoi.Enabled = true;
                        lblGhiChu.Text = "";
                    }
                }
            }
            catch 
            {}
           
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnDongBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDotThanhToan.EditValue != null)
            {
                //kiem tra chot
                if (XtraMessageBox.Show(string.Format("Bạn muốn đồng bộ khối lượng chấm bài năm học {0} - {1} - đợt {2}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.ThuLaoChamBai.DongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString(), ref kq);
                    Cursor.Current = Cursors.Default;
                    if(kq==0)
                        XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
            }
            btnLamTuoi.PerformClick();
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                //kiem tra chot
                if (XtraMessageBox.Show(string.Format("Bạn muốn quy đổi khối lượng chấm bài năm học {0} - {1} - đợt {2}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.ThuLaoChamBai.QuyDoi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString(), ref kq);
                    Cursor.Current = Cursors.Default;
                    if (kq == 0)
                        XtraMessageBox.Show("Quy đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn năm học - học kỳ - đợt chi trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
            }

            btnLamTuoi.PerformClick();
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn chốt dữ liệu chấm bài năm học {0} - {1} - đợt {2}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.ThuLaoChamBai.Chot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString());
                    XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamTuoi.PerformClick();
                }
            }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt dữ liệu chấm bài năm học {0} - {1} - đợt {2}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (frmXacNhanLaiMatKhau frm = new frmXacNhanLaiMatKhau(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString(), "HuyThuLaoChamBai"))
                    {
                        frm.ShowDialog();
                    }
                    btnLamTuoi.PerformClick();
                }
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {

                    cboDotThanhToan.DataBindings.Clear();
                    DataTable tbl = new DataTable();
                    IDataReader r = DataServices.ThuLaoChamBai.GetDotThanhToanByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    tbl.Load(r);
                    bindingSourceDotThanhToan.DataSource = tbl;
                    cboDotThanhToan.DataBindings.Add("EditValue", bindingSourceDotThanhToan, "MaDot", true, DataSourceUpdateMode.OnPropertyChanged);
                }
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDotThanhToan.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.ThuLaoChamBai.GetByNamHocHocKyDotThanhToanDongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString());
                    tb.Load(reader);
                    bindingSourceThulaoChamBai.DataSource = tb;

                    DataServices.ThuLaoChamBai.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString(), ref kiemtra);
                    if (kiemtra == 1)
                    {

                        btnChot.Enabled = false;
                        btnHuyChot.Enabled = true;
                        btnDongBo.Enabled = false;
                        btnQuyDoi.Enabled = false;
                        lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} - đợt {2} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString());

                    }
                    else
                    {
                        btnChot.Enabled = true;
                        btnHuyChot.Enabled = false;
                        btnDongBo.Enabled = true;
                        btnQuyDoi.Enabled = true;
                        lblGhiChu.Text = "";
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            { }
           
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    cboDotThanhToan.DataBindings.Clear();
                    DataTable tbl = new DataTable();
                    IDataReader r = DataServices.ThuLaoChamBai.GetDotThanhToanByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    tbl.Load(r);
                    bindingSourceDotThanhToan.DataSource = tbl;
                    cboDotThanhToan.DataBindings.Add("EditValue", bindingSourceDotThanhToan, "MaDot", true, DataSourceUpdateMode.OnPropertyChanged);
                }
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDotThanhToan.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.ThuLaoChamBai.GetByNamHocHocKyDotThanhToanDongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString());
                    tb.Load(reader);
                    bindingSourceThulaoChamBai.DataSource = tb;

                    DataServices.ThuLaoChamBai.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString(), ref kiemtra);
                    if (kiemtra == 1)
                    {

                        btnChot.Enabled = false;
                        btnHuyChot.Enabled = true;
                        btnDongBo.Enabled = false;
                        btnQuyDoi.Enabled = false;
                        lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} - đợt {2} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString());

                    }
                    else
                    {
                        btnChot.Enabled = true;
                        btnHuyChot.Enabled = false;
                        btnDongBo.Enabled = true;
                        btnQuyDoi.Enabled = true;
                        lblGhiChu.Text = "";
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            { }
            
        }

        private void cboDotThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDotThanhToan.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.ThuLaoChamBai.GetByNamHocHocKyDotThanhToanDongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString());
                    tb.Load(reader);
                    bindingSourceThulaoChamBai.DataSource = tb;

                    DataServices.ThuLaoChamBai.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString(), ref kiemtra);
                    if (kiemtra == 1)
                    {

                        btnChot.Enabled = false;
                        btnHuyChot.Enabled = true;
                        btnDongBo.Enabled = false;
                        btnQuyDoi.Enabled = false;
                        lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} - đợt {2} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString());

                    }
                    else
                    {
                        btnChot.Enabled = true;
                        btnHuyChot.Enabled = false;
                        btnDongBo.Enabled = true;
                        btnQuyDoi.Enabled = true;
                        lblGhiChu.Text = "";
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch 
            {  }
            
        }

    }
}