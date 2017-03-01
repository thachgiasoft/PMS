﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'CauHinhChung' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICauHinhChung 
	{
		/// <summary>			
		/// MaCauHinh : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "CauHinhChung"</remarks>
		System.Int32 MaCauHinh { get; set; }
				
		
		
		/// <summary>
		/// TenCauHinh : 
		/// </summary>
		System.String  TenCauHinh  { get; set; }
		
		/// <summary>
		/// GiaTri : 
		/// </summary>
		System.String  GiaTri  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.DateTime?  NgayCapNhat  { get; set; }
		
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


