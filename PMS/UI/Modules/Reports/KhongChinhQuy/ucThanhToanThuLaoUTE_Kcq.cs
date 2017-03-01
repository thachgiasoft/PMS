using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.DataForm;
using PMS.UI.Forms.BaoCao;
using PMS.Services;


namespace PMS.UI.Modules.Reports.KhongChinhQuy
{
    public partial class ucThanhToanThuLaoUTE_Kcq : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable 
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion
        #region Even Form
        public ucThanhToanThuLaoUTE_Kcq()
        {
            InitializeComponent();
        }

        private void ucThanhToanThuLaoUTE_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewThanhToan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThanhToan, new string[] { "MaQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "SoTiet", "MaLopHocPhan", "MaLop", "SiSo", "HeSoLopDongLyThuyet", "HeSoLopDongThTnTt", "DonGia", "TongThanhTien" }
                , new string[] { "Mã giảng viên", "Họ và tên", "Mã môn học", "tên môn học", "STC", "Số tiết", "Mã lớp học phần", "Mã lớp", "Sĩ số", "hệ số lớp động LT", "Hệ số TH-TN-TT", "Đơn giá", "Thành tiền" }
                , new int[] { 80, 150, 100, 180, 50, 70, 110, 90, 80, 120, 120, 100, 100 });
            AppGridView.AlignHeader(gridViewThanhToan, new string[] { "MaQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "SoTiet", "MaLopHocPhan", "MaLop", "SiSo", "HeSoLopDongLyThuyet", "HeSoLopDongThTnTt", "DonGia", "TongThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhToan, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThanhToan, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToan, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewThanhToan);
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

            #region Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa"}, new string[] { "Mã khoa", "Tên khoa" }, new int[] { 80, 130 });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            
            #endregion

            #region LoaiGiangVien
            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "tên loại giảng viên" });
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion
        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            bindingSourceKhoaDonVi.DataSource = DataServices.ViewKhoa.GetAll();
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            cboKhoaDonVi.DataBindings.Clear();
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);
            cboLoaiGiangVien.DataBindings.Clear();
            cboLoaiGiangVien.DataBindings.Add("EditValue", bindingSourceLoaiGiangVien, "MaLoaiGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
                bindingSourceThanhToan.DataSource = DataServices.KcqUteThanhToanThuLao.GetByNamHocHocKyDonViLoaiGiangVien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), int.Parse(cboLoaiGiangVien.EditValue.ToString()));
        }
        #endregion

        #region Event Button
        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
                bindingSourceThanhToan.DataSource = DataServices.KcqUteThanhToanThuLao.GetByNamHocHocKyDonViLoaiGiangVien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), int.Parse(cboLoaiGiangVien.EditValue.ToString()));
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //gridViewThanhToan.FocusedRowHandle = -1;
            //bindingSourceThanhToan.EndEdit();
            
            //DataTable data = bindingSourceThanhToan.DataSource as DataTable;
            TList<KcqUteThanhToanThuLao> data = new TList<KcqUteThanhToanThuLao>();
            data = bindingSourceThanhToan.DataSource as TList<KcqUteThanhToanThuLao>;
            
            if (data == null)
                return;
            //DataTable vListBaoCao = data as DataTable;
            ////if (vListBaoCao == null)
            //    return;
            //string sort = "";
            //if (vListBaoCao != null)
            //{
            //    //if (vListBaoCao.Rows.Count != 0)
            //    //if(vListBaoCao.c
            //    {
            //        foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThanhToan.SortedColumns)
            //        {
            //            switch (c.SortOrder)
            //            {
            //                case DevExpress.Data.ColumnSortOrder.Ascending:
            //                    sort += string.Format("{0} ASC, ", c.FieldName);
            //                    break;
            //                case DevExpress.Data.ColumnSortOrder.Descending:
            //                    sort += string.Format("{0} DESC, ", c.FieldName);
            //                    break;
            //            }
            //        }
            //    }
            //    if (sort != "")
            //        sort = sort.Substring(0, sort.Length - 2);
            //}
            //string filter = gridViewThanhToan.ActiveFilterString;
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

            ////string filter = gridViewHopDongMoiGiangVien.ActiveFilterString;
            ////vListBaoCao = dv.ToTable();
            ////if (vListBaoCao == null)
            //    return;
         
            //if (vListBaoCao != null)
            //{
                using (frmBaoCao frm = new frmBaoCao())
                {
                    //frm.InThanhToanThuLaoTheoKhoa(PMS.Common.Globals._cauhinh.TenTruong, cboKhoaDonVi.Text, cboLoaiGiangVien.Text, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), PMS.Common.Globals._cauhinh.NguoiLapbieu, data);
                    frm.ShowDialog();
                }
            //}
            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}
