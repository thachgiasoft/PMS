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
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu.SauDaiHoc
{
    public partial class frmChotTongKetKhoiLuongGiangDay_SDH : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnChotThanhToan.Enabled = false;
                btnHuyChot.Enabled = false;
            }
            else
            {
                btnChotThanhToan.Enabled = true;
                btnHuyChot.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        string _maTruong;
        #endregion
        #region Event Form
        public frmChotTongKetKhoiLuongGiangDay_SDH()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmChotTongKetKhoiLuongGiangDay_SDH_Load(object sender, EventArgs e)
        {
            #region Init GirdView
         
                    AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
                    AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "HoTen", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "MaDiaDiem", "TenDiaDiem", "SiSo", "SoTiet", "TietChuNhat", "SoTinChi", "HeSoLopDong", "DonGia", "DonGiaDiaDiem", "HeSoDiaDiem", "DonGiaQuyDoi", "TongThanhTien", "TienChamBai", "TongCong", "MaDonVi" }
                            , new string[] { "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp","Mã địa điểm","Tên địa điểm", "Sĩ số", "Số tiết", "Số tiết buổi tối","Số tín chỉ", "Hệ số lớp đông", "Đơn giá","Đơn giá địa điểm","Hệ số địa điểm", "Đơn giá quy đổi", "Thành tiền", "Tiền chấm bài", "Tổng cộng", "Đơn vị" }
                            , new int[] { 90, 140, 80, 80, 80, 80, 150, 60, 70, 80, 90, 130, 70, 100, 70, 100, 80, 110, 110, 90, 90, 90, 90, 90, 90 });
                    AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "HoTen", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "MaDiaDiem", "TenDiaDiem", "SiSo", "SoTiet", "TietChuNhat", "SoTinChi", "HeSoLopDong", "DonGia", "DonGiaDiaDiem", "HeSoDiaDiem", "DonGiaQuyDoi", "TongThanhTien", "TienChamBai", "TongCong", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.ReadOnlyColumn(gridViewTongKet);
                    AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewTongKet, "TietChuNhat", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewTongKet, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewTongKet, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewTongKet, "DonGiaDiaDiem", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewTongKet, "DonGiaQuyDoi", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewTongKet, "TienChamBai", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewTongKet, "TongCong", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
                    AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
                    AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
                    AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
                    AppGridView.SummaryField(gridViewTongKet, "TongThanhTien", "Tổng: {0:n0}", DevExpress.Data.SummaryItemType.Sum);
          
            gridViewTongKet.GroupPanelText = "Gom nhóm bằng cách kéo tên cột thả vào đây";
            //gridViewTongKet.Columns["MaDonVi"].GroupIndex = 0;
            PMS.Common.Globals.WordWrapHeader(gridViewTongKet, 40);
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

            #region DonVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDonVi, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDonVi, new string[] { "TenBoMon" }, new string[] { "Đơn vị" });
            repositoryItemGridLookUpEditDonVi.ValueMember = "MaBoMon";
            repositoryItemGridLookUpEditDonVi.DisplayMember = "TenBoMon";
            repositoryItemGridLookUpEditDonVi.NullText = string.Empty;
            #endregion

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion

            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
            #endregion

            #region LoaiGiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" });
            repositoryItemGridLookUpEditLoaiGiangVien.ValueMember = "MaLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.DisplayMember = "TenLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.NullText = string.Empty;
            #endregion

            #region HinhThucDaoTao
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHinhThucDaoTao, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHinhThucDaoTao, new string[] { "MaHinhThucDaoTao", "TenHinhThucDaoTao" }, new string[] { "Mã hình thức đào tạo", "Tên hình thức đào tạo" });
            repositoryItemGridLookUpEditHinhThucDaoTao.ValueMember = "MaHinhThucDaoTao";
            repositoryItemGridLookUpEditHinhThucDaoTao.DisplayMember = "TenHinhThucDaoTao";
            repositoryItemGridLookUpEditHinhThucDaoTao.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            bindingSourceDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceHinhThucDaoTao.DataSource = DataServices.HinhThucDaoTao.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceTongKet.DataSource = DataServices.ViewSdhLietKeKhoiLuongGiangDayChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                DataServices.SdhKetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                txtSoLanChot.Text = lanchot.ToString();
            }
            gridViewTongKet.ExpandAllGroups();
        }

        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceTongKet.DataSource = DataServices.ViewSdhLietKeKhoiLuongGiangDayChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                DataServices.SdhKetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                txtSoLanChot.Text = lanchot.ToString();
            }
            gridViewTongKet.ExpandAllGroups();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceTongKet.DataSource = DataServices.ViewSdhLietKeKhoiLuongGiangDayChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                DataServices.SdhKetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                txtSoLanChot.Text = lanchot.ToString();
            }
            gridViewTongKet.ExpandAllGroups();
        }
        #endregion
        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }
        private void btnChotThanhToan_Click(object sender, EventArgs e)
        {
            
            int kq = 0;
            DataServices.SdhKetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
            lanchot++;
            if (XtraMessageBox.Show(string.Format("Chốt khối lượng giảng dạy năm học {0} - {1} lần thứ {2}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lanchot), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    DataServices.SdhKetQuaThanhToanThuLao.ChotThanhToan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lanchot, ref kq);
                    DataServices.SdhKetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                    txtSoLanChot.Text = lanchot.ToString();
                    if (kq == 0)
                        XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (lanchot > 0)
            {
                using (frmHuyChotThuLao_SDH frm = new frmHuyChotThuLao_SDH(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lanchot))
                {
                    frm.ShowDialog();
                }
                InitData();
            }
            else
            {
                XtraMessageBox.Show("Không thể huỷ do chưa chốt lần nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            gridControlTongKet.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        #endregion

  
    }
}
