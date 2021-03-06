﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'MonTinhTheoQuyCheMoi' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IMonTinhTheoQuyCheMoi 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "MonTinhTheoQuyCheMoi"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		System.String  MaMonHoc  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.String  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		System.String  NguoiCapNhat  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


