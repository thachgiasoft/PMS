using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDanhMucViPham : DevExpress.XtraEditors.XtraUserControl
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
        string _maTruong;
        #endregion
        public ucDanhMucViPham()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            if (_maTruong == "IUH")
                btnLamTuoi.Caption = "Cập nhật mới";
        }

        private void ucDanhMucViPham_Load(object sender, EventArgs e)
        {
            #region Init GridView
            switch (_maTruong)
            { 
                case "IUH":
                    InitGridIUH();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            InitData();
        }
        #region InitData
        void InitData()
        {
            bindingSourceViPham.DataSource = DataServices.DanhMucViPham.GetAll();
        }
        #endregion

        #region InitGridView
        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewViPham, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewViPham, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewViPham, new string[] { "MaViPham", "NoiDungViPham" }, new string[] { "Mã vi phạm", "Nội dung vi phạm" }, new int[] { 80, 250 });
            AppGridView.AlignHeader(gridViewViPham, new string[] { "MaViPham", "NoiDungViPham" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewViPham, "MaViPham", "{0}", DevExpress.Data.SummaryItemType.Count);
        }

        void InitRemaining()//UEL
        {
            AppGridView.InitGridView(gridViewViPham, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewViPham, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewViPham, new string[] { "MaViPham", "NoiDungViPham", "CoXepLoai" }, new string[] { "Mã vi phạm", "Nội dung vi phạm", "Có xếp loại" }, new int[] { 80, 250, 80 });
            AppGridView.AlignHeader(gridViewViPham, new string[] { "MaViPham", "NoiDungViPham", "CoXepLoai" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewViPham, "MaViPham", "{0}", DevExpress.Data.SummaryItemType.Count);
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
            AppGridView.DeleteSelectedRows(gridViewViPham);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewViPham.FocusedRowHandle = -1;
            TList<DanhMucViPham> list = bindingSourceViPham.DataSource as TList<DanhMucViPham>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceViPham.EndEdit();
                            DataServices.DanhMucViPham.Save(list);
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
            using (SaveFileDialog file = new SaveFileDialog())
            {
                file.Filter = "(*.xls)|*.xls";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlViPham.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gridViewViPham_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewViPham, e);
        }
    }
}
