using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu.KhongChinhQuy
{
    public partial class frmHuyChotThuLao_Kcq : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        string NamHoc, HocKy;
        int LanChot;
        #endregion
        public frmHuyChotThuLao_Kcq()
        {
            InitializeComponent();
        }

        public frmHuyChotThuLao_Kcq(string _namHoc, string _hocKy, int _lanChot)
        {
            InitializeComponent();
            NamHoc = _namHoc;
            HocKy = _hocKy;
            LanChot = _lanChot;
        }

        private void frmHuyChotThuLao_Load(object sender, EventArgs e)
        {
            txtLanChot.Text = LanChot.ToString();
            //#region _lanChot
            //AppGridLookupEdit.InitGridLookUp(cboLanChot, true, TextEditStyles.Standard);
            //AppGridLookupEdit.ShowField(cboLanChot, new string[] { "_lanChot" }, new string[] { "Lần chốt" });
            //cboLanChot.Properties.ValueMember = "_lanChot";
            //cboLanChot.Properties.DisplayMember = "_lanChot";
            //cboLanChot.Properties.NullText = string.Empty;
            //#endregion
            //InitLanChot();
        }

        //void InitLanChot()
        //{
        //    if (_namHoc != "" && _hocKy != "")
        //    {
        //        DataServices.KetQuaThanhToanThuLao.GetSoLanChot(_namHoc, _hocKy, ref lanchot);
        //        DataTable tblLanChot = new DataTable();
        //        tblLanChot.Columns.Add("_lanChot");
        //        if (lanchot > 0)
        //        {
        //            for (int i = 1; i <= lanchot; i++)
        //            {
        //                tblLanChot.Rows.Add(new string[] { i.ToString() });
        //            }
        //        }
        //        bindingSourceLanChot.DataSource = tblLanChot;
        //    }
        //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == UserInfo.User.MatKhau || PMS.Common.Globals.EncodeMD5(UserInfo.UserName, txtMatKhau.Text) == UserInfo.User.MatKhau)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt thanh toán lần thứ {0} năm học {1} - {2}", LanChot.ToString(), NamHoc, HocKy), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;
                    DataServices.KcqKetQuaThanhToanThuLao.HuyChotThuLao(NamHoc, HocKy, LanChot, ref kq);
                    if (kq == 0)
                    {
                        XtraMessageBox.Show("Huỷ thành công, thoát giao diện huỷ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        XtraMessageBox.Show("Thao tác huỷ thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Sai mật khẩu. Vui lòng nhập đúng mật khẩu người dùng đang đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
            }
        }
    }
}