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
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmQuyDoiCacKhoiLuongKhacTheoDot : DevExpress.XtraEditors.XtraForm
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

        #region Variable
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        int kiemtra = 0;
        string _maTruong;
        bool _thanhToanTheoDot;
        #endregion

        public frmQuyDoiCacKhoiLuongKhacTheoDot()
        {
            InitializeComponent();

            btnChot.Enabled = false;
            btnHuyChot.Enabled = false;
            btnQuyDoi.Enabled = false;
            lblGhiChu.Text = "";

            _maTruong = _listCauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            try
            {
                _thanhToanTheoDot = bool.Parse(_listCauHinhChung.Find(p => p.TenCauHinh == "Thanh toán giờ giảng theo nhiều đợt trong học kỳ").GiaTri);
            }
            catch
            {
                _thanhToanTheoDot = false;
            }
        }

        private void frmQuyDoiCacKhoiLuongKhacTheoDot_Load(object sender, EventArgs e)
        {
            //Nếu thanh toán theo đợt thì hiển thị CBO đợt lên
            if (_thanhToanTheoDot)
            {
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

            switch (_maTruong)
            { 
                case "DLU":
                    InitGridDLU();
                    break;
                default:
                    InitGridRemaining();
                    break;
            }

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

            #region _dotThanhToan
            AppGridLookupEdit.InitGridLookUp(cboDotThanhToan, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotThanhToan, new string[] { "MaQuanLy", "TenQuanLy" }, new string[] { "Mã đợt", "Tên đợt" });
            cboDotThanhToan.Properties.ValueMember = "MaCauHinhChotGio";
            cboDotThanhToan.Properties.DisplayMember = "TenQuanLy";
            cboDotThanhToan.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Đợt thanh toán hiện tại").GiaTri;
            cboDotThanhToan.Properties.NullText = string.Empty;
            #endregion
            
            InitData();
        }

        #region InitGrid
     
        void InitGridDLU()
        {
            AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewKhoiLuong, new string[] { "MaGiangVienQuanLy", "HoTen", "TenKhoa", "TenKhoaNhap", "TenCongViec", "SoLuong", "HeSoQuyDoi", "HeSoChucDanhKhoiLuongKhac", "TietQuyDoi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị trực thuộc", "Đơn vị nhập liệu", "Tên công việc", "Số lượng", "Hệ số quy đổi", "HS chức danh", "Tiết quy đổi", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 90, 150, 150, 150, 500, 60, 50, 80, 90, 90, 90, 90 });
            AppGridView.ShowEditor(gridViewKhoiLuong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "MaGiangVienQuanLy", "HoTen", "TenKhoa", "TenKhoaNhap", "TenCongViec", "SoLuong", "HeSoQuyDoi", "HeSoChucDanhKhoiLuongKhac", "TietQuyDoi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewKhoiLuong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.SummaryField(gridViewKhoiLuong, "TenCongViec", "{0} việc", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuong, "TietQuyDoi", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuong);
        }

        void InitGridRemaining()
        {
            AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewKhoiLuong, new string[] { "MaGiangVienQuanLy", "Ho", "Ten", "TenCongViec", "MaLop", "MaNhom", "SoLuong", "HeSoQuyDoi", "TietQuyDoi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên công việc", "Mã lớp", "Nhóm", "Số lượng", "Hệ số quy đổi", "Tiết quy đổi", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 90, 115, 55, 200, 100, 100, 90, 90, 90, 250, 99, 99 });
            AppGridView.ShowEditor(gridViewKhoiLuong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "MaGiangVienQuanLy", "Ho", "Ten", "TenCongViec", "MaLop", "MaNhom", "SoLuong", "HeSoQuyDoi", "TietQuyDoi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewKhoiLuong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.SummaryField(gridViewKhoiLuong, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuong, "TietQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuong);
        }
        #endregion

        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitDotThanhToan();
            LoadDataSource();
        }

        void InitDotThanhToan()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceDotThanhToan.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDotThanhToan.EditValue != null)
            {
                IDataReader idr = DataServices.KhoiLuongCacCongViecKhac.GetByNamHocHocKyDotThanhToan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString()));
                DataTable dt = new DataTable();
                dt.Load(idr);
                bindingSourceKhoiLuong.DataSource = dt;
                KiemTraChot();
            }
        }

        void KiemTraChot()
        {
            DataServices.KhoiLuongCacCongViecKhac.KiemTraChotTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString()), ref kiemtra);
            if (kiemtra == 1)
            {
                btnQuyDoi.Enabled = false;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = true;
                lblGhiChu.Text = string.Format("Dữ liệu của năm học {0} - {1} - {2} đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.Text);
            }
            else
            {
                btnQuyDoi.Enabled = true;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = false;
                lblGhiChu.Text = "";
            }
        }
        #endregion

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
                if (XtraMessageBox.Show(string.Format("Bạn muốn quy đổi khối lượng năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;
                    DataServices.KhoiLuongCacCongViecKhac.QuyDoiTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString()), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Quy đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LoadDataSource();
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn năm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
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
                            gridControlKhoiLuong.ExportToXls(sf.FileName);
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
            InitDotThanhToan();
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitDotThanhToan();
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn chốt khối lượng năm học {0} - {1} - {2}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.KhoiLuongCacCongViecKhac.ChotTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString()));
                    XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataSource();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                int kq = 0;
                DataServices.GiangVienTamUng.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString()), ref kq);
                if (kq == 1)
                {
                    XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} - {2} đã thanh toán. Không thể huỷ chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt khối lượng năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    using (frmXacNhanLaiMatKhau frm = new frmXacNhanLaiMatKhau(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString(), "HuyCacKhoiLuongKhacTheoDot"))
                    {
                        frm.ShowDialog();
                    }
                    LoadDataSource();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void cboDotThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }
    }
}