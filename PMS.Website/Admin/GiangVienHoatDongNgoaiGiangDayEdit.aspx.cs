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

public partial class GiangVienHoatDongNgoaiGiangDayEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "GiangVienHoatDongNgoaiGiangDayEdit.aspx?{0}", GiangVienHoatDongNgoaiGiangDayDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "GiangVienHoatDongNgoaiGiangDayEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "GiangVienHoatDongNgoaiGiangDay.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaQuanLy");
	}
	protected void GridViewQuyDoiHoatDongNgoaiGiangDay1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaQuanLy={0}", GridViewQuyDoiHoatDongNgoaiGiangDay1.SelectedDataKey.Values[0]);
		Response.Redirect("QuyDoiHoatDongNgoaiGiangDayEdit.aspx?" + urlParams, true);		
	}	
}


