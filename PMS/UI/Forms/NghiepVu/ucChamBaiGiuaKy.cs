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
using PMS.BLL;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChamBaiGiuaKy : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLayDuLieu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        private string _groupname = UserInfo.GroupName;
        bool user;
        public frmChamBaiGiuaKy()
        {
            InitializeComponent();
        }

        private void ucChamBaiGiuaKy_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewChamBaiGiuaKy, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewChamBaiGiuaKy, new string[] { "MaGiangVienQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "MaLop", "SoBai", "NgayCapnhat", "NguoiCapNhat" }
                            , new string[] { "Mã giảng viên", "Họ tên", "Mã môn học", "Tên môn học", "Mã lớp học phần", "Mã lớp", "Số bài giữa kỳ", "D", "U" }
                            , new int[] { 90, 170, 90, 200, 110, 110, 100, 99, 99 });
            AppGridView.HideField(gridViewChamBaiGiuaKy, new string[] { "NgayCapnhat", "NguoiCapNhat" });
            AppGridView.AlignHeader(gridViewChamBaiGiuaKy, new string[] { "MaGiangVienQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "MaLop", "SoBai", "NgayCapnhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewChamBaiGiuaKy, new string[] { "MaGiangVienQuanLy", "MaLopHocPhan" });

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            InitKhoaDonVi();

            InitData();
        }

        void InitKhoaDonVi()
        {
            #region Init Khoa-DonVi
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();

            #region Khoa-BoMon
            _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (v.MaKhoa == _groupname)
                {
                    user = true;
                    break;
                }
            }
            if (user == true)
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupname);

            #endregion


            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, string.Format("{0} - {1}", v.MaBoMon, v.TenBoMon), CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion
        }
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThuLaoChamBai.GetDuLieuChamBaiGiuaKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceChamBai.DataSource = tb;
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLayDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                int kiemtra = 0, ketqua = 0;
                DataServices.ThuLaoChamBai.KiemTraLayDuLieuChamBaiGiuaKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), ref kiemtra);
                if (kiemtra != 0)
                {
                    if (XtraMessageBox.Show(string.Format("Dữ liệu chấm bài giữa kỳ năm học {0} - {1} đã có. Nếu tiếp tục lấy dự liệu sẽ ghi dè dữ liệu cũ.\n Bạn có muốn tiếp tục lấy dữ liệu?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataServices.ThuLaoChamBai.LayDuLieuGiuaKyTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), ref ketqua);
                        if (ketqua == 0)
                            XtraMessageBox.Show("Lấy dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    DataServices.ThuLaoChamBai.LayDuLieuGiuaKyTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), ref ketqua);
                    if (ketqua == 0)
                        XtraMessageBox.Show("Lấy dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThuLaoChamBai.GetDuLieuChamBaiGiuaKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceChamBai.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThuLaoChamBai.GetDuLieuChamBaiGiuaKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceChamBai.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThuLaoChamBai.GetDuLieuChamBaiGiuaKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceChamBai.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewChamBaiGiuaKy.FocusedRowHandle = -1;
            Cursor.Current = Cursors.WaitCursor;
            DataTable tb = bindingSourceChamBai.DataSource as DataTable;
            if (tb.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string xmlData = "";
                    foreach (DataRow row in tb.Rows)
                    {
                        xmlData += "<Input M=\"" + row["MaGiangVienQuanLy"].ToString()
                                    + "\" LHP=\"" + row["MaLopHocPhan"].ToString()
                                    + "\" S=\"" + PMS.Common.Globals.IsNull(row["SoBai"].ToString(), "int")
                                    + "\" D=\"" + row["NgayCapNhat"].ToString()
                                    + "\" U=\"" + row["NguoiCapNhat"].ToString()
                                    + "\" />";
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";

                    int kq = 0;
                    DataServices.ThuLaoChamBai.LuuChamBaiGiuaKy(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Lưu thay đổi sĩ số thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlChamBaiGiuaKy.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewChamBaiGiuaKy_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "SoBai")
            {
                gridViewChamBaiGiuaKy.SetRowCellValue(e.RowHandle, "NgayCapnhat", DateTime.Now.ToLongDateString());
                gridViewChamBaiGiuaKy.SetRowCellValue(e.RowHandle, "NguoiCapnhat", UserInfo.UserName);
            }
        }

    }
}