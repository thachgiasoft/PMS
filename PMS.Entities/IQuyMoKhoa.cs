﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'QuyMoKhoa' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IQuyMoKhoa 
	{
		/// <summary>			
		/// MaKhoa : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "QuyMoKhoa"</remarks>
		System.String MaKhoa { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalMaKhoa { get; set; }
			
		
		
		/// <summary>
		/// IdQuyMo : 
		/// </summary>
		System.Int32?  IdQuyMo  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


