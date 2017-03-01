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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucTietNghiaVuTheoNamHocHocKy_UEL : DevExpress.XtraEditors.XtraUserControl
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

                btnChot.Enabled = false;
                btnHuyChot.Enabled = false;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        //VList<ViewTietNghiaVu> _listTietNghiaVu;
        string _maTruong;
        DateTime _ngayIn;
        TList<GiamTruDinhMuc> _listGiamTruKhac = new TList<GiamTruDinhMuc>();
        #endregion
        public ucTietNghiaVuTheoNamHocHocKy_UEL()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }
        }

        private void ucTietNghiaVuTheoNamHocHocKy_UEL_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "ChucDanh", "HoTen", "TenDonVi", "TenNgach", "SoTietNghiaVu", "PhanTramDuocGiam", "MaGiamTruKhac", "CongPhanTramGiam", "TietNghiaVuSauGiamTru", "GhiChu2", "NgayCapNhat", "NguoiCapNhat", "GhiChu" }
                , new string[] { "Mã nhân sự", "Học hàm - học vị", "Họ và tên", "Đơn vị", "Ngạch", "Số tiết chuẩn", "Phần trăm giảm trừ (%)", "Giảm trừ khác", "Cộng (%)", "Số tiết chuẩn nghĩa vụ", "Ghi chú", "NgayCapNhat", "Người cập nhật", "Đánh dấu" }
                    , new int[] { 70, 110, 140, 140, 80, 70, 60, 100, 60, 70, 200, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "MaQuanLy", "ChucDanh", "HoTen", "TenDonVi", "TenNgach", "SoTietNghiaVu", "PhanTramDuocGiam", "MaGiamTruKhac", "CongPhanTramGiam", "TietNghiaVuSauGiamTru", "GhiChu2", "NgayCapNhat", "NguoiCapNhat", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "MaQuanLy", "ChucDanh", "HoTen", "TenDonVi", "TenNgach", "SoTietNghiaVu", "PhanTramDuocGiam", "CongPhanTramGiam" });
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "NgayCapNhat", "NguoiCapNhat", "GhiChu" });
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietNghiaVu", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNghiaVuSauGiamTru", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTietNghiaVu, "MaGiamTruKhac", repositoryItemGridLookUpEditGiamTruKhac);
            PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 50);
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

            #region GiamTruKhac
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiamTruKhac, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiamTruKhac, new string[] { "NoiDungGiamTru", "PhanTramGiamTru" }, new string[] { "Nội dung giảm trừ", "Phần trăm được giảm" }, new int[] { 200, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiamTruKhac, 300, 500);
            repositoryItemGridLookUpEditGiamTruKhac.DisplayMember = "NoiDungGiamTru";
            repositoryItemGridLookUpEditGiamTruKhac.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiamTruKhac.NullText = String.Empty;
            #endregion

            InitData();
        }
        #region InitData
        void InitData()
        {
           //_listTietNghiaVu = DataServices.ViewTietNghiaVu.GetAll();
            _listGiamTruKhac = DataServices.GiamTruDinhMuc.GetAll();
            bindingSourceGiamTruKhac.DataSource = _listGiamTruKhac;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text !="")
                bindingSourceTietNghiaVu.DataSource = DataServices.ViewTietNghiaVuTheoNamHocHocKy.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            //ToMau(bindingSourceTietNghiaVu.DataSource as VList<ViewTietNghiaVu>);

            HideItems();

            KiemTraChot();
        }

        void HideItems()
        {
            if (_maTruong == "UEL")
            {
                layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                emptySpaceItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        void KiemTraChot()
        {
            int result = -1;
            DataServices.TietNghiaVu.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref result);
            if (result == 1)
            {
                btnLuu.Enabled = false;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = true;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = false;
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
                                xmlData += String.Format("<Input M=\"{0}\" K=\"{1}\" T=\"{2}\" N=\"{3}\" U=\"{4}\" G2=\"{5}\" />", kl.MaGiangVien, kl.MaGiamTruKhac, IsNull(kl.TietNghiaVuSauGiamTru), kl.NgayCapNhat, kl.NguoiCapNhat, kl.GhiChu2);
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceTietNghiaVu.EndEdit();
                        int kq = 0;
                        DataServices.TietNghiaVu.LuuUel(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
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

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }
            Cursor.Current = Cursors.WaitCursor;
            gridViewTietNghiaVu.FocusedRowHandle = -1;
            bindingSourceTietNghiaVu.EndEdit();
            DataTable data = bindingSourceTietNghiaVu.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewTietNghiaVu, bindingSourceTietNghiaVu);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewTietNghiaVu.SortedColumns)
                    {
                        switch (c.SortOrder)
                        {
                            case DevExpress.Data.ColumnSortOrder.Ascending:
                                sort += string.Format("{0} ASC, ", c.FieldName);
                                break;
                            case DevExpress.Data.ColumnSortOrder.Descending:
                                sort += string.Format("{0} DESC, ", c.FieldName);
                                break;
                        }
                    }
                }
                if (sort != "")
                    sort = sort.Substring(0, sort.Length - 2);
            }

            //string filter = gridViewTietNghiaVu.ActiveFilterString;
            ////if (filter.Contains(".0000m"))
            ////    filter = filter.Replace(".0000m", "");
            ////if (filter.Contains(".000m"))
            ////    filter = filter.Replace(".000m", "");
            ////if (filter.Contains(".00m"))
            ////    filter = filter.Replace(".00m", "");
            ////if (filter.Contains(".0m"))
            ////    filter = filter.Replace(".0m", "");
            ////if (filter.Contains(".m"))
            ////    filter = filter.Replace(".m", "");

            //DataView dv = new DataView(vListBaoCao, filter, sort, DataViewRowState.CurrentRows);
            ////vListBaoCao = dv.ToTable();
            ////if (vListBaoCao == null)
            //    return;

            int dem = vListBaoCao.Rows.Count;


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeSoTietNghiaVuGiangVien_UEL(PMS.Common.Globals._cauhinh.TenTruong);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTietNghiaVu.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn chốt tiết chuẩn nghĩa vụ của giảng viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VList<ViewTietNghiaVuTheoNamHocHocKy> list = bindingSourceTietNghiaVu.DataSource as VList<ViewTietNghiaVuTheoNamHocHocKy>;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (ViewTietNghiaVuTheoNamHocHocKy kl in list)
                        {
                            xmlData += String.Format("<Input M=\"{0}\" K=\"{1}\" T=\"{2}\" N=\"{3}\" U=\"{4}\" G2=\"{5}\" />", kl.MaGiangVien, kl.MaGiamTruKhac, IsNull(kl.TietNghiaVuSauGiamTru), kl.NgayCapNhat, kl.NguoiCapNhat, kl.GhiChu2);
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceTietNghiaVu.EndEdit();
                        int kq = 0;
                        DataServices.TietNghiaVu.Chot(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        InitData();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTietNghiaVu.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn huỷ chốt tiết chuẩn nghĩa vụ của giảng viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int kq = 0;
                    DataServices.TietNghiaVu.HuyChot("", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình huỷ chốt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    InitData();
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình huỷ chốt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceTietNghiaVu.DataSource = DataServices.ViewTietNghiaVuTheoNamHocHocKy.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            //ToMau(bindingSourceTietNghiaVu.DataSource as VList<ViewTietNghiaVu>);
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
                bindingSourceTietNghiaVu.DataSource = DataServices.ViewTietNghiaVuTheoNamHocHocKy.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            //ToMau(bindingSourceTietNghiaVu.DataSource as VList<ViewTietNghiaVu>);
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

            if (col.FieldName == "MaGiamTruKhac")
            {
                ViewTietNghiaVuTheoNamHocHocKy v = gridViewTietNghiaVu.GetRow(e.RowHandle) as ViewTietNghiaVuTheoNamHocHocKy;
                GiamTruDinhMuc g = _listGiamTruKhac.Find(p => p.MaQuanLy == v.MaGiamTruKhac);

                decimal? _congPhanTramGiam = g.PhanTramGiamTru + v.PhanTramDuocGiam;
                if (_congPhanTramGiam > 100) _congPhanTramGiam = 100;
                gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "CongPhanTramGiam", _congPhanTramGiam);
                gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "TietNghiaVuSauGiamTru", v.SoTietNghiaVu * (100 - (_congPhanTramGiam)) / 100);
            }
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

        private void repositoryItemGridLookUpEditGiamTruKhac_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            //if (!ParadiseUtility.IsNullOrEmptyOrDBNull(e.Value))
            //{
            //    e.DisplayText = string.Format("{0} ({1}, {2} {3})",
            //         e.DisplayText,
            //         grvUSPSLocation.GetRowCellValue(grvUSPSLocation.FocusedRowHandle, "City"),
            //         grvUSPSLocation.GetRowCellValue(grvUSPSLocation.FocusedRowHandle, "StateCode"),
            //         grvUSPSLocation.GetRowCellValue(grvUSPSLocation.FocusedRowHandle, "PostalCode"));
            //}
            //if (e.Column.FieldName == "MaGiamTruKhac")
            //    e.DisplayText = string.Format("{0}, {1}, {2}", e.Value.ToString(), fieldValue2, fieldValue3);
        }

    }
}
