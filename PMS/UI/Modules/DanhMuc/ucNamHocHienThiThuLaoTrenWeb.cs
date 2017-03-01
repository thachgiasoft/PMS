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
    public partial class ucNamHocHienThiThuLaoTrenWeb : DevExpress.XtraEditors.XtraUserControl
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

        public ucNamHocHienThiThuLaoTrenWeb()
        {
            InitializeComponent();
        }

        private void ucNamHocHienThiThuLaoTrenWeb_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewNamHoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false);
            AppGridView.ShowField(gridViewNamHoc, new string[] { "NamHoc", "HocKy", "Chon" }, new string[] { "Năm học", "Học kỳ", "Chọn" }, new int[] { 100, 100, 100 });
            AppGridView.AlignHeader(gridViewNamHoc, new string[] { "NamHoc", "HocKy", "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            //AppGridView.ReadOnlyColumn(gridViewNamHoc, new string[] { "_namHoc", "_hocKy" });
            AppGridView.RegisterControlField(gridViewNamHoc, "Chon", repositoryItemCheckEditChon);
            
            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.NamHocHienThiThuLaoLenWeb.Sel();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewNamHoc.FocusedRowHandle = -1;
            TList<NamHocHienThiThuLaoLenWeb> list = bindingSourceNamHoc.DataSource as TList<NamHocHienThiThuLaoLenWeb>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (NamHocHienThiThuLaoLenWeb cv in list)
                        {
                            if (cv.Chon == true)
                            {
                                xmlData += "<Input N=\"" + cv.NamHoc
                                            + "\" H=\"" + cv.HocKy
                                            + "\" />";
                            }
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";
                        bindingSourceNamHoc.EndEdit();

                        int kq = 0;
                        DataServices.NamHocHienThiThuLaoLenWeb.Luu(xmlData, ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
