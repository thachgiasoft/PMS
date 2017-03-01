
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
	/// An component type implementation of the 'view_PhanNhomMonHoc' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ViewPhanNhomMonHocService : PMS.Services.ViewPhanNhomMonHocServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocService class.
		/// </summary>
		public ViewPhanNhomMonHocService() : base()
		{
		}
		
	}//End Class


} // end namespace
