using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmLayDuLieuDoAn : XtraForm
    {
        private DataParameter _inputParameter;

        /// <summary>
        /// Input param
        /// </summary>
        public struct DataParameter
        {
            public string NamHoc;
            public string HocKy;
        }

        public frmLayDuLieuDoAn(string _namHoc, string _hocKy)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
        }

        /// <summary>
        /// DoWork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //Init
            //int index = 1;
            string NamHoc = ((DataParameter)e.Argument).NamHoc;
            string HocKy = ((DataParameter)e.Argument).HocKy;
            //try
            //{
            //    //Nhan danh sach lop dai dien cua cua _loai hoc phan do an mon hoc
            //    VList<ViewLopDaiDien> vLopDaiDien = DataServices.ViewLopDaiDien.GetByNamHocHocKy(_namHoc, _hocKy);
            //    VList<ViewChiTietKhoiLuongGiangDay> vKhoiLuongGiangDay = DataServices.ViewChiTietKhoiLuongGiangDay.GetByNamHocHocKy(_namHoc, _hocKy);
            //    TList<KhoiLuongKhac> listKhoiLuong = DataServices.KhoiLuongKhac.GetByNamHocHocKyPhanLoai(_namHoc, _hocKy, 2);
            //    int process = vLopDaiDien.Count;
            //    foreach (ViewLopDaiDien vl in vLopDaiDien)
            //    {
            //        if (!backgroundWorker.CancellationPending)
            //        {
            //            backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("Mã môn học {0}", vl.MaMonHoc));
            //            KhoiLuongKhac obj = listKhoiLuong.Find(p => p.MaMonHoc.Trim() == vl.MaMonHoc.Trim() && p.MaNhom.Trim() == vl.MaNhom.Trim() && p.MaGiangVien == vl.MaGiangVien);
            //            if (obj == null)
            //                obj = new KhoiLuongKhac() { MaGiangVien = vl.MaGiangVien, MaMonHoc = vl.MaMonHoc, LoaiHocPhan = vl.LoaiHocPhan, MaNhom = vl.MaNhom, DonGia = vl.DonGia };
            //            obj.SoLuong = 0;
            //            foreach (ViewChiTietKhoiLuongGiangDay v in vKhoiLuongGiangDay.FindAll(p => p.MaMonHoc.Trim() == vl.MaMonHoc.Trim() && p.MaGiangVien == vl.MaGiangVien))
            //            {
            //                if (obj.MaNhom.Trim() == v.Nhom.Trim())
            //                {
            //                    obj.MaLopHocPhan = v.MaLopHocPhan;
            //                    obj.MaLop = v.MaLop;
            //                    obj.PhanLoai = 2;
            //                    obj._namHoc = _namHoc;
            //                    obj._hocKy = _hocKy;
            //                    obj.NgayTao = DateTime.Now.Date;
            //                    obj.SoLuong += v.SoLuong;
            //                    obj.SoTiet = v.SoTiet;
            //                }
            //                else
            //                    obj.SoLuong += v.SoLuong;
            //            }
            //            if (obj.IsNew)
            //                listKhoiLuong.Add(obj);
            //        }
            //    }
            //    DataServices.KhoiLuongKhac.Save(listKhoiLuong);
            //}
            //catch (Exception ex)
            //{
            //    backgroundWorker.CancelAsync();
            //    XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            try
            {
                DataServices.KhoiLuongKhac.LayDuLieuDoAn(NamHoc, HocKy);
            }
            catch
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            XtraMessageBox.Show("Đã hoàn tất lấy dữ liệu đồ án môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void frmXuLyTinhThanhToanGioGiang_Load(object sender, EventArgs e)
        {
            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;
            //Do worker
            backgroundWorker.RunWorkerAsync(_inputParameter);
        }
    }
}