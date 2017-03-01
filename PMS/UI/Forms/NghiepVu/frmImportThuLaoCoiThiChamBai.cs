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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmImportThuLaoCoiThiChamBai : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnImport.ShortCut = Shortcut.None;

                btnXoaDotChiTra.Enabled = false;
            }
            else
            {
                btnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoaDotChiTra.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion

        public frmImportThuLaoCoiThiChamBai()
        {
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            InitializeComponent();
        }

        private void frmImportThuLaoCoiThiChamBai_Load(object sender, EventArgs e)
        {
            #region Init gridview
            switch (_maTruong)
            {
                case "DLU":
                    AppGridView.InitGridView(gridViewThuLao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
                    AppGridView.ShowField(gridViewThuLao, new string[] { "MaGiangVienQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "LoaiHinhDaoTao", "BacDaoTao", "GioCoiThi", "GioChamThi", "GioRaDe", "GioToChucThi", "GioNhapDiem", "TongCong" }
                            , new string[] { "Mã giảng viên", "Họ tên", "Mã môn học", "Tên môn học", "Loại hình đào tạo", "Bậc đào tạo", "Coi thi", "Chấm thi", "Ra đề", "Tổ chức thi", "Nhập điểm", "Tổng giờ" }
                            , new int[] { 100, 200, 80, 250, 100, 80, 70, 70, 70, 70, 70, 100 });
                    AppGridView.AlignHeader(gridViewThuLao, new string[] { "MaGiangVienQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "LoaiHinhDaoTao", "BacDaoTao", "GioCoiThi", "GioChamThi", "GioRaDe", "GioToChucThi", "GioNhapDiem", "TongCong" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.SummaryField(gridViewThuLao, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.FormatDataField(gridViewThuLao, new string[] { "GioCoiThi", "GioChamThi", "GioRaDe", "GioToChucThi", "GioNhapDiem", "TongCong" }, DevExpress.Utils.FormatType.Custom, "{0:n2}");
                    AppGridView.FixedField(gridViewThuLao, new string[] { "MaGiangVienQuanLy", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
                    break;
                default:
                    AppGridView.InitGridView(gridViewThuLao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
                    AppGridView.ShowField(gridViewThuLao, new string[] { "MaGiangVienQuanLy", "HoTen", "NoiDungChi", "TenMonHoc", "MaLop", "SoBaiQuaTrinh", "SoBaiGiuaKy", "SoBaiCuoiKy", "DonGiaQuaTrinh", "DonGiaGiuaKy", "DonGiaCuoiKy", "ThanhTien", "SoTienCoiThi" }
                            , new string[] { "Mã giảng viên", "Họ tên", "Khoản chi", "Môn học", "Lớp", "Số bài quá trình", "Số bài giữa kỳ", "Số bài cuối kỳ", "Đơn giá quá trình", "Đơn giá giữa kỳ", "Đơn giá cuối kỳ", "Thành tiền", "Số tiền coi thi" }
                            , new int[] { 90, 150, 180, 180, 90, 70, 70, 70, 90, 90, 90, 100, 100 });
                    AppGridView.AlignHeader(gridViewThuLao, new string[] { "MaGiangVienQuanLy", "HoTen", "NoiDungChi", "TenMonHoc", "MaLop", "SoBaiQuaTrinh", "SoBaiGiuaKy", "SoBaiCuoiKy", "DonGiaQuaTrinh", "DonGiaGiuaKy", "DonGiaCuoiKy", "ThanhTien", "SoTienCoiThi" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.ReadOnlyColumn(gridViewThuLao);
                    AppGridView.SummaryField(gridViewThuLao, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.FormatDataField(gridViewThuLao, "DonGiaQuaTrinh", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThuLao, "DonGiaGiuaKy", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThuLao, "DonGiaCuoiKy", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThuLao, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThuLao, "SoTienCoiThi", DevExpress.Utils.FormatType.Custom, "n0");
                    break;
            }
            
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

            #region _dotThanhToan
            AppGridLookupEdit.InitGridLookUp(cboDotChiTra, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotChiTra, new string[] { "MaQuanLy", "TenQuanLy" }, new string[] { "Mã đợt", "Tên đợt" });
            cboDotChiTra.Properties.ValueMember = "MaCauHinhChotGio";
            cboDotChiTra.Properties.DisplayMember = "TenQuanLy";
            cboDotChiTra.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Đợt thanh toán hiện tại").GiaTri;
            cboDotChiTra.Properties.NullText = string.Empty;
            #endregion

            

            InitData();
        }

        #region InitData
        void InitData()
        {
            try
            {
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    bindingSourceDotChiTra.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
                if (cboDotChiTra.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    bindingSourceThuLao.DataSource = DataServices.ThuLaoCoiThiChamBaiImport.GetByNamHocHocKyDotChiTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotChiTra.EditValue.ToString());
            }
            catch
            { }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmImportThanhToanThuLao frm = new frmImportThanhToanThuLao(_maTruong, "ThuLaoCoiThiChamBai"))
            {
                frm.ShowDialog();
            }
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlThuLao.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboDotChiTra.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceThuLao.DataSource = DataServices.ThuLaoCoiThiChamBaiImport.GetByNamHocHocKyDotChiTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotChiTra.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void btnXoaDotChiTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDotChiTra.EditValue == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn đợt chi trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (XtraMessageBox.Show(string.Format("Bạn muốn xoá dữ liệu thù lao của đợt {0}?", cboDotChiTra.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;

                    DataServices.ThuLaoCoiThiChamBaiImport.XoaDotChiTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotChiTra.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Thao tác xoá thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor.Current = Cursors.WaitCursor;
                InitData();
                Cursor.Current = Cursors.Default;
            }
            catch
            {}
          
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    bindingSourceDotChiTra.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    bindingSourceDotChiTra.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }
    }
}