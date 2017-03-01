
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
	/// An component type implementation of the 'View_GiangVien_ChamThi_Lan2' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ViewGiangVienChamThiLan2Service : PMS.Services.ViewGiangVienChamThiLan2ServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the ViewGiangVienChamThiLan2Service class.
		/// </summary>
		public ViewGiangVienChamThiLan2Service() : base()
		{
		}
		
	}//End Class


} // end namespace
