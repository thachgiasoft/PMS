﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'HeSoChucDanhKhoiLuongKhac' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IHeSoChucDanhKhoiLuongKhac 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "HeSoChucDanhKhoiLuongKhac"</remarks>
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
		/// MaKhoiLuong : 
		/// </summary>
		System.Int32?  MaKhoiLuong  { get; set; }
		
		/// <summary>
		/// MaHocHam : 
		/// </summary>
		System.Int32?  MaHocHam  { get; set; }
		
		/// <summary>
		/// MaHocVi : 
		/// </summary>
		System.Int32?  MaHocVi  { get; set; }
		
		/// <summary>
		/// HeSo : 
		/// </summary>
		System.Decimal?  HeSo  { get; set; }
		
		/// <summary>
		/// Stt : 
		/// </summary>
		System.Int32?  Stt  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


