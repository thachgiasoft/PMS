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
using PMS.UI.Forms.BaoCao;
using PMS.Services;
using DevExpress.XtraPrinting;
using PMS.UserReports;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThanhToanTienGiangVuotGioBoSung : DevExpress.XtraEditors.XtraUserControl
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
        int lanchot01 = 0, lanchot02 = 0;
        bool isInitGrid;

        //DataSet _dsData;
        #endregion
        public ucThanhToanTienGiangVuotGioBoSung()
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
            btnIn.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        private void ucBangThanhToanThuLaoTheoKhoa_Load(object sender, EventArgs e)
        {
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            
            #region LanChot01
            AppGridLookupEdit.InitGridLookUp(cboLanChotHK01, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotHK01, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotHK01.Properties.ValueMember = "LanChot";
            cboLanChotHK01.Properties.DisplayMember = "LanChot";
            cboLanChotHK01.Properties.NullText = string.Empty;
            #endregion

            #region LanChot02
            AppGridLookupEdit.InitGridLookUp(cboLanChotHK02, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotHK02, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotHK02.Properties.ValueMember = "LanChot";
            cboLanChotHK02.Properties.DisplayMember = "LanChot";
            cboLanChotHK02.Properties.NullText = string.Empty;
            #endregion
            #region Init Khoa-DonVi
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            VList<ViewKhoa> _vListKhoaBoMon = new VList<ViewKhoa>();
            _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
            #endregion

            InitData();
        }
        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            if (cboNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null && cboLanChotHK01.Text != "" && cboLanChotHK02.Text != "")
            {
                //_dsData = Libraries.BLL.DBComunication.ExecProc("sp_psc_pms_GetBangThanhToanVuotGioBoSung", new string[] { "Luoi", "_namHoc", "Data" }
                //    , cboNamHoc.EditValue.ToString(), cboLanChotHK01.EditValue.ToString(), cboLanChotHK02.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());

                DataTable tblData = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetDataVuotGioBoSung(cboNamHoc.EditValue.ToString(), int.Parse(PMS.Common.Globals.IsNull(cboLanChotHK01.EditValue, "int").ToString()), int.Parse(PMS.Common.Globals.IsNull(cboLanChotHK02.EditValue, "int").ToString()), cboKhoaDonVi.EditValue.ToString());
                tblData.Load(reader);

                foreach (DataColumn col in tblData.Columns)
                {
                    col.ReadOnly = false;
                }
                #region Init GirdView

                //if (isInitGrid) return;
                InitGridView();
                //isInitGrid = true;
                advBandedGridViewData.ExpandAllGroups();
                advBandedGridViewData.BestFitColumns();
                #endregion
            }
        }


        void InitGridView()
        {
            #region Tao band
            advBandedGridViewData.Bands.Clear();

            advBandedGridViewData.OptionsView.ShowAutoFilterRow = true;

            //if (_dsData == null)
            //    _dsData = Libraries.BLL.DBComunication.ExecProc("sp_psc_pms_GetBangThanhToanVuotGioBoSung", new string[] { "Luoi", "_namHoc", "Data" }
            //         , cboNamHoc.EditValue.ToString(), cboLanChotHK01.EditValue.ToString(), cboLanChotHK02.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            DataTable tblData = new DataTable();
            IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetDataVuotGioBoSung(cboNamHoc.EditValue.ToString(), int.Parse(PMS.Common.Globals.IsNull(cboLanChotHK01.EditValue, "int").ToString()), int.Parse(PMS.Common.Globals.IsNull(cboLanChotHK02.EditValue, "int").ToString()), cboKhoaDonVi.EditValue.ToString());
            tblData.Load(reader);

            foreach (DataColumn col in tblData.Columns)
            {
                col.ReadOnly = false;
            }

            gridControlData.DataSource = tblData;
            DataTable tblLuoi = new DataTable();
            IDataReader readerLuoi = DataServices.KetQuaThanhToanThuLao.GetLuoiVuotGioBoSung(cboNamHoc.EditValue.ToString(), int.Parse(PMS.Common.Globals.IsNull(cboLanChotHK01.EditValue, "int").ToString()), int.Parse(PMS.Common.Globals.IsNull(cboLanChotHK02.EditValue, "int").ToString()), cboKhoaDonVi.EditValue.ToString());
            tblLuoi.Load(readerLuoi);
            //foreach (DataRow drColumn in _dsData.Tables["Luoi"].Rows)
            foreach (DataRow drColumn in tblLuoi.Rows)
            {
                DevExpress.XtraGrid.Views.BandedGrid.GridBand Band = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
                Band.Name = drColumn["BandName"].ToString();
                Band.Caption = drColumn["BandCaption"].ToString();
                Band.AppearanceHeader.Options.UseTextOptions = true;
                Band.RowCount = 4;
                Band.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                Band.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                Band.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                advBandedGridViewData.Bands.Add(Band);

                DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
                col2.Caption = drColumn["ColCaption"].ToString();
                col2.FieldName = drColumn["FieldName"].ToString();
                col2.AppearanceHeader.Options.UseTextOptions = true;
                col2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                col2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                col2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                col2.Visible = true;
                //col2.OptionsColumn.ReadOnly = true;
                col2.MinWidth = 70;
                Band.Columns.Add(col2);

            }

            AppGridView.FormatDataField(advBandedGridViewData, "TongCong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(advBandedGridViewData, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(advBandedGridViewData, "TamThuThue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(advBandedGridViewData, "ThucNhan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(advBandedGridViewData, "NamHocTruoc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(advBandedGridViewData, "SoTietTH", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(advBandedGridViewData, "DinhMucNCKH", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(advBandedGridViewData, "NamHocSau", DevExpress.Utils.FormatType.Custom, "n0");

            advBandedGridViewData.OptionsView.ShowFooter = true;
            advBandedGridViewData.Columns["NamHocTruoc"].SummaryItem.FieldName = "NamHocTruoc";
            advBandedGridViewData.Columns["NamHocTruoc"].SummaryItem.DisplayFormat = "{0}";
            advBandedGridViewData.Columns["NamHocTruoc"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
        

            advBandedGridViewData.Columns["TenDonVi"].Caption = "Khoa";
            advBandedGridViewData.Columns["TenDonVi"].GroupIndex = 0;
            //DevExpress.XtraGrid.Views.Grid.GridView View = advBandedGridViewData;

            advBandedGridViewData.SortInfo.ClearAndAddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[]{
                    new DevExpress.XtraGrid.Columns.GridColumnSortInfo(advBandedGridViewData.Columns["TenDonVi"], DevExpress.Data.ColumnSortOrder.Ascending)
                }, 1);

            advBandedGridViewData.Columns["TenDonVi"].Visible = false;
            advBandedGridViewData.Columns["TenDonVi"].OwnerBand.Visible = false;
            #endregion
        }

        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null)
            {
                cboLanChotHK01.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), "HK01", ref lanchot01);
                DataTable tblLanChot01 = new DataTable();
                tblLanChot01.Columns.Add("LanChot");
                if (lanchot01 > 0)
                {
                    for (int i = lanchot01; i >= 1; i--)
                    {
                        tblLanChot01.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotHK01.DataSource = tblLanChot01;
                cboLanChotHK01.DataBindings.Add("EditValue", bindingSourceLanChotHK01, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);

                cboLanChotHK02.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), "HK02", ref lanchot02);
                DataTable tblLanChot02 = new DataTable();
                tblLanChot02.Columns.Add("LanChot");
                if (lanchot02 > 0)
                {
                    for (int i = lanchot02; i >= 1; i--)
                    {
                        tblLanChot02.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotHK02.DataSource = tblLanChot02;
                cboLanChotHK02.DataBindings.Add("EditValue", bindingSourceLanChotHK02, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                string _lanChotHK01, _lanChotHK02;
                if (cboLanChotHK01.EditValue == null)
                    _lanChotHK01 = "0";
                else _lanChotHK01 = cboLanChotHK01.EditValue.ToString();

                if (cboLanChotHK02.EditValue == null)
                    _lanChotHK02 = "0";
                else _lanChotHK02 = cboLanChotHK02.EditValue.ToString();

              //  _dsData = Libraries.BLL.DBComunication.ExecProc("sp_psc_pms_GetBangThanhToanVuotGioBoSung", new string[] { "Luoi", "_namHoc", "Data" }
              //, cboNamHoc.EditValue.ToString(), _lanChotHK01, _lanChotHK02, cboKhoaDonVi.EditValue.ToString());
                DataTable tblData = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetDataVuotGioBoSung(cboNamHoc.EditValue.ToString(), int.Parse(_lanChotHK01), int.Parse(_lanChotHK02), cboKhoaDonVi.EditValue.ToString());
                tblData.Load(reader);

                foreach (DataColumn col in tblData.Columns)
                {
                    col.ReadOnly = false;
                }

                gridControlData.DataSource = tblData;

                InitGridView();
            }
            advBandedGridViewData.ExpandAllGroups();
            advBandedGridViewData.BestFitColumns();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //DataTable dtData = _dsData.Tables["Data"];
                DataTable dtData = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetDataVuotGioBoSung(cboNamHoc.EditValue.ToString(), int.Parse(PMS.Common.Globals.IsNull(cboLanChotHK01.EditValue, "int").ToString()), int.Parse(PMS.Common.Globals.IsNull(cboLanChotHK02.EditValue, "int").ToString()), cboKhoaDonVi.EditValue.ToString());
                dtData.Load(reader);

                if (dtData != null && dtData.Rows.Count > 0)
                {
                    int _lanChotHK01, _lanChotHK02;
                    if (cboLanChotHK01.EditValue == null)
                        _lanChotHK01 = 0;
                    else _lanChotHK01 = int.Parse(PMS.Common.Globals.IsNull(cboLanChotHK01.EditValue, "int").ToString());

                    if (cboLanChotHK02.EditValue == null)
                        _lanChotHK02 = 0;
                    else _lanChotHK02 = int.Parse(PMS.Common.Globals.IsNull(cboLanChotHK02.EditValue, "int").ToString());

                    DataTable tblNamHoc = new DataTable();
                    IDataReader readerNamHoc = DataServices.KetQuaThanhToanThuLao.GetBangNamVuotGioBoSung(cboNamHoc.EditValue.ToString(), _lanChotHK01, _lanChotHK02, cboKhoaDonVi.EditValue.ToString());
                    tblNamHoc.Load(readerNamHoc);

                    //string soTietChuyenSang = _dsData.Tables["_namHoc"].Rows[0]["NamHocTruoc"].ToString();
                    //string soTietThucHien = _dsData.Tables["_namHoc"].Rows[0]["TieuDeSoTietThucHien"].ToString();
                    //string soTietNCKH = _dsData.Tables["_namHoc"].Rows[0]["TieuDeNCKH"].ToString();
                    //string tieuDe = _dsData.Tables["_namHoc"].Rows[0]["TieuDe"].ToString();
                    //string soTietChuyenSangNHSau = _dsData.Tables["_namHoc"].Rows[0]["NamHocSau"].ToString();
                    string soTietChuyenSang = tblNamHoc.Rows[0]["NamHocTruoc"].ToString();
                    string soTietThucHien = tblNamHoc.Rows[0]["TieuDeSoTietThucHien"].ToString();
                    string soTietNCKH = tblNamHoc.Rows[0]["TieuDeNCKH"].ToString();
                    string tieuDe = tblNamHoc.Rows[0]["TieuDe"].ToString();
                    string soTietChuyenSangNHSau = tblNamHoc.Rows[0]["NamHocSau"].ToString();
                    rptThanhToanVuotGioBoSung report = new rptThanhToanVuotGioBoSung();
                    report.InitData(soTietChuyenSang, soTietThucHien, soTietNCKH, tieuDe, soTietChuyenSangNHSau, dtData);
                    //report.ShowPreviewDialog();
                }
            }
            catch { }
        }
        void link_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick tb = new TextBrick();
            tb.Rect = new RectangleF(0, 0, 1000, 20);
            tb.Text = "TRƯỜNG ĐẠI HỌC NGÂN HÀNG";
            e.Graph.DrawBrick(tb);
            tb.BorderColor = Color.White;

            TextBrick tb2 = new TextBrick();
            tb2.Rect = new RectangleF(0, 0, 1000, 40);
            tb2.Text = "TP.HỒ CHÍ MINH";
            e.Graph.DrawBrick(tb2);
            tb2.BorderColor = Color.White;

            TextBrick tb11 = new TextBrick();
            tb11.Rect = new RectangleF(1000, 0, 1000, 20);
            tb11.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            e.Graph.DrawBrick(tb11);
            tb11.BorderColor = Color.White;

            TextBrick tb22 = new TextBrick();
            tb22.Rect = new RectangleF(0, 0, 1000, 40);
            tb22.Text = "Độc lập - Tự do - Hạnh phúc";
            e.Graph.DrawBrick(tb22);
            tb22.BorderColor = Color.White;

            TextBrick tb3 = new TextBrick();
            tb3.Rect = new RectangleF(0, 40, 1000, 20);
            tb3.Text = "BẢNG THANH TOÁN TIỀN GIẢNG VƯỢT GIỜ BỔ SUNG";
            tb3.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            tb3.VertAlignment = DevExpress.Utils.VertAlignment.Center;
            e.Graph.DrawBrick(tb3);
            tb3.BorderColor = Color.White;

            TextBrick tb4 = new TextBrick();
            tb4.Rect = new RectangleF(0, 60, 1000, 20);
            tb4.Text = "(PHẦN ĐÃ TẠM TRỪ NCKH CỦA GV NĂM HỌC " + cboNamHoc.EditValue.ToString() + ")";
            tb4.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            tb4.VertAlignment = DevExpress.Utils.VertAlignment.Center;
            e.Graph.DrawBrick(tb4);
            tb4.BorderColor = Color.White;
        }
        private void Excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                advBandedGridViewData.FocusedRowHandle = -1;
                DataTable tb = gridControlData.DataSource as DataTable;
                if (tb != null)
                {
                    if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string xmlData = "";
                        foreach (DataRow r in tb.Rows)
                        {
                            if (r.RowState == DataRowState.Modified)
                            {
                                xmlData += "<Input M=\"" + r["MaGiangVien"]
                                        + "\" T=\"" + r["TamThuThue"]
                                        + "\" G=\"" + r["GhiChu"]
                                        + "\" S=\"" + r["DinhMucNckh"]
                                        + "\" />";
                            }
                        }

                        xmlData = "<Root>" + xmlData + "</Root>";

                        int kq = -1;
                        DataServices.ThueThanhToanBoSung.Luu(xmlData, cboNamHoc.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                btnLocDuLieu.PerformClick();
            }
            catch
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void advBandedGridViewData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                DataRowView rv = advBandedGridViewData.GetRow(e.RowHandle) as DataRowView;
                if (e.Column.FieldName == "DinhMucNCKH")
                {
                    float _tongCong = float.Parse(rv["TongCong"].ToString());
                    float _donGia = float.Parse(rv["DonGia"].ToString());
                    float _nckh = float.Parse(rv["DinhMucNCKH"].ToString());
                    float _thanhTien = 0, _thue = 0, _thucNhan = 0, _namHocSau = 0;
                    if (_tongCong > _nckh)
                    {
                        _thanhTien = _donGia * _nckh;
                        _namHocSau = _tongCong - _nckh;
                    }
                    else
                    {
                        _thanhTien = _donGia * _tongCong;
                    }

                    _thue = _thanhTien / 10;
                    _thucNhan = _thanhTien - _thue;

                    advBandedGridViewData.SetRowCellValue(e.RowHandle, "ThanhTien", _thanhTien);
                    advBandedGridViewData.SetRowCellValue(e.RowHandle, "TamThuThue", _thue);
                    advBandedGridViewData.SetRowCellValue(e.RowHandle, "ThucNhan", _thucNhan);
                    advBandedGridViewData.SetRowCellValue(e.RowHandle, "NamHocSau", _namHocSau);
                }

                if (e.Column.FieldName == "TamThuThue")
                {
                    float _thucNhan = float.Parse(rv["ThanhTien"].ToString()) - float.Parse(rv["TamThuThue"].ToString());
                    advBandedGridViewData.SetRowCellValue(e.RowHandle, "ThucNhan", _thucNhan);
                }
                
            }
            catch
            { }
           
        }
        
    }
}
