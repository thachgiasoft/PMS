
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
	/// <summary>
	/// An component type implementation of the 'ThuLaoCoiThiVhu' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ThuLaoCoiThiVhuService : PMS.Services.ThuLaoCoiThiVhuServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuService class.
		/// </summary>
		public ThuLaoCoiThiVhuService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
