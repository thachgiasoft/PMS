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

public partial class TinhTrangEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "TinhTrangEdit.aspx?{0}", TinhTrangDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "TinhTrangEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "TinhTrang.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaTinhTrang");
	}
	protected void GridViewGiangVien1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaGiangVien={0}", GridViewGiangVien1.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienEdit.aspx?" + urlParams, true);		
	}	
}


