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

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeCoVanHocTap : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion
        public ucThongKeCoVanHocTap()
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

        private void ucThongKeCoVanHocTap_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewCoVan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewCoVan, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenTinhTrang", "DanhSachLop", "TongSinhVien", "TenDonVi" }
                    , new string[] { "Mã giảng viên", "Họ và tên", "Chức danh", "Trình độ", "Tình trạng giảng dạy", "Lớp", "Số lượng sinh viên", "Khoa - bộ môn" }
                    , new int[] { 90, 150, 100, 100, 110, 200, 110, 100 });
            AppGridView.AlignHeader(gridViewCoVan, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenTinhTrang", "DanhSachLop", "TongSinhVien", "TenDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewCoVan, "MaQuanLy", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewCoVan);
            //gridViewCoVan.Columns["TenDonVi"].GroupIndex = 0;
            #endregion
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Init Khoa-DonVi
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoa> _vListKhoaBoMon = new VList<ViewKhoa>();
            _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();
           
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion
            InitData();
        }

        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.CoVanHocTap.GetByNamHocMaDonVi(cboNamHoc.EditValue.ToString(), cboDonVi.EditValue.ToString());
                dt.Load(reader);
                bindingSourceCoVan.DataSource = dt;
            }
            gridViewCoVan.ExpandAllGroups();
        }
        #endregion

        #region Event Buttong
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewCoVan.FocusedRowHandle = -1;
            bindingSourceCoVan.EndEdit();
            DataTable data = bindingSourceCoVan.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewCoVan, bindingSourceCoVan);

            int _tongSoCoVan = 0, _tongSoSinhVien = 0;
            foreach (DataRow dr in vListBaoCao.Rows)
            {
                _tongSoCoVan++;
                if (dr["TongSinhVien"].ToString() != "")
                    _tongSoSinhVien += (int)dr["TongSinhVien"];
            }

            string _donVi;
            if (cboDonVi.EditValue.ToString().Split(';').Length == cboDonVi.Properties.Items.Count)
                _donVi = "Toàn trường";
            else
                _donVi = cboDonVi.Text;
            
            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InCoVanHocTapTheoNamHocKhoaDonVi(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), _donVi, _tongSoCoVan, _tongSoSinhVien, PMS.Common.Globals._cauhinh.NguoiLapbieu, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboDonVi.EditValue == null || cboDonVi.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Vui lòng chọn Khoa/TT.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDonVi.Focus();
                return;
            }
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.CoVanHocTap.GetByNamHocMaDonVi(cboNamHoc.EditValue.ToString(), cboDonVi.EditValue.ToString());
                dt.Load(reader);
                bindingSourceCoVan.DataSource = dt;
            }
            gridViewCoVan.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }
        #endregion
        object IsNull(object o, string dataType)
        {
            if (dataType == "string")
                if (o == "" || o == null)
                    o = "";
            if (dataType == "int" || dataType == "decimal")
                if (o == "" || o == null)
                    o = (int)0;

            return o;
        }
    }
}
