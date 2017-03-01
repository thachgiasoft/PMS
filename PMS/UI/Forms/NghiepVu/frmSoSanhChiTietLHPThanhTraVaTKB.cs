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

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmSoSanhChiTietLHPThanhTraVaTKB : DevExpress.XtraEditors.XtraForm
    {
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;

        public frmSoSanhChiTietLHPThanhTraVaTKB()
        {
            InitializeComponent();

            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }

            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            if (_maTruong == "IUH")
                btnLamTuoi.Caption = "Cập nhật mới";
        }

        private void frmSoSanhChiTietLHPThanhTraVaTKB_Load(object sender, EventArgs e)
        {
            #region InitGrid ThoiKhoaBieu
            AppGridView.InitGridView(gridViewThoiKhoaBieu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThoiKhoaBieu, new string[] { "Ngay", "MaLop", "Thu", "TietBatDau", "Phong", "MaCanBoGiangDay", "HoTen", "TienDo", "SoTiet", "Khac" }
                , new string[] { "Ngày", "Lớp", "thứ", "Tiết BĐ", "Phòng", "Mã CBGD", "Họ tên", "Tiến độ", "Số tiết", "Khac" }
                , new int[] { 80, 80, 50, 60, 50, 70, 130, 60, 60, 99 });
            AppGridView.AlignHeader(gridViewThoiKhoaBieu, new string[] { "Ngay", "MaLop", "Thu", "TietBatDau", "Phong", "MaCanBoGiangDay", "HoTen", "TienDo", "SoTiet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThoiKhoaBieu, "Ngay", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThoiKhoaBieu, "SoTiet", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.HideField(gridViewThoiKhoaBieu, new string[] { "Khac" });
            #endregion

            #region InitGrid ThanhTra
            AppGridView.InitGridView(gridViewThanhTra, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThanhTra, new string[] { "Ngay", "MaLop", "Thu", "TietBatDau", "Phong", "MaCanBoGiangDay", "HoTen", "TienDo", "SoTietGhiNhan", "Khac" }
                , new string[] { "Ngày", "Lớp", "thứ", "Tiết BĐ", "Phòng", "Mã CBGD", "Họ tên", "Tiến độ", "Số tiết ghi nhận", "Khac" }
                , new int[] { 80, 80, 50, 60, 50, 70, 130, 60, 90, 99 });
            AppGridView.AlignHeader(gridViewThanhTra, new string[] { "Ngay", "MaLop", "Thu", "TietBatDau", "Phong", "MaCanBoGiangDay", "HoTen", "TienDo", "SoTietGhiNhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhTra, "Ngay", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThanhTra, "SoTietGhiNhan", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.HideField(gridViewThanhTra, new string[] { "Khac" });
            #endregion

            #region InitNamHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region InitHocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Init LopHocPhan
            AppGridLookupEdit.InitGridLookUp(cboLopHocPhan, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLopHocPhan, new string[] { "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLop", "SiSo", "SoTinChi" }
                    , new string[] { "Mã lớp học phần", "Mã môn học", "Tên môn học", "Mã lớp", "Sĩ số", "STC" }
                    , new int[]{110, 90, 200, 100, 80, 60 });
            AppGridLookupEdit.InitPopupFormSize(cboLopHocPhan, 640, 650);
            cboLopHocPhan.Properties.DisplayMember = "MaLopHocPhan";
            cboLopHocPhan.Properties.ValueMember = "MaLopHocPhan";
            cboLopHocPhan.Properties.NullText = string.Empty;
            #endregion

            splitContainerControl1.SplitterPosition = splitContainerControl1.Width / 2;

            InitData();

        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboLopHocPhan.EditValue != null)
            {
                ViewLopHocPhan vLHP = bindingSourceLopHocPhan.Current as ViewLopHocPhan;
                txtThongTinLopHocPhan.Text = vLHP.MaLopHocPhan + " - " + vLHP.TenMonHoc + " - STC: " + vLHP.SoTinChi;

                DataTable tbTKB = new DataTable();
                IDataReader readerTKB = DataServices.ThanhTraTheoThoiKhoaBieu.SoSanhChiTietLopHocPhan(cboLopHocPhan.EditValue.ToString(), "1");
                tbTKB.Load(readerTKB);
                bindingSourceThoiKhoaBieu.DataSource = tbTKB;

                DataTable tblThanhTra = new DataTable();
                IDataReader readerThanhTra = DataServices.ThanhTraTheoThoiKhoaBieu.SoSanhChiTietLopHocPhan(cboLopHocPhan.EditValue.ToString(), "2");
                tblThanhTra.Load(readerThanhTra);
                bindingSourceThanhTra.DataSource = tblThanhTra;

                ToMauTKB(tbTKB);
                ToMauThanhTra(tblThanhTra);
            }
            Cursor.Current = Cursors.Default;
        }

        #region ToMau
        void ToMauTKB(DataTable list)
        {
            //--Cột khác: 
            //--1 là Khác thời khoá biểu, 
            //--2 là trùng lịch nhưng số tiết ghi nhận ít hơn tiến độ, 
            //--3 là trùng lịch nhưng ghi nhận nhiều hơn tiến độ,
            //--4 là thanh tra giống tkb
            //--0 là chưa thanh tra
            try
            {
                if (list.Rows.Count > 0)
                {
                    foreach (DataRow v in list.Rows)
                    {
                        if (v["Khac"].ToString() == "1")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThoiKhoaBieu, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Red, v["Khac"]);
                        }
                        if (v["Khac"].ToString() == "2")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThoiKhoaBieu, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Yellow, v["Khac"]);
                        }
                        if (v["Khac"].ToString() == "3")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThoiKhoaBieu, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Cyan, v["Khac"]);
                        }
                        if (v["Khac"].ToString() == "4")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThoiKhoaBieu, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Lime, v["Khac"]);
                        }
                    }
                }
            }
            catch
            { }

        }

        void ToMauThanhTra(DataTable list)
        {
            try
            {
                if (list.Rows.Count > 0)
                {
                    foreach (DataRow v in list.Rows)
                    {
                        if (v["Khac"].ToString() == "1")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThanhTra, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Red, v["Khac"]);
                        }
                        if (v["Khac"].ToString() == "2")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThanhTra, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Yellow, v["Khac"]);
                        }
                        if (v["Khac"].ToString() == "3")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThanhTra, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Cyan, v["Khac"]);
                        }
                        if (v["Khac"].ToString() == "4")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThanhTra, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Lime, v["Khac"]);
                        }
                    }
                }
            }
            catch
            { }

        }
        #endregion

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

    }
}