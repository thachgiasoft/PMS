using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThanhToanThuLao : XtraUserControl
    {
        public ucThanhToanThuLao()
        {
            InitializeComponent();
        }

        private void ucThanhToanThuLao_Load(object sender, EventArgs e)
        {
            #region Init GridView ThanhToanThuLao
            AppGridView.InitGridView(gridViewThanhToanThuLao, true, true, GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewThanhToanThuLao, new string[] { "MaQuanLy", "HoTen", "ChucDanh", "TietNghiaVu", "TietGioiHan", "TietQuyDoi", "TietDoAn", "TietNgoaiGio", "DonGia", "TienDay", "TienDoAn", "TietThieu", "TietVuot", "TienVuot" },
                new string[] { "Mã GV", "Họ tên", "CD", "Tiết NV", "Tiết GH", "Tiết QĐ", "Tiết ĐA", "Ngoài giờ", "Đơn giá", "Tiền GD", "Tiền ĐA", "Tiết thiếu", "Tiết vượt", "Tiền vượt" },
                new int[] { 70, 180, 70, 90, 90, 90, 90, 100, 90, 90, 90, 90, 90, 90 });
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "TienDay", repositoryItemSpinEditTienGiangDay);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "TienVuot", repositoryItemSpinEditTienVuot);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "MaQuanLy", "Tổng:", DevExpress.Data.SummaryItemType.Custom);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "HoTen", "{0:#,0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "TietQuyDoi", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "TietDoAn", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "TienDay", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "TienDoAn", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.ReadOnlyColumn(gridViewThanhToanThuLao);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";            
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            #endregion

            #region LoaiGiangVien
            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" });
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;
            #endregion

            #region DonVi - KhoaBoMon
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaKhoa", "TenKhoa","MaBoMon","TenBoMon" }, new string[] { "Mã đơn vị", "Tên đơn vị","Mã bộ môn", "Tên bộ môn" });
            cboDonVi.Properties.DisplayMember = "TenBoMon";
            cboDonVi.Properties.ValueMember = "MaBoMon";
            cboDonVi.Properties.NullText = string.Empty;
            #endregion

            #region Init Datasource
            InitData();
            #endregion

            #region Init CauHinh
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll() as TList<CauHinh>;
            if (listCauHinh != null)
            {
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }
            #endregion
        }

        private void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHoc.DataBindings.Clear();
            cboNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);

            ViewNamHoc objNamHoc = bindingSourceNamHoc.Current as ViewNamHoc;
            if (objNamHoc != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                cboHocKy.DataBindings.Clear();
                cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            bindingSourceDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            cboDonVi.DataBindings.Clear();
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            cboLoaiGiangVien.DataBindings.Clear();
            cboLoaiGiangVien.DataBindings.Add("EditValue", bindingSourceLoaiGiangVien, "MaLoaiGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewHocKy vHocKy = bindingSourceHocKy.Current as ViewHocKy;
            if (vHocKy == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ViewKhoaBoMon vDonVi = bindingSourceDonVi.Current as ViewKhoaBoMon;
            if (vDonVi == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoaiGiangVien vLoai = bindingSourceLoaiGiangVien.Current as LoaiGiangVien;
            if (vLoai == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn loại giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bindingSourceThanhToanThuLao.DataSource = DataServices.ViewThanhToanThuLao.GetByNamHocHocKyDonViLoaiGiangVien(vHocKy.NamHoc, vHocKy.MaHocKy, vDonVi.MaBoMon, vLoai.MaLoaiGiangVien);
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                ViewNamHoc objNamHoc = cboNamHoc.Properties.GetRowByKeyValue(e.Value) as ViewNamHoc;
                if (objNamHoc != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                    cboHocKy.DataBindings.Clear();
                    cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewHocKy vHocKy = bindingSourceHocKy.Current as ViewHocKy;         
            if (vHocKy == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ViewKhoaBoMon vDonVi = bindingSourceDonVi.Current as ViewKhoaBoMon;
            if (vDonVi == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoaiGiangVien vLoai = bindingSourceLoaiGiangVien.Current as LoaiGiangVien;
            if (vLoai == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn loại giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Init Report.
            VList<ViewThanhToanThuLao> vList = bindingSourceThanhToanThuLao.DataSource as VList<ViewThanhToanThuLao>;
            if (vList != null)
            {
                frmBaoCao frm = new frmBaoCao();
                if (PMS.Common.Globals._cauhinh != null)
                {
                    frm.DanhSachThanhToanThuLaoGiangDay(vHocKy.NamHoc, vHocKy.MaHocKy, vDonVi.TenBoMon + "(" + vDonVi.MaBoMon +")"+" - Khoa:"+ vDonVi.TenKhoa, 
                     vLoai.TenLoaiGiangVien, PMS.Common.Globals._cauhinh.TenTruong.ToUpper(),
                     PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.PhongToChucCanBo, PMS.Common.Globals._cauhinh.KeToan,
                     PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.NguoiLapbieu, vList);
                    frm.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Chưa cấu hình tên trường và các thông tin phòng ban liên quan", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

            }
            Cursor.Current = Cursors.Default;
        }        
    }
}