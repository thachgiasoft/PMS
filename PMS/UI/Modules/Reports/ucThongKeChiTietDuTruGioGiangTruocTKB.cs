using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeChiTietDuTruGioGiangTruocTKB : UserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        #endregion


        public ucThongKeChiTietDuTruGioGiangTruocTKB()
        {
            InitializeComponent();
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll();
            if (listCauHinh != null)
            {
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }
        }

        private void ucThongKeChiTietDuTruGioGiangTruocTKB_Load(object sender, EventArgs e)
        {
            bandedGridViewThongKe.OptionsView.ShowAutoFilterRow = true;
            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc,new string[] {"NamHoc"},new string[] {"Năm học"});
            cboNamHoc.Properties.ValueMember="NamHoc";
            cboNamHoc.Properties.DisplayMember="NamHoc";
            cboNamHoc.Properties.NullText=string.Empty;
            cboNamHoc.EditValue=_cauHinhChung.Find(p=>p.TenCauHinh=="Năm học hiện tại").GiaTri;
            #endregion
            
            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy,true,TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy,new string[] {"MaHocKy","TenHocKy"},new string[] {"Mã học kỳ","Tên học kỳ"});
            cboHocKy.Properties.ValueMember="MaHocKy";
            cboHocKy.Properties.DisplayMember="TenHocKy";
            cboHocKy.Properties.NullText=string.Empty;
            cboHocKy.EditValue=_cauHinhChung.Find(p=>p.TenCauHinh=="Học kỳ hiện tại").GiaTri;
            #endregion  
            
#region Khoa - đơn vị
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi,true,TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi,new string[] {"MaBoMon","TenBoMon"},new string[] {"Mã bộ môn","Tên bộ môn"});
            cboKhoaDonVi.Properties.ValueMember="MaBoMon";
            cboKhoaDonVi.Properties.DisplayMember="TenBoMon";
            cboKhoaDonVi.Properties.NullText=string.Empty;
#endregion

#region Loại giảng viên
            cboLoaiGV.Properties.SelectAllItemCaption="Tất cả";
            cboLoaiGV.Properties.TextEditStyle=TextEditStyles.Standard;
            cboLoaiGV.Properties.Items.Clear();

            TList<LoaiGiangVien> _tLoaiGiangVien=DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> list=new List<CheckedListBoxItem>();

            foreach(LoaiGiangVien l in _tLoaiGiangVien)
                list.Add(new CheckedListBoxItem(l.MaLoaiGiangVien,string.Format("{0} - {1}",l.MaQuanLy,l.TenLoaiGiangVien),CheckState.Unchecked,true));
            cboLoaiGV.Properties.Items.AddRange(list.ToArray());
            cboLoaiGV.Properties.SeparatorChar=';';
            cboLoaiGV.CheckAll();

#endregion
            InitData();

         
        }
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            cboKhoaDonVi.DataBindings.Clear();
            bindingSourceKhoaDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
            
        }

        private void GetData()
        {
            DataTable tbl = new DataTable();
            IDataReader reader = DataServices.DuTruGioGiangTruocThoiKhoaBieu.ThongKeChiTiet_Cdgtvt(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboLoaiGV.EditValue.ToString());
            tbl.Load(reader);

            bindingSourceThongKe.DataSource = tbl;
     
            FitColumnBand(tbl);

            PMS.Common.Globals.GridRowColor(bandedGridViewThongKe, new Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold), Color.Aquamarine, "TenMonHoc", "TỔNG CỘNG");
        }

        


        private void FitColumnBand(DataTable dt)
        {
            bandedGridViewThongKe.OptionsView.ColumnAutoWidth = false;
            bandedGridViewThongKe.BestFitColumns();
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiGV.EditValue != null)
                GetData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter="(*.xls)|*.xls"})
                {
                    if(sf.ShowDialog()==DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControl1.ExportToXls(sf.FileName);
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
            bandedGridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(bandedGridViewThongKe, bindingSourceThongKe);

            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeChiTietDuTruGioGiangTruocTKB(PMS.Common.Globals._cauhinh.TenTruong, cboKhoaDonVi.Text, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                       , PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.PhongDaoTao, "", PMS.Common.Globals._cauhinh.NguoiLapbieu
                       , _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
        
    }
}
