using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu.KhongChinhQuy
{
    public partial class frmXuLyQuyDoiGioiChuanUTE_Kcq : XtraForm
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

        public frmXuLyQuyDoiGioiChuanUTE_Kcq(string _namHoc, string _hocKy, int _maGiangVien)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            _inputParameter.MaGiangVien = _maGiangVien;
        }

        public frmXuLyQuyDoiGioiChuanUTE_Kcq(string _namHoc, string _hocKy)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
        }
        public frmXuLyQuyDoiGioiChuanUTE_Kcq(string _namHoc, string _hocKy, bool _quyCheMoi)
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
            #region
            ////Init
            //int index = 1;
            //string _namHoc = ((DataParameter)e.Argument)._namHoc;
            //string _hocKy = ((DataParameter)e.Argument)._hocKy;
            //int MaGiangVien = ((DataParameter)e.Argument).MaGiangVien;
            //try
            //{
            //    //Lay lop hoc phan giang vien day
            //    VList<ViewKetQuaTinh> vKetqua = DataServices.ViewKetQuaTinh.GetByNamHocHocKy(_namHoc, _hocKy);
            //    int process = vKetqua.Count;
            //    foreach (ViewKetQuaTinh vk in vKetqua)
            //    {
            //        if (!backgroundWorker.CancellationPending)
            //        {
            //            backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("Mã số {0}", vk.MaKetQua));
            //            VList<ViewXuLyQuyDoi> vXuLy = DataServices.ViewXuLyQuyDoi.GetByMaKetQua(vk.MaKetQua);
            //            TList<KhoiLuongGiangDay> listKhoiLuong = DataServices.KhoiLuongGiangDay.GetByMaKetQua(vk.MaKetQua);
            //            //Cap nhat ket qua tinh
            //            KetQuaTinh objKetQua = DataServices.KetQuaTinh.GetByMaKetQua(vk.MaKetQua);
            //            if (objKetQua != null)
            //            {
            //                objKetQua.TietNghiaVu = vk.TietNghiaVu;
            //                objKetQua.TietGioiHan = vk.TietGioiHan;
            //                objKetQua.DonGia = vk.DonGia;
            //                objKetQua.NgayTao = DateTime.Now.Date;
            //                DataServices.KetQuaTinh.Update(objKetQua);
            //            }
            //            //Cap nhat quy doi khoi luong
            //            foreach (ViewXuLyQuyDoi vx in vXuLy)
            //            {
            //                KhoiLuongGiangDay obj = listKhoiLuong.Find(p => p.MaKhoiLuong == vx.MaKhoiLuong);
            //                if (obj != null)
            //                {
            //                    if (obj.ChatLuongCao != null)
            //                    {
            //                        decimal _heSo = vx.HeSoLopDong * vx.HeSoThanhPhan * vx.HeSoCoSo * vx.HeSoHocKy;
            //                        obj.TietQuyDoi = obj.ChatLuongCao * _heSo;
            //                    }
            //                    else
            //                    {
            //                        decimal _heSo = vx.HeSoLopDong * vx.HeSoThanhPhan * vx.HeSoCoSo * vx.HeSoHocKy;
            //                        decimal _trongGio = obj.TrongGio.Value * (_heSo * vx.HeSoTrongGio);
            //                        decimal _ngoaiGio = obj.NgoaiGio.Value * (_heSo * vx.HeSoNgoaiGio);
            //                        obj.TietQuyDoi = _trongGio + _ngoaiGio;
            //                    }
            //                }
            //            }
            //            //Luu lai du lieu
            //            DataServices.KhoiLuongGiangDay.Update(listKhoiLuong);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    backgroundWorker.CancelAsync();
            //    XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            #endregion
            try
            {
                if (((DataParameter)e.Argument).QuyCheMoi == true)
                {
                    DataServices.KcqUteKhoiLuongQuyDoi.QuyDoiTheoNamHocHocKyQuyCheMoi(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
                    DataServices.KcqUteKhoiLuongQuyDoi.QuyDoiTheoNamHocHocKy(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
                    DataServices.KcqUteThanhToanThuLao.ThanhToan(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
                }
                else
                {
                    DataServices.KcqUteKhoiLuongQuyDoi.QuyDoiTheoNamHocHocKy(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
                    DataServices.KcqUteThanhToanThuLao.ThanhToan(((DataParameter)e.Argument).NamHoc, ((DataParameter)e.Argument).HocKy);
                }
            }
            catch
            {
                //Xem đơn giá có bị trùng hay ko (học vị null)
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static decimal? TinhHeSo(TList<KcqQuyDoiGioChuan> listQuyDoiGioChuan, VList<ViewKhoiLuongGiangDay> vListChiTiet)
        {
            //Tinh he so quy doi
            KcqQuyDoiGioChuan objQuyDoi = listQuyDoiGioChuan.Find(p => p.MaQuanLy == vListChiTiet[0].LoaiHocPhan);
            if (objQuyDoi != null)
            {
                foreach (KcqKhoanQuyDoi k in DataServices.KcqKhoanQuyDoi.GetByMaQuyDoi(objQuyDoi.MaQuyDoi))
                {
                    if (k.DenKhoan != null)
                    {
                        if (vListChiTiet[0].SoLuong > k.TuKhoan && vListChiTiet[0].SoLuong < k.DenKhoan)
                            return k.HeSo;
                    }
                    else
                    {
                        if (vListChiTiet[0].SoLuong > k.TuKhoan)
                            return k.HeSo;
                    }
                }
            }
            return 1;
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