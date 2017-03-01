using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucLopChatLuongCao : DevExpress.XtraEditors.XtraUserControl
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

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        public ucLopChatLuongCao()
        {
            InitializeComponent();
        }

        private void ucLopChatLuongCao_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewLopCLC, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewLopCLC, new string[] { "MaLop", "TenLop", "TenKhoaHoc", "TenKhoa", "Chon" }
                    , new string[] { "Mã lớp", "Tên lớp", "Khoá học", "Khoa", "Lớp CLC" }
                    , new int[] { 100, 100, 170, 170, 50 });
            AppGridView.ReadOnlyColumn(gridViewLopCLC, new string[] { "MaLop", "TenLop", "TenKhoaHoc", "TenKhoa" });
            AppGridView.AlignHeader(gridViewLopCLC, new string[] { "MaLop", "TenLop", "TenKhoaHoc", "TenKhoa", "Chon" }, DevExpress.Utils.HorzAlignment.Center);

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, false, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            InitData();

        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceLopCLC.DataSource = DataServices.ViewLopChatLuongCao.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceLopCLC.DataSource = DataServices.ViewLopChatLuongCao.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLopCLC.FocusedRowHandle = -1;
            VList<ViewLopChatLuongCao> _list = bindingSourceLopCLC.DataSource as VList<ViewLopChatLuongCao>;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    string xmlData = "";
                    foreach (ViewLopChatLuongCao v in _list)
                    {
                        if ((bool)v.Chon)
                        {
                            xmlData += "<Input L=\"" + v.MaLop + "\" />";
                        }
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";

                    int kq = 0;
                    DataServices.LopChatLuongCao.Luu(xmlData, cboNamHoc.EditValue.ToString(), ref kq);
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

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlLopCLC.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void gridViewLopCLC_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "Chon")
            {
                gridViewLopCLC.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewLopCLC.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
    }
}
