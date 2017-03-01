
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using PMS.Entities;
using PMS.Entities.Validation;

using PMS.Data;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace PMS.Services
{		
	
	///<summary>
	/// An component type implementation of the 'v_KhoiLuong_ThucDay' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class VKhoiLuongThucDayService : PMS.Services.VKhoiLuongThucDayServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the VKhoiLuongThucDayService class.
		/// </summary>
		public VKhoiLuongThucDayService() : base()
		{
		}
		
	}//End Class


} // end namespace
