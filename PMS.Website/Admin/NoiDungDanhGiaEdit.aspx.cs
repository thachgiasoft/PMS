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

public partial class NoiDungDanhGiaEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "NoiDungDanhGiaEdit.aspx?{0}", NoiDungDanhGiaDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "NoiDungDanhGiaEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "NoiDungDanhGia.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaQuanLy");
	}
	protected void GridViewKetQuaDanhGiaVuotGio1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewKetQuaDanhGiaVuotGio1.SelectedDataKey.Values[0]);
		Response.Redirect("KetQuaDanhGiaVuotGioEdit.aspx?" + urlParams, true);		
	}	
}


