using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;

namespace PMS.Common
{
    public static class Cbo
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataService.CauHinhChung.GetAll();
        #endregion
        public static void InitNamHoc(GridLookUpEdit cboNamHoc,)
        {
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
        }
    }
}
