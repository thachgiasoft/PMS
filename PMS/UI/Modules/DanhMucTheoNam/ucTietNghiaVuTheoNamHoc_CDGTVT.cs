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

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucTietNghiaVuTheoNamHoc_CDGTVT : DevExpress.XtraEditors.XtraUserControl
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
        TList<GiamTruDinhMuc> _listGiamTruKhac = new TList<GiamTruDinhMuc>();
        string _maTruong;
        #endregion
        public ucTietNghiaVuTheoNamHoc_CDGTVT()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucTietNghiaVuTheoNamHoc_CDGTVT_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            switch (_maTruong)
            { 
                case "CDGTVT":
                    InitGridCDGTVT();
                    break;
                case "VHU":
                    InitGridVHU();
                    break;
                case "LAW":
                    InitGridVHU();
                    break;
                case "IUH":
                    InitIUH();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region GiamTruKhac
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiamTruKhac, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiamTruKhac, new string[] { "NoiDungGiamTru", "MucGiam", "DonVi" }, new string[] { "Nội dung giảm trừ", "Mức giảm", "Đơn vị" }, new int[] { 200, 100, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiamTruKhac, 400, 500);
            repositoryItemGridLookUpEditGiamTruKhac.DisplayMember = "NoiDungGiamTru";
            repositoryItemGridLookUpEditGiamTruKhac.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiamTruKhac.NullText = String.Empty;
            #endregion

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion

            #region BacLuong
            repositoryItemCheckedComboBoxEditBacLuong.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditBacLuong.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditBacLuong.Items.Clear();
            TList<BacLuong> listBacLuong = DataServices.BacLuong.GetAll();
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (BacLuong bl in listBacLuong)
                list.Add(new CheckedListBoxItem(bl.MaBacLuong, bl.TenBacLuong, CheckState.Unchecked, true));
            repositoryItemCheckedComboBoxEditBacLuong.Items.AddRange(list.ToArray());
            repositoryItemCheckedComboBoxEditBacLuong.SeparatorChar = ';';

            #endregion

            InitData();
        }

        #region InitGridView
        void InitGridCDGTVT()
        {
            btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNghiaVuSauGiamTru", "TietNghiaVuHk01", "TietNghiaVuHk02", "NgayCapNhat", "GhiChu2", "NguoiCapNhat", "GhiChu" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Số tiết nghĩa vụ", "Loại giảm trừ", "Số tiết giảm trừ", "Tổng giờ chuẩn", "Tiết nghĩa vụ HK01", "Tiết nghĩa vụ HK02", "NgayCapNhat", "Ghi chú", "Người cập nhật", "Đánh dấu" }
                    , new int[] { 180, 90, 140, 80, 80, 100, 110, 110, 110, 150, 110, 110, 99, 200, 99, 99 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNghiaVuSauGiamTru", "TietNghiaVuHk01", "TietNghiaVuHk02", "NgayCapNhat", "GhiChu2", "NguoiCapNhat", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            //AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "SoTietGiamTruKhac", "TietNghiaVuHk01", "TietNghiaVuHk02" });
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu);
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "NgayCapNhat", "NguoiCapNhat", "GhiChu" });
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietNghiaVu", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewTietNghiaVu, "MaGiamTruKhac", repositoryItemGridLookUpEditGiamTruKhac);
        }

        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNghiaVuSauGiamTru", "NgayCapNhat", "GhiChu2", "NguoiCapNhat", "GhiChu" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Số giờ nghĩa vụ", "Loại giảm trừ", "Số giờ giảm trừ", "Tổng giờ chuẩn", "NgayCapNhat", "Ghi chú", "Người cập nhật", "Đánh dấu" }
                    , new int[] { 180, 90, 140, 80, 80, 100, 110, 110, 110, 150, 99, 200, 99, 99 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNghiaVuSauGiamTru", "NgayCapNhat", "GhiChu2", "NguoiCapNhat", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            //AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "SoTietGiamTruKhac", "TietNghiaVuHk01", "TietNghiaVuHk02" });
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "SoTietGiamTruKhac" });
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "NgayCapNhat", "NguoiCapNhat", "GhiChu" });
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietNghiaVu", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewTietNghiaVu, "MaGiamTruKhac", repositoryItemGridLookUpEditGiamTruKhac);
        }

        void InitIUH()
        {
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNghiaVuSauGiamTru", "TietNghiaVuHk01", "TietNghiaVuHk02", "NgayCapNhat", "GhiChu2", "NguoiCapNhat", "GhiChu" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Số tiết nghĩa vụ", "Loại giảm trừ", "Số tiết giảm trừ", "Tổng giờ chuẩn", "Tiết nghĩa vụ HK01", "Tiết nghĩa vụ HK02", "NgayCapNhat", "Ghi chú", "Người cập nhật", "Đánh dấu" }
                    , new int[] { 180, 90, 140, 80, 80, 100, 110, 110, 110, 150, 110, 110, 99, 200, 99, 99 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNghiaVuSauGiamTru", "TietNghiaVuHk01", "TietNghiaVuHk02", "NgayCapNhat", "GhiChu2", "NguoiCapNhat", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "SoTietGiamTruKhac" });
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "NgayCapNhat", "NguoiCapNhat", "GhiChu", "TietNghiaVuHk01", "TietNghiaVuHk02" });
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietNghiaVu", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewTietNghiaVu, "MaGiamTruKhac", repositoryItemGridLookUpEditGiamTruKhac);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "PhanTramGiamTru", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNghiaVuSauGiamTru", "NgayCapNhat", "GhiChu2", "NguoiCapNhat", "GhiChu", "TietNghiaVuHk01", "TietNghiaVuHk02" }
                , new string[] { "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Số tiết nghĩa vụ", "Định mức tối thiểu(%)", "Giảm trừ khác", "Số tiết giảm trừ khác", "Tiết nghĩa vụ sau giảm trừ", "NgayCapNhat", "Ghi chú", "Người cập nhật", "Đánh dấu", "Tiết nghĩa vụ HK01", "Tiết nghĩa vụ HK02" }
                    , new int[] { 90, 140, 80, 80, 100, 110, 110, 110, 110, 150, 99, 200, 99, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "PhanTramGiamTru", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNghiaVuSauGiamTru", "NgayCapNhat", "GhiChu2", "NguoiCapNhat", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "PhanTramGiamTru", "SoTietGiamTruKhac" });
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "NgayCapNhat", "NguoiCapNhat", "GhiChu", "TietNghiaVuHk01", "TietNghiaVuHk02" });
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietNghiaVu", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewTietNghiaVu, "MaGiamTruKhac", repositoryItemGridLookUpEditGiamTruKhac);
        }
        #endregion
        #region InitData
        void InitData()
        {
            _listGiamTruKhac = DataServices.GiamTruDinhMuc.GetAll();
            bindingSourceGiamTruKhac.DataSource = _listGiamTruKhac;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ViewTietNghiaVuTheoNamHocHocKy.GetByNamHocCdgtvt(cboNamHoc.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["TietNghiaVuHk01"].ReadOnly = false;
                tb.Columns["TietNghiaVuHk02"].ReadOnly = false;
                tb.Columns["TietNghiaVuSauGiamTru"].ReadOnly = false;
                bindingSourceTietNghiaVu.DataSource = tb;
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
                DataTable list = bindingSourceTietNghiaVu.DataSource as DataTable;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow kl in list.Rows)
                        {
                            //Kiểm tra điều kiện nếu có sửa mới cho insert hay update xuống
                            if (kl["MaGiangVien"] != null && kl["GhiChu"].ToString() == "True")
                            {
                                xmlData += String.Format("<Input M=\"{0}\" HH=\"{1}\" HV=\"{2}\" MK=\"{3}\" TK=\"{4}\" T=\"{5}\" N=\"{6}\" U=\"{7}\" G2=\"{8}\" K1=\"{9}\" K2=\"{10}\" />"
                                        , kl["MaGiangVien"], PMS.Common.Globals.IsNull(kl["MaHocHam"], "int"), PMS.Common.Globals.IsNull(kl["MaHocVi"], "int")
                                        , PMS.Common.Globals.IsNull(kl["MaGiamTruKhac"], "int").ToString(), PMS.Common.Globals.IsNull(kl["SoTietGiamTruKhac"], "int")
                                        , PMS.Common.Globals.IsNull(Math.Round((decimal)kl["TietNghiaVuSauGiamTru"], 2, MidpointRounding.AwayFromZero), "decimal"), kl["NgayCapNhat"], kl["NguoiCapNhat"], kl["GhiChu2"]
                                        , 0, 0);
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceTietNghiaVu.EndEdit();
                        int kq = 0;
                        DataServices.TietNghiaVu.Luu3(xmlData, cboNamHoc.EditValue.ToString(), "", ref kq);
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
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepTietNghiaVu"))
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
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ViewTietNghiaVuTheoNamHocHocKy.GetByNamHocCdgtvt(cboNamHoc.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["TietNghiaVuHk01"].ReadOnly = false;
                tb.Columns["TietNghiaVuHk02"].ReadOnly = false;
                tb.Columns["TietNghiaVuSauGiamTru"].ReadOnly = false;
                bindingSourceTietNghiaVu.DataSource = tb;
            }
        }

        #endregion

        private void gridViewTietNghiaVu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                int pos = e.RowHandle;
                if (col.FieldName == "TietNghiaVuSauGiamTru" || col.FieldName == "GhiChu2" || col.FieldName == "MaGiamTruKhac" || col.FieldName == "TietNghiaVuCongTacKhacSauGiamTru")
                {
                    gridViewTietNghiaVu.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString());
                    gridViewTietNghiaVu.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
                    gridViewTietNghiaVu.SetRowCellValue(pos, "GhiChu", true);
                }

                if (col.FieldName == "MaGiamTruKhac")
                {
                    DataRowView row = gridViewTietNghiaVu.GetRow(e.RowHandle) as DataRowView;
                    GiamTruDinhMuc g = _listGiamTruKhac.Find(p => p.MaQuanLy == int.Parse(row["MaGiamTruKhac"].ToString()));

                    decimal? t, v, q;

                    t = decimal.Parse(row["SoTietNghiaVu"].ToString());
                    if (g.DonVi.ToLower() == "phantram")
                    {
                        q = (t * (100 - g.MucGiam)) / 100;
                        v = t - q;
                    }
                    else
                    {
                        q = t - g.MucGiam;
                        v = g.MucGiam;
                    }

                    gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SoTietGiamTruKhac", Math.Round((decimal)v, 2, MidpointRounding.AwayFromZero));
                    gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "TietNghiaVuSauGiamTru", Math.Round((decimal)q, 2, MidpointRounding.AwayFromZero));
                }

                if (col.FieldName == "TietNghiaVuSauGiamTru")
                {
                    DataRowView row = gridViewTietNghiaVu.GetRow(e.RowHandle) as DataRowView;
                    decimal tnv = decimal.Parse(row["TietNghiaVuSauGiamTru"].ToString());
                    gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "TietNghiaVuHk01", Math.Round(tnv / 2, 2, MidpointRounding.AwayFromZero));
                    gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "TietNghiaVuHk02", Math.Round(tnv / 2, 2, MidpointRounding.AwayFromZero));
                }
            }
            catch
            {}
        }

        void ToMau(VList<ViewTietNghiaVu> list)
        {
            try
            {
                if (list.Count > 0)
                {
                    foreach (ViewTietNghiaVu v in list)
                    {
                        if (v.GhiChu == true)
                        {
                            AppGridView.ConditionsAdjustment(gridViewTietNghiaVu, "GhiChu", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Silver, v.GhiChu);
                        }
                    }
                }
            }
            catch
            { }
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
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
    }
}
