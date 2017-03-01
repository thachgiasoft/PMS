using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmDongBoDuLieuDoAnUIS : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        string NamHoc, HocKy;
        string Loai;
        #endregion
        public frmDongBoDuLieuDoAnUIS()
        {
            InitializeComponent();
        }

        public frmDongBoDuLieuDoAnUIS(string _namHoc, string _hocKy)
        {
            InitializeComponent();
            NamHoc = _namHoc;
            HocKy = _hocKy;
        }

        public frmDongBoDuLieuDoAnUIS(string _namHoc, string _hocKy, string _loai)
        {
            InitializeComponent();
            NamHoc = _namHoc;
            HocKy = _hocKy;
            Loai = _loai;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (Loai == "DATN")
                    DataServices.KhoiLuongGiangDayDoAnTotNghiep.DongBo(NamHoc, HocKy);
                if(Loai == "DAMH")
                    DataServices.KhoiLuongGiangDayDoAn.DongBo(NamHoc, HocKy);
            }
            catch
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarControl1.Position = e.ProgressPercentage;
            //lblUserState.Text = e.UserState.ToString();
            progressBarControl1.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            XtraMessageBox.Show("Đã hoàn tất lấy dữ liệu đồ án môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void frmDongBoDuLieuDoAnUIS_Load(object sender, EventArgs e)
        {
            progressBarControl1.Properties.Minimum = 0;
            progressBarControl1.Position = 0;
            //Do worker
            backgroundWorker1.RunWorkerAsync();
        }
    }
}