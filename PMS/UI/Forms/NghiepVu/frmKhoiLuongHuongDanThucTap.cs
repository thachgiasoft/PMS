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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKhoiLuongHuongDanThucTap : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongBo.ShortCut = Shortcut.None;

                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ShortCut = Shortcut.None;

                btnChiaNhom.Enabled = false;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = false;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnChiaNhom.Enabled = true;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewGiangVien> _listGiangVien;
        #endregion

        #region Event Form
        public frmKhoiLuongHuongDanThucTap()
        {
            InitializeComponent();
        }

        private void frmKhoiLuongHuongDanThucTap_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuong, new string[] { "ScheduleStudyUnitAlias", "TenMonHoc", "MaBacDaoTao", "LopSinhVien", "TenNganh", "Nhom", "SiSo", "MaGiangVien", "HoTen", "TenDonVi", "SoTuan", "HeSo", "TietQuyDoi", "DonGia", "ThanhTien", "NgayCapNhat", "NguoiCapNhat", "LopChinh", "Id" },
                        new string[] { "Mã lớp học phần", "Tên học phần", "Bậc đào tạo", "Lớp", "Ngành", "Nhóm", "Sĩ số", "Mã giảng viên", "Họ tên", "Khoa - Bộ môn", "Số ngày", "Hệ số", "Tiết quy đổi", "Đơn giá", "Thành tiền", "ngày cập nhật", "Người cập nhật", "Lớp gốc", "Id" },
                        new int[] { 110, 150, 80, 70, 90, 70, 60, 80, 170, 150, 60, 60, 80, 80, 90, 99, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "ScheduleStudyUnitAlias", "TenMonHoc", "MaBacDaoTao", "LopSinhVien", "TenNganh", "Nhom", "SiSo", "MaGiangVien", "HoTen", "TenDonVi", "SoTuan", "HeSo", "TietQuyDoi", "DonGia", "ThanhTien", "NgayCapNhat", "NguoiCapNhat", "LopChinh", "Id" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuong, new string[] { "ScheduleStudyUnitAlias", "TenMonHoc", "MaBacDaoTao", "LopSinhVien", "TenNganh", "HoTen", "TenDonVi", "HeSo", "TietQuyDoi", "DonGia", "ThanhTien" });
            AppGridView.HideField(gridViewKhoiLuong, new string[] { "NgayCapNhat", "NguoiCapNhat", "LopChinh", "Id" });
            AppGridView.FormatDataField(gridViewKhoiLuong, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuong, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewKhoiLuong, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            
            PMS.Common.Globals.GridRowColor(gridViewKhoiLuong, new Font("Tahoma", 8, FontStyle.Bold), Color.White, "LopChinh", "True");

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

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 500, 650);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị" }, new int[] { 100, 180, 220 });
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion
            InitData();
        }
        #endregion

        #region Function
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KhoiLuongHuongDanThucTap.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn r in tb.Columns)
                {
                    r.ReadOnly = false;
                }
                bindingSourceKhoiLuong.DataSource = tb;

                KiemTraChot();
            }

            gridViewKhoiLuong.BestFitColumns();
        }

        void KiemTraChot()
        {
            int kq = 0;
            DataServices.KhoiLuongHuongDanThucTap.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
            if (kq == 1)//Đã chốt
            {
                btnChot.Enabled = false;
                btnDongBo.Enabled = false;
                btnQuyDoi.Enabled = false;
                btnChiaNhom.Enabled = false;
                btnLuu.Enabled = false;
                lblGhiChu.Text = String.Format("Ghi chú: khối lượng hướng dẫn thực tập năm học {0} - {1} đã chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            else
            {
                btnChot.Enabled = true;
                btnDongBo.Enabled = true;
                btnQuyDoi.Enabled = true;
                btnChiaNhom.Enabled = true;
                btnLuu.Enabled = true;
                lblGhiChu.Text = "";
            }
        }
        #endregion

        #region Event button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnDongBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn đồng bộ khối lượng hướng dẫn thực tập năm học {0} - {1}", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int kq = 0;

                        DataServices.KhoiLuongHuongDanThucTap.DongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Cursor.Current = Cursors.WaitCursor;
                        InitData();
                        Cursor.Current = Cursors.Default;
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn quy đổi khối lượng hướng dẫn thực tập năm học {0} - {1}", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int kq = 0;

                        DataServices.KhoiLuongHuongDanThucTap.QuyDoi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Quy đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Cursor.Current = Cursors.WaitCursor;
                        InitData();
                        Cursor.Current = Cursors.Default;
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlKhoiLuong.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            if (bindingSourceKhoiLuong.DataSource != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn chốt khối lượng hướng dẫn thực tập năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "THông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataServices.KhoiLuongHuongDanThucTap.Chot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor.Current = Cursors.WaitCursor;
                    InitData();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (bindingSourceKhoiLuong.DataSource != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt khối lượng hướng dẫn thực tập năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "THông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataServices.KhoiLuongHuongDanThucTap.HuyChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor.Current = Cursors.WaitCursor;
                    InitData();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewKhoiLuong.FocusedRowHandle = -1;
            DataTable tb = bindingSourceKhoiLuong.DataSource as DataTable;
            if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string xmlData = "";
                    foreach (DataRow r in tb.Rows)
                    {
                        if (r["LopChinh"].ToString().ToLower() == "false" && r.RowState == DataRowState.Modified)
                        {
                            xmlData += "<Input Stt =\"" + r["Id"].ToString()
                                    + "\" MaMonHoc=\"" + r["Nhom"].ToString()
                                    + "\" SS=\"" + r["SiSo"]
                                    + "\" M=\"" + r["MaGiangVien"]
                                    + "\" ST=\"" + r["SoTuan"]
                                    + "\" D=\"" + r["NgayCapNhat"]
                                    + "\" U=\"" + r["NguoiCapNhat"]
                                    + "\" />";
                        }
                    }

                    if (xmlData == "")
                        return;
                    else
                    {
                        xmlData = "<Root>" + xmlData + "</Root>";
                        int kq = 0;
                        DataServices.KhoiLuongHuongDanThucTap.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);

                        if (kq == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Cursor.Current = Cursors.WaitCursor;
                        InitData();
                        Cursor.Current = Cursors.Default;
                    }
                    Cursor.Current = Cursors.Default;
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChiaNhom_Click(object sender, EventArgs e)
        {
            gridViewKhoiLuong.FocusedRowHandle = -1;
            DataTable tb = bindingSourceKhoiLuong.DataSource as DataTable;
            if (tb.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn muốn chia nhóm những lớp học phần?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        string xmlData = "";
                        foreach (DataRow r in tb.Rows)
                        {
                            if (r["LopChinh"].ToString().ToLower() == "true")
                            {
                                xmlData += "<Input M =\"" + r["MaLopHocPhan"].ToString()
                                        + "\" SN=\"" + r["Nhom"].ToString()
                                        + "\" SS=\"" + r["SiSo"]
                                        + "\" D=\"" + r["NgayCapNhat"]
                                        + "\" U=\"" + r["NguoiCapNhat"]
                                        + "\" />";
                            }
                        }

                        if (xmlData == "")
                            return;
                        else
                        {
                            xmlData = "<Root>" + xmlData + "</Root>";
                            int kq = 0;
                            DataServices.KhoiLuongHuongDanThucTap.ChiaNhom(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);

                            if (kq == 0)
                                XtraMessageBox.Show("Chia nhóm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                XtraMessageBox.Show("Chia nhóm không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            Cursor.Current = Cursors.WaitCursor;
                            InitData();
                            Cursor.Current = Cursors.Default;
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    catch
                    {
                        XtraMessageBox.Show("Chia nhóm không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        #endregion

        #region Event Grid
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KhoiLuongHuongDanThucTap.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn r in tb.Columns)
                {
                    r.ReadOnly = false;
                }
                bindingSourceKhoiLuong.DataSource = tb;

                KiemTraChot();
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KhoiLuongHuongDanThucTap.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn r in tb.Columns)
                {
                    r.ReadOnly = false;
                }
                bindingSourceKhoiLuong.DataSource = tb;

                KiemTraChot();
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewKhoiLuong_ShowingEditor(object sender, CancelEventArgs e)
        {
            DataRowView r = bindingSourceKhoiLuong.Current as DataRowView;
            if (r["LopChinh"].ToString().ToLower() == "true" && gridViewKhoiLuong.FocusedColumn.FieldName != "Nhom")
            {
                e.Cancel = true;
            }
        }

        private void gridViewKhoiLuong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            DataRowView v = gridViewKhoiLuong.GetRow(e.RowHandle) as DataRowView;
            if (col.FieldName == "MaGiangVien")
            {
                ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(v["MaGiangVien"].ToString()));
                gridViewKhoiLuong.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                gridViewKhoiLuong.SetRowCellValue(e.RowHandle, "TenDonVi", gv.TenDonVi);
            }

            if (col.FieldName == "Nhom" && v["LopChinh"].ToString().ToLower() == "true")
            {
                try
                {
                    int.Parse(v["Nhom"].ToString());
                }
                catch
                {
                    XtraMessageBox.Show("Nhập số nhóm muốn chia.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ColumnView view = (ColumnView)gridControlKhoiLuong.KeyboardFocusView;
                    if (view.IsEditing)
                        view.HideEditor();
                    view.CancelUpdateCurrentRow();
                    return;
                }
            }

            if (col.FieldName == "Nhom" || col.FieldName == "SiSo" || col.FieldName == "MaGiangVien" || col.FieldName == "SoTuan")
            {
                gridViewKhoiLuong.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewKhoiLuong.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
        #endregion

    }
}