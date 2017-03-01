#region Imports...
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using PMS.Web.UI;
#endregion

public partial class HeSoNgonNguEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "HeSoNgonNguEdit.aspx?{0}", HeSoNgonNguDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "HeSoNgonNguEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "HeSoNgonNgu.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaHeSo");
	}
	protected void GridViewGiangVienLopHocPhan1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaGiangVien={0}&MaLopHocPhan={1}", GridViewGiangVienLopHocPhan1.SelectedDataKey.Values[0], GridViewGiangVienLopHocPhan1.SelectedDataKey.Values[1]);
		Response.Redirect("GiangVienLopHocPhanEdit.aspx?" + urlParams, true);		
	}	
}


