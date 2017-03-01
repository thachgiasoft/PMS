using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid;
using DevExpress.Utils;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeChiTietKLGD_HVHQ : DevExpress.XtraEditors.XtraUserControl
    {
        #region Bien gia tri
        private IDataReader reader;

        #endregion

        public ucThongKeChiTietKLGD_HVHQ()
        {
            InitializeComponent();
        }

        private void ucThongKeChiTietKLGD_HVHQ_Load(object sender, EventArgs e)
        {
            #region Cau hinh chung
            TList<CauHinhChung> cauHinh = DataServices.CauHinhChung.GetAll();
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHoc.EditValue = cauHinh.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = cauHinh.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
  
            #region Init Khoa-DonVi
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();


            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon,v.MaBoMon + " - " +  v.TenBoMon, CheckState.Unchecked, true));
            }
            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
            #endregion
            #region InitData
            
            ConfigGridView();
            

            #endregion
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                
            }
            catch { }
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

       
        public void ConfigGridView()
        {

            #region Band Thông tin giảng viên

            GridBand bandThongTinGiangVien = new GridBand();
            bandThongTinGiangVien.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            bandThongTinGiangVien.Name = "bandThongTinGiangVien";
            bandThongTinGiangVien.AppearanceHeader.Options.UseTextOptions = true;
            bandThongTinGiangVien.Caption = "Thông tin giảng viên";
            bandThongTinGiangVien.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            bandThongTinGiangVien.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            bandThongTinGiangVien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            bandThongTinGiangVien.AutoFillDown = true;
            

            BandedGridColumn colMGV = new BandedGridColumn();
            colMGV = advBandedGridViewData.Columns.AddField("MaGiangVien");
            colMGV.VisibleIndex = 0;
            colMGV.AppearanceHeader.Options.UseTextOptions = true;
            colMGV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colMGV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colMGV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMGV.Visible = true;
            colMGV.OptionsColumn.ReadOnly = true;
            colMGV.MinWidth = 30;


            bandThongTinGiangVien.Columns.Insert(0, colMGV);
            bandThongTinGiangVien.Columns[0].Caption = "Mã GV";
            bandThongTinGiangVien.Columns[0].Width = 40;
            bandThongTinGiangVien.Columns[0].OptionsColumn.ReadOnly = true;
            bandThongTinGiangVien.Columns[0].MinWidth = 30;
            bandThongTinGiangVien.Columns[0].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            AppGridView.SummaryField(advBandedGridViewData, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);

            BandedGridColumn colHo = new BandedGridColumn();
            colHo = advBandedGridViewData.Columns.AddField("Ho");
            colHo.VisibleIndex = 1;
            colHo.AppearanceHeader.Options.UseTextOptions = true;
            colHo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colHo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colHo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            colHo.Visible = true;
            colHo.OptionsColumn.ReadOnly = true;
            colHo.MinWidth = 30;
            bandThongTinGiangVien.Columns.Insert(1, colHo);
            bandThongTinGiangVien.Columns[1].Caption = "Họ";
            bandThongTinGiangVien.Columns[1].Width = 85;
            bandThongTinGiangVien.Columns[1].OptionsColumn.ReadOnly = true;
            bandThongTinGiangVien.Columns[1].MinWidth = 30;
            bandThongTinGiangVien.Columns[1].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

           
            BandedGridColumn colTen = new BandedGridColumn();
            colTen = advBandedGridViewData.Columns.AddField("Ten");
            colTen.VisibleIndex = 2;
            colTen.AppearanceHeader.Options.UseTextOptions = true;
            colTen.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colTen.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            colTen.Visible = true;
            colTen.OptionsColumn.ReadOnly = true;
            colTen.MinWidth = 30;
            bandThongTinGiangVien.Columns.Insert(2, colTen);
            bandThongTinGiangVien.Columns[2].Caption = "Tên";
            bandThongTinGiangVien.Columns[2].Width = 40;
            bandThongTinGiangVien.Columns[2].MinWidth = 30;
            bandThongTinGiangVien.Columns[2].OptionsColumn.ReadOnly = true;
            bandThongTinGiangVien.Columns[2].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            BandedGridColumn colKhoa = new BandedGridColumn();
            colKhoa = advBandedGridViewData.Columns.AddField("TenBoMon");
            colKhoa.VisibleIndex = 3;
            colKhoa.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
            colKhoa.AppearanceHeader.Options.UseTextOptions = true;
            colKhoa.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colKhoa.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colKhoa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colKhoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            colKhoa.AutoFillDown = true;
           
            colKhoa.Visible = true;
            colKhoa.OptionsColumn.ReadOnly = true;
            colKhoa.MinWidth = 30;
            bandThongTinGiangVien.Columns.Insert(3, colKhoa);
            bandThongTinGiangVien.Columns[3].Caption = "Khoa - đơn vị";
            bandThongTinGiangVien.Columns[3].Width = 120;
            bandThongTinGiangVien.Columns[3].AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            bandThongTinGiangVien.Columns[3].AutoFillDown = true;
            bandThongTinGiangVien.Columns[3].MinWidth = 30;
            bandThongTinGiangVien.Columns[3].OptionsColumn.ReadOnly = true;
            bandThongTinGiangVien.Columns[3].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
           

            //BandedGridColumn colHocHam = new BandedGridColumn();
            //colHocHam = advBandedGridViewData.Columns.AddField("TenHocHam");
            //colHocHam.VisibleIndex = 4;
            //colHocHam.AppearanceHeader.Options.UseTextOptions = true;
            //colHocHam.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            //colHocHam.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            //colHocHam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            //colHocHam.Visible = true;
            //colHocHam.OptionsColumn.ReadOnly = true;
            //colHocHam.MinWidth = 30;
            //bandThongTinGiangVien.Columns.Insert(4, colHocHam);
            //bandThongTinGiangVien.Columns[4].Caption = "Học hàm";
            //bandThongTinGiangVien.Columns[4].Width = 60;
            //bandThongTinGiangVien.Columns[4].MinWidth = 30;
            //bandThongTinGiangVien.Columns[4].OptionsColumn.ReadOnly = true;
            //bandThongTinGiangVien.Columns[4].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            BandedGridColumn colHocVi = new BandedGridColumn();
            colHocVi = advBandedGridViewData.Columns.AddField("TenHocVi");
            colHocVi.VisibleIndex = 4;
            colHocVi.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
            colHocVi.AppearanceHeader.Options.UseTextOptions = true;
            colHocVi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colHocVi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colHocVi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            colHocVi.Visible = true;
            colHocVi.OptionsColumn.ReadOnly = true;
            colHocVi.MinWidth = 30;
            bandThongTinGiangVien.Columns.Insert(4, colHocVi);
            bandThongTinGiangVien.Columns[4].Caption = "Học vị";
            bandThongTinGiangVien.Columns[4].Width = 45;
            bandThongTinGiangVien.Columns[4].MinWidth = 30;
            bandThongTinGiangVien.Columns[4].OptionsColumn.ReadOnly = true;
            bandThongTinGiangVien.Columns[4].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            //BandedGridColumn colLoaiGV = new BandedGridColumn();
            //colLoaiGV = advBandedGridViewData.Columns.AddField("TenLoaiGiangVien");
            //colLoaiGV.VisibleIndex = 6;
            //colLoaiGV.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default;
            //colLoaiGV.AppearanceHeader.Options.UseTextOptions = true;
            //colLoaiGV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            //colLoaiGV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            //colLoaiGV.Visible = true;
            //colLoaiGV.OptionsColumn.ReadOnly = true;
            //colLoaiGV.MinWidth = 30;
            //bandThongTinGiangVien.Columns.Insert(6, colLoaiGV);
            //bandThongTinGiangVien.Columns[6].Caption = "Loại giảng viên";
            //bandThongTinGiangVien.Columns[6].Width = 70;
            //bandThongTinGiangVien.Columns[6].MinWidth = 30;
            //bandThongTinGiangVien.Columns[6].OptionsColumn.ReadOnly = true;
            //bandThongTinGiangVien.Columns[6].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            BandedGridColumn colMaMH = new BandedGridColumn();
            colMaMH = advBandedGridViewData.Columns.AddField("MaMonHoc");
            colMaMH.VisibleIndex = 5;
            colMaMH.AppearanceHeader.Options.UseTextOptions = true;
            colMaMH.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colMaMH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colMaMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            colMaMH.Visible = true;
            colMaMH.OptionsColumn.ReadOnly = true;
            colMaMH.MinWidth = 30;
            bandThongTinGiangVien.Columns.Insert(5, colMaMH);
            bandThongTinGiangVien.Columns[5].Caption = "Mã môn học";
            bandThongTinGiangVien.Columns[5].Width = 50;
            bandThongTinGiangVien.Columns[5].MinWidth = 30;
            bandThongTinGiangVien.Columns[5].OptionsColumn.ReadOnly = true;
            bandThongTinGiangVien.Columns[5].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            BandedGridColumn colTenMH = new BandedGridColumn();
            colTenMH = advBandedGridViewData.Columns.AddField("TenMonHoc");
            colTenMH.VisibleIndex = 6;
            colTenMH.AppearanceHeader.Options.UseTextOptions = true;
            colTenMH.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colTenMH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colTenMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            colTenMH.Visible = true;
            colTenMH.OptionsColumn.ReadOnly = true;
            colTenMH.MinWidth = 30;
            bandThongTinGiangVien.Columns.Insert(6, colTenMH);
            bandThongTinGiangVien.Columns[6].Caption = "Tên môn học";
            bandThongTinGiangVien.Columns[6].Width = 100;
            bandThongTinGiangVien.Columns[6].MinWidth = 30;
            bandThongTinGiangVien.Columns[6].OptionsColumn.ReadOnly = true;
            bandThongTinGiangVien.Columns[6].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            //BandedGridColumn colMaLHP = new BandedGridColumn();
            //colMaLHP = advBandedGridViewData.Columns.AddField("MaLopHocPhan");
            //colMaLHP.VisibleIndex = 9;
            //colMaLHP.AppearanceHeader.Options.UseTextOptions = true;
            //colMaLHP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            //colMaLHP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            //colMaLHP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            //colMaLHP.Visible = true;
            //colMaLHP.OptionsColumn.ReadOnly = true;
            //colMaLHP.MinWidth = 30;
            //bandThongTinGiangVien.Columns.Insert(9, colMaLHP);
            //bandThongTinGiangVien.Columns[9].Caption = "Mã lớp học phần";
            //bandThongTinGiangVien.Columns[9].Width = 80;
            //bandThongTinGiangVien.Columns[9].MinWidth = 30;
            //bandThongTinGiangVien.Columns[9].OptionsColumn.ReadOnly = true;
            //bandThongTinGiangVien.Columns[9].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            BandedGridColumn colMaLop = new BandedGridColumn();
            colMaLop = advBandedGridViewData.Columns.AddField("MaLop");
            colMaLop.VisibleIndex = 7;
            colMaLop.AppearanceHeader.Options.UseTextOptions = true;
            colMaLop.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colMaLop.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colMaLop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            colMaLop.Visible = true;
            colMaLop.OptionsColumn.ReadOnly = true;
            colMaLop.MinWidth = 30;
            bandThongTinGiangVien.Columns.Insert(7, colMaLop);
            bandThongTinGiangVien.Columns[7].Caption = "Mã lớp";
            bandThongTinGiangVien.Columns[7].Width = 100;
            bandThongTinGiangVien.Columns[7].MinWidth = 30;
            bandThongTinGiangVien.Columns[7].OptionsColumn.ReadOnly = true;
            bandThongTinGiangVien.Columns[7].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

           
            #endregion
            #region Band Số tiết theo loại học phần 
           
            VList<ViewLoaiHocPhan> listLoaiHocPhan = DataServices.ViewLoaiHocPhan.GetAll();
            listLoaiHocPhan.Sort((a, b) => b.MaLoaiHocPhan.CompareTo(a.MaLoaiHocPhan));

            advBandedGridViewData.Bands.Clear();
            advBandedGridViewData.Bands.Add(bandThongTinGiangVien);

            GridBand bandSoTiet = new GridBand();
            bandSoTiet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            bandSoTiet.Name = "bandSoTiet";
            bandSoTiet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            bandSoTiet.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            bandSoTiet.AppearanceHeader.Options.UseTextOptions = true;
            bandSoTiet.Caption = "Số tiết";
            foreach (ViewLoaiHocPhan c in listLoaiHocPhan)
            {
               

                BandedGridColumn colLT= new BandedGridColumn();
                colLT = advBandedGridViewData.Columns.AddField(c.TenLoaiHocPhan);
                colLT.VisibleIndex = 0;
                colLT.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;

                colLT.AppearanceHeader.Options.UseTextOptions = true;
                colLT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                colLT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                colLT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                colLT.Visible = true;
                colLT.OptionsColumn.ReadOnly = true;
                colLT.MinWidth = 30;


                bandSoTiet.Columns.Insert(0, colLT);
                bandSoTiet.Columns[0].Caption = c.TenLoaiHocPhan;
                bandSoTiet.Columns[0].Width = 40;
                bandSoTiet.Columns[0].MinWidth = 30;
                bandSoTiet.Columns[0].OptionsColumn.ReadOnly = true;
                bandSoTiet.Columns[0].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
               
                AppGridView.SummaryField(advBandedGridViewData, c.TenLoaiHocPhan, "{0:n0}", DevExpress.Data.SummaryItemType.Sum);
                AppGridView.FormatDataField(advBandedGridViewData, c.TenLoaiHocPhan, DevExpress.Utils.FormatType.Custom, "n0");
                
            }
           
            advBandedGridViewData.Bands.Add(bandSoTiet);
            
            #endregion


            #region Band tổng số 

            GridBand bandTongSoTiet = new GridBand();
            bandTongSoTiet.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            bandTongSoTiet.Name = "bandTongSoTiet";
            bandTongSoTiet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            bandTongSoTiet.AppearanceHeader.Options.UseTextOptions = true;
            bandTongSoTiet.Caption = "Tổng số tiết";
           
            BandedGridColumn colTongSoTiet = new BandedGridColumn();
            colTongSoTiet = advBandedGridViewData.Columns.AddField("TongSoTiet");
            colTongSoTiet.VisibleIndex = 0;
            colTongSoTiet.AppearanceHeader.Options.UseTextOptions = true;
            colTongSoTiet.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colTongSoTiet.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colTongSoTiet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
       
            colTongSoTiet.Visible = true;
            colTongSoTiet.OptionsColumn.ReadOnly = true;
            colTongSoTiet.MinWidth = 30;
            bandTongSoTiet.Columns.Insert(0, colTongSoTiet);
            bandTongSoTiet.Columns[0].Caption = " ";
            bandTongSoTiet.Columns[0].Width = 50;
            bandTongSoTiet.Columns[0].OptionsColumn.ReadOnly = true;
            bandTongSoTiet.Columns[0].MinWidth = 30;
            bandTongSoTiet.Columns[0].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            AppGridView.SummaryField(advBandedGridViewData, "TongSoTiet", "{0:n0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(advBandedGridViewData, "TongSoTiet", DevExpress.Utils.FormatType.Custom, "n0");   
            advBandedGridViewData.Bands.Add(bandTongSoTiet);
            #endregion
            advBandedGridViewData.Columns["MaGiangVien"].GroupIndex = 0;
      
            advBandedGridViewData.ExpandAllGroups();

            advBandedGridViewData.BestFitColumns();

        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {



                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.KhoiLuongGiangDayChiTiet.ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    tb.Load(reader);
                    reader.Close();

                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        decimal _sumTongSoTiet = 0;
                        DataRow _sum = tb.NewRow();
                        for (int j = 1; j <= tb.Rows.Count; j++)
                        {
                            if (tb.Rows[i]["MaGiangVien"].ToString() == tb.Rows[j]["MaGiangVien"].ToString())
                            {
                                _sumTongSoTiet += Convert.ToDecimal(tb.Rows[i]["TongSoTiet"].ToString()) + Convert.ToDecimal(tb.Rows[j]["TongSoTiet"].ToString());
                            }
                            _sum["MaGiangVien"] = tb.Rows[i]["MaGiangVien"].ToString();
                            _sum["TongSoTiet"] = _sumTongSoTiet;

                        }
                     
                        
                        tb.Rows.Add(_sum);
                    }
                   
                        bindingSourceData.DataSource = tb;
                        //bindingSourceData.Sort = tb.Columns["Ten"].ToString();
                   
                    ConfigGridView();
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa chọn đơn vị - năm học - học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                bindingSourceData.Clear();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)| *.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlData.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                printableComponentLink1.CreateDocument();
                // Show the report. 
                printableComponentLink1.ShowPreview();
            }
            
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printableComponentLink1_CreateReportFooterArea(object sender, CreateAreaEventArgs e)
        {
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll();
            if (listCauHinh != null)
            {
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }

            TextBrick brick = new TextBrick();
            brick = e.Graph.DrawString("TRƯỞNG PHÒNG ĐÀO TẠO\n\n\n\n\n" + PMS.Common.Globals._cauhinh.PhongDaoTao, Color.Black, new RectangleF(50, 10, 300, 40), DevExpress.XtraPrinting.BorderSide.None);
            brick.BackColor = Color.White;
            brick.Font = new Font("Times New Roman", 12);
            brick.StringFormat = new BrickStringFormat(StringAlignment.Center);

            //TextBrick brick1 = new TextBrick();
            //brick1 = e.Graph.DrawString("" + PMS.Common.Globals._cauhinh.PhongDaoTao, Color.Black, new RectangleF(350, 10, 200, 250), DevExpress.XtraPrinting.BorderSide.None);
            //brick1.BackColor = Color.White;
            //brick1.Font = new Font("Times New Roman", 12);
            //brick1.StringFormat = new BrickStringFormat(StringAlignment.Center);

            DateTime dt = DateTime.Now.Date;
            string date = "ngày " + dt.Day.ToString() + " tháng " + dt.Month.ToString() + " năm " + dt.Year.ToString();
            TextBrick brick2 = new TextBrick();
            brick2 = e.Graph.DrawString("Khánh Hòa, " + date + "\nNgười lập bảng\n\n\n\n" + PMS.Common.Globals._cauhinh.NguoiLapbieu, Color.Black, new RectangleF(600, 10, 300, 250), DevExpress.XtraPrinting.BorderSide.None);
            brick2.BackColor = Color.White;
            brick2.Font = new Font("Times New Roman", 12);
            brick2.StringFormat = new BrickStringFormat(StringAlignment.Center);
        }

        private void printableComponentLink1_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null && cboHocKy.EditValue != null)
            {
                e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
                e.Graph.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                RectangleF rec0 = new RectangleF(0, 0, 420, 50);
                e.Graph.DrawString("HỌC VIỆN HẢI QUÂN\n", Color.Black, rec0, DevExpress.XtraPrinting.BorderSide.None);


                e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
                e.Graph.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                RectangleF rec1 = new RectangleF(0, 20, 420, 50);
                e.Graph.DrawString("PHÒNG ĐÀO TẠO", Color.Black, rec1, DevExpress.XtraPrinting.BorderSide.None);


                e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
                e.Graph.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                RectangleF rec2 = new RectangleF(0,50, e.Graph.ClientPageSize.Width,85);
                e.Graph.DrawString("THỐNG KÊ CHI TIẾT KHỐI LƯỢNG GIẢNG DẠY\n" + cboHocKy.EditValue.ToString() + " - NĂM HỌC: " + cboNamHoc.EditValue.ToString() +"\n", Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None);

          
            }
        }
    }
}
