using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu.SauDaiHoc
{
    public partial class frmXuLyQuyDoiGioiChuanUTE_SDH : XtraForm
    {
        private DataParameter _inputParameter;

        /// <summary>
        /// Input param
        /// </summary>
        public struct DataParameter
        {
            public string NamHoc;
            public string HocKy;
            public int MaGiangVien;
            public bool QuyCheMoi;
        }

        public frmXuLyQuyDoiGioiChuanUTE_SDH(string _namHoc, string _hocKy, int _maGiangVien)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            _inputParameter.MaGiangVien = _maGiangVien;
        }

        public frmXuLyQuyDoiGioiChuanUTE_SDH(string _namHoc, string _hocKy)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
        }
        public frmXuLyQuyDoiGioiChuanUTE_SDH(string _namHoc, string _hocKy, bool _quyCheMoi)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            _inputParameter.QuyCheMoi = _quyCheMoi;
        }
        /// <summary>
        /// DoWork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
       
            try
            {
                    DataServices.SdhUteKhoiLuongQuyDoi.QuyDoiTheoNamHocHocKy(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
                    DataServices.SdhUteThanhToanThuLao.ThanhToan(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
            }
            catch
            {
                //Xem đơn giá có bị trùng hay ko (học vị null)
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Position = e.ProgressPercentage;
            lblTenHoiDong.Text = e.UserState.ToString();
            progressBar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            XtraMessageBox.Show("Đã hoàn tất quy đổi khối lượng giảng dạy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void frmXuLyQuyDoiGioiChuanUTE_SDH_Load(object sender, EventArgs e)
        {
            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;
            //Do worker
            backgroundWorker.RunWorkerAsync(_inputParameter);
        }
    }
}