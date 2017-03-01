using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXuLyTinhKhoiLuongGiangDay : XtraForm
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

        public frmXuLyTinhKhoiLuongGiangDay(string _namHoc, string _hocKy, int _maGiangVien)
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
            TList<HeSoNgay> listHeSoNgay = DataServices.HeSoNgay.GetAll();
            TList<QuyDoiGioChuan> listQuyDoiGioChuan = DataServices.QuyDoiGioChuan.GetAll();
            try
            {
                //Lay lop hoc phan giang vien day...
                VList<ViewGiangVienLopHocPhan> vListGiangVien = DataServices.ViewGiangVienLopHocPhan.GetByNamHocHocKyMaGiangVien(NamHoc, HocKy, MaGiangVien);
                int process = vListGiangVien.Count;
                foreach (ViewGiangVienLopHocPhan vGiangVien in vListGiangVien)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("Lớp học phần {0}", vGiangVien.MaLopHocPhan));
                        //Lay chi tiet lop hoc phan...
                        TList<KhoiLuongGiangDayChiTiet> vListChiTiet = DataServices.KhoiLuongGiangDayChiTiet.GetByMaGiangVienMaLopHocPhanMaLop(vGiangVien.MaQuanLy, vGiangVien.MaLopHocPhan, vGiangVien.MaKhoaHoc);
                        decimal? _heSoLopDong = 1;
                        if (vListChiTiet.Count > 0)
                        {
                            switch (vListChiTiet[0].PhanLoai)
                            {
                                case "LT":
                                    _heSoLopDong = TinhHeSo(listQuyDoiGioChuan, vListChiTiet);
                                    break;
                            }

                            //Get parent
                            KetQuaTinh objKetQua = DataServices.KetQuaTinh.GetByMaGiangVienNamHocHocKy(vGiangVien.MaGiangVien, vGiangVien.NamHoc, vGiangVien.HocKy);
                            if (objKetQua == null)
                            {
                                objKetQua = new KetQuaTinh() { MaGiangVien = vGiangVien.MaGiangVien, NamHoc = vGiangVien.NamHoc, HocKy = vGiangVien.HocKy };
                                //Luu ket qua tinh...
                                DataServices.KetQuaTinh.Insert(objKetQua);
                            }

                            //Chi tiet ke qua tinh...
                            TList<KhoiLuongGiangDay> listKhoiLuong = DataServices.KhoiLuongGiangDay.GetByMaKetQua(objKetQua.MaKetQua);
                            KhoiLuongGiangDay objKhoiLuong = listKhoiLuong.Find(p => p.MaLopHocPhan.Trim() == vGiangVien.MaLopHocPhan.Trim());
                            if (objKhoiLuong == null)
                                objKhoiLuong = new KhoiLuongGiangDay() { MaKetQua = objKetQua.MaKetQua, NgayKetThuc = vGiangVien.NgayKetThuc, NgayBatDau = vGiangVien.NgayBatDau, HeSoLopDong = _heSoLopDong };

                            decimal? _trongGio = 0;
                            decimal? _ngoaiGio = 0;
                            decimal? _soTiet = 0;
                            decimal? _heSoTrongGio = 1;
                            decimal? _heSoNgoaiGio = 1;
                            foreach (KhoiLuongGiangDayChiTiet v in vListChiTiet)
                            {
                                if (listHeSoNgay.Exists(p => Convert.ToInt32(p.MaQuanLy) == v.MaBuoiHoc && v.TietBatDau >= p.TietBatDau && v.TietBatDau <= p.TietKetThuc))//DK 1
                                {
                                    HeSoNgay obj = listHeSoNgay.Find(p => Convert.ToInt32(p.MaQuanLy) == v.MaBuoiHoc && v.TietBatDau >= p.TietBatDau && v.TietBatDau <= p.TietKetThuc);
                                    if (obj.TrongGio == true)
                                    {
                                        if (v.TietBatDau + v.SoTiet <= obj.TietKetThuc)
                                        {
                                            _trongGio += v.SoTiet;
                                            _heSoTrongGio = obj.HeSo;
                                        }
                                        else
                                        {
                                            _trongGio += obj.TietKetThuc - v.TietBatDau;
                                            _ngoaiGio += v.SoTiet - (obj.TietKetThuc - v.TietBatDau);
                                            _heSoNgoaiGio = obj.HeSo;
                                        }
                                    }
                                    else
                                    {
                                        _ngoaiGio += v.SoTiet;
                                        _heSoNgoaiGio = obj.HeSo;
                                    }
                                }
                                //Cap nhat field...
                                objKhoiLuong.SoTinChi = v.SoTinChi;
                                objKhoiLuong.MaLopHocPhan = v.MaLopHocPhan;
                                objKhoiLuong.SiSoLop = v.SoLuong;
                                objKhoiLuong.MaNhom = v.Nhom;
                                objKhoiLuong.MaMonHoc = v.MaMonHoc;
                                objKhoiLuong.DienGiai = v.MaMonHoc;
                                objKhoiLuong.LoaiHocPhan = v.LoaiHocPhan;
                                objKhoiLuong.LoaiHocKy = v.LoaiHocKy;
                                objKhoiLuong.HeSoHocKy = v.HeSoHocKy;
                                objKhoiLuong.SoTiet = v.SoTinChi * 15;
                                if (objKhoiLuong.LoaiHocPhan == "TH")
                                {
                                    if (v.ThucHanh >= 45)
                                    {
                                        objKhoiLuong.HeSoThanhPhan = (decimal)0.6;
                                        objKhoiLuong.PhanLoai = "06";
                                    }
                                    else
                                    {
                                        objKhoiLuong.HeSoThanhPhan = (decimal)0.7;
                                        objKhoiLuong.PhanLoai = "07";
                                    }
                                    _soTiet = v.ThucHanh;
                                }
                                objKhoiLuong.MaLop = v.MaLop;
                                if (v.MaLop.Contains("CL"))
                                {
                                    if (objKhoiLuong.LoaiHocPhan == "TH")
                                        objKhoiLuong.ChatLuongCao = v.ThucHanh * 3;
                                    else
                                        objKhoiLuong.ChatLuongCao = objKhoiLuong.SoTiet * 3;
                                }
                            }
                            //Cap nhap gia tri tinh...
                            objKhoiLuong.TrongGio = _trongGio;
                            objKhoiLuong.NgoaiGio = _ngoaiGio;
                            objKhoiLuong.HeSoTrongGio = _heSoTrongGio;
                            objKhoiLuong.HeSoNgoaiGio = _heSoNgoaiGio;
                            objKhoiLuong.NgayTao = DateTime.Now.Date;
                            //Kiem tra trong gio, ngoai gio, giang he...
                            if (objKhoiLuong.TrongGio > 0 && objKhoiLuong.NgoaiGio == 0)//Trong gio
                            {
                                if (objKhoiLuong.LoaiHocPhan.Trim() != "TH")
                                {
                                    if (objKhoiLuong.TrongGio > objKhoiLuong.SoTinChi * 15)
                                        objKhoiLuong.TrongGio = objKhoiLuong.SoTinChi * 15;
                                }
                            }
                            else if (objKhoiLuong.NgoaiGio > 0 && objKhoiLuong.TrongGio == 0)//Ngoai gio
                            {
                                if (objKhoiLuong.LoaiHocPhan.Trim() != "TH")
                                {
                                    if (objKhoiLuong.NgoaiGio > objKhoiLuong.SoTinChi * 15)
                                        objKhoiLuong.NgoaiGio = objKhoiLuong.SoTinChi * 15;
                                }
                            }
                            else if (objKhoiLuong.TrongGio > 0 && objKhoiLuong.NgoaiGio > 0)//Trong gio - Ngoai gio
                            {
                                if (objKhoiLuong.LoaiHocPhan.Trim() != "TH")
                                    objKhoiLuong.NgoaiGio = objKhoiLuong.SoTinChi * 15 - objKhoiLuong.TrongGio;
                                if (objKhoiLuong.NgoaiGio < 0)
                                    objKhoiLuong.NgoaiGio = _ngoaiGio;
                            }
                            if (objKhoiLuong.ChatLuongCao != null)
                            {
                                objKhoiLuong.TrongGio = null;
                                objKhoiLuong.NgoaiGio = null;
                            }
                            //Luu ket qua tinh
                            DataServices.KhoiLuongGiangDay.Save(objKhoiLuong);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static decimal? TinhHeSo(TList<QuyDoiGioChuan> listQuyDoiGioChuan, TList<KhoiLuongGiangDayChiTiet> vListChiTiet)
        {
            //Tinh he so quy doi
            QuyDoiGioChuan objQuyDoi = listQuyDoiGioChuan.Find(p => p.MaQuanLy == vListChiTiet[0].LoaiHocPhan);
            if (objQuyDoi != null)
            {
                foreach (KhoanQuyDoi k in DataServices.KhoanQuyDoi.GetByMaQuyDoi(objQuyDoi.MaQuyDoi))
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
            XtraMessageBox.Show("Đã hoàn tất tính khối lượng giảng dạy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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