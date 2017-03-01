using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.BLL;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.DataForm;
using PMS.UI.Forms.BaoCao;
using PMS.Services;
using System;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeHopDongTheoThoiGian : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable 
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _matruong;
        private bool user = false;

        #endregion

        #region Event Form
                public ucThongKeHopDongTheoThoiGian()
        {
            InitializeComponent();
            _matruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
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
        #endregion

          private void ucThongKeHopDongTheoThoiGian_Load(object sender, EventArgs e)
                {
                    #region InitGridview
                    AppGridView.InitGridView(gridViewThongKeHD, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
                    AppGridView.ShowField(gridViewThongKeHD,new string[] {"MaQuanLy","Ho","Ten","TenHocHam","TenHocVi","TenBoMon","NgayKyHopDong","NgayKetThucHopDong","GhiChu"},
                            new string[] {"Mã giảng viên","Họ","Tên","Học hàm","Học vị","Khoa - đơn vị","Ngày kỳ hợp đồng","Ngày kết thúc hợp đồng","Ghi chú"},
                            new int[] {90,120,70,100,100,130,90,90,100});
                    AppGridView.ReadOnlyColumn(gridViewThongKeHD);
                    AppGridView.SummaryField(gridViewThongKeHD, "Ho", "Tổng cộng: {0} HĐ.", DevExpress.Data.SummaryItemType.Count);
                
                        
                    #endregion
              InitData();
           
                }
#region InitData
        void InitData()
          {
              dateEditNgay.DateTime = DateTime.Now;
              #region Init Khoa - Đơn vị
              cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
              cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
              cboKhoaDonVi.Properties.Items.Clear();
              VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
              _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

              #region Khoa - Bộ môn
              foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
              {
                  if (groupname == v.MaBoMon)
                  {
                      user=true; break;
                  }
              }
              #endregion
              if (user == true)
              {
                  if (_matruong == "UTE")
                      _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.TenKhoa == groupname) as VList<ViewKhoaBoMon>;
                  else
                      _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
              }
              else
              {
                  _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
              }

              if (_matruong == "CTIM")
              {
                  VList<ViewKhoaBoMon> v = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
                  if (v.Count > 0)
                  { 

                      _vListKhoaBoMon=_vListKhoaBoMon.FindAll(p=>p.MaKhoa==groupname) as VList<ViewKhoaBoMon>;
                  }
                  else
                      _vListKhoaBoMon=DataServices.ViewKhoaBoMon.GetAll();
              }
              
            List<CheckedListBoxItem> _list=new List<CheckedListBoxItem>();
            foreach(ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon,string.Format("{0} - {1}",v.MaBoMon,v.TenBoMon),CheckState.Unchecked,true));

            }
            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar=';';
            cboKhoaDonVi.CheckAll();
                  
              
              #endregion
          }
        #endregion

        private void btn_LamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btn_Excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if(sf.FileName!="")
                {
                    gridControlThongKeHD.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            { }
        }

        private void btn_LocDL_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue.ToString() != "" && dateEditNgay.EditValue.ToString() !="")
            {
                DataTable tb=new DataTable();
                IDataReader reader = DataServices.GiangVien.ThongKeHopDongTheoThoiGian(cboKhoaDonVi.EditValue.ToString(),dateEditNgay.DateTime);
                tb.Load(reader);
                bindingSourceThongKeHDTheoThoiGian.DataSource = tb;
                
            }
            gridViewThongKeHD.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
         

           
        }

        void ToMau(DataTable tb)
        {
            try
            {
                if (tb.Rows.Count > 0)
                {
                    foreach (DataRow v in tb.Rows)
                    {
                        if (v["Note"].ToString()=="2")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThongKeHD, "Note", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Silver, v["Note"]);
                        }
                        if (v["Note"].ToString() == "0")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThongKeHD, "Note", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Yellow, v["Note"]);
                        }
                    }
                }
            }
            catch
            { }

        }

        private void btn_In_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKeHD.FocusedRowHandle = -1;
            bindingSourceThongKeHDTheoThoiGian.EndEdit();
            AppType objLoaiBaoCao = bindingSourceThongKeHDTheoThoiGian.Current as AppType;
            DataTable data = bindingSourceThongKeHDTheoThoiGian.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao=data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKeHD, bindingSourceThongKeHDTheoThoiGian);

            string khoa = "";
            if (_matruong == "UTE")
            {
                khoa = groupname;
            }
            else
            {
                VList<ViewKhoa> _vkhoa = DataServices.ViewKhoa.GetAll();
                try
                {
                    khoa = _vkhoa.Find(p => p.MaKhoa == groupname).TenKhoa;
                }
                catch
                {
                    khoa = "";
                }
            }

            if (groupname == "Administrator" || groupname == "User")
                khoa = "";

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeHDTheoThoiGian(PMS.Common.Globals._cauhinh.TenTruong, khoa, PMS.Common.Globals._cauhinh.NguoiLapbieu, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void dateEditNgay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
