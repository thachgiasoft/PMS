using System;
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
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmHoatDongNgoaiGiangDayCLC : DevExpress.XtraEditors.XtraForm
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
        string _groupName = UserInfo.GroupName;
        bool _userRole;
        VList<ViewGiangVien> _listGiangVien;
        TList<HoatDongNgoaiGiangDay> _listHoatDong;
        #endregion

        #region Event Form
        public frmHoatDongNgoaiGiangDayCLC()
        {
            InitializeComponent();
        }

        private void frmHoatDongNgoaiGiangDayCLC_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewHoatDongNgoaiGiangDayCLC, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHoatDongNgoaiGiangDayCLC, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHoatDongNgoaiGiangDayCLC, new string[] { "MaGiangVien", "HoTen", "MaHoatDong", "MaLopHocPhan", "SoTien", "GhiChu" }
                        , new string[] { "Mã giảng viên", "Họ Tên", "Tên hoạt động", "Mã lớp", "Số tiền", "Ghi chú" }
                        , new int[] { 90, 150, 350, 110, 100, 120 });
            AppGridView.AlignHeader(gridViewHoatDongNgoaiGiangDayCLC, new string[] { "MaGiangVien", "HoTen", "MaHoatDong", "MaLopHocPhan", "SoTien", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewHoatDongNgoaiGiangDayCLC, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewHoatDongNgoaiGiangDayCLC, "SoTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewHoatDongNgoaiGiangDayCLC, "SoTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewHoatDongNgoaiGiangDayCLC, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewHoatDongNgoaiGiangDayCLC, "MaHoatDong", repositoryItemGridLookUpEditHoatDong);
            AppGridView.RegisterControlField(gridViewHoatDongNgoaiGiangDayCLC, "MaLopHocPhan", repositoryItemGridLookUpEditLopHocPhan);
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region Học kỳ
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
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
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region HoatDongNgoaiGiangDay
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHoatDong, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHoatDong, new string[] { "TenHoatDong", "MucQuyDoi", "DonGia", "GhiChu" }, new string[] { "Tên hoạt động", "Mức quy đổi", "Đơn giá", "Ghi chú" }, new int[] { 300, 100, 100, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHoatDong, 600, 650);
            repositoryItemGridLookUpEditHoatDong.DisplayMember = "TenHoatDong";
            repositoryItemGridLookUpEditHoatDong.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditHoatDong.NullText = string.Empty;
            #endregion

            #region LopHocPhan

            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLopHocPhan, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLopHocPhan, new string[] { "MaLop", "TenLop" }, new string[] { "Mã lớp", "Tên môn" }, new int[] { 50, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLopHocPhan, 500, 450);
            repositoryItemGridLookUpEditLopHocPhan.DisplayMember = "MaLop";
            repositoryItemGridLookUpEditLopHocPhan.ValueMember = "MaLop";
            repositoryItemGridLookUpEditLopHocPhan.NullText = string.Empty;
            #endregion
            InitData();
        }
        #endregion
        #region InitData
        void InitData()
        {
            #region _namHoc-_hocKy
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            #endregion

            #region _khoaDonVi
            cboKhoaDonVi.DataBindings.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    _userRole = true;
                    break;
                }
                else
                {
                    _userRole = false;
                }
            }

            if (_userRole)
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
            }
            else
            {
                _vListKhoaBoMon.Add(new ViewKhoaBoMon() { ThuTu = 0, MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            }

            bindingSourceKhoaDonVi.DataSource = _vListKhoaBoMon;

            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region GiangVien
            InitGiangVien();
            #endregion

            #region HoatDong
            _listHoatDong = DataServices.HoatDongNgoaiGiangDay.GetAll();
            bindingSourceHoatDong.DataSource = _listHoatDong;
            #endregion

            #region LopHocPhan
            InitLopHocPhan();
            #endregion

            LoadDataSource();
        }

        void InitGiangVien()
        {
            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                bindingSourceGiangVien.DataSource = _listGiangVien;
            }
        }

        void InitLopHocPhan()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                //DataTable dtLop = Libraries.BLL.DBComunication.ExecProc("sp_psc_pms_getLop"
                //        , new object[] { cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString() });
                DataTable dtLop = new DataTable();
                IDataReader readerLop = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonViBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dtLop.Load(readerLop);
                bindingSourceLopHocPhan.DataSource = dtLop;
            }
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.HoatDongNgoaiGiangDayClc.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn col in tb.Columns)
                {
                    col.ReadOnly = false;
                }
                bindingSourceHoatDongNgoaiGiangDayCLC.DataSource = tb;
            }
        }
        #endregion

        #region Event CBO
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }

            InitLopHocPhan();

            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLopHocPhan();

            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitGiangVien();
            InitLopHocPhan();
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Button


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLayDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                int kq = 0;
                DataServices.HoatDongNgoaiGiangDayClc.KiemTraDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kq);

                if (kq == 0)
                {
                    if (XtraMessageBox.Show(string.Format("Bạn muốn thực hiện lấy dữ liệu năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            DataServices.HoatDongNgoaiGiangDayClc.LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            XtraMessageBox.Show("Lấy dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        { }
                    }
                }
                else
                {
                    if (XtraMessageBox.Show(string.Format("Dữ liệu hoạt động ngoài giảng dạy của năm học {0} - {1} đã có, tiếp tục lấy dữ liệu sẽ ghi đè dữ liệu cũ.\n Bạn có muốn tiếp tục?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            DataServices.HoatDongNgoaiGiangDayClc.LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            XtraMessageBox.Show("Lấy dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        { }
                    }
                }

                barButtonItem1.PerformClick();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHoatDongNgoaiGiangDayCLC);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHoatDongNgoaiGiangDayCLC.FocusedRowHandle = -1;
            DataTable tb = bindingSourceHoatDongNgoaiGiangDayCLC.DataSource as DataTable;
            if (tb != null)
            {
                if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        int result = -1;
                        foreach (DataRow row in tb.Rows)
                        {
                            if (row.RowState != DataRowState.Deleted)
                            {
                                if (row["MaGiangVien"].ToString() != "" && row["MaHoatDong"].ToString() != "" && row["MaLopHocPhan"].ToString() != "")
                                {
                                    xmlData += "<Input M=\"" + row["MaGiangVien"]
                                            + "\" L=\"" + row["MaLopHocPhan"]
                                            + "\" H=\"" + row["MaHoatDong"]
                                            + "\" T=\"" + row["SoTien"]
                                            + "\" G=\"" + row["GhiChu"]
                                            + "\" />";
                                }
                                else
                                {
                                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin họ tên, hoạt động và mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }

                        xmlData = "<Root>" + xmlData + "</Root>";

                        DataServices.HoatDongNgoaiGiangDayClc.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref result);

                        if(result == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {  }
                   
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlQuyDoi.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
        #endregion

        #region Event Grid
        private void gridViewHoatDongNgoaiGiangDayCLC_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaGiangVien")
            {
                DataRowView r = gridViewHoatDongNgoaiGiangDayCLC.GetRow(e.RowHandle) as DataRowView;
                ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(r["MaGiangVien"].ToString()));
                gridViewHoatDongNgoaiGiangDayCLC.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
            }
        }

        private void gridViewHoatDongNgoaiGiangDayCLC_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHoatDongNgoaiGiangDayCLC, e);
        }

        private void gridViewHoatDongNgoaiGiangDayCLC_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //Mặc định khi thêm mới lấy hoạt động CLC
            HoatDongNgoaiGiangDay hd = _listHoatDong.Find(p => p.MaQuanLy == 17);
            gridViewHoatDongNgoaiGiangDayCLC.SetRowCellValue(e.RowHandle, "MaHoatDong", 17);
            gridViewHoatDongNgoaiGiangDayCLC.SetRowCellValue(e.RowHandle, "SoTien", hd.DonGia);
        }
        #endregion

    }
}