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

public partial class ThuLaoGiangDayDaiHocLopClcEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "ThuLaoGiangDayDaiHocLopClcEdit.aspx?{0}", ThuLaoGiangDayDaiHocLopClcDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "ThuLaoGiangDayDaiHocLopClcEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "ThuLaoGiangDayDaiHocLopClc.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
}


