using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using PMS.Services;
using DevExpress.XtraEditors.Repository;
//using Libraries.BLL;
using PMS.BLL;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVienHoatDongNgoaiGiangDay : DevExpress.XtraEditors.XtraForm
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

                btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLayDuLieu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditLop;
        string _groupName = UserInfo.GroupName;
        #endregion

        #region Event Form
        public frmGiangVienHoatDongNgoaiGiangDay()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Where(i => i.TenCauHinh == "Mã trường").First().GiaTri;
        }

        private void frmGiangVienHoatDongNgoaiGiangDay_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewGiangVienHDNGD, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewGiangVienHDNGD, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewGiangVienHDNGD, new string[] { "MaGiangVien", "MaHoatDong", "MaLop", "SiSo", "SoTiet", "SoLuong", "GhiChu", "MaQuanLy" }
                        , new string[] { "Họ tên GV", "Hoạt động ngoài giảng dạy", "Lớp", "Sĩ số","Số tiết","Số lượng", "Ghi chú", "Mã HD" }
                        , new int[] { 180, 350, 150,90,90,90, 180, 99 });
            AppGridView.AlignHeader(gridViewGiangVienHDNGD, new string[] { "MaGiangVien", "MaHoatDong", "MaLop", "SiSo", "SoTiet", "SoLuong", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewGiangVienHDNGD, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewGiangVienHDNGD, "MaHoatDong", repositoryItemGridLookUpEditHoatDong);
            AppGridView.FormatDataField(gridViewGiangVienHDNGD, "SoLuong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewGiangVienHDNGD, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewGiangVienHDNGD, "SoTiet", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewGiangVienHDNGD, new string[] { "MaQuanLy" });
            AppGridView.ReadOnlyColumn(gridViewGiangVienHDNGD, new string[] { "SiSo", "SoTiet" });
            AppGridView.SummaryField(gridViewGiangVienHDNGD, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);

            if (_maTruong == "BUH")
            {
                gridViewGiangVienHDNGD.Columns["MaLop"].Visible = true;
            }
            else
            {
                gridViewGiangVienHDNGD.Columns["MaLop"].Visible = false;
                btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "TenHocKy" }, new string[] { "Học kỳ" });
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Khoa bộ môn
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã bộ môn", "Tên bộ môn" });
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;
    
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị" }
                        , new int[] { 100, 180, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 500);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region HoatDongNgoaiGiangDay
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHoatDong, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHoatDong, new string[] { "TenHoatDong", "MucQuyDoi", "GhiChu" }, new string[] { "Tên hoạt động", "Mức quy đổi", "Ghi chú" }, new int[] { 300, 100, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHoatDong, 500, 450);
            repositoryItemGridLookUpEditHoatDong.DisplayMember = "TenHoatDong";
            repositoryItemGridLookUpEditHoatDong.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditHoatDong.NullText = string.Empty;
            
            #endregion

            #region Lớp
            if (_maTruong == "BUH")
            {
                repositoryItemGridLookUpEditLop = new RepositoryItemGridLookUpEdit();
                AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLop
                    , DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
                AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLop
                    , new string[] { "MaLop", "TenLop" }
                    , new string[] { "Mã lớp", "Tên môn" }
                    , new int[] { 50, 100});
                AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLop, 500, 450);
                repositoryItemGridLookUpEditLop.DisplayMember = "MaLop";
                repositoryItemGridLookUpEditLop.ValueMember = "MaLop";
                repositoryItemGridLookUpEditLop.NullText = string.Empty;

                AppGridView.RegisterControlField(gridViewGiangVienHDNGD, "MaLop", repositoryItemGridLookUpEditLop);
            }
            #endregion

            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboKhoaDonVi.DataBindings.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
                    break;
                }
            }

            bindingSourceKhoaDonVi.DataSource = _vListKhoaBoMon;

            //bindingSourceKhoaDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            //Giảng viên của khoa khác cũng có thể dc phân công cho khoa _groupname
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();

            bindingSourceHoatDong.DataSource = DataServices.HoatDongNgoaiGiangDay.GetAll();

            if(cboNamHoc.EditValue !=null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                if (_maTruong == "BUH")
                {
                    DataTable dtLop = new DataTable();
                    IDataReader readerLop = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonViBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    dtLop.Load(readerLop);
                    repositoryItemGridLookUpEditLop.DataSource = dtLop;

                    DataTable dt = new DataTable();
                    IDataReader reader = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    dt.Load(reader);
                    bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;

                    //TList<GiangVienHoatDongNgoaiGiangDay> list = bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource as TList<GiangVienHoatDongNgoaiGiangDay>;
                    //dtData = PMS.Common.Globals.ToDataTable(list);
                    //gridControlGiangVienHDNGD.DataSource = dtData;
                    //bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = list;

                    //dtData = Libraries.BLL.DBComunication.GetTable("GiangVien_HoatDongNgoaiGiangDay", "_namHoc = {0} and _hocKy = {1}"
                    //    , new object[] { cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString() });
                    //gridControlGiangVienHDNGD.DataSource = dtData;
                }
                else
                {
                    DataTable dt = new DataTable();
                    IDataReader reader = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    dt.Load(reader);
                    bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;
                   
                }
            }

        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienHDNGD);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //Cập nhật mã lớp
            if (_maTruong == "BUH")
            {
                gridViewGiangVienHDNGD.FocusedRowHandle = -1;
                try
                {
                    DataTable list = bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource as DataTable;
                    
                    if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string xmlData = "";
                        foreach (DataRow row in list.Rows)
                        {
                            if (row.RowState != DataRowState.Deleted)
                            {
                                if (row["MaGiangVien"].ToString() != "" && row["MaHoatDong"].ToString() != "" && row["MaLop"].ToString() != "")
                                {

                                    xmlData += "<Input Q=\"" + row["MaQuanLy"].ToString()
                                            + "\" M=\"" + row["MaGiangVien"].ToString()
                                            + "\" H=\"" + row["MaHoatDong"].ToString()
                                            + "\" S=\"" + PMS.Common.Globals.IsNull(row["SoLuong"], "decimal")
                                            + "\" L=\"" + row["MaLop"]
                                            + "\" G=\"" + row["GhiChu"]
                                            + "\" />";

                                }
                                else
                                {
                                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin họ tên, hoạt động, số lượng và mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);

                        int kq = -1;
                        DataServices.GiangVienHoatDongNgoaiGiangDay.Luu(xmlData, cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);

                        if(kq == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Load lại gridview:
                        if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            DataTable dtLop = new DataTable();
                            IDataReader readerLop = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonViBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            dtLop.Load(readerLop);
                            repositoryItemGridLookUpEditLop.DataSource = dtLop;

                            DataTable dt = new DataTable();
                            IDataReader reader = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            dt.Load(reader);
                            bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }
                catch
                { XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                gridViewGiangVienHDNGD.FocusedRowHandle = -1;
                TList<GiangVienHoatDongNgoaiGiangDay> list = bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource as TList<GiangVienHoatDongNgoaiGiangDay>;
                if (list != null)
                {
                    foreach (GiangVienHoatDongNgoaiGiangDay g in list)
                    {
                        g.NamHoc = cboNamHoc.EditValue.ToString();
                        g.HocKy = cboHocKy.EditValue.ToString();
                    }
                    if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (list.IsValid)
                        {
                            try
                            {
                                bindingSourceGiangVienHoatDongNgoaiGiangDay.EndEdit();
                                DataServices.GiangVienHoatDongNgoaiGiangDay.Save(list);
                                XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLayDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                int kq = 0;
                DataServices.GiangVienHoatDongNgoaiGiangDay.KiemTraDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kq);
                DataTable dt = new DataTable();
                IDataReader reader;
                if (kq == 0)
                {
                    if (XtraMessageBox.Show("Bạn muốn lấy dữ liệu tự động?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            reader = DataServices.GiangVienHoatDongNgoaiGiangDay.LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            dt.Load(reader);
                            bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;
                            Cursor.Current = Cursors.Default;

                            XtraMessageBox.Show("Lấy dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (kq == 1)
                {
                    if (XtraMessageBox.Show(string.Format("Dữ liệu hoạt động ngoài giảng dạy của năm học {0} - {1} đã có, tiếp tục lấy dữ liệu sẽ ghi đè dữ liệu cũ.\n Bạn có muốn tiếp tục?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            reader = DataServices.GiangVienHoatDongNgoaiGiangDay.LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            dt.Load(reader);
                            bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;
                            Cursor.Current = Cursors.Default;
                            XtraMessageBox.Show("Lấy dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion

        #region Evnet Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable dtLop = new DataTable();
                IDataReader readerLop = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonViBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dtLop.Load(readerLop);
                repositoryItemGridLookUpEditLop.DataSource = dtLop;

                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dt.Load(reader);
                bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable dtLop = new DataTable();
                IDataReader readerLop = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonViBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dtLop.Load(readerLop);
                repositoryItemGridLookUpEditLop.DataSource = dtLop;

                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dt.Load(reader);
                bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                DataTable dtLop = new DataTable();
                IDataReader readerLop = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonViBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dtLop.Load(readerLop);
                repositoryItemGridLookUpEditLop.DataSource = dtLop;

                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dt.Load(reader);
                bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion

        #region Event Grid
        private void gridViewGiangVienHDNGD_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaLop" || col.FieldName == "MaHoatDong")
            {
                try
                {
                    DataTable dtLop = repositoryItemGridLookUpEditLop.DataSource as DataTable;
                    DataRowView r = gridViewGiangVienHDNGD.GetRow(e.RowHandle) as DataRowView;
                    DataRow rowLHP = dtLop.Select(String.Format("MaLop = '{0}'", r["MaLop"]))[0];
                    int _siSo = int.Parse(rowLHP["SiSo"].ToString());
                    int _soTiet = int.Parse(rowLHP["SoTiet"].ToString());
                    gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "SiSo", _siSo);
                    gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "SoTiet", _soTiet);
                    if (r["MaHoatDong"].ToString() == "2")
                    {
                       gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "SoLuong", _siSo * (_soTiet/ 15));
                    }
                    if (r["MaHoatDong"].ToString() == "1" || r["MaHoatDong"].ToString() == "9")
                    {
                        gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "SoLuong", _soTiet);
                    }
                    if (r["MaHoatDong"].ToString() == "6" || r["MaHoatDong"].ToString() == "7" || r["MaHoatDong"].ToString() == "8" || r["MaHoatDong"].ToString() == "12" || r["MaHoatDong"].ToString() == "16")
                    {
                        gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "SoLuong", _siSo);
                    }
                }
                catch
                {}
               
            }
        }


        private void gridViewGiangVienHDNGD_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienHDNGD, e);
        }


        #endregion

    }
}