
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
	/// An component type implementation of the 'View_BacDaoTao' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ViewBacDaoTaoService : PMS.Services.ViewBacDaoTaoServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoService class.
		/// </summary>
		public ViewBacDaoTaoService() : base()
		{
		}
		
	}//End Class


} // end namespace
