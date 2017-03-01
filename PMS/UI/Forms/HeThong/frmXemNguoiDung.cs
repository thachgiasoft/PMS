using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using PMS.Entities;
using DevExpress.Common.Grid;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmXemNguoiDung : XtraForm
    {
        private int _userID = -1;

        public frmXemNguoiDung()
        {
            InitializeComponent();
        }

        public frmXemNguoiDung(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }

        private void InitData()
        {
            bindingSourceNguoiDung.DataSource = DataServices.TaiKhoan.GetAll();
            //Cap nhat lai user da chon
            TList<PMS.Entities.HeThong> listSystems = DataServices.HeThong.GetByUserId(_userID);
            TList<TaiKhoan> listUsers = bindingSourceNguoiDung.DataSource as TList<TaiKhoan>;
            if (listUsers != null)
            {
                foreach (TaiKhoan user in listUsers)
                {
                    if (listSystems.Exists(p => p.ParentId == user.MaTaiKhoan))
                        user.Chon = true;
                    else
                        user.Chon = false;
                }
            }
        }

        private void frmXemNguoiDung_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewNguoiDung, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewNguoiDung, new string[] { "TenDangNhap", "Chon" }, new string[] { "Tên truy cập", "Chọn" }, new int[] { 250, 70 });
            AppGridView.ReadOnlyColumn(gridViewNguoiDung, new string[] { "TenDangNhap" });
            AppGridView.AlignHeader(gridViewNguoiDung, new string[] { "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.UnSortField(gridViewNguoiDung, new string[] { "Chon" });
            InitData();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewNguoiDung.FocusedRowHandle = -1;
            TList<TaiKhoan> listAppUser = bindingSourceNguoiDung.DataSource as TList<TaiKhoan>;
            if (listAppUser != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bindingSourceNguoiDung.EndEdit();
                        TList<PMS.Entities.HeThong> listAppSystems = DataServices.HeThong.GetByUserId(_userID);
                        foreach (TaiKhoan user in listAppUser)
                        {
                            PMS.Entities.HeThong objHeThong = listAppSystems.Find(p => p.UserId == _userID && p.ParentId == user.MaTaiKhoan);
                            if (user.Chon)
                            {
                                if (objHeThong == null)
                                    listAppSystems.Add(new PMS.Entities.HeThong() { UserId = _userID, ParentId = user.MaTaiKhoan });
                            }
                            else
                            {
                                if (objHeThong != null)
                                    objHeThong.MarkToDelete();
                            }
                        }
                        if (listAppSystems.IsValid)
                        {
                            DataServices.HeThong.Save(listAppSystems);
                            DevExpress.XtraEditors.XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("Có {0} dòng dữ liệu không hợp lệ.", listAppSystems.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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