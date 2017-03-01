﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'DonGiaCoiThi' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IDonGiaCoiThi 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "DonGiaCoiThi"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// MaKyThi : 
		/// </summary>
		System.String  MaKyThi  { get; set; }
		
		/// <summary>
		/// MaCoSo : 
		/// </summary>
		System.String  MaCoSo  { get; set; }
		
		/// <summary>
		/// CaThi : 
		/// </summary>
		System.String  CaThi  { get; set; }
		
		/// <summary>
		/// ThoiGianCoiThi : 
		/// </summary>
		System.String  ThoiGianCoiThi  { get; set; }
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		System.Decimal?  DonGia  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		System.String  NguoiCapNhat  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.String  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


