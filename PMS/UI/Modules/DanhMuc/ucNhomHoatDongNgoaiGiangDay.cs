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
using DevExpress.XtraEditors.Controls;
//using Libraries.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucNhomHoatDongNgoaiGiangDay : DevExpress.XtraEditors.XtraUserControl
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

   //     DataTable _dtData;
        public ucNhomHoatDongNgoaiGiangDay()
        {
            InitializeComponent();
        }

        private void ucNhomHoatDongNgoaiGiangDay_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewHoatDongNgoaiGiangDay, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHoatDongNgoaiGiangDay, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHoatDongNgoaiGiangDay, new string[] { "MaNhom", "TenNhom", "GhiChu" }
                        , new string[] { "Mã nhóm hoạt động", "Tên nhóm hoạt động", "Ghi chú" }
                        , new int[] { 300, 100, 100});
            AppGridView.AlignHeader(gridViewHoatDongNgoaiGiangDay, new string[] { "MaNhom", "TenNhom", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            #endregion

            gridControlHoatDongNgoaiGiangDay.DataSource = null; gridControlHoatDongNgoaiGiangDay.DataMember = null;
            InitData();
        }

        #region InitData
        void InitData()
        {
            //_dtData = Libraries.BLL.DBComunication.GetTable("NhomHoatDongNgoaiGiangDay");
            //gridControlHoatDongNgoaiGiangDay.DataSource = _dtData;
            gridControlHoatDongNgoaiGiangDay.DataSource = DataServices.NhomHoatDongNgoaiGiangDay.GetAll();
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHoatDongNgoaiGiangDay);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewHoatDongNgoaiGiangDay.FocusedRowHandle = -1;
            TList<NhomHoatDongNgoaiGiangDay> _list = gridControlHoatDongNgoaiGiangDay.DataSource as TList<NhomHoatDongNgoaiGiangDay>;
            //if (_dtData != null)
            //{
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //if (!_dtData.HasErrors)
                    //{
                        try
                        {
                            //_dtData.save();
                            if (_list.IsValid)
                            {
                                DataServices.NhomHoatDongNgoaiGiangDay.Save(_list);
                                XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch 
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                   // }
                }
            //}
            Cursor.Current = Cursors.Default;
        }
        #endregion

        //#region Event GridView
        //private void gridViewHoatDongNgoaiGiangDay_KeyUp(object sender, KeyEventArgs e)
        //{
        //    AppGridView.DeleteSelectedRows(gridViewHoatDongNgoaiGiangDay, e);
        //}

        //private void gridViewHoatDongNgoaiGiangDay_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        //{
        //    //e.ExceptionMode = ExceptionMode.NoAction;
        //}
        //#endregion
    }
}
