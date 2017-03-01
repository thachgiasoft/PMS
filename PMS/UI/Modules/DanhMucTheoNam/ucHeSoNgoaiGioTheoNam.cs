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
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucHeSoNgoaiGioTheoNam : DevExpress.XtraEditors.XtraUserControl
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

        public ucHeSoNgoaiGioTheoNam()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoNgoaiGioTheoNam_Load(object sender, EventArgs e)
        {
            #region Init GridView 
            switch (_maTruong)
            { 
                case "VHU":
                    InitGridVHU();
                    break;
                case "HBU":
                    InitGridVHU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            InitData();
        }

        #region InitGridView
        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewHeSoNgoaiGio, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoNgoaiGio, new string[] { "Thu", "TietBatDau", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "Thứ", "Tiết bắt đầu", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 180, 120, 120, 300, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoNgoaiGio, NewItemRowPosition.Top);
            AppGridView.HideField(gridViewHeSoNgoaiGio, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.AlignHeader(gridViewHeSoNgoaiGio, new string[] { "Thu", "TietBatDau", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoNgoaiGio, "Thu", repositoryItemCheckedComboBoxEditThu);
            AppGridView.RegisterControlField(gridViewHeSoNgoaiGio, "TietBatDau", repositoryItemGridLookUpEditTietBatDau);
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

            InitThu();

            InitTietBatDau();

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceHeSoNgoaiGio.DataSource = DataServices.HeSoNgoaiGio.GetByNamhocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
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

        void InitThu()
        {
            #region Init GioGiang
            repositoryItemCheckedComboBoxEditThu.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditThu.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditThu.Items.Clear();

            VList<ViewNgayTrongTuan> _vDM = new VList<ViewNgayTrongTuan>();
            _vDM = DataServices.ViewNgayTrongTuan.GetAll();

            List<CheckedListBoxItem> _listDM = new List<CheckedListBoxItem>();
            foreach (ViewNgayTrongTuan v in _vDM)
            {
                _listDM.Add(new CheckedListBoxItem(v.DayId, v.DayName, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditThu.Items.AddRange(_listDM.ToArray());
            repositoryItemCheckedComboBoxEditThu.SeparatorChar = ';';
            #endregion
        }

        void InitTietBatDau()
        {
            #region Init GioGiang
            //repositoryItemCheckedComboBoxEditTietBatDau.SelectAllItemCaption = "Tất cả";
            //repositoryItemCheckedComboBoxEditTietBatDau.TextEditStyle = TextEditStyles.Standard;
            //repositoryItemCheckedComboBoxEditTietBatDau.Items.Clear();

            //VList<ViewTietGiangDay> _vDM = new VList<ViewTietGiangDay>();
            //_vDM = DataServices.ViewTietGiangDay.GetAll();

            //List<CheckedListBoxItem> _listDM = new List<CheckedListBoxItem>();
            //foreach (ViewTietGiangDay v in _vDM)
            //{
            //    _listDM.Add(new CheckedListBoxItem(v.PeriodId, v.PeriodName, CheckState.Unchecked, true));
            //}
            //repositoryItemCheckedComboBoxEditTietBatDau.Items.AddRange(_listDM.ToArray());
            //repositoryItemCheckedComboBoxEditTietBatDau.SeparatorChar = ';';
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditTietBatDau, 200, 650);
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditTietBatDau, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditTietBatDau, new string[] { "PeriodId", "PeriodName" }, new string[] { "Mã tiết", "Tên tiết" }, new int[] { 100, 100 });
            repositoryItemGridLookUpEditTietBatDau.ValueMember = "PeriodId";
            repositoryItemGridLookUpEditTietBatDau.DisplayMember = "PeriodName";
            repositoryItemGridLookUpEditTietBatDau.NullText = string.Empty;

            bindingSourceTietBatDau.DataSource = DataServices.ViewTietGiangDay.GetAll();
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
                            foreach (HeSoNgoaiGio h in list)
                            {
                                h.NamHoc = cboNamHoc.EditValue.ToString();
                                h.HocKy = cboHocKy.EditValue.ToString();
                            }
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
                LoadDataSource();
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

                    //VList<ViewLoaiHinhDaoTao> _vLoaiHinhDaoTao = new VList<ViewLoaiHinhDaoTao>();
                    //_vLoaiHinhDaoTao = DataServices.ViewLoaiHinhDaoTao.GetAll();

                    DataTable dt = new DataTable();
                    dt.Load(DataServices.ViewLoaiHinhDaoTao.GetByBacDaoTao(hs.BacDaoTao));

                    List<CheckedListBoxItem> _listLH = new List<CheckedListBoxItem>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        _listLH.Add(new CheckedListBoxItem((String)dt.Rows[i].ItemArray[0]  //Mã loại hình
                            , (String)dt.Rows[i].ItemArray[1]                               //Tên loại hình
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

            if (col.FieldName == "BacDaoTao" || col.FieldName == "LoaHinhDaoTao" || col.FieldName == "GioGiang" || col.FieldName == "HeSo" || col.FieldName == "GhiChu")
            {
                gridViewHeSoNgoaiGio.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewHeSoNgoaiGio.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoNgoaiGio"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoNgoaiGio"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
    }
}
