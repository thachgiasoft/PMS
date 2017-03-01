
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
	/// An component type implementation of the 'VaiTro' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class VaiTroService : PMS.Services.VaiTroServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the VaiTroService class.
		/// </summary>
		public VaiTroService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
