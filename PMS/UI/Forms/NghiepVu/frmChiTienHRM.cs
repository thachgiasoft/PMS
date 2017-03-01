using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChiTienHRM : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnChiTra.Enabled = false;
            }
            else
            {
                btnChiTra.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int _kiemTra = 0;
        string _maTruong;
        #endregion

        #region Event Form
        public frmChiTienHRM()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmChiTienHRM_Load(object sender, EventArgs e)
        {
            #region InitGrid
            switch (_maTruong)
            { 
                case "UEL":
                    InitGridUEL();
                    break;
                case "UTE":
                    InitGridUTE();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

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
        #endregion
        #region InitGrid
        void InitGridUEL()
        {
            AppGridView.InitGridView(gridViewChiTienHRM, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewChiTienHRM, new string[] { "MaCanBoGiangDay", "HoTen", "TenDonVi", "LaGiangVienThinhGiang", "TongTien" }
                                                    , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Giảng viên thỉnh giảng", "Tổng tiền" }
                                                    , new int[] { 90, 180, 250, 130, 140 });
            AppGridView.AlignHeader(gridViewChiTienHRM, new string[] { "MaCanBoGiangDay", "HoTen", "TenDonVi", "LaGiangVienThinhGiang", "TongTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewChiTienHRM);
            AppGridView.FormatDataField(gridViewChiTienHRM, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.SummaryField(gridViewChiTienHRM, "MaCanBoGiangDay", "{0}", DevExpress.Data.SummaryItemType.Count);
        }

        void InitGridUTE()
        {
            btnChiTra.Text = "Chuyển giờ thỉnh giảng sang HRM";
            AppGridView.InitGridView(gridViewChiTienHRM, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewChiTienHRM, new string[] { "MaCanBoGiangDay", "HoTen", "TenDonVi", "LaGiangVienThinhGiang", "MaMonHoc", "TenMonHoc", "LopClc", "TongSoTietQuyDoi" }
                                                    , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Giảng viên thỉnh giảng", "Mã môn học", "Tên môn học", "Lớp CLC", "Tổng số tiết" }
                                                    , new int[] { 90, 180, 250, 130, 100, 200, 70, 80 });
            AppGridView.AlignHeader(gridViewChiTienHRM, new string[] { "MaCanBoGiangDay", "HoTen", "TenDonVi", "LaGiangVienThinhGiang", "MaMonHoc", "TenMonHoc", "LopClc", "TongSoTietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewChiTienHRM);
            AppGridView.SummaryField(gridViewChiTienHRM, "MaCanBoGiangDay", "{0}", DevExpress.Data.SummaryItemType.Count);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewChiTienHRM, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewChiTienHRM, new string[] { "MaCanBoGiangDay", "HoTen", "TenDonVi", "LaGiangVienThinhGiang", "TongTien" }
                                                    , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Giảng viên thỉnh giảng", "Tổng tiền" }
                                                    , new int[] { 90, 180, 250, 130, 140 });
            AppGridView.AlignHeader(gridViewChiTienHRM, new string[] { "MaCanBoGiangDay", "HoTen", "TenDonVi", "LaGiangVienThinhGiang", "TongTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewChiTienHRM);
            AppGridView.FormatDataField(gridViewChiTienHRM, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.SummaryField(gridViewChiTienHRM, "MaCanBoGiangDay", "{0}", DevExpress.Data.SummaryItemType.Count);
        }
        #endregion
        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ChiTienThuLaoGiangDay.LayThongTinChiTien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bindingSourceChiTien.DataSource = tb;
                KiemTraChiTien();
            }
        }

        void KiemTraChiTien()
        {
            DataServices.ChiTienThuLaoGiangDay.KiemTraChiTien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref _kiemTra);
            if (_kiemTra == 0)
            {
                btnChiTra.Enabled = true;
                labelControl1.Text = "";
            }
            if (_kiemTra == 1)
            {
                btnChiTra.Enabled = false;
                labelControl1.Text = string.Format("HRM đã lấy dữ liệu chi tiền {0} - {1}. Không được phép chi lại.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            if (_kiemTra == 2)
            {
                btnChiTra.Enabled = true;
                labelControl1.Text = string.Format("Dữ liệu năm học {0} - {1} đã thực hiện chi tiền.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnChiTra_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                string s = "";
                if (_kiemTra == 0)
                    s = string.Format("Bạn muốn thực hiện chi tiền thù lao giảng dạy năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                if (_kiemTra == 1)
                {
                    s = string.Format("HRM đã lấy dữ liệu chi tiền {0} - {1}. Không được phép chi lại.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    return;
                }
                if (_kiemTra == 2)

                    s = string.Format("Thù lao giảng dạy năm học {0} - {1} đã được chi. Bạn có muốn chi lại?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                if (XtraMessageBox.Show(s, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int kq = 0;
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.ChiTienThuLaoGiangDay.ChiTienHrm(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                    Cursor.Current = Cursors.Default;
                    if (kq == 0)
                        XtraMessageBox.Show("Chi tiền thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chi tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                InitData();
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
                            gridControlChiTienHRM.ExportToXls(sf.FileName);
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
                IDataReader reader = DataServices.ChiTienThuLaoGiangDay.LayThongTinChiTien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bindingSourceChiTien.DataSource = tb;
                KiemTraChiTien();
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ChiTienThuLaoGiangDay.LayThongTinChiTien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bindingSourceChiTien.DataSource = tb;
                KiemTraChiTien();
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion
    
    }
}