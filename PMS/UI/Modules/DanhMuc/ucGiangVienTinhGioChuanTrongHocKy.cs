using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.NghiepVu;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucGiangVienTinhGioChuanTrongHocKy : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _cauHinhHeSoTheoNam;
        #endregion

        #region Event Form
        public ucGiangVienTinhGioChuanTrongHocKy()
        {
            InitializeComponent();
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }
      
        private void ucGiangVienTinhGioChuanTrongHocKy_Load(object sender, EventArgs e)
        {
            #region InitGrid GV toàn trường
            AppGridView.InitGridView(gridViewGiangVienToanTruong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewGiangVienToanTruong, new string[] { "Chon", "MaQuanLy", "Ho", "Ten", "Ngach", "TenDonVi", "TenTinhTrang", "MaGiangVien", "MaTinhTrang" }
                    , new string[] { "Chọn", "Mã giảng viên", "Họ", "Tên", "Ngạch", "Đơn vị", "Tình trạng", "MaGiangVien", "MaTinhTrang" }
                    , new int[] { 50, 85, 105, 65, 80, 175, 90, 99, 99 });
            AppGridView.AlignHeader(gridViewGiangVienToanTruong, new string[] { "MaQuanLy", "Ho", "Ten", "Ngach", "TenDonVi", "Chon", "TenTinhTrang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewGiangVienToanTruong, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewGiangVienToanTruong, new string[] { "MaGiangVien", "MaTinhTrang" });
            #endregion

            #region InitGrid GV tính giờ chuẩn
            AppGridView.InitGridView(gridViewGiangVienTinhGioChuan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewGiangVienTinhGioChuan, new string[] { "Chon", "MaQuanLy", "Ho", "Ten", "Ngach", "TenDonVi", "MaGiangVien", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Chọn", "Mã giảng viên", "Họ", "Tên", "Ngạch", "Đơn vị", "MaGiangVien", "NgayCapNhat", "NguoiCapNhat" }
                    , new int[] { 50, 85, 105, 65, 80, 175, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewGiangVienTinhGioChuan, new string[] { "MaQuanLy", "Ho", "Ten", "Ngach", "TenDonVi", "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewGiangVienTinhGioChuan, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewGiangVienTinhGioChuan, new string[] { "MaGiangVien", "NgayCapNhat", "NguoiCapNhat" });
            #endregion

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

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tblGVToanTruong = new DataTable();
                IDataReader readerGVToanTruong = DataServices.GiangVienTinhGioChuan.GetGiangVienToanTruong(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblGVToanTruong.Load(readerGVToanTruong);
                tblGVToanTruong.Columns["Chon"].ReadOnly = false;
                bindingSourceGiangVienToanTruong.DataSource = tblGVToanTruong;

                DataTable tblGVTinhGioChuan = new DataTable();
                IDataReader readerGVTinhGioChuan = DataServices.GiangVienTinhGioChuan.GetGiangVienTinhGioChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblGVTinhGioChuan.Load(readerGVTinhGioChuan);
                tblGVTinhGioChuan.Columns["Chon"].ReadOnly = false;
                bindingSourceGiangVienTinhGioChuan.DataSource = tblGVTinhGioChuan;
            }

            radioGroupTinhTrang.SelectedIndex = 0;
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewGiangVienTinhGioChuan.FocusedRowHandle = -1;
            DataTable tbl = bindingSourceGiangVienTinhGioChuan.DataSource as DataTable;
            if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string xmlData = "";
                    foreach (DataRow r in tbl.Rows)
                    {
                        xmlData += "<Input M=\"" + r["MaGiangVien"]
                                    + "\" D=\"" + r["NgayCapNhat"]
                                    + "\" U=\"" + r["NguoiCapNhat"]
                                    + "\" />";
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";
                    int kq = 0;
                    DataServices.GiangVienTinhGioChuan.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Cursor.Current = Cursors.WaitCursor;
                    InitData();
                    Cursor.Current = Cursors.Default;
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepGiangVienTinhGioChuan"))
            //{
            //    frm.ShowDialog();
            //}
            //Cursor.Current = Cursors.WaitCursor;
            //InitData();
            //Cursor.Current = Cursors.Default;

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepGiangVienTinhGioChuan"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepGiangVienTinhGioChuan"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            gridViewGiangVienToanTruong.FocusedRowHandle = -1;
            DataTable tblGVToanTruong = bindingSourceGiangVienToanTruong.DataSource as DataTable;
            DataTable tblGVTinhGioChuan = bindingSourceGiangVienTinhGioChuan.DataSource as DataTable;
            DataRow[] rowColection = tblGVToanTruong.Select("Chon = 'True'");
            foreach (DataRow r in rowColection)
            {
                
                //tblGVTinhGioChuan.ImportRow(r);
                DataRow r2 = tblGVTinhGioChuan.NewRow();
                r2["MaQuanLy"] = r["MaQuanLy"];
                r2["Ho"] = r["Ho"];
                r2["Ten"] = r["Ten"];
                r2["TenDonVi"] = r["TenDonVi"];
                r2["MaGiangVien"] = r["MaGiangVien"];
                r2["NgayCapNhat"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                r2["NguoiCapNhat"] = UserInfo.UserName;
                tblGVTinhGioChuan.Rows.Add(r2);

                tblGVToanTruong.Rows.Remove(r);
            }
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            gridViewGiangVienTinhGioChuan.FocusedRowHandle = -1;
            DataTable tblGVToanTruong = bindingSourceGiangVienToanTruong.DataSource as DataTable;
            DataTable tblGVTinhGioChuan = bindingSourceGiangVienTinhGioChuan.DataSource as DataTable;
            DataRow[] rowColection = tblGVTinhGioChuan.Select("Chon = 'True'");
            foreach (DataRow r in rowColection)
            {

                //tblGVTinhGioChuan.ImportRow(r);
                DataRow r2 = tblGVToanTruong.NewRow();
                r2["MaQuanLy"] = r["MaQuanLy"];
                r2["Ho"] = r["Ho"];
                r2["Ten"] = r["Ten"];
                r2["TenDonVi"] = r["TenDonVi"];
                r2["MaGiangVien"] = r["MaGiangVien"];
                tblGVToanTruong.Rows.Add(r2);

                tblGVTinhGioChuan.Rows.Remove(r);
            }
        }
        #endregion

        #region Event Grid
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tblGVToanTruong = new DataTable();
                IDataReader readerGVToanTruong = DataServices.GiangVienTinhGioChuan.GetGiangVienToanTruong(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblGVToanTruong.Load(readerGVToanTruong);
                tblGVToanTruong.Columns["Chon"].ReadOnly = false;
                bindingSourceGiangVienToanTruong.DataSource = tblGVToanTruong;

                DataTable tblGVTinhGioChuan = new DataTable();
                IDataReader readerGVTinhGioChuan = DataServices.GiangVienTinhGioChuan.GetGiangVienTinhGioChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblGVTinhGioChuan.Load(readerGVTinhGioChuan);
                tblGVTinhGioChuan.Columns["Chon"].ReadOnly = false;
                bindingSourceGiangVienTinhGioChuan.DataSource = tblGVTinhGioChuan;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tblGVToanTruong = new DataTable();
                IDataReader readerGVToanTruong = DataServices.GiangVienTinhGioChuan.GetGiangVienToanTruong(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblGVToanTruong.Load(readerGVToanTruong);
                tblGVToanTruong.Columns["Chon"].ReadOnly = false;
                bindingSourceGiangVienToanTruong.DataSource = tblGVToanTruong;

                DataTable tblGVTinhGioChuan = new DataTable();
                IDataReader readerGVTinhGioChuan = DataServices.GiangVienTinhGioChuan.GetGiangVienTinhGioChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblGVTinhGioChuan.Load(readerGVTinhGioChuan);
                tblGVTinhGioChuan.Columns["Chon"].ReadOnly = false;
                bindingSourceGiangVienTinhGioChuan.DataSource = tblGVTinhGioChuan;
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion
        
        #region Event Check
        private void checkEditChonTatCa1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa1.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewGiangVienToanTruong.DataRowCount; i++)
                {
                    gridViewGiangVienToanTruong.SetRowCellValue(i, "Chon", "True");
                }
            }
            if (checkEditChonTatCa1.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewGiangVienToanTruong.DataRowCount; i++)
                {
                    gridViewGiangVienToanTruong.SetRowCellValue(i, "Chon", "False");
                }
            }
        }

        private void checkEditChonTatCa2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa2.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewGiangVienTinhGioChuan.DataRowCount; i++)
                {
                    gridViewGiangVienTinhGioChuan.SetRowCellValue(i, "Chon", "True");
                }
            }
            if (checkEditChonTatCa2.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewGiangVienTinhGioChuan.DataRowCount; i++)
                {
                    gridViewGiangVienTinhGioChuan.SetRowCellValue(i, "Chon", "False");
                }
            }
        }
        #endregion

        #region Evnet Radio
        private void radioGroupTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupTinhTrang.SelectedIndex == 0)
            {
                gridViewGiangVienToanTruong.ActiveFilterString = "MaTinhTrang = 22";//22 là đang làm việc
            }
            else
            {
                gridViewGiangVienToanTruong.ActiveFilterString = "MaTinhTrang <> 22";
            }
        }
        #endregion
    }
}
