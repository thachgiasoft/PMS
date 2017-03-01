using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using PMS.BLL;
using PMS.Core;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVienHoatDongQuanLy : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLuu.ShortCut = Shortcut.CtrlS;
                btnXoa.ShortCut = Shortcut.Del;
            }
        }
        #endregion
        #region Variable
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewGiangVien> _listGiangVien;
        VList<ViewKhoa> _listKhoaDonVi;
        string _groupName = UserInfo.GroupName;
        bool _status;
        #endregion

        public frmGiangVienHoatDongQuanLy()
        {
            InitializeComponent();
        }

        private void frmGiangVienHoatDongQuanLy_Load(object sender, EventArgs e)
        {
            #region Init grid
            AppGridView.InitGridView(gridView1, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridView1, new string[] { "Id", "MaGiangVien", "MaHoatDongQuanLy", "NoiDungCongViec", "NgayThucHien", "SoPhut", "HeSoQuyDoi", "SoTiet", "GhiChu", "XacNhan" }
                    , new string[] { "Id", "Giảng viên", "Hoạt động quản lý", "Nội dung công việc", "Ngày thực hiện", "Tổng thời gian (phút)", "Hệ số quy đổi", "Số tiết quy đổi", "Ghi chú", "Xác nhận" }
                    , new int[] { 50, 150, 140, 150, 90, 120, 90, 100, 150, 80 });
            AppGridView.ShowEditor(gridView1, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridView1, new string[] { "Id", "MaGiangVien", "MaHoatDongQuanLy", "NoiDungCongViec", "NgayThucHien", "SoPhut", "HeSoQuyDoi", "SoTiet", "GhiChu", "XacNhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridView1, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridView1, "MaHoatDongQuanLy", repositoryItemGridLookUpEditHoatDongQuanLy);
            AppGridView.HideField(gridView1, new string[] { "Id" });
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            bsNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" }, new int[] { 90, 110 });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;

            #endregion

            #region _khoaDonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" }, new int[] { 60, 200 });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            _listKhoaDonVi = DataServices.ViewKhoa.GetAll();
            foreach (ViewKhoa v in _listKhoaDonVi)
            {
                if (v.MaKhoa == _groupName)
                {
                    _status = true;
                    break;
                }
            }
            if (_status)
                _listKhoaDonVi = _listKhoaDonVi.FindAll(p => p.MaKhoa == _groupName) as VList<ViewKhoa>;
            else
                _listKhoaDonVi.Insert(0, new ViewKhoa() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]" });

            cboKhoaDonVi.DataBindings.Clear();
            bsKhoaDonVi.DataSource = _listKhoaDonVi;
            cboKhoaDonVi.DataBindings.Add("EditValue", bsKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi" }, new string[] { "Mã quản lý", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên", "Đơn vị" }, new int[] { 90, 130, 100, 100, 100, 150 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 670, 650);
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region HoatDongQuanLy
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHoatDongQuanLy, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHoatDongQuanLy, new string[] { "MaHoatDong", "TenHoatDong", "GhiChu" }, new string[] { "Mã hoạt động", "Tên hoạt động", "Ghi chú" }, new int[] { 90, 200, 110 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHoatDongQuanLy, 400, 400);
            repositoryItemGridLookUpEditHoatDongQuanLy.ValueMember = "Id";
            repositoryItemGridLookUpEditHoatDongQuanLy.DisplayMember = "TenHoatDong";
            repositoryItemGridLookUpEditHoatDongQuanLy.NullText = string.Empty;
            bsHoatDongQuanLy.DataSource = DataServices.DanhMucHoatDongQuanLy.GetAll();
            #endregion

            InitData(); //chỉ init data không cố định
        }

        private void InitData()
        {
            if (cboNamHoc.EditValue != null)
            {
                bsHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                bsGiangVien.DataSource = _listGiangVien;
            }
            LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null) //chưa có lọc theo hoạt động thì chưa cần kiểm tra
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.GiangVienHoatDongQuanLy.GetByNamHocHocKyHoatDongKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), 0, cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                bsGiangVienHoatDongQL.DataSource = tb;
            }
            KiemTraChot();
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
            bsGiangVien.DataSource = _listGiangVien;
            LoadDataSource();
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            bsHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridView1);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Luu();
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK && sf.FileName != "")
                    {
                        gridControl1.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private int Luu()
        {
            Cursor.Current = Cursors.WaitCursor;

            gridView1.FocusedRowHandle = -1;
            DataTable dt = bsGiangVienHoatDongQL.DataSource as DataTable;

            if (dt != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow gvhdql in dt.Rows)
                        {
                            if (gvhdql.RowState != DataRowState.Deleted)
                            {
                                if (gvhdql["SoTiet"].ToString() == "")
                                {
                                    throw new Exception("Số tiết không được bỏ trống.");
                                }
                                else if (gvhdql["MaGiangVien"].ToString() == "" || gvhdql["MaHoatDongQuanLy"].ToString() == "")
                                {
                                    throw new Exception("Giảng viên và Tên hoạt động không được phép bỏ trống.");
                                }
                                else
                                {
                                    DateTime t = DateTime.Now;
                                    if (!DateTime.TryParse(gvhdql["NgayThucHien"].ToString(), out t))
                                        t = DateTime.Now;
                                    xmlData += "<Input ID=\"" + PMS.Common.Globals.IsNull(gvhdql["Id"], "string")
                                            + "\" MGV=\"" + PMS.Common.Globals.IsNull(gvhdql["MaGiangVien"], "string")
                                            + "\" IDHD=\"" + PMS.Common.Globals.IsNull(gvhdql["MaHoatDongQuanLy"], "string")
                                            + "\" ST=\"" + PMS.Common.Globals.IsNull(gvhdql["SoTiet"], "decimal")
                                            + "\" GC=\"" + PMS.Common.XuLyChuoi.RefreshXmlString(PMS.Common.Globals.IsNull(gvhdql["GhiChu"], "string").ToString())
                                            + "\" NDCV=\"" + PMS.Common.XuLyChuoi.RefreshXmlString(PMS.Common.Globals.IsNull(gvhdql["NoiDungCongViec"], "string").ToString())
                                            + "\" NTH=\"" + t.ToString("dd/MM/yyyy HH:mm:ss")//((DateTime)gvhdql["NgayThucHien"]).ToString("dd/MM/yyyy HH:mm:ss")
                                            + "\" SP=\"" + PMS.Common.Globals.IsNull(gvhdql["SoPhut"], "int")
                                            + "\" HSQD=\"" + PMS.Common.Globals.IsNull(gvhdql["HeSoQuyDoi"], "decimal")
                                            + "\" XN=\"" + PMS.Common.Globals.IsNull(gvhdql["XacNhan"], "bool")
                                            + "\" />";
                                    //MessageBox.Show(xmlData);
                                }
                            }
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";
                        int kq = 0;
                        DataServices.GiangVienHoatDongQuanLy.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kq);
                        if (kq == 0)
                        {
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataSource();
                        }
                        else
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        return kq;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Cảnh báo:\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
            return -1;  //Không lưu
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn CHỐT dữ liệu giảng viên hoạt động quản lý năm học {0} học kỳ {1}", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int kq = 0;
                    DataServices.GiangVienHoatDongQuanLy.Chot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), true, ref kq);

                    XtraMessageBox.Show(string.Format("Chốt dữ liệu giảng viên hoạt động quản lý năm học {0} học kỳ {1} thành công.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            KiemTraChot();
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn HUỶ chốt dữ liệu giảng viên hoạt động quản lý năm học {0} học kỳ {1}", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int kq = 0;
                    DataServices.GiangVienHoatDongQuanLy.Chot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), false, ref kq);

                    XtraMessageBox.Show(string.Format("Huỷ chốt dữ liệu giảng viên hoạt động quản lý năm học {0} học kỳ {1} thành công.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            KiemTraChot();
        }

        void KiemTraChot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                try
                {
                    int _kiemTra = 0;
                    DataServices.GiangVienHoatDongQuanLy.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref _kiemTra);

                    if (_kiemTra == 0)
                    {
                        lblGhiChu.Text = "";
                        btnChot.Enabled = true;
                        btnHuyChot.Enabled = false;
                        btnLuu.Enabled = true;
                    }
                    else
                    {
                        lblGhiChu.Text = string.Format("Dữ liệu giảng viên hoạt động quản lý năm học {0} học kỳ {1} đã chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                        btnChot.Enabled = false;
                        btnHuyChot.Enabled = true;
                        btnLuu.Enabled = false;
                    }
                }
                catch
                { }
                
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "MaGiangVien")
                {
                    DataRowView rv = gridView1.GetRow(e.RowHandle) as DataRowView;
                    if (rv["MaGiangVien"].ToString() != "")
                    {
                        double _heSoQuyDoiGioTroi = 0;
                        DataServices.HeSoQuyDoiGioTroi.GetByMaGiangVienNamHocHocKy(int.Parse(rv["MaGiangVien"].ToString()), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref _heSoQuyDoiGioTroi);
                        //DataServices.HeSoQuyDoiGioTroi.GetByMaGiangVienNamHocHocKy(int.Parse(rv["MaGiangVien"].ToString()), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), DateTime.Parse(rv["NgayThucHien"].ToString()), ref _heSoQuyDoiGioTroi);
                        gridView1.SetRowCellValue(e.RowHandle, "HeSoQuyDoi", _heSoQuyDoiGioTroi);
                    }
                }

                if (e.Column.FieldName == "SoPhut" || e.Column.FieldName == "HeSoQuyDoi")
                {
                    DataRowView rv = gridView1.GetRow(e.RowHandle) as DataRowView;

                    decimal _soPhut = decimal.Parse(PMS.Common.Globals.IsNull(rv["SoPhut"], "decimal").ToString());
                    decimal _heSoQuyDoi = (decimal)PMS.Common.Globals.IsNull(rv["HeSoQuyDoi"], "decimal");
                    decimal _soTietQuyDoi = Math.Round((_soPhut / 60) / _heSoQuyDoi, 2);

                    gridView1.SetRowCellValue(e.RowHandle, "SoTiet", _soTietQuyDoi);
                }
            }
            catch  
            { 
            } 
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, "Id", 0);
        }

        

        

        

        

        

        

        
    }
}