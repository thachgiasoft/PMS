using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucCongThuc : DevExpress.XtraEditors.XtraUserControl
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

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        
        TList<CongThuc> _listCongThuc = new TList<CongThuc>();
        #endregion
        public ucCongThuc()
        {
            InitializeComponent();
        }

        private void ucCongThuc_Load(object sender, EventArgs e)
        {
            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            LoadData();
        }

        void LoadData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            if (cboNamHoc.EditValue != null)
            {
                _listCongThuc = DataServices.CongThuc.GetbyNamHoc(cboNamHoc.EditValue.ToString());

                if (_listCongThuc.Count > 0)
                {
                    spinEditC1.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[0].Col01, "decimal").ToString());
                    spinEditC2.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[0].Col02, "decimal").ToString());
                    spinEditC3.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[0].Col03, "decimal").ToString());
                    spinEditC4.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[0].Col04, "decimal").ToString());

                    spinEditG1.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[1].Col01, "decimal").ToString());
                    spinEditG2.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[1].Col02, "decimal").ToString());
                    spinEditG3.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[1].Col03, "decimal").ToString());
                    spinEditG4.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[1].Col04, "decimal").ToString());

                    spinEditT1.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[2].Col01, "decimal").ToString());
                    spinEditT2.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[2].Col02, "decimal").ToString());
                    spinEditT3.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[2].Col03, "decimal").ToString());
                    spinEditT4.Value = (decimal)float.Parse(PMS.Common.Globals.IsNull(_listCongThuc[2].Col04, "decimal").ToString());
                }
                else
                {
                    spinEditC1.Value = 0;
                    spinEditC2.Value = 0;
                    spinEditC3.Value = 0;
                    spinEditC4.Value = 0;

                    spinEditG1.Value = 0;
                    spinEditG2.Value = 0;
                    spinEditG3.Value = 0;
                    spinEditG4.Value = 0;

                    spinEditT1.Value = 0;
                    spinEditT2.Value = 0;
                    spinEditT3.Value = 0;
                    spinEditT4.Value = 0;
                }
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadData();
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _listCongThuc[0].Col01 = spinEditC1.Value;
            _listCongThuc[0].Col02 = spinEditC2.Value;
            _listCongThuc[0].Col03 = spinEditC3.Value;
            _listCongThuc[0].Col04 = spinEditC4.Value;

            _listCongThuc[1].Col01 = spinEditG1.Value;
            _listCongThuc[1].Col02 = spinEditG2.Value;
            _listCongThuc[1].Col03 = spinEditG3.Value;
            _listCongThuc[1].Col04 = spinEditG4.Value;

            _listCongThuc[2].Col01 = spinEditT1.Value;
            _listCongThuc[2].Col02 = spinEditT2.Value;
            _listCongThuc[2].Col03 = spinEditT3.Value;
            _listCongThuc[2].Col04 = spinEditT4.Value;

            if (_listCongThuc != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn lưu công thức tính hệ số A1 năm học {0}", cboNamHoc.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DataServices.CongThuc.Save(_listCongThuc);
                        XtraMessageBox.Show("Lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}