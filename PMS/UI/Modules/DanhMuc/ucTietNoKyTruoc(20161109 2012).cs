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
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucTietNoKyTruoc : DevExpress.XtraEditors.XtraUserControl
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

                btnLayTuDong.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLayTuDong.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnImportExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLayTuDong.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        VList<ViewGiangVien> _listGiangVien;
        #endregion

        public ucTietNoKyTruoc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucTietNoKyTruoc_Load(object sender, EventArgs e)
        {
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

            #region Init Gridview
            switch (_maTruong)
            {
                case "ACT":
                    InitGridACT();
                    break;
                case "VHU":
                    InitGridVHU();
                    break;
                case "HBU":
                    InitGridHBU();
                    break;
                case "DLU":
                    InitGridDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion
           
            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Đơn vị" });
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitGridView
        void InitGridACT()
        {
            AppGridView.InitGridView(gridViewNoKyTruoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewNoKyTruoc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "TietNoKhac", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Số tiết nợ kỳ trước", "Số tiết nợ khác", "NgayCapNhat", "NguoiCapNhat" },
                                                           new int[] { 120, 150, 200, 130, 130, 99, 99 });
            AppGridView.AlignHeader(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "TietNoKhac", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewNoKyTruoc, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewNoKyTruoc, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.HideField(gridViewNoKyTruoc, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }

        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewNoKyTruoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewNoKyTruoc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "TietNoNckh", "TietNoKhac", "NgayCapNhat", "NguoiCapNhat", "GhiChu", "LayTuDong" },
                                                           new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Tiết nợ / bảo lưu giảng dạy", "Tiết nợ / bảo lưu NCKH", "Tiết nợ / bảo lưu tham gia quản lý", "NgayCapNhat", "NguoiCapNhat", "Ghi chú", "LayTuDong" },
                                                           new int[] { 120, 150, 150, 100, 100, 100, 99, 99, 140, 99 });
            AppGridView.AlignHeader(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "TietNoNckh", "TietNoKhac", "NgayCapNhat", "NguoiCapNhat", "GhiChu", "LayTuDong" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewNoKyTruoc, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.HideField(gridViewNoKyTruoc, new string[] { "NgayCapNhat", "NguoiCapNhat", "LayTuDong" });
            labelControl1.Text = "GHI CHÚ: - Số tiết nhỏ hơn 0 là số tiết nợ; số tiết lớn hơn 0 là số tiết bảo lưu";
            PMS.Common.Globals.WordWrapHeader(gridViewNoKyTruoc, 45);
            AppGridView.SummaryField(gridViewNoKyTruoc, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            btnLayTuDong.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        void InitGridHBU()
        {
            AppGridView.InitGridView(gridViewNoKyTruoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewNoKyTruoc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "TietNoNckh", "TietNoKhac", "NgayCapNhat", "NguoiCapNhat", "GhiChu", "LayTuDong" },
                                                           new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Tiết nợ / bảo lưu giảng dạy", "Tiết nợ / bảo lưu NCKH", "Tiết nợ / bảo lưu các hoạt động khác", "NgayCapNhat", "NguoiCapNhat", "Ghi chú", "LayTuDong" },
                                                           new int[] { 120, 150, 150, 100, 100, 100, 99, 99, 140, 99 });
            AppGridView.AlignHeader(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "TietNoNckh", "TietNoKhac", "NgayCapNhat", "NguoiCapNhat", "GhiChu", "LayTuDong" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewNoKyTruoc, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.HideField(gridViewNoKyTruoc, new string[] { "NgayCapNhat", "NguoiCapNhat", "LayTuDong" });
            labelControl1.Text = "GHI CHÚ: - Số tiết nhỏ hơn 0 là số tiết nợ; số tiết lớn hơn 0 là số tiết bảo lưu";
            PMS.Common.Globals.WordWrapHeader(gridViewNoKyTruoc, 45);
            AppGridView.SummaryField(gridViewNoKyTruoc, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            btnLayTuDong.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        void InitGridDLU()
        {
            AppGridView.InitGridView(gridViewNoKyTruoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewNoKyTruoc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "TietNoNckh", "NgayCapNhat", "NguoiCapNhat", "GhiChu", "LayTuDong" },
                                                           new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Tiet nợ/bảo lưu giảng dạy", "Tiết nợ/bảo lưu NCKH", "NgayCapNhat", "NguoiCapNhat", "Ghi chú", "LayTuDong" },
                                                           new int[] { 120, 150, 150, 100, 100, 99, 99, 140, 99 });
            AppGridView.AlignHeader(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "TietNoNckh", "NgayCapNhat", "NguoiCapNhat", "GhiChu", "LayTuDong" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewNoKyTruoc, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.HideField(gridViewNoKyTruoc, new string[] { "NgayCapNhat", "NguoiCapNhat", "LayTuDong" });
            labelControl1.Text = "GHI CHÚ: - Số tiết nhỏ hơn 0 là số tiết nợ; số tiết lớn hơn 0 là số tiết bảo lưu";
            PMS.Common.Globals.WordWrapHeader(gridViewNoKyTruoc, 45);
            AppGridView.SummaryField(gridViewNoKyTruoc, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            btnLayTuDong.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }


        void InitRemaining()//UEL, IUH
        {
            AppGridView.InitGridView(gridViewNoKyTruoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewNoKyTruoc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Số tiết nợ kỳ trước", "NgayCapNhat", "NguoiCapNhat" },
                                                           new int[] { 120, 150, 200, 130, 99, 99 });
            AppGridView.AlignHeader(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewNoKyTruoc, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.HideField(gridViewNoKyTruoc, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.SummaryField(gridViewNoKyTruoc, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }
        #endregion

        #region InitData
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            //if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            //    bindingSourceNoKyTruoc.DataSource = DataServices.ViewTietNoKyTruoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.TietNoKyTruoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn col in tb.Columns)
                    col.ReadOnly = false;

                bindingSourceNoKyTruoc.DataSource = tb;
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewNoKyTruoc);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewNoKyTruoc.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable list = bindingSourceNoKyTruoc.DataSource as DataTable;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow kl in list.Rows)
                        {
                            //Kiểm tra điều kiện nếu có sửa mới cho insert hay update xuống
                            if (kl.RowState != DataRowState.Deleted)
                            {
                                if (kl["MaGiangVien"].ToString() != "")
                                {
                                    xmlData += String.Format("<Input M=\"{0}\" S=\"{1}\" N=\"{2}\" U=\"{3}\" K=\"{4}\" H=\"{5}\" G=\"{6}\" L=\"{7}\" />"
                                        , kl["MaGiangVien"], PMS.Common.Globals.IsNull(kl["SoTietNoKyTruoc"], "decimal"), kl["NgayCapNhat"], kl["NguoiCapNhat"]
                                        , PMS.Common.Globals.IsNull(kl["TietNoKhac"], "decimal")
                                        , PMS.Common.Globals.IsNull(kl["TietNoNckh"], "decimal")
                                        , PMS.Common.Globals.IsNull(kl["GhiChu"], "string")
                                        , PMS.Common.Globals.IsNull(kl["LayTuDong"], "bool"));
                                }
                                else
                                {
                                    XtraMessageBox.Show("Mã giảng viên không được phép bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceNoKyTruoc.EndEdit();
                        int kq = 0;
                        DataServices.TietNoKyTruoc.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
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

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlNoKyTruoc.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

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

        private void gridViewNoKyTruoc_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewNoKyTruoc, e);
        }

        private void gridViewNoKyTruoc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                DataRowView v = gridViewNoKyTruoc.GetRow(e.RowHandle) as DataRowView;
                string _hoten = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(v["MaGiangVien"].ToString())).HoTen;
                string _donvi = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(v["MaGiangVien"].ToString())).TenDonVi;
                gridViewNoKyTruoc.SetRowCellValue(e.RowHandle, "HoTen", _hoten);
                gridViewNoKyTruoc.SetRowCellValue(e.RowHandle, "TenDonVi", _donvi);
            }
            if (col.FieldName == "MaGiangVien" || col.FieldName == "SoTietNoKyTruoc" || col.FieldName == "TietNoKhac" || col.FieldName == "TietNoNckh")
            {
                gridViewNoKyTruoc.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewNoKyTruoc.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                gridViewNoKyTruoc.SetRowCellValue(e.RowHandle, "LayTuDong", false);
            }
        }
   
        private void btnImportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmImportNoKyTruoc frm = new frmImportNoKyTruoc())
            {
                frm.ShowDialog();
            }
        }

        private void btnLayTuDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null) 
            {
                if (XtraMessageBox.Show("Bạn muốn lấy dữ liệu tiết nợ/bảo lưu của giảng viên từ năm học trước?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int result = 0;
                        DataServices.TietNoKyTruoc.LayTuDong(cboNamHoc.EditValue.ToString(), ref result);

                        if (result == 0)
                            XtraMessageBox.Show("Lấy dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    InitData();
                }
            }
        }
    }
}
