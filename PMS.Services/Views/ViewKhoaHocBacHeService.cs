
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
	/// An component type implementation of the 'View_KhoaHoc_Bac_He' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ViewKhoaHocBacHeService : PMS.Services.ViewKhoaHocBacHeServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeService class.
		/// </summary>
		public ViewKhoaHocBacHeService() : base()
		{
		}
		
	}//End Class


} // end namespace
