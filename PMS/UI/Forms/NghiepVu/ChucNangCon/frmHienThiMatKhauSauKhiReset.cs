using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    public partial class frmHienThiMatKhauSauKhiReset : DevExpress.XtraEditors.XtraForm
    {
        VList<ViewThongTinGiangVien> ListGiangVien = new VList<ViewThongTinGiangVien>();

        public frmHienThiMatKhauSauKhiReset()
        {
            InitializeComponent();
        }

        public frmHienThiMatKhauSauKhiReset(VList<ViewThongTinGiangVien> _list)
        {
            InitializeComponent();
            ListGiangVien = _list;
        }

        private void frmHienThiMatKhauSauKhiReset_Load(object sender, EventArgs e)
        {
            txtMaQuanLy.Text = ListGiangVien[0].MaQuanLy;
            txtHoTen.Text = ListGiangVien[0].HoTen;
            txtMatKhauMoi.Text = ListGiangVien[0].MatKhau;
            txtMatKhauMoi.Focus();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtMatKhauMoi.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (PMS.UI.Forms.BaoCao.frmBaoCao frm = new BaoCao.frmBaoCao())
                {
                    if (PMS.Common.Globals._cauhinh != null)
                    {
                        frm.InCapAccount(PMS.Common.Globals._cauhinh.TenTruong.ToUpper(), ListGiangVien);
                        frm.ShowDialog();
                    }
                }
            }
            catch 
            { }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}