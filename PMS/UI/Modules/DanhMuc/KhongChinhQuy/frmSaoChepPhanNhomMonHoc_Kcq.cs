using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.Grid;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc.KhongChinhQuy
{
    public partial class frmSaoChepPhanNhomMonHoc_Kcq : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        string NamHoc, HocKy;
        #endregion
        public frmSaoChepPhanNhomMonHoc_Kcq()
        {
            InitializeComponent();
        }

        public frmSaoChepPhanNhomMonHoc_Kcq(string _namHoc, string _hocKy)
        {
            InitializeComponent();
            NamHoc = _namHoc;
            HocKy = _hocKy;
        }

        private void frmSaoChepPhanNhomMonHoc_Load(object sender, EventArgs e)
        {
            #region Nam hoc nguon
            AppGridLookupEdit.InitGridLookUp(cboNamHocNguon, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHocNguon, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHocNguon.Properties.ValueMember = "NamHoc";
            cboNamHocNguon.Properties.DisplayMember = "NamHoc";
            cboNamHocNguon.Properties.NullText = string.Empty;
            cboNamHocNguon.EditValue = NamHoc;
            #endregion

            #region _hocKy nguon
            AppGridLookupEdit.InitGridLookUp(cboHocKyNguon, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKyNguon, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKyNguon.Properties.DisplayMember = "TenHocKy";
            cboHocKyNguon.Properties.ValueMember = "MaHocKy";
            cboHocKyNguon.Properties.NullText = string.Empty;
            cboHocKyNguon.EditValue = HocKy;
            #endregion
            #region Nam hoc dich
            AppGridLookupEdit.InitGridLookUp(cboNamHocDich, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHocDich, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHocDich.Properties.ValueMember = "NamHoc";
            cboNamHocDich.Properties.DisplayMember = "NamHoc";
            cboNamHocDich.Properties.NullText = string.Empty;
            #endregion

            #region _hocKy dich
            AppGridLookupEdit.InitGridLookUp(cboHocKyDich, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKyDich, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKyDich.Properties.DisplayMember = "TenHocKy";
            cboHocKyDich.Properties.ValueMember = "MaHocKy";
            cboHocKyDich.Properties.NullText = string.Empty;
            #endregion

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHocNguon.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHocNguon.EditValue.ToString());
            bindingSourceNamHocDich.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHocDich.EditValue != null)
                bindingSourceHocKyDich.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHocDich.EditValue.ToString());
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                {
                    DataServices.KcqPhanNhomMonHoc.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                    XtraMessageBox.Show("Sao chép thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboNamHocDich.Focus();
                }
            }
            catch
            {
                XtraMessageBox.Show("Sao chép dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboNamHocNguon_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocNguon.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHocNguon.EditValue.ToString());
        }

        private void cboNamHocDich_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocDich.EditValue != null)
                bindingSourceHocKyDich.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHocDich.EditValue.ToString());
        }
    }
}