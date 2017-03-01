using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using PMS.Entities;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXuLyDuLieu : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        string NamHoc, HocKy, Loai;
        object DataSource;
        #endregion
        public frmXuLyDuLieu()
        {
            InitializeComponent();
        }
        public frmXuLyDuLieu(string _namHoc, string _hocKy, string _loai)
        {
            InitializeComponent();
            NamHoc = _namHoc;
            HocKy = _hocKy;
            Loai = _loai;
        }
        public frmXuLyDuLieu(string _namHoc, string _hocKy, object _listKhoiLuong, string _loai)
        {
            InitializeComponent();
            NamHoc = _namHoc;
            HocKy = _hocKy;
            Loai = _loai;
            DataSource = _listKhoiLuong;
        }
        private void frmXuLyDuLieu_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (Loai == "DongBoDoAnTotNghiep")
                {
                    DataServices.KhoiLuongDoAnTotNghiepChiTiet.DongBo(NamHoc, HocKy);
                }
                if (Loai == "TinhDuLieuDoAnTotNghiep")
                {
                    TList<QuyDoiGioChuan> listQuyDoiGioChuan = DataServices.QuyDoiGioChuan.GetAll();
                    QuyDoiGioChuan objQuyDoi = listQuyDoiGioChuan.Find(p => p.MaQuanLy == "DATN");
                    TList<KhoanQuyDoi> listKhoanQuyDoi = new TList<KhoanQuyDoi>();
                    if (objQuyDoi != null)
                        listKhoanQuyDoi = DataServices.KhoanQuyDoi.GetByMaQuyDoi(objQuyDoi.MaQuyDoi);

                    QuyDoiGioChuan objQuyDoiTieuLuan = listQuyDoiGioChuan.Find(p => p.MaQuanLy == "HDTL");
                    TList<KhoanQuyDoi> listKhoanQuyDoiTieuLuan = new TList<KhoanQuyDoi>();
                    if (objQuyDoiTieuLuan != null)
                        listKhoanQuyDoiTieuLuan = DataServices.KhoanQuyDoi.GetByMaQuyDoi(objQuyDoiTieuLuan.MaQuyDoi);

                    TList<MonTieuLuan> _listMonTieuLuan = DataServices.MonTieuLuan.GetAll(); 

                    TList<KhoiLuongDoAnTotNghiepChiTiet> list = (TList<KhoiLuongDoAnTotNghiepChiTiet>)DataSource;
                    string xmlData = "";
                    foreach (KhoiLuongDoAnTotNghiepChiTiet kl in list)
                    {
                       decimal? _soTiet;
                       if (_listMonTieuLuan.Find(p => p.MaMonHoc == kl.MaMonHoc) != null)
                           _soTiet = TinhTietQuyDoi(objQuyDoiTieuLuan, listKhoanQuyDoiTieuLuan, (int)kl.SoLuongHuongDan);
                       else
                           _soTiet = TinhTietQuyDoi(objQuyDoi, listKhoanQuyDoi, (int)kl.SoLuongHuongDan);

                        xmlData += "<KhoiLuongDoAnTotNghiep Id = \"" + kl.Id.ToString()
                                + "\" SoTiet = \"" + (IsNull(_soTiet) * IsNull(kl.HeSoHocKy))
                                + "\" SoTien = \"" + (IsNull(_soTiet) * IsNull(kl.DonGia) * IsNull(kl.HeSoHocKy))
                                + "\" NgayCapNhat =\"" + DateTime.Now.ToString()
                                + "\" />";
                    }
                    xmlData = string.Format("{0}{1}{2}", "<Root>", xmlData, "</Root>");
                    DataServices.KhoiLuongDoAnTotNghiepChiTiet.QuyDoi(NamHoc, HocKy, xmlData);
                    //Lưu thông tin thanh toán phản biện luận án cho giảng viên
                    DataServices.PhanBienLuanAn.Luu(NamHoc, HocKy);
                }
            }
            catch
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình xử lý dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            XtraMessageBox.Show("Đã hoàn tất quá trình xử lý dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        #region TinhTietQuyDoi
        decimal? TinhTietQuyDoi(QuyDoiGioChuan objQuyDoi, TList<KhoanQuyDoi> listKhoanQuyDoi, int _siSo)
        {
            decimal? _heso = 0;

            //Tinh he so quy doi


            //Lay danh sach khoan quy doi

            listKhoanQuyDoi.Sort("ThuTu ASC");
            //-----Loop-----
            if (listKhoanQuyDoi.Count > 0)
            {
                foreach (KhoanQuyDoi k in listKhoanQuyDoi)
                {
                    if (objQuyDoi.CongDon == true)
                    {
                        if (k.DenKhoan != null && _siSo >= k.TuKhoan && _siSo <= k.DenKhoan)
                        {
                            if (_heso > 0)
                            {
                                if (_siSo == k.DenKhoan)
                                    return _heso += (k.DenKhoan - k.TuKhoan + 1) * k.HeSo;
                                else
                                    return _heso += (_siSo - k.TuKhoan + 1) * k.HeSo;
                            }
                            else
                                return _heso = k.HeSo * _siSo;
                        }
                        else if (k.DenKhoan != null && _siSo >= k.DenKhoan)
                            _heso += (k.DenKhoan - k.TuKhoan + 1) * k.HeSo;
                        else if (k.DenKhoan == null && _siSo >= k.TuKhoan)
                            _heso += (_siSo - k.TuKhoan + 1) * k.HeSo;
                    }
                    else
                    {
                        if (k.DenKhoan != null && _siSo >= k.TuKhoan && _siSo <= k.DenKhoan)
                            return k.HeSo * _siSo;
                        else if (k.DenKhoan == null && _siSo >= k.TuKhoan)
                            return _siSo * k.HeSo;
                    }
                }
            }

            return _heso;
        }
        #endregion

        decimal? IsNull(decimal? s)
        {
            if (s == null)
                s = 0;
            return s;
        }
    }
}