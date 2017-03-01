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
    public partial class frmDoiLoaiGiangVien : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        public int MaGiangVien;
        ViewGiangVien vGiangVien = new ViewGiangVien();
        #endregion
        public frmDoiLoaiGiangVien()
        {
            InitializeComponent();
        }
        public frmDoiLoaiGiangVien(int maGiangVien)
        {
            MaGiangVien = maGiangVien;
            InitializeComponent();
        }

        private void frmDoiLoaiGiangVien_Load(object sender, EventArgs e)
        {
            vGiangVien = DataServices.ViewGiangVien.Get("MaGiangVien = " + MaGiangVien, "MaGiangVien")[0];
            txtMaGiangVien.Text = vGiangVien.MaQuanLy;
            txtHoTen.Text = vGiangVien.HoTen;
            txtLoaiGVHienTai.Text = vGiangVien.TenLoaiGiangVien;

            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVienMoi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVienMoi, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" });
            cboLoaiGiangVienMoi.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVienMoi.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVienMoi.Properties.NullText = string.Empty;
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();

            dateEditNgayHieuLuc.Text = DateTime.Now.ToShortDateString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboLoaiGiangVienMoi.EditValue == null)
            {
                XtraMessageBox.Show("Hãy chọn loại giảng viên mới cho giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                int kq = 0;
                DataServices.GiangVienThayDoiLoaiGiangVien.Luu(vGiangVien.MaGiangVien, (int)PMS.Common.Globals.IsNull(vGiangVien.MaLoaiGiangVien, "int"), int.Parse(cboLoaiGiangVienMoi.EditValue.ToString()), dateEditNgayHieuLuc.DateTime, DateTime.Now, UserInfo.UserName, ref kq);
                if (kq == 0)
                    XtraMessageBox.Show("Thay đổi loại giảng viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}