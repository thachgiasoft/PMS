using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    public partial class frmChonDieuKienImport : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        string NamHoc, HocKy, MaLoaiHinhDaoTao, MaTruong;
        int DotThanhToan;
        #endregion

        #region Event Form
        public frmChonDieuKienImport()
        {
            InitializeComponent();
        }

        public frmChonDieuKienImport(string _maTruong, string _namHoc, string _hocKy, string _maLoaiHinhDaoTao, int _dotThanhToan)
        {
            InitializeComponent();

            NamHoc = _namHoc;
            HocKy = _hocKy;
            MaLoaiHinhDaoTao = _maLoaiHinhDaoTao;
            DotThanhToan = _dotThanhToan;
            MaTruong = _maTruong;
        }

        private void frmChonDieuKienImport_Load(object sender, EventArgs e)
        {

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.Properties.BestFitMode = BestFitMode.BestFit;
            #endregion
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.Properties.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region LoaiHinhDaoTao
            AppGridLookupEdit.InitGridLookUp(cboLoaiHinhDaoTao, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiHinhDaoTao, new string[] { "MaLoaiHinh", "TenLoaiHinh" }, new string[] { "Mã loại hình đào tạo", "Tên loại hình đào tạo" });
            cboLoaiHinhDaoTao.Properties.ValueMember = "MaLoaiHinh";
            cboLoaiHinhDaoTao.Properties.DisplayMember = "TenLoaiHinh";
            cboLoaiHinhDaoTao.Properties.NullText = string.Empty;
            cboLoaiHinhDaoTao.Properties.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region _dotThanhToan
            AppGridLookupEdit.InitGridLookUp(cboDotThanhToan, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotThanhToan, new string[] { "MaQuanLy", "TenQuanLy" }, new string[] { "Mã đợt", "Tên đợt" });
            cboDotThanhToan.Properties.ValueMember = "MaCauHinhChotGio";
            cboDotThanhToan.Properties.DisplayMember = "TenQuanLy";
            cboDotThanhToan.Properties.NullText = string.Empty;
            cboDotThanhToan.Properties.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region LoadDataSource
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            bindingSourceLoaiHinhDaoTao.DataSource = DataServices.ViewLoaiHinhDaoTao.GetAll();

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDotThanhToan.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

            cboNamHoc.EditValue = NamHoc;
            cboHocKy.EditValue = HocKy;
            cboLoaiHinhDaoTao.EditValue = MaLoaiHinhDaoTao;
            cboDotThanhToan.EditValue = DotThanhToan;
            #endregion
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDotThanhToan.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDotThanhToan.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        #region Event Cbo
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLoaiHinhDaoTao.EditValue != null && cboDotThanhToan.EditValue != null)
            {
                using (frmImportThanhToanThuLao frm = new frmImportThanhToanThuLao(MaTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString())))
                {
                    frm.ShowDialog();
                }

                Close();
            }
        }
        #endregion
    }
}