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

public partial class HeSoCongViecEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "HeSoCongViecEdit.aspx?{0}", HeSoCongViecDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "HeSoCongViecEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "HeSoCongViec.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaHeSo");
	}
	protected void GridViewThucGiangMonThucTeTuHoc1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaQuanLy={0}", GridViewThucGiangMonThucTeTuHoc1.SelectedDataKey.Values[0]);
		Response.Redirect("ThucGiangMonThucTeTuHocEdit.aspx?" + urlParams, true);		
	}	
}


