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

public partial class KhoiLuongCacCongViecKhacEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "KhoiLuongCacCongViecKhacEdit.aspx?{0}", KhoiLuongCacCongViecKhacDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "KhoiLuongCacCongViecKhacEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "KhoiLuongCacCongViecKhac.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
}


