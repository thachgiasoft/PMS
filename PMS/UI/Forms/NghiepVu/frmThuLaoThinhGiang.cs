using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThuLaoThinhGiang : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        bool userRole;
        string _groupName = UserInfo.GroupName;
        DataTable tb;
        #endregion

        #region Event Form
        public frmThuLaoThinhGiang()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmThuLaoThinhGiang_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThuLaoThinhGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThuLaoThinhGiang, new string[] { "XacNhanChiTra", "MaQuanLy", "Ho", "Ten", "ChucDanh", "TenMonHoc", "MaLop", "SiSo", "NoiDung", "SoTiet", "HeSo", "HeSoChucDanh", "CongHeSo", "SoTietQuyDoi", "DonGia", "ThanhTien", "Thue", "ConNhan", "GhiChu", "TenDonVi", "Stt", "MaLopHocPhan", "MaGiangVien", "NgayXacNhan" }
                , new string[] { "Xác nhận", "Mã giảng viên", "Họ", "Tên", "Chức danh", "Tên môn", "Lớp", "Sĩ số", "Nội dung", "Số tiết", "HS QĐGC", "HS chức danh", "Tổng HS", "Tiết quy đổi", "Đơn giá", "Thành tiền", "Thuế TNCN", "Còn nhận", "Ghi chú", "Tên khoa - Đơn vị", "STT", "Mã lớp học phần", "ID giảng viên", "Ngày xác nhận" }
                , new int[] { 70, 90, 115, 55, 120, 120, 80, 50, 120, 50, 70, 90, 60, 85, 60, 70, 80, 70, 70, 99, 99, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewThuLaoThinhGiang, new string[] { "XacNhanChiTra", "MaQuanLy", "Ho", "Ten", "ChucDanh", "TenMonHoc", "MaLop", "SiSo", "NoiDung", "SoTiet", "HeSo", "HeSoChucDanh", "CongHeSo", "SoTietQuyDoi", "DonGia", "ThanhTien", "Thue", "ConNhan", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.FixedField(gridViewThuLaoThinhGiang, new string[] { "XacNhanChiTra", "MaQuanLy", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            //AppGridView.MergeCell(gridViewThuLaoThinhGiang, new string[] { "XacNhanChiTra", "MaQuanLy", "Ho", "Ten", "NoiDung", "SoTiet", "HeSo", "HeSoChucDanh", "CongHeSo", "DonGia", "ThanhTien", "Thue", "ConNhan", "GhiChu" });
            AppGridView.HideField(gridViewThuLaoThinhGiang, new string[] { "Stt", "MaLopHocPhan", "MaGiangVien", "NgayXacNhan" });
            AppGridView.FormatDataField(gridViewThuLaoThinhGiang, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoThinhGiang, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoThinhGiang, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoThinhGiang, "ConNhan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewThuLaoThinhGiang, new string[] { "MaQuanLy", "Ho", "Ten", "ChucDanh", "TenMonHoc", "MaLop", "SiSo", "NoiDung", "SoTiet", "HeSo", "HeSoChucDanh", "CongHeSo", "SoTietQuyDoi", "DonGia", "ThanhTien", "Thue", "ConNhan", "GhiChu", "TenDonVi", "Stt" });
            gridViewThuLaoThinhGiang.Columns["TenDonVi"].GroupIndex = 0;

            PMS.Common.Globals.GridRowColor(gridViewThuLaoThinhGiang, new Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold), Color.Aquamarine, "Stt", "0");
            AppGridView.SummaryField(gridViewThuLaoThinhGiang, "MaLop", "{0}", DevExpress.Data.SummaryItemType.Count);
            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            #region Init Khoa-DonVi
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    userRole = true;
                    break;
                }
                else
                    userRole = false;
            }

            if (userRole)
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
            }

            _vListKhoaBoMon.Sort("TenKhoa");
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (v.MaKhoa == v.MaBoMon)
                    _list.Add(new CheckedListBoxItem(v.MaKhoa, v.MaKhoa + " - " + v.TenKhoa, CheckState.Unchecked, true));
            }

            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion

            #region Init BacDaoTao
            cboBacDaoTao.Properties.SelectAllItemCaption = "Tất cả";
            cboBacDaoTao.Properties.TextEditStyle = TextEditStyles.Standard;
            cboBacDaoTao.Properties.Items.Clear();

            VList<ViewBacDaoTao> _vListBacDaoTao = DataServices.ViewBacDaoTao.GetAll();

            List<CheckedListBoxItem> _listBac = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _vListBacDaoTao)
            {
                _listBac.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.MaBacDaoTao + " - " + v.TenBacDaoTao, CheckState.Unchecked, true));
            }

            cboBacDaoTao.Properties.Items.AddRange(_listBac.ToArray());
            cboBacDaoTao.Properties.SeparatorChar = ';';
            cboBacDaoTao.CheckAll();
            #endregion
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null && cboBacDaoTao.EditValue != null)
            {
                tb = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetThuLaoThinhGiangNamHocHocKyDonViBacDaoTao(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["XacNhanChiTra"].ReadOnly = false;
                bindingSourceThuLaoThinhGiang.DataSource = tb;
                gridViewThuLaoThinhGiang.ExpandAllGroups();
            }
        }
        #endregion

        #region Event Button
        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewThuLaoThinhGiang.FocusedRowHandle = -1;
                DataTable dt = bindingSourceThuLaoThinhGiang.DataSource as DataTable;
                if (dt != null)
                {
                    if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string xmlData = "";
                        foreach (DataRow r in dt.Rows)
                        {
                            if (r.RowState == DataRowState.Modified)
                            { 
                                xmlData+= "<Input MGV=\""+r["MaGiangVien"]
                                        + "\" MLHP=\"" + r["MaLopHocPhan"]
                                        + "\" CD=\"" + r["ChucDanh"]
                                        + "\" ML=\"" + r["MaLop"]
                                        + "\" SS=\"" + r["SiSo"]
                                        + "\" TT=\"" + r["Stt"]
                                        + "\" ND=\"" + r["NoiDung"]
                                        + "\" ST=\"" + PMS.Common.Globals.IsNull(r["SoTiet"], "decimal")
                                        + "\" HS=\"" + PMS.Common.Globals.IsNull(r["HeSo"], "decimal")
                                        + "\" HSCD=\"" + PMS.Common.Globals.IsNull(r["HeSoChucDanh"], "decimal")
                                        + "\" CHS=\"" + PMS.Common.Globals.IsNull(r["CongHeSo"], "decimal")
                                        + "\" DG=\"" + PMS.Common.Globals.IsNull(r["DonGia"], "decimal")
                                        + "\" T=\"" + PMS.Common.Globals.IsNull(r["ThanhTien"], "decimal")
                                        + "\" TH=\"" + PMS.Common.Globals.IsNull(r["Thue"], "decimal")
                                        + "\" CN=\"" + PMS.Common.Globals.IsNull(r["ConNhan"], "decimal")
                                        + "\" GC=\"" + r["GhiChu"]
                                        + "\" N=\"" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                                        + "\" X=\"" + PMS.Common.Globals.IsNull(r["XacNhanChiTra"], "bool")
                                        + "\" />";
                            }
                        }

                        xmlData = "<Root>" + xmlData + "</Root>";

                        int result = 0;

                        DataServices.ThanhToanThinhGiang.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref result);

                        if(result == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã có lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        LoadDataSource();
                    }
                }
            }
            catch 
            { }
            
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }
        #endregion

        #region Event Grid
  
        private void gridViewThuLaoThinhGiang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "XacNhanChiTra")
                {
                    DataRowView v = gridViewThuLaoThinhGiang.GetRow(e.RowHandle) as DataRowView;
                    DataTable dt = bindingSourceThuLaoThinhGiang.DataSource as DataTable;

                    foreach (DataRow r in dt.Rows)
                    {
                        if (r["MaLopHocPhan"].ToString() == v["MaLopHocPhan"].ToString())
                        {
                            if (v["XacNhanChiTra"].ToString().ToLower() == "true")
                            {
                                r["XacNhanChiTra"] = true;
                            }
                            else r["XacNhanChiTra"] = false;
                        }
                    }
                }
            }
            catch
            { }
        }
        #endregion

    }
}