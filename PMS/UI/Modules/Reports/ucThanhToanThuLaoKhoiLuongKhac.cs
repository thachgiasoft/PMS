using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.BaoCao;
using PMS.Services;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThanhToanThuLaoKhoiLuongKhac : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion
        #region Event Form
        public ucThanhToanThuLaoKhoiLuongKhac()
        {
            InitializeComponent();
        }

        private void ucThanhToanThuLaoKhoiLuongKhac_Load(object sender, EventArgs e)
        {
            #region InitGrid
            AppGridView.InitGridView(gridViewThanhToan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThanhToan, new string[] { "MaQuanLy", "Ho", "Ten", "MaMonHoc", "TenMon", "LoaiHocPhan", "MaLopHocPhan", "MaLop", "MaNhom", "SiSo", "SoTuan", "SoTiet", "SoTietQuyDoi", "DonGia", "ThanhTien", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Mã môn học", "Tên môn học", "Loại học phần", "Mã lớp học phần", "Mã lớp", "Mã nhóm", "Sĩ số", "Số tuần", "Số tiết", "Tiết quy đổi", "Đơn giá", "Thành tiền", "Ghi chú" }
                    , new int[] { 90, 110, 50, 100, 150, 100, 110, 90, 80, 70, 70, 70, 90, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewThanhToan, new string[] { "MaQuanLy", "Ho", "Ten", "MaMonHoc", "TenMon", "LoaiHocPhan", "MaLopHocPhan", "MaLop", "MaNhom", "SiSo", "SoTuan", "SoTiet", "SoTietQuyDoi", "DonGia", "ThanhTien", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhToan, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewThanhToan);
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" }, new int[] { 80, 130 });
            cboDonVi.Properties.ValueMember = "MaKhoa";
            cboDonVi.Properties.DisplayMember = "TenKhoa";
            cboDonVi.Properties.NullText = string.Empty;

            #endregion

            #region LoaiGiangVien
            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "tên loại giảng viên" });
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion
        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            bindingSourceDonVi.DataSource = DataServices.ViewKhoa.GetAll();
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            cboDonVi.DataBindings.Clear();
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);
            cboLoaiGiangVien.DataBindings.Clear();
            cboLoaiGiangVien.DataBindings.Add("EditValue", bindingSourceLoaiGiangVien, "MaLoaiGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.UteKhoiLuongKhac.GetByNamHocHocKyDonViLoaiGiangVien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), (int)cboLoaiGiangVien.EditValue);
                tb.Load(reader);
                bindingSourceThanhToan.DataSource = tb;
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

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.UteKhoiLuongKhac.GetByNamHocHocKyDonViLoaiGiangVien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), (int)cboLoaiGiangVien.EditValue);
                tb.Load(reader);
                bindingSourceThanhToan.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThanhToan.FocusedRowHandle = -1;
            bindingSourceThanhToan.EndEdit();

            DataTable data = bindingSourceThanhToan.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data as DataTable;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThanhToan, bindingSourceThanhToan);

            if (vListBaoCao != null)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThanhToanThuLaoKhoiLuongKhac(PMS.Common.Globals._cauhinh.TenTruong, cboDonVi.Text, cboLoaiGiangVien.Text, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), PMS.Common.Globals._cauhinh.NguoiLapbieu, data);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}
