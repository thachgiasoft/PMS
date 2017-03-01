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
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Forms.NghiepVu.ThanhTra
{
    public partial class frmThanhLyXacNhanHopDong : DevExpress.XtraEditors.XtraForm
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
        DateTime _ngayIn;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        VList<ViewKhoaBoMon> _listKhoaBoMon = new VList<ViewKhoaBoMon>();
        #endregion

        #region Event Form
        public frmThanhLyXacNhanHopDong()
        {
            InitializeComponent();

            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }

            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            if (_maTruong == "IUH")
                btnLamTuoi.Caption = "Cập nhật mới";
        }

        private void frmThanhLyXacNhanHopDong_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewXacNhanThanhLyHopDong, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewXacNhanThanhLyHopDong, new string[] { "SoHopDong", "MaQuanLy", "HoTen", "SoTiet", "TietCoiThi", "TongTiet", "ThanhLy", "DaXacNhan", "TenLop", "TenMonHoc" }
                    , new string[] { "Số hợp đồng", "Mã giảng viên", "Họ tên", "Tiết giảng dạy", "Tiết coi thi", "Tổng tiết", "Thanh toán", "Ký xác nhận", "Lớp học", "Môn học" }
                    , new int[] { 100, 80, 150, 80, 80, 80, 100, 100, 100, 120 });
            AppGridView.AlignHeader(gridViewXacNhanThanhLyHopDong, new string[] { "SoHopDong", "MaQuanLy", "HoTen", "SoTiet", "TietCoiThi", "TongTiet", "ThanhLy", "DaXacNhan", "TenLop", "TenMonHoc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewXacNhanThanhLyHopDong, new string[] { "SoHopDong", "MaQuanLy", "HoTen", "SoTiet", "TietCoiThi", "TongTiet", "TenLop", "TenMonHoc" });
            AppGridView.SummaryField(gridViewXacNhanThanhLyHopDong, "SoHopDong", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewXacNhanThanhLyHopDong, "ThanhLy", repositoryItemGridLookUpEditThanhToan);
            AppGridView.RegisterControlField(gridViewXacNhanThanhLyHopDong, "DaXacNhan", repositoryItemGridLookUpEditKyXacNhan);
            #region InitKhoa
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã khoa", "Tên khoa" }, new int[] { 100, 250 });
            AppGridLookupEdit.InitPopupFormSize(cboKhoaDonVi, 350, 650);
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            #region Init ThanhToan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditThanhToan, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditThanhToan, new string[] { "TenHinhThucThanhToan" }, new string[] { "Tên hình thức thanh toán" }, new int[] { 250 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditThanhToan, 250, 250);
            repositoryItemGridLookUpEditThanhToan.ValueMember = "TenHinhThucThanhToan";
            repositoryItemGridLookUpEditThanhToan.DisplayMember = "TenHinhThucThanhToan";
            repositoryItemGridLookUpEditThanhToan.NullText = string.Empty;
            #endregion

            #region Init KyXacNhan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditKyXacNhan, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditKyXacNhan, new string[] { "KyXacNhan" }, new string[] { "Ký xác nhận" }, new int[] { 250 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditKyXacNhan, 250, 250);
            repositoryItemGridLookUpEditKyXacNhan.ValueMember = "Id";
            repositoryItemGridLookUpEditKyXacNhan.DisplayMember = "KyXacNhan";
            repositoryItemGridLookUpEditKyXacNhan.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            dateEditTuNgay.DateTime = DateTime.Now;
            dateEditDenNgay.DateTime = DateTime.Now;

            cboKhoaDonVi.DataBindings.Clear();
            _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            _listKhoaBoMon.Add(new ViewKhoaBoMon() { MaBoMon = "-1", TenBoMon = "[Tất cả]", ThuTu = 0 });
            bindingSourceKhoaDonVi.DataSource = _listKhoaBoMon;
            bindingSourceKhoaDonVi.Sort = "ThuTu";
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            checkEdit1.Checked = true;

            radioGroupXacNhan.SelectedIndex = 0;
            radioGroup1.SelectedIndex = 0;

            txtSoHopDong.Text = string.Empty;

            InitHinhThucThanhToan();

            InitKyXacNhan();
        }

        void InitHinhThucThanhToan()
        {
            DataTable tbl = new DataTable();
            DataColumn col = new DataColumn ("TenHinhThucThanhToan", typeof (string));

            tbl.Columns.Add(col);

            DataRow r1 = tbl.NewRow();
            r1["TenHinhThucThanhToan"] = "Thanh lý";
            DataRow r2 = tbl.NewRow();
            r2["TenHinhThucThanhToan"] = "Tạm ứng";

            tbl.Rows.Add(r1);
            tbl.Rows.Add(r2);

            bindingSourceThanhToan.DataSource = tbl;
        }

        void InitKyXacNhan()
        {
            DataTable tbl = new DataTable();
            DataColumn col1 = new DataColumn("Id", typeof(bool));
            DataColumn col2 = new DataColumn("KyXacNhan", typeof(string));

            tbl.Columns.Add(col1);
            tbl.Columns.Add(col2);

            DataRow r1 = tbl.NewRow();
            r1["Id"] = true;
            r1["KyXacNhan"] = "Đã ký xác nhận";
            DataRow r2 = tbl.NewRow();
            r2["Id"] = false;
            r2["KyXacNhan"] = "Chưa ký xác nhận";

            tbl.Rows.Add(r1);
            tbl.Rows.Add(r2);

            bindingSourceKyXacNhan.DataSource = tbl;
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboKhoaDonVi.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.DanhSachHopDongThinhGiang.LayDanhSachThanhLyXacNhanHopDong(cboKhoaDonVi.EditValue.ToString(), dateEditTuNgay.DateTime, dateEditDenNgay.DateTime, txtSoHopDong.Text, checkEdit1.Checked);
                tbl.Load(reader);
                bindingSourceXacNhanThanhLyHopDong.DataSource = tbl;
                gridViewXacNhanThanhLyHopDong.BestFitColumns();
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewXacNhanThanhLyHopDong.FocusedRowHandle = -1;
            DataTable tb = bindingSourceXacNhanThanhLyHopDong.DataSource as DataTable;
            if (tb != null || tb.Rows.Count > 0)
            {
                try
                {
                    string xmlData = "";
                    if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       
                        foreach (DataRow r in tb.Rows)
                        {
                            if (r.RowState == DataRowState.Modified)
                            {
                                xmlData += String.Format("<Input M=\"{0}\" L=\"{1}\" T=\"{2}\" X=\"{3}\" />", r["MaQuanLy"], r["MaLopHocPhan"], r["ThanhLy"], r["DaXacNhan"]);
                            }
                        }

                        xmlData = String.Format("<Root>{0}</Root>", xmlData);
                    }

                    int kq = -1;

                    DataServices.DanhSachHopDongThinhGiang.LuuThanhLyXacNhanHopDong(xmlData, ref kq);

                    if (kq == 0)
                        XtraMessageBox.Show("Lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlXNTLHD.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Event value changed
        private void radioGroupXacNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridColumn colFilter = gridViewXacNhanThanhLyHopDong.Columns["DaXacNhan"];

            if (radioGroupXacNhan.SelectedIndex == 0)
                colFilter.FilterInfo = new ColumnFilterInfo();
            if (radioGroupXacNhan.SelectedIndex == 1)
                colFilter.FilterInfo = new ColumnFilterInfo(colFilter, true);
            if (radioGroupXacNhan.SelectedIndex == 2)
                colFilter.FilterInfo = new ColumnFilterInfo(colFilter, false);
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridColumn colFilter = gridViewXacNhanThanhLyHopDong.Columns["ThanhLy"];
            if (radioGroup1.SelectedIndex == 0)
                colFilter.FilterInfo = new ColumnFilterInfo();
            if (radioGroup1.SelectedIndex == 1)
                colFilter.FilterInfo = new ColumnFilterInfo(colFilter, (object)"Thanh lý");
            if (radioGroup1.SelectedIndex == 2)
                colFilter.FilterInfo = new ColumnFilterInfo(colFilter, (object)"Tạm ứng");
        }

        private void txtSoHopDong_TextChanged(object sender, EventArgs e)
        {
            GridColumn colFilter = gridViewXacNhanThanhLyHopDong.Columns["SoHopDong"];
            if (txtSoHopDong.Text != "")
                colFilter.FilterInfo = new ColumnFilterInfo(colFilter, (object)txtSoHopDong.Text, String.Format("SoHopDong like '%{0}%'", txtSoHopDong.Text));
            else
                colFilter.FilterInfo = new ColumnFilterInfo();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.CheckState == CheckState.Checked)
            {
                dateEditTuNgay.Enabled = false;
                dateEditDenNgay.Enabled = false;
            }
            else
            {
                dateEditTuNgay.Enabled = true;
                dateEditDenNgay.Enabled = true;
            }
        }
        #endregion
    }
}