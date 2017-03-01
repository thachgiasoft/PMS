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

public partial class KetQuaTinhEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "KetQuaTinhEdit.aspx?{0}", KetQuaTinhDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "KetQuaTinhEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "KetQuaTinh.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaKetQua");
	}
	protected void GridViewKhoiLuongGiangDay1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaKhoiLuong={0}", GridViewKhoiLuongGiangDay1.SelectedDataKey.Values[0]);
		Response.Redirect("KhoiLuongGiangDayEdit.aspx?" + urlParams, true);		
	}	
}


