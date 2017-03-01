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
using PMS.Entities.Validation;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using PMS.Services;

namespace PMS.UI.Modules.Reports
{
    public partial class ucTongHopChiTienCoVanHocTap : XtraUserControl
    {
         TList<CauHinhChung> cauHinhchung = DataServices.CauHinhChung.GetAll();
         string _maTruong;
        public ucTongHopChiTienCoVanHocTap()
        {
            InitializeComponent();
            _maTruong = cauHinhchung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucTongHopChiTienCoVanHocTap_Load(object sender, EventArgs e)
        {
            #region Chi tien co van hoc tap
            AppGridView.InitGridView(gridViewCoVanHocTap, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewCoVanHocTap, new string[] { "TenKhoa", "SoLuong", "SoTien" },
                new string[] { "Khoa", "Số cán bộ", "Thành tiền" },
                new int[] { 280, 100, 130 });
            AppGridView.RegisterControlField(gridViewCoVanHocTap, "SoTien", repositoryItemSpinEditThanhTien);
            AppGridView.SummaryField(gridViewCoVanHocTap, "SoLuong", "Tổng = {0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewCoVanHocTap, "SoTien", "Tổng = {0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.ReadOnlyColumn(gridViewCoVanHocTap);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = cauHinhchung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = cauHinhchung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
           
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            
            

            
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());               
            }

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

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            if (cboNamHoc.EditValue == null && cboHocKy.EditValue==null)
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bindingSourceChiTienCoVan.DataSource = DataServices.ViewTongHopChiTienCoVan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void btnXuatFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook (*.xls)|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        gridControlCoVanHocTap.ExportToXls(sfd.FileName);
                        XtraMessageBox.Show("Bạn đã xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cboNamHoc_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                if (cboNamHoc.EditValue != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                    cboHocKy.DataBindings.Clear();
                    cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue == null || cboHocKy.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            VList<ViewTongHopChiTienCoVan> vList = bindingSourceChiTienCoVan.DataSource as VList<ViewTongHopChiTienCoVan>;
            if (vList != null)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    if (PMS.Common.Globals._cauhinh != null)
                    {
                        frm.InBangTongHopChiTienCoVan(PMS.Common.Globals._cauhinh.TenTruong.ToUpper(), PMS.Common.Globals._cauhinh.KeToan, string.Format("{0}/{1}", cboHocKy.EditValue.ToString(), cboNamHoc.EditValue.ToString()), _maTruong, vList);
                        frm.ShowDialog();
                    }
                    else
                    {
                        XtraMessageBox.Show("Chưa cấu hình tên trường và các thông tin phòng ban liên quan", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}