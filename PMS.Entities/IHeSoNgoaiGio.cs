﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'HeSoNgoaiGio' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IHeSoNgoaiGio 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "HeSoNgoaiGio"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// BacDaoTao : 
		/// </summary>
		System.String  BacDaoTao  { get; set; }
		
		/// <summary>
		/// LoaiHinhDaoTao : 
		/// </summary>
		System.String  LoaiHinhDaoTao  { get; set; }
		
		/// <summary>
		/// GioGiang : 
		/// </summary>
		System.String  GioGiang  { get; set; }
		
		/// <summary>
		/// HeSo : 
		/// </summary>
		System.Decimal?  HeSo  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.String  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		System.String  NguoiCapNhat  { get; set; }
		
		/// <summary>
		/// TietBatDau : 
		/// </summary>
		System.Int32?  TietBatDau  { get; set; }
		
		/// <summary>
		/// Thu : 
		/// </summary>
		System.String  Thu  { get; set; }
		
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


