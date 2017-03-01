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

public partial class HocHamEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "HocHamEdit.aspx?{0}", HocHamDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "HocHamEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "HocHam.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaHocHam");
	}
	protected void GridViewHeSoChucDanhTietNghiaVu1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaHeSo={0}", GridViewHeSoChucDanhTietNghiaVu1.SelectedDataKey.Values[0]);
		Response.Redirect("HeSoChucDanhTietNghiaVuEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewDonGia2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewDonGia2.SelectedDataKey.Values[0]);
		Response.Redirect("DonGiaEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewQuyDinhTienCanTren3_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewQuyDinhTienCanTren3.SelectedDataKey.Values[0]);
		Response.Redirect("QuyDinhTienCanTrenEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewGiangVien4_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaGiangVien={0}", GridViewGiangVien4.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienEdit.aspx?" + urlParams, true);		
	}	
}


