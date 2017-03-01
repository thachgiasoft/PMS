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
    public partial class ucTietNghiaVuTheoNamHoc : DevExpress.XtraEditors.XtraUserControl
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
        #endregion

        public ucTietNghiaVuTheoNamHoc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucTietNghiaVuTheoNamHoc_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            switch (_maTruong)
            {
                case "UTE":
                    AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                    AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "PhanTramGiamTru", "TietNghiaVuSauGiamTru", "NgayCapNhat", "GhiChu2", "NguoiCapNhat", "GhiChu" }
                        , new string[] { "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Số tiết nghĩa vụ", "Định múc tối thiểu", "Tiết nghĩa vụ sau giảm trừ", "NgayCapNhat", "Ghi chú", "Người cập nhật", "Đánh dấu" }
                        , new int[] { 90, 140, 80, 80, 100, 110, 110, 150, 99, 200, 99, 99 });
                    AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "TietNghiaVuSauGiamTru", "GhiChu2", "NguoiCapNhat", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "PhanTramGiamTru" });
                    AppGridView.HideField(gridViewTietNghiaVu, new string[] { "NgayCapNhat", "NguoiCapNhat", "GhiChu" });
                    AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietNghiaVu", DevExpress.Utils.FormatType.Custom, "n2");
                break;
                default:
                    AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
                    AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "PhanTramGiamTru", "TietNghiaVuSauGiamTru", "NgayCapNhat", "GhiChu2", "NguoiCapNhat", "GhiChu" }
                        , new string[] { "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Số tiết nghĩa vụ", "Định múc tối thiểu", "Tiết nghĩa vụ sau giảm trừ", "NgayCapNhat", "Ghi chú", "Người cập nhật", "Đánh dấu" }
                        , new int[] { 90, 140, 80, 80, 100, 110, 110, 150, 99, 200, 99, 99 });
                    AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "TietNghiaVuSauGiamTru", "GhiChu2", "NguoiCapNhat", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "SoTietNghiaVu", "PhanTramGiamTru" });
                    AppGridView.HideField(gridViewTietNghiaVu, new string[] { "NgayCapNhat", "NguoiCapNhat", "GhiChu" });
                    AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietNghiaVu", DevExpress.Utils.FormatType.Custom, "n2");
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

            InitData();
        }

        #region InitData
        void InitData()
        {
           //_listTietNghiaVu = DataServices.ViewTietNghiaVu.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                //bindingSourceTietNghiaVu.DataSource = DataServices.ViewTietNghiaVuTheoNamHocHocKy.GetByNamHocGroupId(cboNamHoc.EditValue.ToString(),UserInfo.GroupID.ToString());
                bindingSourceTietNghiaVu.DataSource = DataServices.ViewTietNghiaVuTheoNamHocHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            //ToMau(bindingSourceTietNghiaVu.DataSource as VList<ViewTietNghiaVu>);
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
                VList<ViewTietNghiaVuTheoNamHocHocKy> list = bindingSourceTietNghiaVu.DataSource as VList<ViewTietNghiaVuTheoNamHocHocKy>;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (ViewTietNghiaVuTheoNamHocHocKy kl in list)
                        {
                            //Kiểm tra điều kiện nếu có sửa mới cho insert hay update xuống
                            if (kl.MaGiangVien != null && kl.GhiChu == true)
                            {
                                xmlData += String.Format("<Input M=\"{0}\" T=\"{1}\" N=\"{2}\" U=\"{3}\" G2=\"{4}\" />", kl.MaGiangVien, IsNull(kl.TietNghiaVuSauGiamTru), kl.NgayCapNhat, kl.NguoiCapNhat, kl.GhiChu2);
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceTietNghiaVu.EndEdit();
                        int kq = 0;
                        DataServices.TietNghiaVu.Luu2(xmlData, cboNamHoc.EditValue.ToString(), "", ref kq);
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

        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceTietNghiaVu.DataSource = DataServices.ViewTietNghiaVuTheoNamHocHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
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
            if (col.FieldName == "TietNghiaVuSauGiamTru" || col.FieldName == "GhiChu2")
            {
                //ViewTietNghiaVu v = (ViewTietNghiaVu)gridViewTietNghiaVu.GetRow(pos);
                //decimal? _tietNghiaVuMacDinh = _listTietNghiaVu.Find(p=>p.MaGiangVien == v.MaGiangVien).SoTietNghiaVu;
                //if (v.SoTietNghiaVu != _tietNghiaVuMacDinh)
                //    gridViewTietNghiaVu.SetRowCellValue(pos, "GhiChu", 1);
                gridViewTietNghiaVu.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString());
                gridViewTietNghiaVu.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
                gridViewTietNghiaVu.SetRowCellValue(pos, "GhiChu", true);
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
    }
}
