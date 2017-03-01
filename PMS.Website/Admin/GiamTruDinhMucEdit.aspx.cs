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

public partial class GiamTruDinhMucEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "GiamTruDinhMucEdit.aspx?{0}", GiamTruDinhMucDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "GiamTruDinhMucEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "GiamTruDinhMuc.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaQuanLy");
	}
	protected void GridViewGiangVienGiamTruDinhMuc1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaQuanLy={0}", GridViewGiangVienGiamTruDinhMuc1.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienGiamTruDinhMucEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewTietNghiaVu2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewTietNghiaVu2.SelectedDataKey.Values[0]);
		Response.Redirect("TietNghiaVuEdit.aspx?" + urlParams, true);		
	}	
}


