﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'HeSoKhoiNganh' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IHeSoKhoiNganh 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "HeSoKhoiNganh"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaKhoiNganh : 
		/// </summary>
		System.String  MaKhoiNganh  { get; set; }
		
		/// <summary>
		/// SiSo : 
		/// </summary>
		System.Int32  SiSo  { get; set; }
		
		/// <summary>
		/// HeSo : 
		/// </summary>
		System.Decimal?  HeSo  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// TenKhoiNganh : 
		/// </summary>
		System.String  TenKhoiNganh  { get; set; }
		
		/// <summary>
		/// NhomKhoiNganh : 
		/// </summary>
		System.String  NhomKhoiNganh  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// HeSoThucHanh : 
		/// </summary>
		System.Decimal?  HeSoThucHanh  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


