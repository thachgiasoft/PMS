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
    public partial class ucChiTietKhoiLuongThucDay : XtraUserControl
    {
        public ucChiTietKhoiLuongThucDay()
        {
            InitializeComponent();
        }

        private void ucChiTietKhoiLuongThucDay_Load(object sender, EventArgs e)
        {
            #region Init GridView ThanhToanThuLao
            AppGridView.InitGridView(gridViewThanhToanThuLao, true, true, GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewThanhToanThuLao, new string[] { "TenKhoa", "TenBoMon", "LyThuyet1", "ThucHanh1", "ThiNghiem1", "DoAn1", "LyThuyet2", "ThucHanh2", "ThiNghiem2", "DoAn2" },
                new string[] { "Khoa", "Bộ môn", "LT (CH)", "TH (CH)", "TN (CH)", "DAMH (CH)", "LT (MG)", "TH (MG)", "TN (MG)", "DAMH (MG)" },
                new int[] { 350, 250, 80, 80, 80, 80, 80, 80, 80, 80 });

            AppGridView.MergeCell(gridViewThanhToanThuLao, new string[] { "LyThuyet1", "ThucHanh1", "ThiNghiem1", "DoAn1", "LyThuyet2", "ThucHanh2", "ThiNghiem2", "DoAn2" });

            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "LyThuyet1", repositoryItemSpinEditLyThuyet1);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "ThucHanh1", repositoryItemSpinEditThucHanh1);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "ThiNghiem1", repositoryItemSpinEditThiNghiem1);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "DoAn1", repositoryItemSpinEditDoAn1);

            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "LyThuyet2", repositoryItemSpinEditLyThuyet2);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "ThucHanh2", repositoryItemSpinEditThucHanh2);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "ThiNghiem2", repositoryItemSpinEditThiNghiem2);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "DoAn2", repositoryItemSpinEditDoAn2);

            AppGridView.SummaryField(gridViewThanhToanThuLao, "TenKhoa", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "LyThuyet1", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "ThucHanh1", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "ThiNghiem1", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "DoAn1", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);

            AppGridView.SummaryField(gridViewThanhToanThuLao, "LyThuyet2", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "ThucHanh2", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "ThiNghiem2", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "DoAn2", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
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

            #region Init Datasource
            InitData();
            #endregion

            #region Init CauHinh
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll() as TList<CauHinh>;
            foreach (CauHinh ch in listCauHinh)
                if (ch.TrangThai == true)
                    PMS.Common.Globals._cauhinh = ch;
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
            bindingSourceTongHopKhoiLuong.DataSource = DataServices.ViewChiTietKhoiLuongThucDay.GetByNamHocHocKy(vHocKy.NamHoc, vHocKy.MaHocKy);
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
            //Init Report
            VList<ViewChiTietKhoiLuongThucDay> vList = bindingSourceTongHopKhoiLuong.DataSource as VList<ViewChiTietKhoiLuongThucDay>;
            if (vList != null)
            {
                frmBaoCao frm = new frmBaoCao();
                frm.InBangChiTietKhoiLuongThucDay(PMS.Common.Globals._cauhinh.TenTruong.ToUpper(),PMS.Common.Globals._cauhinh.PhongDaoTao,vHocKy.NamHoc, vHocKy.MaHocKy, vList);
                frm.ShowDialog();
            }
            Cursor.Current = Cursors.Default;
        }
    }
}