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
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmDoiChucVu : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        public int MaGiangVien;
        ViewGiangVien vGiangVien = new ViewGiangVien();
        #endregion
        public frmDoiChucVu()
        {
            InitializeComponent();
        }

        public frmDoiChucVu(int maGiangVien)
        {
            this.MaGiangVien = maGiangVien;
            InitializeComponent();
        }

        private void frmDoiChucVu_Load(object sender, EventArgs e)
        {
            vGiangVien = DataServices.ViewGiangVien.Get("MaGiangVien = " + this.MaGiangVien, "MaGiangVien")[0];
            txtMaGiangVien.Text = vGiangVien.MaQuanLy;
            txtHoTen.Text = vGiangVien.HoTen;
            txtChucVuCu.Text = vGiangVien.TenHocVi;

            AppGridLookupEdit.InitGridLookUp(cboChucVuMoi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboChucVuMoi, new string[] { "MaQuanLy", "TenChucVu" }, new string[] { "Mã chức vụ", "Tên chức vụ" });
            cboChucVuMoi.Properties.ValueMember = "MaChucVu";
            cboChucVuMoi.Properties.DisplayMember = "TenChucVu";
            cboChucVuMoi.Properties.NullText = string.Empty;
            bindingSourceChucVu.DataSource = DataServices.ChucVu.GetAll();

            dateEditNgayHieuLuc.Text = DateTime.Now.ToShortDateString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                int kq = 0;
                //DataServices.GiangVienThayDoiChucVu.Luu(vGiangVien.MaGiangVien, (int)vGiangVien.MaHocVi, int.Parse(cboChucVuMoi.EditValue.ToString()), dateEditNgayHieuLuc.DateTime, DateTime.Now, UserInfo.UserName, ref kq);
                if (kq == 0)
                    XtraMessageBox.Show("Thay đổi chức vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Thay đổi chức vụ thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}