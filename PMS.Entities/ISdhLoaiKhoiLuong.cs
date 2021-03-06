﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'SdhLoaiKhoiLuong' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISdhLoaiKhoiLuong 
	{
		/// <summary>			
		/// MaLoaiKhoiLuong : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SdhLoaiKhoiLuong"</remarks>
		System.String MaLoaiKhoiLuong { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalMaLoaiKhoiLuong { get; set; }
			
		
		
		/// <summary>
		/// MaNhom : 
		/// </summary>
		System.Int32?  MaNhom  { get; set; }
		
		/// <summary>
		/// TenLoaiKhoiLuong : 
		/// </summary>
		System.String  TenLoaiKhoiLuong  { get; set; }
		
		/// <summary>
		/// NghiaVu : 
		/// </summary>
		System.Boolean?  NghiaVu  { get; set; }
		
		/// <summary>
		/// HeSo : 
		/// </summary>
		System.Decimal?  HeSo  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


