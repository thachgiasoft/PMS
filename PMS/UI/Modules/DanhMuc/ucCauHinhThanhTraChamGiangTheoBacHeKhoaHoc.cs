using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucCauHinhThanhTraChamGiangTheoBacHeKhoaHoc : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        public ucCauHinhThanhTraChamGiangTheoBacHeKhoaHoc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;

            if (_maTruong == "IUH")
                btnLamTuoi.Caption = "Cập nhật mới";
        }

        private void ucCauHinhThanhTraChamGiangTheoBacHeKhoaHoc_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThanhTra, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThanhTra, new string[] { "TenBacDaoTao", "TenLoaiHinhDaoTao", "MaKhoaHoc", "TenKhoaHoc", "Chon", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Bậc đào tạo", "Loại hình đào tạo", "Mã khoá học", "Tên khoá học", "Chọn", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 150, 150, 150, 150, 100, 99, 99 });
            AppGridView.AlignHeader(gridViewThanhTra, new string[] { "TenBacDaoTao", "TenLoaiHinhDaoTao", "MaKhoaHoc", "TenKhoaHoc", "Chon", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThanhTra, new string[] { "TenBacDaoTao", "TenLoaiHinhDaoTao", "MaKhoaHoc", "TenKhoaHoc" });
            AppGridView.HideField(gridViewThanhTra, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.SummaryField(gridViewThanhTra, "TenBacDaoTao", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThanhTra, "Chon", "{0}", DevExpress.Data.SummaryItemType.Sum);
            gridViewThanhTra.GroupPanelText = "Gom nhóm bằng cách kéo tên cột thả vào đây";
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

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            InitData();
        }
        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                VList<ViewThanhTraChamGiangTheoKhoaHoc> _listThanhTra = DataServices.ViewThanhTraChamGiangTheoKhoaHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bool _LHPChuaGanKhoaHoc = false;
                foreach (ViewThanhTraChamGiangTheoKhoaHoc v in _listThanhTra)
                {
                    if (v.MaKhoaHoc == "-1")
                    {
                        _LHPChuaGanKhoaHoc = true;
                        break;
                    }
                }
                if (!_LHPChuaGanKhoaHoc)
                    _listThanhTra.Add(new ViewThanhTraChamGiangTheoKhoaHoc() { MaKhoaHoc = "-1", TenKhoaHoc = "Lớp học phần chưa gắn khoá học", Chon = false });

                bindingSourceThanhTra.DataSource = _listThanhTra;
                bindingSourceThanhTra.Sort = "MaBacDaoTao";
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThanhTra.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VList<ViewThanhTraChamGiangTheoKhoaHoc> list = bindingSourceThanhTra.DataSource as VList<ViewThanhTraChamGiangTheoKhoaHoc>;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (ViewThanhTraChamGiangTheoKhoaHoc kl in list)
                        {
                            //Kiểm tra điều kiện nếu có sửa mới cho insert hay update xuống
                            if (kl.Chon == true)
                            {
                                xmlData += String.Format("<Input M=\"{0}\" C=\"{1}\" D=\"{2}\" U=\"{3}\" />", kl.MaKhoaHoc, (bool)PMS.Common.Globals.IsNull(kl.Chon, "bool"), kl.NgayCapNhat, kl.NguoiCapNhat);
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceThanhTra.EndEdit();
                        int kq = 0;
                        DataServices.ThanhTraChamGiangTheoKhoaHoc.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlThanhTra.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                VList<ViewThanhTraChamGiangTheoKhoaHoc> _listThanhTra = DataServices.ViewThanhTraChamGiangTheoKhoaHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bool _LHPChuaGanKhoaHoc = false;
                foreach (ViewThanhTraChamGiangTheoKhoaHoc v in _listThanhTra)
                {
                    if (v.MaKhoaHoc == "-1")
                    {
                        _LHPChuaGanKhoaHoc = true;
                        break;
                    }
                }
                if (!_LHPChuaGanKhoaHoc)
                    _listThanhTra.Add(new ViewThanhTraChamGiangTheoKhoaHoc() { MaKhoaHoc = "-1", TenKhoaHoc = "Lớp học phần chưa gắn khoá học", Chon = false });

                bindingSourceThanhTra.DataSource = _listThanhTra;
                bindingSourceThanhTra.Sort = "MaBacDaoTao";
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                VList<ViewThanhTraChamGiangTheoKhoaHoc> _listThanhTra = DataServices.ViewThanhTraChamGiangTheoKhoaHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bool _LHPChuaGanKhoaHoc = false;
                foreach (ViewThanhTraChamGiangTheoKhoaHoc v in _listThanhTra)
                {
                    if (v.MaKhoaHoc == "-1")
                    {
                        _LHPChuaGanKhoaHoc = true;
                        break;
                    }
                }
                if (!_LHPChuaGanKhoaHoc)
                    _listThanhTra.Add(new ViewThanhTraChamGiangTheoKhoaHoc() { MaKhoaHoc = "-1", TenKhoaHoc = "Lớp học phần chưa gắn khoá học", Chon = false });

                bindingSourceThanhTra.DataSource = _listThanhTra;
                bindingSourceThanhTra.Sort = "MaBacDaoTao";
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewThanhTra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "Chon")
            {
                gridViewThanhTra.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewThanhTra.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepThanhTraChamGiangTheoBacHeKhoaHoc"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepThanhTraChamGiangTheoBacHeKhoaHoc"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewThanhTra.DataRowCount; i++)
                {
                    gridViewThanhTra.SetRowCellValue(i, "Chon", "True");
                }
            }
            if (checkEditChonTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewThanhTra.DataRowCount; i++)
                {
                    gridViewThanhTra.SetRowCellValue(i, "Chon", "False");
                }
            }
        }

    }
}
