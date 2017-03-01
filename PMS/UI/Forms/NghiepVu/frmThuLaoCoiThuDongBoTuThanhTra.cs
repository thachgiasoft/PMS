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

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThuLaoCoiThuDongBoTuThanhTra : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongBo.ShortCut = Shortcut.None;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = false;
            }
            else
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int _kiemTra = 0;
        #endregion

        public frmThuLaoCoiThuDongBoTuThanhTra()
        {
            InitializeComponent();
        }

        private void frmThuLaoCoiThuDongBoTuThanhTra_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewCoiThi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewCoiThi, new string[] { "MaGiangVienQuanLy", "HoTen", "TenDonVi", "SoTien" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Khoa - đơn vị", "Số tiết coi thi" }
                    , new int[] { 100, 180, 280, 120 });
            AppGridView.AlignHeader(gridViewCoiThi, new string[] { "MaGiangVienQuanLy", "HoTen", "TenDonVi", "SoTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewCoiThi);

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.ValueMember = "MaHocKy";
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

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThuLaoCoiThi.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "-1");
                tb.Load(reader);
                bindingSourceCoiThi.DataSource = tb;

                KiemTraChot();
            }
        }

        void KiemTraChot()
        {
            DataServices.ThuLaoCoiThi.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "", ref _kiemTra);

            if (_kiemTra == 1)
            {
                btnDongBo.Enabled = false;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = true;
            }
            else
            {
                btnDongBo.Enabled = true;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = false;
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnDongBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show("Bạn muốn đồng bộ dữ liệu coi thi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int kq = -1;
                        DataServices.ThuLaoCoiThi.DongBoTuThanhTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);

                        if (kq == 0)
                            XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                        {
                            DataTable tb = new DataTable();
                            IDataReader reader = DataServices.ThuLaoCoiThi.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "-1");
                            tb.Load(reader);
                            bindingSourceCoiThi.DataSource = tb;

                            KiemTraChot();
                        }
                    }
                    catch
                    { }
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
                        if (sf.FileName != "")
                        {
                            gridControlCoiThi.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            if (bindingSourceCoiThi.DataSource != null)
            {
                if (XtraMessageBox.Show("Bạn muốn chốt dữ liệu coi thi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DataServices.ThuLaoCoiThi.Chot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "");
                        XtraMessageBox.Show("Chốt dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Cursor.Current = Cursors.WaitCursor;
                        InitData();
                        Cursor.Current = Cursors.Default;
                    }
                    catch 
                    {
                    }
                }
            }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (bindingSourceCoiThi.DataSource != null)
            {
                if (XtraMessageBox.Show("Bạn muốn huỷ chốt dữ liệu coi thi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DataServices.ThuLaoCoiThi.HuyChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "");
                        XtraMessageBox.Show("Huỷ chốt dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Cursor.Current = Cursors.WaitCursor;
                        InitData();
                        Cursor.Current = Cursors.Default;
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }
    }
}