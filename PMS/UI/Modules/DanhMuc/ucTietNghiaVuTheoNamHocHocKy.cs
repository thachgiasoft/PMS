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
using PMSUI.Common;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucTietNghiaVuTheoNamHocHocKy : DevExpress.XtraEditors.XtraUserControl
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
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public ucTietNghiaVuTheoNamHocHocKy()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucTietNghiaVuTheoNamHocHocKy_Load(object sender, EventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            #region Init GirdView
            switch (_maTruong)
            {
                case "UTE":
                    AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                    AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocHamHrm", "TenHocVi", "TenHocViHrm", "TenChucVu", "TenChucVuHrm", "TenTinhTrang", "DinhMucTietNghiaVuCaNam", "SoTietNghiaVu", "TietGioiHan", "GhiChu", "NgayCapNhat", "GhiChu2", "NguoiCapNhat" }
                            , new string[] { "Mã giảng viên", "Họ và tên", "Khoa - Đơn vị", "Học hàm", "Học hàm HRM", "Học vị", "Học vị HRM", "Chức vụ", "Chức vụ HRM", "Tình trạng", "Định mức cả năm", "Số tiết nghĩa vụ", "Số tiết giới hạn", "Ghi chú khác", "Ngày cập nhật", "Ghi chú", "Người cập nhật" }
                            , new int[] { 90, 150, 150, 90, 100, 90, 100, 80, 90, 90, 100, 100, 100, 150, 90, 80, 90 });
                    AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocHamHrm", "TenHocVi", "TenHocViHrm", "TenChucVu", "TenChucVuHrm", "TenTinhTrang", "DinhMucTietNghiaVuCaNam", "SoTietNghiaVu", "TietGioiHan", "GhiChu", "NgayCapNhat", "GhiChu2", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0} GV", DevExpress.Data.SummaryItemType.Count);
                    //AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocHamHrm", "TenHocVi", "TenHocViHrm", "TenChucVu", "TenChucVuHrm", "TenTinhTrang", "DinhMucTietNghiaVuCaNam" });
                    AppGridView.HideField(gridViewTietNghiaVu, new string[] { "GhiChu", "NgayCapNhat", "NguoiCapNhat" });
                    AppGridView.FixedField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, FixedStyle.Left);
                    AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietNghiaVu", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewTietNghiaVu, "TietGioiHan", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.BackColorFieldAppearance(gridViewTietNghiaVu, new string[] { "TenHocHam", "TenHocVi", "TenChucVu" }, Color.LightCyan);
                    AppGridView.BackColorFieldAppearance(gridViewTietNghiaVu, new string[] { "TenHocHamHrm", "TenHocViHrm", "TenChucVuHrm" }, Color.LemonChiffon);
                    break;
                default:
                    AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                    AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenDonVi", "TenChucVu", "TenTinhTrang", "DinhMucTietNghiaVuCaNam", "SoTietNghiaVu", "TietGioiHan", "GhiChu", "NgayCapNhat", "GhiChu2", "NguoiCapNhat" }
                            , new string[] { "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Khoa - Đơn vị", "Chức vụ", "Tình trạng", "Định mức cả năm", "Số tiết nghĩa vụ", "Số tiết giới hạn", "Ghi chú", "NgayCapNhat", "Ghi chú", "Người cập nhật" }
                            , new int[] { 90, 150, 90, 90, 100, 90, 80, 90, 110, 110, 100, 100, 150, 99 });
                    AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenDonVi", "TenChucVu", "TenTinhTrang", "DinhMucTietNghiaVuCaNam", "SoTietNghiaVu", "TietGioiHan", "GhiChu2", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenDonVi", "TenChucVu", "TenTinhTrang", "DinhMucTietNghiaVuCaNam" });
                    AppGridView.HideField(gridViewTietNghiaVu, new string[] { "GhiChu", "NgayCapNhat", "NguoiCapNhat" });
                    AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietNghiaVu", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewTietNghiaVu, "TietGioiHan", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.HideField(gridViewTietNghiaVu, new string[] { "TietGioiHan" });
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

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
           _listTietNghiaVu = DataServices.ViewTietNghiaVu.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text !="")
            {
                bindingSourceTietNghiaVu.DataSource = DataServices.ViewTietNghiaVu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            ToMau(bindingSourceTietNghiaVu.DataSource as VList<ViewTietNghiaVu>);
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
                VList<ViewTietNghiaVu> list = bindingSourceTietNghiaVu.DataSource as VList<ViewTietNghiaVu>;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (ViewTietNghiaVu kl in list)
                        {
                            if (kl.NgayCapNhat == null)
                                kl.NgayCapNhat = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                            if (kl.MaGiangVien != null)
                            {
                                xmlData += String.Format("<Input M=\"{0}\" Hh=\"{1}\" Hv=\"{2}\" T=\"{3}\" G=\"{4}\" N=\"{5}\" Gh=\"{6}\" G2=\"{7}\" U=\"{8}\" />", kl.MaGiangVien, IsNull(kl.MaHocHam), IsNull(kl.MaHocVi), IsNull(kl.SoTietNghiaVu), IsNull(kl.GhiChu), kl.NgayCapNhat, IsNull(kl.TietGioiHan), kl.GhiChu2, kl.NguoiCapNhat);
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceTietNghiaVu.EndEdit();
                        int kq = 0;
                        DataServices.TietNghiaVu.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
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
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceTietNghiaVu.DataSource = DataServices.ViewTietNghiaVu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            ToMau(bindingSourceTietNghiaVu.DataSource as VList<ViewTietNghiaVu>);
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
                bindingSourceTietNghiaVu.DataSource = DataServices.ViewTietNghiaVu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            ToMau(bindingSourceTietNghiaVu.DataSource as VList<ViewTietNghiaVu>);
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
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            if (col.FieldName == "SoTietNghiaVu")
            {
                ViewTietNghiaVu v = (ViewTietNghiaVu)gridViewTietNghiaVu.GetRow(pos);
                decimal? _tietNghiaVuMacDinh = _listTietNghiaVu.Find(p=>p.MaGiangVien == v.MaGiangVien).SoTietNghiaVu;
                if (v.SoTietNghiaVu != _tietNghiaVuMacDinh)
                    gridViewTietNghiaVu.SetRowCellValue(pos, "GhiChu", 1);
            }

            if (col.FieldName == "SoTietNghiaVu" || col.FieldName == "TietGioiHan" || col.FieldName == "GhiChu2")
            {
                gridViewTietNghiaVu.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewTietNghiaVu.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
            }
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
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlTietNghiaVu.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}
