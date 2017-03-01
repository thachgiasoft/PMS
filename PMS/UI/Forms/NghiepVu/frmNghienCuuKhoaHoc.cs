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
//using Libraries.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmNghienCuuKhoaHoc : DevExpress.XtraEditors.XtraForm
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

                btnImportExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnImportExcel.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnImportExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        VList<ViewKhoaBoMon> _listBoMon = new VList<ViewKhoaBoMon>();
        DataTable _dtData;
        #endregion

        #region Event Form
        public frmNghienCuuKhoaHoc()
        {
            InitializeComponent();
            _maTruong = _listCauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            if (_maTruong != "USSH")
                layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void frmNghienCuuKhoaHoc_Load(object sender, EventArgs e)
        {
            #region Init GridView
            switch (_maTruong)
            { 
                case "LAW":
                    InitGridLAW();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            #region Init GiangVien
            if (_maTruong != "BUH")
            {
                AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
                AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "Ho", "Ten" }, new string[] { "Mã giảng viên", "Họ", "Tên" });
                repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
                repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
                repositoryItemGridLookUpEditGiangVien.NullText = "Chọn mã giảng viên";
            }
            else
            {
                AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
                AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien
                    , new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã giảng viên", "Họ tên" });
                repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
                repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
                repositoryItemGridLookUpEditGiangVien.NullText = "Chọn mã giảng viên";
            }
            #endregion

            #region _khoaDonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboKhoaDonVi, 650, 300);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon", "MaKhoa", "TenKhoa" }, new string[] { "Mã bộ môn", "Tên bộ môn", "Mã khoa", "Tên khoa" }, new int[] { 90, 210, 90, 210 });
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;

            cboKhoaDonVi.EditValueChanged += cboKhoaDonVi_EditValueChanged;
            #endregion
            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;

            //cboNamHoc.EditValueChanged += delegate(object sd, EventArgs v)
            //{
            //    if (cboNamHoc.EditValue != null)
            //        bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            //    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            //    {
            //        _dtData = DBComunication.Join(JoinType.InnerJoin, "GiangVien_DinhMucKhauTru", "View_GiangVien"
            //        , "GiangVien_DinhMucKhauTru.MaGiangVien = View_GiangVien.MaGiangVien", "_namHoc = {0} and _hocKy = {1}", false, true
            //        , null, new string[] { "HoTen" }
            //        , new object[] { cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString() });
            //        _dtData.Columns["MaDinhMucKhauTru"].ReadOnly = false;
            //        gridControlCoVanHocTap.DataSource = _dtData;
            //    }

            //};

            #endregion
            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;

            //cboHocKy.EditValueChanged += delegate(object obj, EventArgs v)
            //{
            //    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            //    {
            //        _dtData = DBComunication.Join(JoinType.InnerJoin, "GiangVien_DinhMucKhauTru", "View_GiangVien"
            //       , "GiangVien_DinhMucKhauTru.MaGiangVien = View_GiangVien.MaGiangVien", "_namHoc = {0} and _hocKy = {1}", false, true
            //       , null, new string[] { "HoTen" }
            //       , new object[] { cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString() });
            //        _dtData.Columns["MaDinhMucKhauTru"].ReadOnly = false;
            //        gridControlCoVanHocTap.DataSource = _dtData;
            //    }
            //};
            #endregion
            InitData();
        }
        #endregion

        #region InitGridView
        void InitGridLAW()
        {
            AppGridView.InitGridView(gridViewCoVanHocTap, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewCoVanHocTap, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewCoVanHocTap, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "SoTietDinhMuc", "SoTietThucHien" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Số tiết định mức", "Số tiết giảng chuyển sang NCKH" }
                    , new int[] { 90, 120, 80, 100, 100, 100, 100 });
            AppGridView.RegisterControlField(gridViewCoVanHocTap, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.AlignHeader(gridViewCoVanHocTap, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "SoTietDinhMuc", "SoTietThucHien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewCoVanHocTap, new string[] { "Ho", "Ten", "TenHocHam", "TenHocVi" });
            AppGridView.HideField(gridViewCoVanHocTap, new string[] { "SoTietDinhMuc" });
            PMS.Common.Globals.WordWrapHeader(gridViewCoVanHocTap, 40);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewCoVanHocTap, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewCoVanHocTap, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewCoVanHocTap, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "SoTietDinhMuc", "SoTietThucHien" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Số tiết định mức", "Số tiết thực hiện" }
                    , new int[] { 90, 120, 80, 100, 100, 100, 100 });
            AppGridView.RegisterControlField(gridViewCoVanHocTap, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.AlignHeader(gridViewCoVanHocTap, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "SoTietDinhMuc", "SoTietThucHien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewCoVanHocTap, new string[] { "Ho", "Ten", "TenHocHam", "TenHocVi" });
            AppGridView.HideField(gridViewCoVanHocTap, new string[] { "SoTietDinhMuc" });
        }
        #endregion
        #region InitData
        void InitData()
        {
            cboKhoaDonVi.DataBindings.Clear();
            _listBoMon = DataServices.ViewKhoaBoMon.GetAll();
            _listBoMon.Add(new ViewKhoaBoMon() { MaBoMon = "-1", TenBoMon = "[Tất cả]", MaKhoa = "-1", TenKhoa = "[Tất cả]" });
            bindingSourceKhoaDonVi.DataSource = _listBoMon;
            bindingSourceKhoaDonVi.Sort = "TenKhoa, TenBoMon";
           
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
            if (cboKhoaDonVi.EditValue.ToString() != "")
                if (_maTruong != "BUH")
                    bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                else
                    //bindingSourceGiangVien.DataSource = bindingSourceGiangVien.DataSource = Libraries.BLL.DBComunication
                    //    .GetTable("View_GiangVien_Khoa", "MaBoMon = {0}", new object[] { cboKhoaDonVi.EditValue.ToString() });
                    bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                    
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (_maTruong == "USSH")
            {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHocHocKy(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            else if (_maTruong == "BUH") {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null) {
                    //_dtData = Libraries.BLL.DBComunication.Join(Libraries.BLL.JoinType.InnerJoin, "NghienCuuKhoaHoc", "view_GiangVien_NghienCuuKhoaHoc"
                    //    , "NghienCuuKhoaHoc.MaGiangVien = view_GiangVien_NghienCuuKhoaHoc.MaGiangVien"
                    //    , "view_GiangVien_NghienCuuKhoaHoc.MaDonVi = {0} and view_GiangVien_NghienCuuKhoaHoc._namHoc = {1} and NghienCuuKhoaHoc._hocKy = {2}"
                    //    , false, true, null, new string[]{"TenHocHam", "TenHocVi", "Ho", "Ten"}
                    //    , new object[] { cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString() });

                   // gridControlCoVanHocTap.DataSource = _dtData;
                    //bindingSourceNghienCuuKhoaHoc.DataSource = _dtData;
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHocHocKy(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(),cboHocKy.EditValue.ToString());
                }                    
            }
            else
            {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null)
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHoc(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString());
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
            AppGridView.DeleteSelectedRows(gridViewCoVanHocTap);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewCoVanHocTap.FocusedRowHandle = -1;
            if (_maTruong != "BUH")
            {
                string XMLData = "<Root>";
                VList<ViewGiangVienNghienCuuKhoaHoc> list = bindingSourceNghienCuuKhoaHoc.DataSource as VList<ViewGiangVienNghienCuuKhoaHoc>;
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bindingSourceNghienCuuKhoaHoc.EndEdit();
                    foreach (ViewGiangVienNghienCuuKhoaHoc nckh in list)
                    {
                        if (nckh.MaGiangVien != 0)
                        {
                            XMLData += "<NghienCuuKhoaHoc MaGiangVien = \"" + nckh.MaGiangVien
                                                + "\" SoTietDinhMuc = \"" + PMS.Common.Globals.IsNull(nckh.SoTietDinhMuc, "decimal")
                                                + "\" SoTietThucHien = \"" + PMS.Common.Globals.IsNull(nckh.SoTietThucHien, "decimal")
                                                + "\" />";
                        }
                        else
                        {
                            XtraMessageBox.Show("Mã giảng viên không được phép bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    XMLData += "</Root>";

                    int kq = 0; string _hocKy;
                    if (_maTruong == "USSH")
                        _hocKy = cboHocKy.EditValue.ToString();
                    else
                        _hocKy = "";
                    DataServices.NghienCuuKhoaHoc.Luu(XMLData, cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), _hocKy, ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else//Trường BUH
            {
                string XMLData = "<Root>";
                VList<ViewGiangVienNghienCuuKhoaHoc> list = bindingSourceNghienCuuKhoaHoc.DataSource as VList<ViewGiangVienNghienCuuKhoaHoc>;
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bindingSourceNghienCuuKhoaHoc.EndEdit();
                    foreach (ViewGiangVienNghienCuuKhoaHoc nckh in list)
                    {
                        if (nckh.MaGiangVien == null || nckh.SoTietThucHien==null)
                        {
                            XtraMessageBox.Show("Chưa nhập mã giảng viên hoặc số tiết thực hiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        XMLData += "<NghienCuuKhoaHoc MaGiangVien = \"" + nckh.MaGiangVien
                                            + "\" SoTietDinhMuc = \"" + PMS.Common.Globals.IsNull(nckh.SoTietDinhMuc,"decimal")
                                            + "\" SoTietThucHien = \"" + PMS.Common.Globals.IsNull(nckh.SoTietThucHien, "decimal")
                                            + "\" />";
                    }
                    XMLData += "</Root>";

                    int kq = 0; 

                    DataServices.NghienCuuKhoaHoc.Luu(XMLData, cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                InitData();
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Cbo
        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue.ToString() != "")
            {
                if (_maTruong != "BUH")
                    bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                else
                {
                    //bindingSourceGiangVien.DataSource = Libraries.BLL.DBComunication
                    //    .GetTable("View_GiangVien_Khoa", "MaBoMon = {0}", new object[] { cboKhoaDonVi.EditValue.ToString() });
                    bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                    repositoryItemGridLookUpEditGiangVien.BestFitMode = BestFitMode.BestFit;
                }
            }

            if (_maTruong == "USSH")
            {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHocHocKy(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            else if (_maTruong == "BUH")
            {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHocHocKy(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            else
            {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null)
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHoc(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Grid
        private void gridViewCoVanHocTap_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            object r = gridViewCoVanHocTap.GetRow(pos);
            if (_maTruong == "BUH")
            {

                ViewGiangVienNghienCuuKhoaHoc drCurr = gridViewCoVanHocTap.GetRow(pos) as ViewGiangVienNghienCuuKhoaHoc;
                if (col.FieldName == "MaGiangVien") {
                    if (drCurr.MaGiangVien != null)
                    {
                        ViewGiangVien vGiangVien = DataServices.ViewGiangVien.Get("MaGiangVien = " + (drCurr.MaGiangVien.ToString()), "MaGiangVien")[0];
                        if (vGiangVien != null)
                        {
                            //_dtData.SetReadOnly(false);
                            drCurr.Ho = vGiangVien.Ho;
                            drCurr.Ten = vGiangVien.Ten;
                            drCurr.TenHocHam = vGiangVien.TenHocHam;
                            drCurr.TenHocVi = vGiangVien.TenHocVi;

                            //int soTietDMuc;

                            //DataTable dt = DBComunication.GetTable("DinhMucGioChuan"
                            //    , "isnull(MaHocHam,'') = isnull({0},'') and isnull(MaHocVi,'') = isnull({1}, '')"
                            //    , false, false, new string[]{"DinhMucNcKh"}
                            //    , new object[]{vGiangVien.MaHocHam, vGiangVien.MaHocVi});

                            //if (dt != null && dt.Rows.Count > 0) {
                            //    int.TryParse(dt.Rows[0]["DinhMucNcKh"].ToString(), out soTietDMuc);
                            //    drCurr.SoTietDinhMuc = soTietDMuc/2;
                            //}
                            //_dtData.SetReadOnly(true, new string[] { "SoTietThucHien", "MaGiangVien" });
                        }
                    }
                }
            }
            else
            {
                ViewGiangVienNghienCuuKhoaHoc o = (ViewGiangVienNghienCuuKhoaHoc)r;
                if (col.FieldName == "MaGiangVien")
                {
                    if (o.MaGiangVien != null)
                    {
                        ViewGiangVien vGiangVien = DataServices.ViewGiangVien.Get("MaGiangVien = " + o.MaGiangVien, "MaGiangVien")[0];
                        if (vGiangVien != null)
                        {
                            gridViewCoVanHocTap.SetRowCellValue(pos, "Ho", vGiangVien.Ho);
                            gridViewCoVanHocTap.SetRowCellValue(pos, "Ten", vGiangVien.Ten);
                            gridViewCoVanHocTap.SetRowCellValue(pos, "TenHocHam", vGiangVien.TenHocHam);
                            gridViewCoVanHocTap.SetRowCellValue(pos, "TenHocVi", vGiangVien.TenHocVi);
                        }
                    }
                }
            }
        }
        #endregion

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_maTruong == "USSH")
            {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHocHocKy(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            else if (_maTruong == "BUH")
            {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHocHocKy(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            else
            {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null)
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHoc(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (_maTruong == "USSH")
            {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHocHocKy(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            else if (_maTruong == "BUH")
            {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHocHocKy(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            else
            {
                if (cboKhoaDonVi.EditValue != null && cboNamHoc.EditValue != null)
                    bindingSourceNghienCuuKhoaHoc.DataSource = DataServices.ViewGiangVienNghienCuuKhoaHoc.GetByMaDonViNamHoc(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnImportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmImportNghienCuuKhoaHoc frm = new frmImportNghienCuuKhoaHoc ())
            {
                frm.ShowDialog();
            }

            InitData();
        }
    }

}