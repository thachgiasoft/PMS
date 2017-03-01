using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoNgoaiGio : DevExpress.XtraEditors.XtraUserControl
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
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public ucHeSoNgoaiGio()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoNgoaiGio_Load(object sender, EventArgs e)
        {
            #region Init GridView 
            AppGridView.InitGridView(gridViewHeSoNgoaiGio, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoNgoaiGio, new string[] { "BacDaoTao", "LoaiHinhDaoTao", "GioGiang", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "Bậc đào tạo", "Loại hình đào tạo", "Thời gian giảng dạy", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 150, 150, 200, 100, 250, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoNgoaiGio, NewItemRowPosition.Top);
            AppGridView.HideField(gridViewHeSoNgoaiGio, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.AlignHeader(gridViewHeSoNgoaiGio, new string[] { "BacDaoTao", "LoaiHinhDaoTao", "GioGiang", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoNgoaiGio, "BacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoNgoaiGio, "LoaiHinhDaoTao", repositoryItemCheckedComboBoxEditLoaiHinhDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoNgoaiGio, "GioGiang", repositoryItemCheckedComboBoxEditGioGiang);
            #endregion

            InitData();
        }

        #region InitGridView
        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewHeSoNgoaiGio, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoNgoaiGio, new string[] { "Thu", "TietBatDau", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "Thứ", "Tiết bắt đầu", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 120, 120, 120, 250, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoNgoaiGio, NewItemRowPosition.Top);
            AppGridView.HideField(gridViewHeSoNgoaiGio, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.AlignHeader(gridViewHeSoNgoaiGio, new string[] { "Thu", "TietBatDau", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewHeSoNgoaiGio, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoNgoaiGio, new string[] { "BacDaoTao", "LoaiHinhDaoTao", "GioGiang", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "Bậc đào tạo", "Loại hình đào tạo", "Thời gian giảng dạy", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 150, 150, 200, 100, 250, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoNgoaiGio, NewItemRowPosition.Top);
            AppGridView.HideField(gridViewHeSoNgoaiGio, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.AlignHeader(gridViewHeSoNgoaiGio, new string[] { "BacDaoTao", "LoaiHinhDaoTao", "GioGiang", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoNgoaiGio, "BacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoNgoaiGio, "LoaiHinhDaoTao", repositoryItemCheckedComboBoxEditLoaiHinhDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoNgoaiGio, "GioGiang", repositoryItemCheckedComboBoxEditGioGiang);
        }
        #endregion

        #region InitData
        void InitData()
        {
            InitBacDaoTao();

            InitLoaiHinhDaoTao();

            InitGioGiang();

            bindingSourceHeSoNgoaiGio.DataSource = DataServices.HeSoNgoaiGio.GetAll();
        }

        void InitBacDaoTao()
        {
            #region Init BacDaoTao
            repositoryItemCheckedComboBoxEditBacDaoTao.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditBacDaoTao.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.Clear();

            VList<ViewBacDaoTao> _vBacDaoTao = new VList<ViewBacDaoTao>();
            _vBacDaoTao = DataServices.ViewBacDaoTao.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _vBacDaoTao)
            {
                _list.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.AddRange(_list.ToArray());
            repositoryItemCheckedComboBoxEditBacDaoTao.SeparatorChar = ';';
            #endregion
        }

        void InitLoaiHinhDaoTao()
        {
            #region Init LoaiHinhDaoTao
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.Items.Clear();

            VList<ViewLoaiHinhDaoTao> _vLoaiHinhDaoTao = new VList<ViewLoaiHinhDaoTao>();
            _vLoaiHinhDaoTao = DataServices.ViewLoaiHinhDaoTao.GetAll();

            List<CheckedListBoxItem> _listLH = new List<CheckedListBoxItem>();
            foreach (ViewLoaiHinhDaoTao v in _vLoaiHinhDaoTao)
            {
                _listLH.Add(new CheckedListBoxItem(v.MaLoaiHinh, v.TenLoaiHinh, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.Items.AddRange(_listLH.ToArray());
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.SeparatorChar = ';';
            #endregion
        }

        void InitGioGiang()
        {
            #region Init GioGiang
            repositoryItemCheckedComboBoxEditGioGiang.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditGioGiang.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditGioGiang.Items.Clear();

            TList<DanhMucGioGiang> _vDM = new TList<DanhMucGioGiang>();
            _vDM = DataServices.DanhMucGioGiang.GetAll();

            List<CheckedListBoxItem> _listDM = new List<CheckedListBoxItem>();
            foreach (DanhMucGioGiang v in _vDM)
            {
                _listDM.Add(new CheckedListBoxItem(v.Id, v.TenGioGiang, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditGioGiang.Items.AddRange(_listDM.ToArray());
            repositoryItemCheckedComboBoxEditGioGiang.SeparatorChar = ';';
            #endregion
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoNgoaiGio);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoNgoaiGio.FocusedRowHandle = -1;
            TList<HeSoNgoaiGio> list = bindingSourceHeSoNgoaiGio.DataSource as TList<HeSoNgoaiGio>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoNgoaiGio.EndEdit();
                            DataServices.HeSoNgoaiGio.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlHeSoNgoaiGio.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void gridViewHeSoNgoaiGio_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoNgoaiGio, e);
        }

        private void gridViewHeSoNgoaiGio_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "BacDaoTao")
            {
                HeSoNgoaiGio hs = gridViewHeSoNgoaiGio.GetRow(e.RowHandle) as HeSoNgoaiGio;
                if (hs.BacDaoTao != null && hs.BacDaoTao != "")
                {
                    #region Init LoaiHinhDaoTao
                    repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.SelectAllItemCaption = "Tất cả";
                    repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.TextEditStyle = TextEditStyles.Standard;
                    repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.Items.Clear();

                    //DataTable _vLoaiHinhDaoTao = new DataTable();
                    //IDataReader reader = DataServices.ViewLoaiHinhDaoTao.GetByBacDaoTao(hs.BacDaoTao);
                    //_vLoaiHinhDaoTao.Load(reader);

                    DataTable dt = new DataTable();
                    dt.Load(DataServices.ViewLoaiHinhDaoTao.GetByBacDaoTao(hs.BacDaoTao));

                    List<CheckedListBoxItem> _listLH = new List<CheckedListBoxItem>();

                    //foreach (DataRow v in _vLoaiHinhDaoTao.Rows)
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //_listLH.Add(new CheckedListBoxItem(v["MaLoaiHinh"], v["TenLoaiHinh"].ToString(), CheckState.Unchecked, true));
                        _listLH.Add(new CheckedListBoxItem((String)dt.Rows[i].ItemArray[0]
                            , (String)dt.Rows[i].ItemArray[1]
                            , CheckState.Unchecked, true));
                    }
                    repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.Items.AddRange(_listLH.ToArray());
                    repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.SeparatorChar = ';';
                    #endregion
                }
            }
            if (col.FieldName == "LoaiHinhDaoTao")
            {
                InitLoaiHinhDaoTao();
            }

            if (col.FieldName == "BacDaoTao" || col.FieldName == "LoaiHinhDaoTao" || col.FieldName == "GioGiang" || col.FieldName == "HeSo" || col.FieldName == "GhiChu")
            {
                gridViewHeSoNgoaiGio.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewHeSoNgoaiGio.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
    }
}
