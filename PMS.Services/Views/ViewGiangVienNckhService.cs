
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
	/// An component type implementation of the 'View_GiangVien_Nckh' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ViewGiangVienNckhService : PMS.Services.ViewGiangVienNckhServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNckhService class.
		/// </summary>
		public ViewGiangVienNckhService() : base()
		{
		}
		
	}//End Class


} // end namespace
