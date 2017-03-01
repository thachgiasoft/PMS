using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;
using PMS.Core;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc.KhongChinhQuy
{
    public partial class ucHeSoDiaDiem : DevExpress.XtraEditors.XtraUserControl
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

        public ucHeSoDiaDiem()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucHeSoDiaDiem_Load(object sender, EventArgs e)
        {
            #region Init gridview
            AppGridView.InitGridView(gridViewHeSoDiaDiem, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoDiaDiem,new string[] {"Stt","MaQuanLy","TenDiaDiem","HeSoDiaDiem","DonGia","TienXeDiaDiem","GhiChu"}
                ,new string[] {"STT","Mã địa diểm","Tên địa điểm","Hệ số địa điểm","Đơn giá","Tiền xe địa điểm","Ghi chú"}
                ,new int[] {80,100,200,100,100,100,100});
            AppGridView.ShowEditor(gridViewHeSoDiaDiem, NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoDiaDiem, new string[] { "Stt", "MaQuanLy", "TenDiaDiem", "HeSoDiaDiem", "DonGia", "TienXeDiaDiem", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewHeSoDiaDiem, "MaQuanLy", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewHeSoDiaDiem, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewHeSoDiaDiem, "TienXeDiaDiem", DevExpress.Utils.FormatType.Custom, "n0");

            #endregion

            #region Init Data
            bindingSourceHeSoDiaDiem.DataSource = DataServices.KcqHeSoDiaDiem.GetAll();
            #endregion
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceHeSoDiaDiem.DataSource = DataServices.KcqHeSoDiaDiem.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridControlHeSoDiaDiem_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoDiaDiem, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            KcqHeSoDiaDiem obj = target as KcqHeSoDiaDiem;
            if (obj != null)
            {
                if (((TList<KcqHeSoDiaDiem>)bindingSourceHeSoDiaDiem.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã địa điểm{0} hiện đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSoDiaDiem_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            KcqHeSoDiaDiem obj = new KcqHeSoDiaDiem();
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoDiaDiem);
        }

        private void gridViewHeSoDiaDiem_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlHeSoDiaDiem.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoDiaDiem.FocusedRowHandle = -1;
            TList<KcqHeSoDiaDiem> list = bindingSourceHeSoDiaDiem.DataSource as TList<KcqHeSoDiaDiem>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoDiaDiem.EndEdit();
                            DataServices.KcqHeSoDiaDiem.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoDiaDiem, barManager1, layoutControl1 });
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

       
    }
}
