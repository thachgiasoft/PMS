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
using System.Reflection;

namespace PMS.UI.Forms.NghiepVu.KhongChinhQuy
{
    public partial class frmXuLyDuLieu_Kcq : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        string NamHoc, HocKy, Loai;
        object DataSource;
        #endregion
        public frmXuLyDuLieu_Kcq()
        {
            InitializeComponent();
        }
        public frmXuLyDuLieu_Kcq(string _namHoc, string _hocKy, string _loai)
        {
            InitializeComponent();
            NamHoc = _namHoc;
            HocKy = _hocKy;
            Loai = _loai;
        }
        public frmXuLyDuLieu_Kcq(string _namHoc, string _hocKy, object _listKhoiLuong, string _loai)
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

        public static DataTable ToDataTable<T>(IEnumerable<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //Đồng bộ khối lượng đồ án tốt nghiệp
                if (Loai == "DongBoDoAnTotNghiep")
                {
                    DataServices.KcqKhoiLuongDoAnTotNghiepChiTiet.DongBoKcq(NamHoc, HocKy);
                }

                //Quy đổi khối lượng đồ án tốt nghiệp
                if (Loai == "TinhDuLieuDoAnTotNghiep")
                {
                    TList<KcqQuyDoiGioChuan> listQuyDoiGioChuan = DataServices.KcqQuyDoiGioChuan.GetAll();
                    KcqQuyDoiGioChuan objQuyDoi = listQuyDoiGioChuan.Find(p => p.MaQuanLy == "DATN");
                    TList<KcqKhoanQuyDoi> listKhoanQuyDoi = new TList<KcqKhoanQuyDoi>();
                    if (objQuyDoi != null)
                        listKhoanQuyDoi = DataServices.KcqKhoanQuyDoi.GetByMaQuyDoi(objQuyDoi.MaQuyDoi);

                    KcqQuyDoiGioChuan objQuyDoiTieuLuan = listQuyDoiGioChuan.Find(p => p.MaQuanLy == "HDTL");
                    TList<KcqKhoanQuyDoi> listKhoanQuyDoiTieuLuan = new TList<KcqKhoanQuyDoi>();
                    if (objQuyDoiTieuLuan != null)
                        listKhoanQuyDoiTieuLuan = DataServices.KcqKhoanQuyDoi.GetByMaQuyDoi(objQuyDoiTieuLuan.MaQuyDoi);

                    TList<KcqMonTieuLuan> _listMonTieuLuan = DataServices.KcqMonTieuLuan.GetAll();




                    //TList<KcqKhoiLuongDoAnTotNghiepChiTiet> list = DataSource as TList<KcqKhoiLuongDoAnTotNghiepChiTiet>;
                    DataTable dt=DataSource as DataTable;

                 
                    string xmlData = "";
                    foreach (DataRow kl in dt.Rows)
                    {
                        TList<KcqHeSoDiaDiem> _listDiaDiem = DataServices.KcqHeSoDiaDiem.GetAll();

                        decimal? _soTiet;
                        if (_listMonTieuLuan.Find(p => p.MaMonHoc == kl["MaMonHoc"]) != null)
                            _soTiet = TinhTietQuyDoi(objQuyDoiTieuLuan, listKhoanQuyDoiTieuLuan, (int)kl["SoLuongHuongDan"]);
                        else
                            _soTiet = TinhTietQuyDoi(objQuyDoi, listKhoanQuyDoi, (int)kl["SoLuongHuongDan"]);
                        if (int.Parse(kl["SoTinChi"].ToString()) < 4)
                        {
                            xmlData += "<KcqKhoiLuongDoAnTotNghiep Id = \"" + kl["Id"].ToString()
                                    + "\" SoTiet = \"" + (IsNull(_soTiet) * IsNull(decimal.Parse(kl["HeSoHocKy"].ToString()))).ToString()
                                    + "\" SoTien = \"" + (IsNull(_soTiet) * ((IsNull(decimal.Parse(kl["DonGia"].ToString())) + (_listDiaDiem.Find(p => p.MaQuanLy == kl["MaDiaDiem"].ToString()).DonGia * _listDiaDiem.Find(p => p.MaQuanLy == kl["MaDiaDiem"].ToString()).HeSoDiaDiem))) + _listDiaDiem.Find(p => p.MaQuanLy == kl["MaDiaDiem"].ToString()).TienXeDiaDiem).ToString()
                                    + "\" NgayCapNhat =\"" + DateTime.Now.ToString()
                                    + "\" />";
                        }
                        else
                        {
                            xmlData += "<KcqKhoiLuongDoAnTotNghiep Id = \"" + kl["Id"].ToString()
                                    + "\" SoTiet = \"" + (IsNull(_soTiet) * IsNull(decimal.Parse(kl["HeSoHocKy"].ToString()))).ToString()
                                    + "\" SoTien = \"" + (IsNull(_soTiet) * ((IsNull(decimal.Parse(kl["DonGia"].ToString())) + (_listDiaDiem.Find(p => p.MaQuanLy == kl["MaDiaDiem"].ToString()).DonGia * _listDiaDiem.Find(p => p.MaQuanLy == kl["MaDiaDiem"].ToString()).HeSoDiaDiem))) + (_listDiaDiem.Find(p => p.MaQuanLy == kl["MaDiaDiem"].ToString()).TienXeDiaDiem * 2)).ToString()
                                    + "\" NgayCapNhat =\"" + DateTime.Now.ToString()
                                    + "\" />";
                        }
                    }

                    //{
                    //    decimal? _soTiet;
                    //    if (_listMonTieuLuan.Find(p => p.MaMonHoc == klMaMonHoc) != null)
                    //        _soTiet = TinhTietQuyDoi(objQuyDoiTieuLuan, listKhoanQuyDoiTieuLuan, (int)kl.SoLuongHuongDan);
                    //    else
                    //        _soTiet = TinhTietQuyDoi(objQuyDoi, listKhoanQuyDoi, (int)kl.SoLuongHuongDan);

                    //    xmlData += "<KhoiLuongDoAnTotNghiep Id = \"" + kl.Id.ToString()
                    //            + "\" SoTiet = \"" + (IsNull(_soTiet) * IsNull(kl.HeSoHocKy)).ToString()
                    //            + "\" SoTien = \"" + (IsNull(_soTiet) * IsNull(kl.DonGia) * IsNull(kl.HeSoHocKy)).ToString()
                    //            + "\" NgayCapNhat =\"" + DateTime.Now.ToString()
                    //            + "\" />";
                    //}
                    xmlData = string.Format("{0}{1}{2}", "<Root>", xmlData, "</Root>");
                    DataServices.KcqKhoiLuongDoAnTotNghiepChiTiet.QuyDoi(NamHoc, HocKy, xmlData);
                    //Lưu thông tin thanh toán phản biện luận án cho giảng viên
                    DataServices.KcqPhanBienLuanAn.Luu(NamHoc, HocKy);
                }

                //Đồng bộ khối lượng thực tập tốt nghiệp, thực tập cuối khoá
                if (Loai == "DongBoThucTapTotNghiep")
                {
                    DataServices.KcqKhoiLuongThucTapCuoiKhoa.DongBo(NamHoc, HocKy);
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
        decimal? TinhTietQuyDoi(KcqQuyDoiGioChuan objQuyDoi, TList<KcqKhoanQuyDoi> listKhoanQuyDoi, int _siSo)
        {
            decimal? _heso = 0;

            //Tinh he so quy doi


            //Lay danh sach khoan quy doi

            listKhoanQuyDoi.Sort("ThuTu ASC");
            //-----Loop-----
            if (listKhoanQuyDoi.Count > 0)
            {
                foreach (KcqKhoanQuyDoi k in listKhoanQuyDoi)
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