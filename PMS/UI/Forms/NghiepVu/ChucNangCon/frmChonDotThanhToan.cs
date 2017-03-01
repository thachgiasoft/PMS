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

namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    public partial class frmChonDotThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public bool XacNhan;
        string NamHoc, HocKy;
        public string IdDot;

        public frmChonDotThanhToan()
        {
            InitializeComponent();
        }

        public frmChonDotThanhToan(string _namHoc, string _hocKy)
        {
            NamHoc = _namHoc;
            HocKy = _hocKy;
            InitializeComponent();
        }

        private void frmChonDotThanhToan_Load(object sender, EventArgs e)
        {
            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboDotThanhToan, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotThanhToan, new string[] { "ThuTu", "MaDotChiTra", "TenDotChiTra" }, new string[] { "Thứ tự", "Mã đợt", "Tên đợt" }, new int[] { 75, 85, 140 });
            AppGridLookupEdit.InitPopupFormSize(cboDotThanhToan, 300, 500);
            cboDotThanhToan.Properties.ValueMember = "Id";
            cboDotThanhToan.Properties.DisplayMember = "TenDotChiTra";
            cboDotThanhToan.Properties.NullText = string.Empty;
            #endregion

            bindingSourceDot.DataSource = DataServices.DotChiTra.GetByNamHocHocKy(NamHoc, HocKy);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cboDotThanhToan.EditValue != null)
            {
                IdDot = cboDotThanhToan.EditValue.ToString();
                XacNhan = true;
                Close();
                Dispose();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn đợt thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDotThanhToan.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            XacNhan = false;
            Close();
            Dispose();
        }
    }
}