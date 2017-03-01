using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using PMS.BLL;
using DevExpress.XtraGrid.Columns;


namespace PMS.UI.Modules.Messages
{
    public partial class frmSendMessages : DevExpress.XtraEditors.XtraForm
    {

        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDanhSachGV.Enabled = false;
                btnGoiTinNhan.Enabled = false;
            }
            else
            {
                btnDanhSachGV.Enabled = true;
                btnGoiTinNhan.Enabled = true;
            }
        }
        #endregion

        string dsnhan_magiangvien;

        public frmSendMessages()
        {
            InitializeComponent();
        }

        private void btnDanhSachGV_Click(object sender, EventArgs e)
        {
            using (frmChonGiangVien frm = new frmChonGiangVien())
            {
                frm.ShowDialog();
                txtNguoiNhan.Text = frm.dsnhan;
                dsnhan_magiangvien = frm.dsnhan_magv;
            }
        }

        void ClearForm()
        {
            txtNguoiNhan.Text = string.Empty;
            richEditControl1.Document.Text = "";
            txtTieuDe.Text = string.Empty;
            dsnhan_magiangvien = "";
        }

        private void btnGoiTinNhan_Click(object sender, EventArgs e)
        {
            
            if (XtraMessageBox.Show("Bạn có muốn gởi tin nhắn không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;          
                    try
                    {
                        string textContain = richEditControl1.Document.HtmlText;
                        int kq = 0;
                        if (txtTieuDe.Text.ToString() != "" && textContain != "" && dsnhan_magiangvien != "")
                        {
                            DataServices.GiangVien.LuuTinNhan(txtTieuDe.Text, dsnhan_magiangvien, textContain, UserInfo.UserName, ref kq);
                        }
                        else
                        {
                            XtraMessageBox.Show("Chưa nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        if (kq == 0)
                        {
                            XtraMessageBox.Show("Bạn đã gởi tin nhắn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình gởi tin nhắn. Kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình gởi tin nhắn. Kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                
                
       
                Cursor.Current = Cursors.Default;
            }
        }
    }
}


