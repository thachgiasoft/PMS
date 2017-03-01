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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.BLL;

namespace PMS.UI.Modules.Reports.ThongKeThanhTra
{
    public partial class ucThongKeCongViecKhongPhuHopCuaGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        VList<ViewKhoaBoMon> _listKhoaDonVi;
        DateTime _ngayIn;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion

        #region Event Grid
        public ucThongKeCongViecKhongPhuHopCuaGiangVien()
        {
            InitializeComponent();

            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }

            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            if (_maTruong == "IUH")
                btnLamTuoi.Caption = "Cập nhật mới";
        }

        private void ucThongKeCongViecKhongPhuHopCuaGiangVien_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "TenKhoa", "Ngay", "TuTiet", "DenTiet", "SoTietThucTe", "Phong", "MaCanBoGiangDay", "HoTen", "MaLop", "TenMonHoc", "NoiDungViPham", "GiaiTrinh" }
                    , new string[] { "STT", "Khoa", "Ngày", "Từ tiết", "Đến tiết", "Số tiết thực tế", "Phòng", "Mã giảng viên", "Họ tên", "Lớp", "Môn học", "Lý do", "Giải trình" }
                    , new int[] { 40, 120, 70, 55, 55, 60, 80, 80, 150, 90, 120, 120, 120 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "TenKhoa", "Ngay", "TuTiet", "DenTiet", "SoTietThucTe", "Phong", "MaCanBoGiangDay", "HoTen", "MaLop", "TenMonHoc", "NoiDungViPham", "GiaiTrinh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.SummaryField(gridViewThongKe, "Ngay", "{0}", DevExpress.Data.SummaryItemType.Count);
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 40);
            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            dateEditTuNgay.DateTime = DateTime.Now;
            dateEditDenNgay.DateTime = DateTime.Now;

            InitCoSo();

            InitKhoaDonVi();

            InitLoaiThieuSot();
        }

        void InitLoaiThieuSot()
        {
            cboLoaiThieuSot.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiThieuSot.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiThieuSot.Properties.Items.Clear();
            TList<DanhMucViPham> _listThieuSot = DataServices.DanhMucViPham.GetAll();
            List<CheckedListBoxItem> _listItem = new List<CheckedListBoxItem>();
            foreach (DanhMucViPham l in _listThieuSot)
            {
                _listItem.Add(new CheckedListBoxItem(l.MaViPham, string.Format("{0} - {1}", l.MaViPham, l.NoiDungViPham), CheckState.Unchecked, true));
            }
            cboLoaiThieuSot.Properties.Items.AddRange(_listItem.ToArray());
            cboLoaiThieuSot.Properties.SeparatorChar = ';';
            cboLoaiThieuSot.CheckAll();
        }

        void InitCoSo()
        {
            cboCoSo.Properties.SelectAllItemCaption = "Tất cả";
            cboCoSo.Properties.TextEditStyle = TextEditStyles.Standard;
            cboCoSo.Properties.Items.Clear();
            VList<ViewCoSo> _listCoSo = DataServices.ViewCoSo.GetAll();
            List<CheckedListBoxItem> _listItem = new List<CheckedListBoxItem>();
            foreach (ViewCoSo l in _listCoSo)
            {
                _listItem.Add(new CheckedListBoxItem(l.MaCoSo, string.Format("{0} - {1}", l.MaCoSo, l.TenCoSo), CheckState.Unchecked, true));
            }
            cboCoSo.Properties.Items.AddRange(_listItem.ToArray());
            cboCoSo.Properties.SeparatorChar = ';';
            cboCoSo.CheckAll();
        }

        void InitKhoaDonVi()
        {
            if (cboCoSo.EditValue != null)
            {
                cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
                cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
                cboKhoaDonVi.Properties.Items.Clear();
                VList<ViewKhoaBoMon> _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaCoSo(cboCoSo.EditValue.ToString());
                List<CheckedListBoxItem> _listItem = new List<CheckedListBoxItem>();
                foreach (ViewKhoaBoMon l in _listKhoaBoMon)
                {
                    _listItem.Add(new CheckedListBoxItem(l.MaBoMon, string.Format("{0} - {1}", l.MaBoMon, l.TenBoMon), CheckState.Unchecked, true));
                }
                cboKhoaDonVi.Properties.Items.AddRange(_listItem.ToArray());
                cboKhoaDonVi.Properties.SeparatorChar = ';';
                cboKhoaDonVi.CheckAll();
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (dateEditTuNgay.DateTime != null && dateEditDenNgay.DateTime != null && cboKhoaDonVi.EditValue != null && cboLoaiThieuSot.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThanhTraTheoThoiKhoaBieu.ThongKeCongViecKhongPhuHop(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime, cboKhoaDonVi.EditValue.ToString(), cboLoaiThieuSot.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();

                if (frmChon.NgayIn.ToString("dd/MM/yyyy") == "01/01/0001")
                    return;
                _ngayIn = frmChon.NgayIn;

            }

            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
                    {
                        switch (c.SortOrder)
                        {
                            case DevExpress.Data.ColumnSortOrder.Ascending:
                                sort += string.Format("{0} ASC, ", c.FieldName);
                                break;
                            case DevExpress.Data.ColumnSortOrder.Descending:
                                sort += string.Format("{0} DESC, ", c.FieldName);
                                break;
                        }
                    }
                }
                if (sort != "")
                    sort = sort.Substring(0, sort.Length - 2);
            }

            //string filter = gridViewThongKe.ActiveFilterString;
            //if (filter.Contains(".0000m"))
            //    filter = filter.Replace(".0000m", "");
            //if (filter.Contains(".000m"))
            //    filter = filter.Replace(".000m", "");
            //if (filter.Contains(".00m"))
            //    filter = filter.Replace(".00m", "");
            //if (filter.Contains(".0m"))
            //    filter = filter.Replace(".0m", "");
            //if (filter.Contains(".m"))
            //    filter = filter.Replace(".m", "");

            //string filter = gridViewHopDongMoiGiangVien.ActiveFilterString;
            //vListBaoCao = dv.ToTable();
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeCongViecKhongPhuHop(PMS.Common.Globals._cauhinh.TenTruong, dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), _ngayIn, UserInfo.FullName, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlThongKe.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cboCoSo_EditValueChanged(object sender, EventArgs e)
        {
            InitKhoaDonVi();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
                gridViewThongKe.ActiveFilterString = "";
            if (radioGroup1.SelectedIndex == 1)
                gridViewThongKe.ActiveFilterString = "isnull(GiaiTrinh, '') <> ''";
            if (radioGroup1.SelectedIndex == 2)
                gridViewThongKe.ActiveFilterString = "isnull(GiaiTrinh, '') = ''";
        }
    }
}
