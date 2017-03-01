using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using DevExpress.Common.Grid;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThuLaoRaDe_VHU : DevExpress.XtraEditors.XtraForm
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
        string _maTruong;
        int kiemtra = 0;
        #endregion

        public frmThuLaoRaDe_VHU()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmThuLaoRaDe_VHU_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThuLaoRaDe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThuLaoRaDe, new string[] { "MaGiangVienQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi", "MaDotThi", "TenDotThi", "ThoiGianLamBai", "MaLopHocPhan", "MaHinhThucThi", "SoLuongDe",  "TenDangDeThi", "KyThi", "SoTietQuyDoi", "TongTien" }
                , new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên", "Khoa - đơn vị","Mã đợt thi", "Tên đợt thi", "Thời gian làm bài", "Mã lớp học phần", "Mã hình thức thi", "Số lượng đề",  "Dạng đề thi", "Kỳ thi", "Số tiết quy đổi", "Tổng tiền" }
                    , new int[] { 80, 130, 90, 90, 90,100,  60, 80, 80, 80, 70, 60, 80, 80,70, 90 });
            //AppGridView.HideField(gridViewThuLaoRaDe, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.AlignHeader(gridViewThuLaoRaDe, new string[] { "MaGiangVienQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi",  "MaDotThi", "TenDotThi", "ThoiGianLamBai", "MaLopHocPhan", "MaHinhThucThi", "SoLuongDe",  "TenDangDeThi", "KyThi", "SoTietQuyDoi", "TongTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThuLaoRaDe, "MaGiangVienQuanLy", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewThuLaoRaDe);
            AppGridView.FormatDataField(gridViewThuLaoRaDe, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
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
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ThuLaoRaDeVhu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceThuLaoRaDe.DataSource = tbl;

                DataServices.ThuLaoRaDeVhu.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
                if (kiemtra == 1)
                {

                    btnChot.Enabled = false;
                    btnHuyChot.Enabled = true;
                    btnDongBo.Enabled = false;

                    lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

                }
                else
                {
                    btnChot.Enabled = true;
                    btnHuyChot.Enabled = false;
                    btnDongBo.Enabled = true;

                    lblGhiChu.Text = "";
                }
                gridViewThuLaoRaDe.BestFitColumns();
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn chốt dữ liệu coi thi năm học {0} - {1} ?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.ThuLaoRaDeVhu.Chot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamTuoi.PerformClick();
                }
            }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt dữ liệu coi thi năm học {0} - {1} ?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (frmXacNhanLaiMatKhau frm = new frmXacNhanLaiMatKhau(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "HuyThuLaoRaDe_VHU"))
                    {
                        frm.ShowDialog();
                    }
                    btnLamTuoi.PerformClick();
                }
            }
        }

        private void btnDongBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                //kiem tra chot
                if (XtraMessageBox.Show(string.Format("Bạn muốn đồng bộ khối lượng coi thi năm học {0} - {1} ?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int kq = 0;
                        Cursor.Current = Cursors.WaitCursor;
                        DataServices.ThuLaoRaDeVhu.DongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        Cursor.Current = Cursors.Default;
                        if (kq == 0)
                            XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn năm học - học kỳ - đợt chi trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
            }
            btnLamTuoi.PerformClick();
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
                            gridControlThuLaoRaDe.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ThuLaoRaDeVhu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceThuLaoRaDe.DataSource = tbl;

                DataServices.ThuLaoRaDeVhu.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
                if (kiemtra == 1)
                {

                    btnChot.Enabled = false;
                    btnHuyChot.Enabled = true;
                    btnDongBo.Enabled = false;

                    lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

                }
                else
                {
                    btnChot.Enabled = true;
                    btnHuyChot.Enabled = false;
                    btnDongBo.Enabled = true;

                    lblGhiChu.Text = "";
                }
                gridViewThuLaoRaDe.BestFitColumns();
            }
            Cursor.Current = Cursors.Default;

        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ThuLaoRaDeVhu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceThuLaoRaDe.DataSource = tbl;

                DataServices.ThuLaoRaDeVhu.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
                if (kiemtra == 1)
                {

                    btnChot.Enabled = false;
                    btnHuyChot.Enabled = true;
                    btnDongBo.Enabled = false;

                    lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

                }
                else
                {
                    btnChot.Enabled = true;
                    btnHuyChot.Enabled = false;
                    btnDongBo.Enabled = true;

                    lblGhiChu.Text = "";
                }
                gridViewThuLaoRaDe.BestFitColumns();
            }
            Cursor.Current = Cursors.Default;
        }
    }
}