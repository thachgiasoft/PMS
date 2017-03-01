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

public partial class HeSoBacDaoTaoEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "HeSoBacDaoTaoEdit.aspx?{0}", HeSoBacDaoTaoDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "HeSoBacDaoTaoEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "HeSoBacDaoTao.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaHeSo");
	}
	protected void GridViewLopHocPhanBacDaoTao1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaLopHocPhan={0}&MaHeSoBacDaoTao={1}", GridViewLopHocPhanBacDaoTao1.SelectedDataKey.Values[0], GridViewLopHocPhanBacDaoTao1.SelectedDataKey.Values[1]);
		Response.Redirect("LopHocPhanBacDaoTaoEdit.aspx?" + urlParams, true);		
	}	
}


