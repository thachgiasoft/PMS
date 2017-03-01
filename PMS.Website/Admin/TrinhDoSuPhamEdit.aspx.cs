﻿#region Imports...
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

public partial class TrinhDoSuPhamEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "TrinhDoSuPhamEdit.aspx?{0}", TrinhDoSuPhamDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "TrinhDoSuPhamEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "TrinhDoSuPham.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaTrinhDoSuPham");
	}
	protected void GridViewGiangVien1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaGiangVien={0}", GridViewGiangVien1.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienEdit.aspx?" + urlParams, true);		
	}	
}


