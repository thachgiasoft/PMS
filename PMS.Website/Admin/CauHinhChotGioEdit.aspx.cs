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

public partial class CauHinhChotGioEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "CauHinhChotGioEdit.aspx?{0}", CauHinhChotGioDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "CauHinhChotGioEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "CauHinhChotGio.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaCauHinhChotGio");
	}
	protected void GridViewKhoiLuongGiangDayCaoDang1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaKhoiLuongCaoDang={0}", GridViewKhoiLuongGiangDayCaoDang1.SelectedDataKey.Values[0]);
		Response.Redirect("KhoiLuongGiangDayCaoDangEdit.aspx?" + urlParams, true);		
	}	
}


