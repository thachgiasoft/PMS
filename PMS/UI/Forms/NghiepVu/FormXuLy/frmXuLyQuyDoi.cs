using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu.FormXuLy
{
    public partial class frmXuLyQuyDoi : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        private string NamHoc, HocKy, MaTruong;
        int q;
        #endregion
        public frmXuLyQuyDoi()
        {
            InitializeComponent();
        }

        public frmXuLyQuyDoi(string namHoc, string hocKy, string maTruong)
        {
            InitializeComponent();
            NamHoc = namHoc;
            HocKy = hocKy;
            MaTruong = maTruong;
        }

        private void frmXuLyQuyDoi_Load(object sender, EventArgs e)
        {
            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;
            marqueeProgressBarControl1.Text = "Đang xử lý...";

            //Do worker
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (MaTruong == "USSH" || MaTruong == "ACT")
            {
                int kiemtra = 0;
                DataServices.HuongDanKhoaLuanThucTap.KiemTra(NamHoc, HocKy, ref kiemtra);
                if (kiemtra == 1)
                {
                    if (XtraMessageBox.Show(string.Format("Khối lượng giảng dạy của năm học {0} - {1} đã được quy đổi. Quy đổi lại sẽ xoá dữ liệu cũ. \nBạn có muốn quy đổi hay không?", NamHoc, HocKy), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataServices.HuongDanKhoaLuanThucTap.QuyDoi(NamHoc, HocKy);
                        q = 1;
                    }
                }
                else
                {
                    DataServices.HuongDanKhoaLuanThucTap.QuyDoi(NamHoc, HocKy);
                    q = 1;
                }
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
            if (q == 1)
                XtraMessageBox.Show("Đã hoàn tất việc quy đổi dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}