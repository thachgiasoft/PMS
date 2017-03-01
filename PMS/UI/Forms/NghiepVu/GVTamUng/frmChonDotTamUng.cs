using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PMS.UI.Forms.NghiepVu.GVTamUng
{
    public partial class frmChonDotTamUng : DevExpress.XtraEditors.XtraForm
    {
        public string TenDotTamUng;
        public DateTime NgayTamUng;
        public bool XacNhan;

        public frmChonDotTamUng()
        {
            InitializeComponent();
        }

        private void frmChonDotTamUng_Load(object sender, EventArgs e)
        {
            dateEditNgayTamUng.DateTime = DateTime.Now;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            TenDotTamUng = txtTenDotTamUng.Text;
            NgayTamUng = dateEditNgayTamUng.DateTime;
            XacNhan = true;
            Close();
            Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            XacNhan = false;
            Close();
            Dispose();
        }
    }
}