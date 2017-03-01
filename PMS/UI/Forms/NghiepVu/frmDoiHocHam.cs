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
    public partial class frmDoiHocHam : DevExpress.XtraEditors.XtraForm
    {
        public int MaGiangVien;
        ViewGiangVien vGiangVien = new ViewGiangVien();
        public frmDoiHocHam()
        {
            InitializeComponent();
        }

        public frmDoiHocHam(int maGiangVien)
        {
            this.MaGiangVien = maGiangVien;
            InitializeComponent();
        }
        
        private void frmDoiHocHam_Load(object sender, EventArgs e)
        {
            vGiangVien = DataServices.ViewGiangVien.Get("MaGiangVien = " + this.MaGiangVien, "MaGiangVien")[0];
            txtMaQuanLy.Text = vGiangVien.MaQuanLy;
            txtTenGiangVien.Text = vGiangVien.HoTen;
            txtHocHamHienTai.Text = vGiangVien.TenHocHam;

            AppGridLookupEdit.InitGridLookUp(cboHocHamMoi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocHamMoi, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            cboHocHamMoi.Properties.ValueMember = "MaHocHam";
            cboHocHamMoi.Properties.DisplayMember = "TenHocHam";
            cboHocHamMoi.Properties.NullText = string.Empty;
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();

            dateEditNgayHieuLuc.Text = DateTime.Now.ToShortDateString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboHocHamMoi.EditValue == null)
            {
                XtraMessageBox.Show("Hãy chọn học hàm mới cho giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                int kq = 0;
                DataServices.GiangVienThayDoiHocHam.Luu(vGiangVien.MaGiangVien, (int)PMS.Common.Globals.IsNull(vGiangVien.MaHocHam, "int"), int.Parse(cboHocHamMoi.EditValue.ToString()), dateEditNgayHieuLuc.DateTime, DateTime.Now, UserInfo.UserName, ref kq);
                if (kq == 0)
                    XtraMessageBox.Show("Thay đổi học hàm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Thay đổi học hàm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}