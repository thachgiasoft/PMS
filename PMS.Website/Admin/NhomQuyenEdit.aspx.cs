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

public partial class NhomQuyenEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "NhomQuyenEdit.aspx?{0}", NhomQuyenDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "NhomQuyenEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "NhomQuyen.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaNhomQuyen");
	}
	protected void GridViewTaiKhoan1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaTaiKhoan={0}", GridViewTaiKhoan1.SelectedDataKey.Values[0]);
		Response.Redirect("TaiKhoanEdit.aspx?" + urlParams, true);		
	}	
}


