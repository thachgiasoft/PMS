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
    public partial class ucTongHopKhoiLuongQuyDoi : XtraUserControl
    {
        public ucTongHopKhoiLuongQuyDoi()
        {
            InitializeComponent();
        }

        private void ucTongHopKhoiLuongQuyDoi_Load(object sender, EventArgs e)
        {
            #region Init GridView ThanhToanThuLao
            AppGridView.InitGridView(gridViewThanhToanThuLao, true, true, GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewThanhToanThuLao, new string[] { "MaKhoa", "TenKhoa", "SoTiet1", "TietDoAn1", "SoTiet2", "TietDoAn2" },
                new string[] { "Mã khoa", "Khoa", "Số tiết (CH)", "Tiết đồ án (CH)", "Số tiết (MG)", "Tiết đồ án (MG)" },
                new int[] { 100, 350, 100, 100, 100, 100, 100 });

            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "SoTiet1", repositoryItemSpinEditTietQuyDoi1);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "TietDoAn1", repositoryItemSpinEditTietDoAn1);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "SoTiet2", repositoryItemSpinEditTietQuyDoi2);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "TietDoAn2", repositoryItemSpinEditTietDoAn2);

            AppGridView.SummaryField(gridViewThanhToanThuLao, "TenKhoa", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "SoTiet1", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "TietDoAn1", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "SoTiet2", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "TietDoAn2", "{0:#,0}", DevExpress.Data.SummaryItemType.Sum);
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
            cboNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "NamHoc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);

            ViewNamHoc objNamHoc = bindingSourceNamHoc.Current as ViewNamHoc;
            if (objNamHoc != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                cboHocKy.DataBindings.Clear();
                cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
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
            bindingSourceTongHopKhoiLuong.DataSource = DataServices.ViewTongHopQuyDoi.GetByNamHocHocKy(vHocKy.NamHoc, vHocKy.MaHocKy);
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
            VList<ViewTongHopQuyDoi> vList = bindingSourceTongHopKhoiLuong.DataSource as VList<ViewTongHopQuyDoi>;
            if (vList != null)
            {
                frmBaoCao frm = new frmBaoCao();
                if (PMS.Common.Globals._cauhinh != null)
                {
                    frm.InBangTongHopKhoiLuongQuyDoi(vHocKy.NamHoc, vHocKy.MaHocKy, PMS.Common.Globals._cauhinh.TenTruong.ToUpper(),
                     PMS.Common.Globals._cauhinh.PhongDaoTao, vList);
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