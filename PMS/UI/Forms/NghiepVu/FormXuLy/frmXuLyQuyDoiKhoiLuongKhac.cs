using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXuLyQuyDoiKhoiLuongKhac : XtraForm
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
        }

        public frmXuLyQuyDoiKhoiLuongKhac(string _namHoc, string _hocKy, int _maGiangVien)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            _inputParameter.MaGiangVien = _maGiangVien;
        }

        /// <summary>
        /// DoWork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //Init
            int index = 1;
            string NamHoc = ((DataParameter)e.Argument).NamHoc;
            string HocKy = ((DataParameter)e.Argument).HocKy;
            int MaGiangVien = ((DataParameter)e.Argument).MaGiangVien;
            try
            {
                //Lay lop hoc phan giang vien day
                TList<QuyDoiGioChuan> listQuyDoiGioChuan = DataServices.QuyDoiGioChuan.GetAll();
                TList<KhoiLuongKhac> listKhoiLuongKhac = DataServices.KhoiLuongKhac.GetByNamHocHocKyPhanLoaiMaGiangVien(NamHoc, HocKy, 2, MaGiangVien);
                int process = listKhoiLuongKhac.Count;
                foreach (KhoiLuongKhac vk in listKhoiLuongKhac)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("Mã môn học {0}", vk.MaMonHoc));
                        //vk.SoTiet = TinhHeSo(listQuyDoiGioChuan, vk);
                        //vk.TietQuyDoi = vk.SoTiet;
                        vk.TietQuyDoi = TinhHeSo(listQuyDoiGioChuan, vk);
                        vk.NgayTao = DateTime.Now.Date;
                        if (vk.IsValid)
                            DataServices.KhoiLuongKhac.Update(vk);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static decimal? TinhHeSo(TList<QuyDoiGioChuan> listQuyDoiGioChuan, KhoiLuongKhac objKhoiLuongKhac)
        {
            decimal? _heso = 0;
            //Tinh he so quy doi
            QuyDoiGioChuan objQuyDoi = listQuyDoiGioChuan.Find(p => p.MaQuanLy == objKhoiLuongKhac.LoaiHocPhan);
            if (objQuyDoi != null)
            {
                //Lay danh sach khoan quy doi
                TList<KhoanQuyDoi> listKhoanQuyDoi = DataServices.KhoanQuyDoi.GetByMaQuyDoi(objQuyDoi.MaQuyDoi);
                listKhoanQuyDoi.Sort("ThuTu ASC");
                //-----Loop-----
                if (listKhoanQuyDoi.Count > 0)
                {
                    foreach (KhoanQuyDoi k in listKhoanQuyDoi)
                    {
                        if (objQuyDoi.CongDon == true)
                        {
                            if (k.DenKhoan != null && objKhoiLuongKhac.SoLuong >= k.TuKhoan && objKhoiLuongKhac.SoLuong <= k.DenKhoan)
                            {
                                if (_heso > 0)
                                {
                                    if (objKhoiLuongKhac.SoLuong == k.DenKhoan)
                                        return _heso += (k.DenKhoan - k.TuKhoan + 1) * k.HeSo;
                                    else
                                        return _heso += (objKhoiLuongKhac.SoLuong - k.TuKhoan + 1) * k.HeSo;
                                }
                                else
                                    return _heso = k.HeSo * objKhoiLuongKhac.SoLuong;
                            }
                            else if (k.DenKhoan != null && objKhoiLuongKhac.SoLuong >= k.DenKhoan)
                                _heso += (k.DenKhoan - k.TuKhoan + 1) * k.HeSo;
                            else if (k.DenKhoan == null && objKhoiLuongKhac.SoLuong >= k.TuKhoan)
                                _heso += (objKhoiLuongKhac.SoLuong - k.TuKhoan + 1) * k.HeSo;
                        }
                        else
                        {
                            if (k.DenKhoan != null && objKhoiLuongKhac.SoLuong >= k.TuKhoan && objKhoiLuongKhac.SoLuong <= k.DenKhoan)
                                return k.HeSo * objKhoiLuongKhac.SoLuong;
                            else if (k.DenKhoan == null && objKhoiLuongKhac.SoLuong >= k.TuKhoan)
                                return objKhoiLuongKhac.SoLuong * k.HeSo;
                        }
                    }
                }
                else
                {
                    if (objKhoiLuongKhac.SoTuan != null && objKhoiLuongKhac.SoTuan > 0)
                        _heso = objQuyDoi.HeSo * objKhoiLuongKhac.SoLuong * objKhoiLuongKhac.SoTuan;
                    else
                        _heso = objQuyDoi.HeSo * objKhoiLuongKhac.SoLuong;
                }
            }
            return _heso;
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

        private void frmXuLyTinhThanhToanGioGiang_Load(object sender, EventArgs e)
        {
            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;
            //Do worker
            backgroundWorker.RunWorkerAsync(_inputParameter);
        }
    }
}