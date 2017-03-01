using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChotThanhToanThuLao : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        TList<ChotKhoiLuongGiangDay> _listChot;
        #endregion
        public frmChotThanhToanThuLao()
        {
            InitializeComponent();
        }

        private void frmChotThanhToanThuLao_Load(object sender, EventArgs e)
        {
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            LoadCauHinh();
        }
        #region LoadCauHinh
        private void LoadCauHinh()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if(cboNamHoc.EditValue!=null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listChot = DataServices.ChotKhoiLuongGiangDay.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                if (_listChot.Count > 0)
                {
                    ChotKhoiLuongGiangDay _chot = _listChot[0];
                    checkEditLyThuyetThucHanh.Checked = (bool)_chot.LyThuyetThucHanh;
                    checkEditDoAnMonHoc.Checked = (bool)_chot.DoAnMonHoc;
                    checkEditDoAnTotNghiep.Checked = (bool)_chot.DoAnTotNghiep;
                    checkEditKhoiLuongKhac.Checked = (bool)_chot.KhoiLuongKhac;
                }
                else
                {
                    checkEditLyThuyetThucHanh.Checked = false;
                    checkEditDoAnMonHoc.Checked = false;
                    checkEditDoAnTotNghiep.Checked = false;
                    checkEditKhoiLuongKhac.Checked = false;
                }
            }
        }

        #endregion

        #region EventButton
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadCauHinh();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string xmlData = "";
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                xmlData = "<Root><ChotKLGD NamHoc=\"" + cboNamHoc.EditValue.ToString()
                                + "\" HocKy=\"" + cboHocKy.EditValue.ToString()
                                + "\" LTTH=\"" + checkEditLyThuyetThucHanh.Checked.ToString()
                                + "\" DAMH=\"" + checkEditDoAnMonHoc.Checked.ToString()
                                + "\" DATN=\"" + checkEditDoAnTotNghiep.Checked.ToString()
                                + "\" KLK=\"" + checkEditKhoiLuongKhac.Checked.ToString()
                                + "\" /></Root>";
                int kq = 0;
                DataServices.ChotKhoiLuongGiangDay.Luu(xmlData, ref kq);
                if (kq == 0)
                    XtraMessageBox.Show("Chốt khối lượng giảng dạy thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt khối lượng giảng dạy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

   

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa.Checked)
            {
                checkEditLyThuyetThucHanh.Checked = true;
                checkEditDoAnMonHoc.Checked = true;
                checkEditDoAnTotNghiep.Checked = true;
                checkEditKhoiLuongKhac.Checked = true;
            }
            else
            {
                checkEditLyThuyetThucHanh.Checked = false;
                checkEditDoAnMonHoc.Checked = false;
                checkEditDoAnTotNghiep.Checked = false;
                checkEditKhoiLuongKhac.Checked = false;
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listChot = DataServices.ChotKhoiLuongGiangDay.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                if (_listChot.Count > 0)
                {
                    ChotKhoiLuongGiangDay _chot = _listChot[0];
                    checkEditLyThuyetThucHanh.Checked = (bool)_chot.LyThuyetThucHanh;
                    checkEditDoAnMonHoc.Checked = (bool)_chot.DoAnMonHoc;
                    checkEditDoAnTotNghiep.Checked = (bool)_chot.DoAnTotNghiep;
                    checkEditKhoiLuongKhac.Checked = (bool)_chot.KhoiLuongKhac;
                }
                else
                {
                    checkEditLyThuyetThucHanh.Checked = false;
                    checkEditDoAnMonHoc.Checked = false;
                    checkEditDoAnTotNghiep.Checked = false;
                    checkEditKhoiLuongKhac.Checked = false;
                }
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listChot = DataServices.ChotKhoiLuongGiangDay.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                if (_listChot.Count > 0)
                {
                    ChotKhoiLuongGiangDay _chot = _listChot[0];
                    checkEditLyThuyetThucHanh.Checked = (bool)_chot.LyThuyetThucHanh;
                    checkEditDoAnMonHoc.Checked = (bool)_chot.DoAnMonHoc;
                    checkEditDoAnTotNghiep.Checked = (bool)_chot.DoAnTotNghiep;
                    checkEditKhoiLuongKhac.Checked = (bool)_chot.KhoiLuongKhac;
                }
                else
                {
                    checkEditLyThuyetThucHanh.Checked = false;
                    checkEditDoAnMonHoc.Checked = false;
                    checkEditDoAnTotNghiep.Checked = false;
                    checkEditKhoiLuongKhac.Checked = false;
                }
            }
        }

        private void checkEditLyThuyetThucHanh_CheckedChanged(object sender, EventArgs e)
        {
            //if (((CheckEdit)sender).Checked == false)
            //    checkEditChonTatCa.Checked = false;
        }
    }
}