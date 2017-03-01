﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'SoTietNckhChuyenSangNamSau' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISoTietNckhChuyenSangNamSau 
	{
		/// <summary>			
		/// id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SoTietNckhChuyenSangNamSau"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		System.Int32?  MaGiangVien  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// SoTietChuyenSangNamSau : 
		/// </summary>
		System.Int32?  SoTietChuyenSangNamSau  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

