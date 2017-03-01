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
    public partial class ucChiTienCoVanHocTap : XtraUserControl
    {
        TList<CauHinhChung> cauHinhchung = DataServices.CauHinhChung.GetAll();
        public ucChiTienCoVanHocTap()
        {
            InitializeComponent();
        }
        private void ucChiTienCoVanHocTap_Load(object sender, EventArgs e)
        {
            #region Chi tien co van hoc tap
            AppGridView.InitGridView(gridViewCoVanHocTap, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewCoVanHocTap, new string[] { "Stt", "HoTen", "MaDonVi", "ChucDanh", "NamHoc", "HocKy", "MaLop", "SoTien", "SoTiet", "ThanhTien", "TongThanhTien" },
                new string[] { "STT", "Họ tên", "Đơn vị", "Chức danh", "Năm học", "Học kỳ", "Lớp", "Số tiền", "Số tiết", "Thành tiền", "Tổng cộng" },
                new int[] { 60, 180, 100, 140, 80, 80, 150, 80, 80, 130, 130 });
            AppGridView.RegisterControlField(gridViewCoVanHocTap, "SoTien", repositoryItemSpinEditSoTien);
            AppGridView.RegisterControlField(gridViewCoVanHocTap, "ThanhTien", repositoryItemSpinEditThanhTien);
            AppGridView.SummaryField(gridViewCoVanHocTap, "ThanhTien", "Tổng = {0:#,0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewCoVanHocTap, "HoTen", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewCoVanHocTap, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
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
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                cboHocKy.Properties.DataSource = bindingSourceHocKy.DataSource;
                cboHocKy.Properties.ValueMember = "MaHocKy";
                cboHocKy.Properties.DisplayMember = "MaHocKy";
                cboHocKy.Properties.NullText = string.Empty;
                cboHocKy.Properties.SeparatorChar = ';';
                cboHocKy.Properties.SelectAllItemCaption = "Tất cả";
                cboHocKy.CheckAll();
            }
            #endregion
            
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            //cboNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "_namHoc", true, DataSourceUpdateMode.OnPropertyChanged);
            
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
            cboNamHoc.EditValue = cauHinhchung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            Cursor.Current = Cursors.Default;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //ViewHocKy objHocKy = bindingSourceHocKy.Current as ViewHocKy;
            if (cboNamHoc.EditValue == null && cboHocKy.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = new DataTable();
            IDataReader reader = DataServices.ViewChiTienCoVan.GetByNamHocHocKy2(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            dt.Load(reader);
            bindingSourceChiTienCoVan.DataSource = dt;
            //bindingSourceChiTienCoVan.DataSource = DataServices.ViewChiTienCoVan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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
                    cboHocKy.Properties.DataSource = bindingSourceHocKy.DataSource;
                    cboHocKy.Properties.ValueMember = "MaHocKy";
                    cboHocKy.Properties.DisplayMember = "MaHocKy";
                    cboHocKy.Properties.NullText = string.Empty;
                    cboHocKy.Properties.SeparatorChar = ';';
                    cboHocKy.Properties.SelectAllItemCaption = "Tất cả";
                    cboHocKy.CheckAll();
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable vList = bindingSourceChiTienCoVan.DataSource as DataTable;
            if (vList != null)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    if (PMS.Common.Globals._cauhinh != null)
                    {
                        string tuaDe = "BẢNG CHI TIỀN CỐ VẤN HỌC TẬP NĂM HỌC " + cboNamHoc.EditValue.ToString();
                        if (cboHocKy.EditValue.ToString().Contains("HK01; HK02"))
                            tuaDe += "";
                        else tuaDe += " - " + cboHocKy.EditValue.ToString();
                             
                        frm.InBangChiTienCoVan(PMS.Common.Globals._cauhinh.TenTruong.ToUpper(), PMS.Common.Globals._cauhinh.KeToan, PMS.Common.Globals._cauhinh.NguoiLapbieu, PMS.Common.Globals._cauhinh.PhongDaoTao, tuaDe, vList);
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