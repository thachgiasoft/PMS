
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
	/// An component type implementation of the 'View_TietGiangDay' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ViewTietGiangDayService : PMS.Services.ViewTietGiangDayServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the ViewTietGiangDayService class.
		/// </summary>
		public ViewTietGiangDayService() : base()
		{
		}
		
	}//End Class


} // end namespace
