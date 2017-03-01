using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;

namespace PMS.UI.Modules.Reports
{
    public partial class ucSoSanhKetQuaHaiLanChot : DevExpress.XtraEditors.XtraUserControl
    {
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        string _maTruong;
        public ucSoSanhKetQuaHaiLanChot()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucSoSanhKetQuaHaiLanChot_Load(object sender, EventArgs e)
        {
            #region Init GridView
            if (_maTruong == "USSH")
            {
                AppGridView.InitGridView(gridViewSoSanh, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
                AppGridView.ShowField(gridViewSoSanh, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "MaMonHoc1", "TenMonHoc1", "MaMonHoc2", "TenMonHoc2", "LoaiHocPhan1", "LoaiHocPhan2", "Nhom1", "Nhom2", "MaLop1", "MaLop2", "SiSo1", "SiSo2", "TietThucDay1", "TietThucDay2", "TenHinhThucDaoTao1", "TenHinhThucDaoTao2", "TenCoSo1", "TenCoSo2", "HeSoCoSo1", "HeSoCoSo2", "HeSoQuyDoiThucHanhSangLyThuyet1", "HeSoQuyDoiThucHanhSangLyThuyet2", "TietQuyDoi1", "TietQuyDoi2", "DonGiaTrongChuan1", "DonGiaTrongChuan2", "DonGiaNgoaiChuan1", "DonGiaNgoaiChuan2" }
                        , new string[] { "Tên khoa", "Mã giảng viên", "Họ tên", "Mã môn học A", "Tên môn học A", "Mã môn học B", "Tên môn học B", "Loại học phần A", "Loại học phần B", "Nhóm A", "Nhóm B", "Mã lớp A", "Mã lớp B", "Sĩ số A", "Sĩ số B", "Tiết thực dạy A", "Tiết thực dạy B", "Hình thức đào tạo A", "Hình thức đào tạo B", "Cơ sở A", "Cơ sở B", "Hệ số cơ sở A", "Hệ số cơ sở B", "Hệ số quy đổi TH-LT A", "Hệ số quy đổi TH-LT B", "Tiết quy đổi A", "Tiết quy đổi B", "Đơn giá trong chuẩn A", "Đơn giá trong chuẩn B", "Đơn giá ngoài chuẩn A", "Đơn giá ngoài chuẩn B" }
                        , new int[] { 120, 90, 140, 100, 150, 100, 150, 120, 120, 60, 60, 70, 70, 70, 70, 100, 100, 120, 120, 70, 70, 100, 100, 150, 150, 100, 100, 130, 130, 130, 130 });
                AppGridView.AlignHeader(gridViewSoSanh, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "MaMonHoc1", "TenMonHoc1", "MaMonHoc2", "TenMonHoc2", "LoaiHocPhan1", "LoaiHocPhan2", "Nhom1", "Nhom2", "MaLop1", "MaLop2", "SiSo1", "SiSo2", "TietThucDay1", "TietThucDay2", "TenHinhThucDaoTao1", "TenHinhThucDaoTao2", "TenCoSo1", "TenCoSo2", "HeSoCoSo1", "HeSoCoSo2", "HeSoQuyDoiThucHanhSangLyThuyet1", "HeSoQuyDoiThucHanhSangLyThuyet2", "TietQuyDoi1", "TietQuyDoi2", "DonGiaTrongChuan1", "DonGiaTrongChuan2", "DonGiaNgoaiChuan1", "DonGiaNgoaiChuan2" }, DevExpress.Utils.HorzAlignment.Center);
                AppGridView.ReadOnlyColumn(gridViewSoSanh);
                gridViewSoSanh.Columns["TenDonVi"].GroupIndex = 0;
                AppGridView.FormatDataField(gridViewSoSanh, "DonGiaTrongChuan1", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewSoSanh, "DonGiaTrongChuan2", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewSoSanh, "DonGiaNgoaiChuan1", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewSoSanh, "DonGiaNgoaiChuan2", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FixedField(gridViewSoSanh, new string[] { "MaQuanLy", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            }
            else//UTE
            {
                AppGridView.InitGridView(gridViewSoSanh, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
                AppGridView.ShowField(gridViewSoSanh, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "MaMonHoc1", "TenMonHoc1", "MaMonHoc2", "TenMonHoc2", "LoaiHocPhan1", "LoaiHocPhan2", "Nhom1", "Nhom2", "MaLop1", "MaLop2", "SiSo1", "SiSo2", "LopClc1", "LopClc2", "TietThucDay1", "TietThucDay2", "HeSoLopDong1", "HeSoLopDong2", "HeSoHocKy1", "HeSoHocKy2", "TietQuyDoi1", "TietQuyDoi2", "DonGia1", "DonGia2", "ThanhTien1", "ThanhTien2", "TenKhoa" }
                        , new string[] { "Mã giảng viên", "Họ tên", "Tên bộ môn", "Mã môn học A", "Tên môn học A", "Mã môn học B", "Tên môn học B", "Loại học phần A", "Loại học phần B", "Nhóm A", "Nhóm B", "Mã lớp A", "Mã lớp B", "Sĩ số A", "Sĩ số B", "Lớp CLC A", "Lớp CLC B", "Tiết thực dạy A", "Tiết thực dạy B", "Hệ số lớp đông A", "Hệ số lớp đông B", "Hệ số học kỳ A", "Hệ số học kỳ B", "Tiết quy đổi A", "Tiết quy đổi B", "Đơn giá A", "Đơn giá B", "Thành tiền A", "Thành tiền B", "Tên khoa" }
                        , new int[] { 90, 140, 120, 80, 150, 80, 150, 120, 120, 60, 60, 70, 70, 70, 70, 90, 90, 120, 120, 110, 110, 100, 100, 100, 100, 90, 90, 100, 100, 99 });
                AppGridView.AlignHeader(gridViewSoSanh, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "MaMonHoc1", "TenMonHoc1", "MaMonHoc2", "TenMonHoc2", "LoaiHocPhan1", "LoaiHocPhan2", "Nhom1", "Nhom2", "MaLop1", "MaLop2", "SiSo1", "SiSo2", "LopClc1", "LopClc2", "TietThucDay1", "TietThucDay2", "HeSoLopDong1", "HeSoLopDong2", "HeSoHocKy1", "HeSoHocKy2", "TietQuyDoi1", "TietQuyDoi2", "DonGia1", "DonGia2", "ThanhTien1", "ThanhTien2" }, DevExpress.Utils.HorzAlignment.Center);
                AppGridView.ReadOnlyColumn(gridViewSoSanh);
                gridViewSoSanh.Columns["TenKhoa"].GroupIndex = 0;
                AppGridView.FormatDataField(gridViewSoSanh, "DonGia1", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewSoSanh, "DonGia2", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewSoSanh, "ThanhTien1", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewSoSanh, "ThanhTien2", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FixedField(gridViewSoSanh, new string[] { "MaQuanLy", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            #region _lanChot A
            AppGridLookupEdit.InitGridLookUp(cboLanChotA, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotA, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotA.Properties.ValueMember = "LanChot";
            cboLanChotA.Properties.DisplayMember = "LanChot";
            cboLanChotA.Properties.NullText = string.Empty;
            #endregion
            #region _lanChot B
            AppGridLookupEdit.InitGridLookUp(cboLanChotB, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotB, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotB.Properties.ValueMember = "LanChot";
            cboLanChotB.Properties.DisplayMember = "LanChot";
            cboLanChotB.Properties.NullText = string.Empty;
            #endregion
            InitData();
        }
        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLanChotA.EditValue != null && cboLanChotB.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.SoSanhHaiLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChotA.EditValue.ToString()), int.Parse(cboLanChotB.EditValue.ToString()));
                dt.Load(reader);
                bindingSourceSoSanh.DataSource = dt;
            }
            gridViewSoSanh.ExpandAllGroups();
        }
        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboLanChotA.DataBindings.Clear();
                cboLanChotB.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotA.DataSource = tblLanChot;
                bindingSourceLanChotB.DataSource = tblLanChot;
                cboLanChotA.DataBindings.Add("EditValue", bindingSourceLanChotA, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
                cboLanChotB.DataBindings.Add("EditValue", bindingSourceLanChotB, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLanChotA.EditValue != null && cboLanChotB.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.SoSanhHaiLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChotA.EditValue.ToString()), int.Parse(cboLanChotB.EditValue.ToString()));
                dt.Load(reader);
                bindingSourceSoSanh.DataSource = dt;
            }
            ToMau();
            gridViewSoSanh.ExpandAllGroups();
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
                        gridControlSoSanh.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }
        void ToMau()
        {
            gridViewSoSanh.FormatConditions.Clear();

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionMaMonHoc = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionMaMonHoc.Column = gridViewSoSanh.Columns["MaMonHoc1"];
            styleFormatConditionMaMonHoc.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionMaMonHoc.Expression = "[MaMonHoc1]  != [MaMonHoc2]";
            styleFormatConditionMaMonHoc.Appearance.Options.UseBackColor = true;
            styleFormatConditionMaMonHoc.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionTenMonHoc = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionTenMonHoc.Column = gridViewSoSanh.Columns["TenMonHoc1"];
            styleFormatConditionTenMonHoc.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionTenMonHoc.Expression = "[TenMonHoc1]  != [TenMonHoc2]";
            styleFormatConditionTenMonHoc.Appearance.Options.UseBackColor = true;
            styleFormatConditionTenMonHoc.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionLoaiHocPhan = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionLoaiHocPhan.Column = gridViewSoSanh.Columns["LoaiHocPhan1"];
            styleFormatConditionLoaiHocPhan.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionLoaiHocPhan.Expression = "[LoaiHocPhan1]  != [LoaiHocPhan2]";
            styleFormatConditionLoaiHocPhan.Appearance.Options.UseBackColor = true;
            styleFormatConditionLoaiHocPhan.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionNhom = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionNhom.Column = gridViewSoSanh.Columns["Nhom1"];
            styleFormatConditionNhom.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionNhom.Expression = "[Nhom1]  != [Nhom2]";
            styleFormatConditionNhom.Appearance.Options.UseBackColor = true;
            styleFormatConditionNhom.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionMaLop = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionMaLop.Column = gridViewSoSanh.Columns["MaLop1"];
            styleFormatConditionMaLop.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionMaLop.Expression = "[MaLop1]  != [MaLop2]";
            styleFormatConditionMaLop.Appearance.Options.UseBackColor = true;
            styleFormatConditionMaLop.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionSiSo = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionSiSo.Column = gridViewSoSanh.Columns["SiSo1"];
            styleFormatConditionSiSo.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionSiSo.Expression = "[SiSo1]  != [SiSo2]";
            styleFormatConditionSiSo.Appearance.Options.UseBackColor = true;
            styleFormatConditionSiSo.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionTietThucDay = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionTietThucDay.Column = gridViewSoSanh.Columns["TietThucDay1"];
            styleFormatConditionTietThucDay.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionTietThucDay.Expression = "[TietThucDay1]  != [TietThucDay2]";
            styleFormatConditionTietThucDay.Appearance.Options.UseBackColor = true;
            styleFormatConditionTietThucDay.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionTenHinhThucDaoTao = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionTenHinhThucDaoTao.Column = gridViewSoSanh.Columns["TenHinhThucDaoTao1"];
            styleFormatConditionTenHinhThucDaoTao.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionTenHinhThucDaoTao.Expression = "[TenHinhThucDaoTao1]  != [TenHinhThucDaoTao2]";
            styleFormatConditionTenHinhThucDaoTao.Appearance.Options.UseBackColor = true;
            styleFormatConditionTenHinhThucDaoTao.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionTenCoSo = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionTenCoSo.Column = gridViewSoSanh.Columns["TenCoSo1"];
            styleFormatConditionTenCoSo.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionTenCoSo.Expression = "[TenCoSo1]  != [TenCoSo2]";
            styleFormatConditionTenCoSo.Appearance.Options.UseBackColor = true;
            styleFormatConditionTenCoSo.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionHeSoCoSo = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionHeSoCoSo.Column = gridViewSoSanh.Columns["HeSoCoSo1"];
            styleFormatConditionHeSoCoSo.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionHeSoCoSo.Expression = "[HeSoCoSo1]  != [HeSoCoSo2]";
            styleFormatConditionHeSoCoSo.Appearance.Options.UseBackColor = true;
            styleFormatConditionHeSoCoSo.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionHeSoQuyDoiThucHanhSangLyThuyet = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionHeSoQuyDoiThucHanhSangLyThuyet.Column = gridViewSoSanh.Columns["HeSoQuyDoiThucHanhSangLyThuyet1"];
            styleFormatConditionHeSoQuyDoiThucHanhSangLyThuyet.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionHeSoQuyDoiThucHanhSangLyThuyet.Expression = "[HeSoQuyDoiThucHanhSangLyThuyet1]  != [HeSoQuyDoiThucHanhSangLyThuyet2]";
            styleFormatConditionHeSoQuyDoiThucHanhSangLyThuyet.Appearance.Options.UseBackColor = true;
            styleFormatConditionHeSoQuyDoiThucHanhSangLyThuyet.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionTietQuyDoi = new DevExpress.XtraGrid.StyleFormatCondition { Column = gridViewSoSanh.Columns["TietQuyDoi1"], Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression, Expression = "[TietQuyDoi1]  != [TietQuyDoi2]" };
            styleFormatConditionTietQuyDoi.Appearance.Options.UseBackColor = true;
            styleFormatConditionTietQuyDoi.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionDonGiaTrongChuan = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionDonGiaTrongChuan.Column = gridViewSoSanh.Columns["DonGiaTrongChuan1"];
            styleFormatConditionDonGiaTrongChuan.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionDonGiaTrongChuan.Expression = "[DonGiaTrongChuan1]  != [DonGiaTrongChuan2]";
            styleFormatConditionDonGiaTrongChuan.Appearance.Options.UseBackColor = true;
            styleFormatConditionDonGiaTrongChuan.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionDonGiaNgoaiChuan = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionDonGiaNgoaiChuan.Column = gridViewSoSanh.Columns["DonGiaNgoaiChuan1"];
            styleFormatConditionDonGiaNgoaiChuan.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionDonGiaNgoaiChuan.Expression = "[DonGiaNgoaiChuan1]  != [DonGiaNgoaiChuan2]";
            styleFormatConditionDonGiaNgoaiChuan.Appearance.Options.UseBackColor = true;
            styleFormatConditionDonGiaNgoaiChuan.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionHeSoHocKy = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionHeSoHocKy.Column = gridViewSoSanh.Columns["HeSoHocKy1"];
            styleFormatConditionHeSoHocKy.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionHeSoHocKy.Expression = "[HeSoHocKy1]  != [HeSoHocKy2]";
            styleFormatConditionHeSoHocKy.Appearance.Options.UseBackColor = true;
            styleFormatConditionHeSoHocKy.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionLopClc = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionLopClc.Column = gridViewSoSanh.Columns["LopClc1"];
            styleFormatConditionLopClc.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionLopClc.Expression = "[LopClc1]  != [LopClc2]";
            styleFormatConditionLopClc.Appearance.Options.UseBackColor = true;
            styleFormatConditionLopClc.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionDonGia = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionDonGia.Column = gridViewSoSanh.Columns["DonGia1"];
            styleFormatConditionDonGia.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionDonGia.Expression = "[DonGia1]  != [DonGia2]";
            styleFormatConditionDonGia.Appearance.Options.UseBackColor = true;
            styleFormatConditionDonGia.Appearance.BackColor = System.Drawing.Color.Silver;

            DevExpress.XtraGrid.StyleFormatCondition styleFormatConditionThanhTien = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatConditionThanhTien.Column = gridViewSoSanh.Columns["ThanhTien1"];
            styleFormatConditionThanhTien.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatConditionThanhTien.Expression = "[ThanhTien1]  != [ThanhTien2]";
            styleFormatConditionThanhTien.Appearance.Options.UseBackColor = true;
            styleFormatConditionThanhTien.Appearance.BackColor = System.Drawing.Color.Silver;

            gridViewSoSanh.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
                styleFormatConditionMaMonHoc, styleFormatConditionTenMonHoc, styleFormatConditionLoaiHocPhan, styleFormatConditionNhom, styleFormatConditionMaLop
                , styleFormatConditionSiSo, styleFormatConditionTietThucDay, styleFormatConditionTenHinhThucDaoTao, styleFormatConditionTenCoSo
                , styleFormatConditionHeSoCoSo, styleFormatConditionHeSoQuyDoiThucHanhSangLyThuyet, styleFormatConditionTietQuyDoi
                , styleFormatConditionDonGiaTrongChuan, styleFormatConditionDonGiaNgoaiChuan, styleFormatConditionHeSoHocKy, styleFormatConditionLopClc
                , styleFormatConditionDonGia, styleFormatConditionThanhTien });
           
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            InitLanChot();
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
        }

    }
}
