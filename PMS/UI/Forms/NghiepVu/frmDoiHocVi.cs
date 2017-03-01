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
    public partial class frmDoiHocVi : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        public int MaGiangVien;
        ViewGiangVien vGiangVien = new ViewGiangVien();
        #endregion
        public frmDoiHocVi()
        {
            InitializeComponent();
        }

        public frmDoiHocVi(int maGiangVien)
        {
            this.MaGiangVien = maGiangVien;
            InitializeComponent();
        }

        private void frmDoiHocVi_Load(object sender, EventArgs e)
        {
            vGiangVien = DataServices.ViewGiangVien.Get("MaGiangVien = " + this.MaGiangVien, "MaGiangVien")[0];
            txtMaGiangVien.Text = vGiangVien.MaQuanLy;
            txtHoTen.Text = vGiangVien.HoTen;
            txtHocViHienTai.Text = vGiangVien.TenHocVi;

            AppGridLookupEdit.InitGridLookUp(cboHocViMoi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocViMoi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            cboHocViMoi.Properties.ValueMember = "MaHocVi";
            cboHocViMoi.Properties.DisplayMember = "TenHocVi";
            cboHocViMoi.Properties.NullText = string.Empty;
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();

            dateEditNgayHieuLuc.Text = DateTime.Now.ToShortDateString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboHocViMoi.EditValue == null)
            {
                XtraMessageBox.Show("Hãy chọn học vị mới cho giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                int kq = 0;
                DataServices.GiangVienThayDoiHocVi.Luu(vGiangVien.MaGiangVien, (int)vGiangVien.MaHocVi, int.Parse(cboHocViMoi.EditValue.ToString()), dateEditNgayHieuLuc.DateTime, DateTime.Now, UserInfo.UserName, ref kq);
                if (kq == 0)
                    XtraMessageBox.Show("Thay đổi học vị thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Thay đổi học vị thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}