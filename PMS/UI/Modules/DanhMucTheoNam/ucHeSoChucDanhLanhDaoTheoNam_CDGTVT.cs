using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraEditors;
using PMS.Core;
using PMS.Entities.Validation;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Services;
using PMS.UI.Forms.NghiepVu;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucHeSoChucDanhLanhDaoTheoNam_CDGTVT : DevExpress.XtraEditors.XtraUserControl
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

                barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem1.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public ucHeSoChucDanhLanhDaoTheoNam_CDGTVT()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucHeSoChucDanhLanhDaoTheoNam_CDGTVT_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            switch (_maTruong)
            {
                case "VHU":
                    InitGridVHU();
                    break;
                case "HBU":
                    InitGridDLU();
                    break;
                case "DLU":
                    InitGridDLU();
                    break;
                default:  //CDGTVT
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

            #region ChucVu
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditChucVu, 400, 600);
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditChucVu, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditChucVu, new string[] { "MaQuanLy", "TenChucVu" }, new string[] { "Mã chức vụ", "Tên chức vụ" }, new int[] { 100, 300 });
            repositoryItemGridLookUpEditChucVu.ValueMember = "MaChucVu";
            repositoryItemGridLookUpEditChucVu.DisplayMember = "TenChucVu";
            repositoryItemGridLookUpEditChucVu.NullText = string.Empty;
            #endregion


            #region RepositoryItemGridLookUpEdit QuyMo
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditQuyMo, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditQuyMo, new string[] { "MaQuyMo", "TenQuyMo" }, new string[] { "Mã quy mô", "Tên quy mô" });
            repositoryItemGridLookUpEditQuyMo.ValueMember = "Id";
            repositoryItemGridLookUpEditQuyMo.DisplayMember = "TenQuyMo";
            repositoryItemGridLookUpEditQuyMo.NullText = string.Empty;
            #endregion


            InitData();
        }

        void InitGridVHU()
        {
            #region Init gridview
            AppGridView.InitGridView(gridViewHeSoChucDanhLanhDao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoChucDanhLanhDao, new string[] { "MaChucVu", "PhanTramGiamTru", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Chức vụ", "Định mức tối thiểu (%)", "NgayCapNhat", "NguoiCapNhat" },
                        new int[] { 300, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewHeSoChucDanhLanhDao, new string[] { "MaChucVu", "PhanTramGiamTru", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewHeSoChucDanhLanhDao, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhLanhDao, "PhanTramGiamTru", repositoryItemSpinEditDinhMucToiThieu);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhLanhDao, "MaChucVu", repositoryItemGridLookUpEditChucVu);
            AppGridView.HideField(gridViewHeSoChucDanhLanhDao, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion
        }

        void InitGridDLU()
        {
            #region Init gridview
            AppGridView.InitGridView(gridViewHeSoChucDanhLanhDao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoChucDanhLanhDao, new string[] { "MaChucVu", "IdQuyMo", "PhanTramGiamTru", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Chức vụ", "Quy mô", "Định mức tối thiểu (%)", "NgayCapNhat", "NguoiCapNhat" },
                        new int[] { 300, 250, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewHeSoChucDanhLanhDao, new string[] { "MaChucVu", "IdQuyMo", "PhanTramGiamTru", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewHeSoChucDanhLanhDao, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhLanhDao, "PhanTramGiamTru", repositoryItemSpinEditDinhMucToiThieu);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhLanhDao, "MaChucVu", repositoryItemGridLookUpEditChucVu);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhLanhDao, "IdQuyMo", repositoryItemGridLookUpEditQuyMo);
            AppGridView.HideField(gridViewHeSoChucDanhLanhDao, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion
        }

        void InitRemaining()
        {
            #region Init gridview
            AppGridView.InitGridView(gridViewHeSoChucDanhLanhDao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoChucDanhLanhDao, new string[] { "MaChucVu", "PhanTramGiamTru", "NhomGiangVien", "SoTietNghiaVu", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Chức vụ", "Định mức tối thiểu (%)", "Nhóm giảng viên", "Giờ chuẩn/năm", "NgayCapNhat", "NguoiCapNhat" },
                        new int[] { 300, 150, 150, 120, 99, 99 });
            AppGridView.AlignHeader(gridViewHeSoChucDanhLanhDao, new string[] { "MaChucVu", "PhanTramGiamTru", "NhomGiangVien", "SoTietNghiaVu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewHeSoChucDanhLanhDao, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhLanhDao, "PhanTramGiamTru", repositoryItemSpinEditDinhMucToiThieu);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhLanhDao, "MaChucVu", repositoryItemGridLookUpEditChucVu);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhLanhDao, "NhomGiangVien", repositoryItemGridLookUpEditPhanLoai);
            AppGridView.HideField(gridViewHeSoChucDanhLanhDao, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            InitPhanLoai();
            #endregion
        }

    
        #region InitData

        void InitPhanLoai()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("PhanLoai"));
            tbl.Columns["PhanLoai"].Caption = "Phân loại";
            tbl.Columns.Add(new DataColumn("TenPhanLoai"));
            tbl.Columns["TenPhanLoai"].Caption = "Tên phân loại";

            DataRow r3 = tbl.NewRow();
            r3["PhanLoai"] = 3;
            r3["TenPhanLoai"] = "GV giảng dạy môn GDTC";
            DataRow r4 = tbl.NewRow();
            r4["PhanLoai"] = 2;
            r4["TenPhanLoai"] = "GV giảng dạy môn chung";

            tbl.Rows.Add(r3);
            tbl.Rows.Add(r4);

            bindingSourcePhanLoai.DataSource = tbl;

            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditPhanLoai, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditPhanLoai, 300, 400);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditPhanLoai, new string[] { "PhanLoai", "TenPhanLoai" }, new string[] { "Mã phân loại", "Phân loại" }, new int[] { 90, 210 });
            repositoryItemGridLookUpEditPhanLoai.DisplayMember = "TenPhanLoai";
            repositoryItemGridLookUpEditPhanLoai.ValueMember = "PhanLoai";
            repositoryItemGridLookUpEditPhanLoai.NullText = "";
        }

        private void InitData()
        {
            bindingSourceChucVu.DataSource = DataServices.ChucVu.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceDanhMucQuyMo.DataSource = DataServices.DanhMucQuyMo.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHeSoChucDanhLanhDao.DataSource = DataServices.DinhMucGioChuanToiThieuTheoChucVu.GetByNamHoc(cboNamHoc.EditValue.ToString());
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
            AppGridView.DeleteSelectedRows(gridViewHeSoChucDanhLanhDao);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoChucDanhLanhDao.FocusedRowHandle = -1;
            TList<DinhMucGioChuanToiThieuTheoChucVu> list = bindingSourceHeSoChucDanhLanhDao.DataSource as TList<DinhMucGioChuanToiThieuTheoChucVu>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (DinhMucGioChuanToiThieuTheoChucVu hs in list)
                            {
                                hs.NamHoc = cboNamHoc.EditValue.ToString();
                            }
                            bindingSourceHeSoChucDanhLanhDao.EndEdit();
                            DataServices.DinhMucGioChuanToiThieuTheoChucVu.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    InitData();
                }
            }
        }

        private void gridViewHeSoChucDanhLanhDao_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoChucDanhLanhDao, e);
        }

        private void gridViewHeSoChucDanhLanhDao_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoChucDanhLanhDao, e);
        }

        private void gridViewHeSoChucDanhLanhDao_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlHeSoChucDanhLanhDao.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHeSoChucDanhLanhDao.DataSource = DataServices.DinhMucGioChuanToiThieuTheoChucVu.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoChucDanhLanhDao"))
            {
                frm.ShowDialog();
            }
            InitData();
        }

        private void gridViewHeSoChucDanhLanhDao_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaChucVu" || col.FieldName == "PhanTramGiamTru")
            {
                gridViewHeSoChucDanhLanhDao.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewHeSoChucDanhLanhDao.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
    }
}
