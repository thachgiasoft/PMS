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

public partial class KhoiLuongGiangDayCaoDangEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "KhoiLuongGiangDayCaoDangEdit.aspx?{0}", KhoiLuongGiangDayCaoDangDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "KhoiLuongGiangDayCaoDangEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "KhoiLuongGiangDayCaoDang.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaKhoiLuongCaoDang");
	}
	protected void GridViewKhoiLuongQuyDoiCaoDang1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaKhoiLuongQuyDoiCaoDang={0}", GridViewKhoiLuongQuyDoiCaoDang1.SelectedDataKey.Values[0]);
		Response.Redirect("KhoiLuongQuyDoiCaoDangEdit.aspx?" + urlParams, true);		
	}	
}


