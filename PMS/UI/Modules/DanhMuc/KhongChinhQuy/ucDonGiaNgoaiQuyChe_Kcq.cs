using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.Entities.Validation;
using PMS.UI.Forms.NghiepVu;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc.KhongChinhQuy
{
    public partial class ucDonGiaNgoaiQuyChe_Kcq : DevExpress.XtraEditors.XtraUserControl
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

                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewGiangVien> _listGiangVien = new VList<ViewGiangVien>();
        string _maTruong;
        #endregion
        public ucDonGiaNgoaiQuyChe_Kcq()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            if (_maTruong == "TCB")
            {
                layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void ucDonGiaNgoaiQuyChe_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewDonGiaNgoaiQuyChe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewDonGiaNgoaiQuyChe, new string[] { "MaGiangVien", "HoTen", "DonGiaDaiTra", "DonGiaClc", "GhiChu", "NgayCapNhat", "TuNgay", "DenNgay" }
                    , new string[] { "Mã giảng viên", "Họ và tên", "Đơn giá", "Đơn giá CLC", "Ghi chú", "NgayCapNhat", "Từ ngày", "Đến ngày" }
                    , new int[] { 90, 150, 90, 90, 150, 100, 100, 100 });
            AppGridView.ShowEditor(gridViewDonGiaNgoaiQuyChe, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewDonGiaNgoaiQuyChe, new string[] { "MaGiangVien", "HoTen", "DonGiaDaiTra", "DonGiaClc", "GhiChu", "TuNgay", "DenNgay" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewDonGiaNgoaiQuyChe, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewDonGiaNgoaiQuyChe, new string[] { "HoTen" });
            //gridViewLietKeKhoiLuong.Columns["PhanLoai"].GroupIndex = 0;

            AppGridView.FormatDataField(gridViewDonGiaNgoaiQuyChe, "DonGiaDaiTra", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewDonGiaNgoaiQuyChe, "DonGiaClc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewDonGiaNgoaiQuyChe, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewDonGiaNgoaiQuyChe, "TuNgay", repositoryItemDateEditTuNgay);
            AppGridView.RegisterControlField(gridViewDonGiaNgoaiQuyChe, "DenNgay", repositoryItemDateEditDenNgay);
            AppGridView.HideField(gridViewDonGiaNgoaiQuyChe, new string[] { "NgayCapNhat" });
            if (_maTruong != "TCB")
                AppGridView.HideField(gridViewDonGiaNgoaiQuyChe, new string[] { "TuNgay", "DenNgay" });
            if (_maTruong == "TCB")
                AppGridView.HideField(gridViewDonGiaNgoaiQuyChe, new string[] { "DonGiaClc" });
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

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã giảng viên", "Họ tên" });
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion
            InitData();
        }
        #region InitData
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            if (_maTruong == "TCB")
            {
                bindingSourceDonGiaNgoaiQuyChe.DataSource = DataServices.ViewKcqDonGiaNgoaiQuyChe.GetAll();
            }
            else
            {
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    bindingSourceDonGiaNgoaiQuyChe.DataSource = DataServices.ViewKcqDonGiaNgoaiQuyChe.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDonGiaNgoaiQuyChe.DeleteSelectedRows();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewDonGiaNgoaiQuyChe.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VList<ViewKcqDonGiaNgoaiQuyChe> list = bindingSourceDonGiaNgoaiQuyChe.DataSource as VList<ViewKcqDonGiaNgoaiQuyChe>;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (ViewKcqDonGiaNgoaiQuyChe kl in list)
                        {
                            if (kl.NgayCapNhat == null)
                                kl.NgayCapNhat = DateTime.Now;
                            if (kl.TuNgay == null)
                                kl.TuNgay = DateTime.Now;
                            if (kl.DenNgay == null)
                                kl.DenNgay = DateTime.Now;
                            if (kl.MaGiangVien != null)
                            {
                                xmlData += "<Input M=\"" + kl.MaGiangVien.ToString()
                                        + "\" Dt=\"" + IsNull(kl.DonGiaDaiTra)//kl.DonGiaDaiTra.ToString()
                                        + "\" Clc=\"" + IsNull(kl.DonGiaClc)//kl.DonGiaClc.ToString()
                                        + "\" G=\"" + IsNull(kl.GhiChu)//kl.GhiChu.ToString()
                                        + "\" T=\"" + ((DateTime)kl.NgayCapNhat).ToString("yyyy/MM/dd HH:mm:ss")
                                        + "\" Tn=\"" + ((DateTime)kl.TuNgay).ToString("yyyy/MM/dd HH:mm:ss")
                                        + "\" Dn=\"" + ((DateTime)kl.DenNgay).ToString("yyyy/MM/dd HH:mm:ss")
                                        + "\" />";
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceDonGiaNgoaiQuyChe.EndEdit();
                        int kq = 0;
                        DataServices.KcqDonGiaNgoaiQuyChe.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
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
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDonGiaNgoaiQuyChe.DataSource = DataServices.ViewKcqDonGiaNgoaiQuyChe.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDonGiaNgoaiQuyChe.DataSource = DataServices.ViewKcqDonGiaNgoaiQuyChe.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void gridViewDonGiaNgoaiQuyChe_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            if (col.FieldName == "MaGiangVien")
            {
                ViewKcqDonGiaNgoaiQuyChe v = (ViewKcqDonGiaNgoaiQuyChe)gridViewDonGiaNgoaiQuyChe.GetRow(pos);
                string _hoTen = _listGiangVien.Find(p => p.MaGiangVien == v.MaGiangVien).HoTen;
                gridViewDonGiaNgoaiQuyChe.SetRowCellValue(pos, "HoTen", _hoTen);
                gridViewDonGiaNgoaiQuyChe.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now);
            }
            if (col.FieldName == "DonGiaDaiTra" || col.FieldName == "DonGiaClc" || col.FieldName == "GhiChu")
            {
                ViewKcqDonGiaNgoaiQuyChe v = (ViewKcqDonGiaNgoaiQuyChe)gridViewDonGiaNgoaiQuyChe.GetRow(pos);
                gridViewDonGiaNgoaiQuyChe.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now);
            }
        }

        private void gridViewDonGiaNgoaiQuyChe_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGiaNgoaiQuyChe, e);
        }

        private void gridViewDonGiaNgoaiQuyChe_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        string IsNull(object o)
        { 
            if(o == null)
                return "";
            else return o.ToString();
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHocHocKy_Kcq frm = new frmSaoChepNamHocHocKy_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepDonGiaNgoaiQuyChe"))
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
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlDonGiaNgoaiQuyChe.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}
