using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PMS.UI.Forms.NghiepVu.FormXuLy
{
    public partial class frmChonNgay : DevExpress.XtraEditors.XtraForm
    {
        public DateTime NgayIn;
        public frmChonNgay()
        {
            InitializeComponent();
        }

        private void frmChonNgay_Load(object sender, EventArgs e)
        {
            dateEditChonNgay.DateTime = DateTime.Now;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            NgayIn = dateEditChonNgay.DateTime;
            if (dateEditChonNgay.Text == "")
                NgayIn = DateTime.MinValue;
            Close();
        }
    }
}