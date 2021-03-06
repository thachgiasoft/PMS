﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'KetQuaTinhTheoTuan' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IKetQuaTinhTheoTuan 
	{
		/// <summary>			
		/// MaKetQua : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "KetQuaTinhTheoTuan"</remarks>
		System.Int32 MaKetQua { get; set; }
				
		
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		System.Int32?  MaGiangVien  { get; set; }
		
		/// <summary>
		/// TietNghiaVu : 
		/// </summary>
		System.Int32?  TietNghiaVu  { get; set; }
		
		/// <summary>
		/// TietGioiHan : 
		/// </summary>
		System.Int32?  TietGioiHan  { get; set; }
		
		/// <summary>
		/// NgayTao : 
		/// </summary>
		System.DateTime?  NgayTao  { get; set; }
		
		/// <summary>
		/// Tuan : 
		/// </summary>
		System.Int32?  Tuan  { get; set; }
		
		/// <summary>
		/// Nam : 
		/// </summary>
		System.Int32?  Nam  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


