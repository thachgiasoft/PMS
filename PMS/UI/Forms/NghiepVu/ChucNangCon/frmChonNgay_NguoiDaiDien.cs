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

namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    public partial class frmChonNgay_NguoiDaiDien : DevExpress.XtraEditors.XtraForm
    {
        public DateTime NgayIn;
        public string NguoiDaiDien;
        public string TenChucVu = "";
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();

        public frmChonNgay_NguoiDaiDien()
        {
            InitializeComponent();
        }

        private void frmChonNgay_NguoiDaiDien_Load(object sender, EventArgs e)
        {
            dateEditChonNgay.DateTime = DateTime.Now;

            AppGridLookupEdit.InitGridLookUp(cboNguoiDaiDien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNguoiDaiDien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị" }, new int[] { 90, 160, 200 });
            AppGridLookupEdit.InitPopupFormSize(cboNguoiDaiDien, 450, 650);
            cboNguoiDaiDien.Properties.DisplayMember = "HoTen";
            cboNguoiDaiDien.Properties.ValueMember = "MaGiangVien";
            cboNguoiDaiDien.Properties.NullText = string.Empty;

            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();

            if (_cauHinhChung != null)
            {
                cboNguoiDaiDien.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Người đại diện mời giảng").GiaTri;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            NgayIn = dateEditChonNgay.DateTime;
            NguoiDaiDien = cboNguoiDaiDien.Text;
            Close();
        }

        private void cboNguoiDaiDien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CauHinhChung objCauHinh = _cauHinhChung.Find(p => p.TenCauHinh == "Người đại diện mời giảng");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != cboNguoiDaiDien.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = cboNguoiDaiDien.EditValue.ToString();
                }

                DataServices.CauHinhChung.Save(objCauHinh);

                DataServices.GiangVien.GetChucVuByMaGiangVienNgay(int.Parse(cboNguoiDaiDien.EditValue.ToString()), dateEditChonNgay.DateTime, ref TenChucVu);
            }
            catch
            { }
            
        }
    }
}