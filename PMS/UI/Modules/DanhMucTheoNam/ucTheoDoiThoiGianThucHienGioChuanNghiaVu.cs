using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMS.UI.Forms.NghiepVu;
using PMS.Services;
using PMS.BLL;
//using Libraries.BLL;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucTheoDoiThoiGianThucHienGioChuanNghiaVu : DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewTietNghiaVu> _listTietNghiaVu;
        string _maTruong;

        DataTable _dtData;

        #endregion
        public ucTheoDoiThoiGianThucHienGioChuanNghiaVu()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucTheoDoiThoiGianThucHienGioChuanNghiaVu_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenChucVu", "SoTietNghiaVu"
                , "DinhMucToiThieu","TietNghiaVuNckh", "TietGiamDoChucVu", "PhanTramGiamTruKhac", "SoTietGiamKhac", "SoTietNckhDuocGiam", "TietNghiaVuGiangDaySauGiam", "TietNghiaVuNckhSauGiam", "TongGioChuan", "GhiChu"
                , "NgayBatDauHocKy", "NgayKetThucHocKy", "SoNgayTrongHocKy"
                , "NgayBatDauNghi", "NgayKetThucNghi", "NgayTruocnghi", "SoNgayNghi", "NgaySauNghi", "TietNghiaVuTruocNghi", "TietNghiaVuSauNghi_ChuaGiam", "SoTietDuocGiamSauNghi", "SoTietDuocGiamTrongKhiNghi"
                , "TietNghiaVuNckhTruocNghi", "TietNghiaVuNckhSauNghi_ChuaGiam", "SoTietNckhDuocGiamTrongKhiNghi", "ThoiGianKetThucGiamTru", "SoNgayDuocGiam", "SoNgayKhongDuocGiam", "TietNghiaVuDoan1", "TietNghiaVuDoan2" }
                , new string[] { "Mã giảng viên (1)", "Họ và tên (2)", "Chức vụ (3)", "Số tiết nghĩa vụ (4)"
                    , "Định mức tối thiểu theo chức vụ(%) (5)","Tiết nghĩa vụ NCKH (6)", "Tiết giảm do chức vụ (7)", "Phần trăm giảm trừ khác (8)", "Số tiết giảm khác (9)", "Tiết NCKH được giảm (10)", "Tiết nghĩa vụ sau giảm (11)", "Tiết nghĩa vụ NCKH sau giảm (12)", "Tổng giờ chuẩn (13)", "Ghi chú (14)"
                    , "Ngày bắt đầu học kỳ (15)", "Ngày kết thúc học kỳ (16)", "Số ngày (17)"
                    , "Ngày bắt đầu nghỉ (18)", "Ngày kết thúc nghỉ (19)", "Số ngày trước nghỉ (20)", "Số ngày nghỉ (21)", "Số ngày sau nghỉ (22)", "Tiết nghĩa vụ giảng dạy trước nghỉ (23)", "Tiết nghĩa vụ giảng dạy sau nghỉ (24)", "Tiết giảng dạy được giảm sau nghỉ (25)", "Tiết giảng dạy được giảm trong khi nghỉ (26)"
                    , "Tiết nghĩa vụ NCKH trước nghỉ (27)", "Tiết nghĩa vụ NCKH sau nghỉ (28)", "Tiết NCKH được giảm trong khi nghỉ (29)", "Thời gian kết thúc giảm trừ (30)", "Số ngày được giảm (31)", "Số ngày không được giảm (32)", "Tiết nghĩa vụ giảng dạy trong thời gian được giảm (33)", "Tiết nghĩa vụ giảng dạy trong thời gian không được giảm (34)" }
                    , new int[] { 90, 140, 100, 60, 80, 60, 60, 60, 60, 60, 60, 80, 70, 100, 80, 80, 50, 80, 80, 50, 50, 50, 60, 60, 60, 60, 60, 60, 60, 80, 50, 50, 90, 90 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenChucVu", "SoTietNghiaVu"
                , "DinhMucToiThieu","TietNghiaVuNckh", "TietGiamDoChucVu", "PhanTramGiamTruKhac", "SoTietGiamKhac", "SoTietNckhDuocGiam", "TietNghiaVuGiangDaySauGiam", "TietNghiaVuNckhSauGiam", "TongGioChuan", "GhiChu"
                , "NgayBatDauHocKy", "NgayKetThucHocKy", "SoNgayTrongHocKy"
                , "NgayBatDauNghi", "NgayKetThucNghi", "NgayTruocnghi", "SoNgayNghi", "NgaySauNghi", "TietNghiaVuTruocNghi", "TietNghiaVuSauNghi_ChuaGiam", "SoTietDuocGiamSauNghi", "SoTietDuocGiamTrongKhiNghi"
                , "TietNghiaVuNckhTruocNghi", "TietNghiaVuNckhSauNghi_ChuaGiam", "SoTietNckhDuocGiamTrongKhiNghi", "ThoiGianKetThucGiamTru", "SoNgayDuocGiam", "SoNgayKhongDuocGiam", "TietNghiaVuDoan1", "TietNghiaVuDoan2" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu);
            PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 100);
        
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
            
            InitData();

            layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            memoEdit1.Properties.ReadOnly = true;
        }
        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                try
                {
                    //_dtData = DBComunication.ExecProc("sp_psc_pms_getTietNghiaVu_NamHocHocKy", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.TietNghiaVu.GetTietNghiaVuBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    tb.Load(reader);
                    bindingSourceTietNghiaVu.DataSource = tb;
                    bindingSourceTietNghiaVu.Filter = "NgayBatDauNghi is not null or ThoiGianKetThucGiamTru is not null";
                    gridViewTietNghiaVu.ExpandAllGroups();

                    //Load ghi chú
                    CauHinhGiangVienPhanHoi ch = DataServices.CauHinhGiangVienPhanHoi.GetById(1);
                    memoEdit1.Text = ch.NoiDung;
                }
                catch
                { }
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

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTietNghiaVu.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable tb = bindingSourceTietNghiaVu.DataSource as DataTable;
                {
                    if (tb != null)
                    {
                        try
                        {
                            string xmlData = "";
                            foreach (DataRow r in tb.Rows)
                            {
                                if (r["MaGiangVien"] != null && r["GhiChu"].ToString().ToLower() == "true" && r.RowState == DataRowState.Modified)
                                {
                                    xmlData += String.Format("<Input M=\"{0}\" T=\"{1}\" N=\"{2}\" U=\"{3}\" G2=\"{4}\" />", r["MaGiangVien"], IsNull(r["TietNghiaVuSauGiamTru"]), r["NgayCapNhat"], r["NguoiCapNhat"], r["GhiChu2"]);
                                }
                            }
                            xmlData = string.Format("<Root>{0}</Root>", xmlData);
                            bindingSourceTietNghiaVu.EndEdit();
                            int kq = 0;
                            DataServices.TietNghiaVu.Luu2(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                            if (kq == 0)
                                XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepTietNghiaVu"))
            {
                frm.ShowDialog();
            }
            InitData();
        }
        #endregion
        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }
        #endregion

        string IsNull(object o)
        {
            if (o == null)
                return "";
            else return o.ToString();
        }

        private void gridViewTietNghiaVu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //try
            //{
            //    GridColumn col = e.Column;
            //    int pos = e.RowHandle;

            //    if (col.FieldName == "TietNghiaVuSauGiamTru" || col.FieldName == "GhiChu2")
            //    {
            //        //ViewTietNghiaVu v = (ViewTietNghiaVu)gridViewTietNghiaVu.GetRow(pos);
            //        //decimal? _tietNghiaVuMacDinh = _listTietNghiaVu.Find(p=>p.MaGiangVien == v.MaGiangVien).SoTietNghiaVu;
            //        //if (v.SoTietNghiaVu != _tietNghiaVuMacDinh)
            //        //    gridViewTietNghiaVu.SetRowCellValue(pos, "GhiChu", 1);
            //        gridViewTietNghiaVu.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString());
            //        gridViewTietNghiaVu.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
            //        gridViewTietNghiaVu.SetRowCellValue(pos, "GhiChu", true);
            //    }
            //}
            //catch
            //{ }
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlTietNghiaVu.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnGhiChu_Click(object sender, EventArgs e)
        {
            if (layoutControlItem6.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Never)
                layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
    }
}
