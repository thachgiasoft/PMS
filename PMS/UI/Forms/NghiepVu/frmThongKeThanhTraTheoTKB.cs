using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThongKeThanhTraTheoTKB : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public frmThongKeThanhTraTheoTKB()
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

        private void frmThongKeThanhTraTheoTKB_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "TietBatDau", "SoTiet", "TienDo", "SiSo", "SoTietGhiNhan", "NoiDungViPham", "TenHinhThucViPham", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                , new string[] { "Ngày", "Phòng học", "Mã học phần", "Tên học phần", "Loại học phần", "Mã lớp học phần", "Mã lớp", "Mã CBGD", "Họ tên", "Đơn vị", "Thứ", "Tiết bắt đầu", "Số tiết", "Tiến độ", "Sĩ số", "Số tiết ghi nhận", "Nội dung vi phạm", "Hình thức vi phạm đánh giá ABC", "Thời điểm ghi nhận", "Lý do", "Ghi chú", "NgayCapNhat", "NguoiCapNhat" }
                    , new int[] { 70, 80, 80, 150, 90, 110, 90, 70, 140, 150, 50, 70, 60, 80, 60, 100, 170, 200, 110, 150, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "TietBatDau", "SoTiet", "TienDo", "SiSo", "SoTietGhiNhan", "NoiDungViPham", "TenHinhThucViPham", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "Ngay", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.HideField(gridViewThongKe, new string[] { "NgayCapNhat", "NguoiCapNhat", "SiSo" });
            AppGridView.FixedField(gridViewThongKe, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.RegisterControlField(gridViewThongKe, "Ngay", repositoryItemDateEditNgay);
            if(_maTruong != "UEL")
                AppGridView.HideField(gridViewThongKe, new string[] { "TenHinhThucViPham" });
            #endregion
            InitData();
        }
        #region InitData
        void InitData()
        {
            dateEditTuNgay.DateTime = DateTime.Now;
            dateEditDenNgay.DateTime = DateTime.Now;

            InitCoSo();

            InitDayNha();

            //if (dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null && cboDayNha.EditValue != null)
            //{
            //    bindingSourceThongKe.DataSource = DataServices.ViewThanhTraTheoThoiKhoaBieu.ThongKeTheoNgayToaNha(dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), cboDayNha.EditValue.ToString());
            //}
        }

        void InitCoSo()
        {
            #region Init Co So
            cboCoSo.Properties.SelectAllItemCaption = "Tất cả";
            cboCoSo.Properties.TextEditStyle = TextEditStyles.Standard;
            cboCoSo.Properties.Items.Clear();

            VList<ViewCoSo> _vListKhoaBoMon = new VList<ViewCoSo>();
            _vListKhoaBoMon = DataServices.ViewCoSo.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewCoSo v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaCoSo, v.TenCoSo, CheckState.Unchecked, true));
            }
            cboCoSo.Properties.Items.AddRange(_list.ToArray());
            cboCoSo.Properties.SeparatorChar = ';';
            cboCoSo.CheckAll();
            #endregion
        }


        void InitDayNha()
        {
            #region Init Day Nha
            if (cboCoSo.EditValue != null)
            {
                cboDayNha.Properties.SelectAllItemCaption = "Tất cả";
                cboDayNha.Properties.TextEditStyle = TextEditStyles.Standard;
                cboDayNha.Properties.Items.Clear();

                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ViewCoSo.GetDayNhaByCoSo(cboCoSo.EditValue.ToString());
                tb.Load(reader);
                List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
                foreach (DataRow v in tb.Rows)
                {
                    _list.Add(new CheckedListBoxItem(v["MaDayNha"].ToString(), v["TenDayNha"].ToString(), CheckState.Unchecked, true));
                }
                cboDayNha.Properties.Items.AddRange(_list.ToArray());
                cboDayNha.Properties.SeparatorChar = ';';
                cboDayNha.CheckAll();
            }
            #endregion
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
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
                        gridControlThongKe.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            VList<ViewThanhTraTheoThoiKhoaBieu> list = bindingSourceThongKe.DataSource as VList<ViewThanhTraTheoThoiKhoaBieu>;
            if (list == null || list.Count == 0)
                return;
             DataTable data = list.ToDataSet(false).Tables[0];

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

            ////string filter = gridViewThongKe.ActiveFilterString;
            ////if (filter.Contains(".0000m"))
            ////    filter = filter.Replace(".0000m", "");
            ////if (filter.Contains(".000m"))
            ////    filter = filter.Replace(".000m", "");
            ////if (filter.Contains(".00m"))
            ////    filter = filter.Replace(".00m", "");
            ////if (filter.Contains(".0m"))
            ////    filter = filter.Replace(".0m", "");
            ////if (filter.Contains(".m"))
            ////    filter = filter.Replace(".m", "");

            //DataView dv = new DataView(vListBaoCao, filter, sort, DataViewRowState.CurrentRows);
            ////vListBaoCao = dv.ToTable();
            ////if (vListBaoCao == null)
            //    return;

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeThanhTraTheoNgay(PMS.Common.Globals._cauhinh.TenTruong, dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), UserInfo.FullName, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null && cboDayNha.EditValue != null)
            {
                bindingSourceThongKe.DataSource = DataServices.ViewThanhTraTheoThoiKhoaBieu.ThongKeTheoNgayToaNha(dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), cboDayNha.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboCoSo_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitDayNha();
            Cursor.Current = Cursors.Default;
        }
    }
}