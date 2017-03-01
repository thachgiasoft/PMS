
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
	/// An component type implementation of the 'View_TongHop_GioDay' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ViewTongHopGioDayService : PMS.Services.ViewTongHopGioDayServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayService class.
		/// </summary>
		public ViewTongHopGioDayService() : base()
		{
		}
		
	}//End Class


} // end namespace
