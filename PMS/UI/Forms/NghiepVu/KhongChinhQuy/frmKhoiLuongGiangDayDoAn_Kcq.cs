using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu.KhongChinhQuy
{
    public partial class frmKhoiLuongGiangDayDoAn_Kcq : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;


                btnLayDuLieuDoAn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLayDuLieuDoAn.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLayDuLieuDoAn.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewGiangVien> _listGiangVien = new VList<ViewGiangVien>();

        TList<KcqQuyDoiGioChuan> listQuyDoiGioChuan = DataServices.KcqQuyDoiGioChuan.GetAll();
        TList<KcqHeSoDiaDiem> _listDiaDiem;
        int kiemtra = 0;
        #endregion
        #region Event Form
        public frmKhoiLuongGiangDayDoAn_Kcq()
        {
            InitializeComponent();
        }

        private void frmKhoiLuongGiangDayDoAn_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoiLuongDoAn, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongDoAn, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "MaDiaDiem", "TenDiaDiem", "TienXeDiaDiem", "Nhom", "SiSo", "MaGiangVienQuanLy", "NgayCapNhat", "SoTietQuyDoi", "HeSoHocKy", "DonGia", "ThanhTien" }
                    , new string[] { "Mã môn học", "Tên môn học", "Số tín chỉ", "Mã lớp học phần", "Mã lớp", "Mã địa điểm", "Tên địa điểm", "Tiền xe địa điểm", "Nhóm", "Sĩ số", "Họ tên giảng viên", "Ngày cập nhật", "Tiết quy đổi", "Hệ số học kỳ", "Đơn giá", "Thành tiền" }
                    , new int[] { 100, 150, 90, 110, 100,90,150,90, 80, 80, 150, 120, 90, 90, 100, 100 });
            AppGridView.HideField(gridViewKhoiLuongDoAn, new string[] { "NgayCapNhat" });
            AppGridView.AlignHeader(gridViewKhoiLuongDoAn, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "MaDiaDiem", "TenDiaDiem", "TienXeDiaDiem", "Nhom", "SiSo", "MaGiangVienQuanLy", "HeSoHocKy", "SoTietQuyDoi", "DonGia", "ThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongDoAn, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewKhoiLuongDoAn, "MaGiangVienQuanLy", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewKhoiLuongDoAn, "MaDiaDiem", repositoryItemGridLookUpEditDiaDiem);
            AppGridView.RegisterControlField(gridViewKhoiLuongDoAn, "SiSo", repositoryItemSpinEditSiSo);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongDoAn, new string[] { "SoTietQuyDoi", "DonGia", "ThanhTien" });
            AppGridView.FormatDataField(gridViewKhoiLuongDoAn, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongDoAn, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongDoAn, "TienXeDiaDiem", DevExpress.Utils.FormatType.Custom, "n0");

            #endregion
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region GiangVien 
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien" }, new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên" }, new int[] { 90, 150, 120, 120, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 600, 600);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region MaDiaDiem
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDiaDiem, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDiaDiem, 360, 600);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDiaDiem, new string[] { "MaQuanLy", "TenDiaDiem", "HeSoDiaDiem", "DonGia", "TienXeDiaDiem" }, new string[] { "Mã địa điểm", "Tên địa điểm", "Hệ số địa điểm", "Đơn giá", "Tiền xe địa điểm" }, new int[] { 100, 150, 80, 80, 90 });
            repositoryItemGridLookUpEditDiaDiem.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditDiaDiem.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditDiaDiem.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion
        #region InitData()
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            
              _listDiaDiem= DataServices.KcqHeSoDiaDiem.GetAll();
              bindingSourceDiaDiem.DataSource = _listDiaDiem;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable dt = new DataTable();
                dt.Load(DataServices.KcqKhoiLuongGiangDayDoAn.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                bindingSourceKhoiLuongDoAn.DataSource = dt;
            }

            
        }
        #endregion
        #region Event Button
        private void btLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLayDuLieuDoAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataServices.KcqChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DAMH", ref kiemtra);
                if (kiemtra == 1)
                {
                    XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int kq = 0;
                DataServices.KcqKhoiLuongGiangDayDoAn.KiemTraDongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                if (kq == 0)
                {
                    using (frmDongBoDuLieuDoAnUIS_Kcq frm = new frmDongBoDuLieuDoAnUIS_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DAMH"))
                    {
                        frm.ShowDialog();
                    }
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(DataServices.KcqKhoiLuongGiangDayDoAn.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                        bindingSourceKhoiLuongDoAn.DataSource = dt;
                    }
                }
                if (kq == 1)
                {
                    if (XtraMessageBox.Show(string.Format("Dữ liệu đồ án của năm học {0} - {1} đã có, tiếp tục lấy dữ liệu sẽ ghi đè dữ liệu cũ.\n Bạn có muốn tiếp tục?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (frmDongBoDuLieuDoAnUIS_Kcq frm = new frmDongBoDuLieuDoAnUIS_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DAMH"))
                        {
                            frm.ShowDialog();
                        }
                        if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(DataServices.KcqKhoiLuongGiangDayDoAn.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                            bindingSourceKhoiLuongDoAn.DataSource = dt;
                        }
                    }
                    else return;
                }
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataServices.KcqChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DAMH", ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gridViewKhoiLuongDoAn.FocusedRowHandle = -1;
            //string xmlData = "";
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable tb = bindingSourceKhoiLuongDoAn.DataSource as DataTable;
                //TList<KcqKhoiLuongGiangDayDoAn> list = bindingSourceKhoiLuongDoAn.DataSource as TList<KcqKhoiLuongGiangDayDoAn>;
                //if (list != null || list.Count > 0)
               if (tb != null)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        KcqQuyDoiGioChuan objQuyDoi = listQuyDoiGioChuan.Find(p => p.MaQuanLy == "DAMH");
                        TList<KcqKhoanQuyDoi> listKhoanQuyDoi = new TList<KcqKhoanQuyDoi>();
                        if (objQuyDoi != null)
                            listKhoanQuyDoi = DataServices.KcqKhoanQuyDoi.GetByMaQuyDoi(objQuyDoi.MaQuyDoi);

                        //DataTable tb = bindingSourceKhoiLuongDoAn.DataSource as DataTable;
                        foreach (DataRow kl in tb.Rows)
                        {
                            if (kl["MaGiangVienQuanLy"].ToString() != null && kl["MaGiangVienQuanLy"].ToString() != "")
                            {
     

                                kl["MaLoaiGiangVien"] = _listGiangVien.Find(p => p.MaQuanLy ==  kl["MaGiangVienQuanLy"].ToString()).MaLoaiGiangVien;
                                kl["MaHocHam"] = _listGiangVien.Find(p => p.MaQuanLy == kl["MaGiangVienQuanLy"].ToString()).MaHocHam;
                                kl["MaHocVi"] = _listGiangVien.Find(p => p.MaQuanLy == kl["MaGiangVienQuanLy"].ToString()).MaHocVi;
                                kl["SoTietQuyDoi"] = (decimal)TinhTietQuyDoi(objQuyDoi, listKhoanQuyDoi, int.Parse(kl["SiSo"].ToString())) * decimal.Parse(kl["HeSoHocKy"].ToString());
                                int _donGia = 0;
                                DataServices.KcqDonGiaNgoaiQuyChe.GetByMaQuanLyNamHocHocKyLopClc(kl["MaGiangVienQuanLy"].ToString(), kl["NamHoc"].ToString(), kl["HocKy"].ToString(), false, ref _donGia);
                                if (_donGia == 0)//đồ án môn học tất cả lấy đơn giá theo đại trà
                                    DataServices.KcqDonGia.GetByMaLoaiGiangVienMaHocHamMaHocViLopClc((int)kl["MaLoaiGiangVien"], (int)kl["MaHocHam"], (int)kl["MaHocVi"], false, ref _donGia);
                                kl["DonGia"]= _donGia;
                               // kl["ThanhTien"] = decimal.Parse(kl["SoTietQuyDoi"].ToString()) * decimal.Parse(kl["DonGia"].ToString());
                                if (int.Parse(kl["SoTinChi"].ToString()) < 4 )
                                    kl["ThanhTien"] =( decimal.Parse(kl["SoTietQuyDoi"].ToString()) * ((decimal.Parse(kl["DonGia"].ToString()) + (_listDiaDiem.Find(p=>p.MaQuanLy==kl["MaDiaDiem"].ToString()).HeSoDiaDiem  *  _listDiaDiem.Find(p=>p.MaQuanLy==kl["MaDiaDiem"].ToString()).DonGia))))  +  decimal.Parse(kl["TienXeDiaDiem"].ToString());
                                else
                                    kl["ThanhTien"] = (decimal.Parse(kl["SoTietQuyDoi"].ToString()) * ((decimal.Parse(kl["DonGia"].ToString()) + (_listDiaDiem.Find(p => p.MaQuanLy == kl["MaDiaDiem"].ToString()).HeSoDiaDiem * _listDiaDiem.Find(p => p.MaQuanLy == kl["MaDiaDiem"].ToString()).DonGia)))) + (decimal.Parse(kl["TienXeDiaDiem"].ToString()) * 2);

                            }
                        }
                        //bindingSourceKhoiLuongDoAn.EndEdit();
                        //DataServices.KcqKhoiLuongGiangDayDoAn.Save(list);
                        //XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (tb.Rows.Count > 0)
                        {
                            if (XtraMessageBox.Show("Bạn muốn lưu thay đổi thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string xmlData = "";
                                foreach (DataRow row in tb.Rows)
                                {

                                    xmlData += "<Input LHP=\"" + row["MaLopHocPhan"].ToString()
                                                + "\" S=\"" + PMS.Common.Globals.IsNull(row["SiSo"].ToString(), "int")
                                                + "\" D=\"" + row["MaDiaDiem"].ToString()
                                                + "\" GV=\"" + row["MaGiangVienQuanLy"].ToString()
                                                + "\" ST=\"" + PMS.Common.Globals.IsNull(row["SoTietQuyDoi"].ToString(), "decimal")
                                                + "\" DG=\"" + PMS.Common.Globals.IsNull(row["DonGia"].ToString(),"decimal")
                                                + "\" TT=\"" + PMS.Common.Globals.IsNull(row["ThanhTien"].ToString(),"decimal")
                                                + "\" />";
                                }
                                xmlData = "<Root>" + xmlData + "</Root>";

                                int kq = 0;
                                DataServices.KcqKhoiLuongGiangDayDoAn.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                                if (kq == 0)
                                    XtraMessageBox.Show("Lưu thay đổi sĩ số thành công. Lưu ý: thực hiện quy đổi lại để tính lại hệ số lớp đông.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion
        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable dt = new DataTable();
                dt.Load(DataServices.KcqKhoiLuongGiangDayDoAn.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                bindingSourceKhoiLuongDoAn.DataSource = dt;
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable dt = new DataTable();
                dt.Load(DataServices.KcqKhoiLuongGiangDayDoAn.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                bindingSourceKhoiLuongDoAn.DataSource = dt;
            }
        }
        #endregion
        #region Event Grid
        private void gridViewKhoiLuongDoAn_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //GridColumn col = e.Column;
            //if (col.FieldName == "MaLop")
            //{
            //    int pos = e.RowHandle;
            //    object r = gridViewCoVan.GetRow(pos);

            //    CoVanHocTap dt = (CoVanHocTap)r;
            //    VList<ViewLop> lop = DataServices.ViewLop.Get(String.Format("MaLop = '{0}'", dt.MaLop), "MaLop");

            //    gridViewCoVan.SetRowCellValue(pos, "MaKhoaHoc", lop[0].MaKhoaHoc);
            //}
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            if (col.FieldName == "MaMonHoc" || col.FieldName == "TenMonHoc" || col.FieldName == "SoTinChi" || col.FieldName == "MaLopHocPhan" || col.FieldName == "MaLop" || col.FieldName == "SiSo" || col.FieldName == "MaGiangVienQuanLy" || col.FieldName == "SoTietQuyDoi")
                gridViewKhoiLuongDoAn.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString());

            if (col.FieldName == "MaDiaDiem")
            {
                DataRowView v = gridViewKhoiLuongDoAn.GetRow(pos) as DataRowView;

                string _tenDiaDiem = _listDiaDiem.Find(p => p.MaQuanLy == v["MaDiaDiem"].ToString()).TenDiaDiem;
                decimal? _tienxeDiaDiem = _listDiaDiem.Find(p => p.MaQuanLy == v["MaDiaDiem"].ToString()).TienXeDiaDiem;
                gridViewKhoiLuongDoAn.SetRowCellValue(e.RowHandle, "TenDiaDiem", _tenDiaDiem);
                gridViewKhoiLuongDoAn.SetRowCellValue(e.RowHandle, "TienXeDiaDiem", _tienxeDiaDiem);
                gridViewKhoiLuongDoAn.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now);
            }

        }
        #endregion
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

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlKhoiLuongDoAn.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}