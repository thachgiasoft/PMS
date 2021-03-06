﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'CauHinhGiangVienPhanHoi' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICauHinhGiangVienPhanHoi 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "CauHinhGiangVienPhanHoi"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaCauHinh : 
		/// </summary>
		System.String  MaCauHinh  { get; set; }
		
		/// <summary>
		/// TenCauHinh : 
		/// </summary>
		System.String  TenCauHinh  { get; set; }
		
		/// <summary>
		/// NoiDung : 
		/// </summary>
		System.String  NoiDung  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.DateTime?  NgayCapNhat  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


